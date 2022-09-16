using System.Text;
using CatSdk.Facade;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using Cosignature = CatSdk.Symbol.Cosignature;
using NetworkType = CatSdk.Symbol.NetworkType;
using PublicKey = CatSdk.Symbol.PublicKey;
using Signature = CatSdk.Symbol.Signature;
using TransactionType = CatSdk.Symbol.TransactionType;

namespace CatSdk;
public class TransactionDescriptorProcessor
{
    private readonly Dictionary<string, object> TransactionDescriptor;
    private readonly Dictionary<string, Func<object, object>> TypeParsingRules;
    private readonly Func<object, object?>? TypeConverter;
    public Dictionary<string, string>? TypeHints;
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
        if (typeHint != null && TypeParsingRules.ContainsKey(typeHint))
        {
            value = TypeParsingRules[typeHint](value);
        }
        return value;
    }

    public object? LookupValue(string key)
    {
        var value = LookupValueAndApplyTypeHints(key);
        //value = ValueParser(key, value);
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
                    var signerPublicKey = new PublicKey(Converter.HexToBytes((string)cosignatureDic["SignerPublicKey"]));
                    var signature = new Signature(Converter.HexToBytes((string)cosignatureDic["Signature"]));
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
    
    public object? LookupNemValue(string key)
    {
        var value = LookupValueAndApplyTypeHints(key);
        if (value.GetType() != typeof(Dictionary<string, object>[]))
        {
            return TypeConverter?.Invoke(value);
        }
        switch (key)
        {
            case "InnerTransaction":
            {
                var netWorkType = (CatSdk.Nem.NetworkType) TransactionDescriptor["Network"] == Nem.NetworkType.MAINNET
                    ? Nem.Factory.Network.MainNet
                    : Nem.Factory.Network.TestNet;
                var facade = new NemFacade(netWorkType);
                var innerTransactions = ((Dictionary<string, object>[]) value).ToList().Select((tx) => facade.TransactionFactory.ToNonVerifiableTransaction(tx)).ToArray();
                return TypeConverter?.Invoke(innerTransactions);
            }
            case "Cosignatures":
            {
                var cosignatures = ((Dictionary<string, object>[]) value).ToList().Select((cosignatureDic) =>
                {
                    var signerPublicKey = new PublicKey(Converter.HexToBytes((string)cosignatureDic["SignerPublicKey"]));
                    var signature = new Signature(Converter.HexToBytes((string)cosignatureDic["Signature"]));
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
            
            if (value is int i && Math.Sign(i) < 0) value = (ushort) (i - 0xFFFF0000);
            if (p.PropertyType == typeof(byte)) value = Convert.ToByte(value);
            if (p.PropertyType == typeof(ushort)) value = Convert.ToUInt16(value);
            if (p.PropertyType == typeof(uint)) value = Convert.ToUInt32(value);
            if (p.PropertyType == typeof(ulong)) value = Convert.ToUInt64(value);
            if (p.PropertyType == typeof(byte[]) && value is string s)
            {
                value = Converter.IsHexString(s) ? Encoding.UTF8.GetBytes(Converter.HexToUtf8(s)) : Encoding.UTF8.GetBytes(s);
                
                //value = Converter.IsHexString((string)value) ? Converter.HexToBytes((string)value) : Encoding.UTF8.GetBytes(value);
            }
            //if (p.PropertyType == typeof(byte[]) && value is int int32) value = Converter.HexToBytes(int32.ToString());
            //if (p.PropertyType == typeof(byte[]) && value is long int64) value = Converter.HexToBytes(int64.ToString());

            p.SetValue(transaction, value);
        }
    }
    
    public void SetTypeHints(Dictionary<string, string>? typeHint)
    {
        TypeHints = typeHint ?? null;
    }

    /*
    private static object ValueParser(string key, object value)
    {
        return key switch
        {
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
    */
}