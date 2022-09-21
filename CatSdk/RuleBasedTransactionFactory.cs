using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CatSdk.Utils;

namespace CatSdk;

/**
 * Rule based transaction factory.
 */
public class RuleBasedTransactionFactory
{
    private readonly List<Type> Module;
    private readonly Dictionary<string, Func<object, object>> Rules;
    private readonly Func<object, object?>? TypeConverter;
    private readonly Dictionary<Type, Func<object, object>>? TypeRuleOverrides;
    private readonly Func<string, byte[]> RawAddressToBytes;

    /**
	 * Creates a rule based transaction factory for use with catbuffer generated code.
	 * @param {List&lt;Type&gt;} module Catbuffer generated module.
	 * @param {Func} typeConverter Type converter.
	 * @param {Dictionary} typeRuleOverrides Type rule overrides.
	 */
    public RuleBasedTransactionFactory(List<Type> module, Func<string, byte[]> rawAddressToBytes, Func<object, object?>? typeConverter = null, Dictionary<Type, Func<object, object>>? typeRuleOverrides = null)
    {
        Module = module;
        TypeConverter = value => TypeConverterFactory(module, typeConverter, value);
        TypeRuleOverrides = typeRuleOverrides;
        Rules = new Dictionary<string, Func<object, object>>();
        RawAddressToBytes = rawAddressToBytes;
    }

    private static object? TypeConverterFactory(IEnumerable<Type> module, Func<object, object?>? customTypeConverter, object? value)
    {
        if (value != null && customTypeConverter?.Invoke(value) != null) return customTypeConverter(value);
        if (value?.GetType() != typeof(ByteArray)) return value;
        var type = module.Select(_ => value.GetType()).First();
        if (type == null) throw new NullReferenceException("type is null");
        return Activator.CreateInstance(type, ((ByteArray)value).bytes);
    }

    /**
	 * Creates an entity from a descriptor using a factory.
	 * @param {Func} factory Factory function.
	 * @param {Dictionary} descriptor Entity descriptor.
	 * @returns {T} Newly created entity.
	 */
    public T CreateFromFactory<T>(Func<string, T> factory, Dictionary<string, object> descriptor) where T : IStruct
    {
        var processor = CreateProcessor(descriptor);
        var entityType = (string)processor.LookupValue("Type")!;
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
        
    /**
	 * Creates wrapper for SDK POD types.
	 * @param {string} name Class name.
	 * @param {Type} PodClass Class type.
	 */
    public void AddPodParser(string name, Type podClass)
    {
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
                value = value is string s ? Converter.IsHexString(s) ? Converter.HexToBytes(s) : RawAddressToBytes(s) : value;
                instance = Activator.CreateInstance(podClass, value);
            }
            if (instance == null) throw new NullReferenceException("instance is null");
            return instance;
        };
    }

    /**
	 * Creates array type parser, based on some existing element type parser.
	 * @param {string} name Class name.
	 */
    public void AddArrayParser(string name)
    {
        var elementRule = Rules[name];
        var elementName = name.Replace("struct:", "");
        var arrayClass = Module.Find(m => m.Name == elementName);
        if (arrayClass == null) throw new NullReferenceException("array class is null");
            
        Rules[$"array[{elementName}]"] = values =>
        {
            IList tInst;
            switch (values)
            {
                case object[] objects:
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
                case int[] int32:
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
                case ulong[] uint64:
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
                default:
                    throw new Exception("value is invalid type");
            }
        };
    }
        
    /**
	 * Creates flag type parser.
	 * @param {string} name Class name.
	 */
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
                        return NameToEnumValue(stringToEnum, flagClass, flagName);
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
        
    /**
	 * Creates enum type parser.
	 * @param {string} name Class name.
	 */
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

    /**
	 * Creates struct parser (to allow nested parsing).
	 * @param {string} name Class name.
	 */
    public void AddStructParser(string name)
    {
        var structClass = Module.Find(m => m.Name == name);
        if (structClass == null) throw new NullReferenceException("struct class is null");
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
                foreach (var pi in structClass.GetProperties())
                {
                    if (pi.PropertyType == structDescriptor.GetType())
                    {
                        dic[pi.PropertyType.Name] = structDescriptor;
                    }
                    else
                    {
                        foreach (var propertyInfo in structDescriptor.GetType().GetProperties())
                        {
                            if (pi.PropertyType.FullName != propertyInfo.PropertyType.FullName || !propertyInfo.CanWrite)
                                continue;
                            var value = propertyInfo.GetValue(structDescriptor);
                            dic[propertyInfo.Name] = value ?? throw new Exception("");
                        }   
                    }
                }
                structProcessor = CreateProcessor(dic);
            }
            {
                var structValue = Activator.CreateInstance(structClass);
                if (structValue == null) throw new NullReferenceException("structValue is null");
                var allTypeHints = BuildTypeHintsMap((IStruct)structValue);
                structProcessor.SetTypeHints(allTypeHints);
                structProcessor.CopyTo((IStruct)structValue);
                return structValue;   
            }
        };
    }

    /**
	 * Autodetects rules using reflection.
	 */
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
            result[t.Name] = ((ISerializer) value).Size switch
            {
                1 => ((IEnum<byte>) value).Value,
                2 => ((IEnum<ushort>) value).Value,
                4 => (int) ((IEnum<uint>) value).Value,
                8 => (int) ((IEnum<ulong>) value).Value,
                _ => result[t.Name]
            };
        }
        return result;
    }
        
    private static int NameToEnumValue(IReadOnlyDictionary<string, int> mapping, Type enumType, string enumValueName){
        if(!mapping.ContainsKey(enumValueName)) throw new ArgumentOutOfRangeException($"unknown value {enumValueName} for type {enumType}");
        return mapping[enumValueName];
    }
}