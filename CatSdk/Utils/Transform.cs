using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Utils;

public static class Transform
{
    static public byte[] RipemdKeccak256(byte[] payload)
    {
        var hasherBuilder1 = new KeccakDigest(256);
        var hash1 = new byte[32];
        hasherBuilder1.BlockUpdate(payload, 0, payload.Length);
        hasherBuilder1.DoFinal(hash1, 0);
        var hashBuilder2 = new RipeMD160Digest();
        var hash2 = new byte[hashBuilder2.GetDigestSize()];
        hashBuilder2.BlockUpdate(hash1, 0, hash1.Length);
        hashBuilder2.DoFinal(hash2, 0);
        return hash2;
    }
}