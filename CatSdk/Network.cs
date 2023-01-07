using Org.BouncyCastle.Crypto.Digests;
using CatSdk.Utils;
using System;
using System.Linq;

namespace CatSdk
{
    /**
	 * Represents a network.
	 */
    public class BaseNetwork<T>
    {
        public readonly string Name;
        public readonly byte Identifier;
        public readonly NetworkTimestampDatetimeConverter DatetimeConverter;
        public readonly KeccakDigest AddressHasher;
        public readonly Func<byte[], byte[], T> CreateAddress;
        public Type AddressClass;
        public readonly Type NetworkTimestampClass;

        /**
		 * Creates a new network with the specified name and identifier byte.
		 * @param {string} name Network name.
		 * @param {byte} identifier Network identifier byte.
		 * @param {NetworkTimestampDatetimeConverter} datetimeConverter Network timestamp datetime converter associated with this network.
		 * @param {KeccakDigest} addressHasher Gets the primary hasher to use in the public key to address conversion.
		 * @param {Func} createAddress Creates an encoded address from an address without checksum and checksum bytes.
		 * @param {Type} AddressClass Address class associated with this network.
		 * @param {Type} NetworkTimestampClass Network timestamp class associated with this network.
		 */
        protected BaseNetwork(string name, byte identifier, NetworkTimestampDatetimeConverter datetimeConverter, KeccakDigest addressHasher, Func<byte[], byte[], T> createAddress, Type addressClass, Type networkTimestampClass)
        {
            Name = name;
            Identifier = identifier;
            DatetimeConverter = datetimeConverter;
            AddressHasher = addressHasher;
            CreateAddress = createAddress;
            AddressClass = addressClass;
            NetworkTimestampClass = networkTimestampClass;
        }

        /**
	     * Converts a public key to an address.
	     * @param {PublicKey} publicKey Public key to convert.
	     * @returns {Address} Address corresponding to the public key input.
	     */
        public T PublicKeyToAddress(string publicKey)
        {
            return PublicKeyToAddress(Converter.HexToBytes(publicKey));
        }

        /**
	     * Converts a public key to an address.
	     * @param {PublicKey} publicKey Public key to convert.
	     * @returns {Address} Address corresponding to the public key input.
	     */
        public T PublicKeyToAddress(byte[] publicKey)
        {
            var partOneHashBuilder = AddressHasher;
            var partOneHash = new byte[partOneHashBuilder.GetDigestSize()];
            partOneHashBuilder.BlockUpdate(publicKey, 0, publicKey.Length);
            partOneHashBuilder.DoFinal(partOneHash, 0);
            var partTwoHashBuilder = new RipeMD160Digest();
            var partTwoHash = new byte[partTwoHashBuilder.GetDigestSize()];
            partTwoHashBuilder.BlockUpdate(partOneHash, 0, partOneHash.Length);
            partTwoHashBuilder.DoFinal(partTwoHash, 0);

            var version = new[] { Identifier }.Concat(partTwoHash).ToArray();

            var partThreeHashBuilder = AddressHasher;
            var resultHash = new byte[partThreeHashBuilder.GetDigestSize()];
            partThreeHashBuilder.BlockUpdate(version, 0, version.Length);
            partThreeHashBuilder.DoFinal(resultHash, 0);
            var checksum = new byte[4];
            Array.Copy(resultHash, checksum, 4);
            return CreateAddress(version, checksum);
        }

        /**
		 * Converts a network timestamp to a datetime.
		 * @param {NetworkTimestamp} referenceNetworkTimestamp Reference network timestamp to convert.
		 * @returns {DateTime} Datetime representation of the reference network timestamp.
		 */
        public DateTime ToDatetime(NetworkTimestamp referenceNetworkTimestamp) => DatetimeConverter.ToDatetime(referenceNetworkTimestamp.Timestamp);

        /**
		 * Converts a datetime to a network timestamp.
		 * @param {DateTime} referenceDatetime Reference datetime to convert.
		 * @returns {NetworkTimestamp} Network timestamp representation of the reference datetime.
		 */
        public E FromDatetime<E>(DateTime referenceDatetime) where E : NetworkTimestamp
        {
            var instance = Activator.CreateInstance(NetworkTimestampClass, DatetimeConverter.ToDifference(referenceDatetime));
            if (NetworkTimestampClass is null) throw new NullReferenceException("");
            if (instance.GetType() == NetworkTimestampClass) return (E)instance;
            throw new Exception("instance is invalid type");
        }

        /**
		 * Returns string representation of this object.
		 * @returns {string} String representation of this object
		 */
        public override string ToString()
        {
            return Name;
        }
    }
}