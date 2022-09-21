using System.Numerics;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Symbol.Factory
{
    public class NetworkTimestamp : CatSdk.NetworkTimestamp
{
    public NetworkTimestamp(BigInteger timestamp) : base(timestamp)
    {
    }
}
public class Network : BaseNetwork<SymbolAddress>
{
    public Hash256? GenerationHashSeed { get; set; }

    public static Network MainNet = new Network(
        "mainnet",
        0x68,
        new DateTime(2021, 2, 16, 0, 6, 25),
        new Hash256(Converter.HexToBytes("57F7DA205008026C776CB6AED843393F04CD458E0AA2D9F1D5F31A402072B2D6"))
        );
    public static Network TestNet = new Network(
        "testnet",
        0x98,
        new DateTime(2021, 10, 25, 14, 0, 47),
        new Hash256(Converter.HexToBytes("7FCCD304802016BEBBCD342A332F91FF1F3BB5E902988B352697BE245F48E836"))
    );
    public Network(string name, byte identifier, DateTime epochTime, Hash256? generationHashSeed = null) : base(
        name,
        identifier,
        new NetworkTimestampDatetimeConverter(epochTime, "milliseconds'"),
        new Sha3Digest(256),
        CreateAddressFunc,
        typeof(Address),
        typeof(NetworkTimestamp)
        )
    {
        GenerationHashSeed = generationHashSeed;
    }

    private static SymbolAddress CreateAddressFunc(byte[] addressWithoutChecksum, byte[] checksum)
    {
        var newBytes = new byte[addressWithoutChecksum.Length + checksum.Length - 1];
        addressWithoutChecksum.CopyTo(newBytes, 0);
        checksum.ToList().CopyTo(0, newBytes, addressWithoutChecksum.Length, checksum.Length - 1);
        return new SymbolAddress(newBytes);
    }
}

public class SymbolAddress : ByteArray
{
    private const byte SIZE = 24;
    private const byte ENCODED_SIZE = 39;

    public override string ToString()
    {
        return Converter.AddressToString(bytes);
    } 
    
    public SymbolAddress(string address) : base(SIZE, Converter.StringToAddress(address)) { }
    public SymbolAddress(ByteArray address) : base(SIZE, address.bytes) { }
    public SymbolAddress(byte[] address) : base(SIZE, address) { }
}
}
