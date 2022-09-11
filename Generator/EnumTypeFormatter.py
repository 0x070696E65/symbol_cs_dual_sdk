from .AbstractTypeFormatter import AbstractTypeFormatter, MethodDescriptor
from .format import indent, wrap_lines
from .printers import IntPrinter


class EnumTypeFormatter(AbstractTypeFormatter):
	def __init__(self, ast_model):
		super().__init__()

		self.enum_type = ast_model

		self.int_printer = IntPrinter(self.enum_type)

	@property
	def typename(self):
		return self.enum_type.name

	#@property
	#def provider_type(self):
	#	return 'enum'

	def get_base_class(self):
		return f'IEnum<{self.int_printer.get_type()}>'

	def get_fields(self):
		return list(
			map(
				lambda e: f'public static readonly {self.typename} {e.name} = new ({e.value});\n',
				self.enum_type.values,
			)
		) + [f"public {self.int_printer.get_type()} Value {{ get; }}"]

	def get_ctor_descriptor(self):
		arguments = [f'{self.int_printer.get_type()} value = 0']
		body = 'Value = value;\n'
		return MethodDescriptor(body=body, arguments=arguments)

	def get_deserialize_descriptor(self):
		body = ''
		if self.enum_type.is_bitwise:
			body += f'return new {self.typename}({self.int_printer.load()});'
		else:
			size = self.int_printer.get_size()
			if size == 1:
				body += f'return FromValue(br.ReadByte());'
			else:
				body += f'return FromValue({self.int_printer.load()});'
		return MethodDescriptor(body=body)

	def get_serialize_descriptor(self):
		if self.int_printer.get_size() == 1:
			return MethodDescriptor(body=f'return new []{{Value}};')	
		return MethodDescriptor(body=f'return BitConverter.GetBytes(Value);')

	def get_size_descriptor(self):
		#return None
		body = '\n'
		body += 'get {\n'
		body += indent(f'return {self.enum_type.size};\n')
		body += '}\n'
		return MethodDescriptor(body=body)

	def generate_key_value_arrays(self):
		values = list(map(lambda e: str(e.value), self.enum_type.values))
		keys = list(map(lambda e: f'"{e.name}"', self.enum_type.values))

		result = wrap_lines(values, f'var values = new uint[]{{', '};\n', 4 * 3)
		result += wrap_lines(keys, 'var keys = new []{', '};\n', 4 * 3)
		return result

	def get_value_to_key_descriptor(self):
		body = self.generate_key_value_arrays()
		body += '''
var index = Array.IndexOf(values, value);
if (-1 == index)
	throw new Exception($"invalid enum value {value}");

return keys[index];
'''
		return MethodDescriptor(method_name='internal static string ValueToKey', body=body, arguments=[f'uint value'])

	def get_map_descriptor(self):
		lines = ['return value switch\n{']
		enumValues = list(map(lambda e: f'{e.value} => {e.name}', self.enum_type.values,))
		current_line = ''
		for i, entry in enumerate(enumValues):
			current_line += '\t' + str(entry) + ',\n'
			if i == len(enumValues) - 1:
				current_line += '\t_ => throw new Exception($"invalid enum value {value}")'
		lines.append(current_line)
		lines.append('};')
		body = '\n'.join(lines)
		return MethodDescriptor(method_name=f'internal static {self.typename} FromValue', body=body, arguments=[f'uint value'])

	def get_getter_setter_descriptors(self):
		methods = []

		if self.enum_type.is_bitwise:
			body = 'return 0 != (Value & flag);\n'
			methods.append(MethodDescriptor(method_name='public bool Has', arguments=['uint flag'], body=body))
		else:
			methods.append(self.get_value_to_key_descriptor())
			methods.append(self.get_map_descriptor())

		return methods

	def get_str_descriptor(self):
		if not self.enum_type.is_bitwise:
			body = f'return $"{self.typename}.{{ValueToKey(Value)}}";'
			return MethodDescriptor(body=body)

		body = self.generate_key_value_arrays()
		body += f'''
if (0 == Value) {{
	var index = Array.IndexOf(values, Value);
	return $"{self.typename}.{{keys[index]}}";
}}

var positions = values.ToList().Select((flag, i) => new {{flag, Index = i}}).Where(flag => (Value & flag.flag) != 0).ToList();
return string.Join("|", positions.Select(n => $"{self.typename}.{{keys[n.Index]}}"));
'''
		return MethodDescriptor(body=body)
