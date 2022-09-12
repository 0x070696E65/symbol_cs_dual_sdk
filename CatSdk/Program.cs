using System.Text;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using PublicKey = CatSdk.Symbol.PublicKey;
using Signature = CatSdk.Symbol.Signature;
using Hash256 = CatSdk.Symbol.Hash256;
using Address = CatSdk.Symbol.Factory.Address;

var Facade = new SymbolFacade(Network.MainNet);

var descriptor = new Dictionary<string, object>(){
    {"Type", TransactionType.MOSAIC_DEFINITION},
    {"Duration", 10000},
    {"Nonce", 812613930},
    {"Flags", 
        new [] {
            MosaicFlags.RESTRICTABLE,
            MosaicFlags.SUPPLY_MUTABLE,
        }
    },
    {"Divisibility", 4},
    {"SignerPublicKey", new PublicKey(Converter.HexToUint8("2E834140FD66CF87B254A693A2C7862C819217B676D3943267156625E816EC6F"))},
    {"Signature", new Signature(Converter.HexToUint8("B4C9702D8F19C4B01747DBA7D4350D70FB7BFF5F0C6B4F69E5380094AC366F0A1AD74466926E3EFB80DB9187F9F6FF565AE9708D3444A0688D60A25068DDF03E"))},
    {"Fee", new Amount(18370164183782063840)},
    {"Deadline", new Timestamp(8207562320463688160)},
};
var tx = (MosaicDefinitionTransaction)Facade.TransactionFactory.Create(descriptor);
Console.WriteLine(Converter.ToHex(tx.Id.Value));
var address = Facade.TransactionFactory.Network.PublicKeyToAddress(Converter.HexToUint8("2E834140FD66CF87B254A693A2C7862C819217B676D3943267156625E816EC6F"));
var mosaicId = new MosaicId(IdGenerator.GenerateMosaicId(address, 812613930));
Console.WriteLine(mosaicId.Value);
Console.WriteLine(Converter.Uint8ToHex(BitConverter.GetBytes(mosaicId.Value)));
