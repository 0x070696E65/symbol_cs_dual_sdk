using CatSdk.Symbol;

namespace CatSdk.Utils
{
    public static class TransactionHelper
    {
        const ulong CosignatureByte = 104;
        public static void SetMaxFee(ITransaction transaction, int feeMultiplier, int cosignatureCount = 0)
        {
            transaction.Fee = new Amount((transaction.Size + (ulong)cosignatureCount * CosignatureByte) * (ulong)feeMultiplier);
        }
        
        public static string GetPayload(ITransaction transaction)
        {
            return Converter.BytesToHex(transaction.Serialize());
        }
        
        public static T TransactionDeserializer<T>(string payload, Func<BinaryReader, T> func) where T: ISerializer
        {
            var barr = Converter.HexToBytes(payload);
            var ms = new MemoryStream(barr);
            var br = new BinaryReader(ms);
            return func(br);
        }
        
        public static Cosignature CosignatureDeserializer(string payload)
        {
            var barr = Converter.HexToBytes(payload);
            var ms = new MemoryStream(barr);
            var br = new BinaryReader(ms);
            return Cosignature.Deserialize(br);
        }
    }
}