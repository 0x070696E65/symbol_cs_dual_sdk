from pathlib import Path
import json
import re
from typing import Iterator

f = open('../models/transactions.json', 'r')
j = json.load(f)
CAMEL_CASE_PATTERN = re.compile(r'(?<!^)(?=[A-Z])')
SNAKE_CASE_PATTERN = re.compile(r'_([a-z])')

def to_flags(value, type):
    arr = re.split(" ", value)
    result = f'\nnew [] {{\n'
    for a in arr:
        result += indent(f'{type}.{a.upper()},\n')
    result += f'}}\n'
    return indent(result)

def to_enum(value, type):
    return f'{type}.{value.upper()}'

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
    t2 = f'\n'
    t2 += f'new Dictionary<string, object>[]{{\n'
    t3 = f'new(){{\n'
    for key in value:
        t3 += indent(f'{{"{to_pascal_case(key)}", {type_check(key, value[key], txType)}}},\n')
    t3 += f'}},\n'
    t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_mosaic_definition(value):
    t2 = f'new MosaicDefinition(){{\n'
    t2 += indent(f'OwnerPublicKey = new PublicKey(Converter.HexToBytes("{str(value["owner_public_key"])}")),\n')
    t2 += indent(f'Id = new MosaicId {{')
    t2 += indent(f'Name = Converter.HexToBytes("{str(value["id"]["name"])}"),\n')
    t2 += indent(f'NamespaceId = {{Name = Converter.HexToBytes("{str(value["id"]["namespace_id"]["name"])}")}}}},\n')
    t2 += indent(f'Description = Converter.HexToBytes("{str(value["description"])}"),\n')
    t2 += indent(f'Properties = new SizePrefixedMosaicProperty[] {{\n')
    for i in range(len(value["properties"])):
        t3 = indent(f'new (){{\n')
        t3 += indent(f'Property = new MosaicProperty {{\n', 2)
        t3 += indent(f'Name = Converter.HexToBytes("{value["properties"][i]["property_"]["name"]}"),\n', 3)
        t3 += indent(f'Value = Converter.HexToBytes("{value["properties"][i]["property_"]["value"]}")}}\n', 3)
        t3 += indent(f'}},\n', 2)
        t2 += indent(t3)
    t2 += indent(f'}}}}\n', 2)
    return t2

def to_mosaic_array(value):
    t2 = f'\n'
    t2 += f'new Mosaic[]{{\n'
    for i in range(len(value)):
        t3 = indent(f'new (){{\n')
        t3 += indent(f'MosaicId = new MosaicId {{', 2)
        t3 += indent(f'NamespaceId = {{Name = Converter.HexToBytes("{str(value[i]["mosaic"]["mosaic_id"]["namespace_id"]["name"])}")}},', 3)
        t3 += indent(f'Name = Converter.HexToBytes("{str(value[i]["mosaic"]["mosaic_id"]["name"])}")}},', 3)
        t3 += indent(f'Amount = new Amount({str(value[i]["mosaic"]["amount"])})',2)
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_cosignature_array(value):
    t2 = f'\n'
    t2 += f'new Cosignature[]{{\n'
    for i in range(len(value)):
        t3 = ''
        t3 += indent(f'new (){{\n')
        t3 += indent(f'SignerPublicKey = new PublicKey(Converter.HexToBytes("{str(value[i]["cosignature"]["signer_public_key"])}")),',2)
        t3 += indent(f'Signature = new Signature(Converter.HexToBytes("{str(value[i]["cosignature"]["signature"])}")),',2)
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_mosaic_id(value):
    t = f'new MosaicId{{\n'
    t += indent(f'NamespaceId = {{Name = Converter.HexToBytes("{value["namespace_id"]["name"]}")}},\n')
    t += indent(f'Name = Converter.HexToBytes("{value["name"]}")}}\n')
    return t

def to_message(value):
    t = indent(f'new Message(){{\n')
    t += indent(f'MessageType = MessageType.{value["message_type"].upper()},',2)
    t += indent(f'MessageField = Converter.HexToBytes("{value["message"]}"),}}',2)
    return t

def to_modifications(value):
    t2 = f'new SizePrefixedMultisigAccountModification[]{{\n'
    for i in range(len(value)):
        t3 = indent(f'new (){{\n')
        t3 += indent(f'Modification = new MultisigAccountModification {{\n')
        t3 += indent(f'ModificationType = MultisigAccountModificationType.{str(value[i]["modification"]["modification_type"]).upper()},',2)
        t3 += indent(f'CosignatoryPublicKey = new PublicKey(Converter.HexToBytes("{str(value[i]["modification"]["cosignatory_public_key"])}")),',2)
        t3 += f'}}}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def type_check(key, value, txType):
    if key == "fee" or key == "rental_fee":
        return f'new Amount({value})'
    if key == "timestamp":
        return f'new Timestamp({value})'
    if key == "mosaic_id":
        return to_mosaic_id(value)
    if key == "mosaics":
        return to_mosaic_array(value)
    if key == "inner_transaction":
        return innner(key, value, txType)
    if key == "mosaic_definition":
        return to_mosaic_definition(value)
    if key == "multisig_account_address":
        return f'new Address(Converter.Utf8ToBytes("{value}"))'
    if key == "multisig_transaction_hash" or key == "rental_fee_sink":
        return f'new Hash256(Converter.HexToBytes("{value}"))'
    if key == "cosignatures":
        if len(value) == 0:
            return 'System.Array.Empty<Cosignature>()'
        else:
            return to_cosignature_array(value)
    if key == "modifications":
        if len(value) == 0:
            return 'System.Array.Empty<SizePrefixedMultisigAccountModification>()'
        else:
            return to_modifications(value)
    if key == "namespace_id":
        return f'new NamespaceId({value})'  
    if key == "value":
        if value.isdecimal():
            return f'Converter.HexToBytes("{value}")'
        else:
            return f'Converter.Utf8ToBytes("{value}")'
    if key == "link_action":
        return to_enum(value, "LinkAction")
    if key == "action":
        return to_enum(value, "MosaicSupplyChangeAction")
    if key == "signer_public_key" or key == "owner_public_key" or key == "remote_public_key":
        return f'new PublicKey(Converter.HexToBytes("{value}"))'
    if key == "signature":
        return f'new Signature(Converter.HexToBytes("{value}"))'
    if key == "parent_name":
        return f'Converter.HexToBytes("{value}")' if value != None else "System.Array.Empty<byte>()"
    if key == "message":
        return to_message(value)
    if isinstance(value, int):
        return value
    if isinstance(value, str):
        return f'"{value}"'

with open(Path('../') / 'TransactionNonParserTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using System.Collections.Generic;
using NUnit.Framework;
using CatSdk.Facade;
using CatSdk.Nem.Factory;
using CatSdk.Nem;
using CatSdk.Utils;

namespace Test.Nem;
public class TransactionNonParserTest
{
    private readonly NemFacade Facade = new (Network.TestNet);     
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
