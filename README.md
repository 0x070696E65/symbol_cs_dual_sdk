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
var descriptor = new Dictionary<string, object>(){
    {"Type", TransactionType.TRANSFER},
    {"RecipientAddress", "RECIPIENT_ADDRESS"},
    {"Mosaics", 
        new UnresolvedMosaic[]{
            new (){
                MosaicId = new UnresolvedMosaicId(0x3A8416DB2D53B6C8),
                Amount = new Amount(1000000)
            },
        }
    },
    {"SignerPublicKey", new PublicKey(Converter.HexToBytes("SIGNER_PUBLIC_KEY"))},
    {"Message", Converter.Utf8ToPlainMessage("Hello, Symbol")},
    {"Fee", new Amount(1000000)},
    {"Deadline", new Timestamp(facade.Network.FromDatetime<NetworkTimestamp>(DateTime.UtcNow).AddHours(2).Timestamp)},
};
var privateKey = new PrivateKey("SIGNER_PRIVATE_KEY");
var keyPair = new KeyPair(privateKey);

var tx = facade.TransactionFactory.Create(descriptor);
var signature = facade.SignTransaction(keyPair, tx);
var payload = facade.TransactionFactory.AttachSignature(tx, signature);
var hash = facade.HashTransaction(facade.TransactionFactory.AttachSignatureTransaction(tx, signature));
Console.WriteLine(payload);
Console.WriteLine(hash);
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
var descriptor = new Dictionary<string, object>(){
    {"Type", "transfer_transaction_v1"},
    {"RecipientAddress", "RECIPIENT_ADDRESS"},
    {"Amount", 1000000},
    {"MessageEnvelopeSize", 0},
    {"SignerPublicKey", new PublicKey(Converter.HexToBytes("SIGNER_PUBLIC_KEY"))},
    {"Fee", new Amount(1000000)},
    {"Timestamp", timestamp.Timestamp - 5},
    {"Deadline", deadline.Timestamp},
};

var tx = facade.TransactionFactory.Create(descriptor);
var privateKey = new PrivateKey("SIGNER_PRIVATE_KEY");
var keyPair = new KeyPair(privateKey);

var signature = facade.SignTransaction(keyPair, tx);
var payload = facade.TransactionFactory.AttachSignature(tx, signature);
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