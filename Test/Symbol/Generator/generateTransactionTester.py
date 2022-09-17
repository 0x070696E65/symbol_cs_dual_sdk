from pathlib import Path
import json
import re
from typing import Iterator
import string

f = open('../models/transactions.json', 'r')
j = json.load(f)
CAMEL_CASE_PATTERN = re.compile(r'(?<!^)(?=[A-Z])')
SNAKE_CASE_PATTERN = re.compile(r'_([a-z])')

def _parse_words(string: str) -> Iterator[str]:
    for block in re.split(r"[ _-]+", string):
        yield block

def to_pascal_case(string: str) -> str:
    words_iter = _parse_words(string)
    return "".join(word.capitalize() for word in words_iter)

def indent(text, i = 1):
    tab = ''
    for j in range(i):
        tab += '\t'
    output = ''
    for line in text.splitlines():
        prefix = tab if line else ''
        output += f'{prefix}{line}\n'
    return output

def innner(key, value, txType):
    t2 = f'new []{{\n'
    for i in range(len(value)):
        t3 = f'Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {{\n'
        for key in value[i]:
            t3 += indent(f'{{"{to_pascal_case(key)}", {type_check(key, value[i][key], txType)}}},\n')
        t3 += f'}}),\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_cosignature_array(key, value, txType):
    t2 = f'\n'
    t2 += f'new Dictionary<string, object>[]{{\n'
    for i in range(len(value)):
        t3 = ''
        t3 += indent(f'new (){{\n')
        for key in value[i]:
            t3 += indent(f'{{"{to_pascal_case(key)}", {type_check(key, value[i][key], txType)}}},\n')
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_mosaic_array(key, value, txType):
    t2 = f'\n'
    t2 += f'new Dictionary<string, object>[]{{\n'
    for i in range(len(value)):
        t3 = ''
        t3 += indent(f'new (){{\n')
        for key in value[i]:
            t3 += indent(f'{{"{to_pascal_case(key)}", {type_check(key, value[i][key], txType)}}},\n')
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def type_check(key, value, txType):
    if key == "value":
        if value.isdecimal():
            return f'Converter.HexToBytes("{value}")'
        else:
            return f'Converter.Utf8ToBytes("{value}")'
    if key == "message" or key == "name":
        if(all(c in string.hexdigits for c in value)):
            return f'"{value}"'
        return f'Converter.Utf8ToBytes("{value}")'
    if key == "transactions":
        return innner(key, value, txType)
    if key == "cosignatures":
        return to_cosignature_array(key, value, txType)
    if key == "mosaics":
        return to_mosaic_array(key, value, txType)
    if key == "mosaic":
        m = f'\n'
        m += f'new Dictionary<string, object>(){{\n'
        m += indent(f'{{"{to_pascal_case("mosaic_id")}", {value["mosaic_id"]}}},\n')
        m += indent(f'{{"{to_pascal_case("amount")}", {value["amount"]}}},\n')
        m += f'}}\n'
        return indent(m)
    if key == "address_additions" or key == "address_deletions":
        a = 'new string[]{\n'
        for i in range(len(value)):
            a += f'"{value[i]}",'
        a += f'}}\n'
        return indent(a)
    if key == "value":
        if value.isdecimal():
            return f'"{value}"'
        else:
            return f'"{value}"'
    if key == "restriction_additions" or key == "restriction_deletions":
        if len(value) == 0:
            if "address_restriction" in txType or "operation_restriction" in txType:
                return 'System.Array.Empty<string>()'
            return 'System.Array.Empty<int>()'
        arr = []
        for i in range(len(value)):
            if isinstance(value[i], str):
                arr.append(f'"{value[i].upper()}"')
            if isinstance(value[i], int):
                arr.append(value[i])
        arr = ",".join(map(str, arr))
        return f'new[] {{{arr}}}'
    if isinstance(value, int):
        return value
    if isinstance(value, str):
        if "flags" in key or key == "link_action" or key == "alias_action" or key == "hash_algorithm" or key == "previous_restriction_type" or key == "new_restriction_type" or key == "action" or key == "registration_type":
            return f'"{value.upper()}"'
        return f'"{value}"'

with open(Path('../') / 'TransactionTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CatSdk.Facade;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;

namespace Test.Symbol;
public class TransactionTest
{
    private readonly SymbolFacade Facade = new (Network.TestNet);    
"""
    for c in j:
        body = f'[Test]\n'
        body += f'public void {c["test_name"]}(){{\n'
        body += indent(f'var payload = "{c["payload"]}";\n')
        body += indent(f'var descriptor = new Dictionary<string, object>(){{\n')
        for key in c["descriptor"]:
            body += indent(f'{{"{to_pascal_case(key)}", {type_check(key, c["descriptor"][key], c["test_name"])}}},\n', 2)
        body += indent(f'}};\n')
        body += indent(f'var tx = Facade.TransactionFactory.Create(descriptor);\n')
        body += indent(f'Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));\n')
        body += f'}}\n'
        result += indent(body)
    result += "}"
    output_file.write(result)
