using System.Text;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;

namespace CatSdk;
public class TransactionDescriptorProcessor
{
    private readonly Dictionary<string, object> TransactionDescriptor;
    private readonly Dictionary<string, Func<object, object>> TypeParsingRules;
    private readonly Func<object, object?>? TypeConverter;
    private Dictionary<string, string>? TypeHints;
    public TransactionDescriptorProcessor(Dictionary<string, object> transactionDescriptor, Dictionary<string, Func<object, object>> typeParsingRules, Func<object, object?>? typeConverter = null)
    {
        TransactionDescriptor = transactionDescriptor;
        TypeParsingRules = typeParsingRules;
        TypeConverter = typeConverter ?? (value => value);
        TypeHints = null;
    }
    
    private object LookupValueAndApplyTypeHints(string key) {
        if (null == TransactionDescriptor[key])
            throw new ArgumentOutOfRangeException($"transaction descriptor does not have attribute {key}");
        var value = TransactionDescriptor[key];
        if (TypeHints == null) return value;
        if (!TypeHints.ContainsKey(key)) return value;
        var typeHint = TypeHints?[key];
        if (typeHint != null && TypeParsingRules.ContainsKey(typeHint)) value = TypeParsingRules[typeHint](value);
        return value;
    }

    public object? LookupValue(string key)
    {
        var value = LookupValueAndApplyTypeHints(key);
        value = ValueParser(key, value);
        if (value.GetType() != typeof(Dictionary<string, object>[]))
        {
            return TypeConverter?.Invoke(value);
        }
        switch (key)
        {
            case "Transactions":
            {
                var netWorkType = (NetworkType) TransactionDescriptor["Network"] == NetworkType.MAINNET
                    ? Network.MainNet
                    : Network.TestNet;
                var facade = new SymbolFacade(netWorkType);
                var innerTransactions = ((Dictionary<string, object>[]) value).ToList().Select((tx) => facade.TransactionFactory.CreateEmbedded(tx)).ToArray();
                return TypeConverter?.Invoke(innerTransactions);
            }
            case "Cosignatures":
            {
                var cosignatures = ((Dictionary<string, object>[]) value).ToList().Select((cosignatureDic) =>
                {
                    var signerPublicKey = new PublicKey(Converter.HexToUint8((string)cosignatureDic["SignerPublicKey"]));
                    var signature = new Signature(Converter.HexToUint8((string)cosignatureDic["Signature"]));
                    return new Cosignature
                    {
                        SignerPublicKey = signerPublicKey,
                        Signature = signature
                    };
                }).ToArray();
                return TypeConverter?.Invoke(cosignatures);
            }
            default:
                return TypeConverter?.Invoke(value);
        }
    }

    public void CopyTo(IStruct transaction, string[]? ignoreKeys = null)
    {
        foreach (var (key, _) in TransactionDescriptor)
        {
            if(ignoreKeys != null && -1 != Array.IndexOf(ignoreKeys, key)) continue;
            var p = transaction.GetType().GetProperty(key);
            if(p == null) throw new ArgumentOutOfRangeException($"transaction does not have attribute {key}");
            var value = LookupValue(key);
            if (value is string s) value = Converter.IsHexString(s) ? Converter.HexToUint8(s) : Encoding.UTF8.GetBytes(s);
            p.SetValue(transaction, value);
        }
    }
    
    public void SetTypeHints(Dictionary<string, string>? typeHint)
    {
        TypeHints = typeHint ?? null;
    }

    private static object ValueParser(string key, object value)
    {
        return key switch
        {
            "Type" when value is string s => StringToTransactionType(s),
            "ScopedMetadataKey" or "ValueSizeDelta" when value is int i =>
                RuleBasedTransactionFactory.KeyParser(key, i),
            "RestrictionKey" or "NewRestrictionValue" or "PreviousRestrictionValue" when value is int i =>
                RuleBasedTransactionFactory.IntParser(i),
            "RestrictionKey" or "NewRestrictionValue" or "PreviousRestrictionValue" when value is long i =>
                RuleBasedTransactionFactory.IntParser(i),
            "Divisibility" or "MinRemovalDelta" or "MinApprovalDelta" when value is int i => RuleBasedTransactionFactory
                .ByteParser(i),
            "Value" when value is int i => RuleBasedTransactionFactory.StringParser(
                Converter.HexToUtf8(i.ToString() ?? throw new InvalidOperationException())),
            "Value" when value is long i => RuleBasedTransactionFactory.StringParser(
                Converter.HexToUtf8(i.ToString() ?? throw new InvalidOperationException())),
            "Value" when value is string s => RuleBasedTransactionFactory.StringParser(s),
            _ => value
        };
    }
    
    private static TransactionType StringToTransactionType(string type)
    {
        return type switch
        {
            "account_key_link_transaction" => TransactionType.ACCOUNT_KEY_LINK,
            "node_key_link_transaction" => TransactionType.NODE_KEY_LINK,
            "aggregate_complete_transaction" => TransactionType.AGGREGATE_COMPLETE,
            "aggregate_bonded_transaction" => TransactionType.AGGREGATE_BONDED,
            "voting_key_link_transaction" => TransactionType.VOTING_KEY_LINK,
            "vrf_key_link_transaction" => TransactionType.VRF_KEY_LINK,
            "hash_lock_transaction" => TransactionType.HASH_LOCK,
            "secret_lock_transaction" => TransactionType.SECRET_LOCK,
            "secret_proof_transaction" => TransactionType.SECRET_PROOF,
            "account_metadata_transaction" => TransactionType.ACCOUNT_METADATA,
            "mosaic_metadata_transaction" => TransactionType.MOSAIC_METADATA,
            "namespace_metadata_transaction" => TransactionType.NAMESPACE_METADATA,
            "mosaic_definition_transaction" => TransactionType.MOSAIC_DEFINITION,
            "mosaic_supply_change_transaction" => TransactionType.MOSAIC_SUPPLY_CHANGE,
            "mosaic_supply_revocation_transaction" => TransactionType.MOSAIC_SUPPLY_REVOCATION,
            "multisig_account_modification_transaction" => TransactionType.MULTISIG_ACCOUNT_MODIFICATION,
            "address_alias_transaction" => TransactionType.ADDRESS_ALIAS,
            "mosaic_alias_transaction" => TransactionType.MOSAIC_ALIAS,
            "namespace_registration_transaction" => TransactionType.NAMESPACE_REGISTRATION,
            "account_address_restriction_transaction" => TransactionType.ACCOUNT_ADDRESS_RESTRICTION,
            "account_mosaic_restriction_transaction" => TransactionType.ACCOUNT_MOSAIC_RESTRICTION,
            "account_operation_restriction_transaction" => TransactionType.ACCOUNT_OPERATION_RESTRICTION,
            "mosaic_address_restriction_transaction" => TransactionType.MOSAIC_ADDRESS_RESTRICTION,
            "mosaic_global_restriction_transaction" => TransactionType.MOSAIC_GLOBAL_RESTRICTION,
            "transfer_transaction" => TransactionType.TRANSFER,
            _ => throw new Exception("this is invalid transaction type of string")
        };
    }
}