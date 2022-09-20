from pathlib import Path
import json

f = open('../crypto/1.test-address.json', 'r')
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

with open(Path('../') / 'AddressTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using CatSdk.Facade;
using CatSdk.Nem.Factory;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Nem;
public class AddressTest
{
    private readonly NemFacade MainFacade = new (Network.MainNet);
    private readonly NemFacade TestFacade = new (Network.TestNet);
"""
    for i, c in enumerate(j):
        body = f'[Test]\n'
        body += f'public void AddressTest{i}(){{\n'
        body += indent(f'const string publicKey = "{c["publicKey"]}";\n')
        body += indent(f'const string addressPublic = "{c["address_Public"]}";\n')
        body += indent(f'const string addressPublicTest = "{c["address_PublicTest"]}";\n')
        body += indent(f'var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();\n')
        body += indent(f'var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();\n')
        body += indent(f'Assert.AreEqual(addressPublic, mainAddress);\n')
        body += indent(f'Assert.AreEqual(addressPublicTest, testAddress);\n')
        body += f'}}\n'
        result += indent(body)
        if i == 100:
            break
    result += "}"
    output_file.write(result)
