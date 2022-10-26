from pathlib import Path
import json
import re
from typing import Iterator
import string

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

def innner(key, value, txType, schema):
    t2 = f'\n'
    t2 += f'TransactionsFactory.ToNonVerifiableTransaction(new {to_pascal_case(value["type"])}() {{\n'
    t3 = ''
    t3 += f'Network = NetworkType.TESTNET,\n'
    for key in value:
        if key != "type":
            t3 += f'{to_pascal_case(key)} = {type_check(key, value[key], txType, schema)},\n'
    t2 += indent(t3)
    t = t2
    t += f'}})\n'
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
    t2 += indent(f'}},\n', 2)
    #t2 += indent(f'LevySize = {value["levy_size"]},\n')
    if "levy" in value:
        t2 += indent(f'Levy = {{\n')
        t2 += indent(f'TransferFeeType = MosaicTransferFeeType.{value["levy"]["transfer_fee_type"].upper()},\n', 2)
        t2 += indent(f'RecipientAddress = new Address(Converter.Utf8ToBytes("{value["levy"]["recipient_address"]}")),\n', 2)
        t2 += indent(f'MosaicId = {{\n', 2)
        t2 += indent(f'NamespaceId = new NamespaceId {{Name = Converter.HexToBytes("{value["levy"]["mosaic_id"]["namespace_id"]["name"]}"),}},\n', 3)
        t2 += indent(f'Name = Converter.HexToBytes("{value["levy"]["mosaic_id"]["name"]}"),}},\n', 3)
        t2 += indent(f'Fee = new Amount({value["levy"]["fee"]})}},\n', 2)
    t2 += indent(f'}}\n', 2)
    return t2

def to_mosaic_array(value):
    t2 = f'\n'
    t2 += f'new SizePrefixedMosaic[]{{\n'
    for i in range(len(value)):
        t3 = f'new SizePrefixedMosaic() {{Mosaic = {{MosaicId = new MosaicId() {{NamespaceId = new NamespaceId() {{\n'
        t3 += indent(f'Name = Converter.HexToBytes("{str(value[i]["mosaic"]["mosaic_id"]["namespace_id"]["name"])}")}},', 2)
        t3 += indent(f'Name = Converter.HexToBytes("{str(value[i]["mosaic"]["mosaic_id"]["name"])}")}},', 2)
        t3 += indent(f'Amount = new Amount({str(value[i]["mosaic"]["amount"])})}}')
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_cosignature_array(value):
    t2 = f'\n'
    t2 += f'new SizePrefixedCosignature[]{{\n'
    for i in range(len(value)):
        t3 = ''
        t3 += indent(f'new (){{ Cosignature = new Cosignature() {{\n')
        t3 += indent(f'MultisigTransactionHash = new Hash256(Converter.HexToBytes("{value[i]["cosignature"]["multisig_transaction_hash"]}")),',2)
        t3 += indent(f'MultisigAccountAddress = new Address(Converter.Utf8ToBytes("{value[i]["cosignature"]["multisig_account_address"]}")),',2)
        t3 += indent(f'SignerPublicKey = new PublicKey(Converter.HexToBytes("{value[i]["cosignature"]["signer_public_key"]}")),',2)
        t3 += indent(f'Signature = new Signature(Converter.HexToBytes("{value[i]["cosignature"]["signature"]}")),',2)
        t3 += indent(f'Fee = new Amount({value[i]["cosignature"]["fee"]}),',2)
        t3 += indent(f'Timestamp = new Timestamp({value[i]["cosignature"]["timestamp"]})}},',2)
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
    if(all(c in string.hexdigits for c in value["message"])):
        t += indent(f'MessageField = Converter.HexToBytes("{value["message"]}"),}}',2)
    else:
        t += indent(f'MessageField = Converter.Utf8ToBytes("{value["message"]}"),}}',2)
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

def type_check(key, value, txType, schema):
    if key == "fee" or key == "rental_fee":
        return f'new Amount({value})'
    if key == "timestamp":
        return f'new Timestamp({value})'
    if key == "mosaic_id":
        return to_mosaic_id(value)
    if key == "mosaics":
        return to_mosaic_array(value)
    if key == "inner_transaction":
        return innner(key, value, txType, schema)
    if key == "mosaic_definition":
        return to_mosaic_definition(value)
    if key == "multisig_account_address":
        return f'new Address(Converter.Utf8ToBytes("{value}"))'
    if key == "multisig_transaction_hash":
        return f'new Hash256(Converter.HexToBytes("{value}"))'
    if key == "rental_fee_sink":
        return f'new Address(Converter.Utf8ToBytes("{value}"))'
    if key == "cosignatures":
        if len(value) == 0:
            return 'System.Array.Empty<SizePrefixedCosignature>()'
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
    if key == "delta" or key == "amount":
        return f'new Amount({value})'
    if key == "recipient_address":
        return f'new Address(Converter.Utf8ToBytes("{value}"))'
    if isinstance(value, int):
        if value < 0:
            return f'unchecked((uint) {value})'
        return value
    if isinstance(value, str):
        return f'Converter.HexToBytes("{value}")'

with open(Path('../') / 'TransactionTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using NUnit.Framework;
using CatSdk.Nem.Factory;
using CatSdk.Nem;
using CatSdk.Utils;

namespace Test.Nem{
public class TransactionTest
{
"""
    for c in j:
        body = f'[Test]\n'
        body += f'public void {c["test_name"]}(){{\n'
        body += indent(f'var payload = "{c["payload"]}";\n')
        body += indent(f'var tx = new {c["schema_name"]} {{\n')
        body += indent(f'Network = NetworkType.TESTNET,\n', 2)
        for key in c["descriptor"]:
            if key != "type":
                body += indent(f'{to_pascal_case(key)} = {type_check(key, c["descriptor"][key], c["test_name"], c["schema_name"])},\n', 2)
        body += indent(f'}};\n')
        body += indent(f'Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));\n')
        body += f'}}\n'
        result += indent(body)
    result += "}"
    result += "}"
    output_file.write(result)
