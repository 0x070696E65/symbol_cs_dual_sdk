from ..DisplayType import DisplayType

# region build_factory_map


class FactoryDescriptor:
	"""Factory descriptor including list of concrete types."""

	def __init__(self, discriminator_names, discriminator_values, discriminator_types):
		"""Creates a factory descriptor."""
		self.discriminator_names = discriminator_names
		self.discriminator_values = discriminator_values
		self.discriminator_types = discriminator_types
		self.children = []


def build_factory_map(ast_models):
	"""Build a map that maps factory types to their concrete implementations."""
	factory_map = {}
	for ast_model in ast_models:
		if DisplayType.STRUCT != ast_model.display_type or not ast_model.factory_type:
			continue

		if ast_model.factory_type not in factory_map:
			discriminator_names = ast_model.discriminator
			discriminator_values = [
				# need values to match name ordering
				next(initializer.value for initializer in ast_model.initializers if discriminator_name == initializer.target_property_name)
				for discriminator_name in discriminator_names
			]
			discriminator_types = [
				next(field.field_type for field in ast_model.fields if discriminator_name == field.name)
				for discriminator_name in discriminator_names
			]

			factory_map[ast_model.factory_type] = FactoryDescriptor(discriminator_names, discriminator_values, discriminator_types)

		factory_map[ast_model.factory_type].children.append(ast_model)

	return factory_map


# endregion

# region extend_models

class AstFieldExtensions:
	"""AST extensions attached to struct field models."""

	def __init__(self, type_model, printer):
		self.type_model = type_model
		self.printer = printer

		self.is_contents_abstract = False
		self.bound_field = None
		self.size_fields = []


def _find_field_by_name(struct_model, field_name):
	return next(field_model for field_model in struct_model.fields if field_name == field_model.name)


def _bind_size_fields(struct_model):
	# go through structs and bind size fields to arrays
	for field_model in struct_model.fields:
		if field_model.display_type.is_array and isinstance(field_model.size, str):
			size_field_name = field_model.size
			size_field_model = _find_field_by_name(struct_model, size_field_name)
			size_field_model.extensions.bound_field = field_model

		if field_model.is_size_reference:
			struct_field_model = _find_field_by_name(struct_model, field_model.value)
			field_model.extensions.bound_field = struct_field_model
			struct_field_model.extensions.size_fields.append(field_model)


def _process_struct(struct_model, type_map, printer_factory):
	for field_model in struct_model.fields:
		type_model = type_map.get(field_model.field_type, None)

		is_pod = True
		is_contents_abstract = False
		if DisplayType.TYPED_ARRAY == field_model.display_type:
			element_type_model = type_map.get(field_model.field_type.element_type, None)
			is_contents_abstract = DisplayType.STRUCT == element_type_model.display_type and element_type_model.is_abstract

			# if the struct is unaligned but contains an aligned field,
			# set a `requires_unaligned` flag to trigger generation of unaligned serializers
			# for the field too
			if not struct_model.is_aligned and element_type_model.is_aligned:
				element_type_model.requires_unaligned = True

			type_model = field_model
		elif not type_model:
			type_model = field_model
		else:
			is_pod = False

		field_printer = printer_factory(type_model, field_model.name, is_pod)
		field_model.extensions = AstFieldExtensions(type_model, field_printer)
		field_model.extensions.is_contents_abstract = is_contents_abstract

	_bind_size_fields(struct_model)


class MarkedStructs:
	def __init__(self):
		self.already_marked = set()
		self.tracked = None

	def start(self):
		self.tracked = set()

	def add(self, value):
		destination = self.tracked if self.tracked is not None else self.already_marked

		# always check against already_marked set
		if value not in self.already_marked:
			destination.add(value)

	def finalize(self):
		self.already_marked.update(self.tracked)
		result = self.tracked
		self.tracked = None
		return result

	def __len__(self):
		return len(self.already_marked)


def _propagate_unaligned(struct_names, type_map):
	marked_structs = MarkedStructs()

	while True:
		previous_length = len(marked_structs)

		# mark derived objects
		marked_structs.start()
		for struct_name in struct_names:
			struct_model = type_map[struct_name]
			factory_type = type_map.get(struct_model.factory_type, None)
			if factory_type and factory_type.requires_unaligned:
				struct_model.requires_unaligned = True
				marked_structs.add(struct_name)

		newly_marked = marked_structs.finalize()

		# go through newly marked structs and check if any field type needs to be marked:
		for struct_name in newly_marked:
			struct_model = type_map[struct_name]
			for field_model in struct_model.fields:
				if field_model.display_type.is_array:
					raise RuntimeError(f'array field not handled in {struct_name}.{field_model.name}')

				type_model = type_map.get(field_model.field_type, None)
				if type_model and DisplayType.STRUCT == type_model.display_type:
					type_model.requires_unaligned = True
					marked_structs.add(type_model.name)

		if previous_length == len(marked_structs):
			break


def extend_models(ast_models, printer_factory):
	"""Adds extensions to all struct field models."""

	type_map = {ast_model.name: ast_model for ast_model in ast_models}
	struct_names = set()

	for ast_model in ast_models:
		if DisplayType.STRUCT == ast_model.display_type:
			_process_struct(ast_model, type_map, printer_factory)
			struct_names.add(ast_model.name)

	# second pass, mark derived structs as also requiring unaligned
	_propagate_unaligned(struct_names, type_map)

# endregion
