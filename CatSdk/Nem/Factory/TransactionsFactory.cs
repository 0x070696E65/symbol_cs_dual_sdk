using System.Reflection;
using CatSdk.Utils;

namespace CatSdk.Nem.Factory;
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
        var transaction = Factory.CreateNemFromFactory(TransactionFactory.CreateByName, transactionDescriptor);
        return transaction;
        if (transaction.Type == TransactionType.TRANSFER)
        {
        }
    }
    
    /*
	 * Converts a transaction to a non-verifiable transaction.
	 * @param {object} transaction Transaction object.
	 * @returns {object} Non-verifiable transaction object.
	 */
    public IBaseTransaction ToNonVerifiableTransaction(Dictionary<string, object> transactionDescriptor)
    {
        var networkType = Network == Network.MainNet ? NetworkType.MAINNET : NetworkType.TESTNET;
        transactionDescriptor.Add("Network", networkType);
        var transaction = Factory.CreateNemFromFactory(NonVerifiableTransactionFactory.CreateByName, transactionDescriptor);
        
        var nonVerifiableClassName = transaction.GetType().GetConstructors().ToList().Select((ctor) => ctor.Name).First();
        nonVerifiableClassName = nonVerifiableClassName.Contains("NonVerifiable") ? nonVerifiableClassName : $"NonVerifiable{nonVerifiableClassName}";

        var type = Factory.Module.Find(t => t.Name == nonVerifiableClassName);
        if (type == null) throw new NullReferenceException("transaction type is invalid");
        {
            var inst = (IBaseTransaction)Activator.CreateInstance(type)!;
            var pInfos = inst.GetType().GetProperties();
            var tInfos = transaction.GetType().GetProperties();
            
            foreach (var propertyInfo in pInfos)
            {
                var tInfo = tInfos.ToList().Find(t => t.Name == propertyInfo.Name);
                var value = tInfo?.GetValue(transaction);
                propertyInfo.SetValue(inst, value);
            }
            return inst;
        }
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
    
    private static Address? NemTypeConverter(object value)
    {
        if (value.GetType() != typeof(Address)) return null;
        var castValue = (ByteArray)value;
        return new Address(castValue.bytes);
    }
    
    private static RuleBasedTransactionFactory BuildRules(Dictionary<Type, Func<object, object>>? typeRuleOverrides)
    {
        var assm = Assembly.GetExecutingAssembly();
        var types = assm.GetTypes()
            .Where(p => p.Namespace == "CatSdk.Nem")
            .OrderBy(o => o.Name)
            .Where(s => !s.Name.Contains("<>"))
            .ToList();
        var factory = new RuleBasedTransactionFactory(types, NemTypeConverter, typeRuleOverrides);
        
        factory.Autodetect();
        
        var enumsMapping = new Dictionary<string, Type>()
        {
            {"LinkAction", typeof(LinkAction)},
            {"MessageType", typeof(MessageType)},
            {"MosaicSupplyChangeAction", typeof(MosaicSupplyChangeAction)},
            {"MosaicTransferFeeType", typeof(MosaicTransferFeeType)},
            {"MultisigAccountModificationType", typeof(MultisigAccountModificationType)},
            {"NetworkType", typeof(NetworkType)},
            {"TransactionType", typeof(TransactionType)},
        };
        foreach (var key in enumsMapping.Keys)
        {
            factory.AddEnumParser(key, enumsMapping[key]);
        }
        
        var structsMapping = new Dictionary<string, Type>()
        {
            {"Message", typeof(Message)},
            {"NamespaceId", typeof(NamespaceId)},
            {"MosaicId", typeof(MosaicId)},
            {"Mosaic", typeof(Mosaic)},
            {"SizePrefixedMosaic", typeof(SizePrefixedMosaic)},
            {"MosaicLevy", typeof(MosaicLevy)},
            {"MosaicProperty", typeof(MosaicProperty)},
            {"SizePrefixedMosaicProperty", typeof(SizePrefixedMosaicProperty)},
            {"MosaicDefinition", typeof(MosaicDefinition)},
            {"MultisigAccountModification", typeof(MultisigAccountModification)},
            {"SizePrefixedMultisigAccountModification", typeof(SizePrefixedMultisigAccountModification)},
        };
        
        foreach (var key in structsMapping.Keys)
        {
            factory.AddStructParser(key, structsMapping[key]);
        }
        
        var sdkTypeMapping = new Dictionary<string, Type>()
        {
            {"Address", typeof(Address)},
            {"Hash256", typeof(Hash256)},
            {"PublicKey", typeof(PublicKey)},
        };
        foreach (var key in sdkTypeMapping.Keys)
        {
            factory.AddPodParser(key, sdkTypeMapping[key], "Nem");
        }
        
        var arrayParserMapping = new Dictionary<string, Type>()
        {
            {"struct:SizePrefixedMosaic", typeof(SizePrefixedMosaic)},
            {"struct:SizePrefixedMosaicProperty", typeof(SizePrefixedMosaicProperty)},
            {"struct:SizePrefixedMultisigAccountModification", typeof(SizePrefixedMultisigAccountModification)},
        };
        foreach (var key in arrayParserMapping.Keys)
        {
            factory.AddArrayParser(key, arrayParserMapping[key]);
        }
        return factory;
    }
}