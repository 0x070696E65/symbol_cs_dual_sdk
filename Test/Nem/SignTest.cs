
using CatSdk.CryptoTypes;
using CatSdk.Nem;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Nem;
public class SignTest
{
	[Test]
	public void SigneTest0(){
		const string pKey = "ABF4CF55A2B3F742D7543D9CC17F50447B969E6E06F5EA9195D428AB12B7318D";
		const string pubKey = "8A558C728C21C126181E5E654B404A45B4F0137CE88177435A69978CC6BEC1F4";
		const string data = "8CE03CD60514233B86789729102EA09E867FC6D964DEA8C2018EF7D0A2E0E24BF7E348E917116690B9";
		const string sig = "D9CEC0CC0E3465FAB229F8E1D6DB68AB9CC99A18CB0435F70DEB6100948576CD5C0AA1FEB550BDD8693EF81EB10A556A622DB1F9301986827B96716A7134230C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest1(){
		const string pKey = "6AA6DAD25D3ACB3385D5643293133936CDDDD7F7E11818771DB1FF2F9D3F9215";
		const string pubKey = "BBC8CBB43DDA3ECF70A555981A351A064493F09658FFFE884C6FAB2A69C845C6";
		const string data = "E4A92208A6FC52282B620699191EE6FB9CF04DAF48B48FD542C5E43DAA9897763A199AAA4B6F10546109F47AC3564FADE0";
		const string sig = "98BCA58B075D1748F1C3A7AE18F9341BC18E90D1BEB8499E8A654C65D8A0B4FBD2E084661088D1E5069187A2811996AE31F59463668EF0F8CB0AC46A726E7902";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest2(){
		const string pKey = "8E32BC030A4C53DE782EC75BA7D5E25E64A2A072A56E5170B77A4924EF3C32A9";
		const string pubKey = "72D0E65F1EDE79C4AF0BA7EC14204E10F0F7EA09F2BC43259CD60EA8C3A087E2";
		const string data = "13ED795344C4448A3B256F23665336645A853C5C44DBFF6DB1B9224B5303B6447FBF8240A2249C55";
		const string sig = "EF257D6E73706BB04878875C58AA385385BF439F7040EA8297F7798A0EA30C1C5EFF5DDC05443F801849C68E98111AE65D088E726D1D9B7EECA2EB93B677860C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest3(){
		const string pKey = "C83CE30FCB5B81A51BA58FF827CCBC0142D61C13E2ED39E78E876605DA16D8D7";
		const string pubKey = "3EC8923F9EA5EA14F8AAA7E7C2784653ED8C7DE44E352EF9FC1DEE81FC3FA1A3";
		const string data = "A2704638434E9F7340F22D08019C4C8E3DBEE0DF8DD4454A1D70844DE11694F4C8CA67FDCB08FED0CEC9ABB2112B5E5F89";
		const string sig = "0C684E71B35FED4D92B222FC60561DB34E0D8AFE44BDD958AAF4EE965911BEF5991236F3E1BCED59FC44030693BCAC37F34D29E5AE946669DC326E706E81B804";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest4(){
		const string pKey = "2DA2A0AAE0F37235957B51D15843EDDE348A559692D8FA87B94848459899FC27";
		const string pubKey = "D73D0B14A9754EEC825FCB25EF1CFA9AE3B1370074EDA53FC64C22334A26C254";
		const string data = "D2488E854DBCDFDB2C9D16C8C0B2FDBC0ABB6BAC991BFE2B14D359A6BC99D66C00FD60D731AE06D0";
		const string sig = "6F17F7B21EF9D6907A7AB104559F77D5A2532B557D95EDFFD6D88C073D87AC00FC838FC0D05282A0280368092A4BD67E95C20F3E14580BE28D8B351968C65E03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest5(){
		const string pKey = "0C066261FB1B18EBF2A9BCDEDA81EB47D5A3745438B3D0B9D19B75885AD0A154";
		const string pubKey = "2E5773F0E725024BC0359CE93A44E15D6507E7B160B6C592200385FEE4A269CF";
		const string data = "F15CB706E29FCFBCB324E38CBAC62BB355DEDDB845C142E970F0C029EA4D05E59FD6ADF85573CF1775";
		const string sig = "13B5D2DD1B04F62CC2EC1544FED256423684F2DBCA4538CEDDDA1D15C59DC7196C87840EA303EA30F4F6914A6EC9167841980C1D717F47FD641225068DE88507";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest6(){
		const string pKey = "EF3D8E22A592F04C3A31AA736E10901757A821D053F1A49A525B4EC91EACDEE3";
		const string pubKey = "72A2B4910A502B30E13A96ABA643C59C79328C1BA1462BE6F254E817EF157FEE";
		const string data = "6C3E4387345740B8D62CF0C9DEC48F98C292539431B2B54020D8072D9CB55F0197F7D99FF066AFCF9E41EA8B7AEA78EB082D";
		const string sig = "95F2437A0210D2D2F125A3C377ED666C0D596CD104185E70204924A182A11A6EB3BDBA4395BBFC3F4E827D38805752657EE52D1CE0F17E70F59BFD4999282509";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest7(){
		const string pKey = "F7FB79743E9BA957D2A4F1BD95CEB1299552ABECAF758BF840D2DC2C09F3E3CB";
		const string pubKey = "8B7D7531280F76A8ABAC8293D87508E3953894087112AE01B6AD32485D4E9B67";
		const string data = "55D8E60C307EE533B1AF9FF677A2DE40A6EACE722BCC9EB5D79907B420E533BC06DB674DAFBD9F43D672";
		const string sig = "C868ECF31CEE783FE8799AC7E6A662431C822967351D8B79687F4DDF608F79A080C4FF9EED4FDEE8C99FE1BE905F734CAE2A172F1CFDB00771625C0695A5260E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest8(){
		const string pKey = "8CC9A2469A77FAD18B44B871B2B6932CD354641D2D1E84403F746C4FFF829791";
		const string pubKey = "AED5DA202D4983DAC560FAF6704DC76AC111616318570E244043E82ED1BBCD2B";
		const string data = "D9B8BE2F71B83261304E333D6E35563DC3C36C2EB5A23E1461B6E95AA7C6F381F9C3BD39DEAA1B6DF2F9";
		const string sig = "AEE9616DB4135150818EAFFA3E4503C2D7E9E834847A4C7D0A8856E952761D361A657104D36950C9B75770DED00D56A96E06F383FA2406BC935DCF51F272300E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest9(){
		const string pKey = "A247ABBEF0C1AFFBF021D1AFF128888550532FC0EDD77BC39F6EF5312317EC47";
		const string pubKey = "98EDEDBAD1E5AD7A0D5A0CF4FCD7A794EB5C6900A65E7E921884A636F19B131D";
		const string data = "4A5F07EB713932532FC3132C96EFDC45862FE7A954C1D2AE4640AFDF4728FB58C65E8A4EBFE0D53D5797D5146442B9";
		const string sig = "F8CC02933851432F0C5DF0B70F2067F740CCB72DE7D6FA1E9A9B0D6DE1402B9C6C525FD848E45AAAAC1423B52880EC3474A2F64B38DB6FC8E008D95A310E6E0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest10(){
		const string pKey = "163D69079DDAD1F16695C47D81C3B72F869B2FDD50E6E47113DB6C85051A6EDE";
		const string pubKey = "93FE602642EE5773F4AAF6A3BC21E98E354035225353F419E78E43C3EC36C88A";
		const string data = "65FE5C1A0214A59644892E5AC4216F09FBB4E191B89BFB63D6540177D25EF9E3714850B8453BD6B2B6";
		const string sig = "DA747FA2CB47AAE1EFFC1E4CFDE0E39FA79937948592A712A7665BF948B8311E7F3F80F966301679520D5C2AFA3EADD60E061F0D264887500D8D03A17E10FD02";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest11(){
		const string pKey = "7B061BF90EB760971B9EC66A96FD6609635CA4B531F33E3C126B9AE6FDB3D491";
		const string pubKey = "CB392EBB6912DF4111EFEEB1278160DAF9DA396E9291B83979A5AC479F7276D2";
		const string data = "A17F5CE39B9BA7B7CF1147E515D6AA84B22FD0E2D8323A91367198FC6C3AFF04EBB21FC2BDBE7BC0364E8040A9";
		const string sig = "F6EEBE86F7EA672E0707EE518E1798D6FBD118C11B2AA30BE07D10E3882E3721F2030F9F044B77C3A7A9A2F1FEBA7E7CE75D1F7F3807A96A764FDED35D341D02";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest12(){
		const string pKey = "C9F8CCBF761CEC00AB236C52651E76B5F46D90F8936D44D40561ED5C277104DE";
		const string pubKey = "A3192641E343B669FFD43677C2E5CD4EFAED174E876141F1D773BD6CFE30D875";
		const string data = "3D7E33B0ECEAD8269966E9DCD192B73EB8A12573FC8A5FDFBE5753541026EF2E49F5280CBA9BC2515A049B3A1C1B49";
		const string sig = "D44F884EC9EAE2E99E74194B5ACC769B7AA369AAAD359E92BA6FF0FE629AF2A9A7156C19B720E7DE8C7F03C039563F160948073CAB6F99B26A56A8BB1023BA08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest13(){
		const string pKey = "EBFA409AC6F987DF476858DD35310879BF564EEB62984A52115D2E6C24590124";
		const string pubKey = "7BB1601FE7215F3F4DA9C8AB5E804DC58F57BA41B03223F57EC80D9C9A2DD0E1";
		const string data = "0C37564F718EDA683AA6F3E9AB2487620B1A8B5C8F20ADB3B2D7550AF0D635371E531F27CEBE76A2ABCC96DE0875BDAE987A45AC";
		const string sig = "F3E7C1ABFCC9F35556CB1E4C5A2B34445177AC188312D9148F1D1D8467EA8411FA3CDA031D023034E45BBE407EF7D1B937BFB098266138857D35CB4EFE407306";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest14(){
		const string pKey = "F993F61902B7DA332F2BB001BAA7ACCAF764D824EB0CD073315F7EC43158B8FB";
		const string pubKey = "55FC8E0DA1B454CAB6DDEFB235311DB2B01504BF9AC3F71C7E3F3D0D1F09F80B";
		const string data = "B7DD613BC9C364D9EEB9A52636D72BC881DFC81A836B6537BBB928BFF5B73831358947EA9EDEA1570550";
		const string sig = "178BD147673C0CA330E45DA63CBD1F1811906BD5284BB44E4BB00F7D7163D1F396975610B6F71C1AE4686466FAD4C5E7BB9685099E21CA4F1A45BB3FCF56AE0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest15(){
		const string pKey = "05188C09C31B4BB63F0D49B47CCC1654C2ABA907B8C6C0A82EE403E950169167";
		const string pubKey = "E096D808DFABE8E44EB74950199DADCD586F9DE6B141A0CE85AB94B3D97866EB";
		const string data = "BB8E22469D1C7F1D5418563E8781F69ECCB56678BD36D8919F358C2778562FF6B50DE916C12D44F1A778A7F3";
		const string sig = "669491C8EB7CEDBBC0252F3EAFB048B39A2A37F60AC87837777C72C879AC8B726C39E10060750C2F539102999B71889746111BC5F71EC8C158CC81CF566AEF03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest16(){
		const string pKey = "EABE57E1A916EBBFFA4BA7ABC7F23E83D4DEB1338816CC1784D7495D92E98D0B";
		const string pubKey = "3AAD275642F48A46ED1032F3DE9F4053E0FD35CF217E065D2E4579C3683932F7";
		const string data = "3F2C2D6682EE597F2A92D7E560AC53D5623550311A4939D68ADFB904045ED8D215A9FDB757A2368EA4D89F5F";
		const string sig = "B2E9DAC2C83942CA374F29C8EFF5A30C377C3DB3C1C645E593E524D17484E7705B11F79573E2D63495FC3CE3BF216A209F0CB7BEA477AE0F8BD297F193AF8805";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest17(){
		const string pKey = "FEF7B893B4B517FAB68CA12D36B603BC00826BF3C9B31A05149642AE10BB3F55";
		const string pubKey = "B3FB891868708DFA5DA5B9B5234058767AB42C117F12C3228C02A1976D1C0F83";
		const string data = "38C69F884045CDBEEBE4478FDBD1CCC6CF00A08D8A3120C74E7167D3A2E26A67A043B8E5BD198F7B0CE0358CEF7CF9";
		const string sig = "6243E289314B7C7587802909A9BE6173A916B36F9DE1E164954DFE5D1EBD57C869A79552D770E13B51855502BE6B15E7BE42A3675298A81284DF58E609B06503";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest18(){
		const string pKey = "16228BEC9B724300A37E88E535FC1C58548D34D7148B57C226F2B3AF974C1822";
		const string pubKey = "3C92423A8360C9A5D9A093730D72831BEC4601DCADFE84DE19FC8C8F91FC3D4B";
		const string data = "A3D7B122CD4431B396B20D8CC46CC73ED4A5253A44A76FC83DB62CDC845A2BF7081D069A857955A161CCCF84";
		const string sig = "6AEBFA9A4294EC888D54BCB517FCB6821E4C16D2708A2AFE701F431A28149FF4F139F9D16A52A63F1F91BAF4C8DEA37710C73F25C263A8035A39CC118AD0280F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest19(){
		const string pKey = "2DC3F5F0A0BC32C6632534E1E8F27E59CBE0BF7617D31AFF98098E974C828BE7";
		const string pubKey = "B998A416EDC28DED988DCACB1CAF2BD96C87354B0D1EECCB6980E54A3104F21F";
		const string data = "BDAE276D738B9758EA3D322B54FD12FE82B767E8D817D8EF3D41F78705748E28D15E9C506962A1B85901";
		const string sig = "76A2DDFC4BEA48C47E0C82BCBFEE28A37C61EC626AF39A468E643E0EF9F6533056A5A0B44E64D614BA3C641A40E5B003A99463445AE2C3C8E1E9882092D74B07";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest20(){
		const string pKey = "3ECB9CE7A3C4477B8324D787E94475CBE018A95140447AB7EDC4E87980171C92";
		const string pubKey = "85EDB88E57670537E354DD7AEAC53C8606119988CAC9B57BC6626FD799F1F321";
		const string data = "19C3797889404967A54C91A737738400FCD4F4FD1C5EBEFCE1A5694B7CEDEB6BEA395088ED38F83A";
		const string sig = "2B0763894AC409803E1D176AE656A7447CF0273E45E434ED2299EFED0436EE4E844A7A3D4621981E0887053D62D651CA113B22CA5CED72B87176DB56E9C3EA0F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest21(){
		const string pKey = "3898C88D44091FE30A6E58D67BF5641E9D7CB3186D085EDB9EE05F6E7A79EA50";
		const string pubKey = "BD8862E9D85BABF4268F30374CB790927555EBD0BB1FAB5F9B6F253B7F4E260D";
		const string data = "FCB7A3B57B2E22069F22ABDB6DB6DD467BEEFFAD0F3B74A999BAEE14831AD517E0B536152151B80C8D3D7C407F9CB889A52C06";
		const string sig = "F83ED8B174706B90C32DB15CE83C5C4669F4213A94D062B962694ACE58ADA44FFDACCA48EE877A798FBC4234CF7982780D18217C332393402B8EFDDF52319907";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest22(){
		const string pKey = "5DB7FE111A7B068ED616D82FE649CA2CC08825960F2FA1D941B4347B344E8622";
		const string pubKey = "1D21AB614624E7C6F1AE298F60A4112E5CB322C3CFD20C5D3B56E751320F2CD6";
		const string data = "10E6253361F0102A1090EB861F35F6764AE71FA0ACC46E3CA0632C5B7C65017AC3C3E05894F22CEA18B37E6FA28D219874C9";
		const string sig = "9A72AE509C584ECDD7908C74AA7AF59FE00C26FDE1E4EBF9BD7C1D8645AC9EA43E2B6710B69B27790FE2BDA07106622740E0C150B15749CA1A2170EE9DD1050D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest23(){
		const string pKey = "5854F9B2A283AE951945CA5E151E46DE7F54B3612D5D590AF7C097D842DB399D";
		const string pubKey = "896C28F790D85306F379381B9A4A0F9D58CC389B25D206596CDAC7C45258AE03";
		const string data = "2AC0A5C801F0DF0A7D9C66DAA3EB6F1231298700D628585D9295505408E799B3EF7B5313E9AB26554CCFBFDAD4EA7BAB31F46B50";
		const string sig = "CA6CCE7451ABFFD4A0777F6880830F04511B315F38D120CD65C685BC734ECDFE59151F7BDDFA153AE8F93248BDC244A2093509D842FB740118E78E2B40D49608";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest24(){
		const string pKey = "0C3ED7A3E226754E03A90CE8E2918BD2EC622E0B258E69F98C8B7A09543A4D5B";
		const string pubKey = "01A729345D34DE0023CA07FD5FC562D233963C4CAB72A3D65537892ADA7DAE62";
		const string data = "FF60983E0C5D21D2FB83C67598D560F3CF0E28AE667B5616AAA58A059666CD8CF826B026243C92CF";
		const string sig = "E546D2133A6F54DE604509DB681F1618AA50555AC081110FB4014B49C197C7A868BDA1746481F5FC0B5D21F8B1FAC034AD68D606C9B0548ED100C77DE68FAD06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest25(){
		const string pKey = "C90C193DAC26E6172462F212B5D3FA11406434496C7BF72FDF71FB4E9840BA44";
		const string pubKey = "A51650BE1FF08C9B9A5D45EFC12ADA5AD2040DFC57B52ED628C71F88FEC3AAC3";
		const string data = "337E7CDBFF240042C778A8E6DAAD5690A47BC852087735CBDC3E0321ED056BE3EE4F6979BEF147BF59F9227AFB";
		const string sig = "DBBCAA2699619917053B207A176EB2EC58E1A997D1BA0A1711A2B0DFF4C146F57EC77F32560697702C406A4ED8F2F053F43F4C0B92DC9E12C584414E3A6DC300";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest26(){
		const string pKey = "E3653151EC7882D6C6CB3DF83717374DF447DAE66544842AD354615B37D7B134";
		const string pubKey = "B961F0F906574E21CB2E369F94243C2C719332119EC6DCB9BF66F78A7199A9C1";
		const string data = "17448B36DF681C62A79C2D8C95B7AF3BBE4C8951DF3E47A940C5D343B2A81BAA589F63B6D00D82918B5B3B0BC80447F4E2B39F";
		const string sig = "DF3FF2DD0F913A2905E7436DA21AEEFE12998A51A9641689EEEAFED5BE68F2BBDDE20739B4AF27913EF660D7339DA66FE0823E4B49D529C5B6C838519A18F10A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest27(){
		const string pKey = "43C74F8169896510718540B6D90C02EADAC289EE44A6EAEBD213DE9D951667A9";
		const string pubKey = "2B64C18FE99780E12BE05B5E3A99712DC54FCE16CD13D66ED2B1B88F2EB31947";
		const string data = "F8D4D3CA7EEA8F20E24D155FB00D45639887F014D8F0A5D557AFEBA99625F360921167072B6C3A1078";
		const string sig = "42A245AB18C330DB0B70BC1837AB8A4162CE8E657742F73AACD89F668EC0385DA3ADE18A55DFB493C6DBE40EEBCBF0CB472FE3BD1C6B2F6B2C4C386994E62C06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest28(){
		const string pKey = "DAB6E9D455178FAA8531518A30565AD0ED5C0E1E00029A572DB990B4E922A5D8";
		const string pubKey = "01F529B5DC95545F7951D5BD47FED72DC1006DBA09DD9B6193E4127FBBAC572E";
		const string data = "6C0611A6F2C768F84B2D95C4DC6487EC7D73AAA804B5DF50719B86A26AA8CAF9AA71C624240FACFE22";
		const string sig = "51DD9B8C8A992583214F14935AAE8B820F04B6A6C87B4641954BB1D94B0B96D3358884652BC537B1434C56CEBEEA40E874CDDAA98D2C87143035D1CA8F16F304";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest29(){
		const string pKey = "97E825A1780F32227539EBF3D032E390035B50A6E13CF6174D259B33F1F327E5";
		const string pubKey = "8346CA23363796B5729CC28A9A1A0911EA497E0382AEA100CF57696383E40393";
		const string data = "23F47836AB60E6258A5B64909B422D7BB305745D3D01DE7BA8D0A167F134AE61A4E08E11C5DF327EEF1D";
		const string sig = "52532E7A6594B926BE0EA5A186BA6A72C8EF55C9BE42BDFA41DAE882D4CF801C7C6F882972FA36017CD33AB4C587248EDAB6947C68D688E91FA28A4538590F03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest30(){
		const string pKey = "8230263C82F79A5DE3E309C084C369A13DBE7E66540A6974435080606B9004C9";
		const string pubKey = "2F3288B9FFE76EDD9827923263CB2A20F2B2BA832992BC64E2E7D5885961BC66";
		const string data = "AF962C1BC29FF028C8B8FD89827219536D90D60F6E427C3E6E3BD5E7712B8D0A8052F32A7986B249E1331D";
		const string sig = "8C48741C5A27C73AB216E4049B3F384A6E05E8FC335812FB0F14E998685CE81C009D31786E7D3C2134D202901DB1036AAF79C08179C1224E3A28F54DE30DD606";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest31(){
		const string pKey = "43D74BB830C268519BF5C72FB5EBBEBC7CDA14B3D787B005FC2038EE6F292497";
		const string pubKey = "870262772B18B1565071318D8FD23E7144ED1774CB0A8D7FA77043767BE61092";
		const string data = "F88D70F62102CE63AE2921EB8F930B849F7D4732C512E03EE1C8B05AB3E2EFED5DEE2B1893CB0A3FC13D";
		const string sig = "3BD0B6369AE8ECA6B4F4925B97FE1603964E1541E9B53B2C991612A074FBE2F2A9CBB39FBCEDCC4C25B17BBF133EBFE993DC0B5F4A24A85A749CC5A2567C6406";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest32(){
		const string pKey = "AA43BC3208F01D29E954DE910B69BE07A33AC3F97424EBF51F246774BACEDE8D";
		const string pubKey = "9848D8AB2FB31998F6C8347FE0754121505C41C696A4A623FF814B68FAE4444B";
		const string data = "87D576C693E5528DC1FBD1CB96ACBE88D2BB71D9B8B73E7928BD16A8A71F0AE246BAE69F1241C6D7A009B7C691E5ECF639F4DAFD";
		const string sig = "4A368F280B7F837A3C22A7BE67CA1BFF3236E527091098B06D81C869E17C618984DD955860DC22BCF14B8DED7BC87DA3B274805ACB25DD0DB2214E0493154E02";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest33(){
		const string pKey = "E657D1D5E7789967B9366E1D3D1386CDEBBD8650EA0D6184D8E36B8853960B09";
		const string pubKey = "3508B0ADFD69A415BD230A433D0B71882DF3C7102917A964FA43B9B7556F93D0";
		const string data = "8017A5CD334DB855016599C74F7BA4BF8B9226CD343FF0134EDAEE2F10ACA0BE407B233986F0A6F02C633844578EAC3D28";
		const string sig = "0FCE68964A0A13EB449A2175484A14BDE19007310C87051EF76131BACB058702311C105BBD0A475D0A5F73ACC0659F946D05EDFFDE001F7242E8F3B73F712E0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest34(){
		const string pKey = "9D3F468B66925D1F5941F81CEB845F2BD75FBA1F1F3E510EB4C5C9C787181D01";
		const string pubKey = "6FDEA4454D90D1F8CF343BB31030AB5C99E75306A0F9CF978651C89AC9F7CE72";
		const string data = "6645AAFAD0AFD4D5B524EC278807E67F7C39529188D311515A1DC101CB46EEC0847D44870F473CC123244447B853";
		const string sig = "FB76EEDAA51F7BD0A7E0D7B2AF679C22A5838697F45249968D64AB48D64E936BC22FD203ABE598CBB3DB8043F4CEEEDB0964364131250ADB8D89B1114C91D905";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest35(){
		const string pKey = "42FED01BA1A2CD66368E1B04BF3C9A2585A8E9E0DA7EF41351F347F84B4588BD";
		const string pubKey = "43C1298085A086AAFCAC101608691EFD46C23F621DAE5B2A2AA53B5D56AE68BB";
		const string data = "E5BC834E803D8F55F9621DB8E79B94CD736C08BFC77155A6D3B1A8DE2AB73799665CD71BC7A1837CEB";
		const string sig = "65829873B706DC4A2E6E4E3BF9F1CDAD858AF2E377BF5AD31B1D052596AACB2AC28772D0F1BDAF1670C1FA388BFF720CA1B5D7378D7CEC51D44A04D159847A09";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest36(){
		const string pKey = "EA97113FD54FFA5E89B2623898A9399488D5215BEB325F0D91ED6FEBBFB492D2";
		const string pubKey = "4C774AA783D9C6A201BAC0C18052222957C03A94B710044569775F26FF4DC740";
		const string data = "9C248DF832A6F7A2E96776CB2CC0DDED477705790F32778023753541ED13BFF187C5168FD52535BF9B919F6144592BCEFD707946";
		const string sig = "32F95D6EF5EC95A4F6A7EACF4E4888C32366193565AA06C8E74E4975647411C9F4D49AEC0EE02EF375678F964BD8D145130C3AA43AE341E9BAE58C3F82E06C0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest37(){
		const string pKey = "4F9084EEBEEFABCCCFAA51504ADC698405738922BB1BD99CF9C4E5273CFC3A79";
		const string pubKey = "64C826BF9E4001305298BC637FBE7EC57479E584AE09DBF8CC3F5CFF8830C89F";
		const string data = "712F4DC51E20995F2DDB160FBAE4BEADCC916E1D54CF46EF4E2FA80EE44E781765919E2AC103E5110AF899FCC3466C72E9D6";
		const string sig = "D8DFB016A89ED7AFBE7B90C59174C6D58DBF189F3406BD1C52ED3636E5D0D061B6A69E8B288451DB3D9152337C626013D3ECC17A58CEAF9D55A70A28166C5E03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest38(){
		const string pKey = "4F9845AB197ADE1CE0C616380327A2FE1F39A29AC15CAB803299F54AC2C66B66";
		const string pubKey = "3BDC5CF0D81C18C06EDFFE7F149B0F6B2B8C883EAD717F72D5BF48076FCB27D8";
		const string data = "DC8C44894D5CC7A138A70C4326C82628C740A288C65247A213B410743E1725F58F4E1B97248BA372";
		const string sig = "BA7CE26F2B1F1FBD1A777AE9073645818609074D9AD12951CCE6E5E91CE7901D10A88FD85D2963B84084A4224CC36E7A380BBE41ECAC757B530B21433D02BB0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest39(){
		const string pKey = "7C0C9AC3B6B1FFA2BD7BFE6238499C7662D3B9508A629F8953C127AB64DFE063";
		const string pubKey = "300D4FEBD3629A45AC0EA671072359C68263E56756897B46DB5425C60DF6A5D1";
		const string data = "89D8CB99858E7FCA07479CABA3B0BE76C7E1BD536F1B8AC6828CBA6894F5AE3F83D69DAC4B48A1701257";
		const string sig = "2E08D56D98ED9DC9AB8639D805CA9D01B589BFDC1EC8FB2A17A0FEDF79654ECFA35D00A5860B2D05C090697D7B8C850C88AA50822F40D0407B7D1865C22D1C0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest40(){
		const string pKey = "E52F4833CFDDAD84065F8B60991111A1B8DF29EAB5C3D1AE0F76B7A29C1429F2";
		const string pubKey = "F5008DFEA5A4EF6DBC4C85454BFA1EF3DFE75F0688C6B3C72C0F3390C199D1F5";
		const string data = "6450318F4E7655EC8A8559D812A9621109498E83D0223800A2F51F25E3F7D6042CF11DDCFD34CDEBC2B1A52E140CCDD21A";
		const string sig = "A87CA9032AC65C5AC8B47A761DF86B1B22E4049DE21DF04FE57FBEFAA4BC73237BA90DA66FF9177137280F0D1DA5AE186B0986E13E62E7C62D1274FE814D8003";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest41(){
		const string pKey = "223CB09792B627A0DCB3A2844EEC76E739926EEAE51A54AC3D1B87B236DF7CB7";
		const string pubKey = "F2FFC77D8D98DF77A27D2DEA82462FF2629AE9910834E0C421A915A5B8073295";
		const string data = "50FB500789E1C6878D6796C4EFF83609BAD0A4D36CA236C9D6BDBCC9215BA298792788B2E031E43C0EE661DC5E";
		const string sig = "57CCDAD1D7A94B1FD0CE25FFC3B1931980EB80E45B79B2ACECC489ED07F957C858F52A4B419CE8F891E300634584B135CC4D2368EFE10154F90D0792B6FAA309";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest42(){
		const string pKey = "F08D123A754845A3FB735F3742F75C701B9A42F348CAE9FC59C540F52106A04A";
		const string pubKey = "E453950B60ABCF11EAFB3E4F54FFE914A6B793AE55686E38C0ACB8F49ED0C627";
		const string data = "E20CDE9087154A91BF18029C532449BBFD5083B932E3AC5853A712C8DBA2335EE028C017C55EE78A6819BED1";
		const string sig = "B971941EC51490015A84B58F1326086B1017E4B736C4202EF57D299319581223ED9082B8ACD4AA2DE602D93BCC4471FD31CCF33CC3A96B29FA7370425422EE0C";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest43(){
		const string pKey = "3CFC0D47DC90A51AE1830E23A64811827C7614F2839FF04A7FFB0FE41ACFE87C";
		const string pubKey = "9B2DFFE5377232EA6CCEF09D22F50C985CC5269A3E41C1D75F894B010AA45B40";
		const string data = "8B029AFBA7A9F0718DFAC31A322C2B04898A2C93513C7CE31DE57D8F4C756D5FAE841E38DFA49FA4A7795CE6DB1654";
		const string sig = "803F74B687B19AB7B69B1C3A4809D07741A6CDBEA28087EEA59C6064C5CA71B6C612B27F90CE603C65EC4C70D132FA1401F31CA8701AEC6BFFFCF144D5005203";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest44(){
		const string pKey = "4AC719DE0CB49B4D25795651ECDF64653A145CC0106602D97A33B7ABAA53E162";
		const string pubKey = "FF64543BE30FA1DC02B2CE20CA131B4CBE91BB716E939B1CEB93FA49061284C0";
		const string data = "F807FE986F54D6CDF987E3F200FA6E9D3F257CCD5BA8E5B06291907B3F640FEDA52D8264387E46EA6D18FF9D1110CBC967";
		const string sig = "0B0B97CA6A18147DE2B35EC41541DF1F321FA7BC64916D7C54A5FF568CB0C3EF96C7CCAD838713168BCC26CB2AE838F1135EAB8F699416D2113C568C07FE6009";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest45(){
		const string pKey = "9EC60BA468F1A537774E10F8BAB3909627D7A09D5EBCA86FB28903F4D740EC2C";
		const string pubKey = "F87C03929A01969B8BBD0FDB96217A69A7B357CDD12372F5C75001C356AB4525";
		const string data = "7283F37C2D42D621673875D529D36F755BB0149B54DA0D9DB45E1D703166E801C55DADCD72558C295660FF31";
		const string sig = "26B00F5F240138A9696CBECEC469F957A4B0569CC303453284D354B34D5BB6CC851F9C7D5CF7C41EA7D680430E01F86B7FE8EDE19BA68B61A9F358520E556E07";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest46(){
		const string pKey = "836958918397D87CB8C261BC79B6D6B6C2C0812DD43BAFDACECC21FF91B55FA4";
		const string pubKey = "204A605B6FD1E70A67C8FD5FB7D71BF2E8734EC6FE1C749D1D82DD4B821F4E8D";
		const string data = "955F1735E70128BEEBE64CA8903480C6DA19CC2BAF3E6BDD3FC7041A692A045CA102B059548FC57F";
		const string sig = "9C3BD4140027590648F53C0219CBAB3F059E37F112E01C8D02873D32F9DE603D47F7C27227233CF0D689CB9CE09BCA66AB0A62567D16FAB723F37460686E6B07";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest47(){
		const string pKey = "1530BE5A7BBA1B0F0BC3FB4CB0B019542D47DF89ECB3996D01BC280E4017ACD8";
		const string pubKey = "8A54EEE6BACCDD0342800DC2852145874B650634D8FF5B0FED59C2EC779DC1C8";
		const string data = "132CE7708E19068CECA35F8FC1F7384C4FDFD585C6E7953F22AE34659053C4716250434F666695497A7077BC9D63AAC495950B";
		const string sig = "3CD6FA5F328DD37D6248FE4BCF3A66C9D8D5E4C1D7D175CA8CA3F7724A2BDED728CCC81AF5EB9D0E1EAEAE1030343EF5F7AAB592D96CF019C67CC901E3F92E06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest48(){
		const string pKey = "F281A5B2D1C7F4CE628392E75902F38614CBB3AF4ACCCE263CBA860AFB2387EF";
		const string pubKey = "0D45F47F73C76620CF67EE573813B6BEBE89199DECF79B480055707EB34BC830";
		const string data = "332FD70780B5FFAF3C571B6D3ECD048C065C0AFB05C1BE0F5DC7C80A5797180B6D886372A9B8B1DBD2EE1B904152FE";
		const string sig = "0C041F72F14E64679577F47DEAEE8148506C7A3CAFF8043ADB28EB8D5B1E0AD4E26E718D9032C0291BDF346F5C432665EFAB1ED8B4764BE409FBE1EE1663C607";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest49(){
		const string pKey = "8B0A47A1ED6044E03234A517B0C508C24B6900F94546296472F1D6C380CA34BF";
		const string pubKey = "3D37714E76B9685AEB35B006BB492DF809025EA14930A0CA72D6E915700BA531";
		const string data = "8918CAD2C4D10E8222865BD04A3AA492FC246A6BA477440FFCA26A2C21230456BE236D2B1D8F95AA01CD8EE8E01DCDB5CA89CA";
		const string sig = "D041DECC9C8C25B7E248A7CEE4F38990F7EF9830B6AD064039ADA7D7062433A70DC8FD5B0D09D5F6A1CEE1E1CE26B1E7E693C47E4C1F20155CB9C4CC0749DA03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest50(){
		const string pKey = "09DDD185A0A2B62760CA35567B83EAD845ACEF97AD2BCA6BFEA381FF8E806C1D";
		const string pubKey = "244275F9741A100C13D2BC346F872586BE9AD13A147CBC80049EF8C738EA953F";
		const string data = "55DD33145CB8CBFBD21264C2FF786066B21A2DB7FE47F6E1410D20CC9E50FB9D6462188E4602A041";
		const string sig = "66E519A2BA8F3EB16B63D69BF9D3BE564DAC0CA516D4EBEC9BDE5BE34CAF4FDC20A0A22EA45A01A00BC5F29016E35E128A7D73E4E7B396762C87F5C8F0695209";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest51(){
		const string pKey = "00665342A5BEE2DD5BD63C4C7996D102070A1CC7278CE10524715A8DBFC99DC8";
		const string pubKey = "5415FDBAB7D6968FF49352CF6EFB7C3F2B7C1DD20F8B7F83004D8EFCB5456143";
		const string data = "CF13D2EF24FE41E094A95D3619C80B2B5176349DCCE7EB3588D63AD5C1116597338C23D171D3DCE3A6DAC0CC311692D46AEEC1";
		const string sig = "41D7BA92A0DA2FDC85850C7F7370544A36D24C930E13356BC57A9D96A7FA5A3367617EDAE13D5D100CB2B72621E2F10D5BEB60726925DAD6F9B56D675348440F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest52(){
		const string pKey = "81B4183684CFCA61BAC4F9114363E0A87DD1DF88191D4D4CD29762E9FCAC67FC";
		const string pubKey = "9E8A29707623498D19ECF3ACC85D132D9E8644B52D1A503EC7E1A5A7C2415366";
		const string data = "22FA266659FB38312725A4A8C6D2972E44C96C4BFF2FC7A8B7FDCA4D8AB2F5368A21E424C602E4C8759C7A7107A7E13722BD";
		const string sig = "D2C95ED5CC95CB0A5493DD6D6BC078425B920B88173BA9ED0D100E4F501CD586BEED24FE77B2033B58677330661A2D1E7EA55A874D329B03CA8E1E5365FF2F08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest53(){
		const string pKey = "030C0B139705180A44D5A2406FBDB92AFB16F93C2D168DD39D2F5F43516295EC";
		const string pubKey = "406A85746BB0FFBFADDF09EA5F192A7FBB52D13E26B9848CF628D7402F253155";
		const string data = "60A3512E600236957F271A5B47EC35AB8991A1F0A0B76564D0549B77357779D0B1502365DD83DE78191265";
		const string sig = "23FAFE9934BD84B70AD9E4F453B756BC858627524E55BE47C53FF41AE7CC3ED2520282781CF0281C0C00E81DDFAD981ABDAF0CCDC98A9CEA2EDF9D262A7C0F0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest54(){
		const string pKey = "E6C1685E7AC64EFB63B77D55E05D7A1D1036B21A2831A250564653DC0A137CB7";
		const string pubKey = "FF612F6AD90FABC5E24DBF6BE9F340C2562C38FAFF854622A22AA81E5D273915";
		const string data = "A50E6D1BCF638075E64C9E1B17C4DF9D21EA977878E2852628A485A29D8456FC7073921DE0A972E9DA4AC861";
		const string sig = "353A9520C6CC81DABC8FF77C7A9EBBA136C751A6C9272A0D9495CD96B576BF8D8DEFFA4DF2EDE162B8E9EA9A4AC9461E20B3A8AF2A4E9CD07DD1E92B70A6CF0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest55(){
		const string pKey = "51758D3BBC03772AC3047018FA472EF980B20ABC38212A63B442861BEAC83904";
		const string pubKey = "67EAC0B1CC2176EAA0A931A48875563F0605F28E17A1CC76C06E67B1FCAC6411";
		const string data = "5547AB3B1B7A38BA5CA4E7208F405D0B9D3B8FDD04841C4AFAA49D704A7BADE6533F369FF1D9F87CBB70D6";
		const string sig = "D8CA4F8AE7C4DCBFA903A62339FA72AB5F2711C7B6759C464EFCC3CF2C3F068E6584F1E299A52888B406BD52CF1051D1CB55A953B903CF803B5B25500FB1CC07";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest56(){
		const string pKey = "2900D96D21B7ACE794558A432C1F28B806280AD93C31482E5B40A117E1219F21";
		const string pubKey = "9397BF2939CA685268B826EA65A750F11223CB87286C343A900D2233C5764B29";
		const string data = "3B68A2DE1C8808566EB969C032F5A10DF91AB7AE2D3D57C5A6A3376572876E0D94A759EAB785D943AD1DA35689";
		const string sig = "700F9E02632A6C751CA0A06156A55A3C8A1A6D0BC405B3E65F74A0E46FB5CDBBCF20865E0368F939E7482B5032D39F613D1E8B9C69F8E969BBCC2708D46A2207";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest57(){
		const string pKey = "D7DA4E94FB9925B6AB01370F26D45D1649A47B8601EC7CB8AB8E410FE8205D21";
		const string pubKey = "460509FECD9D9D16EAA5BCCB56A7FCD5206AABCD23D2D383A691247CF1CF8283";
		const string data = "2DEE16A97075FDF715819FA1E88A49F96C7345F414330AB6BD5CB12A81412969920F0483961DA4EA6ADCBC01FDF5";
		const string sig = "52199ACF799D9DEFDA5D3FCCE7C696E5AF7ED98C94B46B00DBA5EA157F7D4CE78BE29E0CEA6DE2B0E8299BF0110059F90683F12F67FD7733B40AE7AD5A945F0F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest58(){
		const string pKey = "3837B66CD409334733027AF1F4F89F9F8654FEB50C57DA4208BF60D32DD441B3";
		const string pubKey = "8086E849839C4AC0EFF1B1BFE1C0B56574AE9789792D23A309E018D66CEB57DA";
		const string data = "E7F642BCCE878038090F520A6337C06F6ADB55050F3AEF6CEA392B6AD230B0DBA62E7C3AA524E84A6EBE";
		const string sig = "7DA557F09FD814C667F672BB037D207B39066A09DE6BE993230A9A1A1C4F279643D4905BAEE6AFCBF3F70339A2845D9DC3A0F3BB579A0AC71407D45ADC099405";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest59(){
		const string pKey = "59212CC95F202C2482122ACDCE15C0491C4DFD3C239423953CEA71B31C8ABE0D";
		const string pubKey = "F6F37A426B002184C039A4BDCB1004FCFD037B1957519F4363B9C51F52719EC7";
		const string data = "E6275ECFF25A50C01FCE080C1E657ED04301DB84F455CD462F8829EC909E4DC873EB31B90CC8381973";
		const string sig = "B50E4791D6CF9198E0BF623EB08A66F5C00778896B649AC07FA126F5438371C4D7B8DA1EF8E07B909725706B47480D3D324BF80DB64E6BEE9127198378E86003";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest60(){
		const string pKey = "6C89B77896B8109821B0F0CA372563476FE4102E4E77B5EA57A263C4EB9E1A6F";
		const string pubKey = "F8F4AB8F0142F6233897FA96A88BAE70C6C3A5B5551B3ECA9B5F0D35B9BB3A3B";
		const string data = "6F1CD9AAC157734245E8688C7117092929030FE3A4499983481FE92E29B171C848C2E40E67183E9AED506F536CDB605D21";
		const string sig = "FC282BAF480FED84994B6AA10C50B69A39FCAD49AC5DCFDC9DBF0610729F1B2B1BE239B1A46B61C3971C4B6EC802FBBA2530E77979AC7B971472288E322AEA06";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest61(){
		const string pKey = "3C3408D03B2C01FA5547375F73CA9734858DA32BC6CFD7C62C184EEB49652F69";
		const string pubKey = "217075AD860F6C31456000F3FAC18C39A79DB3DC8F8EEA91D2708A346E57A432";
		const string data = "51D01978437B34277EF148297E09197F5F03D434E57E1DD61B975BB2ED290B87B3DBA4425B0B705BE211426236";
		const string sig = "5F97DD102B02A844EF9D3B4D8BBD3ADEED42ABA5EA84C02CA46CDD47AB5046B1EBF90F5A58860E8F14CAE4DC84EC90BCC52BC1B1C213C998DDB73D5D6D3EB105";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest62(){
		const string pKey = "4D3300355854397FDAA96467254DB2EC04C18D165E5194D009EEDE13FD8B0273";
		const string pubKey = "87279DAA2A4E4A634C3A4F3545A9B5E98C930D8EC6E9516374ADB7BB789827F9";
		const string data = "9E52B4BE735C44483CB6CC78BA9E8D9A84AAC17F14096D47D8067A36A2027892BCDD5B9F5AC466E564";
		const string sig = "68AAC725A7C45AB960551EF09376514FCEA190EF179E3039AB591F450E1BF81E5A6E20802A72FED06C20F93A19EAFE6B483271B4A31C3268378431C702CBBA01";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest63(){
		const string pKey = "9606BF951F3F28AEA0B7536DDE26C5AF8807B6D0BD54B2EA165645FA9890ED9D";
		const string pubKey = "716D1C2D79072BE263821BF42B3E11C22662B1491E69ED127AA726045336F202";
		const string data = "112BAAD15429D6F30E8A81637315A6CBCB959A48A1FBBC3844E5427274FFD486D039DC6D27D7BABB21F5";
		const string sig = "50E5731C5EB4DCB2FE72103A04BE8D2FF504C55FB927CECDCCC2772A0BC9DBE1F9502A27DB546359CC84AD5877D17AFF0DAB5BC4ABE8FD185A5C5AD8A69C5207";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest64(){
		const string pKey = "08720F4471BA2EC5DF3AB0A6B9C704B2302AF9A398F3AD3F56AF42FFE4F2A4CF";
		const string pubKey = "0E66294FD8BA6FF431CBC603085170B5F65D461F2DB370AF341C16286EB71EFB";
		const string data = "42F96AB0BCAE227C6CAE23E76C967B8CD87450B21D894C98394F2896ECFB79807418C27DFF5EFF0B7439F522ED82EC3A8D48B927";
		const string sig = "DE120D8C217BBF2FA00A90443383371DFE21189423D61FA5A5B90B8C40E3AEDFC2164A4BB02D6C047D90F4D9159CCB356203A3C630E9BB3920959ADF1D014308";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest65(){
		const string pKey = "725A04A1BA670B678B0C9162B53B550E9C0E0768DFEA503D33951C1BCD22E6A1";
		const string pubKey = "DD49BE25CFF43A75708BE2C110AF0FDC6ACBD052DEBE3AD08816E92F6F75A356";
		const string data = "C610347D5FD368C7BE675B8B225CC8C8F92444797A0DFAD09E222D8D503EBE561E4DBEFA5D5E1F6F71229F9955A2692527F6E8";
		const string sig = "B5D842AC3019FAEEE1608AD23621FC1D24DE87FCC32487E19CFC29D897CB8C8EBCCC09FA0E28679732434A490B666CB8CCDB95D880DA38AD692F53487664EC07";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest66(){
		const string pKey = "109F2CBA71A6540641D004B870D52CA7C8BF49602D5782CE5F29E10DB3A7E6EA";
		const string pubKey = "A8FFFA728216257C95C847A919EE01DC177EE9EB839E78C31988619CA94F055D";
		const string data = "51E806EEC93DDB4E0115BF6BF98E38B750A3747AC920CE2364C18D1BB59E776AB9A1D5B68DEFBC7F59414C741E3E";
		const string sig = "FCFDCFDEDAA8B514B00250AF2B9E76DB0F5ABF1A734DFAF6904213FE4EEBE37FBC5C27C4B40D664CFDB53760EE9CF6AC6840E239D6B182B30D7C0CC9565B6C05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest67(){
		const string pKey = "C0FA590D5C7D85865F034E6CA954335104C362409B5BED31DFACEEAC905E2BDF";
		const string pubKey = "0B4E4A617F3E56894CE0E7C4788C26C15F1A0AF0E0DC8C08CCF8AD703109D888";
		const string data = "1A3D7ED3E11D9EE3CE2BF3811BA3B8C8F09D921048637998782D942FBD2BCF5BEF60546FB6D4D9D06FE7E4";
		const string sig = "F0E34EBA9189BE832F2A7284C29A8A9ABAB172AA0BD3CCF2F7BB16C3192BEB5698A80715670C8F55F509F0E69D5CDC8EC01E3B8479A9D2FFE08B956B362DBB0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest68(){
		const string pKey = "901D333913CEF4615A6CB51E40CA34A64E533E8775614764C5A8980A54E50440";
		const string pubKey = "9D90A121ABB8BFEA3C165FE38D19BE7073A5DB91E8605811EA2FE0D368F505BC";
		const string data = "0D56822B276670290FF16147A8A85C22A9C511E0050D661FB5CB028B82FB232F88DFAAECB8795C1CC9634E6C";
		const string sig = "D9BED66E171FDC6C6C29132BF66848A3913BC9DA279F2B55CAA7DC3791408CAD24167B0DFB25056FE78F591FA71FBEEA0E50C0DAC1CE8702E43795A7D3306306";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest69(){
		const string pKey = "FB78E363319A83A8C102788149349D976E5451D2DD36640CADC9A92DB95BE4DC";
		const string pubKey = "4D8A82526F80DE02BCDA4F4AEC530CA080330D0AE12D11630172939AF00E0924";
		const string data = "5649AAFCF2064BCC904010466F9DBFDC4AA08ABF4B7E20A6EDA825538144BEB721B6AA6834A6654E60E6B6";
		const string sig = "E545277F65F7775832CE77A23FA3CAA8E198585698D5DD993B49AE240264991044C87EE907345EF03BE6355770CC8FA6EF7D5A6E53647243633591D9D40D690F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest70(){
		const string pKey = "BED500236EC1F573823C48284026C3B6CCCC53C780A8BEB51FF963D41A72EBDB";
		const string pubKey = "69B0F877312A771609E47111874B12C44243C79FE3251A2F1795F21F58FF0CE4";
		const string data = "69E09B4BBE374D59A5BB44F15A4FCA914D1DEFAA5D61806056490FD6F820621A890A38BDF898BCD6";
		const string sig = "8109F5D26CCFA39510E6B06D05B1BA89F856D985E8834BC9B81545801303A873E2426724D65B378003CA109A3A686C83E5F7ED084029F505010FA70315A09F08";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest71(){
		const string pKey = "5CDF38FB1FC4491FDC7BB7A113BA775BE1D029C8BC91B743C399679BF70434F9";
		const string pubKey = "36C16765883DD1F85138D8A694B06F03490C1B9295B4269343FC61EFE8CE76AB";
		const string data = "B671BB8A610B45BBF79113629196F748860B474FFC3443E5C25AE2D0C9AAC16F4C73ED13E1BF17655C07BB431DC138A3";
		const string sig = "AD3E7E320A44603FBCF7EEA04B5D0EA879DE916785FEBEDF99335B9C223B9818CBF90A81219F752C6C28EE354EB57A93EF18C7E6471CFE648B6BD76A957EE300";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest72(){
		const string pKey = "E0138020F43450171D4A6446BA1CEC67213404DF3AF0F792D324F0C1D5EDB01F";
		const string pubKey = "C69CD66C186EE4AD786355FB2070F193CEBBF0B38AD87AE9374E8010CD679A9B";
		const string data = "2823306B0EE6733CAFE87BC0A40D82DC007EAA3FB9BB0610EF35524D472049E241AB8C1D487C9F57D2FEC64F";
		const string sig = "50CFF2D5292CF28213E1D740F4026D87FE4D152BBB3D9AD1AB5D69DC2B9A8DFB6527032E746E92F7438B7E58B690434E254379373AB4DC2194FCCA107DD4FB05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest73(){
		const string pKey = "0BCD7DA5A908BB98DAFD0251E5F147758BEF4C10CCA8C4FD8687E28A3D35A82F";
		const string pubKey = "1EC0A6F5C1DA732C0E6708F8242A929405F7A6A6AC4F7481E928194560BFB7B8";
		const string data = "3079D831662AAB394453CBEC5457BDCEC3F345BBFE995D28A8B5687DCBF2FD40DE0139713219A2CF";
		const string sig = "AB692062CE59A15CFA102F692C8943EAF878DC102CE29A9D44F56367D3161744441B0823E46860850A656D1DFF95E6A85E97367461B268EAE22D060AB66B7304";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest74(){
		const string pKey = "62962129D2B1CBD1D53E8A916B94851324E0C81DDB3CDF188CBB8272117A2DEE";
		const string pubKey = "B0E0CE7D304277B37F97ADFADE9FE5246E5B57F3C0D87E2FBCFB4D12654A0679";
		const string data = "AB2E0D661E82C15CA0066C0AC27FA11D5D6434D0738ABD2ADAB0EACB552DA3426459C739F0D5BB9745C1A4";
		const string sig = "27E2325CD73B21CB9295AC48C315A2D29F9022E366325EA3A49CFC4572706359C8CC5988BED8FB4264784AD79B2BFB0CD133D255B041E702117612862731A00F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest75(){
		const string pKey = "328306875BDE44BD21A072C168EDF2A16B399D8E8DFCE4A66439D4118E8CA139";
		const string pubKey = "58255562E45AE665147B37115673704AA4270479706ECFEA36BCC6A990F1902B";
		const string data = "FB85BB5AD2F506B73347F7AEE241681CC6AFB0E594F53654DB8DA72110E2B7F8793BD7997FB78EAD";
		const string sig = "C26310BAAF9A009789881AEF3E0BBEF33F93A6AF7AA6E990106FDECDDC3507EECF793B4CFDDF9585C3441045ED1FCCC1337616A991A950CCAFB7DCB56E40990B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest76(){
		const string pKey = "A96E4D19EF866388915FE04D2A2D770301E1A91B656C2F0DB71B3C7716BCFBF3";
		const string pubKey = "C4E1FD1F9B597E48202F3AEAB67445CE602705F111D0323FB5EB0132E8A0CE1A";
		const string data = "AF1E0E20AC69B95CB20612866AE7C62B401550260A931D114FDF38B21FA84ECA5D19D52E5836F2203B7A45D3D764F0858F8235";
		const string sig = "82959460253E3B644DA350071B2F565B56D215CA3A0C71FF22221957C2B50AE21F3DAF03149ADC5CEC7AA383706A1057CBA1922739A907A40B67E83D74A5D303";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest77(){
		const string pKey = "95B74D8C9D7C199D6AA0141B237ADFE18AFBC9F421368B0F29901852674D6021";
		const string pubKey = "351B54ADB71A59327A2082160AD43D4B3C08F482BD7CEE2AA69E81424B0BCF5C";
		const string data = "3B4857F562B2DFEB3E6829827F197784634426DF1DAE143B49E6C954951AD7816370DB0CB2240C56E9D4";
		const string sig = "9C2A331DE189D5A95C4B3A046EBCC3694F7D201AF922005B9FF4AF990C128037302A755E4C3CB49100541A29A9E94C46F9E82633A41324F0B49CFA64ADB36E03";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest78(){
		const string pKey = "A7AAF052EA42574A5BD5555782390F8E9E7FED925307E8954FF7971C7AF5405D";
		const string pubKey = "C81F717625692E62D2D3671C9698614A8730833C77F53A3F1CCEB6EF53EB9AD5";
		const string data = "075BD25C6996ACE1678ED20E00A3552A368CFCD45D966D87AD288BB9E05A200A5D36ABF815CF30D06655D3E31840850475F3";
		const string sig = "C9B6AC2405184B4E3DCECEB029ACC17A0A36F498A7649B7AD1F74836785642A30FFCA063D335526B2A8A854C73783D43992B2FFF111BDC97647C43436398320B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest79(){
		const string pKey = "EB44B44C2A6BEE51CD45E5B137A803D52B37610ABD6C933AB9AB21E83C3A7973";
		const string pubKey = "E99C466EA3ED60026A8A0619A048B2DBAD49CF894DB62564B3238022EEDA22CC";
		const string data = "5A48A9F78D8ED36546237696F486F3FC340B0B875979E962A4EF7ACFA969174589D7BC6EB34745B2D938E9B4CF31148005B0";
		const string sig = "FB83B86C523AB21D71FA4C1EE3C32ABCD693F2752AE0D9DECFAFC21DAA6AADE962831B2A0CFD3CD0B9EFA529C3259168EC18749746E5BF454B89B6BD110D2B0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest80(){
		const string pKey = "052BCF210594FC94FB68324A5F43245504FDB4A5510630115E530C3AB8F8C24E";
		const string pubKey = "6C15737B008820174D48CABCA88C219B9D42E8A387065A2C4868D1A33F564C81";
		const string data = "4E70933AF05CCC656BC2B341A31B6D891068FDC1E9EB64669B534079E9F9D5F386E5409D11F2BB2758C3AD4C";
		const string sig = "FF159E219E12584861CC404824AE48D8843B25E335D8723C1670A2433CDC5E49EC1DE0B1E5F2621D8842D37A0D3782F0BA676716DFDD33F6A0045B44F6345405";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest81(){
		const string pKey = "B4883C684E866D5B0C66C753477F429CA2230600B085EDC156928BA99B98C98E";
		const string pubKey = "08247D1562E88ABF869CA2415B2B1E2C4182CCB0791E865505306BAF98AEBCDE";
		const string data = "55C12DCA9BE62B57F4D53016C43BB6DBD09EB8DD467E41EE676290E5801798A5B3E348075C3E91B9";
		const string sig = "7F4895001F0493C46969618B7C1DBB9DFA6F0EBBA38A3CEFDA50BF104FA91AC2BC331260F3895CC45C21B2C4D9E93EF6402835A6FFF6F8601E92D020F233AA0F";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest82(){
		const string pKey = "E240047967ADB460094F2B515BE2F590A4C93A1F97488FE564F29176F2DB95F1";
		const string pubKey = "3FF0064F0E3C28A81F48787D33A0505EB40EF18CF36B1A517A30383A515A979F";
		const string data = "5827805FD9031B0EE8605B03EC448B415A3F744ADC12943C9E84E60FD133CAAE544C0101F2F267576B678F6E43121198B947A7";
		const string sig = "5539BBFD2A23C2F2EC44C7EC8C6C4E6AC10A4A7D0D0682EB4B3BFB8996973892D7F6DFDBA16A21BC4F9A6AB408772C3965D5750BFB62DB3FAEE97720B7F26C0A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest83(){
		const string pKey = "0CEBB0A6F4343ABA85450BBB69013D1B7D92EA42525790DF61B05BCB4D87D81A";
		const string pubKey = "DC7ECBBE1134C7EEA669976A2D50EEE3E32485FCA1A07E0F1ABEB19C2CA1AE01";
		const string data = "CD7E66272F697D7BF92133393952BD5ACB24F14F5F66F2755F0CFD81A2A6782F6F32FD75E524E4D6317E5818D728771AEB3D23";
		const string sig = "F4ADFBF39F35D61C329E32F3BAD2E51D0E4D06CE3AF95BEC9C68CCF6373F8C6B91FF4121C6CF2F7AB0B926CEDF92AAB493EE06A0D811AF50EAEC0DFBECB7610A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest84(){
		const string pKey = "E83FE044F92C3F349A3E5FBC3BE0269E13E98A19CCC19CC2D29CBA931F649FDF";
		const string pubKey = "56589C565098349FB0E66B70D21B260B8CB3D9729042A1801EB75D976D1935A4";
		const string data = "1081E428CE82FD8A7EDB75DE2C3AA0A701B4F0C36476A52A8CCFD8C6EC5F5B41D3C28AF6A5BD1017EBE019E2378031FF1B";
		const string sig = "1458AD4DAEC6588084819CD386EE4E4CFC49F1344798E848BE7D75EC0CD40CE54BC5A2632EF8BD508519AEEDBF32DACA9A218D20CFA39A0C47A5A8A783E3FB05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest85(){
		const string pKey = "1D3BE57CCCC3B433C5A85E3BB8C671BE8E26F70B8F1D23BA5E845C02417D9A2C";
		const string pubKey = "EF7EFFAB10E839507A11ECA72605478648D3F2F073FD32CDEFB41C44C3931E4B";
		const string data = "32DA83D92939DD7802BE226B92A63F4CD91ACB3A25D0129271957BD6804AF02974883478FE52FABA92253E31CA98";
		const string sig = "AC680CAD80B522327565A629B9267506E7F61430834F2DA92D543B8BA74B0B797A84F6EDB536890AB582D0DC1309CE1D9FFE7D50718EB263A2EC8C731974E504";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest86(){
		const string pKey = "96AC795DF13BF62ED986677FA5D27D8B162BC8F00468AED06FEA3074A4F2971F";
		const string pubKey = "A2949A81FAE2A542B2891A05BA8378C27C2E22581B5F7CA006F1BF24DC94A5F9";
		const string data = "47BF91FC6F3EB2FAD7D8E230E347AA7E734D63F9E73C863934B83E7AC4DCA386AE605CEF63D901FF57";
		const string sig = "EB2B9998C7363FAB99BC8E99580265996576A6307AA6CAF49CCB6575903394CEA90C838EA00D7F254D09C61EF69E3FAD3E1A9488E4FE1E8FCE4DBE76E99C4E00";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest87(){
		const string pKey = "A65F9AAFE4121F2CB73BD692F1ECA62AF02955DB5506D5A6B5FF8A0609B911EE";
		const string pubKey = "6B66B77495C789E7990F9AFCEE4BEF45CF598D39B52EAB5569036FB5816B9B50";
		const string data = "5F91D02155A4FC170ADE24A348B3451DE285526933564D6D71759A8C46CEA1CC34378054C7158951E5F6F4AF68";
		const string sig = "35985373BF2B6533374CD46822135D8DCB9F8F5924543E1AB0678C67F7306D2E9BAC0D8C52A9CB8F09B21261D83FE260EC1C54A7300D6AA8A6198BA7C0CFB503";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest88(){
		const string pKey = "A00F90870EF0D049B91AFCE85DA351001E7590341BF7CA263A19936EFC3F503F";
		const string pubKey = "D907D95CF88B5B77093396889ADF7AA7FDDFC359C7AEBAD35DF35A8365313145";
		const string data = "3CAEA495F508587E6220D0FED1BF683B702C0E2C325B8BB9902479679ADEDA47648A3D932F7558A89D87E12FA561B1BFE8FCB7";
		const string sig = "514EE99CC2D4583488CF0CE38A0284C954381963D47A032DA07D0B073FF2178490787E15C64213129DA5CFC8E2EC16645F4D7B5082012A078876286A9187850E";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest89(){
		const string pKey = "ACC4208A7DA43F2BD6EC23C09B608EF8C2D6A4732F7BE6C9278936065D5EA51D";
		const string pubKey = "B7239E698C94F320B015302A87BF7C35B12AC601A24B15CAD92064285D49C28D";
		const string data = "25FA6E8A46C02EF5501186E27D876C14CEB2CE9E591A121894C5F4CF1CE2C7D7BAA77DFC0BFF00D06CA47A9E7E3EA6";
		const string sig = "02238FBC3BC22F010373CFEEBAFDB4002E46F4BD507C26710149CCBB65A7212F5EF77A8D48D9C29D00207A9F572191C364B729860B814D6C2C3F47F460F44F0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest90(){
		const string pKey = "4CEED036C390909CFE6DB9483431D8D242AB1B8452217DF32370CD2A3EB90E1A";
		const string pubKey = "A75E61A982060AEDBF2E0FBD95373298D8477EF48B614BFFD4044060ACB44D84";
		const string data = "71741BA7BBD422CCEF1B42FD183E4DF1C74AA78ADFA5FD49860CF572F8CCF8D016949913306BA5886376F68BCA";
		const string sig = "D84F1184E93E5A57CA0EFE1A3AE6335249A4AE5319B001E01C7E4D08C367C8CB216CA9F8564A389313628DA910259AE9898F0DC85D9C7EDBF67F1C0E4D7AE003";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest91(){
		const string pKey = "7611E68D8B7ADC81E924EB4E274B1A8E1D48FD46A6FD3756B8709977B37BF332";
		const string pubKey = "94C47460B1D085DEE5844D5CA65E50CFB063D63257DC5ABAF14249F3FD69F28D";
		const string data = "A22AD42F959183F27B2EE67DD2FD5422AAE2838BB133D87634764AE9D47E51DD1A5016A1C2A0EB1653AA6F27F499";
		const string sig = "02223B8780E2632C2E3D62716251782E87E96B0094532CD6317C82E1C1487007E9190385844407FCCD447DA90CF9EAE8A845DBE1C7A9C27865C8E16324AFB506";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest92(){
		const string pKey = "DB75731AF82D837C4A5309DFD9AA61F36669AB3311B2CE946A13F4922A802ABF";
		const string pubKey = "265B6F4A5DA2096089AF140F75FFCFCF855418CA6208B0659D913C7363B94152";
		const string data = "5C5CA712CF93561C3DF00C996F685DAD2FF00178A1BE5D83D15B568A5B80D38F1E67DEB5F20F3AFFC37E8ADC38CEACE8FB8E";
		const string sig = "5D0F8355B82D6609387B7166C4C51E5420828A83FD52B47AF2975F451F824F67C2F10C47F92C238CFDD1F351990B6B527FFC725612AD5F7D01C2B3A94FC75A0D";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest93(){
		const string pKey = "8D0B67C2A2BC6D43C2EBE7E522BB526CD63A140552411FD9D3BE92369E22F4D2";
		const string pubKey = "E07B559F55E6CD356C7F05883EB7002251B3E5DF505DCC2B528F1E01425481BD";
		const string data = "C3417D98A65E66C8AEF760810EBA037B004CA47D1A211EF90E0AE4AD48B687DD2396828BC751EB5888C539D945F1DC6AE4FBEF";
		const string sig = "736277F5356D8365836FDC2E5B990C9E5EB4A7A4611253EB0281BF09EAEC6FE13F16E25F43DE5FAE5A6635B7EC0F2791F24589E096FCDED948515CF1AF5E2C01";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest94(){
		const string pKey = "519CF6115E3C7DC1351831096BC03C02A076F3FDC4A935C2830E8C5261C2CE78";
		const string pubKey = "A82AC56FD26BFC73124830750693C76B047116C3E854D0223A25FA01F531FEE9";
		const string data = "6447BE163BA795A7EE780072E63DCA3E2917FDDE2E921448C646D96C9B6E9E76215E4D7C26E3884DC71BA642CA23EAF7468E";
		const string sig = "A438234D4E099751C582BB5BD2BDB4FAB50711B55937964503B6ABD89B44F5F274195CE2E5ADFDCFAA05D9C7DA3AB369F7144B29EDD8BBE2C956EE37166C4503";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest95(){
		const string pKey = "04C90BBD85F5E643D0FD4FA31C1163F85464668CF293ECB7ACD76D01100AA9DA";
		const string pubKey = "CAD2094576058B74D9FBBD2AF9F2776C40AB9DA4D62D8FEB94D3619B09C2DFF1";
		const string data = "880271C34B55E5CCFE454019DFAAD11A18A10C4B21D74401D6480608E79F8E3FF321DCF6FBDA939334D54AEC";
		const string sig = "B4894E342636AFF607D08314EDE10A1A0D9F454CE3D95BA843C07481E90519681317E76F73DADFDDAAE1A0F43807C12944C4F8E7DCF1C6E45CAC2989A093C20B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest96(){
		const string pKey = "C4F72790F1E365E0A99CA4A05A97343185A50CC5ECB88CB70BF9171EFD1A7F7A";
		const string pubKey = "2E89A96767A7E18EC050203A65FC3A343916D2CEB98CD4F1EB8129E2C7B017BA";
		const string data = "D1686F5004566364F58AE24EF2886CE55E12D0A8FE26ADD43C0B41271EBDCABA823B02D56C4491FA91E4BCA1399D915236";
		const string sig = "A664C43C62A60B4B2321D3763266E5BBE44D82AE3335D3190D26B198D6F197EB8A0B53C321630E1DB0981F97F268FB008537FC24CA58EA7E6FEEA764DF223103";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest97(){
		const string pKey = "26E33D9476F5AA6F5471F5B00B3EACE30828C5063A45E3C7DAF383ACE9472880";
		const string pubKey = "30B52B6D79414C7E2798BA7509A28ABB3F9B771B29B32A64D8FFBC504FD6D0FD";
		const string data = "9D46CF217ABB40142861E947DE60D174FC34B106D9A049590BF0320560A388B0A39FEC4906C691691107C71343AF1880322067";
		const string sig = "AFA542434930CC5CCF5C062A28E6DEB1F535B0B45CFD0753D1C0B3A157AC18F32B1D4D358A200D572D586D635DA27FF1360C7AE6753F15E083F08F359E0C340A";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest98(){
		const string pKey = "7331C098B14761F582694EE54FA7218EA516C22F7FF91201E8F03C440E1D185B";
		const string pubKey = "7D2AA34F6D0A961F251D14640A93197C1545883713758585E958A8407BEB7B01";
		const string data = "DC55A1811819FF75A98DD078CCC432D718B7260842C492F0377B65D846BA0BB3760FF42B1D34DB6BAD4CB8B2A0E669178D37AD";
		const string sig = "74275773BFAED7B83A158310BB9DCD3396F67672099D37480665DD655FB80560894E0668F2B989FC41F6C2694958E7773F015F372EA8A7738A3D988D7CE72D05";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest99(){
		const string pKey = "8CAC50F5586F71BA46825F2BA8B0548AE46DD553A0A3BEA2F9FFEEA9F021D5A7";
		const string pubKey = "EE57CCF10076BDFAF38364B98F3FF54327F72E10534616A9BCE0C5E7763C77A3";
		const string data = "5DF2AEB28226903EA995D456CC07F6555B25614995B59EE7E4B93C8B557D722638146AA48A6BEF64B8B334";
		const string sig = "75FB1C63357C53FF4B75F8742C35A5F38E94069B680A3841BCB62F6E5BF859727E3A44509B5D1DE04F3E060C426E672558BE7EF27B908D51611FCE2DE20BDD09";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
	[Test]
	public void SigneTest100(){
		const string pKey = "913D0740DA5D0DC5ADEA97E7675F771BF2B7F28A509C9D2FD0D9F02CAAADD0E8";
		const string pubKey = "F25DCCA43938650EA0C1210AD721F80993CC0EDD3F4476FE87E0C4C29B7E0906";
		const string data = "B7CC179962B553F78B28379B7DDB20D801715FC1D3C7EC33FA7A8E47208508D9AF84C1549755CF9E93125CC65E898D02C5FF";
		const string sig = "E34CFA94FA04E9DB3936DAFC0487BB5A0708440C7A194A30D275C5E47D06D5F1EC24D7BE608CED010EF58E32DDBE9C9A58DB3D4929E6C2A58FC37AEA69A75B0B";
		var privateKey = new PrivateKey(pKey);
		var keyPair = new KeyPair(privateKey);
		var publicKey = Converter.BytesToHex(keyPair.PublicKey.bytes);
		var signature = Converter.BytesToHex(keyPair.Sign(Converter.HexToBytes(data)).bytes);
		Assert.AreEqual(pubKey, publicKey);
		Assert.AreEqual(sig, signature);
	}
}