using System;
using System.IO;
using CatSdk;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Symbol;
public class CatbufferTest
{
    private static string Test<T>(string? hex, Func<BinaryReader, T>? func) where T: ISerializer
    {
        if (hex == null || func == null) throw new NullReferenceException("");
        var barr = Converter.HexToBytes(hex);
        var ms = new MemoryStream(barr);
        var br = new BinaryReader(ms);
        var d = func(br);
        return Converter.BytesToHex(d.Serialize());
    }
    [Test]public void MosaicMetadataTransaction0(){    Assert.AreEqual(Transactions.transactions[0].value, Test(Transactions.transactions[0].value, Transactions.transactions[0].func));}
[Test]public void MosaicMetadataTransaction1(){    Assert.AreEqual(Transactions.transactions[1].value, Test(Transactions.transactions[1].value, Transactions.transactions[1].func));}
[Test]public void AggregateBondedTransaction2(){    Assert.AreEqual(Transactions.transactions[2].value, Test(Transactions.transactions[2].value, Transactions.transactions[2].func));}
[Test]public void MosaicAliasTransaction3(){    Assert.AreEqual(Transactions.transactions[3].value, Test(Transactions.transactions[3].value, Transactions.transactions[3].func));}
[Test]public void MosaicAliasTransaction4(){    Assert.AreEqual(Transactions.transactions[4].value, Test(Transactions.transactions[4].value, Transactions.transactions[4].func));}
[Test]public void AggregateBondedTransaction5(){    Assert.AreEqual(Transactions.transactions[5].value, Test(Transactions.transactions[5].value, Transactions.transactions[5].func));}
[Test]public void AddressAliasTransaction6(){    Assert.AreEqual(Transactions.transactions[6].value, Test(Transactions.transactions[6].value, Transactions.transactions[6].func));}
[Test]public void AddressAliasTransaction7(){    Assert.AreEqual(Transactions.transactions[7].value, Test(Transactions.transactions[7].value, Transactions.transactions[7].func));}
[Test]public void AggregateBondedTransaction8(){    Assert.AreEqual(Transactions.transactions[8].value, Test(Transactions.transactions[8].value, Transactions.transactions[8].func));}
[Test]public void AccountMetadataTransaction9(){    Assert.AreEqual(Transactions.transactions[9].value, Test(Transactions.transactions[9].value, Transactions.transactions[9].func));}
[Test]public void AccountMetadataTransaction10(){    Assert.AreEqual(Transactions.transactions[10].value, Test(Transactions.transactions[10].value, Transactions.transactions[10].func));}
[Test]public void AggregateBondedTransaction11(){    Assert.AreEqual(Transactions.transactions[11].value, Test(Transactions.transactions[11].value, Transactions.transactions[11].func));}
[Test]public void AccountAddressRestrictionTransaction12(){    Assert.AreEqual(Transactions.transactions[12].value, Test(Transactions.transactions[12].value, Transactions.transactions[12].func));}
[Test]public void AggregateBondedTransaction13(){    Assert.AreEqual(Transactions.transactions[13].value, Test(Transactions.transactions[13].value, Transactions.transactions[13].func));}
[Test]public void AggregateBondedTransaction14(){    Assert.AreEqual(Transactions.transactions[14].value, Test(Transactions.transactions[14].value, Transactions.transactions[14].func));}
[Test]public void AggregateBondedTransaction15(){    Assert.AreEqual(Transactions.transactions[15].value, Test(Transactions.transactions[15].value, Transactions.transactions[15].func));}
[Test]public void AggregateBondedTransaction16(){    Assert.AreEqual(Transactions.transactions[16].value, Test(Transactions.transactions[16].value, Transactions.transactions[16].func));}
[Test]public void AggregateBondedTransaction17(){    Assert.AreEqual(Transactions.transactions[17].value, Test(Transactions.transactions[17].value, Transactions.transactions[17].func));}
[Test]public void HashLockTransaction18(){    Assert.AreEqual(Transactions.transactions[18].value, Test(Transactions.transactions[18].value, Transactions.transactions[18].func));}
[Test]public void HashLockTransaction19(){    Assert.AreEqual(Transactions.transactions[19].value, Test(Transactions.transactions[19].value, Transactions.transactions[19].func));}
[Test]public void AggregateBondedTransaction20(){    Assert.AreEqual(Transactions.transactions[20].value, Test(Transactions.transactions[20].value, Transactions.transactions[20].func));}
[Test]public void AccountKeyLinkTransaction21(){    Assert.AreEqual(Transactions.transactions[21].value, Test(Transactions.transactions[21].value, Transactions.transactions[21].func));}
[Test]public void AccountKeyLinkTransaction22(){    Assert.AreEqual(Transactions.transactions[22].value, Test(Transactions.transactions[22].value, Transactions.transactions[22].func));}
[Test]public void AggregateBondedTransaction23(){    Assert.AreEqual(Transactions.transactions[23].value, Test(Transactions.transactions[23].value, Transactions.transactions[23].func));}
[Test]public void MultisigAccountModificationTransaction24(){    Assert.AreEqual(Transactions.transactions[24].value, Test(Transactions.transactions[24].value, Transactions.transactions[24].func));}
[Test]public void MultisigAccountModificationTransaction25(){    Assert.AreEqual(Transactions.transactions[25].value, Test(Transactions.transactions[25].value, Transactions.transactions[25].func));}
[Test]public void AggregateBondedTransaction26(){    Assert.AreEqual(Transactions.transactions[26].value, Test(Transactions.transactions[26].value, Transactions.transactions[26].func));}
[Test]public void AccountOperationRestrictionTransaction27(){    Assert.AreEqual(Transactions.transactions[27].value, Test(Transactions.transactions[27].value, Transactions.transactions[27].func));}
[Test]public void AccountOperationRestrictionTransaction28(){    Assert.AreEqual(Transactions.transactions[28].value, Test(Transactions.transactions[28].value, Transactions.transactions[28].func));}
[Test]public void AggregateBondedTransaction29(){    Assert.AreEqual(Transactions.transactions[29].value, Test(Transactions.transactions[29].value, Transactions.transactions[29].func));}
[Test]public void NamespaceMetadataTransaction30(){    Assert.AreEqual(Transactions.transactions[30].value, Test(Transactions.transactions[30].value, Transactions.transactions[30].func));}
[Test]public void NamespaceMetadataTransaction31(){    Assert.AreEqual(Transactions.transactions[31].value, Test(Transactions.transactions[31].value, Transactions.transactions[31].func));}
[Test]public void AggregateBondedTransaction32(){    Assert.AreEqual(Transactions.transactions[32].value, Test(Transactions.transactions[32].value, Transactions.transactions[32].func));}
[Test]public void MosaicSupplyChangeTransaction33(){    Assert.AreEqual(Transactions.transactions[33].value, Test(Transactions.transactions[33].value, Transactions.transactions[33].func));}
[Test]public void MosaicSupplyChangeTransaction34(){    Assert.AreEqual(Transactions.transactions[34].value, Test(Transactions.transactions[34].value, Transactions.transactions[34].func));}
[Test]public void AggregateBondedTransaction35(){    Assert.AreEqual(Transactions.transactions[35].value, Test(Transactions.transactions[35].value, Transactions.transactions[35].func));}
[Test]public void SecretLockTransaction36(){    Assert.AreEqual(Transactions.transactions[36].value, Test(Transactions.transactions[36].value, Transactions.transactions[36].func));}
[Test]public void SecretLockTransaction37(){    Assert.AreEqual(Transactions.transactions[37].value, Test(Transactions.transactions[37].value, Transactions.transactions[37].func));}
[Test]public void AggregateBondedTransaction38(){    Assert.AreEqual(Transactions.transactions[38].value, Test(Transactions.transactions[38].value, Transactions.transactions[38].func));}
[Test]public void SecretLockTransaction39(){    Assert.AreEqual(Transactions.transactions[39].value, Test(Transactions.transactions[39].value, Transactions.transactions[39].func));}
[Test]public void SecretLockTransaction40(){    Assert.AreEqual(Transactions.transactions[40].value, Test(Transactions.transactions[40].value, Transactions.transactions[40].func));}
[Test]public void AggregateBondedTransaction41(){    Assert.AreEqual(Transactions.transactions[41].value, Test(Transactions.transactions[41].value, Transactions.transactions[41].func));}
[Test]public void MosaicAddressRestrictionTransaction42(){    Assert.AreEqual(Transactions.transactions[42].value, Test(Transactions.transactions[42].value, Transactions.transactions[42].func));}
[Test]public void MosaicAddressRestrictionTransaction43(){    Assert.AreEqual(Transactions.transactions[43].value, Test(Transactions.transactions[43].value, Transactions.transactions[43].func));}
[Test]public void AggregateBondedTransaction44(){    Assert.AreEqual(Transactions.transactions[44].value, Test(Transactions.transactions[44].value, Transactions.transactions[44].func));}
[Test]public void SecretProofTransaction45(){    Assert.AreEqual(Transactions.transactions[45].value, Test(Transactions.transactions[45].value, Transactions.transactions[45].func));}
[Test]public void SecretProofTransaction46(){    Assert.AreEqual(Transactions.transactions[46].value, Test(Transactions.transactions[46].value, Transactions.transactions[46].func));}
[Test]public void AggregateBondedTransaction47(){    Assert.AreEqual(Transactions.transactions[47].value, Test(Transactions.transactions[47].value, Transactions.transactions[47].func));}
[Test]public void MosaicDefinitionTransaction48(){    Assert.AreEqual(Transactions.transactions[48].value, Test(Transactions.transactions[48].value, Transactions.transactions[48].func));}
[Test]public void MosaicDefinitionTransaction49(){    Assert.AreEqual(Transactions.transactions[49].value, Test(Transactions.transactions[49].value, Transactions.transactions[49].func));}
[Test]public void AggregateBondedTransaction50(){    Assert.AreEqual(Transactions.transactions[50].value, Test(Transactions.transactions[50].value, Transactions.transactions[50].func));}
[Test]public void NamespaceRegistrationTransaction51(){    Assert.AreEqual(Transactions.transactions[51].value, Test(Transactions.transactions[51].value, Transactions.transactions[51].func));}
[Test]public void NamespaceRegistrationTransaction52(){    Assert.AreEqual(Transactions.transactions[52].value, Test(Transactions.transactions[52].value, Transactions.transactions[52].func));}
[Test]public void AggregateBondedTransaction53(){    Assert.AreEqual(Transactions.transactions[53].value, Test(Transactions.transactions[53].value, Transactions.transactions[53].func));}
[Test]public void NamespaceRegistrationTransaction54(){    Assert.AreEqual(Transactions.transactions[54].value, Test(Transactions.transactions[54].value, Transactions.transactions[54].func));}
[Test]public void NamespaceRegistrationTransaction55(){    Assert.AreEqual(Transactions.transactions[55].value, Test(Transactions.transactions[55].value, Transactions.transactions[55].func));}
[Test]public void AggregateBondedTransaction56(){    Assert.AreEqual(Transactions.transactions[56].value, Test(Transactions.transactions[56].value, Transactions.transactions[56].func));}
[Test]public void TransferTransaction57(){    Assert.AreEqual(Transactions.transactions[57].value, Test(Transactions.transactions[57].value, Transactions.transactions[57].func));}
[Test]public void TransferTransaction58(){    Assert.AreEqual(Transactions.transactions[58].value, Test(Transactions.transactions[58].value, Transactions.transactions[58].func));}
[Test]public void TransferTransaction59(){    Assert.AreEqual(Transactions.transactions[59].value, Test(Transactions.transactions[59].value, Transactions.transactions[59].func));}
[Test]public void AggregateBondedTransaction60(){    Assert.AreEqual(Transactions.transactions[60].value, Test(Transactions.transactions[60].value, Transactions.transactions[60].func));}
[Test]public void TransferTransaction61(){    Assert.AreEqual(Transactions.transactions[61].value, Test(Transactions.transactions[61].value, Transactions.transactions[61].func));}
[Test]public void TransferTransaction62(){    Assert.AreEqual(Transactions.transactions[62].value, Test(Transactions.transactions[62].value, Transactions.transactions[62].func));}
[Test]public void AggregateBondedTransaction63(){    Assert.AreEqual(Transactions.transactions[63].value, Test(Transactions.transactions[63].value, Transactions.transactions[63].func));}
[Test]public void TransferTransaction64(){    Assert.AreEqual(Transactions.transactions[64].value, Test(Transactions.transactions[64].value, Transactions.transactions[64].func));}
[Test]public void TransferTransaction65(){    Assert.AreEqual(Transactions.transactions[65].value, Test(Transactions.transactions[65].value, Transactions.transactions[65].func));}
[Test]public void TransferTransaction66(){    Assert.AreEqual(Transactions.transactions[66].value, Test(Transactions.transactions[66].value, Transactions.transactions[66].func));}
[Test]public void TransferTransaction67(){    Assert.AreEqual(Transactions.transactions[67].value, Test(Transactions.transactions[67].value, Transactions.transactions[67].func));}
[Test]public void TransferTransaction68(){    Assert.AreEqual(Transactions.transactions[68].value, Test(Transactions.transactions[68].value, Transactions.transactions[68].func));}
[Test]public void AggregateBondedTransaction69(){    Assert.AreEqual(Transactions.transactions[69].value, Test(Transactions.transactions[69].value, Transactions.transactions[69].func));}
[Test]public void TransferTransaction70(){    Assert.AreEqual(Transactions.transactions[70].value, Test(Transactions.transactions[70].value, Transactions.transactions[70].func));}
[Test]public void TransferTransaction71(){    Assert.AreEqual(Transactions.transactions[71].value, Test(Transactions.transactions[71].value, Transactions.transactions[71].func));}
[Test]public void AggregateBondedTransaction72(){    Assert.AreEqual(Transactions.transactions[72].value, Test(Transactions.transactions[72].value, Transactions.transactions[72].func));}
[Test]public void MosaicGlobalRestrictionTransaction73(){    Assert.AreEqual(Transactions.transactions[73].value, Test(Transactions.transactions[73].value, Transactions.transactions[73].func));}
[Test]public void MosaicGlobalRestrictionTransaction74(){    Assert.AreEqual(Transactions.transactions[74].value, Test(Transactions.transactions[74].value, Transactions.transactions[74].func));}
[Test]public void AggregateBondedTransaction75(){    Assert.AreEqual(Transactions.transactions[75].value, Test(Transactions.transactions[75].value, Transactions.transactions[75].func));}
[Test]public void AccountMosaicRestrictionTransaction76(){    Assert.AreEqual(Transactions.transactions[76].value, Test(Transactions.transactions[76].value, Transactions.transactions[76].func));}
[Test]public void AccountMosaicRestrictionTransaction77(){    Assert.AreEqual(Transactions.transactions[77].value, Test(Transactions.transactions[77].value, Transactions.transactions[77].func));}
[Test]public void AggregateBondedTransaction78(){    Assert.AreEqual(Transactions.transactions[78].value, Test(Transactions.transactions[78].value, Transactions.transactions[78].func));}
[Test]public void AggregateCompleteTransaction79(){    Assert.AreEqual(Transactions.transactions[79].value, Test(Transactions.transactions[79].value, Transactions.transactions[79].func));}
[Test]public void AggregateCompleteTransaction80(){    Assert.AreEqual(Transactions.transactions[80].value, Test(Transactions.transactions[80].value, Transactions.transactions[80].func));}
[Test]public void AggregateCompleteTransaction81(){    Assert.AreEqual(Transactions.transactions[81].value, Test(Transactions.transactions[81].value, Transactions.transactions[81].func));}
[Test]public void AggregateCompleteTransaction82(){    Assert.AreEqual(Transactions.transactions[82].value, Test(Transactions.transactions[82].value, Transactions.transactions[82].func));}
[Test]public void AggregateCompleteTransaction83(){    Assert.AreEqual(Transactions.transactions[83].value, Test(Transactions.transactions[83].value, Transactions.transactions[83].func));}
[Test]public void AggregateCompleteTransaction84(){    Assert.AreEqual(Transactions.transactions[84].value, Test(Transactions.transactions[84].value, Transactions.transactions[84].func));}
[Test]public void AggregateCompleteTransaction85(){    Assert.AreEqual(Transactions.transactions[85].value, Test(Transactions.transactions[85].value, Transactions.transactions[85].func));}
[Test]public void AggregateCompleteTransaction86(){    Assert.AreEqual(Transactions.transactions[86].value, Test(Transactions.transactions[86].value, Transactions.transactions[86].func));}
[Test]public void AggregateCompleteTransaction87(){    Assert.AreEqual(Transactions.transactions[87].value, Test(Transactions.transactions[87].value, Transactions.transactions[87].func));}
[Test]public void AggregateCompleteTransaction88(){    Assert.AreEqual(Transactions.transactions[88].value, Test(Transactions.transactions[88].value, Transactions.transactions[88].func));}
[Test]public void AggregateCompleteTransaction89(){    Assert.AreEqual(Transactions.transactions[89].value, Test(Transactions.transactions[89].value, Transactions.transactions[89].func));}
[Test]public void AggregateCompleteTransaction90(){    Assert.AreEqual(Transactions.transactions[90].value, Test(Transactions.transactions[90].value, Transactions.transactions[90].func));}
[Test]public void AggregateCompleteTransaction91(){    Assert.AreEqual(Transactions.transactions[91].value, Test(Transactions.transactions[91].value, Transactions.transactions[91].func));}
[Test]public void AggregateCompleteTransaction92(){    Assert.AreEqual(Transactions.transactions[92].value, Test(Transactions.transactions[92].value, Transactions.transactions[92].func));}
[Test]public void AggregateCompleteTransaction93(){    Assert.AreEqual(Transactions.transactions[93].value, Test(Transactions.transactions[93].value, Transactions.transactions[93].func));}
[Test]public void AggregateCompleteTransaction94(){    Assert.AreEqual(Transactions.transactions[94].value, Test(Transactions.transactions[94].value, Transactions.transactions[94].func));}
[Test]public void TransferTransaction95(){    Assert.AreEqual(Transactions.transactions[95].value, Test(Transactions.transactions[95].value, Transactions.transactions[95].func));}
[Test]public void TransferTransaction96(){    Assert.AreEqual(Transactions.transactions[96].value, Test(Transactions.transactions[96].value, Transactions.transactions[96].func));}
[Test]public void TransferTransaction97(){    Assert.AreEqual(Transactions.transactions[97].value, Test(Transactions.transactions[97].value, Transactions.transactions[97].func));}
[Test]public void AggregateCompleteTransaction98(){    Assert.AreEqual(Transactions.transactions[98].value, Test(Transactions.transactions[98].value, Transactions.transactions[98].func));}
[Test]public void AggregateCompleteTransaction99(){    Assert.AreEqual(Transactions.transactions[99].value, Test(Transactions.transactions[99].value, Transactions.transactions[99].func));}
[Test]public void AggregateCompleteTransaction100(){    Assert.AreEqual(Transactions.transactions[100].value, Test(Transactions.transactions[100].value, Transactions.transactions[100].func));}
[Test]public void AggregateCompleteTransaction101(){    Assert.AreEqual(Transactions.transactions[101].value, Test(Transactions.transactions[101].value, Transactions.transactions[101].func));}
[Test]public void AccountAddressRestrictionTransaction102(){    Assert.AreEqual(Transactions.transactions[102].value, Test(Transactions.transactions[102].value, Transactions.transactions[102].func));}
[Test]public void AccountMosaicRestrictionTransaction103(){    Assert.AreEqual(Transactions.transactions[103].value, Test(Transactions.transactions[103].value, Transactions.transactions[103].func));}
[Test]public void AccountOperationRestrictionTransaction104(){    Assert.AreEqual(Transactions.transactions[104].value, Test(Transactions.transactions[104].value, Transactions.transactions[104].func));}
[Test]public void AddressAliasTransaction105(){    Assert.AreEqual(Transactions.transactions[105].value, Test(Transactions.transactions[105].value, Transactions.transactions[105].func));}
[Test]public void MosaicAliasTransaction106(){    Assert.AreEqual(Transactions.transactions[106].value, Test(Transactions.transactions[106].value, Transactions.transactions[106].func));}
[Test]public void MosaicDefinitionTransaction107(){    Assert.AreEqual(Transactions.transactions[107].value, Test(Transactions.transactions[107].value, Transactions.transactions[107].func));}
[Test]public void MosaicDefinitionTransaction108(){    Assert.AreEqual(Transactions.transactions[108].value, Test(Transactions.transactions[108].value, Transactions.transactions[108].func));}
[Test]public void MosaicDefinitionTransaction109(){    Assert.AreEqual(Transactions.transactions[109].value, Test(Transactions.transactions[109].value, Transactions.transactions[109].func));}
[Test]public void MosaicDefinitionTransaction110(){    Assert.AreEqual(Transactions.transactions[110].value, Test(Transactions.transactions[110].value, Transactions.transactions[110].func));}
[Test]public void MosaicDefinitionTransaction111(){    Assert.AreEqual(Transactions.transactions[111].value, Test(Transactions.transactions[111].value, Transactions.transactions[111].func));}
[Test]public void MosaicSupplyChangeTransaction112(){    Assert.AreEqual(Transactions.transactions[112].value, Test(Transactions.transactions[112].value, Transactions.transactions[112].func));}
[Test]public void TransferTransaction113(){    Assert.AreEqual(Transactions.transactions[113].value, Test(Transactions.transactions[113].value, Transactions.transactions[113].func));}
[Test]public void SecretLockTransaction114(){    Assert.AreEqual(Transactions.transactions[114].value, Test(Transactions.transactions[114].value, Transactions.transactions[114].func));}
[Test]public void SecretProofTransaction115(){    Assert.AreEqual(Transactions.transactions[115].value, Test(Transactions.transactions[115].value, Transactions.transactions[115].func));}
[Test]public void MultisigAccountModificationTransaction116(){    Assert.AreEqual(Transactions.transactions[116].value, Test(Transactions.transactions[116].value, Transactions.transactions[116].func));}
[Test]public void AggregateBondedTransaction117(){    Assert.AreEqual(Transactions.transactions[117].value, Test(Transactions.transactions[117].value, Transactions.transactions[117].func));}
[Test]public void AggregateBondedTransaction118(){    Assert.AreEqual(Transactions.transactions[118].value, Test(Transactions.transactions[118].value, Transactions.transactions[118].func));}
[Test]public void AccountKeyLinkTransaction119(){    Assert.AreEqual(Transactions.transactions[119].value, Test(Transactions.transactions[119].value, Transactions.transactions[119].func));}
[Test]public void VrfKeyLinkTransaction120(){    Assert.AreEqual(Transactions.transactions[120].value, Test(Transactions.transactions[120].value, Transactions.transactions[120].func));}
[Test]public void NodeKeyLinkTransaction121(){    Assert.AreEqual(Transactions.transactions[121].value, Test(Transactions.transactions[121].value, Transactions.transactions[121].func));}
[Test]public void NamespaceRegistrationTransaction122(){    Assert.AreEqual(Transactions.transactions[122].value, Test(Transactions.transactions[122].value, Transactions.transactions[122].func));}
[Test]public void MosaicGlobalRestrictionTransaction123(){    Assert.AreEqual(Transactions.transactions[123].value, Test(Transactions.transactions[123].value, Transactions.transactions[123].func));}
[Test]public void MosaicAddressRestrictionTransaction124(){    Assert.AreEqual(Transactions.transactions[124].value, Test(Transactions.transactions[124].value, Transactions.transactions[124].func));}
[Test]public void MosaicAddressRestrictionTransaction125(){    Assert.AreEqual(Transactions.transactions[125].value, Test(Transactions.transactions[125].value, Transactions.transactions[125].func));}
[Test]public void AccountMetadataTransaction126(){    Assert.AreEqual(Transactions.transactions[126].value, Test(Transactions.transactions[126].value, Transactions.transactions[126].func));}
[Test]public void MosaicMetadataTransaction127(){    Assert.AreEqual(Transactions.transactions[127].value, Test(Transactions.transactions[127].value, Transactions.transactions[127].func));}
[Test]public void NamespaceMetadataTransaction128(){    Assert.AreEqual(Transactions.transactions[128].value, Test(Transactions.transactions[128].value, Transactions.transactions[128].func));}
[Test]public void AggregateBondedTransaction129(){    Assert.AreEqual(Transactions.transactions[129].value, Test(Transactions.transactions[129].value, Transactions.transactions[129].func));}
[Test]public void AggregateBondedTransaction130(){    Assert.AreEqual(Transactions.transactions[130].value, Test(Transactions.transactions[130].value, Transactions.transactions[130].func));}
[Test]public void AggregateBondedTransaction131(){    Assert.AreEqual(Transactions.transactions[131].value, Test(Transactions.transactions[131].value, Transactions.transactions[131].func));}
[Test]public void AggregateBondedTransaction132(){    Assert.AreEqual(Transactions.transactions[132].value, Test(Transactions.transactions[132].value, Transactions.transactions[132].func));}
[Test]public void VotingKeyLinkTransaction133(){    Assert.AreEqual(Transactions.transactions[133].value, Test(Transactions.transactions[133].value, Transactions.transactions[133].func));}
}