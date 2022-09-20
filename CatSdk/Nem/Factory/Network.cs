using System.Numerics;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Nem.Factory;

public class NetworkTimestamp : CatSdk.NetworkTimestamp
{
    public NetworkTimestamp(BigInteger timestamp) : base(timestamp)
    {
    }
}
public class Network : BaseNetwork<NemAddress>
{
    public Hash256? GenerationHashSeed { get; set; }

    public static Network MainNet = new Network(
        "mainnet",
        0x68,
        new DateTime(2015, 3, 1, 0, 6, 25)
        );
    public static Network TestNet = new Network(
        "testnet",
        0x98,
        new DateTime(2015, 3, 1, 0, 6, 25)
    );
    public Network(string name, byte identifier, DateTime epochTime, Hash256? generationHashSeed = null) : base(
        name,
        identifier,
        new NetworkTimestampDatetimeConverter(epochTime, "seconds'"),
        new KeccakDigest(256),
        CreateAddressFunc,
        typeof(Address),
        typeof(NetworkTimestamp)
        )
    {
        GenerationHashSeed = generationHashSeed;
    }

    private static NemAddress CreateAddressFunc(byte[] addressWithoutChecksum, byte[] checksum)
    {
        var newBytes = new byte[addressWithoutChecksum.Length + checksum.Length];
        addressWithoutChecksum.CopyTo(newBytes, 0);
        checksum.CopyTo(newBytes, addressWithoutChecksum.Length);
        return new NemAddress(newBytes);
    }
}

public class NemAddress : ByteArray
{
    private const byte SIZE = 25;
    private const byte ENCODED_SIZE = 39;

    public override string ToString()
    {
        return Base32.Encode(bytes);
    }
    public NemAddress(string address) : base(SIZE, Base32.Decode(address)) { }
    public NemAddress(ByteArray address) : base(SIZE, address.bytes) { }
    public NemAddress(byte[] address) : base(SIZE, address) { }
}
