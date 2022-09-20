using Org.BouncyCastle.Crypto.Digests;
namespace CatSdk.Symbol;

public static class IdGenerator
{
    private const ulong NAMESPACE_FLAG = (ulong) 1 << 63;

    public static ulong GenerateMosaicId<T>(T ownerAddress, ulong nonce) where T: ByteArray
    {
        var hasher = new Sha3Digest(256);
        var arr = new byte[32];
        hasher.BlockUpdate(BitConverter.GetBytes(nonce), 0, 4);
        hasher.BlockUpdate(ownerAddress.bytes, 0, ownerAddress.bytes.Length);
        hasher.DoFinal(arr, 0);
        var result = BitConverter.ToUInt64(arr);
        if ((result & NAMESPACE_FLAG) != 0) result -= NAMESPACE_FLAG;
        return result;
    }
    
    public static ulong GenerateNamespaceId(byte[] name, ulong parentNamespaceId = 0)
    {
        var hasher = new Sha3Digest(256);
        var arr = new byte[32];
        hasher.BlockUpdate(BitConverter.GetBytes(parentNamespaceId & 0xFFFFFFFF), 0, 4);
        hasher.BlockUpdate(BitConverter.GetBytes((parentNamespaceId >> 32) & 0xFFFFFFFF), 0, 4);
        hasher.BlockUpdate(name, 0, name.Length);
        hasher.DoFinal(arr, 0);
        var result = BitConverter.ToUInt64(arr);
        return result | NAMESPACE_FLAG;
    }
}