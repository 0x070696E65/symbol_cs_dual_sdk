using Org.BouncyCastle.Crypto.Digests;
using CatSdk.Utils;

namespace CatSdk;

/**
 * Represents a network.
 */
public class BaseNetwork<T>
{
	private string Name;
	private readonly byte Identifier;
	private NetworkTimestampDatetimeConverter DatetimeConverter;
	private readonly KeccakDigest AddressHasher;
	private readonly Func<byte[], byte[], T> CreateAddress;
	private Type AddressClass;
	private Type NetworkTimestampClass;

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

		var version = new []{Identifier}.Concat(partTwoHash).ToArray();
		
		var partThreeHashBuilder = AddressHasher;
		var resultHash = new byte[partThreeHashBuilder.GetDigestSize()];
		partThreeHashBuilder.BlockUpdate(version, 0, version.Length);
		partThreeHashBuilder.DoFinal(resultHash, 0);
		var checksum = new byte[4];
		Array.Copy(resultHash, checksum, 4);
		return CreateAddress(version, checksum);
	}
}