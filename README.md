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

### TransferTransaction

```c#
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
const string node = "https://hideyoshi.mydns.jp:3001/transactions";
using var client = new HttpClient();
var content = new StringContent(payload, Encoding.UTF8, "application/json");
var response =  client.PutAsync(node, content).Result;
var responseDetailsJson = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseDetailsJson);

```

# Author
[toshi](https://twitter.com/toshiya_ma)

# License
SymbolCsDualSDK is under [MIT license](https://en.wikipedia.org/wiki/MIT_License).