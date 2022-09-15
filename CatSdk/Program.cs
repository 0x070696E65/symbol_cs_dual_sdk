using System.Text;
using CatSdk.Crypto;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
//using CatSdk.Symbol;
using CatSdk.Nem;
using CatSdk.Nem.Factory;
using CatSdk.Utils;
using PublicKey = CatSdk.Nem.PublicKey;
using Signature = CatSdk.Nem.Signature;
using Hash256 = CatSdk.Symbol.Hash256;
var Facade = new NemFacade(Network.TestNet);

var descriptor = new Dictionary<string, object>()
{
    {"Type", "account_key_link_transaction"},
    {"LinkAction", LinkAction.LINK},
    {"RemotePublicKey", new PublicKey(Converter.HexToBytes("6269E26026CECEFE640C3E0DE050CB9B3CFD279A0713CF00E16EDEF5D6C10EB9"))},
    {"SignerPublicKey", new PublicKey(Converter.HexToBytes("a087a6358b302a25edbd5b990aa0bbbc04c9c13911c579c8538ce880e368a8ac"))},
    {"Signature", new Signature(Converter.HexToBytes("9CB67E932354C553B34E2B8E6253B3E0C3A30E00D97D3F402B846975D681650CFB5BEF94415FDFE02EDEC9EA0F45D4728E65588F21BCC8A465E16D356D209964"))},
    {"Fee", new Amount(18370164183782063840)},
    {"Timestamp", new Timestamp(1910972016)},
};

var tx = Facade.TransactionFactory.Create(descriptor);
Console.WriteLine(Converter.BytesToHex(tx.Serialize()));
