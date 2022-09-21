using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Nem.Factory
{
    /**
     * Represents a NEM network timestamp with millisecond resolution.
     */
    public class NetworkTimestamp : CatSdk.NetworkTimestamp
    {
        public NetworkTimestamp(ulong timestamp) : base(timestamp)
        {
        }
    }

    /**
     * Represents a NEM network.
     */
    public class Network : BaseNetwork<NemAddress>
    {
        private Hash256? GenerationHashSeed { get; }
        
        public static readonly Network MainNet = new Network(
            "mainnet",
            0x68,
            new DateTime(2015, 3, 1, 0, 6, 25)
        );
        public static readonly Network TestNet = new Network(
            "testnet",
            0x98,
            new DateTime(2015, 3, 1, 0, 6, 25)
        );
        
        /**
	     * Creates a new network with the specified name, identifier byte and generation hash seed.
	     * @param {string} name Network name.
	     * @param {byte} identifier Network identifier byte.
	     * @param {DateTime} epochTime Network epoch time.
	     */
        private Network(string name, byte identifier, DateTime epochTime, Hash256? generationHashSeed = null) : base(
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

    /**
     * Represents a NEM address.
     */
    public class NemAddress : ByteArray
    {
        private const byte SIZE = 25;
        private const byte ENCODED_SIZE = 39;
        
        /**
	     * Creates a NEM address.
	     * @param {Uint8Array|string|Address} address Input string, byte array or address.
	     */
        public NemAddress(string address) : base(SIZE, Base32.Decode(address)) { }
        public NemAddress(ByteArray address) : base(SIZE, address.bytes) { }
        public NemAddress(byte[] address) : base(SIZE, address) { }
        
        /**
	     * Returns string representation of this object.
	     * @returns {string} String representation of this object
	     */
        public override string ToString()
        {
            return Base32.Encode(bytes);
        }
    }
}