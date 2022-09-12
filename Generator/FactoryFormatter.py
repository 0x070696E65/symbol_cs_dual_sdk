from catparser.ast import FixedSizeInteger

from .AbstractTypeFormatter import AbstractTypeFormatter, MethodDescriptor
from .format import indent
from .name_formatting import fix_name, underline_name
from .printers import BuiltinPrinter
from .TypeFormatter import ClassFormatter


# hack: skip embedded from names
def skip_embedded(name):
	if not name.startswith('embedded_'):
		return name

	return name[len('embedded_'):]

class FactoryClassFormatter(ClassFormatter):
	def generate_deserializer(self):
		method_descriptor = self.provider.get_deserialize_descriptor()
		method_descriptor.method_name = f'public static {self.provider.return_class} Deserialize'
		method_descriptor.arguments = ['BinaryReader br']
		return self.generate_method(method_descriptor)

	def generate_deserializer2(self):
		method_descriptor = self.provider.get_deserialize_descriptor2()
		method_descriptor.method_name = f'public static {self.provider.return_class} Deserialize'
		method_descriptor.arguments = ['string payload']
		return self.generate_method(method_descriptor)

	def generate_create_by_name(self):
		method_descriptor = self.provider.get_create_by_name_descriptor()
		method_descriptor.method_name = f'public static {self.provider.return_class} CreateByName'
		method_descriptor.arguments = [
			'TransactionType entityName'
		]
		return self.generate_method(method_descriptor)

	def generate_methods(self):
		methods = []
		#getters_setters = self.generate_getters_setters()
		#methods.extend(getters_setters)
		methods.append(self.generate_deserializer())
		methods.append(self.generate_deserializer2())
		methods.append(self.generate_create_by_name())
		return methods

	def generate_getters_setters(self):
		return list(map(self.generate_method, self.provider.get_getter_setter_descriptors()))


class FactoryFormatter(AbstractTypeFormatter):
	def __init__(self, factory_map, abstract_model):
		super().__init__()

		# array or int
		self.abstract = abstract_model
		self.printer = BuiltinPrinter(abstract_model, 'parent')
		self.factory_descriptor = factory_map.get(self.abstract.name)

	@property
	def return_class(self):
		if self.abstract.name == "Transaction":
			return "ITransaction"
		elif self.abstract.name == "EmbeddedTransaction":
			return "IBaseTransaction"

	def get_ctor_descriptor(self):
		raise NotImplementedError('`get_ctor_descriptor` not supported by FactoryFormatter')

	@property
	def typename(self):
		return f'{self.abstract.name}Factory'

	@staticmethod
	def map_to_value(name, value, field_type):
		return f'{name}.{value}'# if isinstance(field_type, FixedSizeInteger) else f'{name}.{value}.value'

	def get_base_class(self):
		return ''

	def create_discriminator(self, name):
		field_values = self.factory_descriptor.discriminator_values
		field_types = self.factory_descriptor.discriminator_types

		values = ', '.join(map(lambda value_type: self.map_to_value(name, *value_type), zip(field_values, field_types)))
		return f'{{{values}, {name}.Deserialize}}'

	def get_deserialize_descriptor(self):
		body = 'var position = br.BaseStream.Position;\n'
		body += f'var {self.printer.name} = {self.printer.load()};\n'

		body += f'var mapping = new Dictionary<TransactionType, Func<BinaryReader, {self.return_class}>>\n{{\n'

		if self.factory_descriptor:
			names = [f'{concrete.name}' for concrete in self.factory_descriptor.children]
			body += indent(
				',\n'.join(map(self.create_discriminator, names))
			)

		body += '};\n'
		body += 'br.BaseStream.Position = position;\n'
		body += 'return mapping[parent.Type](br);'

		return MethodDescriptor(body=body)

	def get_deserialize_descriptor2(self):
		body = 'using var ms = new MemoryStream(Converter.HexToBytes(payload).ToArray());\n'
		body += 'using var br = new BinaryReader(ms);\n'
		body += 'return Deserialize(br);'

		return MethodDescriptor(body=body)

	def get_create_by_name_descriptor(self):
		body = ''
		body += f'var mapping = new Dictionary<TransactionType, {self.return_class}>\n{{\n'
		body += indent(
			',\n'.join(
				map(
					# lambda child: f'{{"{skip_embedded(underline_name(child.name))}", new {child.name}()}}',
					lambda child: f'{{{skip_embedded(child.name)}.TRANSACTION_TYPE, new {child.name}()}}',
					{} if not self.factory_descriptor else self.factory_descriptor.children
				)
			)
		)
		body += indent('\n')
		body += '};\n'

		body += f'return mapping[entityName];'
		return MethodDescriptor(body=body)

	def get_serialize_descriptor(self):
		raise RuntimeError('not required')

	def get_size_descriptor(self):
		raise RuntimeError('not required')

	def get_getter_setter_descriptors(self):
		# toKey is a helper method that is used to create map keys, that are used inside factory's deserialize method
		methods = []
		body = '''if (1 === values.length)
	return values[0];

// assume each key is at most 32bits
return values.map(n => BigInt(n)).reduce((accumulator, value) => (accumulator << 32n) + value);
'''
		methods.append(MethodDescriptor(method_name='static toKey', arguments=['values'], body=body))
		return methods
