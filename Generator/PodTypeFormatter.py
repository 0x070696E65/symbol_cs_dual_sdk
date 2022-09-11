from .AbstractTypeFormatter import AbstractTypeFormatter, MethodDescriptor
from .printers import create_pod_printer
from .format import indent

class PodTypeFormatter(AbstractTypeFormatter):
	def __init__(self, ast_model):
		super().__init__()

		# array or int
		self.pod = ast_model
		self.printer = create_pod_printer(self.pod)

	@property
	def typename(self):
		return self.pod.name

	@property
	def field_name(self):
		return f'this._{self.printer.name}'

	@property
	def _is_array(self):
		return self.pod.display_type.is_array

	#@property
	#def provider_type(self):
	#	return 'pod'

	def get_fields(self):
		return [f'private const byte SIZE = {self.pod.size};']

	def get_base_class(self):
		return f'ByteArray, ISerializer' if self._is_array else f'BaseValue, ISerializer'

	def get_ctor_descriptor(self):
		variable_name = self.printer.name
		base = f': base(SIZE, {variable_name})'
		if self._is_array:
			arguments = [f'{self.printer.get_type()}? {variable_name} = null']
		else:
			arguments = [f'{self.printer.get_type()} {variable_name} = {self.printer.get_default_value()}']

		return MethodDescriptor(arguments=arguments, base=base)

	def get_deserialize_descriptor(self):
		body = f'return new {self.typename}({self.printer.load()});'
		return MethodDescriptor(body=body)

	def get_serialize_descriptor(self):
		if self._is_array:
			return MethodDescriptor(body='return bytes;')

		return MethodDescriptor(body=f'return {self.printer.store("Value")};')

	def get_size_descriptor(self):
		return None

