from pathlib import Path
import json

f = open('../crypto/2.test-sign.json', 'r')
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

with open(Path('../') / 'SignTest.cs', 'w', encoding='utf8', newline='\n') as output_file:
    result = """
using CatSdk.CryptoTypes;
using CatSdk.Symbol;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Symbol;
public class SignTest
{
"""
    for i, c in enumerate(j):
        body = f'[Test]\n'
        body += f'public void AddressTest{i}(){{\n'
        body += indent(f'const string pKey = "{c["privateKey"]}";\n')
        body += indent(f'const string pubKey = "{c["publicKey"]}";\n')
        body += indent(f'const string data = "{c["data"]}";\n')
        body += indent(f'const string sig = "{c["signature"]}";\n')
        body += indent(f'var privateKey = new PrivateKey(pKey);\n')
        body += indent(f'var keyPair = new KeyPair(privateKey);\n')
        body += indent(f'var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);\n')
        body += indent(f'var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);\n')
        body += indent(f'Assert.AreEqual(pubKey, publicKey);\n')
        body += indent(f'Assert.AreEqual(sig, signature);\n')
        body += f'}}\n'
        result += indent(body)
        if i == 100:
            break
    result += "}"
    output_file.write(result)
