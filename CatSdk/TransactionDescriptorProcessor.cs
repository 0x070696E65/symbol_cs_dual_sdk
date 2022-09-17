using CatSdk.Facade;
using CatSdk.Utils;

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
        if (typeHint != null && TypeParsingRules.ContainsKey(typeHint)) value = TypeParsingRules[typeHint].Invoke(value);
        return value;
    }

    public object LookupValue(string key)
    {
        return LookupValueAndApplyTypeHints(key);
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
            if (p.PropertyType == typeof(byte[]) && value is string s) value = Converter.HexToBytes(s);
            if (p.PropertyType == typeof(byte[]) && value is int int32) value = Converter.HexToBytes(int32.ToString());
            if (p.PropertyType == typeof(byte[]) && value is long int64) value = Converter.HexToBytes(int64.ToString());
            p.SetValue(transaction, value);
        }
    }
    
    public void SetTypeHints(Dictionary<string, string>? typeHint)
    {
        TypeHints = typeHint ?? null;
    }
}