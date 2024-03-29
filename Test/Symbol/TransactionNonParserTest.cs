
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using CatSdk.Facade;
using CatSdk.Symbol;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;

namespace Test.Symbol
{
    public class TransactionNonParserTest
    {
        private readonly SymbolFacade Facade = new(Network.TestNet);
        [Test]
        public void AccountAddressRestrictionTransactionV1_account_address_restriction_single_1()
        {
            var payload = "D0000000000000007695D855CBB6CB83D5BD08E9D76145674F805D741301883387B7101FD8CA84329BB14DBF2F0B4CD58AA84CF31AC6899D134FC38FAB0E7A76F6216ACD60914ACBD294E5E650ACC2A911B548BE2A1806FF4717621BCE3EC1007295219AFFC17B820000000001985041E0FEEEEFFEEEEFFEE0711EE7711EE77101000201000000009841E5B8E40781CF74DABF592817DE48711D778648DEAFB298F409274B52FABBFBCF7E7DF7E20DE1D0C3F657FB8595C1989059321905F681BCF47EA33BBF5E6F8298B5440854FDED";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_ADDRESS_RESTRICTION},
            {"RestrictionFlags",
                new [] {
                    AccountRestrictionFlags.ADDRESS,
                }
            },
            {"RestrictionAdditions", new[] {new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ")),new UnresolvedAddress(Converter.StringToAddress("TD2ASJ2LKL5LX66PPZ67PYQN4HIMH5SX7OCZLQI"))}},
            {"RestrictionDeletions", new[] {new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))}},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("D294E5E650ACC2A911B548BE2A1806FF4717621BCE3EC1007295219AFFC17B82"))},
            {"Signature", new Signature(Converter.HexToBytes("7695D855CBB6CB83D5BD08E9D76145674F805D741301883387B7101FD8CA84329BB14DBF2F0B4CD58AA84CF31AC6899D134FC38FAB0E7A76F6216ACD60914ACB"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountAddressRestrictionTransactionV1_account_address_restriction_single_2()
        {
            var payload = "A0000000000000004E1E910A55162EA9D5E9B17EA6AB357290E97030969C2FAFC18BCF3D73E08827F0CC9A304088742D170E8B3CE1EC4AAAC813F0F7BB6C6BBAFAEBCAE9C23D43276A4E5B14BEDA025A0F12D76FA4391E96FA26D85BE24B3E8C4A08F336ABA1C6F40000000001985041E0FEEEEFFEEEEFFEE0711EE7711EE77101C0010000000000989059321905F681BCF47EA33BBF5E6F8298B5440854FDED";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_ADDRESS_RESTRICTION},
            {"RestrictionFlags",
                new [] {
                    AccountRestrictionFlags.ADDRESS,
                    AccountRestrictionFlags.OUTGOING,
                    AccountRestrictionFlags.BLOCK,
                }
            },
            {"RestrictionAdditions", new[] {new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))}},
            {"RestrictionDeletions", System.Array.Empty<UnresolvedAddress>()},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("6A4E5B14BEDA025A0F12D76FA4391E96FA26D85BE24B3E8C4A08F336ABA1C6F4"))},
            {"Signature", new Signature(Converter.HexToBytes("4E1E910A55162EA9D5E9B17EA6AB357290E97030969C2FAFC18BCF3D73E08827F0CC9A304088742D170E8B3CE1EC4AAAC813F0F7BB6C6BBAFAEBCAE9C23D4327"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountAddressRestrictionTransactionV1_account_address_restriction_aggregate_1()
        {
            var payload = "28010000000000006A1C14B723E973CC450165EFC629DCAC65F0A9B70517F27BD426BFEB9C21E33C91699BCDF34A0464DBA8D4A7237E4A4309139F2E9378BEC7B67C7EA1F92D5DC683D1CD2DA160075F016CC04B51397186FEF67006364D851DA9EB0CF3E886E3720000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771553D90AFA4B171840BCBA16DB6F82A767C98344D5F6D5F2B0B05A8902D01BD4D800000000000000080000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198504101000201000000009841E5B8E40781CF74DABF592817DE48711D778648DEAFB298F409274B52FABBFBCF7E7DF7E20DE1D0C3F657FB8595C1989059321905F681BCF47EA33BBF5E6F8298B5440854FDED";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_ADDRESS_RESTRICTION},
                        {"RestrictionFlags",
                            new [] {
                                AccountRestrictionFlags.ADDRESS,
                            }
                        },
                        {"RestrictionAdditions", new[] {new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ")),new UnresolvedAddress(Converter.StringToAddress("TD2ASJ2LKL5LX66PPZ67PYQN4HIMH5SX7OCZLQI"))}},
                        {"RestrictionDeletions", new[] {new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))}},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("83D1CD2DA160075F016CC04B51397186FEF67006364D851DA9EB0CF3E886E372"))},
            {"Signature", new Signature(Converter.HexToBytes("6A1C14B723E973CC450165EFC629DCAC65F0A9B70517F27BD426BFEB9C21E33C91699BCDF34A0464DBA8D4A7237E4A4309139F2E9378BEC7B67C7EA1F92D5DC6"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("553D90AFA4B171840BCBA16DB6F82A767C98344D5F6D5F2B0B05A8902D01BD4D"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountAddressRestrictionTransactionV1_account_address_restriction_aggregate_2()
        {
            var payload = "F800000000000000E9FF7CE62D0925F2AF5C7C8560B01856833B643B24FB7D850C307B9021065A9A58ADCF295D9A48AF2D59344ED8998E80607B3EB21458EE7DC7011B3869E2B4EC1CBF41A4BFD2355911130C4A1CF08AA3A2E4849E5DA5A273545A9D1D1E084AA40000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771FFBAABB2E7655A0D6388DA5736FB9BA45EF6F08DB5D2659F427467FD80D6A341500000000000000050000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198504101C0010000000000989059321905F681BCF47EA33BBF5E6F8298B5440854FDED";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_ADDRESS_RESTRICTION},
                        {"RestrictionFlags",
                            new [] {
                                AccountRestrictionFlags.ADDRESS,
                                AccountRestrictionFlags.OUTGOING,
                                AccountRestrictionFlags.BLOCK,
                            }
                        },
                        {"RestrictionAdditions", new[] {new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))}},
                        {"RestrictionDeletions", System.Array.Empty<UnresolvedAddress>()},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("1CBF41A4BFD2355911130C4A1CF08AA3A2E4849E5DA5A273545A9D1D1E084AA4"))},
            {"Signature", new Signature(Converter.HexToBytes("E9FF7CE62D0925F2AF5C7C8560B01856833B643B24FB7D850C307B9021065A9A58ADCF295D9A48AF2D59344ED8998E80607B3EB21458EE7DC7011B3869E2B4EC"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("FFBAABB2E7655A0D6388DA5736FB9BA45EF6F08DB5D2659F427467FD80D6A341"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountKeyLinkTransactionV1_account_key_link_single_1()
        {
            var payload = "A100000000000000F9197D11A025101D4396A3475EEBD790DC62DC63859C4FEA5DA57BE16D7BF3771AB705D063E05356AD3FBFA344425CAAB47B0831AEBB2D65A08C0C014B110C6209DF26A84FD347A711C50CEF23C5094F33E4B52435365EA460A894B7785F24830000000001984C41E0FEEEEFFEEEEFFEE0711EE7711EE771F6503F78FBF99544B906872DDB392F4BE707180D285E7919DBACEF2E9573B1E601";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_KEY_LINK},
            {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("F6503F78FBF99544B906872DDB392F4BE707180D285E7919DBACEF2E9573B1E6"))},
            {"LinkAction", LinkAction.LINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("09DF26A84FD347A711C50CEF23C5094F33E4B52435365EA460A894B7785F2483"))},
            {"Signature", new Signature(Converter.HexToBytes("F9197D11A025101D4396A3475EEBD790DC62DC63859C4FEA5DA57BE16D7BF3771AB705D063E05356AD3FBFA344425CAAB47B0831AEBB2D65A08C0C014B110C62"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountKeyLinkTransactionV1_account_key_link_single_2()
        {
            var payload = "A1000000000000007E87B96BC9C9481B675BF1C0DB8618E4F5AFE5E95EEF7FB37231C252BA76534A1EE392CC2210350F35E7096A43003049ADC71F48556621896014227BC1DDF54F8D8B630E0A3086A427DC187452878840ADA021A6D8CACFCF023B7CD172F1B1AB0000000001984C41E0FEEEEFFEEEEFFEE0711EE7711EE7719801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B600";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_KEY_LINK},
            {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
            {"LinkAction", LinkAction.UNLINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("8D8B630E0A3086A427DC187452878840ADA021A6D8CACFCF023B7CD172F1B1AB"))},
            {"Signature", new Signature(Converter.HexToBytes("7E87B96BC9C9481B675BF1C0DB8618E4F5AFE5E95EEF7FB37231C252BA76534A1EE392CC2210350F35E7096A43003049ADC71F48556621896014227BC1DDF54F"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountKeyLinkTransactionV1_account_key_link_aggregate_1()
        {
            var payload = "00010000000000008FF91B4D9027D09053E39059C271A3C633B6B740D0722172FB58838A1DDBE2B472D9537151EA989AF5BF183BD1DE42CC9117F466DAC0A4F3CA5C8424A7D249386C3AD86C294BCC0244EF2F68D47BA6426FF48C42CB5FF1978139E0256142BACC0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7715E870D460A2A239AE83466240C3ED08742134705FB55A85E3536527D4EA072105800000000000000510000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984C41F6503F78FBF99544B906872DDB392F4BE707180D285E7919DBACEF2E9573B1E60100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_KEY_LINK},
                        {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("F6503F78FBF99544B906872DDB392F4BE707180D285E7919DBACEF2E9573B1E6"))},
                        {"LinkAction", LinkAction.LINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("6C3AD86C294BCC0244EF2F68D47BA6426FF48C42CB5FF1978139E0256142BACC"))},
            {"Signature", new Signature(Converter.HexToBytes("8FF91B4D9027D09053E39059C271A3C633B6B740D0722172FB58838A1DDBE2B472D9537151EA989AF5BF183BD1DE42CC9117F466DAC0A4F3CA5C8424A7D24938"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("5E870D460A2A239AE83466240C3ED08742134705FB55A85E3536527D4EA07210"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountKeyLinkTransactionV1_account_key_link_aggregate_2()
        {
            var payload = "0001000000000000EBB7CEC3AF0608CA6BB21826B2E5AE07BE95E49B20C98B0DB33D2DB36B09174A0D54C98855D68999DFBE81F893B6F5D496F9233730BA56B7FA8BDD7DE2DAA566D571DBBC3B5948FBC7239B34964484AA478046F8BB09B3F3805F853935125E5D0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77106C15A5AFC09E2EB3DE1B42E3B8E9674438C7D60995469ACDBED1D453F5962695800000000000000510000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984C419801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B60000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_KEY_LINK},
                        {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
                        {"LinkAction", LinkAction.UNLINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("D571DBBC3B5948FBC7239B34964484AA478046F8BB09B3F3805F853935125E5D"))},
            {"Signature", new Signature(Converter.HexToBytes("EBB7CEC3AF0608CA6BB21826B2E5AE07BE95E49B20C98B0DB33D2DB36B09174A0D54C98855D68999DFBE81F893B6F5D496F9233730BA56B7FA8BDD7DE2DAA566"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("06C15A5AFC09E2EB3DE1B42E3B8E9674438C7D60995469ACDBED1D453F596269"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMetadataTransactionV1_account_metadata_single_1()
        {
            var payload = "AA00000000000000A3204BB3BDBCBFEF5BA954DAB9D6AE784A84B492AA9911B533C381BBB2BBD06A36B4F623A00CA60F7BAF93CCB46441506F469EBBAF4C18352AF548E8315F4B3DFA182D113CBFB48881D3EF7F4CC5BDB29069087E2A7E903093A02D09684A4F940000000001984441E0FEEEEFFEEEEFFEE0711EE7711EE7719841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A000000000000000A000600313233424143";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_METADATA},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"ScopedMetadataKey", 10},
            {"ValueSizeDelta", 10},
            {"Value", Converter.HexToBytes("313233424143")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("FA182D113CBFB48881D3EF7F4CC5BDB29069087E2A7E903093A02D09684A4F94"))},
            {"Signature", new Signature(Converter.HexToBytes("A3204BB3BDBCBFEF5BA954DAB9D6AE784A84B492AA9911B533C381BBB2BBD06A36B4F623A00CA60F7BAF93CCB46441506F469EBBAF4C18352AF548E8315F4B3D"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMetadataTransactionV1_account_metadata_single_2()
        {
            var payload = "AA0000000000000003B8387DAA75186536106B847E4AE26213EADCC166A70EAA20C2AF66646D9243D54413EBFA4BB0B614E0ADCAF2417EA350198A26F3DCDBB8B4DACCECC8B1D418A679C078A6514E8DC0CA28B1A943D8BA9373AC8B14CCA6B07FEA07ABF90529130000000001984441E0FEEEEFFEEEEFFEE0711EE7711EE7719841E5B8E40781CF74DABF592817DE48711D778648DEAFB2EFCAAB0000000000FAFF0600313233424143";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_METADATA},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"ScopedMetadataKey", 11258607},
            {"ValueSizeDelta", -6},
            {"Value", Converter.HexToBytes("313233424143")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("A679C078A6514E8DC0CA28B1A943D8BA9373AC8B14CCA6B07FEA07ABF9052913"))},
            {"Signature", new Signature(Converter.HexToBytes("03B8387DAA75186536106B847E4AE26213EADCC166A70EAA20C2AF66646D9243D54413EBFA4BB0B614E0ADCAF2417EA350198A26F3DCDBB8B4DACCECC8B1D418"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMetadataTransactionV1_account_metadata_aggregate_1()
        {
            var payload = "0801000000000000267C52D9EC00722EFEE5696D994338270A9163F22B3248611FC0E37590BAE07B5FCFB08A075C086962A25D31B42AB283235021C6F8BE3C79EF70AE1B010D956705785D97A5BEB8B77E1F567DA9C2D18048515A01F34E9040EA604C06CF0E6FEC0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77121CD7DF1DCA82BB7DEF6F46B360EDF56376CCE4C8B80D17F22AD39D5321D052C60000000000000005A00000000000000000000000000000000000000000000000000000000000000000000000000000000000000019844419841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A000000000000000A000600313233424143000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_METADATA},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                        {"ScopedMetadataKey", 10},
                        {"ValueSizeDelta", 10},
                        {"Value", Converter.HexToBytes("313233424143")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("05785D97A5BEB8B77E1F567DA9C2D18048515A01F34E9040EA604C06CF0E6FEC"))},
            {"Signature", new Signature(Converter.HexToBytes("267C52D9EC00722EFEE5696D994338270A9163F22B3248611FC0E37590BAE07B5FCFB08A075C086962A25D31B42AB283235021C6F8BE3C79EF70AE1B010D9567"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("21CD7DF1DCA82BB7DEF6F46B360EDF56376CCE4C8B80D17F22AD39D5321D052C"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMetadataTransactionV1_account_metadata_aggregate_2()
        {
            var payload = "0801000000000000A7F24315C43FD5DB5DA323E460CAA1EBE8D138E311ED26035343D24DB792E106251D97A2307CBDDAABD3F05C069C069FE25B0F131D9C53B46F76EF160360A8E88501AD37DE64117F3F9DBCC5751F62FDF60FE3B7BBAD8BF77F94E7F9DAD4438C0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7715AA2E82C4CDE5674CF0EA42BB6128CF177E5135126645C2BE70956F2018A08B460000000000000005A00000000000000000000000000000000000000000000000000000000000000000000000000000000000000019844419841E5B8E40781CF74DABF592817DE48711D778648DEAFB2EFCAAB0000000000FAFF0600313233424143000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_METADATA},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                        {"ScopedMetadataKey", 11258607},
                        {"ValueSizeDelta", -6},
                        {"Value", Converter.HexToBytes("313233424143")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("8501AD37DE64117F3F9DBCC5751F62FDF60FE3B7BBAD8BF77F94E7F9DAD4438C"))},
            {"Signature", new Signature(Converter.HexToBytes("A7F24315C43FD5DB5DA323E460CAA1EBE8D138E311ED26035343D24DB792E106251D97A2307CBDDAABD3F05C069C069FE25B0F131D9C53B46F76EF160360A8E8"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("5AA2E82C4CDE5674CF0EA42BB6128CF177E5135126645C2BE70956F2018A08B4"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMosaicRestrictionTransactionV1_account_mosaic_restriction_single_1()
        {
            var payload = "9800000000000000FD9028F3F1A77147A0A41A0159DC0AD8B13FDA38F7076684F769C1B0BB1CEBED212AA9D6590CE68FB976998D263A2B9C86A744215B35A2EAE02E492E4B788A742636536393B22D8EC6DC9E1E2A3F4266839DB16634821789BDFCD5FD51C43B220000000001985042E0FEEEEFFEEEEFFEE0711EE7711EE7710200010100000000E803000000000000D007000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_MOSAIC_RESTRICTION},
            {"RestrictionFlags",
                new [] {
                    AccountRestrictionFlags.MOSAIC_ID,
                }
            },
            {"RestrictionAdditions", new[] {new UnresolvedMosaicId(1000)}},
            {"RestrictionDeletions", new[] {new UnresolvedMosaicId(2000)}},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("2636536393B22D8EC6DC9E1E2A3F4266839DB16634821789BDFCD5FD51C43B22"))},
            {"Signature", new Signature(Converter.HexToBytes("FD9028F3F1A77147A0A41A0159DC0AD8B13FDA38F7076684F769C1B0BB1CEBED212AA9D6590CE68FB976998D263A2B9C86A744215B35A2EAE02E492E4B788A74"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMosaicRestrictionTransactionV1_account_mosaic_restriction_single_2()
        {
            var payload = "90000000000000001EB35E0C52602BF150054BDB7B938335A7BB30311C66CEEA869F98CB8808AE214A004AFBEE92B091138C9C7969D08E7B12476C30E182644C3C2A9590BE206F7B109184E25B10CD680042331EFCDE6C5BE55659DDD747F83CAA729CAD575C17F30000000001985042E0FEEEEFFEEEEFFEE0711EE7711EE77102800100000000004CCCD78612DDF5CA";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_MOSAIC_RESTRICTION},
            {"RestrictionFlags",
                new [] {
                    AccountRestrictionFlags.MOSAIC_ID,
                    AccountRestrictionFlags.BLOCK,
                }
            },
            {"RestrictionAdditions", new[] {new UnresolvedMosaicId(14624838436596993100)}},
            {"RestrictionDeletions", System.Array.Empty<UnresolvedMosaicId>()},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("109184E25B10CD680042331EFCDE6C5BE55659DDD747F83CAA729CAD575C17F3"))},
            {"Signature", new Signature(Converter.HexToBytes("1EB35E0C52602BF150054BDB7B938335A7BB30311C66CEEA869F98CB8808AE214A004AFBEE92B091138C9C7969D08E7B12476C30E182644C3C2A9590BE206F7B"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMosaicRestrictionTransactionV1_account_mosaic_restriction_aggregate_1()
        {
            var payload = "F000000000000000C1BDC572211630B84D43ADFB11DA5004E42093E92CE96E144BF66E6F2A2CDDFBF5138CA52F32ED23E7D8DECDA8FFC78DFC024552CCC19D605E4F1885C74D369B47AE9AFBF35F72617BEC0A990D5BCFCD3651D5E6E4DF51A29E900595A1AF7D1E0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771C9B816E2B225F39322E72150DADA9F4A8C6F46C2A429F6DF4C89776A4CA8443B48000000000000004800000000000000000000000000000000000000000000000000000000000000000000000000000000000000019850420200010100000000E803000000000000D007000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_MOSAIC_RESTRICTION},
                        {"RestrictionFlags",
                            new [] {
                                AccountRestrictionFlags.MOSAIC_ID,
                            }
                        },
                        {"RestrictionAdditions", new[] {new UnresolvedMosaicId(1000)}},
                        {"RestrictionDeletions", new[] {new UnresolvedMosaicId(2000)}},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("47AE9AFBF35F72617BEC0A990D5BCFCD3651D5E6E4DF51A29E900595A1AF7D1E"))},
            {"Signature", new Signature(Converter.HexToBytes("C1BDC572211630B84D43ADFB11DA5004E42093E92CE96E144BF66E6F2A2CDDFBF5138CA52F32ED23E7D8DECDA8FFC78DFC024552CCC19D605E4F1885C74D369B"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("C9B816E2B225F39322E72150DADA9F4A8C6F46C2A429F6DF4C89776A4CA8443B"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountMosaicRestrictionTransactionV1_account_mosaic_restriction_aggregate_2()
        {
            var payload = "E800000000000000AFECA8EE9220F05F8EDEC66E27F698E9D3774B40FF1ED1B2501CBDE88690A901F19F8F03006F6C96083B1B0D09CC7D9CBA77E2D6A4A59E67FB7DFE105E9DE1969F088F7A876138C11646E2ECA8ED00FC57AC81F3DC37DEC9991A6959700325ED0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7713B8D31922E345C3F457E73D6DA388FA8F09E0C157AA9E77680A4EBBC3B070562400000000000000040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198504202800100000000004CCCD78612DDF5CA";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_MOSAIC_RESTRICTION},
                        {"RestrictionFlags",
                            new [] {
                                AccountRestrictionFlags.MOSAIC_ID,
                                AccountRestrictionFlags.BLOCK,
                            }
                        },
                        {"RestrictionAdditions", new[] {new UnresolvedMosaicId(14624838436596993100)}},
                        {"RestrictionDeletions", System.Array.Empty<UnresolvedMosaicId>()},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("9F088F7A876138C11646E2ECA8ED00FC57AC81F3DC37DEC9991A6959700325ED"))},
            {"Signature", new Signature(Converter.HexToBytes("AFECA8EE9220F05F8EDEC66E27F698E9D3774B40FF1ED1B2501CBDE88690A901F19F8F03006F6C96083B1B0D09CC7D9CBA77E2D6A4A59E67FB7DFE105E9DE196"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("3B8D31922E345C3F457E73D6DA388FA8F09E0C157AA9E77680A4EBBC3B070562"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountOperationRestrictionTransactionV1_account_operation_restriction_single_1()
        {
            var payload = "8C00000000000000DD7BC1EEFC484BB258024BF0CCEA65E49A83805A63948A60E52F0FD0349C731D1A9F4070FB21C1456FC8C265743BAE84D2D97A9EA3F9A2E4577B5A383C58642D357B615F58B325C42286A51C3E7C797B92135F871D338312D6FCC23BE78FBE130000000001985043E0FEEEEFFEEEEFFEE0711EE7711EE771044001010000000052425441";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_OPERATION_RESTRICTION},
            {"RestrictionFlags",
                new [] {
                    AccountRestrictionFlags.OUTGOING,
                    AccountRestrictionFlags.TRANSACTION_TYPE,
                }
            },
            {"RestrictionAdditions", new[] {TransactionType.SECRET_PROOF}},
            {"RestrictionDeletions", new[] {TransactionType.TRANSFER}},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("357B615F58B325C42286A51C3E7C797B92135F871D338312D6FCC23BE78FBE13"))},
            {"Signature", new Signature(Converter.HexToBytes("DD7BC1EEFC484BB258024BF0CCEA65E49A83805A63948A60E52F0FD0349C731D1A9F4070FB21C1456FC8C265743BAE84D2D97A9EA3F9A2E4577B5A383C58642D"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountOperationRestrictionTransactionV1_account_operation_restriction_single_2()
        {
            var payload = "8A000000000000003BB0589E7608A5BB4A6FC071A1CBD604DBCC4B34AFC46C97674C1AB287192DB41BF3BD7EB77DC7E68F310D4A62B81CB23511834E6BCB21048F4EA9883284D97E20C98B818D42B45707812D9AEDD8DF76D575EEA2C35480D45F1BC7104D4E25CE0000000001985043E0FEEEEFFEEEEFFEE0711EE7711EE77104C00100000000004E42";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ACCOUNT_OPERATION_RESTRICTION},
            {"RestrictionFlags",
                new [] {
                    AccountRestrictionFlags.OUTGOING,
                    AccountRestrictionFlags.TRANSACTION_TYPE,
                    AccountRestrictionFlags.BLOCK,
                }
            },
            {"RestrictionAdditions", new[] {TransactionType.ADDRESS_ALIAS}},
            {"RestrictionDeletions", System.Array.Empty<TransactionType>()},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("20C98B818D42B45707812D9AEDD8DF76D575EEA2C35480D45F1BC7104D4E25CE"))},
            {"Signature", new Signature(Converter.HexToBytes("3BB0589E7608A5BB4A6FC071A1CBD604DBCC4B34AFC46C97674C1AB287192DB41BF3BD7EB77DC7E68F310D4A62B81CB23511834E6BCB21048F4EA9883284D97E"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountOperationRestrictionTransactionV1_account_operation_restriction_aggregate_1()
        {
            var payload = "E800000000000000645CCB69512162882D705DFB599DADD9AB082AE8BB59A9237C2819BF35F2F18ED5AE27881F79548003277B38BB7A46157EC56DC99F4E178C4DEF8090755139705D500E7BE219C910C07C33560769AD7D1025DA3FB845C646E43D017D201CF8000000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771C257D6202832DE1D7C1632853DA071244EAE31867DD5AEBD2E3A2232B7772D2D40000000000000003C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198504304400101000000005242544100000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_OPERATION_RESTRICTION},
                        {"RestrictionFlags",
                            new [] {
                                AccountRestrictionFlags.OUTGOING,
                                AccountRestrictionFlags.TRANSACTION_TYPE,
                            }
                        },
                        {"RestrictionAdditions", new[] {TransactionType.SECRET_PROOF}},
                        {"RestrictionDeletions", new[] {TransactionType.TRANSFER}},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("5D500E7BE219C910C07C33560769AD7D1025DA3FB845C646E43D017D201CF800"))},
            {"Signature", new Signature(Converter.HexToBytes("645CCB69512162882D705DFB599DADD9AB082AE8BB59A9237C2819BF35F2F18ED5AE27881F79548003277B38BB7A46157EC56DC99F4E178C4DEF809075513970"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("C257D6202832DE1D7C1632853DA071244EAE31867DD5AEBD2E3A2232B7772D2D"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AccountOperationRestrictionTransactionV1_account_operation_restriction_aggregate_2()
        {
            var payload = "E800000000000000635961D27DBF6178FF952D1E98F55A09EAD1248141BC32248B29F1A7D11A6E9CE5BD011746D85D73A977046E85ADAB60547FC0FEA682E0C23286A1385B768D4C896F8F32730913961A94EBB0ED6959434BE790FA8810D86E7FF91774BCB180A50000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77185170A5F6579EC36FC651524D1F953744E635AEF2D890C3DD696C34F683A039140000000000000003A000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198504304C00100000000004E42000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ACCOUNT_OPERATION_RESTRICTION},
                        {"RestrictionFlags",
                            new [] {
                                AccountRestrictionFlags.OUTGOING,
                                AccountRestrictionFlags.TRANSACTION_TYPE,
                                AccountRestrictionFlags.BLOCK,
                            }
                        },
                        {"RestrictionAdditions", new[] {TransactionType.ADDRESS_ALIAS}},
                        {"RestrictionDeletions", System.Array.Empty<TransactionType>()},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("896F8F32730913961A94EBB0ED6959434BE790FA8810D86E7FF91774BCB180A5"))},
            {"Signature", new Signature(Converter.HexToBytes("635961D27DBF6178FF952D1E98F55A09EAD1248141BC32248B29F1A7D11A6E9CE5BD011746D85D73A977046E85ADAB60547FC0FEA682E0C23286A1385B768D4C"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("85170A5F6579EC36FC651524D1F953744E635AEF2D890C3DD696C34F683A0391"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AddressAliasTransactionV1_address_alias_single_1()
        {
            var payload = "A100000000000000A2B62B8383199C1030E1231E9BDB9FA0DA44646E7ADD17C91F9136438DF16D7C629C9B6F017DD47FC0AD066C05E2E71747C7834D188665FE2B1ACC474A27741BF1C440FF40F3B9E8E768B9B306E2231B0E349FF83F327E1824A1E5AF333EC2DA0000000001984E42E0FEEEEFFEEEEFFEE0711EE7711EE7714BFA5F372D55B3849841E5B8E40781CF74DABF592817DE48711D778648DEAFB201";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ADDRESS_ALIAS},
            {"NamespaceId", new NamespaceId(9562080086528621131)},
            {"Address", new Address(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"AliasAction", AliasAction.LINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("F1C440FF40F3B9E8E768B9B306E2231B0E349FF83F327E1824A1E5AF333EC2DA"))},
            {"Signature", new Signature(Converter.HexToBytes("A2B62B8383199C1030E1231E9BDB9FA0DA44646E7ADD17C91F9136438DF16D7C629C9B6F017DD47FC0AD066C05E2E71747C7834D188665FE2B1ACC474A27741B"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AddressAliasTransactionV1_address_alias_single_2()
        {
            var payload = "A100000000000000128FA50612DF89B1A99A9D2624BEC9957408CCBB0149D82B7F3EB9A7EAC05EB964CE554CA36B86C3776F1B8E584AB6431EC2A1B848B7479A5CBB53049B62218661C09C365DE9685B3E93420019F9F4BC853013E1AD95C67E7BBA32DB6C44D1C90000000001984E42E0FEEEEFFEEEEFFEE0711EE7711EE7714BFA5F372D55B3849841E5B8E40781CF74DABF592817DE48711D778648DEAFB200";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.ADDRESS_ALIAS},
            {"NamespaceId", new NamespaceId(9562080086528621131)},
            {"Address", new Address(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"AliasAction", AliasAction.UNLINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("61C09C365DE9685B3E93420019F9F4BC853013E1AD95C67E7BBA32DB6C44D1C9"))},
            {"Signature", new Signature(Converter.HexToBytes("128FA50612DF89B1A99A9D2624BEC9957408CCBB0149D82B7F3EB9A7EAC05EB964CE554CA36B86C3776F1B8E584AB6431EC2A1B848B7479A5CBB53049B622186"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AddressAliasTransactionV1_address_alias_aggregate_1()
        {
            var payload = "0001000000000000D746C915B445707307ED4533F414DF25E277820EB3C2305088A8798AB66041DA1224BE51AF9FDA79B7E9025DA21B14E1C81371440AE445EEAB0051564D6BAF76BC3361A2FE27D9DF789C5D126475267E37B4F06CC30356E53C55A5FC9933E1040000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771CC226F4051790D1150EA87A77C6425DCC44CB90BB827C859F57CD2963147788F5800000000000000510000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984E424BFA5F372D55B3849841E5B8E40781CF74DABF592817DE48711D778648DEAFB20100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ADDRESS_ALIAS},
                        {"NamespaceId", new NamespaceId(9562080086528621131)},
                        {"Address", new Address(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                        {"AliasAction", AliasAction.LINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("BC3361A2FE27D9DF789C5D126475267E37B4F06CC30356E53C55A5FC9933E104"))},
            {"Signature", new Signature(Converter.HexToBytes("D746C915B445707307ED4533F414DF25E277820EB3C2305088A8798AB66041DA1224BE51AF9FDA79B7E9025DA21B14E1C81371440AE445EEAB0051564D6BAF76"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("CC226F4051790D1150EA87A77C6425DCC44CB90BB827C859F57CD2963147788F"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AddressAliasTransactionV1_address_alias_aggregate_2()
        {
            var payload = "0001000000000000F507BD152F611E07BA6433C70067B50C274AA00ED6F29C4CEB22A3120FFEC83BAFA482F990A89FBCE533E982F80C83FF7B8EE9156D3723CF8EA8E8A3EDB6267B9EB78F164D02FE97FE29259E2678586A7BC08E402D14C1444A64A97B394D1F480000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7717C624B5B7854988BC31B8B7CBE48B9BD388A6247A45AB5591D4832A2ADB5C17A5800000000000000510000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984E424BFA5F372D55B3849841E5B8E40781CF74DABF592817DE48711D778648DEAFB20000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.ADDRESS_ALIAS},
                        {"NamespaceId", new NamespaceId(9562080086528621131)},
                        {"Address", new Address(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                        {"AliasAction", AliasAction.UNLINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("9EB78F164D02FE97FE29259E2678586A7BC08E402D14C1444A64A97B394D1F48"))},
            {"Signature", new Signature(Converter.HexToBytes("F507BD152F611E07BA6433C70067B50C274AA00ED6F29C4CEB22A3120FFEC83BAFA482F990A89FBCE533E982F80C83FF7B8EE9156D3723CF8EA8E8A3EDB6267B"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("7C624B5B7854988BC31B8B7CBE48B9BD388A6247A45AB5591D4832A2ADB5C17A"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AggregateBondedTransactionV1_aggregate_bonded_v1_aggregate_1()
        {
            var payload = "2002000000000000571D4D09863665FCF713326380231B13B6FFA83971620FF5513FE73FF51B0D656925BEDBC90045B0C63D5DF6D3BBED9CABD6B06B417846CB4A54C461304F60AA363A7A186418E092BABF794F98D71EA9F15BF9083D1968D1292352A9ACDBD8470000000001984142E0FEEEEFFEEEEFFEE0711EE7711EE77161E0F8B9AB2FE3E008DCE1380FECDAF5BCFB1851247BF990771154177A0B7E78A8000000000000006000000000000000000000000000000000000000000000000000000000000000000000000000000000000000019854419841E5B8E40781CF74DABF592817DE48711D778648DEAFB20000010000000000672B0000CE5600006500000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D428969746E9B1A70570A00000000000000010000000000000000000000000000003B5E19EC9CB090E2BA71D7113ABAE59DB46B56A5F2E9D45754CCE948569A9B74F01733D23F54901E68DE8D573B99B0494E28A6458B9D128CB126C8B607C593625083F1D3A1F554C175DA395FDC6713ABFF1EF0770B1418894268045A8E00C1A50000000000000000364685EDCF7B4CD10B9383E89BF3B5C687468BB4328CB2B22FEDDBA9547FE3A4BCD47C4630D2017752159B65F3AABC8B62001D94F9B2955B399E136339FB620E13332FFE3FA93171E1746290E84F373FC77BC87E0BD1DD4524C22ED3A9D2F726";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(95442763262823),
                                        Amount = new Amount(101)
                                },
                            }
                        },
                    }),
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_SUPPLY_CHANGE},
                        {"MosaicId", 6300565133566699913},
                        {"Action", MosaicSupplyChangeAction.INCREASE},
                        {"Delta", 10},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("363A7A186418E092BABF794F98D71EA9F15BF9083D1968D1292352A9ACDBD847"))},
            {"Signature", new Signature(Converter.HexToBytes("571D4D09863665FCF713326380231B13B6FFA83971620FF5513FE73FF51B0D656925BEDBC90045B0C63D5DF6D3BBED9CABD6B06B417846CB4A54C461304F60AA"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("3b5e19ec9cb090e2ba71d7113abae59db46b56a5f2e9d45754cce948569a9b74")),
                            Signature = new Signature(Converter.HexToBytes("f01733d23f54901e68de8d573b99b0494e28a6458b9d128cb126c8b607c593625083f1d3a1f554c175da395fdc6713abff1ef0770b1418894268045a8e00c1a5")),
                    },
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("364685edcf7b4cd10b9383e89bf3b5c687468bb4328cb2b22feddba9547fe3a4")),
                            Signature = new Signature(Converter.HexToBytes("bcd47c4630d2017752159b65f3aabc8b62001d94f9b2955b399e136339fb620e13332ffe3fa93171e1746290e84f373fc77bc87e0bd1dd4524c22ed3a9d2f726")),
                    },
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("61E0F8B9AB2FE3E008DCE1380FECDAF5BCFB1851247BF990771154177A0B7E78"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            ((AggregateBondedTransactionV2)tx).Version = 1;
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AggregateBondedTransactionV2_aggregate_bonded_v2_aggregate_1()
        {
            var payload = "20020000000000005001A9E7BC05B9F9A34314E7CAA8AF49C437694062DD5262CFCF9C8083388A4B1037A629D832F334FD366AEBA5CBC20BD818ED0CE115606F6C1AFA32F985FB64943CFC24A60E184016EC9BA38FD79FA5B6F396B1E1336FB69DB30D6010F0050C0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7713F2BE873F569828C88CD0DE37BB31C998FA0AAEB3308A1FFBF3D01CE49E8E9F7A8000000000000006000000000000000000000000000000000000000000000000000000000000000000000000000000000000000019854419841E5B8E40781CF74DABF592817DE48711D778648DEAFB20000010000000000672B0000CE5600006400000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D428869746E9B1A70570A0000000000000001000000000000000000000000000000066CE2878023D9AD192996FCE7364FBC6E2DDF8CD6D2FFFDF0488452CEF3E6709328BA385315ADA0F653BC9F312B9C93A4C98422B60040EF8C56BD0E7E99A4854B8FB7E1D8EAAE7E5777BCB2A68D141424BE0281246515FC3587DEE0C43A484900000000000000004C1AA3EEBD363E1C175DD0133020967B3E54EE9CEE980D352245ADB722A4810CDF22CE76709E0CF416C7032ED3D7167E49D8946DE739FBAD3F5A20DABFBFD9CFF06C7E8243E64ED79EEA84F0BD549DF8F9D1249D78BBD2F75E82744E08AA57A9";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(95442763262823),
                                        Amount = new Amount(100)
                                },
                            }
                        },
                    }),
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_SUPPLY_CHANGE},
                        {"MosaicId", 6300565133566699912},
                        {"Action", MosaicSupplyChangeAction.INCREASE},
                        {"Delta", 10},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("943CFC24A60E184016EC9BA38FD79FA5B6F396B1E1336FB69DB30D6010F0050C"))},
            {"Signature", new Signature(Converter.HexToBytes("5001A9E7BC05B9F9A34314E7CAA8AF49C437694062DD5262CFCF9C8083388A4B1037A629D832F334FD366AEBA5CBC20BD818ED0CE115606F6C1AFA32F985FB64"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("066ce2878023d9ad192996fce7364fbc6e2ddf8cd6d2fffdf0488452cef3e670")),
                            Signature = new Signature(Converter.HexToBytes("9328ba385315ada0f653bc9f312b9c93a4c98422b60040ef8c56bd0e7e99a4854b8fb7e1d8eaae7e5777bcb2a68d141424be0281246515fc3587dee0c43a4849")),
                    },
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("4c1aa3eebd363e1c175dd0133020967b3e54ee9cee980d352245adb722a4810c")),
                            Signature = new Signature(Converter.HexToBytes("df22ce76709e0cf416c7032ed3d7167e49d8946de739fbad3f5a20dabfbfd9cff06c7e8243e64ed79eea84f0bd549df8f9d1249d78bbd2f75e82744e08aa57a9")),
                    },
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("3F2BE873F569828C88CD0DE37BB31C998FA0AAEB3308A1FFBF3D01CE49E8E9F7"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AggregateCompleteTransactionV1_aggregate_complete_v1_aggregate_1()
        {
            var payload = "C002000000000000DFF51A031F1E3EB8DDB71DE5E1E2FD0DE0421BF41686DEDB6F1F5ED1D27B574EC718398181A2949835568EEC49B44F950318398C930CC0BD18317FED3B15ACF340035076D8560AAE3B6EA85CAA497619D0D2EF9BAC77A022A7C6710DAA0401AA0000000001984141E0FEEEEFFEEEEFFEE0711EE7711EE7716655F5FCF2290442DD1B3AEBB649A49249E32EBAF259403183A9A847EA22E0B6E0000000000000005C00000000000000000000000000000000000000000000000000000000000000000000000000000000000000019854419841E5B8E40781CF74DABF592817DE48711D778648DEAFB20C00000000000000476F6F6462796520F09F918B00000000800000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED1000020000000000672B0000CE560000650000000000000029CF5FD941AD25D50100000000000000D600000300504C5445000000FBAF93F70000000000000000E47F08DD7821F438E6218B5F5B28C7A363C141282FFC3E4E8C81D29D63A8A591CB617E68C37942E30A33206BABC1471C779A6E5D29AF1BC65532B97E8FC1EF424FE875B94B720E8C295D302B60AA362456373AFE8F350029E9CF54BB4F0E3BBA00000000000000000A1492EE8CE8E4DCB10E2818D5019D45128A69DDD19BCD687A48A91B3EAD64114866FC05BB9A5BF967275CCEB9DF06445DB8616DA8BD97F6A75FFD35B4DF5B586B75D9E7B2DE6AC143BCA22E0C110120350BB459A43AA1280F3F242D6A7739510000000000000000BF748F068C32E9E4E4B6FBE3E83993B44CF52BF81F447B9040D833257DBF8DB4C00460F5DD8036417BF244AC49F6882092C341A346CF57D0A0466A200476952B97BC244327362FB59659D47957D48ABF88456958A67E8F50D23EF22AB3CA55A6";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_COMPLETE},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                            }
                        },
                        {"Message", Converter.Utf8ToBytes("Goodbye 👋")},
                    }),
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(95442763262823),
                                        Amount = new Amount(101)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(15358872602548358953),
                                        Amount = new Amount(1)
                                },
                            }
                        },
                        {"Message", "D600000300504C5445000000FBAF93F7"},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("40035076D8560AAE3B6EA85CAA497619D0D2EF9BAC77A022A7C6710DAA0401AA"))},
            {"Signature", new Signature(Converter.HexToBytes("DFF51A031F1E3EB8DDB71DE5E1E2FD0DE0421BF41686DEDB6F1F5ED1D27B574EC718398181A2949835568EEC49B44F950318398C930CC0BD18317FED3B15ACF3"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("e47f08dd7821f438e6218b5f5b28c7a363c141282ffc3e4e8c81d29d63a8a591")),
                            Signature = new Signature(Converter.HexToBytes("cb617e68c37942e30a33206babc1471c779a6e5d29af1bc65532b97e8fc1ef424fe875b94b720e8c295d302b60aa362456373afe8f350029e9cf54bb4f0e3bba")),
                    },
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("0a1492ee8ce8e4dcb10e2818d5019d45128a69ddd19bcd687a48a91b3ead6411")),
                            Signature = new Signature(Converter.HexToBytes("4866fc05bb9a5bf967275cceb9df06445db8616da8bd97f6a75ffd35b4df5b586b75d9e7b2de6ac143bca22e0c110120350bb459a43aa1280f3f242d6a773951")),
                    },
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("bf748f068c32e9e4e4b6fbe3e83993b44cf52bf81f447b9040d833257dbf8db4")),
                            Signature = new Signature(Converter.HexToBytes("c00460f5dd8036417bf244ac49f6882092c341a346cf57d0a0466a200476952b97bc244327362fb59659d47957d48abf88456958a67e8f50d23ef22ab3ca55a6")),
                    },
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("6655F5FCF2290442DD1B3AEBB649A49249E32EBAF259403183A9A847EA22E0B6"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            ((AggregateCompleteTransactionV2)tx).Version = 1;
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void AggregateCompleteTransactionV2_aggregate_complete_v2_aggregate_1()
        {
            var payload = "C0020000000000003D0EB1ED5F1A6F142392ED9BBA1AC9F519B5B7952F7FB853454F49A9D4F2E8A21F2AA84DAC2DFE81AA561B613E6F8043E97128E31D39CE29D401BA35056685D2F72F531D47A2C5134534DFAFFF99C00E4BDA59280038FD3EBCDF46114FC53CCE0000000002984141E0FEEEEFFEEEEFFEE0711EE7711EE771DCE7DC355A58AEDC834B89C2E3D42DD07DBB8C9167A046856CA56EBE4EEE5AC2E0000000000000005A00000000000000000000000000000000000000000000000000000000000000000000000000000000000000019854419841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A0000000000000048656C6C6F20F09F918B000000000000800000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED1000020000000000672B0000CE560000640000000000000029CF5FD941AD25D50100000000000000D600000300504C5445000000FBAF93F70000000000000000546B242959D50EEF616378554BEF479B62057068A28B694A173A6E0B45778EA327D2A434D1ED5359B7E0028030CD35BA4305C1CC3D8062CC0D66834345B6F6674C6D78F671C9350C0F7E4A862EE2E29DB043C661A041791435E6FC7040C55DCE000000000000000046F8566072BC4629913C11031922CFDF6DBDEF85A5B45701B32A37A82ED05ED4B990451C0AD2E400AD521FA5EBD97BC5A9F0D6F9ED6C4DAE4A8D45A24DC143EA991336F5D495973D4CDC48F3CB731E43AEFC094F73F63B4E51FC5CBD7CB471D20000000000000000D38D270849BE4CE2E1B8CE9E6019AE2734C27FA2EBDDA3D64A4636F72A35AD88EC14521C6F05C41160933DD61FC1AC5DD0D6273C9ED8E3A86E1631EA98047FE7FA84D807A2CDE3A81EB017EE6A40B0108B417002F6C56219B35DE25E57EB47F5";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_COMPLETE},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                            }
                        },
                        {"Message", Converter.Utf8ToBytes("Hello 👋")},
                    }),
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(95442763262823),
                                        Amount = new Amount(100)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(15358872602548358953),
                                        Amount = new Amount(1)
                                },
                            }
                        },
                        {"Message", "D600000300504C5445000000FBAF93F7"},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("F72F531D47A2C5134534DFAFFF99C00E4BDA59280038FD3EBCDF46114FC53CCE"))},
            {"Signature", new Signature(Converter.HexToBytes("3D0EB1ED5F1A6F142392ED9BBA1AC9F519B5B7952F7FB853454F49A9D4F2E8A21F2AA84DAC2DFE81AA561B613E6F8043E97128E31D39CE29D401BA35056685D2"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("546b242959d50eef616378554bef479b62057068a28b694a173a6e0b45778ea3")),
                            Signature = new Signature(Converter.HexToBytes("27d2a434d1ed5359b7e0028030cd35ba4305c1cc3d8062cc0d66834345b6f6674c6d78f671c9350c0f7e4a862ee2e29db043c661a041791435e6fc7040c55dce")),
                    },
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("46f8566072bc4629913c11031922cfdf6dbdef85a5b45701b32a37a82ed05ed4")),
                            Signature = new Signature(Converter.HexToBytes("b990451c0ad2e400ad521fa5ebd97bc5a9f0d6f9ed6c4dae4a8d45a24dc143ea991336f5d495973d4cdc48f3cb731e43aefc094f73f63b4e51fc5cbd7cb471d2")),
                    },
                        new (){
                            SignerPublicKey = new PublicKey(Converter.HexToBytes("d38d270849be4ce2e1b8ce9e6019ae2734c27fa2ebdda3d64a4636f72a35ad88")),
                            Signature = new Signature(Converter.HexToBytes("ec14521c6f05c41160933dd61fc1ac5dd0d6273c9ed8e3a86e1631ea98047fe7fa84d807a2cde3a81eb017ee6a40b0108b417002f6c56219b35de25e57eb47f5")),
                    },
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("DCE7DC355A58AEDC834B89C2E3D42DD07DBB8C9167A046856CA56EBE4EEE5AC2"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void HashLockTransactionV1_hash_lock_single_1()
        {
            var payload = "B800000000000000DCE85092A4AA448260E9C849FBC5FA51CA92BF90DFD1831FBFBE44D0B7FB4973E243B0D651CD5DC0EE35EC60472C1598C0BF182B344FD80D26938E3DFF5F9491AC09CC13AF31045A0AF5D0427B219E6336D29375A4ACB5365ECDDE434F3E57950000000001984841E0FEEEEFFEEEEFFEE0711EE7711EE77144B262C46CEABB85809698000000000064000000000000008498B38D89C1DC8A448EA5824938FF828926CD9F7747B1844B59B4B6807E878B";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.HASH_LOCK},
            {"Mosaic",
                new UnresolvedMosaic{
                    MosaicId = new UnresolvedMosaicId(9636553580561478212),
                    Amount = new Amount(10000000),
                }
            },
            {"Duration", 100},
            {"Hash", new Hash256(Converter.HexToBytes("8498B38D89C1DC8A448EA5824938FF828926CD9F7747B1844B59B4B6807E878B"))},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("AC09CC13AF31045A0AF5D0427B219E6336D29375A4ACB5365ECDDE434F3E5795"))},
            {"Signature", new Signature(Converter.HexToBytes("DCE85092A4AA448260E9C849FBC5FA51CA92BF90DFD1831FBFBE44D0B7FB4973E243B0D651CD5DC0EE35EC60472C1598C0BF182B344FD80D26938E3DFF5F9491"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void HashLockTransactionV1_hash_lock_aggregate_1()
        {
            var payload = "100100000000000086FA92B1514E3AE2EAE225EE402C4390B2CF4C481573501B8AC793AFA9DBEA0C4C63E7F9993E62F9F100C435315BD4B0EC5F473CA7BF1A7939454F04B6168C4A0A56922477C082CCB79B3994BCB6639B952167882A129905C81E0262B49450A50000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771F0197674A946DD65165C9E7FFD0CAA15745F2E304BB9DD41ABAF2630112592D8680000000000000068000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198484144B262C46CEABB85809698000000000064000000000000008498B38D89C1DC8A448EA5824938FF828926CD9F7747B1844B59B4B6807E878B";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.HASH_LOCK},
                        {"Mosaic",
                            new UnresolvedMosaic{
                                MosaicId = new UnresolvedMosaicId(9636553580561478212),
                                Amount = new Amount(10000000),
                            }
                        },
                        {"Duration", 100},
                        {"Hash", new Hash256(Converter.HexToBytes("8498B38D89C1DC8A448EA5824938FF828926CD9F7747B1844B59B4B6807E878B"))},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("0A56922477C082CCB79B3994BCB6639B952167882A129905C81E0262B49450A5"))},
            {"Signature", new Signature(Converter.HexToBytes("86FA92B1514E3AE2EAE225EE402C4390B2CF4C481573501B8AC793AFA9DBEA0C4C63E7F9993E62F9F100C435315BD4B0EC5F473CA7BF1A7939454F04B6168C4A"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("F0197674A946DD65165C9E7FFD0CAA15745F2E304BB9DD41ABAF2630112592D8"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicAddressRestrictionTransactionV1_mosaic_address_restriction_single_1()
        {
            var payload = "B800000000000000D540747095A39055383EA6A199959BE21A43DC6324DFD215EBE2888904D6F5D6F61D259D84456DC6D731DABBCFD26C747E4A80970D56C1741D82FFE9CDB0E54013F9FD5838B8F8AC48E7526D508250E581D7ADA7E304162F334CB03A0D556E040000000001985142E0FEEEEFFEEEEFFEE0711EE7711EE7710100000000000000EFCAAB9078563412090000000000000008000000000000009841E5B8E40781CF74DABF592817DE48711D778648DEAFB2";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_ADDRESS_RESTRICTION},
            {"MosaicId", 1},
            {"RestrictionKey", 1311768467294898927},
            {"PreviousRestrictionValue", 9},
            {"NewRestrictionValue", 8},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("13F9FD5838B8F8AC48E7526D508250E581D7ADA7E304162F334CB03A0D556E04"))},
            {"Signature", new Signature(Converter.HexToBytes("D540747095A39055383EA6A199959BE21A43DC6324DFD215EBE2888904D6F5D6F61D259D84456DC6D731DABBCFD26C747E4A80970D56C1741D82FFE9CDB0E540"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicAddressRestrictionTransactionV1_mosaic_address_restriction_aggregate_1()
        {
            var payload = "1001000000000000422F08BBF26F3589B048C8C2079B18E90555724C99F8AE37FFC14CA5A2B2943C9759DDDD54837C6630A5A138AD96DD5BC478D78F7E677445EEBFC55EFA9E35C8BBAA2C0D6489F346888202F8860674C70858ED2ED33B6CCC4C16865543520CFF0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7717B6ED24A1F78B4BEC3900FBFED34AC0D18ECD29D2EB179BD0C46291107EDDEEF68000000000000006800000000000000000000000000000000000000000000000000000000000000000000000000000000000000019851420100000000000000EFCAAB9078563412090000000000000008000000000000009841E5B8E40781CF74DABF592817DE48711D778648DEAFB2";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_ADDRESS_RESTRICTION},
                        {"MosaicId", 1},
                        {"RestrictionKey", 1311768467294898927},
                        {"PreviousRestrictionValue", 9},
                        {"NewRestrictionValue", 8},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("BBAA2C0D6489F346888202F8860674C70858ED2ED33B6CCC4C16865543520CFF"))},
            {"Signature", new Signature(Converter.HexToBytes("422F08BBF26F3589B048C8C2079B18E90555724C99F8AE37FFC14CA5A2B2943C9759DDDD54837C6630A5A138AD96DD5BC478D78F7E677445EEBFC55EFA9E35C8"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("7B6ED24A1F78B4BEC3900FBFED34AC0D18ECD29D2EB179BD0C46291107EDDEEF"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicAliasTransactionV1_mosaic_alias_single_1()
        {
            var payload = "91000000000000008D5BDBFC1344DA6738E928C2547B8422D34AAB8AA80E77E9657AEC80937DA19D782F837545CFF48DD4880D08C35B7C39119B9F75F3E50DFAB0D917D4D2598BF064C9E56A3D00C0AE070BF06A400BDFEB829B00CCAB9F0ADF1A229A308EC5EB4A0000000001984E43E0FEEEEFFEEEEFFEE0711EE7711EE771A487791451FDF1B60A0000000000000001";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_ALIAS},
            {"NamespaceId", new NamespaceId(13182596108967839652)},
            {"MosaicId", 10},
            {"AliasAction", AliasAction.LINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("64C9E56A3D00C0AE070BF06A400BDFEB829B00CCAB9F0ADF1A229A308EC5EB4A"))},
            {"Signature", new Signature(Converter.HexToBytes("8D5BDBFC1344DA6738E928C2547B8422D34AAB8AA80E77E9657AEC80937DA19D782F837545CFF48DD4880D08C35B7C39119B9F75F3E50DFAB0D917D4D2598BF0"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicAliasTransactionV1_mosaic_alias_single_2()
        {
            var payload = "91000000000000006B1750C3D6F272C316EBB3916E177F2DAF2F6837CF43201A631059D02EC0FFCC554C2C64E9AB10F6B154EFE152DAAA04CCA11082DB6E81EA411E7E416A298142DD5CFC65BCEDBF0E91E4DFE20B5E1598106DD30EC59997C6E8028DBAE9910D630000000001984E43E0FEEEEFFEEEEFFEE0711EE7711EE7712AD8FC018D9A49E14CCCD78612DDF5CA00";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_ALIAS},
            {"NamespaceId", new NamespaceId(16233676262248077354)},
            {"MosaicId", 14624838436596993100},
            {"AliasAction", AliasAction.UNLINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("DD5CFC65BCEDBF0E91E4DFE20B5E1598106DD30EC59997C6E8028DBAE9910D63"))},
            {"Signature", new Signature(Converter.HexToBytes("6B1750C3D6F272C316EBB3916E177F2DAF2F6837CF43201A631059D02EC0FFCC554C2C64E9AB10F6B154EFE152DAAA04CCA11082DB6E81EA411E7E416A298142"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicAliasTransactionV1_mosaic_alias_aggregate_1()
        {
            var payload = "F000000000000000F620B8DC54CA880724AAD84C1B4D260D02DE838AA661995ED90FEF2425EC29C948C0BC68D09B09B956CA0A4457ED85B26F246F6C0471D830F74B8A776438BAA8114DDC0523930DC9F7B360CECF4DFDD5A5DF9C2B06709C577EAACCC58118AEA30000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7712FDCAABBB776C8A409B39AB27525383DC06A271643372B03F622F886C08B44B64800000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984E43A487791451FDF1B60A000000000000000100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_ALIAS},
                        {"NamespaceId", new NamespaceId(13182596108967839652)},
                        {"MosaicId", 10},
                        {"AliasAction", AliasAction.LINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("114DDC0523930DC9F7B360CECF4DFDD5A5DF9C2B06709C577EAACCC58118AEA3"))},
            {"Signature", new Signature(Converter.HexToBytes("F620B8DC54CA880724AAD84C1B4D260D02DE838AA661995ED90FEF2425EC29C948C0BC68D09B09B956CA0A4457ED85B26F246F6C0471D830F74B8A776438BAA8"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("2FDCAABBB776C8A409B39AB27525383DC06A271643372B03F622F886C08B44B6"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicAliasTransactionV1_mosaic_alias_aggregate_2()
        {
            var payload = "F000000000000000072AD7B3441046032836E13A21FF0591FFCFCCB6B80CC99BBA4EA0291B1E13830560B3BD33E1D2368C4CAD9FFC812A7F64A6029774DDA784F25290B54059CF88A2A8877BEA72600C4C83B18067F721CA8C09370ADF3445A289FD6FA69DE0B9990000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77105270A1D4E45A3D4898353D52F890D573445F81914D96DBF5A9A7EA113564E344800000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984E432AD8FC018D9A49E14CCCD78612DDF5CA0000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_ALIAS},
                        {"NamespaceId", new NamespaceId(16233676262248077354)},
                        {"MosaicId", 14624838436596993100},
                        {"AliasAction", AliasAction.UNLINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("A2A8877BEA72600C4C83B18067F721CA8C09370ADF3445A289FD6FA69DE0B999"))},
            {"Signature", new Signature(Converter.HexToBytes("072AD7B3441046032836E13A21FF0591FFCFCCB6B80CC99BBA4EA0291B1E13830560B3BD33E1D2368C4CAD9FFC812A7F64A6029774DDA784F25290B54059CF88"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("05270A1D4E45A3D4898353D52F890D573445F81914D96DBF5A9A7EA113564E34"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicDefinitionTransactionV1_mosaic_definition_single_1()
        {
            var payload = "96000000000000005D3116D285D4ED8883DBBBC8E59FED08A888DAB21C6E4B918434BE2B3AF1105EE1B94EAA9C4BB54428F4A71C711964F00848B9A9E00D8F55670991AADC16119F70F08E77C31D9816C0A63009137A9BADBE5F42431EFBC3994822A25CED9D82820000000001984D41E0FEEEEFFEEEEFFEE0711EE7711EE7719AAEBB6AA74736151027000000000000000000000504";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_DEFINITION},
            {"Duration", 10000},
            {"Nonce", 0},
            {"Flags",
                new [] {
                    MosaicFlags.RESTRICTABLE,
                    MosaicFlags.SUPPLY_MUTABLE,
                }
            },
            {"Divisibility", 4},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("70F08E77C31D9816C0A63009137A9BADBE5F42431EFBC3994822A25CED9D8282"))},
            {"Signature", new Signature(Converter.HexToBytes("5D3116D285D4ED8883DBBBC8E59FED08A888DAB21C6E4B918434BE2B3AF1105EE1B94EAA9C4BB54428F4A71C711964F00848B9A9E00D8F55670991AADC16119F"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicDefinitionTransactionV1_mosaic_definition_single_2()
        {
            var payload = "9600000000000000D3B6BEF55F6D99281079B8A138EECE9A4CACC052BC3E84D83D72C3FCF0CFA85DEA390B8FCD50F1A6A6E196DDDED52CB92FC3C216C6B5F06F96E89B23FA62B4BEFA59F3C0267DA5F9A11BBC9714B19402172CD1834F42CC4D2699301437B6BF0D0000000001984D41E0FEEEEFFEEEEFFEE0711EE7711EE7719CBBDB70BCB8CB64E803000000000000E6DE84B80003";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_DEFINITION},
            {"Duration", 1000},
            {"Nonce", 3095715558},
            {"Flags",
                new [] {
                    MosaicFlags.NONE,
                }
            },
            {"Divisibility", 3},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("FA59F3C0267DA5F9A11BBC9714B19402172CD1834F42CC4D2699301437B6BF0D"))},
            {"Signature", new Signature(Converter.HexToBytes("D3B6BEF55F6D99281079B8A138EECE9A4CACC052BC3E84D83D72C3FCF0CFA85DEA390B8FCD50F1A6A6E196DDDED52CB92FC3C216C6B5F06F96E89B23FA62B4BE"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicDefinitionTransactionV1_mosaic_definition_single_3()
        {
            var payload = "96000000000000003712BC4F3932457AD1A7CC967CC45C3D5F04A52F6B802AEC7D377E504432F1DA40DD1EDAFE9F5899BD04DFBFB1324B198CCEE3344883DEA75DCCE2D1778B65291138798330AB1EDF113867A0A03285FBFC8D433F7F688B41B33D01C7939086D50000000001984D41E0FEEEEFFEEEEFFEE0711EE7711EE771373C73AFF80478750000000000000000E6DE84B80A02";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_DEFINITION},
            {"Duration", 0},
            {"Nonce", 3095715558},
            {"Flags",
                new [] {
                    MosaicFlags.REVOKABLE,
                    MosaicFlags.TRANSFERABLE,
                }
            },
            {"Divisibility", 2},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("1138798330AB1EDF113867A0A03285FBFC8D433F7F688B41B33D01C7939086D5"))},
            {"Signature", new Signature(Converter.HexToBytes("3712BC4F3932457AD1A7CC967CC45C3D5F04A52F6B802AEC7D377E504432F1DA40DD1EDAFE9F5899BD04DFBFB1324B198CCEE3344883DEA75DCCE2D1778B6529"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicDefinitionTransactionV1_mosaic_definition_aggregate_1()
        {
            var payload = "F00000000000000032D1342734620E653DE0D6987C77EBD99D8B9818E9BF20BB7E042BF96FD2A288CB16DA71B3D60AB7627DDD5C3BCEA5901DACBDAF42B55184C51D1F19E04C62AD9408A21018F5FA6205D0A5D1A99DC3BF7295D686460569F6FC7BCD9D392F2E9E0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771E22385E28D66F4A783AC56C45640070DB628B0A9192B1F773DED09C41123ADFA4800000000000000460000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D4101CE59EBE6B06F3210270000000000000000000005040000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_DEFINITION},
                        {"Duration", 10000},
                        {"Nonce", 0},
                        {"Flags",
                            new [] {
                                MosaicFlags.RESTRICTABLE,
                                MosaicFlags.SUPPLY_MUTABLE,
                            }
                        },
                        {"Divisibility", 4},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("9408A21018F5FA6205D0A5D1A99DC3BF7295D686460569F6FC7BCD9D392F2E9E"))},
            {"Signature", new Signature(Converter.HexToBytes("32D1342734620E653DE0D6987C77EBD99D8B9818E9BF20BB7E042BF96FD2A288CB16DA71B3D60AB7627DDD5C3BCEA5901DACBDAF42B55184C51D1F19E04C62AD"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("E22385E28D66F4A783AC56C45640070DB628B0A9192B1F773DED09C41123ADFA"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicDefinitionTransactionV1_mosaic_definition_aggregate_2()
        {
            var payload = "F00000000000000015C8937E60CE6D6EBFC8CD244B3C617E92E45E5C386C2DC7F05010039DF9B95D65529BD7646A7772390ED95828F65792399C78C53B00F349F142B6FBBC749BF8D962535DE9E97E0CB8E878AA0B68B2D601D20D0BB2A46AE06C086FFED4342DFE0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7719F08B173200F10F08F6FC4C6E1B37DAE1C3B425A98C8D1EB4B3BC44AF6B2906E4800000000000000460000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D41B685550629D42453E803000000000000E6DE84B800030000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_DEFINITION},
                        {"Duration", 1000},
                        {"Nonce", 3095715558},
                        {"Flags",
                            new [] {
                                MosaicFlags.NONE,
                            }
                        },
                        {"Divisibility", 3},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("D962535DE9E97E0CB8E878AA0B68B2D601D20D0BB2A46AE06C086FFED4342DFE"))},
            {"Signature", new Signature(Converter.HexToBytes("15C8937E60CE6D6EBFC8CD244B3C617E92E45E5C386C2DC7F05010039DF9B95D65529BD7646A7772390ED95828F65792399C78C53B00F349F142B6FBBC749BF8"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("9F08B173200F10F08F6FC4C6E1B37DAE1C3B425A98C8D1EB4B3BC44AF6B2906E"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicDefinitionTransactionV1_mosaic_definition_aggregate_3()
        {
            var payload = "F0000000000000004AEF7D973B45E8D60E030DDE3D6EEB6CDA947FA7663A87223B780A6E9F23C28FC78B196EFFF719894B4E09D223D77F2B87D7334C06F47D95762E284326D10ADCC1F2E14CBF743FE0A0FC27482BA97B4734B5F80BED8C6642B075EB421F9E2F810000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771D1C267AFAC897195F41696647A89AC5E0B75A0910D0F2A3DD404F93113C356334800000000000000460000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D41B685550629D424530000000000000000E6DE84B80A020000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_DEFINITION},
                        {"Duration", 0},
                        {"Nonce", 3095715558},
                        {"Flags",
                            new [] {
                                MosaicFlags.REVOKABLE,
                                MosaicFlags.TRANSFERABLE,
                            }
                        },
                        {"Divisibility", 2},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("C1F2E14CBF743FE0A0FC27482BA97B4734B5F80BED8C6642B075EB421F9E2F81"))},
            {"Signature", new Signature(Converter.HexToBytes("4AEF7D973B45E8D60E030DDE3D6EEB6CDA947FA7663A87223B780A6E9F23C28FC78B196EFFF719894B4E09D223D77F2B87D7334C06F47D95762E284326D10ADC"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("D1C267AFAC897195F41696647A89AC5E0B75A0910D0F2A3DD404F93113C35633"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicGlobalRestrictionTransactionV1_mosaic_global_restriction_single_1()
        {
            var payload = "AA00000000000000A70ECFC4FAD876EDD481D02AF560DBC319E6AAB21DD33A9095BD45B1A5994844527F5DDBE7C10AE28D960436ACD0D6076D3D9F7ABE9473832F2839FB3370B95A0A72FF40C5C259ACCDFA578E3409242DE4DED94C84C43A11A8D3F9EC8FD773DE0000000001985141E0FEEEEFFEEEEFFEE0711EE7711EE771077C47437698051A268025252B5EF26A0100000000000000090000000000000008000000000000000106";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_GLOBAL_RESTRICTION},
            {"MosaicId", 1875072453572000775},
            {"ReferenceMosaicId", 7706325451784159270},
            {"RestrictionKey", 1},
            {"PreviousRestrictionValue", 9},
            {"NewRestrictionValue", 8},
            {"PreviousRestrictionType", MosaicRestrictionType.EQ},
            {"NewRestrictionType", MosaicRestrictionType.GE},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("0A72FF40C5C259ACCDFA578E3409242DE4DED94C84C43A11A8D3F9EC8FD773DE"))},
            {"Signature", new Signature(Converter.HexToBytes("A70ECFC4FAD876EDD481D02AF560DBC319E6AAB21DD33A9095BD45B1A5994844527F5DDBE7C10AE28D960436ACD0D6076D3D9F7ABE9473832F2839FB3370B95A"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicGlobalRestrictionTransactionV1_mosaic_global_restriction_single_2()
        {
            var payload = "AA00000000000000BB9436193DB00910693878E9530966643BAB80AF00C026FD3FD85327422707AD2E5F21B890C22220BC510301F5DC8DE7FAC2445F7022B4B8DEDC5D751E95ADF1AB12A93BCCCDB042E487A653D7E975EA1DA739FA886B8EFF7833C2CA878C96FB0000000001985141E0FEEEEFFEEEEFFEE0711EE7711EE771513FEE4E65C1235600000000000000005C11000000000000000000000000000000000000000000000006";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_GLOBAL_RESTRICTION},
            {"MosaicId", 6207017352306769745},
            {"ReferenceMosaicId", 0},
            {"RestrictionKey", 4444},
            {"PreviousRestrictionValue", 0},
            {"NewRestrictionValue", 0},
            {"PreviousRestrictionType", MosaicRestrictionType.NONE},
            {"NewRestrictionType", MosaicRestrictionType.GE},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("AB12A93BCCCDB042E487A653D7E975EA1DA739FA886B8EFF7833C2CA878C96FB"))},
            {"Signature", new Signature(Converter.HexToBytes("BB9436193DB00910693878E9530966643BAB80AF00C026FD3FD85327422707AD2E5F21B890C22220BC510301F5DC8DE7FAC2445F7022B4B8DEDC5D751E95ADF1"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicGlobalRestrictionTransactionV1_mosaic_global_restriction_aggregate_1()
        {
            var payload = "08010000000000004FB58CAE68814089A1A4D74CA49B33288E426AC7AB956EA3AE9EBFFA8C3D0C26CDC0CBDE2B597425C53AAC2E27AC6DF11776A5A50C54436364EA0BE9E60BA7465B47A3C1ECE8210626CA7638F00C38DAC6697E3FAC0461D7C9ECDF5BEB4C4D850000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77194049515EBF52723CC7B217DE82D79D5ADFFF719C1934CB50AE91693FADEDC2560000000000000005A0000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985141077C47437698051A268025252B5EF26A0100000000000000090000000000000008000000000000000106000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_GLOBAL_RESTRICTION},
                        {"MosaicId", 1875072453572000775},
                        {"ReferenceMosaicId", 7706325451784159270},
                        {"RestrictionKey", 1},
                        {"PreviousRestrictionValue", 9},
                        {"NewRestrictionValue", 8},
                        {"PreviousRestrictionType", MosaicRestrictionType.EQ},
                        {"NewRestrictionType", MosaicRestrictionType.GE},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("5B47A3C1ECE8210626CA7638F00C38DAC6697E3FAC0461D7C9ECDF5BEB4C4D85"))},
            {"Signature", new Signature(Converter.HexToBytes("4FB58CAE68814089A1A4D74CA49B33288E426AC7AB956EA3AE9EBFFA8C3D0C26CDC0CBDE2B597425C53AAC2E27AC6DF11776A5A50C54436364EA0BE9E60BA746"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("94049515EBF52723CC7B217DE82D79D5ADFFF719C1934CB50AE91693FADEDC25"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicGlobalRestrictionTransactionV1_mosaic_global_restriction_aggregate_2()
        {
            var payload = "0801000000000000AA268835334E38F0FF478710AE0E474399CDF49653E9924F8627F0BB09B59DC47C3231D8EA38F188E61407857BC2F918657E849939FBFC4FE6FD377DB558177326646FC63C7D7EA9EAA0B678CA7BDB1ECD77C7D210ACD997A8713BAB88D6A8C10000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7718D93F6BF096B6D02432E54A73A39F70937971A10926195552EFC67396C9F33AB60000000000000005A0000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985141513FEE4E65C1235600000000000000005C11000000000000000000000000000000000000000000000006000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_GLOBAL_RESTRICTION},
                        {"MosaicId", 6207017352306769745},
                        {"ReferenceMosaicId", 0},
                        {"RestrictionKey", 4444},
                        {"PreviousRestrictionValue", 0},
                        {"NewRestrictionValue", 0},
                        {"PreviousRestrictionType", MosaicRestrictionType.NONE},
                        {"NewRestrictionType", MosaicRestrictionType.GE},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("26646FC63C7D7EA9EAA0B678CA7BDB1ECD77C7D210ACD997A8713BAB88D6A8C1"))},
            {"Signature", new Signature(Converter.HexToBytes("AA268835334E38F0FF478710AE0E474399CDF49653E9924F8627F0BB09B59DC47C3231D8EA38F188E61407857BC2F918657E849939FBFC4FE6FD377DB5581773"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("8D93F6BF096B6D02432E54A73A39F70937971A10926195552EFC67396C9F33AB"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicMetadataTransactionV1_mosaic_metadata_single_1()
        {
            var payload = "B20000000000000021F6DF84B68468A19A0E204EFC45A826C02991737D0C3334F42CB64928D9537886359B83316B16060A859A5A2C1819CBC36FF520DF5F17D1529240F256CEA94CD7E3F96B4A418E8E2FDF8A45B7C34B3A354ECC07C0175763727C1FBA0B1736AC0000000001984442E0FEEEEFFEEEEFFEE0711EE7711EE7719841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A00000000000000E8030000000000000A000600313233414243";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_METADATA},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"ScopedMetadataKey", 10},
            {"TargetMosaicId", 1000},
            {"ValueSizeDelta", 10},
            {"Value", Converter.HexToBytes("313233414243")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("D7E3F96B4A418E8E2FDF8A45B7C34B3A354ECC07C0175763727C1FBA0B1736AC"))},
            {"Signature", new Signature(Converter.HexToBytes("21F6DF84B68468A19A0E204EFC45A826C02991737D0C3334F42CB64928D9537886359B83316B16060A859A5A2C1819CBC36FF520DF5F17D1529240F256CEA94C"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicMetadataTransactionV1_mosaic_metadata_single_2()
        {
            var payload = "B200000000000000EE4682A5FBE4BA1C8F8131DF3C0DF7BE4E8BAF0E3A2B2D288101F2C5261932F03E02FDC4207B5FD7E44A4771E6D3895388213C48789982B42AF05CDEB7F88E26A7FB98F0A1BE958F2D70BC8609A3539DCBD702978FC872C2D388A634FBEA074C0000000001984442E0FEEEEFFEEEEFFEE0711EE7711EE7719841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A00000000000000E803000000000000FBFF0600313233414243";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_METADATA},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
            {"ScopedMetadataKey", 10},
            {"TargetMosaicId", 1000},
            {"ValueSizeDelta", -5},
            {"Value", Converter.HexToBytes("313233414243")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("A7FB98F0A1BE958F2D70BC8609A3539DCBD702978FC872C2D388A634FBEA074C"))},
            {"Signature", new Signature(Converter.HexToBytes("EE4682A5FBE4BA1C8F8131DF3C0DF7BE4E8BAF0E3A2B2D288101F2C5261932F03E02FDC4207B5FD7E44A4771E6D3895388213C48789982B42AF05CDEB7F88E26"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicMetadataTransactionV1_mosaic_metadata_aggregate_1()
        {
            var payload = "10010000000000008EA0617C41D6BD51E768BCFA2A63F380E909BC8291F8BA1F4855D0C52EDFAA07EFD4DA8E20D3506CEBF72B8509B420447254300ABE817242B7D6D0D7C2B532211D00C6B79C08776387DBFAB93D0DEBB09D6F2E1BE8E08BD206A35594CD1531720000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771E2553E2E3FC4A959406B0F1AF9ADB9FC67D558615D523FD24119A7915FD0046868000000000000006200000000000000000000000000000000000000000000000000000000000000000000000000000000000000019844429841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A00000000000000E8030000000000000A000600313233414243000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_METADATA},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                        {"ScopedMetadataKey", 10},
                        {"TargetMosaicId", 1000},
                        {"ValueSizeDelta", 10},
                        {"Value", Converter.HexToBytes("313233414243")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("1D00C6B79C08776387DBFAB93D0DEBB09D6F2E1BE8E08BD206A35594CD153172"))},
            {"Signature", new Signature(Converter.HexToBytes("8EA0617C41D6BD51E768BCFA2A63F380E909BC8291F8BA1F4855D0C52EDFAA07EFD4DA8E20D3506CEBF72B8509B420447254300ABE817242B7D6D0D7C2B53221"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("E2553E2E3FC4A959406B0F1AF9ADB9FC67D558615D523FD24119A7915FD00468"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicMetadataTransactionV1_mosaic_metadata_aggregate_2()
        {
            var payload = "1001000000000000BF2CAD734C8F4AFB309D4543F9183B3BA7320D1302C0024D30BC310C81140D9DE47D22883282A995B614B80FBA8DFEDF1B4BE1D97AFB2192E881482B95BDCFD99F96414C1542444D215F3C971002101B031334A54DED6843C59B5CB86E164F010000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771494C04ABA6F7275CDE4C6C829C99AC3C668EE50E46F6324020E0EADA8B08E51868000000000000006200000000000000000000000000000000000000000000000000000000000000000000000000000000000000019844429841E5B8E40781CF74DABF592817DE48711D778648DEAFB20A00000000000000E803000000000000FBFF0600313233414243000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_METADATA},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"))},
                        {"ScopedMetadataKey", 10},
                        {"TargetMosaicId", 1000},
                        {"ValueSizeDelta", -5},
                        {"Value", Converter.HexToBytes("313233414243")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("9F96414C1542444D215F3C971002101B031334A54DED6843C59B5CB86E164F01"))},
            {"Signature", new Signature(Converter.HexToBytes("BF2CAD734C8F4AFB309D4543F9183B3BA7320D1302C0024D30BC310C81140D9DE47D22883282A995B614B80FBA8DFEDF1B4BE1D97AFB2192E881482B95BDCFD9"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("494C04ABA6F7275CDE4C6C829C99AC3C668EE50E46F6324020E0EADA8B08E518"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicSupplyChangeTransactionV1_mosaic_supply_change_single_1()
        {
            var payload = "9100000000000000E2170899C9BFFDB63EA730C1EE0AA60A9AB086C9127242101ACF0DEFCEA8A31D9B4CA37B6644AC2B6928527338C1CB2C87EA4ADBD98A9EFAC34430B9245C6F93F37F9FB1AFC9F6737DE4652755E6251E66ACB1FCE0A767B62F6E9DA4235E69600000000001984D42E0FEEEEFFEEEEFFEE0711EE7711EE7718869746E9B1A70570A0000000000000001";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_SUPPLY_CHANGE},
            {"MosaicId", 6300565133566699912},
            {"Action", MosaicSupplyChangeAction.INCREASE},
            {"Delta", 10},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("F37F9FB1AFC9F6737DE4652755E6251E66ACB1FCE0A767B62F6E9DA4235E6960"))},
            {"Signature", new Signature(Converter.HexToBytes("E2170899C9BFFDB63EA730C1EE0AA60A9AB086C9127242101ACF0DEFCEA8A31D9B4CA37B6644AC2B6928527338C1CB2C87EA4ADBD98A9EFAC34430B9245C6F93"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicSupplyChangeTransactionV1_mosaic_supply_change_single_2()
        {
            var payload = "9100000000000000575F393E380C091DCC5729454D7B839D52158AD00CFD07A735F385DBC0574266EAD33478F15B0F38788437B0F9249A4732808002E23ADC95B9BA1F3F1B86A2221412C49C8BB197DBDEDAB0D12AF4C24A653707369B24C995F924E78D55964BB90000000001984D42E0FEEEEFFEEEEFFEE0711EE7711EE7714CCCD78612DDF5CA0A0000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MOSAIC_SUPPLY_CHANGE},
            {"MosaicId", 14624838436596993100},
            {"Action", MosaicSupplyChangeAction.DECREASE},
            {"Delta", 10},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("1412C49C8BB197DBDEDAB0D12AF4C24A653707369B24C995F924E78D55964BB9"))},
            {"Signature", new Signature(Converter.HexToBytes("575F393E380C091DCC5729454D7B839D52158AD00CFD07A735F385DBC0574266EAD33478F15B0F38788437B0F9249A4732808002E23ADC95B9BA1F3F1B86A222"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicSupplyChangeTransactionV1_mosaic_supply_change_aggregate_1()
        {
            var payload = "F000000000000000654E486DC8DB96B8C5307ABA03C65DEBD61270A24AFC473703D1FF1DB0B554C91945A07C6B1D77DE5F1406E8B48EE09480097F0402397A5AF925E3B00C091EAC95D4073C8B7C43F263AAE6E1C8615C41019E2B4FC4AA2693191FC8E693CB4D5D0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7716FFAC840B2C866960FCBCF42AF16B113FFE309A0991DFC0E4F3772E7AFC2FB694800000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D428869746E9B1A70570A000000000000000100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_SUPPLY_CHANGE},
                        {"MosaicId", 6300565133566699912},
                        {"Action", MosaicSupplyChangeAction.INCREASE},
                        {"Delta", 10},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("95D4073C8B7C43F263AAE6E1C8615C41019E2B4FC4AA2693191FC8E693CB4D5D"))},
            {"Signature", new Signature(Converter.HexToBytes("654E486DC8DB96B8C5307ABA03C65DEBD61270A24AFC473703D1FF1DB0B554C91945A07C6B1D77DE5F1406E8B48EE09480097F0402397A5AF925E3B00C091EAC"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("6FFAC840B2C866960FCBCF42AF16B113FFE309A0991DFC0E4F3772E7AFC2FB69"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MosaicSupplyChangeTransactionV1_mosaic_supply_change_aggregate_2()
        {
            var payload = "F0000000000000008C31F816AE5EDBDCF507DF2F6E05CA7EDF4DE59AB8C3F67AA7474D44065A9E53618859CE09F2D76B92028EA267255B2DCCA6D1E0D7A10A5F3884F936883E25DF8661A3B2F2D23C954942249029CA29E0ABBDDB19B15F73D8560472FCD797EAD40000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771137E5D6F7F63CCB9E2B51A4C22481D2766E8A4FCD6A387E667A35723F2C684284800000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984D424CCCD78612DDF5CA0A000000000000000000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MOSAIC_SUPPLY_CHANGE},
                        {"MosaicId", 14624838436596993100},
                        {"Action", MosaicSupplyChangeAction.DECREASE},
                        {"Delta", 10},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("8661A3B2F2D23C954942249029CA29E0ABBDDB19B15F73D8560472FCD797EAD4"))},
            {"Signature", new Signature(Converter.HexToBytes("8C31F816AE5EDBDCF507DF2F6E05CA7EDF4DE59AB8C3F67AA7474D44065A9E53618859CE09F2D76B92028EA267255B2DCCA6D1E0D7A10A5F3884F936883E25DF"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("137E5D6F7F63CCB9E2B51A4C22481D2766E8A4FCD6A387E667A35723F2C68428"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MultisigAccountModificationTransactionV1_multisig_account_modification_single_1()
        {
            var payload = "D0000000000000004E30A6E6477467C8314BEFF4922D58C33ED32AF351DD88640AF200EB4EE9C6FAD92B42D7FA236485F99D4D2C253993A66B2B00454A1159E71CBB3EB51394AC670499B08886DED0962C696C707C0964588FE4B6C3BC82BECF9F1F63257ED4CB870000000001985541E0FEEEEFFEEEEFFEE0711EE7711EE77101020201000000009841E5B8E40781CF74DABF592817DE48711D778648DEAFB298F409274B52FABBFBCF7E7DF7E20DE1D0C3F657FB8595C1989059321905F681BCF47EA33BBF5E6F8298B5440854FDED";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.MULTISIG_ACCOUNT_MODIFICATION},
            {"MinRemovalDelta", 1},
            {"MinApprovalDelta", 2},
            {"AddressAdditions",    new UnresolvedAddress[]{
                new (Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ")),new (Converter.StringToAddress("TD2ASJ2LKL5LX66PPZ67PYQN4HIMH5SX7OCZLQI")),}
            },
            {"AddressDeletions",    new UnresolvedAddress[]{
                new (Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I")),}
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("0499B08886DED0962C696C707C0964588FE4B6C3BC82BECF9F1F63257ED4CB87"))},
            {"Signature", new Signature(Converter.HexToBytes("4E30A6E6477467C8314BEFF4922D58C33ED32AF351DD88640AF200EB4EE9C6FAD92B42D7FA236485F99D4D2C253993A66B2B00454A1159E71CBB3EB51394AC67"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void MultisigAccountModificationTransactionV1_multisig_account_modification_aggregate_1()
        {
            var payload = "28010000000000005DCE50608AF36771B8DBD26FF07CE6284500C24606DAD95ECBAEEB51220896AFC59BE14C353FC1037F6089FB70480752D6402A68278E9457C6D66D85719A4E923AFC562C7601C865F7F473063BDA62E72D9EA4802B111F302D016A699DFB4B080000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77123CC3A9D303266D2E163A8B8AA1A991F3EC9012B7F7490C6870BB5F6ED9E4D8D800000000000000080000000000000000000000000000000000000000000000000000000000000000000000000000000000000000198554101020201000000009841E5B8E40781CF74DABF592817DE48711D778648DEAFB298F409274B52FABBFBCF7E7DF7E20DE1D0C3F657FB8595C1989059321905F681BCF47EA33BBF5E6F8298B5440854FDED";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.MULTISIG_ACCOUNT_MODIFICATION},
                        {"MinRemovalDelta", 1},
                        {"MinApprovalDelta", 2},
                        {"AddressAdditions",    new UnresolvedAddress[]{
                            new (Converter.StringToAddress("TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ")),new (Converter.StringToAddress("TD2ASJ2LKL5LX66PPZ67PYQN4HIMH5SX7OCZLQI")),}
                        },
                        {"AddressDeletions",    new UnresolvedAddress[]{
                            new (Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I")),}
                        },
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("3AFC562C7601C865F7F473063BDA62E72D9EA4802B111F302D016A699DFB4B08"))},
            {"Signature", new Signature(Converter.HexToBytes("5DCE50608AF36771B8DBD26FF07CE6284500C24606DAD95ECBAEEB51220896AFC59BE14C353FC1037F6089FB70480752D6402A68278E9457C6D66D85719A4E92"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("23CC3A9D303266D2E163A8B8AA1A991F3EC9012B7F7490C6870BB5F6ED9E4D8D"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceMetadataTransactionV1_namespace_metadata_single_1()
        {
            var payload = "B200000000000000067D7153D66ED03E696208DAFB698C1EC0ECD92DA3AFEC180E082FA84133F1E5B9B0F0ACD14CEBE867DBA15DD37CB9CC413AAB3EF73E9929977337E6A8F2AB442D64F92F75B37994557B14A982218F4A8B7D6B9CFFBBADFB259BAEC0F9434F0F0000000001984443E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0A00000000000000E8030000000000000A000600414243313233";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.NAMESPACE_METADATA},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))},
            {"ScopedMetadataKey", 10},
            {"TargetNamespaceId", 1000},
            {"ValueSizeDelta", 10},
            {"Value", Converter.Utf8ToBytes("ABC123")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("2D64F92F75B37994557B14A982218F4A8B7D6B9CFFBBADFB259BAEC0F9434F0F"))},
            {"Signature", new Signature(Converter.HexToBytes("067D7153D66ED03E696208DAFB698C1EC0ECD92DA3AFEC180E082FA84133F1E5B9B0F0ACD14CEBE867DBA15DD37CB9CC413AAB3EF73E9929977337E6A8F2AB44"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceMetadataTransactionV1_namespace_metadata_single_2()
        {
            var payload = "B200000000000000FD0DDFDC372E15AE261A4AF8C61EFE37FAE5E4D6D8B6E53AA83ED616BD002C1700D2B594C841472C3DC24E4B74DE5E01968A943F8AE7BC34B9C59C9918DA2A4672D6ECEC68081903BB300BC0C033139CDB18D41EA98F9922CF20A5E1FB6B02D60000000001984443E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0A00000000000000E803000000000000FDFF0600414243313233";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.NAMESPACE_METADATA},
            {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))},
            {"ScopedMetadataKey", 10},
            {"TargetNamespaceId", 1000},
            {"ValueSizeDelta", -3},
            {"Value", Converter.Utf8ToBytes("ABC123")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("72D6ECEC68081903BB300BC0C033139CDB18D41EA98F9922CF20A5E1FB6B02D6"))},
            {"Signature", new Signature(Converter.HexToBytes("FD0DDFDC372E15AE261A4AF8C61EFE37FAE5E4D6D8B6E53AA83ED616BD002C1700D2B594C841472C3DC24E4B74DE5E01968A943F8AE7BC34B9C59C9918DA2A46"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceMetadataTransactionV1_namespace_metadata_aggregate_1()
        {
            var payload = "1001000000000000E4BA86E9FD077A8D66EC1B283EE9D771DB7BEA4B169F77A2B24D3D83362F48A028FF8762FE47B1B21B1D8F2515F97485CB25B251F8DE540BBCF5E7B5485F7B57DB14CF9C0521579EB44C4FCFC30BFB92CCEC6BFD25FE506E0A8BB8144B8D73B60000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771A716D958F0076204E3F1DDD9CCFB4087C8B934826E977A978914CF3D619494EE6800000000000000620000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984443989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0A00000000000000E8030000000000000A000600414243313233000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.NAMESPACE_METADATA},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))},
                        {"ScopedMetadataKey", 10},
                        {"TargetNamespaceId", 1000},
                        {"ValueSizeDelta", 10},
                        {"Value", Converter.Utf8ToBytes("ABC123")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("DB14CF9C0521579EB44C4FCFC30BFB92CCEC6BFD25FE506E0A8BB8144B8D73B6"))},
            {"Signature", new Signature(Converter.HexToBytes("E4BA86E9FD077A8D66EC1B283EE9D771DB7BEA4B169F77A2B24D3D83362F48A028FF8762FE47B1B21B1D8F2515F97485CB25B251F8DE540BBCF5E7B5485F7B57"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("A716D958F0076204E3F1DDD9CCFB4087C8B934826E977A978914CF3D619494EE"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceMetadataTransactionV1_namespace_metadata_aggregate_2()
        {
            var payload = "1001000000000000E241E4975832859BFC491EA4F2DABB1F29C984C0035D403C151CEBDB5DFB6F6FCDAFE7F79921213DBB0733C593CDF711E61CACE4A83877C1AFB2D0C2CF6A4E3CF786C045005CD01DE3ABC781B29FE97E0DC7C863AEF29BB5BB16D9D309678E8B0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771A92D6804B56AF5C4439906441DEE2EC265756E9D95914230483A4D1BF6283C1D6800000000000000620000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984443989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0A00000000000000E803000000000000FDFF0600414243313233000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.NAMESPACE_METADATA},
                        {"TargetAddress", new UnresolvedAddress(Converter.StringToAddress("TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"))},
                        {"ScopedMetadataKey", 10},
                        {"TargetNamespaceId", 1000},
                        {"ValueSizeDelta", -3},
                        {"Value", Converter.Utf8ToBytes("ABC123")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("F786C045005CD01DE3ABC781B29FE97E0DC7C863AEF29BB5BB16D9D309678E8B"))},
            {"Signature", new Signature(Converter.HexToBytes("E241E4975832859BFC491EA4F2DABB1F29C984C0035D403C151CEBDB5DFB6F6FCDAFE7F79921213DBB0733C593CDF711E61CACE4A83877C1AFB2D0C2CF6A4E3C"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("A92D6804B56AF5C4439906441DEE2EC265756E9D95914230483A4D1BF6283C1D"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceRegistrationTransactionV1_namespace_registration_single_1()
        {
            var payload = "9E000000000000006F81F080720F6F641386F1320BCD4B641345CA1D3FF4D7DE302B0EA28D0E8869F3FCC0BACD72C3FF897CB620ED6B713B07F68B6312428A3C6C09B88FCAD0789A15A62A582DA8A52B13BB59EBE39FF2E4155FA2C822CBB0268BDDE5FA00F4F8FF0000000001984E41E0FEEEEFFEEEEFFEE0711EE7711EE77110270000000000007EE9B3B8AFDF53C0000C6E65776E616D657370616365";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.NAMESPACE_REGISTRATION},
            {"Duration", 10000},
            {"Id", 13858666424160217470},
            {"RegistrationType", NamespaceRegistrationType.ROOT},
            {"Name", Converter.Utf8ToBytes("newnamespace")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("15A62A582DA8A52B13BB59EBE39FF2E4155FA2C822CBB0268BDDE5FA00F4F8FF"))},
            {"Signature", new Signature(Converter.HexToBytes("6F81F080720F6F641386F1320BCD4B641345CA1D3FF4D7DE302B0EA28D0E8869F3FCC0BACD72C3FF897CB620ED6B713B07F68B6312428A3C6C09B88FCAD0789A"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceRegistrationTransactionV1_namespace_registration_single_2()
        {
            var payload = "9E0000000000000059C951AD8691705F1EB49D80B78B850B4114F38E0FCC64DAC404E9AA44DCBAA8A3DCFE82DF1275E278F8B8C98D3B83FB6328F257937AD4490B944C4AE27904B300C8921E7F8A214345AC3A2E15FA9651622A4FA7E609FC6BDE2E79063DCBD3360000000001984E41E0FEEEEFFEEEEFFEE0711EE7711EE7717EE9B3B8AFDF53400312981B7879A3F1010C7375626E616D657370616365";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.NAMESPACE_REGISTRATION},
            {"ParentId", 4635294387305441662},
            {"Id", 17411894141110456835},
            {"RegistrationType", NamespaceRegistrationType.CHILD},
            {"Name", Converter.Utf8ToBytes("subnamespace")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("00C8921E7F8A214345AC3A2E15FA9651622A4FA7E609FC6BDE2E79063DCBD336"))},
            {"Signature", new Signature(Converter.HexToBytes("59C951AD8691705F1EB49D80B78B850B4114F38E0FCC64DAC404E9AA44DCBAA8A3DCFE82DF1275E278F8B8C98D3B83FB6328F257937AD4490B944C4AE27904B3"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceRegistrationTransactionV1_namespace_registration_aggregate_1()
        {
            var payload = "F8000000000000004C08B813E15C24982EE1D908942CBC07F7EE373EB78F99935D657CAB1CE6397156FF07C97D334F8E2E71B57E293E98B0523633FF36C052E3AB0B5E3FF4924310C3327284E6AC67B1A558F95797CF2EFC994BCECA4EBBCCB4592CB6B8F645DC2D0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77164148373332A1284E316AC070194019D786C29F3B879A0AAFACEC2E393D0FCB550000000000000004E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984E4110270000000000007EE9B3B8AFDF53C0000C6E65776E616D6573706163650000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.NAMESPACE_REGISTRATION},
                        {"Duration", 10000},
                        {"Id", 13858666424160217470},
                        {"RegistrationType", NamespaceRegistrationType.ROOT},
                        {"Name", Converter.Utf8ToBytes("newnamespace")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("C3327284E6AC67B1A558F95797CF2EFC994BCECA4EBBCCB4592CB6B8F645DC2D"))},
            {"Signature", new Signature(Converter.HexToBytes("4C08B813E15C24982EE1D908942CBC07F7EE373EB78F99935D657CAB1CE6397156FF07C97D334F8E2E71B57E293E98B0523633FF36C052E3AB0B5E3FF4924310"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("64148373332A1284E316AC070194019D786C29F3B879A0AAFACEC2E393D0FCB5"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NamespaceRegistrationTransactionV1_namespace_registration_aggregate_2()
        {
            var payload = "F800000000000000BC0F54C2F8ECC9AF9964BA7BBD76797981A7030F037228B256F220C04E0CA1A9C2C45C9E4A8914143E1AAD5E1DFDB2A4503BC1D0095EB21FC2CD8B0DF21D31A22491954E840A79E330BD295F8FF0A15863384734583B9AB6E83815AF9438C0860000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7719777CD6B81EED8832122E7D4692D5AC09D6144D30E3A8D1DF559FDB21C1B4FAC50000000000000004E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984E417EE9B3B8AFDF53400312981B7879A3F1010C7375626E616D6573706163650000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.NAMESPACE_REGISTRATION},
                        {"ParentId", 4635294387305441662},
                        {"Id", 17411894141110456835},
                        {"RegistrationType", NamespaceRegistrationType.CHILD},
                        {"Name", Converter.Utf8ToBytes("subnamespace")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("2491954E840A79E330BD295F8FF0A15863384734583B9AB6E83815AF9438C086"))},
            {"Signature", new Signature(Converter.HexToBytes("BC0F54C2F8ECC9AF9964BA7BBD76797981A7030F037228B256F220C04E0CA1A9C2C45C9E4A8914143E1AAD5E1DFDB2A4503BC1D0095EB21FC2CD8B0DF21D31A2"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("9777CD6B81EED8832122E7D4692D5AC09D6144D30E3A8D1DF559FDB21C1B4FAC"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NodeKeyLinkTransactionV1_node_key_link_single_1()
        {
            var payload = "A1000000000000003CCE9BCD544BFF665A3400F7337A5115307ABB490AD821B6EE8F2906805B4B4C7D525EC20B52B9F6D7FEAA0CC6C20E6A613F2395916AC07F4ACC34FAD57F177D63F4B6B964EE70A2980C5BB57DB2C184F8DDBF9B0BD9E72F89EA55AC9C5BA6BF0000000001984C42E0FEEEEFFEEEEFFEE0711EE7711EE7719801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B601";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.NODE_KEY_LINK},
            {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
            {"LinkAction", LinkAction.LINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("63F4B6B964EE70A2980C5BB57DB2C184F8DDBF9B0BD9E72F89EA55AC9C5BA6BF"))},
            {"Signature", new Signature(Converter.HexToBytes("3CCE9BCD544BFF665A3400F7337A5115307ABB490AD821B6EE8F2906805B4B4C7D525EC20B52B9F6D7FEAA0CC6C20E6A613F2395916AC07F4ACC34FAD57F177D"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void NodeKeyLinkTransactionV1_node_key_link_aggregate_1()
        {
            var payload = "00010000000000004A84BB8D0EFC259B98887D4E14C146041D4C9C8ED06F56E224893AA19969A8DB3515ED03430BCA5F47A17F386C184741596EBCFA7110D9CF569B8FFC8300693FF13328C38A0C8B9DE194EAB1609872BAA51FF677395513A528A707795E3C2F590000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771D1E0E4543AD54FB41747EAA74009AE05DB685DD0FB2B8CB6385327DCC71ED8B25800000000000000510000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984C429801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B60100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.NODE_KEY_LINK},
                        {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
                        {"LinkAction", LinkAction.LINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("F13328C38A0C8B9DE194EAB1609872BAA51FF677395513A528A707795E3C2F59"))},
            {"Signature", new Signature(Converter.HexToBytes("4A84BB8D0EFC259B98887D4E14C146041D4C9C8ED06F56E224893AA19969A8DB3515ED03430BCA5F47A17F386C184741596EBCFA7110D9CF569B8FFC8300693F"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("D1E0E4543AD54FB41747EAA74009AE05DB685DD0FB2B8CB6385327DCC71ED8B2"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void SecretLockTransactionV1_secret_lock_single_1()
        {
            var payload = "D1000000000000005E9808E11624AAABD2826CF7F464B93F309B8F15506BE6FC7E8C1E5E09E23B4D13A37C5982225413DDD6CA5913F4F4673662732059AD381DF191A01C72CB6D5D21EDDC0F3547F2FE431C1B2BAA531E7C299CD1CBE3F410112C74F43DDAD2A5780000000001985241E0FEEEEFFEEEEFFEE0711EE7711EE7719841E5B8E40781CF74DABF592817DE48711D778648DEAFB23FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE44B262C46CEABB858096980000000000640000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.SECRET_LOCK},
            {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
            {"Secret", "3FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE"},
            {"Mosaic",
                new UnresolvedMosaic{
                    MosaicId = new UnresolvedMosaicId(9636553580561478212),
                    Amount = new Amount(10000000),
                }
            },
            {"Duration", 100},
            {"HashAlgorithm", LockHashAlgorithm.SHA3_256},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("21EDDC0F3547F2FE431C1B2BAA531E7C299CD1CBE3F410112C74F43DDAD2A578"))},
            {"Signature", new Signature(Converter.HexToBytes("5E9808E11624AAABD2826CF7F464B93F309B8F15506BE6FC7E8C1E5E09E23B4D13A37C5982225413DDD6CA5913F4F4673662732059AD381DF191A01C72CB6D5D"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void SecretLockTransactionV1_secret_lock_single_2()
        {
            var payload = "D1000000000000001F97199EAA5A7B3D956DE51DB9E93490A72123ECDC7C2931ED4B3EA9D02FD9443F9F5028B92D5CF5A32DD1F9802D0D5B703BE5FFFDB3480D0915C8BE7ABE62FDED5139E46E6BECCD9E762EBFCA2A534DE476087621E2EA3A0BD9E42743A2B4AF0000000001985241E0FEEEEFFEEEEFFEE0711EE7711EE7719841E5B8E40781CF74DABF592817DE48711D778648DEAFB259CC35F8C8D91867717CE4290B40EA636E86CE5C00000000000000000000000044B262C46CEABB85EFCDAB9078563412640000000000000001";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.SECRET_LOCK},
            {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
            {"Mosaic",
                new UnresolvedMosaic{
                    MosaicId = new UnresolvedMosaicId(9636553580561478212),
                    Amount = new Amount(1311768467294899695),
                }
            },
            {"Duration", 100},
            {"Secret", "59CC35F8C8D91867717CE4290B40EA636E86CE5C000000000000000000000000"},
            {"HashAlgorithm", LockHashAlgorithm.HASH_160},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("ED5139E46E6BECCD9E762EBFCA2A534DE476087621E2EA3A0BD9E42743A2B4AF"))},
            {"Signature", new Signature(Converter.HexToBytes("1F97199EAA5A7B3D956DE51DB9E93490A72123ECDC7C2931ED4B3EA9D02FD9443F9F5028B92D5CF5A32DD1F9802D0D5B703BE5FFFDB3480D0915C8BE7ABE62FD"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void SecretLockTransactionV1_secret_lock_aggregate_1()
        {
            var payload = "3001000000000000D2CECD95BAA2B1F170D2EA70E7EC4A32C6DF0813CCE37C900262BDF1A13E16EE9F54F1A9F31E80DC488D43EDBE3072103AA74B7E064EAEDEF5BAB348B45541E18B23AE138D05DFC8CCEC32BA748D55766D1053859E2F403EAA30D692C3CB822F0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77136927A7B0987EB9A13129BA53AC0597E96F9D8F2C8306EA3F750518ACD15529A88000000000000008100000000000000000000000000000000000000000000000000000000000000000000000000000000000000019852419841E5B8E40781CF74DABF592817DE48711D778648DEAFB23FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE44B262C46CEABB85809698000000000064000000000000000000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.SECRET_LOCK},
                        {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
                        {"Secret", "3FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE"},
                        {"Mosaic",
                            new UnresolvedMosaic{
                                MosaicId = new UnresolvedMosaicId(9636553580561478212),
                                Amount = new Amount(10000000),
                            }
                        },
                        {"Duration", 100},
                        {"HashAlgorithm", LockHashAlgorithm.SHA3_256},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("8B23AE138D05DFC8CCEC32BA748D55766D1053859E2F403EAA30D692C3CB822F"))},
            {"Signature", new Signature(Converter.HexToBytes("D2CECD95BAA2B1F170D2EA70E7EC4A32C6DF0813CCE37C900262BDF1A13E16EE9F54F1A9F31E80DC488D43EDBE3072103AA74B7E064EAEDEF5BAB348B45541E1"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("36927A7B0987EB9A13129BA53AC0597E96F9D8F2C8306EA3F750518ACD15529A"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void SecretLockTransactionV1_secret_lock_aggregate_2()
        {
            var payload = "30010000000000003F55F0B895EDBC04AA511CB828326E32FBCD57D5A2688BF1F9FC3A2C604F7BF8B55929FB0B18624A58641CF010A628DC7D64FDFEA1EEC5315950E2559BD5458BEC851E578B1AEF681A6FBE5CD8682D12517F69142EF25B27F9CE75F0087E1F010000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77181F7349CC9785016A1435572751389F02926573244D7F97E14F811D60627750A88000000000000008100000000000000000000000000000000000000000000000000000000000000000000000000000000000000019852419841E5B8E40781CF74DABF592817DE48711D778648DEAFB259CC35F8C8D91867717CE4290B40EA636E86CE5C00000000000000000000000044B262C46CEABB85EFCDAB907856341264000000000000000100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.SECRET_LOCK},
                        {"RecipientAddress", "TBA6LOHEA6A465G2X5MSQF66JBYR254GJDPK7MQ"},
                        {"Mosaic",
                            new UnresolvedMosaic{
                                MosaicId = new UnresolvedMosaicId(9636553580561478212),
                                Amount = new Amount(1311768467294899695),
                            }
                        },
                        {"Duration", 100},
                        {"Secret", "59CC35F8C8D91867717CE4290B40EA636E86CE5C000000000000000000000000"},
                        {"HashAlgorithm", LockHashAlgorithm.HASH_160},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("EC851E578B1AEF681A6FBE5CD8682D12517F69142EF25B27F9CE75F0087E1F01"))},
            {"Signature", new Signature(Converter.HexToBytes("3F55F0B895EDBC04AA511CB828326E32FBCD57D5A2688BF1F9FC3A2C604F7BF8B55929FB0B18624A58641CF010A628DC7D64FDFEA1EEC5315950E2559BD5458B"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("81F7349CC9785016A1435572751389F02926573244D7F97E14F811D60627750A"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void SecretProofTransactionV1_secret_proof_single_1()
        {
            var payload = "BF00000000000000AF3DC7E901D3DBA59F26DB495339E55466C70DDAFD4993CFA437CC260C5829774A3A8891758C20D1E4432D53C9B23FD500972FB212325CC0160300BEE521B444CC619039AF06C01EE2082F40F9D0F4626B8EDB093303FAAC9B15AE5D9797FAE50000000001985242E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED3FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE0400009A493664";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.SECRET_PROOF},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Secret", "3FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE"},
            {"HashAlgorithm", LockHashAlgorithm.SHA3_256},
            {"Proof", "9A493664"},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("CC619039AF06C01EE2082F40F9D0F4626B8EDB093303FAAC9B15AE5D9797FAE5"))},
            {"Signature", new Signature(Converter.HexToBytes("AF3DC7E901D3DBA59F26DB495339E55466C70DDAFD4993CFA437CC260C5829774A3A8891758C20D1E4432D53C9B23FD500972FB212325CC0160300BEE521B444"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void SecretProofTransactionV1_secret_proof_aggregate_1()
        {
            var payload = "1801000000000000C7A226BE39161700A4EAAA38663DE7FD9A3ECDDB6D8AE5BE745FA97CAB9A994CD3B6AD7199C586EE62FB3A1860888B5306F34D6AA31D856B8DDBFBAA51E9A9240F6E0AF656247EBE417B0BF2A910BCB879429D9167B274833DA2BCC7526097F00000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7712082780E43D0C6AB646FF178295F5B7CE48B9DE845A3DA98EF595433BDA184E970000000000000006F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985242989059321905F681BCF47EA33BBF5E6F8298B5440854FDED3FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE0400009A49366400";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.SECRET_PROOF},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Secret", "3FC8BA10229AB5778D05D9C4B7F56676A88BF9295C185ACFC0F961DB5408CAFE"},
                        {"HashAlgorithm", LockHashAlgorithm.SHA3_256},
                        {"Proof", "9A493664"},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("0F6E0AF656247EBE417B0BF2A910BCB879429D9167B274833DA2BCC7526097F0"))},
            {"Signature", new Signature(Converter.HexToBytes("C7A226BE39161700A4EAAA38663DE7FD9A3ECDDB6D8AE5BE745FA97CAB9A994CD3B6AD7199C586EE62FB3A1860888B5306F34D6AA31D856B8DDBFBAA51E9A924"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("2082780E43D0C6AB646FF178295F5B7CE48B9DE845A3DA98EF595433BDA184E9"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_1()
        {
            var payload = "B0000000000000002396B87D65DDDCF52F527CC4C8E2C413C52DA4E2D2D951E5EB1370941D86068688099761AD473A3D124650B823C39078B9326EC8CD050FE2EB6ABC9FE61C0212A75027E4F32570A79B8A5A8641AB91ED48360074AE2AAE055CE3BD48D3BE22330000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0000010000000000672B0000CE5600006400000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                        new (){
                            MosaicId = new UnresolvedMosaicId(95442763262823),
                            Amount = new Amount(100)
                    },
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("A75027E4F32570A79B8A5A8641AB91ED48360074AE2AAE055CE3BD48D3BE2233"))},
            {"Signature", new Signature(Converter.HexToBytes("2396B87D65DDDCF52F527CC4C8E2C413C52DA4E2D2D951E5EB1370941D86068688099761AD473A3D124650B823C39078B9326EC8CD050FE2EB6ABC9FE61C0212"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_2()
        {
            var payload = "C00000000000000042D030CD0166DA62C1DF1FF0945752475FBD2B4B975E9991EFF57BCD742C235787433B8AF428C3852009C8C63B632572057945118F393F4187FF51DFD77CAC6DB0A48186B2D8C168DBAF2395AD3BF421F9E44D7AD8E616C5E981ABD1DB5190F20000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED000002000000000064000000000000000200000000000000C8000000000000000100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                        new (){
                            MosaicId = new UnresolvedMosaicId(100),
                            Amount = new Amount(2)
                    },
                        new (){
                            MosaicId = new UnresolvedMosaicId(200),
                            Amount = new Amount(1)
                    },
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("B0A48186B2D8C168DBAF2395AD3BF421F9E44D7AD8E616C5E981ABD1DB5190F2"))},
            {"Signature", new Signature(Converter.HexToBytes("42D030CD0166DA62C1DF1FF0945752475FBD2B4B975E9991EFF57BCD742C235787433B8AF428C3852009C8C63B632572057945118F393F4187FF51DFD77CAC6D"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_3()
        {
            var payload = "D000000000000000C1DD9E45551CF35D8F058C73A8E3813B107A5D6EC6393F60B8B2F294E1C831FF96F30CB71D18EBEE2C96146D97DF1CFA252B8B3988697015150D7CDFEF8844635A76A15971385920F91E666BD0698687C0A5C50D6FCEE82E9F1FDC4D8BC7F5180000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0000030000000000BA36BD286FB7F2670300000000000000D787D9329996A177020000000000000029CF5FD941AD25D50100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                        new (){
                            MosaicId = new UnresolvedMosaicId(7490250818323297978),
                            Amount = new Amount(3)
                    },
                        new (){
                            MosaicId = new UnresolvedMosaicId(8620336746491119575),
                            Amount = new Amount(2)
                    },
                        new (){
                            MosaicId = new UnresolvedMosaicId(15358872602548358953),
                            Amount = new Amount(1)
                    },
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("5A76A15971385920F91E666BD0698687C0A5C50D6FCEE82E9F1FDC4D8BC7F518"))},
            {"Signature", new Signature(Converter.HexToBytes("C1DD9E45551CF35D8F058C73A8E3813B107A5D6EC6393F60B8B2F294E1C831FF96F30CB71D18EBEE2C96146D97DF1CFA252B8B3988697015150D7CDFEF884463"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_4()
        {
            var payload = "B0000000000000005A5763BD9CE487F745C0A5F4D2D2F4167778878C9C119B03C549F915ED471B6AD05F51A76C4CE9CC7BCF58958A6DC64B3C43584D1651B64FBBFCD42FCAD1DEBF2558851FBDECC3CFAD26DE0050EAA6661B81F2CCE59F3A6672766CD8EC8EE3AA0000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED1000000000000000D600000300504C5445000000FBAF93F7";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                }
            },
            {"Message", "D600000300504C5445000000FBAF93F7"},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("2558851FBDECC3CFAD26DE0050EAA6661B81F2CCE59F3A6672766CD8EC8EE3AA"))},
            {"Signature", new Signature(Converter.HexToBytes("5A5763BD9CE487F745C0A5F4D2D2F4167778878C9C119B03C549F915ED471B6AD05F51A76C4CE9CC7BCF58958A6DC64B3C43584D1651B64FBBFCD42FCAD1DEBF"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_5()
        {
            var payload = "CE000000000000003CA4BBA1CFF24DEA27FD659AA48334DB71FF2E377F641E52773959C58B8A3F77E1255762A39097716FCA94CD55FFED106B8B4EFE69701484E05A184A4FEFFD0311EB0CF6770160DFED4C943B9B691930D3F138141FF4D02B7CB8B383A3AE2BDA0000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE7719188DD7D72227ECAE70000000000000000000000000000001E0001000000000044B262C46CEABB8501000000000000004974277320736F6D65206B696E64206F66206D616769632C206D61676963";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "SGEN27LSEJ7MVZYAAAAAAAAAAAAAAAAAAAAAAAA"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                        new (){
                            MosaicId = new UnresolvedMosaicId(9636553580561478212),
                            Amount = new Amount(1)
                    },
                }
            },
            {"Message", Converter.Utf8ToBytes("It's some kind of magic, magic")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("11EB0CF6770160DFED4C943B9B691930D3F138141FF4D02B7CB8B383A3AE2BDA"))},
            {"Signature", new Signature(Converter.HexToBytes("3CA4BBA1CFF24DEA27FD659AA48334DB71FF2E377F641E52773959C58B8A3F77E1255762A39097716FCA94CD55FFED106B8B4EFE69701484E05A184A4FEFFD03"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_6()
        {
            var payload = "CA0000000000000070E5416292032C453B628E6D8D8EFE8EF81C19AA054AD1C270B17E98B0993352B9A2627F5C944E49F01D479F3BB1B263D4516E6C63117DFA35EBBA9D30432EDE0E24F92F57FF40F89B2F28B0A89B1F1A55408A653C1864502F29744237EFA2B60000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0A00020000000000671305C6390B00002C01000000000000672B0000CE560000640000000000000048656C6C6F20F09F918B";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                        new (){
                            MosaicId = new UnresolvedMosaicId(12342763262823),
                            Amount = new Amount(300)
                    },
                        new (){
                            MosaicId = new UnresolvedMosaicId(95442763262823),
                            Amount = new Amount(100)
                    },
                }
            },
            {"Message", Converter.Utf8ToBytes("Hello 👋")},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("0E24F92F57FF40F89B2F28B0A89B1F1A55408A653C1864502F29744237EFA2B6"))},
            {"Signature", new Signature(Converter.HexToBytes("70E5416292032C453B628E6D8D8EFE8EF81C19AA054AD1C270B17E98B0993352B9A2627F5C944E49F01D479F3BB1B263D4516E6C63117DFA35EBBA9D30432EDE"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_single_7()
        {
            var payload = "D000000000000000D62C87F5719E3D2AAACB0ADA00678E0FBD040AB7B3D05C30DE7DC613834C45F3C491D61574DF3E368A27895FD494C0F0D83C6D32FA5916E6A7EE1466F4E6E4C6E66203800A937D2CDF45D3C62C30DEE4A0FEA810B958DD870EBB05CC97BCC3820000000001985441E0FEEEEFFEEEEFFEE0711EE7711EE771989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0000030000000000BA36BD286FB7F2670300000000000000D787D9329996A177020000000000000029CF5FD941AD25D50100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.TRANSFER},
            {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
            {"Mosaics",
                new UnresolvedMosaic[]{
                        new (){
                            MosaicId = new UnresolvedMosaicId(8620336746491119575),
                            Amount = new Amount(2)
                    },
                        new (){
                            MosaicId = new UnresolvedMosaicId(15358872602548358953),
                            Amount = new Amount(1)
                    },
                        new (){
                            MosaicId = new UnresolvedMosaicId(7490250818323297978),
                            Amount = new Amount(3)
                    },
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("E66203800A937D2CDF45D3C62C30DEE4A0FEA810B958DD870EBB05CC97BCC382"))},
            {"Signature", new Signature(Converter.HexToBytes("D62C87F5719E3D2AAACB0ADA00678E0FBD040AB7B3D05C30DE7DC613834C45F3C491D61574DF3E368A27895FD494C0F0D83C6D32FA5916E6A7EE1466F4E6E4C6"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_1()
        {
            var payload = "08010000000000001DD497AAE2AF93C3E7402AA3623F0578A14646FDA848EF82EB8D14033AB515CECC22B0AD6B9A3C6277B0DC3451C93A534301FFEDF49958E9AC36BE8B684F92A58881DFC77FE896CB10A98B2CD52660C243C81185BAE7C54187E5BCF84CE849E80000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771708124B1E5E63878225B38A343BDB300A1A06150343BA85DFC608331265D0DA56000000000000000600000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0000010000000000672B0000CE5600006400000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(95442763262823),
                                        Amount = new Amount(100)
                                },
                            }
                        },
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("8881DFC77FE896CB10A98B2CD52660C243C81185BAE7C54187E5BCF84CE849E8"))},
            {"Signature", new Signature(Converter.HexToBytes("1DD497AAE2AF93C3E7402AA3623F0578A14646FDA848EF82EB8D14033AB515CECC22B0AD6B9A3C6277B0DC3451C93A534301FFEDF49958E9AC36BE8B684F92A5"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("708124B1E5E63878225B38A343BDB300A1A06150343BA85DFC608331265D0DA5"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_2()
        {
            var payload = "1801000000000000C3CB1685625F7B50CB6CE902EB01C6B87EA219EAA24C4B8C99470228725ACAA913838F8C526ABD8E73C3D07FAE029C7F2952DA60D2C45CAF2CEC06FE6086DB1D20D7B516D60461DDBDBF41E29F111DAB28951B5E1E257B560889766C7F210D620000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771F34F69D90B202FC2752058059E3BC49A8CA4BE331D5F49C2C13B8F2A9A3BC3317000000000000000700000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED000002000000000064000000000000000200000000000000C8000000000000000100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(100),
                                        Amount = new Amount(2)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(200),
                                        Amount = new Amount(1)
                                },
                            }
                        },
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("20D7B516D60461DDBDBF41E29F111DAB28951B5E1E257B560889766C7F210D62"))},
            {"Signature", new Signature(Converter.HexToBytes("C3CB1685625F7B50CB6CE902EB01C6B87EA219EAA24C4B8C99470228725ACAA913838F8C526ABD8E73C3D07FAE029C7F2952DA60D2C45CAF2CEC06FE6086DB1D"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("F34F69D90B202FC2752058059E3BC49A8CA4BE331D5F49C2C13B8F2A9A3BC331"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_3()
        {
            var payload = "2801000000000000C9F0161425259D1D2984B589F7C2C6F2F0B00E1233103F204AD082152C0E1DD549993443C85FDB91C130F8A4CABDF445852E9B2B0AECEB355E57D2BC83B28D84A311444F2A64E4E1D9864C117076FA4AA1629FC011AD6103B2FB7FC614F60EDE0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771611B90A6E05EE33D30D87DE5B58505B8B9807E54BB8B9229EAF95DBBD43819BC8000000000000000800000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0000030000000000BA36BD286FB7F2670300000000000000D787D9329996A177020000000000000029CF5FD941AD25D50100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(7490250818323297978),
                                        Amount = new Amount(3)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(8620336746491119575),
                                        Amount = new Amount(2)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(15358872602548358953),
                                        Amount = new Amount(1)
                                },
                            }
                        },
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("A311444F2A64E4E1D9864C117076FA4AA1629FC011AD6103B2FB7FC614F60EDE"))},
            {"Signature", new Signature(Converter.HexToBytes("C9F0161425259D1D2984B589F7C2C6F2F0B00E1233103F204AD082152C0E1DD549993443C85FDB91C130F8A4CABDF445852E9B2B0AECEB355E57D2BC83B28D84"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("611B90A6E05EE33D30D87DE5B58505B8B9807E54BB8B9229EAF95DBBD43819BC"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_4()
        {
            var payload = "0801000000000000E9255429A2B8253E6FBC0FFBBE00222DB8B5FBB5606EE98811B763CE3EE63C81D24365B2C4392389172356B16C43F633A1D76C9F594257AA017C3EEA028F2D2C7C4A1D083B98CCA7D7A7F467B1ECCE4CD8ED1B3D4615724B590B07E852B4A89C0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771AB122F570B57922F4B25A37E13EC53E14BE4A6A3F38C06CE4AF510060633667D6000000000000000600000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED1000000000000000D600000300504C5445000000FBAF93F7";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                            }
                        },
                        {"Message", "D600000300504C5445000000FBAF93F7"},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("7C4A1D083B98CCA7D7A7F467B1ECCE4CD8ED1B3D4615724B590B07E852B4A89C"))},
            {"Signature", new Signature(Converter.HexToBytes("E9255429A2B8253E6FBC0FFBBE00222DB8B5FBB5606EE98811B763CE3EE63C81D24365B2C4392389172356B16C43F633A1D76C9F594257AA017C3EEA028F2D2C"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("AB122F570B57922F4B25A37E13EC53E14BE4A6A3F38C06CE4AF510060633667D"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_5()
        {
            var payload = "2801000000000000DC057B241AFA2AD72F522AB22299AF9B76AC3C20C8C29278CC1CD15F2F0CD4FA54A7500F66904858C3ABC7C258EA8130F67140C9F6C85EA73502FCDD409F68306AA821C54CAC407F32028BABE0D2B29DC3EE7F89078B2EC40705C7EAA123C4E70000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7719ACF4807E95D6989038C5FCFEA053C55077439DFB93C06C98237C73815CABE8780000000000000007E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000019854419188DD7D72227ECAE70000000000000000000000000000001E0001000000000044B262C46CEABB8501000000000000004974277320736F6D65206B696E64206F66206D616769632C206D616769630000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "SGEN27LSEJ7MVZYAAAAAAAAAAAAAAAAAAAAAAAA"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(9636553580561478212),
                                        Amount = new Amount(1)
                                },
                            }
                        },
                        {"Message", Converter.Utf8ToBytes("It's some kind of magic, magic")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("6AA821C54CAC407F32028BABE0D2B29DC3EE7F89078B2EC40705C7EAA123C4E7"))},
            {"Signature", new Signature(Converter.HexToBytes("DC057B241AFA2AD72F522AB22299AF9B76AC3C20C8C29278CC1CD15F2F0CD4FA54A7500F66904858C3ABC7C258EA8130F67140C9F6C85EA73502FCDD409F6830"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("9ACF4807E95D6989038C5FCFEA053C55077439DFB93C06C98237C73815CABE87"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_6()
        {
            var payload = "2801000000000000287E9D267A8560FC82BCABEB6E161DB461AA585344739B738CA4474F450B3B8A6DA715AC41AF6BEDE4D8F0C3C7C0104F9E8C7FC91AD441E09ACDE33A15DC8A5C3A347999434B7D11999E74880393A38AA0EAD0D5290B16B665E9408F7DC7CABA0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771754207E883B1237A94D2892613D382C17B0F0A2EC93042871724F6AE0D991ABA80000000000000007A0000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0A00020000000000671305C6390B00002C01000000000000672B0000CE560000640000000000000048656C6C6F20F09F918B000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(12342763262823),
                                        Amount = new Amount(300)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(95442763262823),
                                        Amount = new Amount(100)
                                },
                            }
                        },
                        {"Message", Converter.Utf8ToBytes("Hello 👋")},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("3A347999434B7D11999E74880393A38AA0EAD0D5290B16B665E9408F7DC7CABA"))},
            {"Signature", new Signature(Converter.HexToBytes("287E9D267A8560FC82BCABEB6E161DB461AA585344739B738CA4474F450B3B8A6DA715AC41AF6BEDE4D8F0C3C7C0104F9E8C7FC91AD441E09ACDE33A15DC8A5C"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("754207E883B1237A94D2892613D382C17B0F0A2EC93042871724F6AE0D991ABA"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void TransferTransactionV1_transfer_aggregate_7()
        {
            var payload = "2801000000000000A0893317E373F4009C20654644B74253746799124BA671531C1DBBE26DFED167860641CEA467B53139EBDBB4313BD929C0A3838363D10CD71CD882B42DA5EC929FC9DA6EB5B2E47C0AB55B8B7DEBEC331DFDD4C4A7E748ED35A59D69E29B639B0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771611B90A6E05EE33D30D87DE5B58505B8B9807E54BB8B9229EAF95DBBD43819BC8000000000000000800000000000000000000000000000000000000000000000000000000000000000000000000000000000000001985441989059321905F681BCF47EA33BBF5E6F8298B5440854FDED0000030000000000BA36BD286FB7F2670300000000000000D787D9329996A177020000000000000029CF5FD941AD25D50100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.TRANSFER},
                        {"RecipientAddress", "TCIFSMQZAX3IDPHUP2RTXP26N6BJRNKEBBKP33I"},
                        {"Mosaics",
                            new UnresolvedMosaic[]{
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(8620336746491119575),
                                        Amount = new Amount(2)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(15358872602548358953),
                                        Amount = new Amount(1)
                                },
                                    new (){
                                        MosaicId = new UnresolvedMosaicId(7490250818323297978),
                                        Amount = new Amount(3)
                                },
                            }
                        },
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("9FC9DA6EB5B2E47C0AB55B8B7DEBEC331DFDD4C4A7E748ED35A59D69E29B639B"))},
            {"Signature", new Signature(Converter.HexToBytes("A0893317E373F4009C20654644B74253746799124BA671531C1DBBE26DFED167860641CEA467B53139EBDBB4313BD929C0A3838363D10CD71CD882B42DA5EC92"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("611B90A6E05EE33D30D87DE5B58505B8B9807E54BB8B9229EAF95DBBD43819BC"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VotingKeyLinkTransactionV1_voting_key_link_single_1()
        {
            var payload = "A9000000000000002E2DA14AA2ED5E08B2BC7636A3F45E84B84C6968B70BB4064E4C8BE04971FBE4A87B64561B4F378D08FB60F24F2DF28932913364D7CFDF09BDDE75C635EB16B17163EBCDA4CACDCAE3A1145D22FA73E0AA8AFFB46F5E14D9205DCF98951FFA480000000001984341E0FEEEEFFEEEEFFEE0711EE7711EE771C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA75010000000300000001";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.VOTING_KEY_LINK},
            {"LinkedPublicKey", new VotingPublicKey(Converter.HexToBytes("C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA75"))},
            {"StartEpoch", 1},
            {"EndEpoch", 3},
            {"LinkAction", LinkAction.LINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("7163EBCDA4CACDCAE3A1145D22FA73E0AA8AFFB46F5E14D9205DCF98951FFA48"))},
            {"Signature", new Signature(Converter.HexToBytes("2E2DA14AA2ED5E08B2BC7636A3F45E84B84C6968B70BB4064E4C8BE04971FBE4A87B64561B4F378D08FB60F24F2DF28932913364D7CFDF09BDDE75C635EB16B1"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VotingKeyLinkTransactionV1_voting_key_link_single_2()
        {
            var payload = "A9000000000000004B8726EC5C6F5875707C8CE094880AD4CE0882B34AE4BEFE244C33C2A8FD8A4B4A6A2BDE2B56C84471A69160B1A24B1AD328F86876F39FB4B7D1A2CDB55CA494880B6E4974E521B5B448C41BFD54F6F316D7707CCC6D07006DB993A350B83DAF0000000001984341E0FEEEEFFEEEEFFEE0711EE7711EE7719801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6CD0000001001000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.VOTING_KEY_LINK},
            {"LinkedPublicKey", new VotingPublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
            {"StartEpoch", 205},
            {"EndEpoch", 272},
            {"LinkAction", LinkAction.UNLINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("880B6E4974E521B5B448C41BFD54F6F316D7707CCC6D07006DB993A350B83DAF"))},
            {"Signature", new Signature(Converter.HexToBytes("4B8726EC5C6F5875707C8CE094880AD4CE0882B34AE4BEFE244C33C2A8FD8A4B4A6A2BDE2B56C84471A69160B1A24B1AD328F86876F39FB4B7D1A2CDB55CA494"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VotingKeyLinkTransactionV1_voting_key_link_aggregate_1()
        {
            var payload = "0801000000000000D595FEF4F50F3CC47B4D684B1DD9DB0352574D18492BE938E364073B00E4091A1E60354A10753AE92DA6B6935663137B946A82D5B15E8A01F2DD647BC3463017E31C85F00E72BB7537B1D055E2F8B1563143080AA60C3A9653FA2A94AD5958A90000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77156C4DAA441CE9528C6F0F1431E6FDD78AD33943E568964DF3AADAA9023B97F266000000000000000590000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984341C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA7501000000030000000100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.VOTING_KEY_LINK},
                        {"LinkedPublicKey", new VotingPublicKey(Converter.HexToBytes("C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA75"))},
                        {"StartEpoch", 1},
                        {"EndEpoch", 3},
                        {"LinkAction", LinkAction.LINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("E31C85F00E72BB7537B1D055E2F8B1563143080AA60C3A9653FA2A94AD5958A9"))},
            {"Signature", new Signature(Converter.HexToBytes("D595FEF4F50F3CC47B4D684B1DD9DB0352574D18492BE938E364073B00E4091A1E60354A10753AE92DA6B6935663137B946A82D5B15E8A01F2DD647BC3463017"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("56C4DAA441CE9528C6F0F1431E6FDD78AD33943E568964DF3AADAA9023B97F26"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VotingKeyLinkTransactionV1_voting_key_link_aggregate_2()
        {
            var payload = "0801000000000000CB5E0C56862D705FDB3AFBDA7399365F0259ECC36377D19FBC154D94C18E337C9183A2B911BE690AF2FAC22C1C65821749E37CF475EFE6C14DEAB991ACBAFE7C06EE91EA9B49139264D5AD874CC71D53EA5010A6033A951A163C46CB00718C8C0000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE7717BEFAC9DE1ED91FF6A7F9252CBDF9825C5DEF3D65EBC9CE6D07475854D69978C60000000000000005900000000000000000000000000000000000000000000000000000000000000000000000000000000000000019843419801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6CD000000100100000000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.VOTING_KEY_LINK},
                        {"LinkedPublicKey", new VotingPublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
                        {"StartEpoch", 205},
                        {"EndEpoch", 272},
                        {"LinkAction", LinkAction.UNLINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("06EE91EA9B49139264D5AD874CC71D53EA5010A6033A951A163C46CB00718C8C"))},
            {"Signature", new Signature(Converter.HexToBytes("CB5E0C56862D705FDB3AFBDA7399365F0259ECC36377D19FBC154D94C18E337C9183A2B911BE690AF2FAC22C1C65821749E37CF475EFE6C14DEAB991ACBAFE7C"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("7BEFAC9DE1ED91FF6A7F9252CBDF9825C5DEF3D65EBC9CE6D07475854D69978C"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VrfKeyLinkTransactionV1_vrf_key_link_single_1()
        {
            var payload = "A10000000000000038F64BB69857DF898DF5D551032AA4BBFA454B3235F5915CEBED82C85BE69E7C7D06443763551A4E68CDA17AEC2BF9A74CB5F85A6D0474E7CA7B804F55AF8EDBF338E25ED94FC0376305E1B337BF00D56F8B012A88D5E9E18DF13815A1AB1C890000000001984342E0FEEEEFFEEEEFFEE0711EE7711EE7719801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B601";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.VRF_KEY_LINK},
            {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
            {"LinkAction", LinkAction.LINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("F338E25ED94FC0376305E1B337BF00D56F8B012A88D5E9E18DF13815A1AB1C89"))},
            {"Signature", new Signature(Converter.HexToBytes("38F64BB69857DF898DF5D551032AA4BBFA454B3235F5915CEBED82C85BE69E7C7D06443763551A4E68CDA17AEC2BF9A74CB5F85A6D0474E7CA7B804F55AF8EDB"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VrfKeyLinkTransactionV1_vrf_key_link_single_2()
        {
            var payload = "A10000000000000083FC771045460B0545CA4C27C00A595D21418F34E056F299732CD759C9C0A268D0395222D79F0EEB392D3F5AC0A0FAEAFE231CC0C5F7187F99CAAF74DECC13E341F56C0A08B535092BDFF114360B5563B729B9BB82B727238D857D9FFF705B1E0000000001984342E0FEEEEFFEEEEFFEE0711EE7711EE771C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA7500";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.VRF_KEY_LINK},
            {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA75"))},
            {"LinkAction", LinkAction.UNLINK},
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("41F56C0A08B535092BDFF114360B5563B729B9BB82B727238D857D9FFF705B1E"))},
            {"Signature", new Signature(Converter.HexToBytes("83FC771045460B0545CA4C27C00A595D21418F34E056F299732CD759C9C0A268D0395222D79F0EEB392D3F5AC0A0FAEAFE231CC0C5F7187F99CAAF74DECC13E3"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VrfKeyLinkTransactionV1_vrf_key_link_aggregate_1()
        {
            var payload = "0001000000000000931F2E428A63C16A98CFC5A3EDEC34DE7014133316645C99E1A13C5EF30006D22D255C52C0529286CFD234CF69E9F8DE369F34B45A894649F7595E035977BB39633071BA1815E88BE471CE8C8B930BE7771C637A7209B6D04523BD35ABF089520000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE771DFED773D9A8101C3DEE6A0F1B8F2D2414FAA3EA509980ED2A6A68DD1F11C32B558000000000000005100000000000000000000000000000000000000000000000000000000000000000000000000000000000000019843429801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B60100000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.VRF_KEY_LINK},
                        {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("9801508C58666C746F471538E43002B85B1CD542F9874B2861183919BA8787B6"))},
                        {"LinkAction", LinkAction.LINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("633071BA1815E88BE471CE8C8B930BE7771C637A7209B6D04523BD35ABF08952"))},
            {"Signature", new Signature(Converter.HexToBytes("931F2E428A63C16A98CFC5A3EDEC34DE7014133316645C99E1A13C5EF30006D22D255C52C0529286CFD234CF69E9F8DE369F34B45A894649F7595E035977BB39"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("DFED773D9A8101C3DEE6A0F1B8F2D2414FAA3EA509980ED2A6A68DD1F11C32B5"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
        [Test]
        public void VrfKeyLinkTransactionV1_vrf_key_link_aggregate_2()
        {
            var payload = "0001000000000000B6D02A1F73CB1F1E5DCF024763E33A837CBC3E36AA8C5CD982620F360B60E05BD9549B1B139E51725BE39DB878F7044CA9AC786EB97163B1D9E81CB74BC39EEFC28DC781CBA32E6D357869E20D90BD00B29729341414E5ECE5FBF8B93492A8800000000002984142E0FEEEEFFEEEEFFEE0711EE7711EE77120DBC70A82354FC46E727F9925707398981300E40BE3778FF9EFBE86D722AF595800000000000000510000000000000000000000000000000000000000000000000000000000000000000000000000000000000001984342C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA750000000000000000";
            var descriptor = new Dictionary<string, object>(){
            {"Type", TransactionType.AGGREGATE_BONDED},
            {"Transactions",    new []{
                    Facade.TransactionFactory.CreateEmbedded(new Dictionary<string, object>() {
                        {"Type", TransactionType.VRF_KEY_LINK},
                        {"LinkedPublicKey", new PublicKey(Converter.HexToBytes("C614558647D02037384A2FECA80ACE95B235D9B9D90035FA46102FE79ECCBA75"))},
                        {"LinkAction", LinkAction.UNLINK},
                    }),
                }
            },
            {"SignerPublicKey", new PublicKey(Converter.HexToBytes("C28DC781CBA32E6D357869E20D90BD00B29729341414E5ECE5FBF8B93492A880"))},
            {"Signature", new Signature(Converter.HexToBytes("B6D02A1F73CB1F1E5DCF024763E33A837CBC3E36AA8C5CD982620F360B60E05BD9549B1B139E51725BE39DB878F7044CA9AC786EB97163B1D9E81CB74BC39EEF"))},
            {"Fee", new Amount(18370164183782063840)},
            {"Deadline", new Timestamp(8207562320463688160)},
            {"Cosignatures",
                new Cosignature[]{
                }
            },
            {"TransactionsHash", new Hash256(Converter.HexToBytes("20DBC70A82354FC46E727F9925707398981300E40BE3778FF9EFBE86D722AF59"))},
        };
            var tx = Facade.TransactionFactory.Create(descriptor);
            Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
        }
    }
}