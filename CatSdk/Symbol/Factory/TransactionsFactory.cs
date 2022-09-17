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
        var transactionType = transactionDescriptor["Type"];
        if (transactionType is TransactionType type) transactionDescriptor["Type"] = TransactionTypeToString(type);
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
        var transactionType = transactionDescriptor["Type"];
        if (transactionType is TransactionType type) transactionDescriptor["Type"] = TransactionTypeToString(type);
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
        var hexPayload = Converter.BytesToHex(transactionBuffer);
        var jsonPayload = "{\"payload\": \"" + hexPayload + "\"}";
        return jsonPayload;
    }
    
    public ITransaction AttachSignatureTransaction(ITransaction transaction, CryptoTypes.Signature signature) {
        transaction.Signature = new Signature(signature.bytes);
        return transaction;
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
        //var factory = new RuleBasedTransactionFactory(types, SymbolTypeConverter, typeRuleOverrides);
        var factory = new RuleBasedTransactionFactory(types, null, typeRuleOverrides);
        factory.Autodetect();

        var flagsMapping = new []
        {
            "MosaicFlags",
            "AccountRestrictionFlags",
        };
        foreach (var key in flagsMapping)
        {
            factory.AddFlagsParser(key);
        }
        
        var enumsMapping = new []
        {
            "AliasAction",
            "LinkAction",
            "LockHashAlgorithm",
            "MosaicRestrictionType",
            "MosaicSupplyChangeAction",
            "NamespaceRegistrationType",
            "NetworkType",
            "TransactionType"
        };
        foreach (var key in enumsMapping)
        {
            factory.AddEnumParser(key);
        }
        
        factory.AddStructParser("UnresolvedMosaic");
        factory.AddStructParser("Cosignature");
        
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
        var arrayParserMapping = new []
        {
            "struct:Cosignature",
            "UnresolvedMosaicId",
            "TransactionType",
            "UnresolvedAddress",
            "struct:UnresolvedMosaic",
        };
        foreach (var key in arrayParserMapping)
        {
            factory.AddArrayParser(key);
        }
        
        return factory;
    }

    public static string TransactionTypeToString(TransactionType type)
    {
        if (type == TransactionType.ACCOUNT_KEY_LINK) return "account_key_link_transaction";
        if (type == TransactionType.NODE_KEY_LINK) return "node_key_link_transaction";
        if (type == TransactionType.AGGREGATE_COMPLETE) return "aggregate_complete_transaction";
        if (type == TransactionType.AGGREGATE_BONDED) return "aggregate_bonded_transaction";
        if (type == TransactionType.VOTING_KEY_LINK) return "voting_key_link_transaction";
        if (type == TransactionType.VRF_KEY_LINK) return "vrf_key_link_transaction";
        if (type == TransactionType.HASH_LOCK) return "hash_lock_transaction";
        if (type == TransactionType.SECRET_LOCK) return "secret_lock_transaction";
        if (type == TransactionType.SECRET_PROOF) return "secret_proof_transaction";
        if (type == TransactionType.ACCOUNT_METADATA) return "account_metadata_transaction";
        if (type == TransactionType.MOSAIC_METADATA) return "mosaic_metadata_transaction";
        if (type == TransactionType.NAMESPACE_METADATA) return "namespace_metadata_transaction";
        if (type == TransactionType.MOSAIC_DEFINITION) return "mosaic_definition_transaction";
        if (type == TransactionType.MOSAIC_SUPPLY_CHANGE) return "mosaic_supply_change_transaction";
        if (type == TransactionType.MOSAIC_SUPPLY_REVOCATION) return "mosaic_supply_revocation_transaction";
        if (type == TransactionType.MULTISIG_ACCOUNT_MODIFICATION) return "multisig_account_modification_transaction";
        if (type == TransactionType.ADDRESS_ALIAS) return "address_alias_transaction";
        if (type == TransactionType.MOSAIC_ALIAS) return "mosaic_alias_transaction";
        if (type == TransactionType.NAMESPACE_REGISTRATION) return "namespace_registration_transaction";
        if (type == TransactionType.ACCOUNT_ADDRESS_RESTRICTION) return "account_address_restriction_transaction";
        if (type == TransactionType.ACCOUNT_MOSAIC_RESTRICTION) return "account_mosaic_restriction_transaction";
        if (type == TransactionType.ACCOUNT_OPERATION_RESTRICTION) return "account_operation_restriction_transaction";
        if (type == TransactionType.MOSAIC_ADDRESS_RESTRICTION) return "mosaic_address_restriction_transaction";
        if (type == TransactionType.MOSAIC_GLOBAL_RESTRICTION) return "mosaic_global_restriction_transaction";
        if (type == TransactionType.TRANSFER) return "transfer_transaction";
        throw new Exception("type is invalid");
    }
}