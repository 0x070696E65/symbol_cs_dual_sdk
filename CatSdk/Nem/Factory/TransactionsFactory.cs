using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CatSdk.Utils;

namespace CatSdk.Nem.Factory
{
    public class TransactionsFactory
    {
        private readonly RuleBasedTransactionFactory Factory;
        private readonly Network Network;
        public TransactionsFactory(Network network, Dictionary<Type, Func<object, object>>? typeRuleOverrides = null)
        {
            Factory = BuildRules(typeRuleOverrides);
            Network = network;
        }

        public ITransaction Create(Dictionary<string, object> transactionDescriptor, bool autosort = true)
        {
            var networkType = Network == Network.MainNet ? NetworkType.MAINNET : NetworkType.TESTNET;
            transactionDescriptor.Add("Network", networkType);
            var transaction = Factory.CreateFromFactory(TransactionFactory.CreateByName, transactionDescriptor);
            if (autosort) transaction.Sort();
            return transaction;
        }

        /*
	     * Converts a transaction to a non-verifiable transaction.
	     * @param {object} transaction Transaction object.
	     * @returns {object} Non-verifiable transaction object.
	     */
        public static IBaseTransaction ToNonVerifiableTransaction(IBaseTransaction transaction)
        {
            var nonVerifiableClassName = transaction.GetType().Name;
            nonVerifiableClassName = nonVerifiableClassName.Contains("NonVerifiable") ? nonVerifiableClassName : $"NonVerifiable{nonVerifiableClassName}";
            var assm = Assembly.GetExecutingAssembly();
            var types = assm.GetTypes()
                .Where(p => p.Namespace == "CatSdk.Nem")
                .OrderBy(o => o.Name)
                .Where(s => !s.Name.Contains("<>"))
                .ToList();
            var nonVerifiableClass = types.Find(m => m.Name == nonVerifiableClassName);
            if (nonVerifiableClass == null) throw new NullReferenceException("nonVerifiableClass type is invalid");
            var inst = (IBaseTransaction)Activator.CreateInstance(nonVerifiableClass)!;

            var pInfos = inst.GetType().GetProperties();
            var tInfos = transaction.GetType().GetProperties();

            foreach (var propertyInfo in pInfos)
            {
                if (!propertyInfo.CanWrite) continue;
                var tInfo = tInfos.ToList().Find(t => t.Name == propertyInfo.Name);
                var value = tInfo?.GetValue(transaction);
                propertyInfo.SetValue(inst, value);
            }
            return inst;
        }

        public static string AttachSignature(ITransaction transaction, Signature signature)
        {
            transaction.Signature = new Signature(signature.bytes);
            var transactionHex = Converter.BytesToHex(ToNonVerifiableTransaction(transaction).Serialize());
            var signatureHex = signature.ToString();
            var jsonPayload = "{\"data\":\"" + transactionHex + "\",\"signature\":\"" + signatureHex + "\"}";
            return jsonPayload;
        }

        public static ITransaction AttachSignatureTransaction(ITransaction transaction, Signature signature)
        {
            transaction.Signature = new Signature(signature.bytes);
            return transaction;
        }

        private static Address? NemTypeConverter(object value)
        {
            if (value.GetType() != typeof(Address)) return null;
            var castValue = (ByteArray)value;
            return new Address(castValue.bytes);
        }

        public static byte[] RawAddressToBytes(string rawAddress)
        {
            return Converter.Utf8ToBytes(rawAddress);
        }

        private static RuleBasedTransactionFactory BuildRules(Dictionary<Type, Func<object, object>>? typeRuleOverrides)
        {
            var assm = Assembly.GetExecutingAssembly();
            var types = assm.GetTypes()
                .Where(p => p.Namespace == "CatSdk.Nem")
                .OrderBy(o => o.Name)
                .Where(s => !s.Name.Contains("<>"))
                .ToList();
            //var factory = new RuleBasedTransactionFactory(types, NemTypeConverter, typeRuleOverrides);
            var factory = new RuleBasedTransactionFactory(types, RawAddressToBytes, null, typeRuleOverrides);

            factory.Autodetect();

            var enumsMapping = new[]
            {
                "LinkAction",
                "MessageType",
                "MosaicSupplyChangeAction",
                "MosaicTransferFeeType",
                "MultisigAccountModificationType",
                "NetworkType",
                "TransactionType",
            };
            foreach (var key in enumsMapping)
            {
                factory.AddEnumParser(key);
            }

            var structsMapping = new[]
            {
                "CosignatureV1",
                "SizePrefixedCosignatureV1",
                "Message",
                "NamespaceId",
                "MosaicId",
                "Mosaic",
                "SizePrefixedMosaic",
                "MosaicLevy",
                "MosaicProperty",
                "SizePrefixedMosaicProperty",
                "MosaicDefinition",
                "MultisigAccountModification",
                "SizePrefixedMultisigAccountModification",
            };

            foreach (var key in structsMapping)
            {
                factory.AddStructParser(key);
            }

            var sdkTypeMapping = new Dictionary<string, Type>()
            {
                {"Address", typeof(Address)},
                {"Hash256", typeof(Hash256)},
                {"PublicKey", typeof(PublicKey)},
            };
            foreach (var key in sdkTypeMapping.Keys)
            {
                factory.AddPodParser(key, sdkTypeMapping[key]);
            }

            var arrayParserMapping = new[]
            {
                "struct:SizePrefixedCosignatureV1",
                "struct:SizePrefixedMosaic",
                "struct:SizePrefixedMosaicProperty",
                "struct:SizePrefixedMultisigAccountModification",
            };
            foreach (var key in arrayParserMapping)
            {
                factory.AddArrayParser(key);
            }
            return factory;
        }
    }
}