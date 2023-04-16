using CatSdk.CryptoTypes;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace CatSdk.Symbol
{
    /**
	 * Represents an ED25519 private and public key.
	 */
	public class KeyPair
	{
		/**
	     * Creates a new key pair.
	     */
		static public KeyPair GenerateNewKeyPair()
		{
			var _privateKey = new PrivateKey(Crypto.Crypto.RandomBytes(32));
			return new KeyPair(_privateKey);
		}
		/**
	     * Creates a key pair from a private key.
	     * @param {PrivateKey} privateKey Private key.
	     */
		public KeyPair(PrivateKey privateKey)
		{
			PrivateKey = privateKey;
			PublicKey = CreatePublicKey(privateKey);
		}
	        
		private static PublicKey CreatePublicKey(PrivateKey privateKey)
		{
			var privateKeyRebuild = new Ed25519PrivateKeyParameters(privateKey.bytes, 0);
			var publicKeyRebuild = privateKeyRebuild.GeneratePublicKey();
			var publicKey = publicKeyRebuild.GetEncoded();
			return new PublicKey(publicKey);
		}

		/**
	     * Gets the private key.
	     * @returns {PrivateKey} Private key.
	     */
		public PrivateKey PrivateKey { get; }
	        
		/**
	     * Gets the public key.
	     * @returns {PublicKey} Public key.
	     */
		public PublicKey PublicKey { get; }
	    
		/**
		 * Signs a message with the private key.
		 * @param {byte[]} message Message to sign.
		 * @returns {Signature} Message signature.
		 */
		public Signature Sign(byte[] data) {
			var privateKey = new Ed25519PrivateKeyParameters(PrivateKey.bytes, 0);
			var signer = new Ed25519Signer();
			signer.Init(true, privateKey);
			signer.BlockUpdate(data, 0, data.Length);
			var signature = signer.GenerateSignature();
			return new Signature(signature);
		}
		
		/**
		 * Signs a message with the private key.
		 * @param {string} message Message to sign.
		 * @returns {Signature} Message signature.
		 */
		public Signature Sign(string data)
		{
			return Sign(Converter.HexToBytes(data));
		}
	}

	/**
	 * Verifies signatures signed by a single key pair.
	 */
	public class Verifier {
		/**
		 * Creates a verifier from a public key.
		 * @param {PublicKey} publicKey Public key.
		 */
		public Verifier (PublicKey publicKey) {
			PublicKey = publicKey;
		}
		    
		public PublicKey PublicKey { get; }

		/**
		 * Verifies a message signature.
		 * @param {byte[]} message Message to verify.
		 * @param {Signature} signature Signature to verify.
		 * @returns {bool} true if the message signature verifies.
		 */
		public bool Verify(byte[] message, Signature signature)
		{
			var verifier = new Ed25519Signer();
			var publicKey = new Ed25519PublicKeyParameters(PublicKey.bytes, 0);
			verifier.Init(false, publicKey);
			verifier.BlockUpdate(message, 0, message.Length);
			return verifier.VerifySignature(signature.bytes);
		}
		
		/**
		 * Verifies a message signature.
		 * @param {string} message Message to verify.
		 * @param {Signature} signature Signature to verify.
		 * @returns {bool} true if the message signature verifies.
		 */
		public bool Verify(string message, Signature signature)
		{
			return Verify(Converter.Utf8ToBytes(message), signature);
		}
	}
}