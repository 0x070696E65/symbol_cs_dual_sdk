using System.Security.Cryptography;

namespace CatSdk.CryptoTypes
{
/**
 *  Represents a 256-bit hash.
 */
public class Hash256 : ByteArray {
    public const byte SIZE = 32;

    /**
     * Creates a hash from bytes or a hex string.
     * @param {byte[]|string} hash256 Input string or byte array.
     */
    public Hash256(byte[] hash256): base(SIZE, hash256) {
    }
    public Hash256(string hash256): base(SIZE, hash256) {
    }

    /**
	 * Creates a zeroed hash.
	 * @returns {Hash256} Zeroed hash.
	 */
    public static Hash256 Zero() {
        return new Hash256(new byte[SIZE]);
    }
}

/**
 *  Represents a private key.
 */
public class PrivateKey : ByteArray {
	public const byte SIZE = 32;

	/**
	 * Creates a private key from bytes or a hex string.
	 * @param {byte[]|string} privateKey Input string or byte array.
	 */
	public PrivateKey(byte[] privateKey): base(SIZE, privateKey) {
	}
	public PrivateKey(string privateKey): base(SIZE, privateKey) {
	}

	/**
	 * Creates a random private key.
	 * @returns {PrivateKey} Random private key.
	 */
	public static PrivateKey Random()
	{
		var rng = new RNGCryptoServiceProvider();
		var random = new byte[SIZE];
		rng.GetBytes(random);
		return new PrivateKey(random);
	}
}

/**
 *  Represents a public key.
 */
public class PublicKey : ByteArray {
	public const byte SIZE = 32;

	/**
	 * Creates a public key from bytes or a hex string.
	 * @param {byte[]|string} publicKey Input string, byte array or public key.
	 */
	public PublicKey(byte[] publicKey): base(SIZE, publicKey) {
	}
	public PublicKey(string publicKey): base(SIZE, publicKey) {
	}
}

/**
 *  Represents a signature.
 */
public class Signature : ByteArray {
	public const byte SIZE = 64;

	/**
	 * Creates a signature from bytes or a hex string.
	 * @param {byte[]|string} signature Input string or byte array.
	 */
	public Signature(byte[] signature): base(SIZE, signature) {
	}

	/**
	 * Creates a zeroed signature.
	 * @returns {Signature} Zeroed signature.
	 */
	public static Signature Zero() {
		return new Signature(new byte[SIZE]);
	}
}	
}