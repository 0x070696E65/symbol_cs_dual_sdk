using CatSdk.CryptoTypes;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace CatSdk.Nem;
public class KeyPair
{
    public KeyPair(PrivateKey privateKey)
    {
        PrivateKey = privateKey;
        PublicKey = CreatePublicKey(privateKey);
    }

    private static PublicKey CreatePublicKey(PrivateKey privateKey)
    {
        Array.Reverse(privateKey.bytes);
        /*var publicKey = new byte[privateKey.bytes.Length];
        Array.Fill(publicKey, (byte)0, 0, publicKey.Length);
        var secretKey = new byte[64];
        privateKey.bytes.CopyTo(secretKey, 0);
        publicKey.ToList().CopyTo(0, secretKey, 32, 32);
        var a = new Sha3Digest(512);
        var resultKey = new byte[64];
        a.BlockUpdate(secretKey, 0, resultKey.Length);
        a.DoFinal(resultKey, 0);
        Console.WriteLine(Converter.BytesToHex(resultKey));*/
        var blankKey = new byte[privateKey.bytes.Length];
        Array.Fill(blankKey, (byte)0, 0, blankKey.Length);
        var secretKey = new byte[64];
        privateKey.bytes.CopyTo(secretKey, 0);
        blankKey.ToList().CopyTo(0, secretKey, 32, 32);
        Console.WriteLine(Converter.BytesToHex(secretKey));
        var privateKeyRebuild = new Ed25519PrivateKeyParameters(secretKey, 0);
        var publicKeyRebuild = privateKeyRebuild.GeneratePublicKey();
        var publicKey = publicKeyRebuild.GetEncoded();
        Console.WriteLine(Converter.BytesToHex(publicKey));
        return new PublicKey(publicKey);
    }

    public PrivateKey PrivateKey { get; }
    public PublicKey PublicKey { get; }
    
    public CryptoTypes.Signature Sign(byte[] data) {
        var privateKey = new Ed25519PrivateKeyParameters(PrivateKey.bytes, 0);
        var signer = new Ed25519Signer();
        signer.Init(true, privateKey);
        signer.BlockUpdate(data, 0, data.Length);
        var signature = signer.GenerateSignature();
        return new CryptoTypes.Signature(signature);
    }
}