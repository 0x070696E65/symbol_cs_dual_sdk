namespace CatSdk.Symbol
{
    public interface ITransaction : IBaseTransaction
    {
        public Signature Signature { get; set; }
        public Amount Fee { get; set; }
        public NetworkType Network { get; set; }
    }
}