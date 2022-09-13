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
public class Network : Network<Address>
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

    private static Address CreateAddressFunc(byte[] addressWithoutChecksum, byte[] checksum)
    {
        var newBytes = new byte[addressWithoutChecksum.Length + checksum.Length];
        addressWithoutChecksum.CopyTo(newBytes, 0);
        checksum.CopyTo(newBytes, addressWithoutChecksum.Length);
        return new Address(newBytes);
    }
}
/*
public class Address : ByteArray
{
    private const byte SIZE = 24;
    private const byte ENCODED_SIZE = 39;

    private static byte[] StrToAddress(string address)
    {
        var rawBytes = Base32.Decode(address + "A");
        Array.Resize(ref rawBytes, rawBytes.Length - 1);
        return rawBytes;
    }
    public Address(string address) : base(SIZE, StrToAddress(address)) { }
    public Address(ByteArray address) : base(SIZE, address.bytes) { }
    public Address(byte[] address) : base(SIZE, address) { }
}
*/