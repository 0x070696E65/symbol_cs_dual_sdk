using System.Text;
using CatSdk.CryptoTypes;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using System.Text.Json;

namespace CatSdk.Samples.Symbol;

public class SampleMetadata
{
    public static async void SampleMetadataTransaction()
    {
        var facade = new SymbolFacade(Network.TestNet);
        var sourceAddress = "TBIL6D6RURP45YQRWV6Q7YVWIIPLQGLZQFHWFEQ";
        var targetAddress = "TBIL6D6RURP45YQRWV6Q7YVWIIPLQGLZQFHWFEQ";
        var scopedMetadataKey = "CF217E116AA422E2";
        var metadata = GetAccountMetadata("https://mikun-testnet.tk:3001", sourceAddress, targetAddress, scopedMetadataKey);
        Console.WriteLine(metadata);
        /*
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
        */
    }
    
    public static byte[] Xor(byte[] currentMetadataValueBytes, byte[] newMetadataValueBytes)
    {
        var length = Math.Max(currentMetadataValueBytes.Length, newMetadataValueBytes.Length);
        for (var i = currentMetadataValueBytes.Length; i < length; i++) currentMetadataValueBytes.ToList().Add(0);
        for (var i = newMetadataValueBytes.Length; i < length; i++) newMetadataValueBytes.ToList().Add(0);
        var metadataNewlist = new List<byte>();
        for (var i = 0; i < length; i++) metadataNewlist.Add((byte)(currentMetadataValueBytes[i] ^ newMetadataValueBytes[i]));
        return metadataNewlist.ToArray();
    }
    
    public static async Task<string> GetAccountMetadata(string node, string sourceAddress, string targetAddress, string scopedMetadataKey)
    {
        var url = $"{node}/metadata?sourceAddress={sourceAddress}&targetAddress={targetAddress}&scopedMetadataKey={scopedMetadataKey}";
        //using var client = new HttpClient();
        var result = await new HttpClient().GetStringAsync(url);
        //var response = await client.GetAsync(url);
        Console.WriteLine(result);
        var root = JsonSerializer.Deserialize<Root>(result);
        //return root.data[0].metadataEntry.value;
        Console.WriteLine(root.pagination);
        Console.WriteLine(root.data[0]);
        Console.WriteLine(root.data[0].metadataEntry.value);
        return ""; //Task.FromResult(root.data[0].metadataEntry.value);
    }
    
    [Serializable]
    public class Datum
    {
        public MetadataEntry metadataEntry;
        public string id;
    }

    [Serializable]
    public class MetadataEntry
    {
        public int version;
        public string compositeHash;
        public string sourceAddress;
        public string targetAddress;
        public string scopedMetadataKey;
        public string targetId;
        public int metadataType;
        public int valueSize;
        public string value;
    }

    [Serializable]
    public class Pagination
    {
        public int pageNumber;
        public int pageSize;
    }

    [Serializable]
    public class Root
    {
        public List<Datum> data;
        public Pagination pagination;
    }
}