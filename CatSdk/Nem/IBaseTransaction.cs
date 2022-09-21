namespace CatSdk.Nem
{
    public interface IBaseTransaction : IStruct
    {
        public TransactionType Type { get; set; }
    }
}
