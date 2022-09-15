from pathlib import Path
import json
import re
from typing import Iterator

f = open('../models/transactions.json', 'r')
j = json.load(f)
CAMEL_CASE_PATTERN = re.compile(r'(?<!^)(?=[A-Z])')
SNAKE_CASE_PATTERN = re.compile(r'_([a-z])')

def type_converter(type):
    if type == "account_key_link_transaction":
        return "TransactionType.ACCOUNT_KEY_LINK"
    if type == "node_key_link_transaction":
        return "TransactionType.NODE_KEY_LINK"
    if type == "aggregate_complete_transaction":
        return "TransactionType.AGGREGATE_COMPLETE"
    if type == "aggregate_bonded_transaction":
        return "TransactionType.AGGREGATE_BONDED"
    if type == "voting_key_link_transaction":
        return "TransactionType.VOTING_KEY_LINK"
    if type == "vrf_key_link_transaction":
        return "TransactionType.VRF_KEY_LINK"
    if type == "hash_lock_transaction":
        return "TransactionType.HASH_LOCK"
    if type == "secret_lock_transaction":
        return "TransactionType.SECRET_LOCK"
    if type == "secret_proof_transaction":
        return "TransactionType.SECRET_PROOF"
    if type == "account_metadata_transaction":
        return "TransactionType.ACCOUNT_METADATA"
    if type == "mosaic_metadata_transaction":
        return "TransactionType.MOSAIC_METADATA"
    if type == "namespace_metadata_transaction":
        return "TransactionType.NAMESPACE_METADATA"
    if type == "mosaic_definition_transaction":
        return "TransactionType.MOSAIC_DEFINITION"
    if type == "mosaic_supply_change_transaction":
        return "TransactionType.MOSAIC_SUPPLY_CHANGE"
    if type == "mosaic_supply_revocation_transaction":
        return "TransactionType.MOSAIC_SUPPLY_REVOCATION"
    if type == "multisig_account_modification_transaction":
        return "TransactionType.MULTISIG_ACCOUNT_MODIFICATION"
    if type == "address_alias_transaction":
        return "TransactionType.ADDRESS_ALIAS"
    if type == "mosaic_alias_transaction":
        return "TransactionType.MOSAIC_ALIAS"
    if type == "namespace_registration_transaction":
        return "TransactionType.NAMESPACE_REGISTRATION"
    if type == "account_address_restriction_transaction":
        return "TransactionType.ACCOUNT_ADDRESS_RESTRICTION"
    if type == "account_mosaic_restriction_transaction":
        return "TransactionType.ACCOUNT_MOSAIC_RESTRICTION"
    if type == "account_operation_restriction_transaction":
        return "TransactionType.ACCOUNT_OPERATION_RESTRICTION"
    if type == "mosaic_address_restriction_transaction":
        return "TransactionType.MOSAIC_ADDRESS_RESTRICTION"
    if type == "mosaic_global_restriction_transaction":
        return "TransactionType.MOSAIC_GLOBAL_RESTRICTION"
    if type == "transfer_transaction":
        return "TransactionType.TRANSFER"

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
    for i in range(len(value)):
        t3 = f'new(){{\n'
        for key in value[i]:
            t3 += indent(f'{{"{to_pascal_case(key)}", {type_check(key, value[i][key], txType)}}},\n')
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_mosaic_array(value):
    t2 = f'\n'
    t2 += f'new UnresolvedMosaic[]{{\n'
    for i in range(len(value)):
        t3 = ''
        t3 += indent(f'new (){{\n')
        t3 += indent(f'MosaicId = new UnresolvedMosaicId({str(value[i]["mosaic_id"])}),',2)
        t3 += indent(f'Amount = new Amount({str(value[i]["amount"])})',2)
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
        t3 += indent(f'SignerPublicKey = new PublicKey(Converter.HexToBytes("{str(value[i]["signer_public_key"])}")),',2)
        t3 += indent(f'Signature = new Signature(Converter.HexToBytes("{str(value[i]["signature"])}")),',2)
        t3 += f'}},\n'
        t2 += indent(t3)
    t = t2
    t += f'}}\n'
    return indent(t)

def to_mosaic(value):
    m = f'\n'
    m += f'new UnresolvedMosaic{{\n'
    m += indent(f'MosaicId = new UnresolvedMosaicId({value["mosaic_id"]}),\n')
    m += indent(f'Amount = new Amount({value["amount"]}),\n')
    m += f'}}\n'
    return indent(m)

def type_check(key, value, txType):
    if key == "type":
        return type_converter(value)
    if key == "fee":
        return f'new Amount({value})'
    if key == "deadline":
        return f'new Timestamp({value})'
    if key == "transactions":
        return innner(key, value, txType)
    if key == "mosaics":
        return to_mosaic_array(value)
    if key == "cosignatures":
        return to_cosignature_array(value)
    if key == "namespace_id":
        return f'new NamespaceId({value})'
    if key == "mosaic":
        return to_mosaic(value)
    if key == "target_address":
        return f'new UnresolvedAddress(Converter.StringToAddress("{value}"))'
    if key == "address":
        return f'new Address(Converter.StringToAddress("{value}"))'
    if key == "address_additions" or key == "address_deletions":
        a = 'new UnresolvedAddress[]{\n'
        for i in range(len(value)):
            a += f'new (Converter.StringToAddress("{value[i]}")),'
        a += f'}}\n'
        return indent(a)
    if key == "value":
        if value.isdecimal():
            return f'Converter.HexToBytes("{value}")'
        else:
            return f'Converter.Utf8ToBytes("{value}")'
    if key == "restriction_additions" or key == "restriction_deletions":
        if len(value) == 0:
            if "address_restriction" in txType:
                return 'System.Array.Empty<UnresolvedAddress>()'
            if "operation_restriction" in txType:
                return 'System.Array.Empty<TransactionType>()'
            return 'System.Array.Empty<UnresolvedMosaicId>()'
        else:
            arr = []
            for i in range(len(value)):
                if "address_restriction" in txType:
                    arr.append(f'new UnresolvedAddress(Converter.StringToAddress("{value[i].upper()}"))')
                elif "operation_restriction" in txType:
                    arr.append(f'TransactionType.{value[i].upper()}')
                else:
                    arr.append(f'new UnresolvedMosaicId({value[i]})')
            arr = ",".join(map(str, arr))
            return f'new[] {{{arr}}}'
    if key == "flags":
        return to_flags(value, "MosaicFlags")
    if key == "restriction_flags":
        return to_flags(value, "AccountRestrictionFlags")
    if key == "link_action":
        return to_enum(value, "LinkAction")
    if key == "alias_action":
        return to_enum(value, "AliasAction")
    if key == "hash_algorithm":
        return to_enum(value, "LockHashAlgorithm")
    if key == "previous_restriction_type" or key == "new_restriction_type":
        return to_enum(value, "MosaicRestrictionType")
    if key == "action":
        return to_enum(value, "MosaicSupplyChangeAction")
    if key == "registration_type":
        return to_enum(value, "NamespaceRegistrationType")
    if key == "signer_public_key":
        return f'new PublicKey(Converter.HexToBytes("{value}"))'
    if key == "linked_public_key":
        if "voting_key" in txType:
            return f'new VotingPublicKey(Converter.HexToBytes("{value}"))'    
        return f'new PublicKey(Converter.HexToBytes("{value}"))'
    if key == "signature":
        return f'new Signature(Converter.HexToBytes("{value}"))'
    if key == "transactions_hash" or key == "hash":
        return f'new Hash256(Converter.HexToBytes("{value}"))'
    if isinstance(value, int):
        return value
    if isinstance(value, str):
        return f'"{value}"'

with open(Path('../') / 'TransactionNonParserTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using System;
using System.Collections.Generic;
using NUnit.Framework;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using Address = CatSdk.Symbol.Address;

namespace Test.Symbol;
public class TransactionNonParserTest
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
