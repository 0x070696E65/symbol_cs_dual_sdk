using CatSdk.Utils;
using System;
using System.Collections.Generic;

namespace CatSdk
{
    /**
     * Processes and looks up transaction descriptor properties.
     */
    public class TransactionDescriptorProcessor
    {
        private readonly Dictionary<string, object> TransactionDescriptor;
        private readonly Dictionary<string, Func<object, object>> TypeParsingRules;
        private readonly Func<object, object?>? TypeConverter;
        public Dictionary<string, string>? TypeHints;

        /**
         * Creates a transaction descriptor processor.
         * @param {object} transactionDescriptor Transaction descriptor.
         * @param {Map} typeParsingRules Type-dependent parsing rules.
         * @param {function} typeConverter Converts a generated type to an sdk type (optional).
         */
        public TransactionDescriptorProcessor(Dictionary<string, object> transactionDescriptor, Dictionary<string, Func<object, object>> typeParsingRules, Func<object, object?>? typeConverter = null)
        {
            TransactionDescriptor = transactionDescriptor;
            TypeParsingRules = typeParsingRules;
            TypeConverter = typeConverter ?? (value => value);
            TypeHints = null;
        }

        private object LookupValueAndApplyTypeHints(string key)
        {
            if (null == TransactionDescriptor[key])
                throw new ArgumentOutOfRangeException($"transaction descriptor does not have attribute {key}");
            var value = TransactionDescriptor[key];
            if (TypeHints == null) return value;
            if (!TypeHints.ContainsKey(key)) return value;
            var typeHint = TypeHints?[key];
            if (typeHint != null && TypeParsingRules.ContainsKey(typeHint)) value = TypeParsingRules[typeHint].Invoke(value);
            return value;
        }

        /**
	     * Looks up the value for key.
	     * @param {string} key Key for which to retrieve value.
	     * @returns {object} Value corresponding to key.
	     */

        public object LookupValue(string key)
        {
            return LookupValueAndApplyTypeHints(key);
        }

        /**
	     * Copies all descriptor information to a transaction.
	     * @param {IStruct} transaction Transaction to which to copy keys.
	     * @param {array&lt;string&gt;} ignoreKeys Keys of descriptor values not to copy (optional).
	     */
        public void CopyTo(IStruct transaction, string[]? ignoreKeys = null)
        {
            foreach (var kvp in TransactionDescriptor)
            {
                if (ignoreKeys != null && -1 != Array.IndexOf(ignoreKeys, kvp.Key)) continue;
                var p = transaction.GetType().GetProperty(kvp.Key);
                if (p == null) throw new ArgumentOutOfRangeException($"transaction does not have attribute {kvp.Key}");
                var value = LookupValue(kvp.Key);
                if (value is int i && Math.Sign(i) < 0 && p.PropertyType == typeof(ushort)) value = (ushort)(i - 0xFFFF0000);
                if (value is int ii && Math.Sign(ii) < 0 && p.PropertyType == typeof(uint)) value = (uint)ii;
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

        /**
	     * Sets type hints.
	     * @param {Dictionary} typeHints New type hints.
	     */
        public void SetTypeHints(Dictionary<string, string>? typeHint)
        {
            TypeHints = typeHint ?? null;
        }
    }
}