using CatSdk.CryptoTypes;

namespace CatSdk.Nem;

public interface IBaseTransaction : IStruct
{
    public PublicKey SignerPublicKey { get; set; }
    
    public byte Version { get; set; }

    //public NetworkType Network { get; set; }

    //public TransactionType Type { get; set; }
}
