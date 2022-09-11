namespace CatSdk.Symbol;

public interface ITransaction : IBaseTransaction
{
    public Signature Signature { get; set; }
}

