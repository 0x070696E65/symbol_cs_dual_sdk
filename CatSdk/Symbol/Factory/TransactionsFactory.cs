using System.Reflection;
using System.Text;
using CatSdk.Utils;

namespace CatSdk.Symbol.Factory;
public class TransactionsFactory
{
    public RuleBasedTransactionFactory Factory;
    public Network Network;
    public TransactionsFactory(Network network, Dictionary<Type, Func<object, object>>? typeRuleOverrides = null)
    {
        Factory = BuildRules(typeRuleOverrides);
        Network = network;
    }
    
    private IBaseTransaction CreateAndExtend(Dictionary<string, object> transactionDescriptor, Type transactionFactory)
    {
        var networkType = Network == Network.MainNet ? NetworkType.MAINNET : NetworkType.TESTNET;
        transactionDescriptor.Add("Network", networkType);
        IBaseTransaction transaction;
        if (transactionFactory == typeof(TransactionFactory))
        {
            transaction = Factory.CreateFromFactory(TransactionFactory.CreateByName, transactionDescriptor);
        }
        else if (transactionFactory == typeof(EmbeddedTransactionFactory))
        {
            transaction = Factory.CreateFromFactory(EmbeddedTransactionFactory.CreateByName, transactionDescriptor);
        }
        else
        {
            throw new Exception("transactionFactory is invalid type");
        }
        if (transaction.Type == TransactionType.NAMESPACE_REGISTRATION)
        {
            if (transactionFactory == typeof(TransactionFactory))
            {
                var namespaceRegistrationTransaction = (NamespaceRegistrationTransaction) transaction;
                var rawNamespaceId = IdGenerator.GenerateNamespaceId(namespaceRegistrationTransaction.Name, namespaceRegistrationTransaction.ParentId.Value);
                namespaceRegistrationTransaction.Id = new NamespaceId(rawNamespaceId);
                return namespaceRegistrationTransaction;
            }
            else
            {
                var namespaceRegistrationTransaction = (EmbeddedNamespaceRegistrationTransaction) transaction;
                var rawNamespaceId = IdGenerator.GenerateNamespaceId(namespaceRegistrationTransaction.Name, namespaceRegistrationTransaction.ParentId.Value);
                namespaceRegistrationTransaction.Id = new NamespaceId(rawNamespaceId);
                return namespaceRegistrationTransaction;   
            }
        }
        if (transaction.Type == TransactionType.MOSAIC_DEFINITION)
        {
            if (transactionFactory == typeof(TransactionFactory))
            {
                var mosaicDefinitionTransaction = (MosaicDefinitionTransaction) transaction;
                var address = Network.PublicKeyToAddress(mosaicDefinitionTransaction.SignerPublicKey.bytes);
                mosaicDefinitionTransaction.Id = new MosaicId(IdGenerator.GenerateMosaicId(address, mosaicDefinitionTransaction.Nonce.Value));
                return mosaicDefinitionTransaction;
            }
            else
            {
                var mosaicDefinitionTransaction = (EmbeddedMosaicDefinitionTransaction) transaction;
                var address = Network.PublicKeyToAddress(mosaicDefinitionTransaction.SignerPublicKey.bytes);
                mosaicDefinitionTransaction.Id = new MosaicId(IdGenerator.GenerateMosaicId(address, mosaicDefinitionTransaction.Nonce.Value));
                return mosaicDefinitionTransaction;   
            }
        }
        return transaction;
    }

    public IBaseTransaction Create(Dictionary<string, object> transactionDescriptor)
    {
        return CreateAndExtend(transactionDescriptor, typeof(TransactionFactory));
    }
    
    public IBaseTransaction CreateEmbedded(Dictionary<string, object> transactionDescriptor)
    {
        return CreateAndExtend(transactionDescriptor, typeof(EmbeddedTransactionFactory));
    }
    
    /**
	 * Attaches a signature to a transaction.
	 * @param {object} transaction Transaction object.
	 * @param {Signature} signature Signature to attach.
	 * @returns {string} JSON transaction payload.
	 */
    public static string AttachSignature(ITransaction transaction, CatSdk.Signature signature) {
        transaction.Signature = new Signature(signature.bytes);
        var transactionBuffer = transaction.Serialize();
        var hexPayload = Converter.Uint8ToHex(transactionBuffer);
        var jsonPayload = "{\"payload\": \"" + hexPayload + "\"}";
        return jsonPayload;
    }
    
    private static UnresolvedAddress? SymbolTypeConverter(object value)
    {
        if (value.GetType() != typeof(Address)) return null;
        var castValue = (ByteArray)value;
        return new UnresolvedAddress(castValue.bytes);
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
            {"Address", typeof(CatSdk.Symbol.Address)},
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