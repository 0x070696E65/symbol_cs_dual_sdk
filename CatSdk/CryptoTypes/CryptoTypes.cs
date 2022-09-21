using System.Security.Cryptography;

namespace CatSdk.CryptoTypes
{
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
}
