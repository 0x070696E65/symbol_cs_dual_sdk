from pathlib import Path
import json

f = open('../crypto/5.test-mosaic-id.json', 'r')
j = json.load(f)

def indent(text, i = 1):
    tab = ''
    for j in range(i):
        tab += '\t'
    output = ''
    for line in text.splitlines():
        prefix = tab if line else ''
        output += f'{prefix}{line}\n'
    return output

with open(Path('../') / 'MosaicIdTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Symbol;
public class MosaicIdTest
{
    private readonly SymbolFacade MainFacade = new (Network.MainNet);
    private readonly SymbolFacade TestFacade = new (Network.TestNet);
"""
    for i, c in enumerate(j):
        body = f'[Test]\n'
        body += f'public void MosaicIdTest{i}(){{\n'
        body += indent(f'const uint mosaicNonce = {c["mosaicNonce"]};\n')
        body += indent(f'const string publicKey = "{c["publicKey"]}";\n')
        body += indent(f'const string mosaicIdPublic = "{c["mosaicId_Public"]}";\n')
        body += indent(f'const string mosaicIdPublicTest = "{c["mosaicId_PublicTest"]}";\n')
        body += indent(f'const string addressPublic = "{c["address_Public"]}";\n')
        body += indent(f'const string addressPublicTest = "{c["address_PublicTest"]}";\n')
        body += indent(f'var mainAd = MainFacade.TransactionFactory.Network.PublicKeyToAddress(Converter.HexToUint8(publicKey));\n')
        body += indent(f'var mainAddress = Converter.AddressToString(mainAd.bytes);\n')
        body += indent(f'var testAd = TestFacade.TransactionFactory.Network.PublicKeyToAddress(Converter.HexToUint8(publicKey));\n')
        body += indent(f'var testAddress = Converter.AddressToString(testAd.bytes);\n')
        body += indent(f'var mosaicIdMain = Converter.ToHex(new MosaicId(IdGenerator.GenerateMosaicId(mainAd, mosaicNonce)).Value, 16);\n')
        body += indent(f'var mosaicIdTest = Converter.ToHex(new MosaicId(IdGenerator.GenerateMosaicId(testAd, mosaicNonce)).Value, 16);\n')
        body += indent(f'Assert.AreEqual(addressPublic, mainAddress);\n')
        body += indent(f'Assert.AreEqual(addressPublicTest, testAddress);\n')
        body += indent(f'Assert.AreEqual(mosaicIdPublic, mosaicIdMain);\n')
        body += indent(f'Assert.AreEqual(mosaicIdPublicTest, mosaicIdTest);\n')
        body += f'}}\n'
        result += indent(body)
        if i == 100:
            break
    result += "}"
    output_file.write(result)
