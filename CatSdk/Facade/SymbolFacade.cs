using System;
using System.Collections.Generic;
using System.Linq;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Facade
{
    /**
	 * Facade used to interact with Symbol blockchain.
	 */
    public class SymbolFacade
    {
        public Network Network;
        public readonly TransactionsFactory TransactionFactory;

        private readonly int TRANSACTION_HEADER_SIZE = new List<int> { 4, 4, Signature.SIZE, PublicKey.SIZE, 4 }.Aggregate((x, y) => x + y);
        private readonly int AGGREGATE_HASHED_SIZE = new List<int> { 4, 8, 8, Hash256.SIZE }.Aggregate((x, y) => x + y);

        /**
		 * Creates a Symbol facade.
		 * @param {Network} network Symbol network or network name.
		 */
        public SymbolFacade(Network network)
        {
            Network = network;
            TransactionFactory = new TransactionsFactory(Network);
        }

        /**
		 * Hashes a Symbol transaction.
		 * @param {ITransaction} transaction Transaction object.
		 * @returns {Hash256} Transaction hash.
		 */
        public Hash256 HashTransaction(ITransaction transaction)
        {
            var hasher = new Sha3Digest(256);
            var hash = new byte[32];
            hasher.BlockUpdate(transaction.Signature.bytes, 0, transaction.Signature.bytes.Length);
            hasher.BlockUpdate(transaction.SignerPublicKey.bytes, 0, transaction.SignerPublicKey.bytes.Length);
            hasher.BlockUpdate(Network.GenerationHashSeed?.bytes, 0, Network.GenerationHashSeed!.bytes.Length);
            var transactionBytes = TransactionDataBuffer(transaction.Serialize());
            hasher.BlockUpdate(transactionBytes, 0, transactionBytes.Length);
            hasher.DoFinal(hash, 0);
            return new Hash256(hash);
        }
        
        /**
		 * Hashes a Symbol transaction.
		 * @param {ITransaction} transaction Transaction object.
         * @param {Signature} signature.
		 * @returns {Hash256} Transaction hash.
		 */
        public Hash256 HashTransaction(ITransaction transaction, Signature signature)
        {
	        transaction.Signature = signature;
	        return HashTransaction(transaction);
        }

        /**
		 * Signs a Symbol transaction.
		 * @param {KeyPair} keyPair Key pair.
		 * @param {IBaseTransaction} transaction Transaction object.
		 * @returns {Signature} Transaction signature.
		 */
        public Signature SignTransaction(KeyPair keyPair, IBaseTransaction transaction)
        {
            var txByte = TransactionDataBuffer(transaction.Serialize());
            if (Network.GenerationHashSeed == null) throw new Exception("GenerationHashSeed is Null");
            var newBytes = new byte[Network.GenerationHashSeed.bytes.Length + txByte.Length];
            Network.GenerationHashSeed.bytes.CopyTo(newBytes, 0);
            txByte.CopyTo(newBytes, Network.GenerationHashSeed.bytes.Length);
            return keyPair.Sign(newBytes);
        }
        
        /**
		 * Verifies a Symbol transaction.
		 * @param {IBaseTransaction} transaction Transaction object.
		 * @param {Signature} signature Signature to verify.
         * @param {PublicKey} signer PublicKey.
		 * @returns {bool} true if transaction signature is verified.
		 */
        public bool VerifyTransaction(ITransaction transaction, Signature signature, PublicKey? publicKey = null)
        {
            var txByte = TransactionDataBuffer(transaction.Serialize());
            if (Network.GenerationHashSeed == null) throw new Exception("GenerationHashSeed is Null");
            var newBytes = new byte[Network.GenerationHashSeed.bytes.Length + txByte.Length];
            Network.GenerationHashSeed.bytes.CopyTo(newBytes, 0);
            txByte.CopyTo(newBytes, Network.GenerationHashSeed.bytes.Length);
            return publicKey == null ? new Verifier(transaction.SignerPublicKey).Verify(newBytes, signature) : new Verifier(publicKey).Verify(newBytes, signature);
        }

        /**
		 * Hashes embedded transactions of an aggregate."""
		 * @param {array&lt;ITransaction&gt;} embeddedTransactions Embedded transactions to hash.
		 * @returns {Hash256} Aggregate transactions hash.
		 */
        public static Hash256 HashEmbeddedTransactions(IBaseTransaction[] embeddedTransactions)
        {
            var hashBuilder = new MerkleHashBuilder();
            embeddedTransactions.ToList().ForEach(embeddedTransaction =>
            {
                var hasher = new Sha3Digest(256);
                var serialize = embeddedTransaction.Serialize();
                var hash = new byte[32];
                hasher.BlockUpdate(serialize, 0, serialize.Length);
                hasher.DoFinal(hash, 0);
                hashBuilder.Update(new Hash256(hash));
            });

            return hashBuilder.Final();
        }

        private bool IsAggregateTransaction(IReadOnlyList<byte> transactionBuffer)
        {
            var transactionTypeOffset = TRANSACTION_HEADER_SIZE + 2; // skip version and network byte
            var transactionType = (transactionBuffer[transactionTypeOffset + 1] << 8) + transactionBuffer[transactionTypeOffset];
            var a = TransactionType.AGGREGATE_BONDED.Value;
            var b = TransactionType.AGGREGATE_COMPLETE.Value;
            var aggregateTypes = new[] { a, b };
            return aggregateTypes.ToList().Any(aggregateType => aggregateType == transactionType);
        }

        private byte[] TransactionDataBuffer(byte[] transactionBuffer)
        {
            var dataBufferStart = TRANSACTION_HEADER_SIZE;
            var dataBufferEnd = IsAggregateTransaction(transactionBuffer)
                ? TRANSACTION_HEADER_SIZE + AGGREGATE_HASHED_SIZE
                : transactionBuffer.Length;

            var result = new byte[dataBufferEnd - dataBufferStart];
            Array.Copy(transactionBuffer, dataBufferStart, result, 0, dataBufferEnd - dataBufferStart);
            return result;
        }
    }
}