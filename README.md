# SymbolCsDualSDK
# Features
ブロックチェーンSymbolとNEMを一つのSDKで両方使えるC#用SDKです。<br>
***[注意]現在NEMは使えません!!***<br>
<br>
もちろんUnityで使用可能です。<br>
※Unityのバージョンは2020.3.31, 2021.3.11は動作確認済みです。

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

使い方に関しては以下の速習Symbol for C#を参照してください。<br>
https://github.com/0x070696E65/quick_learning_symbol_csharp

Symbolの学習目的や本SDKのドキュメントとして活用してください。

速習Symbolは以下のオリジナル版をC#に合わせて主にコード箇所を改変したものです。<br>
https://github.com/xembook/quick_learning_symbol<br>
オリジナル版の著作者である<a href="https://github.com/xembook" target="_blank">xembook</a>さんにお礼申し上げます。

以下に速習Symbolに含まれていない点は記載しておきます。

### TransferTransactionで複数モザイクを送信する場合はSortが必要です
```c#
var transfer = new TransferTransactionV1()
{
    Network = NetworkType.TESTNET,
    SignerPublicKey = aliceKeyPair.PublicKey,
    RecipientAddress = new UnresolvedAddress(Converter.StringToAddress("ADDRESS")),
    Mosaics = new UnresolvedMosaic[]
    {
        new()
        {
            MosaicId = new UnresolvedMosaicId(0x65DBB4CC472A5734),
            Amount = new Amount(2)
        },
        new()
        {
            MosaicId = new UnresolvedMosaicId(0x3A8416DB2D53B6C8),
            Amount = new Amount(1)
        }
    },
    Fee = new Amount(500000),
    Deadline = new Timestamp(facade.Network.FromDatetime<NetworkTimestamp>(DateTime.UtcNow).AddHours(2).Timestamp),
};
// Transaction構築後にSort()
transfer.Sort();
```
### Symbol AggregateCompleteTransaction using SSS Extension
#### AliceがSSSで署名、Bobが連署者の場合
```c#
var facade = new SymbolFacade(Network.TestNet);

var alicePublicKey = new PublicKey(Converter.HexToBytes("ALICE_PUBLIC_KEY"));
var bobPrivateKey = new PrivateKey("BOB_PRIVATE_KEY");
var bobKeyPair = new KeyPair(bobPrivateKey);

var innerTransactions = new IBaseTransaction[] {
    new EmbeddedTransferTransactionV1
    {
        Network = NetworkType.TESTNET,
        SignerPublicKey = alicePublicKey,
        RecipientAddress = new UnresolvedAddress(Converter.StringToAddress("BOB_ADDRESS")),
        Mosaics = new UnresolvedMosaic[]
        {
            new()
            {
                MosaicId = new UnresolvedMosaicId(0x3A8416DB2D53B6C8),
                Amount = new Amount(100)
            }
        }
    }, 
    new EmbeddedTransferTransactionV1
    {
        Network = NetworkType.TESTNET,
        SignerPublicKey = bobKeyPair.PublicKey,
        RecipientAddress = new UnresolvedAddress(Converter.StringToAddress("ALICE_ADDRESS")),
        Mosaics = new UnresolvedMosaic[]
        {
            new()
            {
                MosaicId = new UnresolvedMosaicId(0x3A8416DB2D53B6C8),
                Amount = new Amount(100)
            }
        }
    }
};

var merkleHash = SymbolFacade.HashEmbeddedTransactions(innerTransactions);

var aggTx = new AggregateCompleteTransactionV2 {
    Network = NetworkType.TESTNET,
    Transactions = 	innerTransactions,
    SignerPublicKey = alicePublicKey,
    Fee = new Amount(1000000),
    TransactionsHash = merkleHash,
    Deadline = new Timestamp(facade.Network.FromDatetime<NetworkTimestamp>(DateTime.UtcNow).AddHours(2).Timestamp),
};

// アグリゲートトランザクションのペイロード
Console.WriteLine(Converter.BytesToHex(aggTx.Serialize()));
```

C#で取得したペイロードをSSSで署名する
```javascript
window.SSS.setTransactionByPayload("PAYLOAD");
window.SSS.requestSign().then((signedTx) => {
    console.log(signedTx.payload)
});
```

署名済みペイロードを用いて再度C#でアグリゲートトランザクションの再構築
```c#
var ms = new MemoryStream(Converter.HexToBytes("SIGNED_TRASACTION_PEYLOAD"));
var br = new BinaryReader(ms);
var aggTx = AggregateCompleteTransaction.Deserialize(br);

var hash = facade.HashTransaction(aggTx);
var bobCosignature = new Cosignature
{
    Signature = bobKeyPair.Sign(hash.bytes),
    SignerPublicKey = bobKeyPair.PublicKey
};
aggTx.Cosignatures = new [] {bobCosignature};

var payload = TransactionsFactory.CreatePayload(aggTx);

const string node = "NODE_URL";
using var client = new HttpClient();
var content = new StringContent(payload, Encoding.UTF8, "application/json");
var response =  client.PutAsync(node + "/transactions", content).Result;
var responseDetailsJson = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseDetailsJson);
```

#### Aliceが署名者でBobがSSSで連署する場合
アグリゲートトランザクションの構築まで上と同じ
```c#
var aliceSignature = facade.SignTransaction(aliceKeyPair, aggTx);
TransactionsFactory.AttachSignature(aggTx, aliceSignature);

Console.WriteLine(Converter.BytesToHex(aggTx.Serialize()));
```

SSSで連署する。requestSignCosignatureTransactionである点に注意<br>
取得するのはトランザクションの署名（signedTx.signature）
```javascript
window.SSS.setTransactionByPayload("PAYLOAD")
window.SSS.requestSignCosignatureTransaction().then((signedTx) => {
    console.log(signedTx.signature)
});
```

```c#
var bobCosignature = new Cosignature
{
    Signature = new Signature(Converter.HexToBytes("BOB_SIGNATURE")),
    SignerPublicKey = bobKeyPair.PublicKey
};
aggTx.Cosignatures = new [] {bobCosignature};

var payload = TransactionsFactory.CreatePayload(aggTx);
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
