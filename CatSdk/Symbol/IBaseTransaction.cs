using CatSdk.Nem;

namespace CatSdk.Symbol
{
    public interface IBaseTransaction : IStruct
    {
        public TransactionType Type { get; set; }
    }
}
