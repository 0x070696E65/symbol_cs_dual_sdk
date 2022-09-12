
using CatSdk.CryptoTypes;
using CatSdk.Symbol;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Symbol;
public class SignTest
{
	[Test]
	public void AddressTest0(){
		const string pKey = "ABF4CF55A2B3F742D7543D9CC17F50447B969E6E06F5EA9195D428AB12B7318D";
		const string pubKey = "4DB881D07086498C3626F1F84EF89D7E08E5D8293298400F27CA98C92AB2D271";
		const string data = "8CE03CD60514233B86789729102EA09E867FC6D964DEA8C2018EF7D0A2E0E24BF7E348E917116690B9";
		const string sig = "31D272F0662915CAC43AB7D721CAF65D8601F52B2E793EA1533E7BC20E04EA97B74859D9209A7B18DFECFD2C4A42D6957628F5357E3FB8B87CF6A888BAB4280E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest1(){
		const string pKey = "6AA6DAD25D3ACB3385D5643293133936CDDDD7F7E11818771DB1FF2F9D3F9215";
		const string pubKey = "F7BBE3BB4DBF9698122DA02EB8A6EDE55F1EF90D0C64819E8A792231A2A0B143";
		const string data = "E4A92208A6FC52282B620699191EE6FB9CF04DAF48B48FD542C5E43DAA9897763A199AAA4B6F10546109F47AC3564FADE0";
		const string sig = "F21E4BE0A914C0C023F724E1EAB9071A3743887BB8824CB170404475873A827B301464261E93700725E8D4427A3E39D365AFB2C9191F75D33C6BE55896E0CC00";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest2(){
		const string pKey = "8E32BC030A4C53DE782EC75BA7D5E25E64A2A072A56E5170B77A4924EF3C32A9";
		const string pubKey = "41C7467803C694DC7CB1D11384AD35BF63873E21EC04454E434FE64934942621";
		const string data = "13ED795344C4448A3B256F23665336645A853C5C44DBFF6DB1B9224B5303B6447FBF8240A2249C55";
		const string sig = "939CD8932093571E24B21EA53F1359279BA5CFC32CE99BB020E676CF82B0AA1DD4BC76FCDE41EF784C06D122B3D018135352C057F079C926B3EFFA7E73CF1D06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest3(){
		const string pKey = "C83CE30FCB5B81A51BA58FF827CCBC0142D61C13E2ED39E78E876605DA16D8D7";
		const string pubKey = "4CD65AE31B90557EA0F80BCA0748AE1C91C9A1FB53666E8DCCC176774B94E52A";
		const string data = "A2704638434E9F7340F22D08019C4C8E3DBEE0DF8DD4454A1D70844DE11694F4C8CA67FDCB08FED0CEC9ABB2112B5E5F89";
		const string sig = "9B4AFBB7B96CAD7726389C2A4F31115940E6EEE3EA29B3293C82EC8C03B9555C183ED1C55CA89A58C17729EFBA76A505C79AA40EC618D83124BC1134B887D305";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest4(){
		const string pKey = "2DA2A0AAE0F37235957B51D15843EDDE348A559692D8FA87B94848459899FC27";
		const string pubKey = "37C877158F0BCCEF264475AF113494A0A385CB01CDA2ABCEC93C76A8EFC537A8";
		const string data = "D2488E854DBCDFDB2C9D16C8C0B2FDBC0ABB6BAC991BFE2B14D359A6BC99D66C00FD60D731AE06D0";
		const string sig = "7AF2F0D9B30DE3B6C40605FDD4EBA93ECE39FA7458B300D538EC8D0ABAC1756DEFC0CA84C8A599954313E58CE36EFBA4C24A82FD6BB8127023A58EFC52A8410A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest5(){
		const string pKey = "0C066261FB1B18EBF2A9BCDEDA81EB47D5A3745438B3D0B9D19B75885AD0A154";
		const string pubKey = "F5328D4F30DE46CF43F09C228AFC47CF358FAE6A69057C6298E7356047C056F4";
		const string data = "F15CB706E29FCFBCB324E38CBAC62BB355DEDDB845C142E970F0C029EA4D05E59FD6ADF85573CF1775";
		const string sig = "1D660056554F8AF19DE1F6774A4434B092CE3AAF68CAA302CCF77DC7AB4735C135545B1861297387E8902DBA7FCCE69D4A25DF996E3F0C33938B4B89EECF6B03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest6(){
		const string pKey = "EF3D8E22A592F04C3A31AA736E10901757A821D053F1A49A525B4EC91EACDEE3";
		const string pubKey = "6FBC2C208318E49104E25A34434CD5F55849D9C9F53D4B26C2049634B93B28FA";
		const string data = "6C3E4387345740B8D62CF0C9DEC48F98C292539431B2B54020D8072D9CB55F0197F7D99FF066AFCF9E41EA8B7AEA78EB082D";
		const string sig = "032F9FCA99BE7B72D4F76792DD5ADFEED94FCCC75E4B311292534C5CCA64205BBC4B1E92E734B94B99995A186ECD0B1768F24DF9CEF744DC9A922FEF96533509";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest7(){
		const string pKey = "F7FB79743E9BA957D2A4F1BD95CEB1299552ABECAF758BF840D2DC2C09F3E3CB";
		const string pubKey = "39AC2ABE9AD7A73E0ED1B238AF32C1E9CC051236161CDAA1D2A7FD67AC3C7FE0";
		const string data = "55D8E60C307EE533B1AF9FF677A2DE40A6EACE722BCC9EB5D79907B420E533BC06DB674DAFBD9F43D672";
		const string sig = "DE32F224B6A4C8C3761D3F4904F03D8ED15D9B13AEE5C5671E03131560819FC9DF23F61CA5984B19C287DE63C7410A081B6E2F772D33193A4B48DED5056D6C0A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest8(){
		const string pKey = "8CC9A2469A77FAD18B44B871B2B6932CD354641D2D1E84403F746C4FFF829791";
		const string pubKey = "8D6756F82F2CAA567A08663784852D066815132157AAE94948E81AD0B14DFFE6";
		const string data = "D9B8BE2F71B83261304E333D6E35563DC3C36C2EB5A23E1461B6E95AA7C6F381F9C3BD39DEAA1B6DF2F9";
		const string sig = "1A6499428B2E8BEA6370B31363E93552BA597746EE074A276867A3889F9CB50BB85E4D17C1F4140555C9862CCD80300830D2517AE6BE308B8FAB8C6412F2B205";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest9(){
		const string pKey = "A247ABBEF0C1AFFBF021D1AFF128888550532FC0EDD77BC39F6EF5312317EC47";
		const string pubKey = "C23BFD8E37575D392F5A8B5F1EC7F0E1A228BFA33941566A33A692C6A6B7A70A";
		const string data = "4A5F07EB713932532FC3132C96EFDC45862FE7A954C1D2AE4640AFDF4728FB58C65E8A4EBFE0D53D5797D5146442B9";
		const string sig = "96E67B41AED22D8D77D3E7F2212DB5324A27D83FC5974C7F6B497E0A70C216C40066F78D0E68E4BB36490246C327B85236BAC9BA2057ADC8D25869F33759D009";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest10(){
		const string pKey = "163D69079DDAD1F16695C47D81C3B72F869B2FDD50E6E47113DB6C85051A6EDE";
		const string pubKey = "EB344803F7BF51AC9238E8670686A4EDD90960F3682B29F0F4CAE7C2D265E132";
		const string data = "65FE5C1A0214A59644892E5AC4216F09FBB4E191B89BFB63D6540177D25EF9E3714850B8453BD6B2B6";
		const string sig = "D0441615DE0A07DB213D18DC97BFF8857C629D1E1AE3EE6E3CDAA3DA0221ED36415BFE5E8C2D2F9848B8139A031158ED748EE315B8A8B18C7C2D365F99C1FE0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest11(){
		const string pKey = "7B061BF90EB760971B9EC66A96FD6609635CA4B531F33E3C126B9AE6FDB3D491";
		const string pubKey = "3E26D45143A5DAF42ACC54B05A26F95F33F99BFB63FDB6F3E17F22B8362B3579";
		const string data = "A17F5CE39B9BA7B7CF1147E515D6AA84B22FD0E2D8323A91367198FC6C3AFF04EBB21FC2BDBE7BC0364E8040A9";
		const string sig = "8E2F0CED0546D6D2F0C59DCFCF2110A0200D331ABBE5A3B6867594EC2A7E3BA98D18DDA2B63CF7BFE6252F50B82823FC62B66F5E29AC71BBDD0A3A5B412C600E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest12(){
		const string pKey = "C9F8CCBF761CEC00AB236C52651E76B5F46D90F8936D44D40561ED5C277104DE";
		const string pubKey = "03447511451D7052D526094FD59BB9C6270863911C6B657448353FBA55B8ED4A";
		const string data = "3D7E33B0ECEAD8269966E9DCD192B73EB8A12573FC8A5FDFBE5753541026EF2E49F5280CBA9BC2515A049B3A1C1B49";
		const string sig = "E68AAA2D854D411492EA26FFDBF69E6236531D2BBEA6B1015BDCF08A31F0E0030D2A177F2F375F2591A49E745B54EBEFA44D71C6B27B780C195E6C9045C68F06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest13(){
		const string pKey = "EBFA409AC6F987DF476858DD35310879BF564EEB62984A52115D2E6C24590124";
		const string pubKey = "F09832C0F3470136F34466DF2C12312C36D51B923260092FBB71188C74623F7A";
		const string data = "0C37564F718EDA683AA6F3E9AB2487620B1A8B5C8F20ADB3B2D7550AF0D635371E531F27CEBE76A2ABCC96DE0875BDAE987A45AC";
		const string sig = "DC9A32E94379B259FE77E53762AD759250747162BBF9832B25AA502E9D5BBA23AABB74BA39470F111ADCE67D7647342E502342499B2AC34D2E19A1BB49D1BA0F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest14(){
		const string pKey = "F993F61902B7DA332F2BB001BAA7ACCAF764D824EB0CD073315F7EC43158B8FB";
		const string pubKey = "ABCD89B9740576399D85CE6EA630A2F887B1AA22EF50059178224C64EB56CE19";
		const string data = "B7DD613BC9C364D9EEB9A52636D72BC881DFC81A836B6537BBB928BFF5B73831358947EA9EDEA1570550";
		const string sig = "D770890819CE6B117F4E9CE754C70716116880FAF67C34DFAE789A4131AA9A9EEDAD713EA363AC12073FE36D224CE37C15B7D92068C3C5CE06BEAABE9EDCAE0A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest15(){
		const string pKey = "05188C09C31B4BB63F0D49B47CCC1654C2ABA907B8C6C0A82EE403E950169167";
		const string pubKey = "603C051831C696E3F9B83574D75CE73B44DEF4002DDDEB6128ECA42DA902D928";
		const string data = "BB8E22469D1C7F1D5418563E8781F69ECCB56678BD36D8919F358C2778562FF6B50DE916C12D44F1A778A7F3";
		const string sig = "0BE56B9D1C7509070EADE0CB817DC7D7B89B46158E917AF8544AE3441802D071F7A2FEA9293D76869EABD0CB2BB30CA7043D2A9B7F07B49EC06B9D0E8907C40B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest16(){
		const string pKey = "EABE57E1A916EBBFFA4BA7ABC7F23E83D4DEB1338816CC1784D7495D92E98D0B";
		const string pubKey = "388DED7692931BA9621E08DCD0F4C3F9F3E5F2F26A2A5B456EF99509390705A9";
		const string data = "3F2C2D6682EE597F2A92D7E560AC53D5623550311A4939D68ADFB904045ED8D215A9FDB757A2368EA4D89F5F";
		const string sig = "2D56049F2C92173FADE821CF3BABFBE78BE249C72664C528A59998899AE83CF2E8B17EF71C5D2B42C1E81FE1ADE2558C16FC308AF19641E7EEC6FFF46788170D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest17(){
		const string pKey = "FEF7B893B4B517FAB68CA12D36B603BC00826BF3C9B31A05149642AE10BB3F55";
		const string pubKey = "6C5E1C025D03D1C8492D2BE99B263D746D2B33C4E7BF8ED670F76B556293E8F8";
		const string data = "38C69F884045CDBEEBE4478FDBD1CCC6CF00A08D8A3120C74E7167D3A2E26A67A043B8E5BD198F7B0CE0358CEF7CF9";
		const string sig = "0176BC5AC41091F5F26FFB906A0AD59CA6BF09A1CC93AAB944706656752E9AF953DCA16482E7DFB836264394699A00DCEA0ED32B28280B5A6047E193CB805407";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest18(){
		const string pKey = "16228BEC9B724300A37E88E535FC1C58548D34D7148B57C226F2B3AF974C1822";
		const string pubKey = "B0BE6C2B4882E9F2D199C867121990F887F31A1D09C1FF2EC9386AB4F21D812E";
		const string data = "A3D7B122CD4431B396B20D8CC46CC73ED4A5253A44A76FC83DB62CDC845A2BF7081D069A857955A161CCCF84";
		const string sig = "8405727BFE8EA916BD2B9F169026528DED0A8D913DF217AD3AF0A9F10D0ABDFBFC5187A9C2AE2CB49DD0D76388C1A1E7CFF7D1E938134C1ED8E407CBECF01F0F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest19(){
		const string pKey = "2DC3F5F0A0BC32C6632534E1E8F27E59CBE0BF7617D31AFF98098E974C828BE7";
		const string pubKey = "9AF057D0C28A517A13EDDD6861FF68BAB5862915CE1DCA12FF4E1C2EED7E4C66";
		const string data = "BDAE276D738B9758EA3D322B54FD12FE82B767E8D817D8EF3D41F78705748E28D15E9C506962A1B85901";
		const string sig = "7340B72E36115DC472871C149EE74D8030766960FD62FAC35A38B2198D1836AA9538F253CE048891AF2199DE224CB6C0586696140B6977433E6BBA5DC5F3D10A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest20(){
		const string pKey = "3ECB9CE7A3C4477B8324D787E94475CBE018A95140447AB7EDC4E87980171C92";
		const string pubKey = "15278A71B893798D5FBBCCCAB31DD860EDE563E9D3B9227DB5E80EA25A981EAD";
		const string data = "19C3797889404967A54C91A737738400FCD4F4FD1C5EBEFCE1A5694B7CEDEB6BEA395088ED38F83A";
		const string sig = "12856F010456E647BA799D142FF5908EA14322B54AB22F8EC39FFAC8712F9AABB259014E49CBB56E2A8001E5FA69CCDDE3EEAC2434298160B3CA3478E6ABCD05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest21(){
		const string pKey = "3898C88D44091FE30A6E58D67BF5641E9D7CB3186D085EDB9EE05F6E7A79EA50";
		const string pubKey = "8B2F1438CFAC26E414EE376ED31FC7088F4687BAEC13F7E556C8BE7704F655D0";
		const string data = "FCB7A3B57B2E22069F22ABDB6DB6DD467BEEFFAD0F3B74A999BAEE14831AD517E0B536152151B80C8D3D7C407F9CB889A52C06";
		const string sig = "D576A5D0E713C72E5D048CE38B15753E3E3F2C23825F471D69C599A40CA2B2F28A02127AAEFD1E028A08DB91A640F3DD50420349D0C477F11B3CDC8C6C79FE09";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest22(){
		const string pKey = "5DB7FE111A7B068ED616D82FE649CA2CC08825960F2FA1D941B4347B344E8622";
		const string pubKey = "620B6072065B23ECDBC3EFE28CCA40E81FC410711FE199570AD44D88604AE014";
		const string data = "10E6253361F0102A1090EB861F35F6764AE71FA0ACC46E3CA0632C5B7C65017AC3C3E05894F22CEA18B37E6FA28D219874C9";
		const string sig = "C873CF9357A46CB0BA91DC0FC83E65BA7194E7B347B2771DAA3EABCFC672F02F9FCD55F5738D3CBD69872731C0A3AC954064E9BF802131ED08477478A13F9E06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest23(){
		const string pKey = "5854F9B2A283AE951945CA5E151E46DE7F54B3612D5D590AF7C097D842DB399D";
		const string pubKey = "688A67B337DB39AADF31B10653761236FF7FA8712845A22872D735A4B03C7F84";
		const string data = "2AC0A5C801F0DF0A7D9C66DAA3EB6F1231298700D628585D9295505408E799B3EF7B5313E9AB26554CCFBFDAD4EA7BAB31F46B50";
		const string sig = "A9CCE10862E910071D0A1974E65578E5536AACB9E1D90B1274A30D8E4CB437BCD06A221902B59306B825A43C6BAB021A9ECE238C136E2A966897D2594141350D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest24(){
		const string pKey = "0C3ED7A3E226754E03A90CE8E2918BD2EC622E0B258E69F98C8B7A09543A4D5B";
		const string pubKey = "16FB59F907524009730BCB9F860C8C5A1109A9E8F194275DA0B9F5A2085E2D02";
		const string data = "FF60983E0C5D21D2FB83C67598D560F3CF0E28AE667B5616AAA58A059666CD8CF826B026243C92CF";
		const string sig = "2E32A8A934C2B8BC54A1594643A866CCDB3166BD41B6DE3E0C9FC779E7F3F421A0BCC798408ACCC92F47A3A45EF237D5CB7473D768991EE79AC659E1DA8CBB0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest25(){
		const string pKey = "C90C193DAC26E6172462F212B5D3FA11406434496C7BF72FDF71FB4E9840BA44";
		const string pubKey = "AC515DCD6284495D569A374B40768F86D963604B68AB671E155A37A443FD8EAB";
		const string data = "337E7CDBFF240042C778A8E6DAAD5690A47BC852087735CBDC3E0321ED056BE3EE4F6979BEF147BF59F9227AFB";
		const string sig = "E57C65FD7C9C445CA7C7723B506E569F278FBCF02E572E30365668EFBF764A4303BD43105B1840FB57C6342ABA8771ED42A20867049AC0C9DD356775AF2FDB01";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest26(){
		const string pKey = "E3653151EC7882D6C6CB3DF83717374DF447DAE66544842AD354615B37D7B134";
		const string pubKey = "298F22B868882CCE041BC3614C6752124BBAD3C1189E85CEEF4BE2AB359D59A4";
		const string data = "17448B36DF681C62A79C2D8C95B7AF3BBE4C8951DF3E47A940C5D343B2A81BAA589F63B6D00D82918B5B3B0BC80447F4E2B39F";
		const string sig = "0C1C9BC4C96F71656293DE75394C2C698519A5762FFD0478BD31D3CA137014E68C85682EF77F5F6FE2BDC66C78183AEA5DCCB2FA06CF61B8B08E8E2EAA01F90A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest27(){
		const string pKey = "43C74F8169896510718540B6D90C02EADAC289EE44A6EAEBD213DE9D951667A9";
		const string pubKey = "452869F7A0B507DF296DF39799E47E9D9A647CCEE95CE914A4DA502A461B83D2";
		const string data = "F8D4D3CA7EEA8F20E24D155FB00D45639887F014D8F0A5D557AFEBA99625F360921167072B6C3A1078";
		const string sig = "D5D3E033F51244BD65255AC558B8BFF06C311F7AC534542277945DB3B247633BE264458D116DD5A5FD5EDADF95F561B03511727E5579F1112C70E38217D6FF0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest28(){
		const string pKey = "DAB6E9D455178FAA8531518A30565AD0ED5C0E1E00029A572DB990B4E922A5D8";
		const string pubKey = "3B73F90F676F140004F8FD7BED292DF952B661E4D099F3EC5149A881773D1C40";
		const string data = "6C0611A6F2C768F84B2D95C4DC6487EC7D73AAA804B5DF50719B86A26AA8CAF9AA71C624240FACFE22";
		const string sig = "74C62500E24E71054C12AD44ADFCC64F938B8BECD4C494A718EC7B6343F5F3DD4299280EC95FBA1B5ECAB0B4FA0017AA84B05A042422249255231C0CC0A80D0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest29(){
		const string pKey = "97E825A1780F32227539EBF3D032E390035B50A6E13CF6174D259B33F1F327E5";
		const string pubKey = "E2BE362795B77D0C19FC4AC15BBA09E4449104D05DC7F75E4E7F3B3F9BCF1CEC";
		const string data = "23F47836AB60E6258A5B64909B422D7BB305745D3D01DE7BA8D0A167F134AE61A4E08E11C5DF327EEF1D";
		const string sig = "8E514CD7AE01ADB20D6C4CA551255C1DFABC4E41531EF23539E29D27626BBD1F11BFD5030B6973981D515C627C3623F87926FAE4FC5CF15EB3C6DB75F7C26A03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest30(){
		const string pKey = "8230263C82F79A5DE3E309C084C369A13DBE7E66540A6974435080606B9004C9";
		const string pubKey = "076C56322569282D625CB5094746711AB95BA78179D4BC2F40B3A95CF21AAF8F";
		const string data = "AF962C1BC29FF028C8B8FD89827219536D90D60F6E427C3E6E3BD5E7712B8D0A8052F32A7986B249E1331D";
		const string sig = "AC347785DC36B2259D84F879CFC8FAF25615DB80288CC594A87759CD611E8B065AD5A57AD95C96085527C4D3E65CEE36BA7EE911097FCCD3625FAC07968B3E04";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest31(){
		const string pKey = "43D74BB830C268519BF5C72FB5EBBEBC7CDA14B3D787B005FC2038EE6F292497";
		const string pubKey = "02ADFC1A0581E48999AD182A1FC051092C2148880BFEFCEAA2A69E3363A172FB";
		const string data = "F88D70F62102CE63AE2921EB8F930B849F7D4732C512E03EE1C8B05AB3E2EFED5DEE2B1893CB0A3FC13D";
		const string sig = "69E609B0DB38EEC29758BA5AF310B52390E4D6AB22E261C326BDF26ABFDF1A485E7D8F074F786B306C49D193BA0553FE7BAA7C27419DF1515BA7B8F8E77D6D07";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest32(){
		const string pKey = "AA43BC3208F01D29E954DE910B69BE07A33AC3F97424EBF51F246774BACEDE8D";
		const string pubKey = "D49C9ECC9E55728F8F493349C7DFDE31B90C4A1E834342BFCC6BCF207A87295D";
		const string data = "87D576C693E5528DC1FBD1CB96ACBE88D2BB71D9B8B73E7928BD16A8A71F0AE246BAE69F1241C6D7A009B7C691E5ECF639F4DAFD";
		const string sig = "7D7803920DC48D8D681E46571F5501E6B139800D7AEB464EF732FAD469AB0E451D6F31391E74340A03A2B69DB0346B7E727ABF637B70267EAEE9509FA41B5E0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest33(){
		const string pKey = "E657D1D5E7789967B9366E1D3D1386CDEBBD8650EA0D6184D8E36B8853960B09";
		const string pubKey = "4A6141E3781E25E794210B6CA9922839EE0E81AAC69764360121775C95721BAD";
		const string data = "8017A5CD334DB855016599C74F7BA4BF8B9226CD343FF0134EDAEE2F10ACA0BE407B233986F0A6F02C633844578EAC3D28";
		const string sig = "531B8436475C77AA90B891B7BED2A0E13FEAA5A603D8A53C27E64645690B9102AC48CDA7238F1CDA635634BDCEAEFC451569A57F0AA72D956B60ED455463BE0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest34(){
		const string pKey = "9D3F468B66925D1F5941F81CEB845F2BD75FBA1F1F3E510EB4C5C9C787181D01";
		const string pubKey = "E90A9C4982BE531FE7E99BCA0A820BA950795859AE55EA6468D0EB3EF792E106";
		const string data = "6645AAFAD0AFD4D5B524EC278807E67F7C39529188D311515A1DC101CB46EEC0847D44870F473CC123244447B853";
		const string sig = "AA627DCD21F2A9F35FD1E32E945DD24CC74035DCEC32CF3082B5C7FA1D9FA6B1F99D67CFCE41D54F2461B380956EBFF36CBD21712D8AF3E50B17D14FE2A29F02";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest35(){
		const string pKey = "42FED01BA1A2CD66368E1B04BF3C9A2585A8E9E0DA7EF41351F347F84B4588BD";
		const string pubKey = "74C235585AB72A7465B24A3F7A2F8DCDE2A4CA8F844C46F57CA22C09C5C85731";
		const string data = "E5BC834E803D8F55F9621DB8E79B94CD736C08BFC77155A6D3B1A8DE2AB73799665CD71BC7A1837CEB";
		const string sig = "CC009F182DB0E92262DFC28D9A65EC1546F9A825EA58642D38AACE7B7DFE12189308C3DF71A0A22F8E7FD01AAE11BCCC1DDB1B2F048D7C6C01F10D8D610C830A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest36(){
		const string pKey = "EA97113FD54FFA5E89B2623898A9399488D5215BEB325F0D91ED6FEBBFB492D2";
		const string pubKey = "613EA6630B9409C46E7B60ADCA75F1F27923EA41C5DFE0178416FF6064E87BCD";
		const string data = "9C248DF832A6F7A2E96776CB2CC0DDED477705790F32778023753541ED13BFF187C5168FD52535BF9B919F6144592BCEFD707946";
		const string sig = "1D8A36B56141025771F0816ADBC44046FFB3C13FDE22C67616BE5574959C936CC4D71D29F9CA7E136C54C3708C8426A9B9C7ADA5137CCA9A2DFD4BFFABAAE303";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest37(){
		const string pKey = "4F9084EEBEEFABCCCFAA51504ADC698405738922BB1BD99CF9C4E5273CFC3A79";
		const string pubKey = "4301C97DC20FB6A0C893497565AACD40904139D6D973C617A2311A31B7D0CE5F";
		const string data = "712F4DC51E20995F2DDB160FBAE4BEADCC916E1D54CF46EF4E2FA80EE44E781765919E2AC103E5110AF899FCC3466C72E9D6";
		const string sig = "7F7022FD153FBE0D01D174F1B1C0A515AD5A5E92B801F7F9C060789AA87DECEEB6CE11078836A75C54C3BD2313FF9C81C26E4EFD29E4FB388CA86EE2A217C60C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest38(){
		const string pKey = "4F9845AB197ADE1CE0C616380327A2FE1F39A29AC15CAB803299F54AC2C66B66";
		const string pubKey = "D2BEAE369749522EC60D2FD5533DEDDE4234037E685C0E62FD5632139977F769";
		const string data = "DC8C44894D5CC7A138A70C4326C82628C740A288C65247A213B410743E1725F58F4E1B97248BA372";
		const string sig = "08AFCC9CE11473F49DF7115B20B820101136248DFFA9A5F84F9A41B56280192B40C43DD3D416FA8B99CFFC608331A623FC2D691C9CEA4DA073368B8CB93E470F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest39(){
		const string pKey = "7C0C9AC3B6B1FFA2BD7BFE6238499C7662D3B9508A629F8953C127AB64DFE063";
		const string pubKey = "E32D3999D74F0E04ECD1F7120291A645DC4BC77BE8CA776D2E43A601F7029E80";
		const string data = "89D8CB99858E7FCA07479CABA3B0BE76C7E1BD536F1B8AC6828CBA6894F5AE3F83D69DAC4B48A1701257";
		const string sig = "B752F24584C13AEBB6C253F33C8B5D2AA1B3471607F6D92AA1BD20AA8EA526918F08F4E55B4A6A7FCBB07563949BDC12F16E9C75E564931FA190A55A4CD64608";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest40(){
		const string pKey = "E52F4833CFDDAD84065F8B60991111A1B8DF29EAB5C3D1AE0F76B7A29C1429F2";
		const string pubKey = "8CB39CD61AB2580182FFD625FB52BC2F2CEE3912AE43CCA74C067E2FC8C5E31A";
		const string data = "6450318F4E7655EC8A8559D812A9621109498E83D0223800A2F51F25E3F7D6042CF11DDCFD34CDEBC2B1A52E140CCDD21A";
		const string sig = "63D5E6937F926729BC25556DDFEF1308D8DEA3476B1240FE0B43D43F14322F654198631E940603468E4D57922CCC1A9F28BF879C737244AD9F408F6D389AA10F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest41(){
		const string pKey = "223CB09792B627A0DCB3A2844EEC76E739926EEAE51A54AC3D1B87B236DF7CB7";
		const string pubKey = "A93B264145571E4768DD1C59E340328095483A9D552602E9CEADFA03648AE97C";
		const string data = "50FB500789E1C6878D6796C4EFF83609BAD0A4D36CA236C9D6BDBCC9215BA298792788B2E031E43C0EE661DC5E";
		const string sig = "4971948AAC210159C1E806A615932FDF06AE37A6F06A4368160CEFAA5C2CFA6B35AA254C279AE57D448B910448C13331C23AD4F031A661E5DBFA23227C7E4507";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest42(){
		const string pKey = "F08D123A754845A3FB735F3742F75C701B9A42F348CAE9FC59C540F52106A04A";
		const string pubKey = "16F59FB9DC7E30D2C8463C5FBFF014F0A43B8F58D3D0F3141860F71CBE597C47";
		const string data = "E20CDE9087154A91BF18029C532449BBFD5083B932E3AC5853A712C8DBA2335EE028C017C55EE78A6819BED1";
		const string sig = "E937149644EF70B2F1546E0D5B8FA986E82B40D944A3490DD50B3F051827CC136D7289C50ED1C64364242339FDAF31A7E36F2242BE9E29AB65404CCAF127150D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest43(){
		const string pKey = "3CFC0D47DC90A51AE1830E23A64811827C7614F2839FF04A7FFB0FE41ACFE87C";
		const string pubKey = "F533228996724D57DEF40E19E0CAF32B0160B435A3446DAF03733C3C7D53BA88";
		const string data = "8B029AFBA7A9F0718DFAC31A322C2B04898A2C93513C7CE31DE57D8F4C756D5FAE841E38DFA49FA4A7795CE6DB1654";
		const string sig = "F8BCACCA577BC24FE37155AB4111CA0F9C9CDC9BEEEEFF4551126DBF90CCA4CFBFD35500B319F0EAE449583D84A42CF272404D477E6DE08713B50BBB74B3A808";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest44(){
		const string pKey = "4AC719DE0CB49B4D25795651ECDF64653A145CC0106602D97A33B7ABAA53E162";
		const string pubKey = "2C77836502DBFFCC202FC7DF4B30C41D0E8355CD085B53FC12F46B72ADF5DEA6";
		const string data = "F807FE986F54D6CDF987E3F200FA6E9D3F257CCD5BA8E5B06291907B3F640FEDA52D8264387E46EA6D18FF9D1110CBC967";
		const string sig = "C45F6C30CFC167926C5BC3C34F2B29C57FA2C8DB8E67D2DA86345BA02C2013A8C09BF0B1901071C6DCB8FDF74E79F508BC2F4B3B28FE132A06DCF53F6D53990B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest45(){
		const string pKey = "9EC60BA468F1A537774E10F8BAB3909627D7A09D5EBCA86FB28903F4D740EC2C";
		const string pubKey = "968240B4A9846DE2DE85AA5C80A66412123A74B77CE1E98DF0ED93A7FF38B765";
		const string data = "7283F37C2D42D621673875D529D36F755BB0149B54DA0D9DB45E1D703166E801C55DADCD72558C295660FF31";
		const string sig = "87DDAF5F0AB3B43A898332E423F096863DAA97B13E598EC2E0448E927119114DC933C655C0BCB6921F72BF8374207D730BA9FB8C5A8A891E3A5D8BC9E7E0F707";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest46(){
		const string pKey = "836958918397D87CB8C261BC79B6D6B6C2C0812DD43BAFDACECC21FF91B55FA4";
		const string pubKey = "BB097BEF47B294374B7281EB61BF4FA1B1422353B714E6FDD3748D7805C2416C";
		const string data = "955F1735E70128BEEBE64CA8903480C6DA19CC2BAF3E6BDD3FC7041A692A045CA102B059548FC57F";
		const string sig = "C37C4906FEF387022ADFCD664319DCA282893C6BF66BC41581B9402C36F537ED20A683BC0F52B7C079B18317F7B35B7E70BBB792541956E48206B44149B26501";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest47(){
		const string pKey = "1530BE5A7BBA1B0F0BC3FB4CB0B019542D47DF89ECB3996D01BC280E4017ACD8";
		const string pubKey = "5E4CAA36812F2DB20CAB3EBD10697242D6AAF27A1C1615B899957BAB26866B8C";
		const string data = "132CE7708E19068CECA35F8FC1F7384C4FDFD585C6E7953F22AE34659053C4716250434F666695497A7077BC9D63AAC495950B";
		const string sig = "F546F9F56CFE6B976E46E1B71709E4FB7563F4B52570B07DA9CE40B4BDABC1A332CA7C64EE9FE3DBCC6137D0A3DAD6C99F93F466A93A0596CB06494F4BA3CB0A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest48(){
		const string pKey = "F281A5B2D1C7F4CE628392E75902F38614CBB3AF4ACCCE263CBA860AFB2387EF";
		const string pubKey = "2FBC4FA9EA2B714FFA2902A68AB9E6EE6BFE213319FAE449FAF69C15A5B0E060";
		const string data = "332FD70780B5FFAF3C571B6D3ECD048C065C0AFB05C1BE0F5DC7C80A5797180B6D886372A9B8B1DBD2EE1B904152FE";
		const string sig = "E7325CC1B7F4F67A704B9CC87C918777823071CD3BF888C1857DE273D0421BD5699DFAB857A7C90BE2907AFE0C361CC7002D0353C719A96ED3EE0A04B67A7007";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest49(){
		const string pKey = "8B0A47A1ED6044E03234A517B0C508C24B6900F94546296472F1D6C380CA34BF";
		const string pubKey = "6E79131A0A48B7D6A729C4CFB83C337DEE288921299D0909BDD2B234101ABAC5";
		const string data = "8918CAD2C4D10E8222865BD04A3AA492FC246A6BA477440FFCA26A2C21230456BE236D2B1D8F95AA01CD8EE8E01DCDB5CA89CA";
		const string sig = "726E867D23D6DDAC3C69B4B313F7951057197083427B38ED82178BC09DF98B6DF71C59D51649822D618111AB4A5E378A1A9418084DA59787F38B713B2EB59E05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest50(){
		const string pKey = "09DDD185A0A2B62760CA35567B83EAD845ACEF97AD2BCA6BFEA381FF8E806C1D";
		const string pubKey = "6EAF3A025A604E7A47DE2BA81FB13FC28B819D2C849CCB0D460ECE0F11D1BE6A";
		const string data = "55DD33145CB8CBFBD21264C2FF786066B21A2DB7FE47F6E1410D20CC9E50FB9D6462188E4602A041";
		const string sig = "A440B334D5D3853F96BF910EEFA5285C9EF8702DC1036D94DF08C7B428BEE796C57033081D0AF0A640DD20A10937628934B1F7A291E88CDC018292BC787C6B08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest51(){
		const string pKey = "00665342A5BEE2DD5BD63C4C7996D102070A1CC7278CE10524715A8DBFC99DC8";
		const string pubKey = "1B0AB95A7417DB3CFCDEC24033CB9E01BB81F30DEDC892AA8AC619E4CF713E41";
		const string data = "CF13D2EF24FE41E094A95D3619C80B2B5176349DCCE7EB3588D63AD5C1116597338C23D171D3DCE3A6DAC0CC311692D46AEEC1";
		const string sig = "6B3D9033B7B0E926D70FD4991DD1D9B40045E0E27097186FC50860A811C3E659E443F5027ADA8B29D80E31AC75520D68C36431E196F9F691E182481DDBA66B04";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest52(){
		const string pKey = "81B4183684CFCA61BAC4F9114363E0A87DD1DF88191D4D4CD29762E9FCAC67FC";
		const string pubKey = "0879AC6FE51ED7199FB25D6C85D6B906F97462DF18705BEBFED17AD35742D01C";
		const string data = "22FA266659FB38312725A4A8C6D2972E44C96C4BFF2FC7A8B7FDCA4D8AB2F5368A21E424C602E4C8759C7A7107A7E13722BD";
		const string sig = "751422EBABB558FCEE300027413083F7AC206DA8589AABB966204DD22AB4A29825C3ADBA1F9B985E2E4E0C0CE7BF2059CDFA1DDE6FD715C8218E87055C805608";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest53(){
		const string pKey = "030C0B139705180A44D5A2406FBDB92AFB16F93C2D168DD39D2F5F43516295EC";
		const string pubKey = "2221D02D760C42B7793FB154B92259DC1EBB312C95DEB971F1EAA6F2D7E4DB19";
		const string data = "60A3512E600236957F271A5B47EC35AB8991A1F0A0B76564D0549B77357779D0B1502365DD83DE78191265";
		const string sig = "CBDD3036A9964F2B000FB43F2A420F235B0FC8AF2A21A3017DA45547AC91C4F322E3BA0822DF6982EBAFA60BFCE41CC52FFA8E3BE7148044F70805F84E585D08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest54(){
		const string pKey = "E6C1685E7AC64EFB63B77D55E05D7A1D1036B21A2831A250564653DC0A137CB7";
		const string pubKey = "2E71772EA2A8216A6489235DC630E2948B1320E5BCAFE9F9D624F1B9515F5871";
		const string data = "A50E6D1BCF638075E64C9E1B17C4DF9D21EA977878E2852628A485A29D8456FC7073921DE0A972E9DA4AC861";
		const string sig = "16B8630CE5268C4AF312EDF8791DB70FBB1F1ACDA6E1D468A3A266C221574D9E3C666373B4CCB68FDE86270A8EC7C1228A0E4E4073CFE9807364FED3CE231304";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest55(){
		const string pKey = "51758D3BBC03772AC3047018FA472EF980B20ABC38212A63B442861BEAC83904";
		const string pubKey = "34F5E8C2D9315188E66A41E56524CB1BDA5E8123D965F3E9598906023BAC6014";
		const string data = "5547AB3B1B7A38BA5CA4E7208F405D0B9D3B8FDD04841C4AFAA49D704A7BADE6533F369FF1D9F87CBB70D6";
		const string sig = "E37836858C29ECF256586D303F5D09C0A576FA20EA8DB77F026B5372D6C23BD5D2B82F12A3C9D321E38BE3B048F7B43BEAE5D81218DDAED2284058A372CF6904";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest56(){
		const string pKey = "2900D96D21B7ACE794558A432C1F28B806280AD93C31482E5B40A117E1219F21";
		const string pubKey = "73B456E0CB23D8C7C4DB03DCF3AC2E095056D066D5E1A38DA5C38C9386536CB0";
		const string data = "3B68A2DE1C8808566EB969C032F5A10DF91AB7AE2D3D57C5A6A3376572876E0D94A759EAB785D943AD1DA35689";
		const string sig = "C43B4FF7453A8063321AA877D4F4B2EC70A087D5B50464BCF63FA9270C717FB567A4034F56661F269A0310E07B190493393C7221D94549E33C0C61335A1D9B0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest57(){
		const string pKey = "D7DA4E94FB9925B6AB01370F26D45D1649A47B8601EC7CB8AB8E410FE8205D21";
		const string pubKey = "A0E86E5C7D04C31F8E56D4B4288A0E5ECF34DF2F566A6A576009D9FDF708D14F";
		const string data = "2DEE16A97075FDF715819FA1E88A49F96C7345F414330AB6BD5CB12A81412969920F0483961DA4EA6ADCBC01FDF5";
		const string sig = "00175568E98362C66EA8EEED9E1594F104952C02CDE4E2836C637C26D402E52C0934842390E63CEB166D56BB43723F52E58B36E2A644772D16379DE40CFBC10B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest58(){
		const string pKey = "3837B66CD409334733027AF1F4F89F9F8654FEB50C57DA4208BF60D32DD441B3";
		const string pubKey = "B71D5686982299078B3CCEDB1DE58DC4D44C01D8195AC38D13F96B35EBEB6320";
		const string data = "E7F642BCCE878038090F520A6337C06F6ADB55050F3AEF6CEA392B6AD230B0DBA62E7C3AA524E84A6EBE";
		const string sig = "2D7595F8470BB2F94D52A7DEE30B345E3C8036B034A9DE366714782CC802368B3E9E32883D2A9E6D91816B28C108682499FDF154F912486F0C35B635913F5402";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest59(){
		const string pKey = "59212CC95F202C2482122ACDCE15C0491C4DFD3C239423953CEA71B31C8ABE0D";
		const string pubKey = "4DB9A56DE7FB460989134919A126160CEE5BF28AFC4A4F7A1E4133F6D261B454";
		const string data = "E6275ECFF25A50C01FCE080C1E657ED04301DB84F455CD462F8829EC909E4DC873EB31B90CC8381973";
		const string sig = "4C236E60A00A7DE0E362BCD35B1455104617ADCED5E1BF96BA71D6DC80A7324A097FA3D6F3E91596D58CCD4FF26B5335CB3D4A1622B370ACB4DEB69759408301";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest60(){
		const string pKey = "6C89B77896B8109821B0F0CA372563476FE4102E4E77B5EA57A263C4EB9E1A6F";
		const string pubKey = "1293209FFCA524BA8F2FDD919E675CD22050EE8FE3CC8012BDC5F5BA7E94E3E2";
		const string data = "6F1CD9AAC157734245E8688C7117092929030FE3A4499983481FE92E29B171C848C2E40E67183E9AED506F536CDB605D21";
		const string sig = "8D0E034D9880FD9D5A256A39C329AFFB588289524A9C4BC76711B00B03C5367C1D5B24DD75C1AF87386AE35933B7F0925378A7CD3E07237541285657129EA601";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest61(){
		const string pKey = "3C3408D03B2C01FA5547375F73CA9734858DA32BC6CFD7C62C184EEB49652F69";
		const string pubKey = "B6DE0F193F7DA826B7A512DC8D4FE359825B5572580376E5BCE1A93ED68A46C1";
		const string data = "51D01978437B34277EF148297E09197F5F03D434E57E1DD61B975BB2ED290B87B3DBA4425B0B705BE211426236";
		const string sig = "EF883C9D6D496CE8A476EEA7C399B78C164DB2CED1809D4DE36BD9354488675A8F4771F8CF33E6CE58C79F9D9DCA1485142340C5E0DE194BFB5A5D226A83CD04";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest62(){
		const string pKey = "4D3300355854397FDAA96467254DB2EC04C18D165E5194D009EEDE13FD8B0273";
		const string pubKey = "1B7B4F851B6D374D6D38EF76BE4F2D900F9F8E1A8BA047F63B26CF6F608DD377";
		const string data = "9E52B4BE735C44483CB6CC78BA9E8D9A84AAC17F14096D47D8067A36A2027892BCDD5B9F5AC466E564";
		const string sig = "64EF79C0BCFDFFE8B51FD2CBA90DE31ECED82FFE6CF4EA9A8F2E39E2833C642288AD4A09E501FC151E45D4219211C3A4E79706D852CBC97F8971443DB3415D0E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest63(){
		const string pKey = "9606BF951F3F28AEA0B7536DDE26C5AF8807B6D0BD54B2EA165645FA9890ED9D";
		const string pubKey = "5DF39A0FBE3D43F86C85791D82330F2C05905A832F56C61827E4BD110A490347";
		const string data = "112BAAD15429D6F30E8A81637315A6CBCB959A48A1FBBC3844E5427274FFD486D039DC6D27D7BABB21F5";
		const string sig = "0602F3C8CA10DE8364AC80D3B6B484CA18FC87AE07F6ADA4ADBE79CC8813370FC5BF10CEA9FEED676F990DDE74529E78A188FA85A0B47EDCF51B6DC3DFB8F30D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest64(){
		const string pKey = "08720F4471BA2EC5DF3AB0A6B9C704B2302AF9A398F3AD3F56AF42FFE4F2A4CF";
		const string pubKey = "EDA0E18533AAEE4DDD57F68F36C34B75D282E649FDAF325DC68530B27052945F";
		const string data = "42F96AB0BCAE227C6CAE23E76C967B8CD87450B21D894C98394F2896ECFB79807418C27DFF5EFF0B7439F522ED82EC3A8D48B927";
		const string sig = "1613FD614AE6B562AF159D3348A21E1961F76E6F9B96AC0D2BE9E713978048E066023CF08BC7DBEAF16F27E7C280B9F0264272E488BF7A4702C261F2677CA204";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest65(){
		const string pKey = "725A04A1BA670B678B0C9162B53B550E9C0E0768DFEA503D33951C1BCD22E6A1";
		const string pubKey = "D83B6913FF47529492304829DCFEEE5E0866EADEC87A24057511F3D05B373A39";
		const string data = "C610347D5FD368C7BE675B8B225CC8C8F92444797A0DFAD09E222D8D503EBE561E4DBEFA5D5E1F6F71229F9955A2692527F6E8";
		const string sig = "B48CAF93B64B987E4E5A5F03F436B02AC4AA0EEE456E81AD4AE19B5AF58F0D2E5DBAFBBD6C08775FCE01B7109D8DB1F3ED5E58BB7198EC09412696726FD68607";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest66(){
		const string pKey = "109F2CBA71A6540641D004B870D52CA7C8BF49602D5782CE5F29E10DB3A7E6EA";
		const string pubKey = "F7336140849721938D40E21FA14404F402AA4FE7EE1253833AE89A4A7FFE8EDA";
		const string data = "51E806EEC93DDB4E0115BF6BF98E38B750A3747AC920CE2364C18D1BB59E776AB9A1D5B68DEFBC7F59414C741E3E";
		const string sig = "CA2804DDDC648193F4A43CF320E1DFDE73422D5D60CEB10204CE6B65B476BF5170FF759395B0599B0854B0B1F6F4B5E7DAC304FF22F942E878060C963A25FD0A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest67(){
		const string pKey = "C0FA590D5C7D85865F034E6CA954335104C362409B5BED31DFACEEAC905E2BDF";
		const string pubKey = "6458BF7BA1BF53D0B373FC636AC16B197B054103DC36A8DF7379741843540337";
		const string data = "1A3D7ED3E11D9EE3CE2BF3811BA3B8C8F09D921048637998782D942FBD2BCF5BEF60546FB6D4D9D06FE7E4";
		const string sig = "C957CE99B6DC7DFC01E53D979092DA129F87E88F6688A7787611848757016E24EF007A9D9DE95005B5A9805C397A20BFA17427EB509BAACEC4CA8789A0CE510D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest68(){
		const string pKey = "901D333913CEF4615A6CB51E40CA34A64E533E8775614764C5A8980A54E50440";
		const string pubKey = "51CE0DB007057AC7CF6296D5E8BD27AEEB25A8A04D40F1112AF91EEABD7FF3E5";
		const string data = "0D56822B276670290FF16147A8A85C22A9C511E0050D661FB5CB028B82FB232F88DFAAECB8795C1CC9634E6C";
		const string sig = "AD16683F1A3D3A843D2D5B6ADB9EC337DFDE8B2A3A5506C32899AABA519B935A1C85F2BB1A5E3CEC633FE12AFAA8C45B8D6D9BD28988A02D4839A1EF639F3102";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest69(){
		const string pKey = "FB78E363319A83A8C102788149349D976E5451D2DD36640CADC9A92DB95BE4DC";
		const string pubKey = "74BCB16DC586D43B6BDA90CFC1927811555E3A772FBA30B6E39C045291A2FCED";
		const string data = "5649AAFCF2064BCC904010466F9DBFDC4AA08ABF4B7E20A6EDA825538144BEB721B6AA6834A6654E60E6B6";
		const string sig = "FFF47B6C21CDD186C0EBB6E9C763BD2AA7D6572F297564F9BF88C06A44A0DCA1793E38984138D4CFD40B0B825D9F6BCCE084EA6F068B4B93270F50DF8FC34902";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest70(){
		const string pKey = "BED500236EC1F573823C48284026C3B6CCCC53C780A8BEB51FF963D41A72EBDB";
		const string pubKey = "E8A30D04A63E7FD518EB92E437C6737273DC602F013905B3A2321F391741B0F5";
		const string data = "69E09B4BBE374D59A5BB44F15A4FCA914D1DEFAA5D61806056490FD6F820621A890A38BDF898BCD6";
		const string sig = "599B4CA4B6FFAD6948086B094920D03122F925E810EC6B1E383F9A939B95A3924F9E2DBDD64E6B3BB8B9A32F9E58BAB418ADCB8A173AF32017B91A9535DA920B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest71(){
		const string pKey = "5CDF38FB1FC4491FDC7BB7A113BA775BE1D029C8BC91B743C399679BF70434F9";
		const string pubKey = "48129AD8D3997EA2ACCDEAFECC4FB0635715A83F980510DA591C5E2FED87C4C6";
		const string data = "B671BB8A610B45BBF79113629196F748860B474FFC3443E5C25AE2D0C9AAC16F4C73ED13E1BF17655C07BB431DC138A3";
		const string sig = "6FA952CA0EC7A74749DE7741E9C27F7428E63499BC3130446DE0E47E816D9AD8386EA427A352987DE1F5BBBAB542B5D1885E2A6C373028364D29B61856CFCC0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest72(){
		const string pKey = "E0138020F43450171D4A6446BA1CEC67213404DF3AF0F792D324F0C1D5EDB01F";
		const string pubKey = "5D221A4CAE7B7BC8B9E241BAB1F04E00205AE9E9CD703175B05F003D068B54AC";
		const string data = "2823306B0EE6733CAFE87BC0A40D82DC007EAA3FB9BB0610EF35524D472049E241AB8C1D487C9F57D2FEC64F";
		const string sig = "10A022F721E33C20BA7C9EFA4874889803EC4E776D36B2AA1AA81AACE7ADE9FADDF49813B15643E0DB3BA9ACB91A5A1BC6306056A08A1F3BF450A0365AFEC20D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest73(){
		const string pKey = "0BCD7DA5A908BB98DAFD0251E5F147758BEF4C10CCA8C4FD8687E28A3D35A82F";
		const string pubKey = "FC701985932A7FCD600053E87C3DEFE370513AB5963AE9B37D6BEB630E3488E9";
		const string data = "3079D831662AAB394453CBEC5457BDCEC3F345BBFE995D28A8B5687DCBF2FD40DE0139713219A2CF";
		const string sig = "5365D0A3B5DB75285DDDEDEC6EDDF2C48DB30F9355112693D58A753A637F7F8B8440143BD70584534FB29E195767143876A541A218228D6CB4CEC3019E4F180B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest74(){
		const string pKey = "62962129D2B1CBD1D53E8A916B94851324E0C81DDB3CDF188CBB8272117A2DEE";
		const string pubKey = "88030729446D0DDEFEAD3367CB81CEE63D0F88A9134BAD409D74D4C15FA8EB7A";
		const string data = "AB2E0D661E82C15CA0066C0AC27FA11D5D6434D0738ABD2ADAB0EACB552DA3426459C739F0D5BB9745C1A4";
		const string sig = "EB4FDF2AD8EE552974650E8414DCCC9780875EE47F06588B109C89736B8D93E10D700B3C15259C97F7E5D9D1ED7670E9750580EFA8C33BBD641D1CA42E440F05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest75(){
		const string pKey = "328306875BDE44BD21A072C168EDF2A16B399D8E8DFCE4A66439D4118E8CA139";
		const string pubKey = "4E6C6A2FF1D5EA68199BE4F5417E7E21851ABD823FFC2DE6C4980313AEE51A47";
		const string data = "FB85BB5AD2F506B73347F7AEE241681CC6AFB0E594F53654DB8DA72110E2B7F8793BD7997FB78EAD";
		const string sig = "46BEB7B070CBFD4533FD49B10DD237A3C4ED976DC73423FE3DA338662FBE2FDB90F104CAF712E3E5B6B70E1EF19B005E21E58221E12DC25963E89A55E7CD7E0E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest76(){
		const string pKey = "A96E4D19EF866388915FE04D2A2D770301E1A91B656C2F0DB71B3C7716BCFBF3";
		const string pubKey = "07E074EF64AE02EC65B0421A74E8868C584370005422884B3558FB6360612F77";
		const string data = "AF1E0E20AC69B95CB20612866AE7C62B401550260A931D114FDF38B21FA84ECA5D19D52E5836F2203B7A45D3D764F0858F8235";
		const string sig = "59F88A985908EA120BB71F34CD477B5E0ED27B2ABCF4F1B19E739E0CE3D1093C2306E6718122CEAF20E358C222D57FFFC5DEAA6FD2206D64C0380F9C4CA12603";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest77(){
		const string pKey = "95B74D8C9D7C199D6AA0141B237ADFE18AFBC9F421368B0F29901852674D6021";
		const string pubKey = "17AB1EDFCB71238603004B0E8104E44E09F0810D1CA589915831A26F871F8901";
		const string data = "3B4857F562B2DFEB3E6829827F197784634426DF1DAE143B49E6C954951AD7816370DB0CB2240C56E9D4";
		const string sig = "FE3C4A1FC084425474572A794BEB3E83F7B265FFF8FDD2B7022D9B1AFFF877500F0564DE2AD40A2C6F2B73C64D9CC430546F73616DD2709D00442DF5F623070C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest78(){
		const string pKey = "A7AAF052EA42574A5BD5555782390F8E9E7FED925307E8954FF7971C7AF5405D";
		const string pubKey = "54EDDA2AD0970E4E6991E6E823DB5278583ED80D5C42F3347EFB0860D06D0B75";
		const string data = "075BD25C6996ACE1678ED20E00A3552A368CFCD45D966D87AD288BB9E05A200A5D36ABF815CF30D06655D3E31840850475F3";
		const string sig = "8A13C9E9FD48799B227AC2E0F214DFE5B1A5686F0DC15DB10E2FFD8C9684AEB670DD956A612503FF1873FC9ACF6E57B71DD3F1856820E4C9CBA91E08F4143E03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest79(){
		const string pKey = "EB44B44C2A6BEE51CD45E5B137A803D52B37610ABD6C933AB9AB21E83C3A7973";
		const string pubKey = "A2279D6DDC9C16D37A7A45099E22AFFA5DECD8262FD23D30C0E052E017B9603C";
		const string data = "5A48A9F78D8ED36546237696F486F3FC340B0B875979E962A4EF7ACFA969174589D7BC6EB34745B2D938E9B4CF31148005B0";
		const string sig = "87DC26681556A81487A05AE4A8B9321D35797820D0A37D12EDBA5BA7A6A8CED18A32DC8D52C252D90571B75D5698838D91EA59BD5731782EC721D0CD6F825B03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest80(){
		const string pKey = "052BCF210594FC94FB68324A5F43245504FDB4A5510630115E530C3AB8F8C24E";
		const string pubKey = "269F9F187D1E33986BD3B80D19B875C457B98C5225C4B96A321420B348BF8BEF";
		const string data = "4E70933AF05CCC656BC2B341A31B6D891068FDC1E9EB64669B534079E9F9D5F386E5409D11F2BB2758C3AD4C";
		const string sig = "15C851D264FD979A2B84942DE697223D721B0C73AD240FFDDA1B5839974301B7AFEED79481800883BAE9BBEFDD22029351665E7763B1A9702E25D026BC046C03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest81(){
		const string pKey = "B4883C684E866D5B0C66C753477F429CA2230600B085EDC156928BA99B98C98E";
		const string pubKey = "15554BC42C22EA35C6D4C1EBA5988C0F15A5ACAB1F54482D882ACC05732AB7A7";
		const string data = "55C12DCA9BE62B57F4D53016C43BB6DBD09EB8DD467E41EE676290E5801798A5B3E348075C3E91B9";
		const string sig = "E2B48B1EA7CF98C8152FD836ECF017DAF8598D12DD6F461D3F1D787AF1DEEDC362573D1041B15B9849EE2C68368EDD22F9988F69AC859301EED081336070AF02";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest82(){
		const string pKey = "E240047967ADB460094F2B515BE2F590A4C93A1F97488FE564F29176F2DB95F1";
		const string pubKey = "6E34CA96170C34B4DAC322D8927F768CD229CBA4C8E70EBE63A6C79387909EC6";
		const string data = "5827805FD9031B0EE8605B03EC448B415A3F744ADC12943C9E84E60FD133CAAE544C0101F2F267576B678F6E43121198B947A7";
		const string sig = "BEC637C03FFD03DD4E9E65F183B41C4CD63425B6248D065360E874EF8342257067909B7236AEACA07816FB4AFF0B0775E767FD9E657E48B2FE3848EDEE274301";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest83(){
		const string pKey = "0CEBB0A6F4343ABA85450BBB69013D1B7D92EA42525790DF61B05BCB4D87D81A";
		const string pubKey = "C75DB4F66A517E3DA54B8B511FCCF5A1B2DB0F25D76C465DA8713FEF97EF36B6";
		const string data = "CD7E66272F697D7BF92133393952BD5ACB24F14F5F66F2755F0CFD81A2A6782F6F32FD75E524E4D6317E5818D728771AEB3D23";
		const string sig = "FF36587898B60ECF81AEE3A61E64183B2659F241A2C4050E6D813413A39CA6C4D8F46F232E0C75B6702D35B103321EC687AA270D5447BF77170A126EF60D0D01";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest84(){
		const string pKey = "E83FE044F92C3F349A3E5FBC3BE0269E13E98A19CCC19CC2D29CBA931F649FDF";
		const string pubKey = "6820CB3225E06EC2C6857780C4C9052D64B000F140DFDFDCD8D34DBFA71F8BE0";
		const string data = "1081E428CE82FD8A7EDB75DE2C3AA0A701B4F0C36476A52A8CCFD8C6EC5F5B41D3C28AF6A5BD1017EBE019E2378031FF1B";
		const string sig = "4D64EEEF21BC9D9697720746D24090E85B39A47C7E046C18543E8E7203317B8B782841073E427A2AFCAEC5BA7065F9733B7F18BD090DD65CFD987C3970C71F03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest85(){
		const string pKey = "1D3BE57CCCC3B433C5A85E3BB8C671BE8E26F70B8F1D23BA5E845C02417D9A2C";
		const string pubKey = "1E988CA858221BEF4203406F872630C16EE4BF84AD697BDBD5171F5AB8EE9F9F";
		const string data = "32DA83D92939DD7802BE226B92A63F4CD91ACB3A25D0129271957BD6804AF02974883478FE52FABA92253E31CA98";
		const string sig = "156A81603CB75C3910D62947DF2B7C3512AD212E4F1875B76C97890F6EAF455664E0906B5935A55E08911B7B29830DC6C82398C22A36209F1BCED2F94726910D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest86(){
		const string pKey = "96AC795DF13BF62ED986677FA5D27D8B162BC8F00468AED06FEA3074A4F2971F";
		const string pubKey = "8B732F8248F1FA36201243B1DFB14713FE9CA0AD68964C09AF8380C094050F13";
		const string data = "47BF91FC6F3EB2FAD7D8E230E347AA7E734D63F9E73C863934B83E7AC4DCA386AE605CEF63D901FF57";
		const string sig = "730113BB2042DF8CF866F051BCF9D86A91AD155E9B9C7689F12FA84CFD5DAA0492BF9A736B139BE5B6F3FD6A3E35A918180A5A70E4ED3B935443A6D30C37E80F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest87(){
		const string pKey = "A65F9AAFE4121F2CB73BD692F1ECA62AF02955DB5506D5A6B5FF8A0609B911EE";
		const string pubKey = "5DEF0B5E3590359D88E9570C83296248F4586FC0751E86CFEAD1EC6903096339";
		const string data = "5F91D02155A4FC170ADE24A348B3451DE285526933564D6D71759A8C46CEA1CC34378054C7158951E5F6F4AF68";
		const string sig = "32114FC174E627840DD700875DF30BB313CEC7FD73DCA98258F35819F13C6C9349A8105BFC946D498D2D306B6C4CCCC413D38ECF55C858DA34C07F3F6224CA08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest88(){
		const string pKey = "A00F90870EF0D049B91AFCE85DA351001E7590341BF7CA263A19936EFC3F503F";
		const string pubKey = "EC2F3E589E62FEB22F58FC4D322D6B0793DC1F489BC62FE2096DCA2AB0C21100";
		const string data = "3CAEA495F508587E6220D0FED1BF683B702C0E2C325B8BB9902479679ADEDA47648A3D932F7558A89D87E12FA561B1BFE8FCB7";
		const string sig = "42B795770A8E50121D2A7E8E110A1FF022AA090FC3CED6E13656D785EB4AE03D58B2E6AA6DA74C7C8F8F8D7D81E1634F74E29F2E742FBF093C6A5581DC5A2C0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest89(){
		const string pKey = "ACC4208A7DA43F2BD6EC23C09B608EF8C2D6A4732F7BE6C9278936065D5EA51D";
		const string pubKey = "4BC339C558CCA6BC3CCE068CBAEA4D84227737B7F56B1D32B1E82E8F7BE98012";
		const string data = "25FA6E8A46C02EF5501186E27D876C14CEB2CE9E591A121894C5F4CF1CE2C7D7BAA77DFC0BFF00D06CA47A9E7E3EA6";
		const string sig = "CDEBC4DFF87D46FB6299D7E397F0164E301C47F2EC2FCCE8B9FE11CF05A4C4792AB84B2000193F5A31EED2B179B3285F482103BC2B71520E2E91B30CDD8BAA01";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest90(){
		const string pKey = "4CEED036C390909CFE6DB9483431D8D242AB1B8452217DF32370CD2A3EB90E1A";
		const string pubKey = "CB272645BC25DBDE74AC05AFCDC6A78B95EBCB4A6651CD5FC569038E2F536F67";
		const string data = "71741BA7BBD422CCEF1B42FD183E4DF1C74AA78ADFA5FD49860CF572F8CCF8D016949913306BA5886376F68BCA";
		const string sig = "691E1308EF1837011032CB1AC4C91FAF138B1EB5B430B1E927159805FE098CB214FDD479177613D2CDC3DBE1C9002175289B55A763761194337F7CD19FAEDB01";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest91(){
		const string pKey = "7611E68D8B7ADC81E924EB4E274B1A8E1D48FD46A6FD3756B8709977B37BF332";
		const string pubKey = "D35A2BFFE381F2343706B008122BF9AEBC3487154D9ADA6003F3FF0856F77030";
		const string data = "A22AD42F959183F27B2EE67DD2FD5422AAE2838BB133D87634764AE9D47E51DD1A5016A1C2A0EB1653AA6F27F499";
		const string sig = "6E7EA8F42361E7958C9CFE45B945E2F543FB016F47A36F1B83649BB56E025BC05045A69A9748D280C5E7B95EC0064D365D5E0116F44C3AF5663D07FE92566D09";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest92(){
		const string pKey = "DB75731AF82D837C4A5309DFD9AA61F36669AB3311B2CE946A13F4922A802ABF";
		const string pubKey = "5D77338934D4AD607FE5B27260458FBFC4CFDB47524135C3E246915CE4932E8D";
		const string data = "5C5CA712CF93561C3DF00C996F685DAD2FF00178A1BE5D83D15B568A5B80D38F1E67DEB5F20F3AFFC37E8ADC38CEACE8FB8E";
		const string sig = "2071DA29931A120F389DEA9C90F0AF82AA6BE0A474F9231D0A9731763520B4F1A2608D9ED4D897C35B78991A654F5057FA06377FED078A2EA6B52A37F5C5F30E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest93(){
		const string pKey = "8D0B67C2A2BC6D43C2EBE7E522BB526CD63A140552411FD9D3BE92369E22F4D2";
		const string pubKey = "5EA02D9431FA64162D7ADA031741FA1AB19A5791B85A7148A03CC33CF23A96FD";
		const string data = "C3417D98A65E66C8AEF760810EBA037B004CA47D1A211EF90E0AE4AD48B687DD2396828BC751EB5888C539D945F1DC6AE4FBEF";
		const string sig = "9A5999F578D6E9DB6F95CF168979569B258EED2E7CA7B0BF19FC57B0E188771179180096C559C1396659924672435C61E377A88A7CC5BD179B112D0E749D6306";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest94(){
		const string pKey = "519CF6115E3C7DC1351831096BC03C02A076F3FDC4A935C2830E8C5261C2CE78";
		const string pubKey = "53BFA7DCB5FCA69E8F562E04B6DC89A164F62403167331C8E45CFE1007D0CE3B";
		const string data = "6447BE163BA795A7EE780072E63DCA3E2917FDDE2E921448C646D96C9B6E9E76215E4D7C26E3884DC71BA642CA23EAF7468E";
		const string sig = "105FFC243FD18AE0B625F1CD048DCF77F24942E11627CEE0A3744BEBF697852290EA7CCCD32B725DD3354811320632F6F3EFFBB0518F70075A631CA5BD0DDF06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest95(){
		const string pKey = "04C90BBD85F5E643D0FD4FA31C1163F85464668CF293ECB7ACD76D01100AA9DA";
		const string pubKey = "B3A7B798E4ADF3161B9F71B0738DCA38A28A1AAEE0C1711BE69771D3BBB98BB2";
		const string data = "880271C34B55E5CCFE454019DFAAD11A18A10C4B21D74401D6480608E79F8E3FF321DCF6FBDA939334D54AEC";
		const string sig = "67A12E32DC41BD399E72E493F6C8563187A616F8989922E712B7BD96FE87D96B5D2A07100F7FA720C26243D9EB7C1930CF23375984D6C9DE03A4C342E5CF610B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest96(){
		const string pKey = "C4F72790F1E365E0A99CA4A05A97343185A50CC5ECB88CB70BF9171EFD1A7F7A";
		const string pubKey = "4FFFF4EB1EDBC81F1CA5B10C7E65B9C62F8FE8F6221A6E65AAD6E332BF4BBC2E";
		const string data = "D1686F5004566364F58AE24EF2886CE55E12D0A8FE26ADD43C0B41271EBDCABA823B02D56C4491FA91E4BCA1399D915236";
		const string sig = "3CBA3DB501AE0770DB484FBA50617A1611DD4F9062D056D3ECA67F7D05538137FA37DCBE760B4BE176D8D97FA04203013D66C1DA07AB7B89C946361E0227880F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest97(){
		const string pKey = "26E33D9476F5AA6F5471F5B00B3EACE30828C5063A45E3C7DAF383ACE9472880";
		const string pubKey = "29DB23001BBA6A3CCB1172F8DC15D66025FBF824E38BC9BC1C9E4FDACE9A7D14";
		const string data = "9D46CF217ABB40142861E947DE60D174FC34B106D9A049590BF0320560A388B0A39FEC4906C691691107C71343AF1880322067";
		const string sig = "1F60371E0B998A78E6BFA9855BE439393F7F94CC7A87C72521F460080B8A7414C5FAC22BBEEA105B352014995268CA2EF3A17B5BA30BE3780232483EC64FA90F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest98(){
		const string pKey = "7331C098B14761F582694EE54FA7218EA516C22F7FF91201E8F03C440E1D185B";
		const string pubKey = "1CEF1D171F1706D56E4340FD8DE9AD99DD718928D96D201B13EB9C7FF8102387";
		const string data = "DC55A1811819FF75A98DD078CCC432D718B7260842C492F0377B65D846BA0BB3760FF42B1D34DB6BAD4CB8B2A0E669178D37AD";
		const string sig = "DD8B2AFB3CCE85DBDB1E105713218C8F5BB7465C4FA2C5DC2BA91152425FF7AA5B473C1AC7D7DF6ADB3F3400A1E6810ED562D67D7E5CD24B963254938155BC03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest99(){
		const string pKey = "8CAC50F5586F71BA46825F2BA8B0548AE46DD553A0A3BEA2F9FFEEA9F021D5A7";
		const string pubKey = "EB95A590F42671E3516E9F9F015B781CA586CCA1584FBB86A95ED349CC18CDAD";
		const string data = "5DF2AEB28226903EA995D456CC07F6555B25614995B59EE7E4B93C8B557D722638146AA48A6BEF64B8B334";
		const string sig = "4B8026776E0675F15F23A15643311B5A4A41B0FF3D5B1B3BD2FB4954EAFB87117D0BE6F95637A41EF2734D679F540FDE3E6D21E55C36E95C83444E521948E10B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void AddressTest100(){
		const string pKey = "913D0740DA5D0DC5ADEA97E7675F771BF2B7F28A509C9D2FD0D9F02CAAADD0E8";
		const string pubKey = "F77180BC426B974302C21772254A1BA69677C4B11F3E46678CFB97BB3FAC9D79";
		const string data = "B7CC179962B553F78B28379B7DDB20D801715FC1D3C7EC33FA7A8E47208508D9AF84C1549755CF9E93125CC65E898D02C5FF";
		const string sig = "6641BAF99916F55D914EE99D8F03CE5B5DF86CA069F947472B60632133360B88E662C9241942C3FA2D7A6D8709079E8D247369686086CF3E3F5004394AFB6F08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
}