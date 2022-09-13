using System.Text;
using CatSdk.Crypto;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using PublicKey = CatSdk.Symbol.PublicKey;
using Signature = CatSdk.Symbol.Signature;
using Hash256 = CatSdk.Symbol.Hash256;
var Facade = new SymbolFacade(Network.MainNet);

var privateKeyAlice = new PrivateKey("14D1D35E7CD97AD165A451548152139A20901715D41A5DE970948E786F9887B3");
var aliceKeyPair = new KeyPair(privateKeyAlice);

var privateKeyBob = new PrivateKey("DD45058E85CEEA02B7261A0322F3E7DABB41010F30CD4F249A557FED37896DAC");
var bobKeyPair = new KeyPair(privateKeyBob);

var privatekeyCarol = new PrivateKey("7BACE57B2B33F665857A8A9B3F6D06A568DD245C5A8E3ADBF17955CC3A0E225C");
var carolKeyPair = new KeyPair(privatekeyCarol);

const string text = "text";
var str = Crypto.Encode(aliceKeyPair.PrivateKey.bytes, bobKeyPair.PublicKey.bytes, text);
Console.WriteLine(str);

var dec = Crypto.Decode(carolKeyPair.PrivateKey.bytes, aliceKeyPair.PublicKey.bytes, str);
Console.WriteLine(dec);