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

var flag = 0xFFFF0000;
var value = -6;
var res = (ushort)((value << 16) >> 16);
Console.WriteLine((ushort)value);
Console.WriteLine(flag);
Console.WriteLine(res);
Console.WriteLine((ushort)(value - flag));

//11111111111111111111111111111010
//1111111111111010
//FFFA
//FFFFFFFA