namespace CatSdk.Symbol;

public interface ITransaction : IBaseTransaction
{
    public Signature Signature { get; set; }
    public PublicKey SignerPublicKey { get; set; }
}

