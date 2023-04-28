from itertools import filterfalse
from Generator.printers import Printer, ArrayPrinter

from catparser.DisplayType import DisplayType

from .AbstractTypeFormatter import AbstractTypeFormatter, MethodDescriptor
from .format import indent
from .name_formatting import fix_size_name, lang_field_name, pascal_name


def is_reserved(field):
	return 'reserved' == field.disposition


def is_bound_size(field):
	return field.extensions.bound_field is not None


def is_const(field):
	return field.is_const

def is_computed(field):
	return hasattr(field.field_type, 'sizeref') and field.field_type.sizeref

def create_temporary_buffer_name(name):
	return f'{name}_condition'


def indent_if_conditional(condition, statements):
	if not condition:
		return statements

	if '\n' not in statements[:-1]:
		return f'{condition}\n{indent(statements)}\n'

	return f'{condition} {{\n{indent(statements)}}}\n'


def filter_size_if_first(fields_iter):
	first_field = next(fields_iter, None)
	if 'size' == first_field.name:
		pass
	else:
		yield first_field

	for field in fields_iter:
		yield field


class StructFormatter(AbstractTypeFormatter):
	# pylint: disable=too-many-public-methods

	def __init__(self, ast_model):
		super().__init__()

		self.struct = ast_model

	def non_const_fields(self):
		return filterfalse(is_const, self.struct.fields)

	def const_fields(self):
		return filter(is_const, self.struct.fields)

	def non_reserved_fields(self):
		return filter_size_if_first(filterfalse(is_bound_size, filterfalse(is_reserved, self.non_const_fields())))

	def reserved_fields(self):
		return filter(is_reserved, self.non_const_fields())

	@property
	def typename(self):
		return self.struct.name

	def field_name(self, field, object_name='this'):
		name = pascal_name(field.extensions.printer.name)
		if "Message" == name and "Message" == self.typename:
			name = "MessageField"
		return name

	@staticmethod
	def generate_class_field(field):
		modifier = field.extensions.printer.get_modifier(field.name)
		default_value = field.extensions.printer.assign(field.value)
		return f'{modifier}{field.name} = {default_value};\n'

	@property
	def _is_struct(self):
		return self.struct.display_type.STRUCT

	#@property
	#def provider_type(self):
	#	return 'struct'

	def generate_type_hints(self):
		body = 'public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){\n'
		hints = []
		for field in self.non_reserved_fields():
			if not field.extensions.printer.type_hint:
				continue
			hints.append('{"' + field.extensions.printer.name[:1].upper() + field.extensions.printer.name[1:] + '", "' + field.extensions.printer.type_hint + '"}')

		body += indent(',\n'.join(hints))
		body += '};\n'
		return body

	def get_base_class(self):
		base_transaction = ''
		if 'Transaction' in self.typename:
			if 'Embedded' in self.typename or 'NonVerifiable' in self.typename:
				base_transaction = 'IBaseTransaction'
			else:
				base_transaction = 'ITransaction'
		else:
			for i in self.get_fields():
				if "TransactionType" in i:
					base_transaction = 'ITransaction'
				else:
					base_transaction = 'IStruct'
		if 'Statement' in self.typename:
			base_transaction = 'ISerializer'
		return base_transaction if self._is_struct else None

	def get_fields(self):
		return list(map(self.generate_class_field, self.const_fields())) + [self.get_reserved_fields(), self.generate_type_hints()]

	def get_reserved_fields(self):
		fields = ''
		for field in self.reserved_fields():
			fields += f'private readonly int {self.field_name(field)};\n'
		return fields

	def get_property(self):
		properties = ''
		for field in self.non_reserved_fields():
			const_field = self.get_paired_const_field(field)
			if not const_field:
				properties += f'public {field.extensions.printer.get_type()} {self.field_name(field)} {{ get; set; }}\n'

		properties += '\n'

		for field in self.non_reserved_fields():
			const_field = self.get_paired_const_field(field)
			if const_field:
				properties += f'private {field.extensions.printer.get_type()} {self.field_name(field)};\n'
		
		return properties

	def get_paired_const_field(self, field):
		for const_field in self.const_fields():
			if const_field.name.lower().endswith(field.name):
				return const_field
		return None

	def get_ctor_descriptor(self):
		arguments = []

		body = ''
		for field in self.non_reserved_fields():
			const_field = self.get_paired_const_field(field)
			field_name = self.field_name(field)
			if const_field:
				body += f'{field_name} = {const_field.name};\n'
			else:
				body += f'{field_name} = {field.extensions.printer.get_default_value()};\n'

		body += '\n'.join(
			map(
				lambda field: f'{self.field_name(field)} = {field.value}; // reserved field',
				self.reserved_fields()
			)
		)

		if not body:
			return None

		return MethodDescriptor(body=body, arguments=arguments)

	def get_comparer_descriptor(self):
		if not self.struct.comparer:
			return None

		body = 'return [\n'
		for (property_name, transform) in self.struct.comparer:
			body += '\t'
			if not transform:
				body += f'this.{lang_field_name(property_name)}'
			else:
				body += f'{lang_field_name(transform).replace("_", "")}(this.{lang_field_name(property_name)}.bytes)'

			body += ',\n'

		body = body[:-2]  # strip trailing comma
		body += '\n];'

		return MethodDescriptor(body=body)

	def generate_condition(self, field, prefix_field=False):
		if not field.is_conditional:
			return ''

		conditional = field.value
		condition_field_name = conditional.linked_field_name

		# find condition field type
		condition_field = next(f for f in self.non_const_fields() if condition_field_name == f.name)
		condition_to_operator_map = {
			'equals': '==',
			'not equals': '!=',
			'not in': '!',
			'in': '',
		}
		condition_operator = condition_to_operator_map[conditional.operation]

		value = f'{conditional.value}'
		condition_model = condition_field.extensions.type_model
		yoda_value = value if DisplayType.INTEGER == condition_model.display_type else f'{condition_model.name}.{value}'
		#field_prefix = 'this.' if prefix_field else ''

		# HACK: instead of handling dumb magic value in namespace parent_name, generate slightly simpler condition
		if prefix_field and DisplayType.UNSET != field.display_type:
			return f'if ({pascal_name(field.extensions.printer.name)}.Length > 0)'

		display_condition_field_name = lang_field_name(condition_field_name)
		if conditional.operation in ['not in', 'in']:
			return f'if ({condition_operator}{display_condition_field_name}.has({yoda_value}))'
		
		if prefix_field:
			if yoda_value.isdecimal():
				return f'if ({yoda_value} {condition_operator} {display_condition_field_name[:1].upper() + display_condition_field_name[1:]})'
			else:
				return f'if ({yoda_value}.Value {condition_operator} {display_condition_field_name[:1].upper() + display_condition_field_name[1:]}.Value)'
		else :
			if yoda_value.isdecimal():
				return f'if ({yoda_value} {condition_operator} {display_condition_field_name})'
			else:
				return f'if ({yoda_value}.Value {condition_operator} {display_condition_field_name}.Value)'
		#return f'if ({yoda_value} {condition_operator} {display_condition_field_name})'

	def get_sort_descriptor(self):
		body = ''
		is_last_sort_field_conditional = False
		for field in self.non_const_fields():
			field_value = self.field_name(field)

			sort = field.extensions.printer.sort(field_value)
			if not sort:
				continue

			condition = self.generate_condition(field, True)

			if is_computed(field):
				sort += 'Computed'

			body += indent_if_conditional(condition, f'{sort}\n')
			is_last_sort_field_conditional = bool(condition)

		# indent_if_conditional always adds a newline when there is a condition
		# if the last sortable field has a condition, the newline needs to be stripped to avoid a blank line before closing brace
		if is_last_sort_field_conditional:
			body = body[:-1]

		return MethodDescriptor(body=body)

	def generate_deserialize_field(self, field, arg_buffer_name=None):
		# pylint: disable=too-many-locals

		condition = self.generate_condition(field)

		buffer_name = arg_buffer_name or 'view'
		field_name = fix_size_name(field.extensions.printer.name)

		# half-hack: limit buffer to amount specified in size field
		buffer_load_name = buffer_name
		size_fields = field.extensions.size_fields
		if size_fields:
			assert len(size_fields) == 1, f'unexpected number of size_fields associated with {field.name}'
			buffer_load_name = f'br'

		use_custom_buffer_name = arg_buffer_name or size_fields

		load = field.extensions.printer.load(buffer_load_name) if use_custom_buffer_name else field.extensions.printer.load('br')
		const_field = 'var ' if not condition else ''
		deserialize = f'{const_field}{field_name} = {load};\n'

		# hack: if there's passed buffer name it means it's a name of temporary buffer (used for coditionals)
		# don't generate adjust in such case
		# adjust = '' if arg_buffer_name else f'{buffer_name}.shiftRight({field.extensions.printer.advancement_size()});\n'

		additional_statements = ''
		if is_reserved(field):
			additional_statements = f'if ({field.value} != {field.extensions.printer.name})\n'
			additional_statements += indent(f'throw new Exception($"Invalid value of reserved field ({{{field.extensions.printer.name}}})");')

		if is_bound_size(field) and field.is_size_reference:
			additional_statements += '// marking sizeof field\n'

		if field.is_conditional:
			if DisplayType.INTEGER == field.extensions.type_model.display_type:
				load = field.extensions.printer.load('tempBr')
				deserialize = '{\n'
				deserialize += indent('var tempMs = new MemoryStream(durationTemporary.Serialize());')
				deserialize += indent('var tempBr = new BinaryReader(tempMs);')
				deserialize += indent(f'{const_field}{field_name} = {load};\n')
				deserialize += '}\n'
			else:
				load = field.extensions.printer.load('br')
				deserialize = '{\n'
				deserialize += indent(f'{const_field}{field_name} = {load};\n')
				deserialize += '}\n'
				

		deserialize_field = deserialize + additional_statements

		if condition:
			if field.extensions.printer.get_type() == "byte[]":
				condition = f'var {field.extensions.printer.name} = new {field.extensions.printer.get_type()}{{}};\n' + condition
			else:
				condition = f'var {field.extensions.printer.name} = new {field.extensions.printer.get_type()}();\n' + condition

		return indent_if_conditional(condition, deserialize_field)

	def get_deserialize_descriptor(self):
		body = ''

		# special treatment for condition-guarded fields,
		# where condition is behind the fields...
		processed_fields = set()
		queued_fields = {}
		for field in self.non_const_fields():
			if field.is_conditional:
				condition_field_name = field.value.linked_field_name

				if condition_field_name not in processed_fields:
					if condition_field_name not in queued_fields:
						queued_fields[condition_field_name] = []

						# assume same size and generate single dummy access
						deserialize = f'var {field.extensions.printer.name}Temporary = {field.extensions.printer.load()};'
						comment = '// deserialize to temporary buffer for further processing'
						body += comment + '\n' + deserialize + '\n'

					# queue field for re-reading it from temporary buffer
					queued_fields[condition_field_name].append({'field': field})
					continue

			deserialized_field = self.generate_deserialize_field(field)
			body += deserialized_field
			processed_fields.add(field.name)

			# if conditional field has been processed, process queued fields
			for conditioned in queued_fields.get(field.name, []):
				body += self.generate_deserialize_field(
					conditioned['field'],
					'br'
				)

		# create call to ctor
		body += '\n'
		body += f'var instance = new {self.typename}()\n{{\n'

		for field in self.non_reserved_fields():
			field_name = self.field_name(field, 'instance')
			body += indent(f'{field_name} = {field.extensions.printer.name},\n')
		body = body.rstrip(',\n')
		body += '\n};\nreturn instance;'
		return MethodDescriptor(body=body)

	def generate_serialize_field(self, field):
		condition = self.generate_condition(field, True)

		field_value = ''
		field_comment = ''

		# bound fields are the size / count / sizeof fields that are bound to either object or array
		bound_field = field.extensions.bound_field
		if is_bound_size(field):
			bound_field_name = self.field_name(bound_field)
			field_comment = f' // bound: {field.name}'

			if bound_field.display_type.is_array:
				if field.name.endswith('_count') or not bound_field.field_type.is_byte_constrained:
					field_value = f'({field.extensions.printer.get_type()}){bound_field_name}.Length'

					bound_condition = self.generate_condition(bound_field, True)
					if condition and bound_condition:
						raise RuntimeError('do not know yet how to generate both conditions')

					# HACK: create inline if condition (for NEM namespace purposes)
					if bound_condition:
						condition_value = bound_field.value.value
						field_value = f'({bound_field_name}.Length > 0 ? {field_value} : {condition_value})'
				else:
					field_value = bound_field.extensions.printer.get_size()
			elif field.is_size_reference:
				field_value = bound_field.extensions.printer.get_size()
		elif DisplayType.INTEGER == field.display_type:
			field_value = f'({field.extensions.printer.get_type()}){self.field_name(field)}'
		else:
			field_value = self.field_name(field)

		serialize_line = None
		if DisplayType.TYPED_ARRAY == field.display_type:
			serialize_field = field.extensions.printer.store(field_value, 'bw')
			serialize_line = f'{serialize_field};{field_comment}\n'
		else:
			serialize_field = field.extensions.printer.store(field_value)
			serialize_line = f'bw.Write({serialize_field}); {field_comment}\n'

		return indent_if_conditional(condition, serialize_line)

	def get_serialize_descriptor(self):
		body = 'using var ms = new MemoryStream();\n' + 'using var bw = new BinaryWriter(ms);\n'

		# if first field is size replace serializer with custom one (to access builder .size() instead)
		fields_iter = self.non_const_fields()
		first_field = next(fields_iter)
		if self.struct.size == first_field.extensions.printer.name:
			body += f'bw.Write(Size);\n'
		else:
			body += self.generate_serialize_field(first_field)

		for field in fields_iter:
			body += self.generate_serialize_field(field)

		body += 'return ms.ToArray();'
		return MethodDescriptor(body=body)

	def generate_size_field(self, field):
		condition = self.generate_condition(field, True)
		if self.typename == "Message" and field.extensions.printer.name == "message":
			size_field = field.extensions.printer.get_size(True)
		else:
			size_field = field.extensions.printer.get_size()

		#if "Message" == self.typename:
		#	size_field.replace("Message", "MessageField")

		return indent_if_conditional(condition, f'size += {size_field};\n')

	def get_size_descriptor(self):
		body = '\n'
		body += 'get {\n'
		body += indent('uint size = 0;\n')
		body += indent(''.join(map(self.generate_size_field, self.non_const_fields())))
		body += indent('return size;')
		body += '}'
		return MethodDescriptor(body=body)

	def create_getter_setter_descriptor(self, field):
		class_name = field.extensions.printer.get_type()
		if self.field_name(field) == 'Transactions':
			class_name = 'IBaseTransaction[]'
		elif self.field_name(field) == 'InnerTransaction':
			class_name = 'IBaseTransaction'
		method_descriptor = MethodDescriptor(
			method_name=f'public {class_name} {self.field_name(field)} {{ get; set; }}',
			note='getter_setter',
		)
		return method_descriptor

	def create_getter_descriptor(self, field):
		method_descriptor = MethodDescriptor(
			method_name=f'get {field.extensions.printer.name}',
			body=f'return {self.field_name(field)};',
		)
		return method_descriptor

	def create_setter_descriptor(self, field):
		method_descriptor = MethodDescriptor(
			method_name=f'set {field.extensions.printer.name}',
			arguments=['value'],
			body=f'{self.field_name(field)} = value;',
		)
		return method_descriptor

	def get_getter_setter_descriptors(self):
		descriptors = []
		for field in self.non_reserved_fields():
			descriptors.append(self.create_getter_setter_descriptor(field))
		return descriptors

	def generate_str_field(self, field):
		condition = self.generate_condition(field, True)
		field_to_string = field.extensions.printer.to_string(self.field_name(field))
		value = None
		if DisplayType.TYPED_ARRAY == field.display_type:
			value = f'[{{{field_to_string}}}]'
		elif DisplayType.BYTE_ARRAY == field.display_type:
			value = f'hex({{{field_to_string}}})'
		else:
			value = f'{{{field_to_string}}}'
		return indent_if_conditional(condition, f'result += $"{field.extensions.printer.name}: {value}, ";\n')

	def get_str_descriptor(self):
		body = 'var result = \"(\";\n'
		body += ''.join(map(self.generate_str_field, self.non_reserved_fields()))
		body += 'result += \")\";\n'
		body += 'return result;'
		return MethodDescriptor(body=body)
