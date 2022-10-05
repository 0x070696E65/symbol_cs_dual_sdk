using System.Text;
using CatSdk.Symbol;
using CatSdk.Utils;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Symbol.Factory;

namespace CatSdk.Samples.Symbol;

public static class SampleMosaicCreate
{
    public static async void SampleTransaction()
    {
        var facade = new SymbolFacade(Network.TestNet);
        var alicePrivateKey = new PrivateKey(Converter.HexToBytes("PRIVATE_KEY"));
        var keyPair = new KeyPair(alicePrivateKey);
        var nonce = BitConverter.ToUInt64(Crypto.Crypto.RandomBytes(8), 0);

        var mosaicDefinitionTransaction = CreateMosaicDefinitionTransaction(facade, keyPair.PublicKey, nonce);
        var mosaicSupplyChangeTransaction = CreateMosaicSupplyChangeTransaction(facade, keyPair.PublicKey,
            mosaicDefinitionTransaction.Id, MosaicSupplyChangeAction.INCREASE, 100000);
        
        var innerTransactions = new IBaseTransaction[] { mosaicDefinitionTransaction, mosaicSupplyChangeTransaction};
        var merkleHash = SymbolFacade.HashEmbeddedTransactions(innerTransactions);
        
        var aggTx = new AggregateCompleteTransaction {
            Network = NetworkType.FromValue(facade.Network.Identifier),
            Transactions = 	innerTransactions,
            SignerPublicKey = keyPair.PublicKey,
            Fee = new Amount(1000000),
            TransactionsHash = merkleHash,
            Deadline = new Timestamp(facade.Network.FromDatetime<NetworkTimestamp>(DateTime.UtcNow).AddHours(2).Timestamp),
        };

        var aliceSignature = facade.SignTransaction(keyPair, aggTx);
        TransactionsFactory.AttachSignature(aggTx, aliceSignature);
        
        var payload = TransactionsFactory.CreatePayload(aggTx);

        const string node = "NODE_URL";
        using var client = new HttpClient();
        var content = new StringContent(payload, Encoding.UTF8, "application/json");
        var response =  client.PutAsync(node + "/transactions", content).Result;
        var responseDetailsJson = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseDetailsJson);
    }

    private static EmbeddedMosaicDefinitionTransaction CreateMosaicDefinitionTransaction(SymbolFacade facade, PublicKey publicKey, ulong nonce)
    {
        var address = facade.Network.PublicKeyToAddress(publicKey.bytes);
        var id = IdGenerator.GenerateMosaicId(address, nonce);
        return new EmbeddedMosaicDefinitionTransaction()
        {
            Network = NetworkType.FromValue(facade.Network.Identifier),
            SignerPublicKey = publicKey,
            Duration = new BlockDuration(0), //期限を設けない場合は0
            Nonce = new MosaicNonce((uint)nonce),//作成したNonceをuintに
            // Flagsは以下のようにTrueFlagの合計値
            Flags =
                new MosaicFlags((byte) new[]
                {
                    MosaicFlags.RESTRICTABLE,
                    MosaicFlags.SUPPLY_MUTABLE,
                }.ToList().Select(flag => (int) flag.Value).Sum()),
            Divisibility = 6,
            Id = new MosaicId(id),
        };
    }
    
    private static EmbeddedMosaicSupplyChangeTransaction CreateMosaicSupplyChangeTransaction(SymbolFacade facade, PublicKey publicKey, MosaicId mosaicId, MosaicSupplyChangeAction action, ulong amount)
    {
        return new EmbeddedMosaicSupplyChangeTransaction()
        {
            Network = NetworkType.FromValue(facade.Network.Identifier),
            SignerPublicKey = publicKey,
            MosaicId = new UnresolvedMosaicId(mosaicId.Value),
            Action = action,
            Delta = new Amount(amount)
        };
    }
}