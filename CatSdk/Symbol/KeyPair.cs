using CatSdk.CryptoTypes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace CatSdk.Symbol
{
    public class KeyPair
    {
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

        public PrivateKey PrivateKey { get; }
        public PublicKey PublicKey { get; }
    
        public CryptoTypes.Signature Sign(byte[] data) {
            var privateKey = new Ed25519PrivateKeyParameters(PrivateKey.bytes, 0);
            var signer = new Ed25519Signer();
            signer.Init(true, privateKey);
            signer.BlockUpdate(data, 0, data.Length);
            var signature = signer.GenerateSignature();
            return new CryptoTypes.Signature(signature);
        }
    }
}