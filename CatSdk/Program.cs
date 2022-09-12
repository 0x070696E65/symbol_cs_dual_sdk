using System.Text;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using PublicKey = CatSdk.Symbol.PublicKey;
using Signature = CatSdk.Symbol.Signature;
using Hash256 = CatSdk.Symbol.Hash256;
var Facade = new SymbolFacade(Network.MainNet);

var privateKey = new PrivateKey("ABF4CF55A2B3F742D7543D9CC17F50447B969E6E06F5EA9195D428AB12B7318D");
var keyPair = new KeyPair(privateKey);

var descriptor = new Dictionary<string, object>(){
    {"Type", "transfer_transaction"},
    {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
    {"Mosaics",
        Array.Empty<Mosaic>()
    },
    {"SignerPublicKey", "887a295e3f01a57cbfa7a381776140a1f4084788ae6a82a004dff09fae5c0eb2"},
    {"Fee", 0},
    {"Deadline", 0},
};
var tx = Facade.TransactionFactory.Create(descriptor);
var signed = Facade.SignTransaction(keyPair, tx);
//var signedTx = Facade.TransactionFactory.AttachSignatureTransaction(tx, tx);
((ITransaction)tx).Signature = new Signature(signed.bytes);

Console.WriteLine(Converter.BytesToHex(signed.bytes));
Console.WriteLine(Converter.BytesToHex(Facade.HashTransaction((ITransaction)tx).bytes));
