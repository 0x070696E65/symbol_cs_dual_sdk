using System;
using System.Linq;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Symbol
{
    /**
     * Represents a symbol network timestamp with millisecond resolution.
     */
    public class NetworkTimestamp : CatSdk.NetworkTimestamp
    {
        public NetworkTimestamp(ulong timestamp) : base(timestamp) { }

        /**
	     * Adds a specified number of milliseconds to this timestamp.
	     * @param {ulong} count Number of milliseconds to add.
	     * @returns {NetworkTimestamp} New timestamp that is the specified number of milliseconds past this timestamp.
	     */
        public CatSdk.NetworkTimestamp AddMilliseconds(ulong count)
        {
            return new NetworkTimestamp(Timestamp + count);
        }

        /**
	     * Adds a specified number of seconds to this timestamp.
	     * @override
	     * @param {ulong} count Number of seconds to add.
	     * @returns {NetworkTimestamp} New timestamp that is the specified number of seconds past this timestamp.
	     */
        public override CatSdk.NetworkTimestamp AddSeconds(ulong count)
        {
            return AddMilliseconds(1000 * count);
        }
    }

    /**
     * Represents a Symbol network.
     */
    public class Network : BaseNetwork<SymbolAddress>
    {
        public Hash256? GenerationHashSeed { get; }

        public static readonly Network MainNet = new Network(
            "mainnet",
            0x68,
            new DateTime(2021, 3, 16, 0, 6, 25, DateTimeKind.Utc),
            new Hash256(Converter.HexToBytes("57F7DA205008026C776CB6AED843393F04CD458E0AA2D9F1D5F31A402072B2D6"))
        );
        public static readonly Network TestNet = new Network(
            "testnet",
            0x98,
            new DateTime(2022, 10, 31, 21, 07, 47, DateTimeKind.Utc),
            new Hash256(Converter.HexToBytes("49D6E1CE276A85B70EAFE52349AACCA389302E7A9754BCF1221E79494FC665A4"))
        );

        /**
	     * Creates a new network with the specified name, identifier byte and generation hash seed.
	     * @param {string} name Network name.
	     * @param {number} identifier Network identifier byte.
	     * @param {Date} epochTime Network epoch time.
	     * @param {Hash256} generationHashSeed Network generation hash seed.
	     */
        private Network(string name, byte identifier, DateTime epochTime, Hash256? generationHashSeed = null) : base(
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

    /**
     * Represents a Symbol address.
     */
    public class SymbolAddress : ByteArray
    {
        private const byte SIZE = 24;
        private const byte ENCODED_SIZE = 39;

        /**
	     * Creates a Symbol address.
	     * @param {byte[]|string|Address} address Input string, byte array or address.
	     */
        public SymbolAddress(string address) : base(SIZE, Converter.StringToAddress(address)) { }
        public SymbolAddress(ByteArray address) : base(SIZE, address.bytes) { }
        public SymbolAddress(byte[] address) : base(SIZE, address) { }

        /**
	     * Returns string representation of this object.
	     * @returns {string} String representation of this object
	     */
        public override string ToString()
        {
            return Converter.AddressToString(bytes);
        }
    }
}