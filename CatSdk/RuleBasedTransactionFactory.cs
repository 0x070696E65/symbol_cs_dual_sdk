using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using CatSdk.Nem;
using CatSdk.Symbol;
using CatSdk.Utils;
using Address = CatSdk.Symbol.Address;
using Amount = CatSdk.Symbol.Amount;
using Hash256 = CatSdk.Symbol.Hash256;
using Height = CatSdk.Symbol.Height;
using IBaseTransaction = CatSdk.Symbol.IBaseTransaction;
using MosaicId = CatSdk.Symbol.MosaicId;
using NamespaceId = CatSdk.Symbol.NamespaceId;
using PublicKey = CatSdk.Symbol.PublicKey;
using Signature = CatSdk.Symbol.Signature;
using Timestamp = CatSdk.Symbol.Timestamp;
using TransactionType = CatSdk.Symbol.TransactionType;

namespace CatSdk;

public class RuleBasedTransactionFactory
{
    public readonly List<Type> Module;
    private readonly Dictionary<string, Func<object, object>> Rules;
    private readonly Func<object, object?>? TypeConverter;
    private readonly Dictionary<Type, Func<object, object>>? TypeRuleOverrides;

    public RuleBasedTransactionFactory(List<Type> module, Func<object, object?>? typeConverter = null, Dictionary<Type, Func<object, object>>? typeRuleOverrides = null)
    {
        Module = module;
        TypeConverter = value => TypeConverterFactory(module, typeConverter, value);
        TypeRuleOverrides = typeRuleOverrides;
        Rules = new Dictionary<string, Func<object, object>>();
    }

    private static object? TypeConverterFactory(IEnumerable<Type> module, Func<object, object?>? customTypeConverter, object? value)
    {
        if (value != null && customTypeConverter?.Invoke(value) != null) return customTypeConverter(value);
        if (value is not ByteArray byteArray) return value;
        var type = module.Select(_ => value.GetType()).First();
        if (type == null) throw new NullReferenceException("type is null");
        return Activator.CreateInstance(type, byteArray.bytes);
    }

    public T CreateFromFactory<T>(Func<string, T> factory, Dictionary<string, object> descriptor) where T : IBaseTransaction
    {
        var processor = CreateProcessor(descriptor);
        var entityType = (string)processor.LookupValue("Type")!;
        var entity = factory(entityType);
        var allTypeHints = BuildTypeHintsMap(entity);
        processor.SetTypeHints(allTypeHints);
        processor.CopyTo(entity, new []{"Type"});
        return entity;
    }
    
    public T CreateNemFromFactory<T>(Func<string, T> factory, Dictionary<string, object> descriptor) where T : CatSdk.Nem.IBaseTransaction
    {
        var processor = CreateProcessor(descriptor);
        var entityType = (string)processor.LookupNemValue("Type")!;
        var entity = factory(entityType);
        var allTypeHints = BuildTypeHintsMap(entity);
        processor.SetTypeHints(allTypeHints);
        processor.CopyTo(entity, new []{"Type"});
        return entity;
    }

    private TransactionDescriptorProcessor CreateProcessor(Dictionary<string, object> descriptor)
    {
        return new TransactionDescriptorProcessor(descriptor, Rules, TypeConverter);
    }

    /*
    public static object KeyParser(string key, int value)
    {
        switch (key)
        {
            case "ScopedMetadataKey":
                return Convert.ToUInt64(value);
            case "ValueSizeDelta":
                if (Math.Sign(value) < 0) value = (ushort)(value - 0xFFFF0000);
                    return Convert.ToUInt16(value);
            default:
                throw new Exception("key is invalid string");
        }
    }

    public static byte[] StringParser(string value)
    {
        return Encoding.UTF8.GetBytes(value);
    }
    
    public static object ByteParser(int value)
    {
        return Convert.ToByte(value);
    }
    
    public static object ByteParser(long value)
    {
        return Convert.ToByte(value);
    }
    
    
    public static object IntParser(int value)
    {
        return Convert.ToUInt64(value);
    }
    
    public static object IntParser(long value)
    {
        return Convert.ToUInt64(value);
    }
    */
    
    public void AddPodParser(string name)
    {
        var podClass = Module.Find(m => m.Name == name);
        if (podClass == null) throw new NullReferenceException("pod class is null");
        var type = podClass.GetConstructors()[0].GetParameters()[0].ParameterType;
        
        if (TypeRuleOverrides != null && TypeRuleOverrides.ContainsKey(podClass))
        {
            Rules[name] = TypeRuleOverrides[podClass];
            return;
        }
        
        Rules[name] = value =>
        {
            if (value == null) throw new NullReferenceException("value is null");
            var valueType = value.GetType();
            if (valueType == podClass) return value;
            object? instance = null;
            if (type == typeof(byte)) instance = Activator.CreateInstance(podClass, Convert.ToByte(value));
            else if (type == typeof(ushort)) instance = Activator.CreateInstance(podClass, Convert.ToUInt16(value));
            else if (type == typeof(uint)) instance = Activator.CreateInstance(podClass, Convert.ToUInt32(value));
            else if (type == typeof(ulong)) instance = Activator.CreateInstance(podClass, Convert.ToUInt64(value));
            else if (type == typeof(byte[]))
            {
                value = value is string s ? Converter.IsHexString(s) ? Converter.HexToBytes(s) : Converter.StringToAddress(s) : value;
                instance = Activator.CreateInstance(podClass, value);
            }
            if (instance == null) throw new NullReferenceException("instance is null");
            return instance;
        };
    }

    public void AddArrayParser(string name)
    {
        var elementRule = Rules[name];
        var elementName = name.Replace("struct:", "");
        var arrayClass = Module.Find(m => m.Name == elementName);
        if (arrayClass == null) throw new NullReferenceException("array class is null");

        Rules[$"array[{elementName}]"] = values =>
        {
            IList tInst;
            if (values is object[] objects)
            {
                var o = objects.Select((v) => elementRule(v));
                tInst = Array.CreateInstance(arrayClass, objects.Length);
                var enumerable = o as object[] ?? o.ToArray();
                for (var i = 0; i < enumerable.Length; i++)
                {
                    tInst[i] = enumerable[i];
                }
                return tInst;
            }
            if (values is int[] int32)
            {
                var o = int32.Select((v) => elementRule(v));
                tInst = Array.CreateInstance(arrayClass, int32.Length);
                var enumerable = o as object[] ?? o.ToArray();
                for (var i = 0; i < enumerable.Length; i++)
                {
                    tInst[i] = enumerable[i];
                }
                return tInst;
            }

            if (values is ulong[] uint64)
            {
                var o = uint64.Select((v) => elementRule(v));
                tInst = Array.CreateInstance(arrayClass, uint64.Length);
                var enumerable = o as object[] ?? o.ToArray();
                for (var i = 0; i < enumerable.Length; i++)
                {
                    tInst[i] = enumerable[i];
                }
                return tInst;
            }
            throw new Exception("value is invalid type");
        };
    }
    
    public void AddFlagsParser(string name)
    {
        var flagClass = Module.Find(m => m.Name == name);
        if (flagClass == null) throw new NullReferenceException("flag class is null");
        var type = flagClass.GetConstructors()[0].GetParameters()[0].ParameterType;
        var stringToEnum = BuildEnumStringToValueMap(flagClass);
        
        Rules[name] = flags =>
        {
            int flagsInt;
            switch (flags)
            {
                case string s:
                    flagsInt = s.Split(" ").ToList().Select(flagName =>
                    {
                        if (stringToEnum == null) throw new Exception("");
                        if (stringToEnum.Values == null) throw new Exception("");
                        return NameToEnumValue(stringToEnum, typeof(MosaicFlags), flagName);
                    }).Sum();
                    break;
                case int i:
                    flagsInt = i;
                    break;
                case IEnum<byte>[] array:
                    flagsInt = array.ToList().Select(flag => (int)flag.Value).Sum();
                    break;
                case IEnum<ushort>[] array:
                    flagsInt = array.ToList().Select(flag => (int)flag.Value).Sum();
                    break;
                default:
                    return flags;
            }

            object? instance = null;
            if (type == typeof(byte))
            {
                instance = Activator.CreateInstance(flagClass, Convert.ToByte(flagsInt));
            }
            else if (type == typeof(ushort))
            {
                instance = Activator.CreateInstance(flagClass, Convert.ToUInt16(flagsInt));
            }
            if (instance == null) throw new NullReferenceException("instance is null");
            return instance;
        };
        
    }
    
    public void AddEnumParser(string name)
    {
        var enumClass = Module.Find(m => m.Name == name);
        if (enumClass == null) throw new NullReferenceException("enum class is null");
        var type = enumClass.GetConstructors()[0].GetParameters()[0].ParameterType;
        var stringToEnum = BuildEnumStringToValueMap(enumClass);
        
        Rules[name] = enumValue =>
        {
            int enumInt;
            switch (enumValue)
            {
                case string s:
                    enumInt = NameToEnumValue(stringToEnum, enumClass, s);
                    break;
                case int i:
                    enumInt = i;
                    break;
                default:
                    return enumValue;
            }
            
            object? instance = null;
            if (type == typeof(byte))
            {
                instance = Activator.CreateInstance(enumClass, Convert.ToByte(enumInt));
            }
            else if (type == typeof(ushort))
            {
                instance = Activator.CreateInstance(enumClass, Convert.ToUInt16(enumInt));
            }
            if (instance == null) throw new NullReferenceException("instance is null");
            return instance;
        };
    }

    public void AddStructParser(string name)
    {
        var structClass = Module.Find(m => m.Name == name);
        if (structClass == null) throw new NullReferenceException("enum class is null");
        Rules[$"struct:{name}"] = structDescriptor =>
        {
            TransactionDescriptorProcessor structProcessor;
            if (structDescriptor.GetType() == typeof(Dictionary<string, object>))
            {
                structProcessor = CreateProcessor((Dictionary<string, object>)structDescriptor);
            }
            else
            {
                var dic = new Dictionary<string, object>();
                foreach (var propertyInfo in structDescriptor.GetType().GetProperties())
                {
                    foreach (var pi in structClass.GetProperties())
                    {
                        if (pi.PropertyType.FullName != propertyInfo.PropertyType.FullName || !propertyInfo.CanWrite)
                            continue;
                        var value = propertyInfo.GetValue(structDescriptor);
                        dic[propertyInfo.Name] = value ?? throw new Exception("");
                    }
                }
                structProcessor = CreateProcessor(dic);
            }
            var structValue = Activator.CreateInstance(structClass);
            if (structValue == null) throw new NullReferenceException("structValue is null");
            var allTypeHints = BuildTypeHintsMap((IStruct)structValue);
            structProcessor.SetTypeHints(allTypeHints);
            structProcessor.CopyTo((IStruct)structValue);
            return structValue;
        };
    }

    public void Autodetect()
    {
        foreach (var cls in Module.Where(cls => cls.BaseType == typeof(BaseValue) && typeof(BaseValue) != cls))
        {
            AddPodParser(cls.Name);
        }
    }
    
    private static Dictionary<string, string> BuildTypeHintsMap(IStruct structValue) {
        var typeHints = new Dictionary<string, string>();
        var rawTypeHints = structValue.TypeHints;
        foreach (var (key, hint) in rawTypeHints)
        {
            string? ruleName = null;
            if (hint.IndexOf("array[", StringComparison.Ordinal) == 0)
            {
                ruleName = hint;
            } else if (hint.IndexOf("enum:", StringComparison.Ordinal) == 0)
            {
                ruleName = hint["enum:".Length..];
            }
            else if (hint.IndexOf("pod:", StringComparison.Ordinal) == 0)
            {
                ruleName = hint["pod:".Length..];
            }
            else if (hint.IndexOf("struct:", StringComparison.Ordinal) == 0)
            {
                ruleName = hint;
            }

            if (ruleName != null)
            {
                typeHints[key] = ruleName;
            }
        }
        return typeHints;
    }
    
    private static Dictionary<string, int> BuildEnumStringToValueMap(Type enumClass)
    {
        var fields = enumClass.GetFields();
        var result = new Dictionary<string, int>();
        foreach (var t in fields)
        {
            var value = t.GetValue(t.Name);
            if (value == null) throw new NullReferenceException("");
            if (((ISerializer) value).Size == 2)
            {
                result[t.Name] = ((IEnum<ushort>)value).Value;
            }
            else
            {
                result[t.Name] = ((IEnum<byte>)value).Value;
            }
        }
        return result;
    }
    
    private static int NameToEnumValue(IReadOnlyDictionary<string, int> mapping, Type enumType, string enumValueName){
        if(!mapping.ContainsKey(enumValueName)) throw new ArgumentOutOfRangeException($"unknown value {enumValueName} for type {enumType}");
        return mapping[enumValueName];
    }
}

