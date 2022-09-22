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
private readonly SymbolFacade Facade = new (Network.TestNet);
```

## SampleTransaction

### TransferTransaction

# Author
[toshi](https://twitter.com/toshiya_ma)

# License
SymbolCsDualSDK is under [MIT license](https://en.wikipedia.org/wiki/MIT_License).