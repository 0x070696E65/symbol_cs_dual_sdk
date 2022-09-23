using CatSdk.Nem;
using CatSdk.Nem.Factory;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Facade
{
    /**
     * Facade used to interact with NEM blockchain.
     */
    public class NemFacade
    {
        public readonly Network Network;
        public readonly TransactionsFactory TransactionFactory;
    
        /**
         * Creates a NEM facade.
         * @param {Network} network NEM network or network name.
         */
        public NemFacade(Network network)
        {
            Network = network;
            TransactionFactory = new TransactionsFactory(Network);
        }

        /**
         * Hashes a NEM transaction.
         * @param {ITransaction} transaction Transaction object.
         * @returns {Hash256} Transaction hash.
         */
        public Hash256 HashTransaction(ITransaction transaction)
        {
            var hasher = new KeccakDigest(256);
            var hash = new byte[32];
            var nonVerifiableTransaction = TransactionsFactory.ToNonVerifiableTransaction(transaction);
            hasher.BlockUpdate(nonVerifiableTransaction.Serialize(), 0, nonVerifiableTransaction.Serialize().Length);
            hasher.DoFinal(hash, 0);
            return new Hash256(hash);
        }

        /**
	     * Signs a NEM transaction.
	     * @param {KeyPair} keyPair Key pair.
	     * @param {IBaseTransaction} transaction Transaction object.
	     * @returns {Signature} Transaction signature.
	     */
        public Signature SignTransaction(KeyPair keyPair, IBaseTransaction transaction)
        {
            var nonVerifiableTransaction = TransactionsFactory.ToNonVerifiableTransaction(transaction);
            return keyPair.Sign(nonVerifiableTransaction.Serialize());
        }
        
        /**
	     * Verifies a NEM transaction.
	     * @param {IBaseTransaction} transaction Transaction object.
	     * @param {Signature} signature Signature to verify.
	     * @returns {bool} true if transaction signature is verified.
	     */
        public static bool VerifyTransaction(ITransaction transaction, Signature signature) {
            var nonVerifiableTransaction = TransactionsFactory.ToNonVerifiableTransaction(transaction);
            var publicKey = new PublicKey(transaction.SignerPublicKey.bytes);
            return new Verifier(publicKey).Verify(nonVerifiableTransaction.Serialize(), signature);
        }
    }
}