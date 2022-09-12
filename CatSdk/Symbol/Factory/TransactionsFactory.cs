using System.Reflection;
using CatSdk.Utils;

namespace CatSdk.Symbol.Factory;
public class TransactionsFactory
{
    private readonly RuleBasedTransactionFactory Factory;
    public readonly Network Network;
    public TransactionsFactory(Network network, Dictionary<Type, Func<object, object>>? typeRuleOverrides = null)
    {
        Factory = BuildRules(typeRuleOverrides);
        Network = network;
    }
    
    public ITransaction Create(Dictionary<string, object> transactionDescriptor)
    {
        var networkType = Network == Network.MainNet ? NetworkType.MAINNET : NetworkType.TESTNET;
        transactionDescriptor.Add("Network", networkType);
        var transaction = Factory.CreateFromFactory(TransactionFactory.CreateByName, transactionDescriptor);
        if (transaction.Type == TransactionType.NAMESPACE_REGISTRATION)
        {
            var namespaceRegistrationTransaction = (NamespaceRegistrationTransaction) transaction;
            var rawNamespaceId = IdGenerator.GenerateNamespaceId(namespaceRegistrationTransaction.Name, namespaceRegistrationTransaction.ParentId.Value); 
            namespaceRegistrationTransaction.Id = new NamespaceId(rawNamespaceId);
            return namespaceRegistrationTransaction; 
        }

        if (transaction.Type != TransactionType.MOSAIC_DEFINITION) return transaction;
        var mosaicDefinitionTransaction = (MosaicDefinitionTransaction) transaction;
        var address = Network.PublicKeyToAddress(mosaicDefinitionTransaction.SignerPublicKey.bytes);
        mosaicDefinitionTransaction.Id = new MosaicId(IdGenerator.GenerateMosaicId(address, mosaicDefinitionTransaction.Nonce.Value));
        return mosaicDefinitionTransaction;
    }
    
    public IBaseTransaction CreateEmbedded(Dictionary<string, object> transactionDescriptor)
    {
        var networkType = Network == Network.MainNet ? NetworkType.MAINNET : NetworkType.TESTNET;
        transactionDescriptor.Add("Network", networkType);
        var transaction = Factory.CreateFromFactory(EmbeddedTransactionFactory.CreateByName, transactionDescriptor);
        if (transaction.Type == TransactionType.NAMESPACE_REGISTRATION)
        {
            var namespaceRegistrationTransaction = (EmbeddedNamespaceRegistrationTransaction) transaction;
            var rawNamespaceId = IdGenerator.GenerateNamespaceId(namespaceRegistrationTransaction.Name, namespaceRegistrationTransaction.ParentId.Value); 
            namespaceRegistrationTransaction.Id = new NamespaceId(rawNamespaceId); 
            return namespaceRegistrationTransaction;
        }

        if (transaction.Type != TransactionType.MOSAIC_DEFINITION) return transaction;
        var mosaicDefinitionTransaction = (EmbeddedMosaicDefinitionTransaction) transaction;
        var address = Network.PublicKeyToAddress(mosaicDefinitionTransaction.SignerPublicKey.bytes);
        mosaicDefinitionTransaction.Id = new MosaicId(IdGenerator.GenerateMosaicId(address, mosaicDefinitionTransaction.Nonce.Value));
        return mosaicDefinitionTransaction;
    }
    
    public string AttachSignature(ITransaction transaction, CryptoTypes.Signature signature) {
        transaction.Signature = new Signature(signature.bytes);
        var transactionBuffer = transaction.Serialize();
        var hexPayload = Converter.Uint8ToHex(transactionBuffer);
        var jsonPayload = "{\"payload\": \"" + hexPayload + "\"}";
        return jsonPayload;
    }
    
    public ITransaction AttachSignatureTransaction(ITransaction transaction, CryptoTypes.Signature signature) {
        transaction.Signature = new Signature(signature.bytes);
        return transaction;
    }
    
    private static Address? SymbolTypeConverter(object value)
    {
        if (value.GetType() != typeof(Address)) return null;
        var castValue = (ByteArray)value;
        return new Address(castValue.bytes);
    }
    
    private static RuleBasedTransactionFactory BuildRules(Dictionary<Type, Func<object, object>>? typeRuleOverrides)
    {
        var assm = Assembly.GetExecutingAssembly();
        var types = assm.GetTypes()
            .Where(p => p.Namespace == "CatSdk.Symbol")
            .OrderBy(o => o.Name)
            .Where(s => !s.Name.Contains("<>"))
            .ToList();
        var factory = new RuleBasedTransactionFactory(types, SymbolTypeConverter, typeRuleOverrides);
        factory.Autodetect();

        var flagsMapping = new Dictionary<string, Type>()
        {
            {"MosaicFlags", typeof(MosaicFlags)},
            {"AccountRestrictionFlags", typeof(AccountRestrictionFlags)},
        };
        foreach (var key in flagsMapping.Keys)
        {
            factory.AddFlagsParser(key, flagsMapping[key]);
        }
        
        var enumsMapping = new Dictionary<string, Type>()
        {
            {"AliasAction", typeof(AliasAction)},
            {"LinkAction", typeof(LinkAction)},
            {"LockHashAlgorithm", typeof(LockHashAlgorithm)},
            {"MosaicRestrictionType", typeof(MosaicRestrictionType)},
            {"MosaicSupplyChangeAction", typeof(MosaicSupplyChangeAction)},
            {"NamespaceRegistrationType", typeof(NamespaceRegistrationType)},
            {"NetworkType", typeof(NetworkType)},
            {"TransactionType", typeof(TransactionType)},
        };
        foreach (var key in enumsMapping.Keys)
        {
            factory.AddEnumParser(key, enumsMapping[key]);
        }
        
        factory.AddStructParser("UnresolvedMosaic", typeof(UnresolvedMosaic));
        
        var sdkTypeMapping = new Dictionary<string, Type>()
        {
            {"UnresolvedAddress", typeof(UnresolvedAddress)},
            {"Address", typeof(Address)},
            {"Hash256", typeof(Hash256)},
            {"PublicKey", typeof(PublicKey)},
            {"VotingPublicKey", typeof(VotingPublicKey)},
            {"Signature", typeof(Signature)},
        };
        foreach (var key in sdkTypeMapping.Keys)
        {
            factory.AddPodParser(key, sdkTypeMapping[key]);
        }
        
        var arrayParserMapping = new Dictionary<string, Type>()
        {
            {"UnresolvedMosaicId", typeof(UnresolvedMosaicId)},
            {"TransactionType", typeof(TransactionType)},
            {"UnresolvedAddress", typeof(UnresolvedAddress)},
            {"struct:UnresolvedMosaic", typeof(UnresolvedMosaic)},
        };
        foreach (var key in arrayParserMapping.Keys)
        {
            factory.AddArrayParser(key, arrayParserMapping[key]);
        }
        return factory;
    }
   
}