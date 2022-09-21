using System;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Nem;
using CatSdk.Nem.Factory;
using CatSdk.Utils;

namespace CatSdk
{
    public class Program
    {
        public void Main(string[] args)
        {
            var Facade = new NemFacade(Network.TestNet);
            var a = Facade.Network.PublicKeyToAddress("C5F54BA980FCBB657DBAAA42700539B207873E134D2375EFEAB5F1AB52F87844");
            var keyPair = new KeyPair(new PrivateKey("ABF4CF55A2B3F742D7543D9CC17F50447B969E6E06F5EA9195D428AB12B7318D"));
            var signature = keyPair.Sign(Converter.HexToBytes("ABF4CF55A2B3F742D7543D9CC17F50447B969E6E06F5EA9195D428AB12B7318D"));
        } 
    }
}