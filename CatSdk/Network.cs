namespace CatSdk;
using Org.BouncyCastle.Crypto.Digests;
using Utils;
public class BaseNetwork<T>
{
	public string Name;
	public byte Identifier;
	public NetworkTimestampDatetimeConverter DatetimeConverter;
	public KeccakDigest AddressHasher;
	public Func<byte[], byte[], T> CreateAddress;
	public Type AddressClass;
	public Type NetworkTimestampClass;

	public BaseNetwork(string name, byte identifier, NetworkTimestampDatetimeConverter datetimeConverter, KeccakDigest addressHasher, Func<byte[], byte[], T> createAddress, Type addressClass, Type networkTimestampClass)
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
		var checksum = new byte[3];
		Array.Copy(resultHash, checksum, 3);

		return CreateAddress(version, checksum);
	}
}