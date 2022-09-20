using CatSdk.CryptoTypes;
using CatSdk.Nem.External;

namespace CatSdk.Nem;
public class KeyPair
{
    public KeyPair(PrivateKey privateKey)
    {
        PrivateKey = privateKey;
        var reversed = new byte[32];
        PrivateKey.bytes.CopyTo(reversed, 0);
        Array.Reverse(reversed);
        _keypair = TweetnaclNaclFastKeccak.FromSeed(reversed);
    }

    private Dictionary<string, byte[]> _keypair { get; }
    public PrivateKey PrivateKey { get; }

    public PublicKey PublicKey => new PublicKey(_keypair["publicKey"]);
    
    public CryptoTypes.Signature Sign(byte[] data)
    {
        return new CryptoTypes.Signature(TweetnaclNaclFastKeccak.Detached(data, _keypair["secretKey"]));
    }
}