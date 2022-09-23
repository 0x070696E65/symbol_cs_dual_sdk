# SymbolCsDualSDK
# Features
ブロックチェーンSymbolとNEMを一つのSDKで両方使えるC#用SDKです。<br>
もちろんUnityで使用可能です。

# Requirement
<li>BouncyCastle.Crypto(1.9.0)</li>

Releaseに同梱<br>
[BouncyCastle.Crypto1.9.0](https://www.bouncycastle.org/csharp/)

# Reference
https://0x070696e65.github.io/symbol_cs_dual_sdk_reference/

# Usage
[Release](https://github.com/0x070696E65/symbol_cs_dual_sdk/releases) 
よりCatSdk.dllとBouncyCastle.Crypto.dll、2つのファイルをダウンロードし、ご自身のプロジェクト等より参照を追加してください。<br>
Unityの場合はAssetsフォルダ配下に配置すれば自動で参照が追加されます。

[リファレンス](https://0x070696e65.github.io/symbol_cs_dual_sdk_reference/) を参照して利用したいネームスペースを以下のように読み込んでください。<br>
※よく分からない場合でIDE（Visual StudioやRider）を利用している場合は、usingを書かなくとも参照候補が出ると思います。

```c#
using CatSdk.Facade;
```

使用するブロックチェーン、ネットワークのFacadeを作成します。<br><br>
<b>例）Symbolブロックチェーン、テストネットの場合</b>
```c#
var Facade = new SymbolFacade(Network.TestNet);
```

<b>例）Nemブロックチェーン、メインネットの場合</b>
```c#
var Facade = new NemFacade(Network.MainNet);
```

## SampleTransaction

### Symbol TransferTransaction

```c#
using System.Text;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Utils;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;

var facade = new SymbolFacade(Network.TestNet);

var tx = new TransferTransaction
{
    Network = NetworkType.TESTNET,
    RecipientAddress = new UnresolvedAddress(Converter.StringToAddress("RECIPIENT_ADDRESS")),
    Mosaics = new UnresolvedMosaic[]
    {
        new()
        {
            MosaicId = new UnresolvedMosaicId(0x3A8416DB2D53B6C8),
            Amount = new Amount(1000000)
        },
    },
    SignerPublicKey = new PublicKey(Converter.HexToBytes("SIGNER_PUBLIC_KEY")),
    Message = Converter.Utf8ToPlainMessage("Hello, Symbol"),
    Fee = new Amount(1000000),
    Deadline = new Timestamp(facade.Network.FromDatetime<NetworkTimestamp>(DateTime.UtcNow).AddHours(2).Timestamp)
};

var privateKey = new PrivateKey("BBD394D0EE4E10650D5BF15D1389580C6A6C044481E52022A98CD288A2EB679D");
var keyPair = new KeyPair(privateKey);
var signature = facade.SignTransaction(keyPair, transferTransaction);
var payload = TransactionsFactory.AttachSignature(transferTransaction, signature);
var signed = TransactionsFactory.AttachSignatureTransaction(transferTransaction, signature);
var hash = facade.HashTransaction(TransactionsFactory.AttachSignatureTransaction(transferTransaction, signature));
Console.WriteLine(payload);
Console.WriteLine(hash);
Console.WriteLine(signed.Signature);

const string node = "NODE_URL";
using var client = new HttpClient();
var content = new StringContent(payload, Encoding.UTF8, "application/json");
var response =  client.PutAsync(node + "/transactions", content).Result;
var responseDetailsJson = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseDetailsJson);

```

### NEM TransferTransaction

```c#
using System.Text;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Utils;
using CatSdk.Nem;

var facade = new NemFacade(Network.TestNet);
var timestamp = facade.Network.FromDatetime<NetworkTimestamp>(DateTime.UtcNow);
var deadline = timestamp.AddHours(2);
var tx = new TransferTransactionV1()
{
    Network = NetworkType.TESTNET,
    RecipientAddress = new Address(Converter.Utf8ToBytes("RECIPIENT_ADDRESS")),
    Amount = new Amount(1000000),
    MessageEnvelopeSize = 0,
    SignerPublicKey = new PublicKey(Converter.HexToBytes("SIGNER_PUBLIC_KEY")),
    Fee = new Amount(1000000),
    Timestamp = new Timestamp((uint)timestamp.Timestamp - 5),
    Deadline = new Timestamp((uint)deadline.Timestamp),
};
var privateKey = new PrivateKey("SIGNER_PRIVATE_KEY");
var keyPair = new KeyPair(privateKey);

var signature = facade.SignTransaction(keyPair, tx);
var payload = TransactionsFactory.AttachSignature(tx, signature);
var signed = TransactionsFactory.AttachSignatureTransaction(tx, signature);
var hash = facade.HashTransaction(signed);
Console.WriteLine(payload);
Console.WriteLine(hash);
Console.WriteLine(signed.Signature);

const string node = "NODE_URL";
using var client = new HttpClient();
var content = new StringContent(payload, Encoding.UTF8, "application/json");
var response =  client.PostAsync(node + "/transaction/announce", content).Result;
var problemDetailsJson = await response.Content.ReadAsStringAsync();
Console.WriteLine(problemDetailsJson);
```

その他のトランザクションはテストデータを参考にしてください。<br>
今後、需要があればドキュメントを更新するかもしれません。<br>

[Symbol Transactions](https://github.com/0x070696E65/symbol_cs_dual_sdk/blob/master/Test/Symbol/TransactionNonParserTest.cs)
<br>
[NEM Transactions](https://github.com/0x070696E65/symbol_cs_dual_sdk/blob/master/Test/Nem/TransactionNonParserTest.cs)

# Author
[toshi](https://twitter.com/toshiya_ma)

# License
SymbolCsDualSDK is under [MIT license](https://en.wikipedia.org/wiki/MIT_License).