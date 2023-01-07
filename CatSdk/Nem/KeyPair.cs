using System;
using System.Collections.Generic;
using CatSdk.CryptoTypes;
using CatSdk.Nem.External;

namespace CatSdk.Nem
{
    /**
	 * Represents an ED25519 private and public key.
	 */
    public class KeyPair
    {
        /**
	     * Creates a key pair from a private key.
	     * @param {PrivateKey} privateKey Private key.
	     */
        public KeyPair(PrivateKey privateKey)
        {
            PrivateKey = privateKey;
            var reversed = new byte[32];
            PrivateKey.bytes.CopyTo(reversed, 0);
            Array.Reverse(reversed);
            _keypair = TweetnaclNaclFastKeccak.FromSeed(reversed);
        }

        private Dictionary<string, byte[]> _keypair { get; }

        /**
		 * Gets the private key.
		 * @returns {PrivateKey} Private key.
		 */
        public PrivateKey PrivateKey { get; }

        /**
	     * Gets the public key.
	     * @returns {PublicKey} Public key.
	     */
        public PublicKey PublicKey => new PublicKey(_keypair["publicKey"]);

        /**
		 * Signs a message with the private key.
		 * @param {byte[]} message Message to sign.
		 * @returns {CryptoTypes.Signature} Message signature.
		 */
        public Signature Sign(byte[] data)
        {
            return new Signature(TweetnaclNaclFastKeccak.Detached(data, _keypair["secretKey"]));
        }
    }

    /**
	 * Verifies signatures signed by a single key pair.
	 */
    public class Verifier
    {
        /**
		 * Creates a verifier from a public key.
		 * @param {PublicKey} publicKey Public key.
		 */
        public Verifier(PublicKey publicKey)
        {
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
            return TweetnaclNaclFastKeccak.Verify(message, signature.bytes, PublicKey.bytes);
        }
    }
}