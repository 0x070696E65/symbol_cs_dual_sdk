using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Text;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using Address = CatSdk.Symbol.Address;
namespace CatSdk;

public class RuleBasedTransactionFactory
{
    public List<Type> Module;
    public Dictionary<string, Func<object, object>> Rules;
    public Func<object, object?>? TypeConverter;
    public Dictionary<Type, Func<object, object>>? TypeRuleOverrides;

    public RuleBasedTransactionFactory(List<Type> module, Func<object, object?>? typeConverter = null, Dictionary<Type, Func<object, object>>? typeRuleOverrides = null)
    {
        Module = module;
        TypeConverter = value => TypeConverterFactory(module, typeConverter, value);
        TypeRuleOverrides = typeRuleOverrides;
        Rules = new Dictionary<string, Func<object, object>>();
    }

    public static object? TypeConverterFactory(IEnumerable<Type> module, Func<object, object?>? customTypeConverter, object? value)
    {
        if (value != null && customTypeConverter?.Invoke(value) != null) return customTypeConverter(value);
        var type = module.Select(_ => value?.GetType()).First();
        if (value is not ByteArray byteArray) return value;
        if (type == null) throw new NullReferenceException("type is null");
        var bar = Activator.CreateInstance(type, byteArray.bytes)!;
        return bar;
    }

    public IBaseTransaction CreateFromFactory(Func<TransactionType, IBaseTransaction> factory, Dictionary<string, object> descriptor)
    {
        var processor = CreateProcessor(descriptor);
        var entityType = (TransactionType)processor.LookupValue("Type")!;
        var entity = factory(entityType);
        var allTypeHints = BuildTypeHintsMap(entity);
        processor.SetTypeHints(allTypeHints);
        processor.CopyTo(entity, new []{"Type"});
        return entity;
    }
    
    private TransactionDescriptorProcessor CreateProcessor(Dictionary<string, object> descriptor) {
        return new TransactionDescriptorProcessor(descriptor, Rules, TypeConverter);
    }

    public static object KeyParser(string key, int value)
    {
        switch (key)
        {
            case "ScopedMetadataKey":
                return Convert.ToUInt64(value);
            case "ValueSizeDelta":
                if (Math.Sign(value) < 0) value = (ushort)((value << 16) >> 16);
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
    
    public void AddPodParser(string name, Type podClass)
    {
        if (TypeRuleOverrides != null && TypeRuleOverrides.ContainsKey(podClass))
        {
            Rules[name] = TypeRuleOverrides[podClass];
            return;
        }
        Rules[name] = value =>
        {
            if (value == null) throw new NullReferenceException("value is null");
            var valueType = value.GetType();
            if (valueType == podClass
                || valueType == typeof(UnresolvedAddress))
            {
                return value;
            }

            {
                object? instance;
                if (
                    podClass == typeof(Amount)
                    || podClass == typeof(BlockDuration)
                    || podClass == typeof(Difficulty)
                    || podClass == typeof(Height)
                    || podClass == typeof(Importance)
                    || podClass == typeof(ImportanceHeight)
                    || podClass == typeof(UnresolvedMosaicId)
                    || podClass == typeof(MosaicId)
                    || podClass == typeof(Timestamp)
                    || podClass == typeof(NamespaceId)
                    || podClass == typeof(MosaicRestrictionKey)
                    )
                {
                    instance = Activator.CreateInstance(podClass, Convert.ToUInt64(value));
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                if (
                    podClass == typeof(CatSdk.Symbol.Hash256)
                    || podClass == typeof(CatSdk.Symbol.PublicKey)
                    || podClass == typeof(VotingPublicKey)
                   )
                {
                    value = value is string s ? Converter.HexToUint8(s) : value;
                    instance = Activator.CreateInstance(podClass, value);
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                if (podClass == typeof(Address))
                {
                    value = value is string s ? Converter.StringToAddress(s) : value;
                    instance = Activator.CreateInstance(podClass, value);
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                if (podClass == typeof(UnresolvedAddress))
                {
                    value = value is string s ? Converter.StringToAddress(s) : value;
                    instance = Activator.CreateInstance(podClass, value);
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                if (podClass == typeof(CatSdk.Symbol.Signature))
                {
                    value = value is string s ? Converter.HexToUint8(s) : value;
                    instance = Activator.CreateInstance(podClass, value);
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                if (podClass == typeof(CatSdk.Symbol.Signature))
                {
                    value = value is string s ? Converter.HexToUint8(s) : value;
                    instance = Activator.CreateInstance(podClass, value);
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                {
                    instance = Activator.CreateInstance(podClass, Convert.ToUInt32(value));
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
            }
        };
    }

    public void AddArrayParser(string name, Type type)
    {
        var elementRule = Rules[name];
        var elementName = name.Replace("struct:", "");
        Rules[$"array[{elementName}]"] = values =>
        {
            if (type == typeof(UnresolvedMosaicId))
            {
                if (values.GetType() == typeof(ulong[]))
                {
                    var result = ((ulong[]) values).ToList().Select((value) =>
                    {
                        if (value.GetType() == typeof(UnresolvedMosaicId))
                        {
                            return elementRule(value);
                        }
                        return elementRule(new UnresolvedMosaicId(value));
                    }).ToArray();
                    return result.Cast<UnresolvedMosaicId>().ToArray();
                }
                if (values.GetType() == typeof(int[]))
                {
                    var result = ((uint[]) values).ToList().Select((value) =>
                    {
                        if (value.GetType() == typeof(UnresolvedMosaicId))
                        {
                            return elementRule(value);
                        }
                        return elementRule(new UnresolvedMosaicId(value));
                    }).ToArray();
                    return result.Cast<UnresolvedMosaicId>().ToArray();   
                }
            }
            
            var list = ((object[]) values).ToList();
            if (type == typeof(UnresolvedMosaic))
            {
                var result = list.Select((value) =>
                {
                    if (value.GetType() == typeof(UnresolvedMosaic))
                    {
                        return elementRule(value);
                    }

                    if (value.GetType() != typeof(Dictionary<string, object>)) return elementRule(value);
                    var b = (Dictionary<string, object>) value;
                    var a = new UnresolvedMosaic
                    {
                        MosaicId = new UnresolvedMosaicId(Convert.ToUInt64(b["MosaicId"])),
                        Amount = new Amount(Convert.ToUInt64(b["Amount"]))
                    };
                    return elementRule(a);
                }).ToArray();
                return result.Cast<UnresolvedMosaic>().ToArray();
            }
            if (type == typeof(UnresolvedAddress))
            {
                var result = list.Select((value) =>
                {
                    if (value.GetType() == typeof(UnresolvedAddress))
                    {
                        return elementRule(value);
                    }
                    if (value is string s)
                    {
                        var unresolvedAddress = new UnresolvedAddress(Converter.StringToAddress(s));
                        return elementRule(unresolvedAddress);
                    }
                    throw new Exception("value is invalid type");
                }).ToArray();
                return result.Cast<UnresolvedAddress>().ToArray();
            }

            if (type == typeof(TransactionType))
            {
                var result = list.Select((value) =>
                {
                    if (value.GetType() == typeof(TransactionType))
                    {
                        return elementRule(value);
                    }
                    if (value is string s)
                    {
                        var stringToEnum = BuildEnumStringToValueMap(type);
                        var enumInt = NameToEnumValue(stringToEnum, typeof(TransactionType), s);
                        var transactionType = new TransactionType((ushort)enumInt);
                        return elementRule(transactionType);
                    }
                    
                    throw new Exception("value is invalid type");
                }).ToArray();
                return result.Cast<TransactionType>().ToArray();
            }
            
            if(type == typeof(Dictionary<string, object>))
            {
                return list.Select((value) => elementRule((Dictionary<string, object>)value)).ToArray();
            }
            return list.Select((value) => elementRule(value)).ToArray();
        };
    }

    public void AddFlagsParser(string name, Type flagsClass)
    {
        Rules[name] = flags =>
        {
            var valueType = flags.GetType();
            if (valueType == flagsClass)
            {
                return flags;
            }

            object? instance;
            switch (flags)
            {
                case int when flagsClass == typeof(MosaicFlags):
                {
                    instance = Activator.CreateInstance(flagsClass, Convert.ToByte(flags));
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                case int when flagsClass == typeof(AccountRestrictionFlags):
                {
                    instance = Activator.CreateInstance(flagsClass, Convert.ToUInt16(flags));
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                case string s when flagsClass == typeof(MosaicFlags):
                {
                    var stringToEnum = BuildEnumStringToValueMap(flagsClass);
                    var enumTotalInt = s.Split(" ").ToList().Select(flagName =>
                    {
                        if (stringToEnum == null) throw new Exception("");
                        if (stringToEnum.Values == null) throw new Exception("");
                        return NameToEnumValue(stringToEnum, typeof(MosaicFlags), flagName);
                    }).Sum();
                    
                    instance = Activator.CreateInstance(flagsClass, Convert.ToByte(enumTotalInt));
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                case string s when flagsClass == typeof(AccountRestrictionFlags):
                {
                    var stringToEnum = BuildEnumStringToValueMap(flagsClass);
                    var enumTotalInt = s.Split(" ").ToList().Select(flagName =>
                    {
                        if (stringToEnum == null) throw new Exception("");
                        if (stringToEnum.Values == null) throw new Exception("");
                        return NameToEnumValue(stringToEnum, typeof(MosaicFlags), flagName);
                    }).Sum();
                    
                    instance = Activator.CreateInstance(flagsClass, Convert.ToUInt16(enumTotalInt));
                    if (instance == null)  throw new NullReferenceException("instance is null");
                    return instance;
                }
                default:
                    throw new Exception("flags is invalid type. ex) not int or string");
            }
        };
    }
    
    public void AddEnumParser(string name, Type flagsClass)
    {
        Rules[name] = enumValue =>
        {
            var valueType = enumValue.GetType();
            if (valueType == flagsClass)
            {
                return enumValue;
            }

            object? instance;
            if (flagsClass == typeof(TransactionType))
            {
                switch (enumValue)
                {
                    case int:
                    {
                        instance = Activator.CreateInstance(flagsClass, Convert.ToUInt16(enumValue));
                        if (instance == null) throw new NullReferenceException("instance is null");
                        return instance;
                    }
                    case string value:
                    {
                        var stringToEnum = BuildEnumStringToValueMap(flagsClass);
                        var enumInt = NameToEnumValue(stringToEnum, typeof(MosaicFlags), value);
                        instance = Activator.CreateInstance(flagsClass, Convert.ToUInt16(enumInt));
                        if (instance == null) throw new NullReferenceException("instance is null");
                        return instance;
                    }
                }
            }
            {
                switch (enumValue)
                {
                    case int:
                    {
                        instance = Activator.CreateInstance(flagsClass, Convert.ToByte(enumValue));
                        if (instance == null) throw new NullReferenceException("instance is null");
                        return instance;
                    }
                    case string value:
                    {
                        var stringToEnum = BuildEnumStringToValueMap(flagsClass);
                        var enumInt = NameToEnumValue(stringToEnum, typeof(MosaicFlags), value);
                        instance = Activator.CreateInstance(flagsClass, Convert.ToByte(enumInt));
                        if (instance == null) throw new NullReferenceException("instance is null");
                        return instance;
                    }
                }
            }
            throw new Exception("enumValue is invalid type. ex) not int or string");
        };
    }

    public void AddStructParser(string name, Type structClass)
    {
        Rules[$"struct:{name}"] = structDescriptor =>
        {
            TransactionDescriptorProcessor structProcessor;
            if (structDescriptor.GetType() == typeof(UnresolvedMosaic))
            {
                var temp = (UnresolvedMosaic)structDescriptor;
                var dic = new Dictionary<string, object>()
                {
                    {"MosaicId", temp.MosaicId},
                    {"Amount", temp.Amount},
                };
                structProcessor = CreateProcessor(dic);
            } else {
                structProcessor = CreateProcessor((Dictionary<string, object>)structDescriptor);
            }
            var instance = Activator.CreateInstance(structClass);
            if (instance == null) throw new NullReferenceException("structValue instance is null");
            var structValue = (UnresolvedMosaic) instance;
            if (structValue == null) throw new NullReferenceException("structValue is null");
            var allTypeHints = BuildTypeHintsMap(structValue);
            structProcessor.SetTypeHints(allTypeHints);
            structProcessor.CopyTo(structValue);
            return structValue;
        };
    }

    public void Autodetect()
    {
        foreach (var cls in Module.Where(cls => cls.BaseType == typeof(BaseValue) && typeof(BaseValue) != cls))
        {
            AddPodParser(cls.Name, cls);
        }
    }
    
    private static Dictionary<string, string> BuildTypeHintsMap(IStruct structValue) {
        var typeHints = new Dictionary<string, string>();
        var rawTypeHints = structValue.TypeHints;
        foreach (var keyValuePair in rawTypeHints)
        {
            var hint = keyValuePair.Value;
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
                typeHints[keyValuePair.Key] = ruleName;
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
    
    private static int NameToEnumValue(Dictionary<string, int> mapping, Type enumType, string enumValueName){
        if(!mapping.ContainsKey(enumValueName)) throw new ArgumentOutOfRangeException($"unknown value {enumValueName} for type {enumType}");
        return mapping[enumValueName];
    }
}