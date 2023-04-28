from catparser.DisplayType import DisplayType

from .name_formatting import fix_name, fix_size_name, lang_field_name, underline_name, pascal_name


def js_bool(value):
	return 'true' if value else 'false'


class Printer:
	def __init__(self, descriptor, name):
		self.descriptor = descriptor
		self.name = fix_name(lang_field_name(name or underline_name(self.descriptor.name)))

	def sort(self, _field_name):  # pylint: disable=no-self-use
		return None

class IntPrinter(Printer):
	def __init__(self, descriptor, name=None):
		super().__init__(descriptor, name)
		self.type_hint = None

	def get_type(self):
		type = {1:"byte", 2:"ushort", 4:"uint", 8:"ulong"} 
		return type[self.get_size()]

	def get_default_value(self):
		return '0'

	def get_size(self):
		return self.descriptor.size

	def get_bit_size(self, data_size):
		bit = {1: '8', 2: '16', 4: '32', 8: '64'}
		return bit[data_size]

	def load(self, buffer_load_name=''):
		bit_size = self.get_bit_size(self.get_size())
		if bit_size == '8':
			return f'br.ReadByte()'
		else:
			return f'br.ReadUInt{bit_size}()'

	def size_load(self):
		bit_size = self.get_bit_size(self.get_size())
		return f'(int)br.ReadUInt{bit_size}()'

	def advancement_size(self):
		return self.get_size()

	def store(self, field_name):
		bit_size = self.get_bit_size(self.get_size())
		if bit_size == '8':
			return f'{field_name}'
		else:
			return f'BitConverter.GetBytes(({self.get_type()}){field_name})'

	def get_modifier(self, field_name = None):
		return 'public const byte '

	@staticmethod
	def assign(value):
		return str(value)

	@staticmethod
	def to_string(field_name):
		return f'Converter.ToString({field_name})'


class TypedArrayPrinter(Printer):
	def __init__(self, descriptor, name=None):
		super().__init__(descriptor, name)
		self.type_hint = f'array[{self.descriptor.field_type.element_type}]'

	def get_type(self):
		return f'{self.descriptor.field_type.element_type}[]'

	def get_default_value(self):
		class_name = 'IBaseTransaction' if self.descriptor.field_type.element_type == 'EmbeddedTransaction' else self.descriptor.field_type.element_type
		return f'Array.Empty<{class_name}>()'

	@property
	def is_variable_size(self):
		# note: self.descriptor.field_type.alignment condition at the end is needed to filter out receipts
		descriptor = self.descriptor
		return (descriptor.field_type.is_byte_constrained or descriptor.extensions.is_contents_abstract) and descriptor.field_type.alignment

	def get_size(self):
		if self.is_variable_size:
			alignment = self.descriptor.field_type.alignment
			#skip_last_element_padding = js_bool(not self.descriptor.field_type.is_last_element_padded)
			#return f'ArrayHelpers.Size({self.name[:1].upper() + self.name[1:]}, {alignment}, {skip_last_element_padding})'
			return f'ArrayHelpers.Size({self.name[:1].upper() + self.name[1:]}, {alignment})'

		return f'ArrayHelpers.Size({self.name[:1].upper() + self.name[1:]})'

	#def _get_sort_comparer(self, variable_name):
		#sort_key = lang_field_name(self.descriptor.field_type.sort_key)
		#comparer = f'({variable_name}.{sort_key}.comparer ? {variable_name}.{sort_key}.comparer() : {variable_name}.{sort_key}.value)'
		#return comparer

	def _get_sort_accessor(self):
		accessor = f'e => ({self._get_sort_comparer("e")})'
		return accessor

	def load(self, buffer_name):
		del buffer_name
		element_type = self.descriptor.field_type.element_type

		if self.is_variable_size:
			# use either type name or if it's an abstract type use a factory instead
			if self.descriptor.extensions.is_contents_abstract:
				element_type = f'{element_type}Factory.Deserialize'

			data_size = ''
			if self.descriptor.field_type.is_expandable:
				data_size = '(uint)(br.BaseStream.Length - br.BaseStream.Position)'
			else:
				data_size = lang_field_name(self.descriptor.size)

			alignment = self.descriptor.field_type.alignment
			#skip_last_element_padding = js_bool(not self.descriptor.field_type.is_last_element_padded)
			#return f'ArrayHelpers.ReadVariableSizeElements(br, {element_type}, {alignment}, {skip_last_element_padding})'
			return f'ArrayHelpers.ReadVariableSizeElements(br, {element_type}, {data_size}, {alignment})'

		if self.descriptor.field_type.is_expandable:
			element_type = f'{element_type}.Deserialize'
			return f'ArrayHelpers.ReadArray(br, {element_type})'

		args = [
			'br',
			f'{element_type}.Deserialize',
			f'(byte){lang_field_name(str(self.descriptor.size))}',
		]
		#if self.descriptor.field_type.sort_key:
		#	accessor = f'e => e.{lang_field_name(self.descriptor.field_type.sort_key)}.value'
		#	args.append(accessor)

		args_str = ', '.join(args)
		return f'ArrayHelpers.ReadArrayCount({args_str})'

	def advancement_size(self):
		if self.descriptor.field_type.is_byte_constrained:
			return lang_field_name(str(self.descriptor.size))

		alignment = self.descriptor.field_type.alignment
		if alignment:
			skip_last_element_padding = js_bool(not self.descriptor.field_type.is_last_element_padded)
			return f'ArrayHelpers.Size({self.name}, {alignment}, {skip_last_element_padding})'

		return f'ArrayHelpers.Size({self.name})'

	def store(self, field_name, buffer_name):
		if self.is_variable_size:
			alignment = self.descriptor.field_type.alignment
			#skip_last_element_padding = js_bool(not self.descriptor.field_type.is_last_element_padded)
			return f'ArrayHelpers.WriteVariableSizeElements({buffer_name}, {field_name}, {alignment})'
			#return f'ArrayHelpers.WriteVariableSizeElements({buffer_name}, {field_name}, {alignment}, {skip_last_element_padding})'

		if self.descriptor.field_type.is_expandable:
			return f'ArrayHelpers.WriteArray({buffer_name}, {field_name})'

		args = [buffer_name, field_name]
		size = self.descriptor.size
		if not isinstance(size, str):
			args.append(str(size))

		#if self.descriptor.field_type.sort_key:
		#	accessor = f'e => e.{lang_field_name(self.descriptor.field_type.sort_key)}.value'
		#	args.append(accessor)

		args_str = ', '.join(args)
		if isinstance(size, str):
			return f'ArrayHelpers.WriteArray({args_str})'

		return f'ArrayHelpers.WriteArrayCount({args_str})'

	def sort(self, field_name):
		if not self.descriptor.field_type.sort_key:
			return None

		sort_key = pascal_name(lang_field_name(self.descriptor.field_type.sort_key))
		body = f'Array.Sort({field_name}, (lhs, rhs) => {{\n'
		body +=	f'return ((ulong) ((lhs.{sort_key}.GetType().GetMethod("Comparer") != null\n'
		body += f'? lhs.{sort_key}.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {{}})\n'
		body += f': lhs.{sort_key}.GetType().GetField("Value").GetValue(lhs.{sort_key}) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))\n'
		body += f'.CompareTo((ulong) ((rhs.{sort_key}.GetType().GetMethod("Comparer") != null\n'
		body += f'? rhs.{sort_key}.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {{}})\n'
		body += f': rhs.{sort_key}.GetType().GetField("Value").GetValue(rhs.{sort_key}) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));\n'
		body += f'}});'
		#body = f'Array.Sort({field_name},(lhs, rhs)=>lhs.{sort_key}.Value.CompareTo(rhs.{sort_key}.Value));'
		return body

	@staticmethod
	def to_string(field_name):
		return f'string.Join(",", {field_name}.Select(e => e.ToString()))'

class ArrayPrinter(Printer):
	def __init__(self, descriptor, name=None):
		super().__init__(descriptor, name)
		self.type_hint = 'bytes_array'

	@staticmethod
	def get_type():
		return 'byte[]'

	def get_default_value(self):
		return 'Array.Empty<byte>()'

	def get_size(self, message=False):
		size = self.descriptor.size
		if isinstance(size, str):
			if message:
				return f'(uint){pascal_name(self.name).replace("Message", "MessageField")}.Length'
			else:
				return f'(uint){pascal_name(self.name)}.Length'
		return size

	def load(self, buffer_name='br.ReadBytes'):
		if not isinstance(self.descriptor.size, str):
			return f'{buffer_name}({self.advancement_size()})'
		else:
			return f'{buffer_name}.ReadBytes((int){self.advancement_size()})'

	def advancement_size(self):
		# like get_size() but without self prefix, as this refers to local method field
		if not isinstance(self.descriptor.size, str):
			return self.descriptor.size

		return fix_size_name(lang_field_name(self.descriptor.size))

	@staticmethod
	def store(field_name):
		return f'{field_name}'

	@staticmethod
	def to_string(field_name):
		return f'Converter.BytesToHex({field_name})'


class BuiltinPrinter(Printer):
	def __init__(self, descriptor, name=None):
		super().__init__(descriptor, name)
		self.type_hint = {
			DisplayType.INTEGER: 'pod:',
			DisplayType.BYTE_ARRAY: 'pod:',
			DisplayType.TYPED_ARRAY: 'pod:',
			DisplayType.ENUM: 'enum:',
			DisplayType.STRUCT: 'struct:'
		}[self.descriptor.display_type]

		self.type_hint += self.descriptor.name

	def get_type(self):
		return self.descriptor.name
	
	def get_name(self):
		return self.name[:1].upper() + self.name[1:]

	def get_default_value(self):
		if DisplayType.ENUM == self.descriptor.display_type:
			first_enum_value_name = self.descriptor.values[0].name
			return f'{self.get_type()}.{first_enum_value_name}'

		return f'new {self.get_type()}()'

	def get_size(self):
		return f'{self.get_name()}.Size'

	def load(self, buffer_name='br'):
		if DisplayType.STRUCT == self.descriptor.display_type and self.descriptor.is_abstract:
			# HACK: factories use this printers as well, ignore them
			if 'parent' != self.name:
				factory_name = self.get_type() + 'Factory'
				return f'({self.get_type()}){factory_name}.Deserialize({buffer_name})'

		return f'{self.get_type()}.Deserialize({buffer_name})'

	def advancement_size(self):
		return f'{self.name}.size'

	@staticmethod
	def store(field_name):
		return f'{field_name}.Serialize()'

	def sort(self, field_name):
		return f'{field_name}.Sort();' if DisplayType.STRUCT == self.descriptor.display_type else None

	def get_modifier(self, field_name):
		return f'public static readonly {field_name.lower().title().replace("_", "")} '

	def assign(self, value):
		return f'{self.get_type()}.{value}'

	@staticmethod
	def to_string(field_name):
		return field_name


def create_pod_printer(descriptor, name=None):
	display_type = descriptor.display_type
	if DisplayType.INTEGER == display_type:
		PrinterType = IntPrinter
	elif DisplayType.BYTE_ARRAY == display_type:
		PrinterType = ArrayPrinter
	else:
		PrinterType = TypedArrayPrinter

	return PrinterType(descriptor, name)
