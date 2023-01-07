#!/usr/bin/python

from pathlib import Path

from catparser.DisplayType import DisplayType
from catparser.generators.util import build_factory_map, extend_models

from .EnumTypeFormatter import EnumTypeFormatter
from .FactoryFormatter import FactoryClassFormatter, FactoryFormatter
from .format import wrap_lines
from .PodTypeFormatter import PodTypeFormatter
from .printers import BuiltinPrinter, create_pod_printer
from .StructTypeFormatter import StructFormatter
from .TypeFormatter import TypeFormatter

import re
from .name_formatting import pascal_name

def create_printer(descriptor, name, is_pod):
	return (create_pod_printer if is_pod else BuiltinPrinter)(descriptor, name)

def to_type_formatter_instance(ast_model):
	type_formatter_class = {
		DisplayType.STRUCT: StructFormatter,
		DisplayType.ENUM: EnumTypeFormatter,
		DisplayType.BYTE_ARRAY: PodTypeFormatter,
		DisplayType.INTEGER: PodTypeFormatter
	}[ast_model.display_type]

	return type_formatter_class(ast_model)


def generate_module_exports(output_file, all_names):
	output_file.write(wrap_lines(all_names, '\nmodule.exports = {', '};\n'))

def chain_name(name):
	return pascal_name(re.split('/', str(name))[-1])

def generate_files(ast_models, output_directory: Path):
	factory_map = build_factory_map(ast_models)
	extend_models(ast_models, create_printer)

	output_directory.mkdir(exist_ok=True)

	with open(output_directory / 'Models.cs', 'w', encoding='utf8', newline='\n') as output_file:
		output_file.write(
			f'using System;\nusing System.Collections.Generic;\nusing System.IO;\nusing System.Linq;\nusing CatSdk.Utils;\nnamespace CatSdk.{chain_name(output_directory)}{{\n\n'
		)

		for ast_model in ast_models:
			generator = TypeFormatter(to_type_formatter_instance(ast_model))
			output_file.write(str(generator))
			output_file.write('\n')

		factories = []
		factory_names = []
		for ast_model in ast_models:
			if DisplayType.STRUCT == ast_model.display_type and ast_model.is_abstract:
				factory_formatter = FactoryFormatter(factory_map, ast_model)
				factory_generator = FactoryClassFormatter(factory_formatter)
				factory_names.append(factory_formatter.typename)
				factories.append(str(factory_generator))

		output_file.write('\n'.join(factories))
		output_file.write(f'}}')

		#generate_module_exports(output_file, list(map(lambda ast_model: ast_model.name, ast_models)) + factory_names)


class Generator:
	@staticmethod
	def generate(ast_models, output):
		print(f'python catbuffer generator called with output: {output}')
		generate_files(ast_models, Path(output))
