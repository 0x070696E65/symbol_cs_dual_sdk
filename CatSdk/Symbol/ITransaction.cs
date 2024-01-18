namespace CatSdk.Symbol
{
    public interface ITransaction : IBaseTransaction
    {
        public Signature Signature { get; set; }
        public Amount Fee { get; set; }
        public new NetworkType Network { get; set; }
        public Timestamp Deadline { get; set; }
    }
}