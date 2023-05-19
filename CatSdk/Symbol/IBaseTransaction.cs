namespace CatSdk.Symbol
{
    public interface IBaseTransaction : IStruct
    {
        public TransactionType Type { get; }
        public PublicKey SignerPublicKey { get; set; }
        public NetworkType Network { get; set; }
        public void Sort();
    }
}