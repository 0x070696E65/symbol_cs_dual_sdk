using CatSdk.Nem;
using CatSdk.Nem.Factory;
using Org.BouncyCastle.Crypto.Digests;
using Hash256 = CatSdk.CryptoTypes.Hash256;
using PublicKey = CatSdk.CryptoTypes.PublicKey;
using Signature = CatSdk.CryptoTypes.Signature;

namespace CatSdk.Facade;
public class NemFacade
{
    public Network Network;
    public TransactionsFactory TransactionFactory;
    
    public NemFacade(Network network)
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

    /*public Signature SignTransaction(KeyPair keyPair, IBaseTransaction transaction)
    {
        var nonVerifiableTransaction = TransactionFactory.ToNonVerifiableTransaction(transaction);
        return keyPair.Sign(nonVerifiableTransaction.Serialize());
    }*/
}