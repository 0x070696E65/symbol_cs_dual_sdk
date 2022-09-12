using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using Org.BouncyCastle.Crypto.Digests;
using Hash256 = CatSdk.CryptoTypes.Hash256;
using PublicKey = CatSdk.CryptoTypes.PublicKey;
using Signature = CatSdk.CryptoTypes.Signature;

namespace CatSdk.Facade;
public class SymbolFacade
{
    public Network Network;
    public TransactionsFactory TransactionFactory;
    
    private int TRANSACTION_HEADER_SIZE = new List<int>{4, 4, Signature.SIZE, PublicKey.SIZE, 4}.Aggregate((x, y) => x + y);
    private int AGGREGATE_HASHED_SIZE = new List<int>{4, 8, 8, Hash256.SIZE}.Aggregate((x, y) => x + y);

    public SymbolFacade(Network network)
    {
        Network = network;
        TransactionFactory = new TransactionsFactory(Network);
    }

    public Hash256 HashTransaction(ITransaction transaction)
    {
        var hasher = new Sha3Digest(256);
        var hash = new byte[32];
        hasher.BlockUpdate(transaction.Signature.bytes, 0, hash.Length);
        hasher.BlockUpdate(transaction.SignerPublicKey.bytes, 0, hash.Length);
        hasher.BlockUpdate(Network.GenerationHashSeed?.bytes, 0, hash.Length);
        hasher.DoFinal(hash, 0);
        return new Hash256(hash);
    }

    public Signature SignTransaction(KeyPair keyPair, IBaseTransaction transaction)
    {
        var txByte = TransactionDataBuffer(transaction.Serialize());
        if (Network.GenerationHashSeed == null) throw new Exception("GenerationHashSeed is Null");
        var newBytes = new byte[Network.GenerationHashSeed.bytes.Length + txByte.Length];
        Network.GenerationHashSeed.bytes.CopyTo(newBytes, 0);
        txByte.CopyTo(newBytes, Network.GenerationHashSeed.bytes.Length);
        return keyPair.Sign(newBytes);
    }

    private bool IsAggregateTransaction(IReadOnlyList<byte> transactionBuffer)
    {
        var transactionTypeOffset = TRANSACTION_HEADER_SIZE + 2; // skip version and network byte
        var transactionType = (transactionBuffer[transactionTypeOffset + 1] << 8) + transactionBuffer[transactionTypeOffset];
        var a = TransactionType.AGGREGATE_BONDED.Value;
        var b = TransactionType.AGGREGATE_COMPLETE.Value;
        var aggregateTypes = new []{a, b};
        return aggregateTypes.ToList().Any(aggregateType => aggregateType == transactionType);
    }
    
    private byte[] TransactionDataBuffer(byte[] transactionBuffer){
        var dataBufferStart = TRANSACTION_HEADER_SIZE;
        var dataBufferEnd = IsAggregateTransaction(transactionBuffer)
            ? TRANSACTION_HEADER_SIZE + AGGREGATE_HASHED_SIZE
            : transactionBuffer.Length;

        var result = new byte[dataBufferEnd - dataBufferStart];
        Array.Copy(transactionBuffer, dataBufferStart, result, 0, dataBufferEnd - dataBufferStart);
        return result;
    }
}