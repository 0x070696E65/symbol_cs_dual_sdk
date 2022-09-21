
using CatSdk.Facade;
using CatSdk.Symbol.Factory;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Symbol{
public class AddressTest
{
    private readonly SymbolFacade MainFacade = new (Network.MainNet);
    private readonly SymbolFacade TestFacade = new (Network.TestNet);
	[Test]
	public void AddressTest0(){
		const string publicKey = "2E834140FD66CF87B254A693A2C7862C819217B676D3943267156625E816EC6F";
		const string addressPublic = "NATNE7Q5BITMUTRRN6IB4I7FLSDRDWZA34SQ33Y";
		const string addressPublicTest = "TATNE7Q5BITMUTRRN6IB4I7FLSDRDWZA37JGO5Q";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest1(){
		const string publicKey = "4875FD2E32875D1BC6567745F1509F0F890A1BF8EE59FA74452FA4183A270E03";
		const string addressPublic = "NDR6EW2WBHJQDYMNGFX2UBZHMMZC5PGL2YCZOQQ";
		const string addressPublicTest = "TDR6EW2WBHJQDYMNGFX2UBZHMMZC5PGL2YBO3KA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest2(){
		const string publicKey = "9F780097FB6A1F287ED2736A597B8EA7F08D20F1ECDB9935DE6694ECF1C58900";
		const string addressPublic = "NCOXVZMAZJTT4I3F7EAZYGNGR77D6WPTRH6SYIQ";
		const string addressPublicTest = "TCOXVZMAZJTT4I3F7EAZYGNGR77D6WPTRE3VIBQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest3(){
		const string publicKey = "0815926E003CDD5AF0113C0E067262307A42CD1E697F53B683F7E5F9F57D72C9";
		const string addressPublic = "NDZ4373ASEGJ7S7GQTKF26TIIMC7HK5EWFDDCHA";
		const string addressPublicTest = "TDZ4373ASEGJ7S7GQTKF26TIIMC7HK5EWEPHRSI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest4(){
		const string publicKey = "3683B3E45E76870CFE076E47C2B34CE8E3EAEC26C8AA7C1ED752E3E840AF8A27";
		const string addressPublic = "NDI5I7Z3BRBAAHTZHGONGOXX742CW4W5QAZ4BMQ";
		const string addressPublicTest = "TDI5I7Z3BRBAAHTZHGONGOXX742CW4W5QCY5ZUA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest5(){
		const string publicKey = "4F593111964B37A9CAC59D2A70BC959AE9269589B75FBD640145EB0038960540";
		const string addressPublic = "NAA6RO4ZAPEDGTCVADE3G4C7SWAE3DBQ4SCMOAI";
		const string addressPublicTest = "TAA6RO4ZAPEDGTCVADE3G4C7SWAE3DBQ4RTFBQY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest6(){
		const string publicKey = "E7E4F02AC46A7DF3262BA9560C5161943B62953D175EAD37FA5DC7139EE16AA5";
		const string addressPublic = "NBEOZ72O73OYXFDLID5KGBMP67MROHONPQHVKAI";
		const string addressPublicTest = "TBEOZ72O73OYXFDLID5KGBMP67MROHONPR72UPQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest7(){
		const string publicKey = "5FB83A2717B6A615C92250D2B333BFFE974CEED13B6E668E4DB203A819574FF6";
		const string addressPublic = "NAMJCSC2BEW52LVAULFRRJJTSRHLI7ABRG2X5RI";
		const string addressPublicTest = "TAMJCSC2BEW52LVAULFRRJJTSRHLI7ABRHFJZ5I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest8(){
		const string publicKey = "2F62010232E8529C8D3AC0C66A0E638847B310DFAB85A05E7988BEB8117C9948";
		const string addressPublic = "NCOVTFVVDZGNURZFU4IJLJR37X5TXNWMTSEHR6I";
		const string addressPublicTest = "TCOVTFVVDZGNURZFU4IJLJR37X5TXNWMTTXN3DI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest9(){
		const string publicKey = "E3B88D841947C5B8717476D78B3C980B9AD84835D9FA25418F4ED0F03D558631";
		const string addressPublic = "NDTHQOO4RGNIWRNFFWK7Q72YQWFZ3MA42MN7UUI";
		const string addressPublicTest = "TDTHQOO4RGNIWRNFFWK7Q72YQWFZ3MA42MUJ7AI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest10(){
		const string publicKey = "9D1E51DB71BDE7A997C8197D8F45EC5F89067BD2729BEE19919B450587880E8F";
		const string addressPublic = "NCPBOKP4CAIRPTHMLQ77BAD36JYLRIF7KPUW2RQ";
		const string addressPublicTest = "TCPBOKP4CAIRPTHMLQ77BAD36JYLRIF7KOA7LIY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest11(){
		const string publicKey = "E7274B578319382FBE3E27353D44038711488171565A8F3E109F601DD9EBA527";
		const string addressPublic = "NDCXOEKHZABQC3KK6QL72CADWOEH3UPNDDH72RA";
		const string addressPublicTest = "TDCXOEKHZABQC3KK6QL72CADWOEH3UPNDCC7QTQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest12(){
		const string publicKey = "AC4472BA44AA9085BC7B391DD83199D126A2B84417C7A40EAF547F63B60B2939";
		const string addressPublic = "NBR45GPME33WO3JRPYKQDZZSBXDPCEZOGDJ2S4I";
		const string addressPublicTest = "TBR45GPME33WO3JRPYKQDZZSBXDPCEZOGC6PLJY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest13(){
		const string publicKey = "4D9764D8F80CF1E58F9E96B3EA80BDFDD6CE356A71C2D9DD10F8ED766AA83B27";
		const string addressPublic = "NCPB6J2ZA6HLWKCKBGKHKLSYISEK3U2XPT5JY6Q";
		const string addressPublicTest = "TCPB6J2ZA6HLWKCKBGKHKLSYISEK3U2XPRQOGXQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest14(){
		const string publicKey = "5A5F08F39C14E05DDDA74B373856F0C54DFF146FD7F0BF055D42D64E74C2A7B2";
		const string addressPublic = "NAFAQOHQ7HWZW6Y6YYQBY5XCSMTZSHZGPGJRRWY";
		const string addressPublicTest = "TAFAQOHQ7HWZW6Y6YYQBY5XCSMTZSHZGPHHPVOY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest15(){
		const string publicKey = "DD64DBD277E3CDCBF3B02E2CFE1A2130EFA6BC87100C09D798EA75C6CCAFDBB1";
		const string addressPublic = "NDUQREDKKSZVGMUPQYLHNSEMUTIUZTSC3CKTYTA";
		const string addressPublicTest = "TDUQREDKKSZVGMUPQYLHNSEMUTIUZTSC3CLO4RI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest16(){
		const string publicKey = "25E2D163E5FDD2DD26E0338A91698977EEE23159F28888EA0A3E07B038B91B48";
		const string addressPublic = "NAHNSCCWQZAGUISMCVTKC7S67A364VX4FG4NCUY";
		const string addressPublicTest = "TAHNSCCWQZAGUISMCVTKC7S67A364VX4FGJMSKY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest17(){
		const string publicKey = "079928075E0D4C60359D7835C74A60D68C4F6A0FE8F30C2B0F4899C94FE02B10";
		const string addressPublic = "NAILZRTYAU53SAHF56HLJDF6SRWB3BJ67FCZJFA";
		const string addressPublicTest = "TAILZRTYAU53SAHF56HLJDF6SRWB3BJ67HSSLHA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest18(){
		const string publicKey = "9E1AF2C84DA9E788D7AEFA151350BCFD53BE28621642D26459834658FF9C68BF";
		const string addressPublic = "NCSELP7QXBTQ3NFTNH642ZM5JMZZU2CEO5VTWRI";
		const string addressPublicTest = "TCSELP7QXBTQ3NFTNH642ZM5JMZZU2CEO5SDIAI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest19(){
		const string publicKey = "E3FF86D60D6966D02951E46FAF13EAFA52E891B961C51C54C329BEAF2F912439";
		const string addressPublic = "NAMW26EN6Y2LIFAU43C6TGDVGZEYXK35DXRHG5A";
		const string addressPublicTest = "TAMW26EN6Y2LIFAU43C6TGDVGZEYXK35DVN7NVA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest20(){
		const string publicKey = "F81CE75785431C495C1935306A26E655150E6B9E6C9ADE4955CD80B7EA0FC960";
		const string addressPublic = "NDWZAL6QCD2ANX3DAFDUK4TXZQDLXWEDQGLS6KI";
		const string addressPublicTest = "TDWZAL6QCD2ANX3DAFDUK4TXZQDLXWEDQGZD2OY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest21(){
		const string publicKey = "EC9DD943155CADF561513057DAC971FC55771D6564CC2283594700594D93D37B";
		const string addressPublic = "NBL6EEPN3KEDP37YGNYOUQO3DOTPOBBUATPB5PY";
		const string addressPublicTest = "TBL6EEPN3KEDP37YGNYOUQO3DOTPOBBUASYEFEA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest22(){
		const string publicKey = "91C607BF2128EE5ADE40BA1BECBD043E9893B368B7C66BB5D74929E6567C9392";
		const string addressPublic = "NA6J57H2L22WYAVSCJIGXIYTWHAF7ZECFVEWSSI";
		const string addressPublicTest = "TA6J57H2L22WYAVSCJIGXIYTWHAF7ZECFUYM5FI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest23(){
		const string publicKey = "0DBE76A80979C4DD2081A06E88370FB9EE4425D9047D4875B373DE0EE0A96555";
		const string addressPublic = "NCOI6JDF7FLFVNFJSJFF2MMYLIRAH4IHPZ6CXMA";
		const string addressPublicTest = "TCOI6JDF7FLFVNFJSJFF2MMYLIRAH4IHPZFYQWA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest24(){
		const string publicKey = "A71E8A545903D2A4CEB865233BBDE665BB1E2FAEACB0CE5489AD3E047C11277D";
		const string addressPublic = "NCGLAJ47YWB7ZW7PBLLUVAONWOBMYNSQKDSUFRI";
		const string addressPublicTest = "TCGLAJ47YWB7ZW7PBLLUVAONWOBMYNSQKAITBAI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest25(){
		const string publicKey = "1E1AB199992E1C7792EB164FD4ADAD2E512D50033C13D439318DD96DB7F1A2A5";
		const string addressPublic = "ND664WXAYTBBB3OVKW7IAH3F7NOXUNM5UBH24XY";
		const string addressPublicTest = "TD664WXAYTBBB3OVKW7IAH3F7NOXUNM5UAIALJI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest26(){
		const string publicKey = "5D2BCEF32570E7A127C384F27E66EA77855112EFC055A23BCB66904E1B8398DD";
		const string addressPublic = "NCNL6IS7FGXRBCMH45AQIWWUGUVBPSNF23R2ZNA";
		const string addressPublicTest = "TCNL6IS7FGXRBCMH45AQIWWUGUVBPSNF22OJPLA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest27(){
		const string publicKey = "BDABE8C6D9B4FE4296B35BAF3DC590379A040CEF319C41F13D6A300305171F38";
		const string addressPublic = "NAJXTIHLM6GKENYTR7IIIAXAJFMBWQQ3GGU56MI";
		const string addressPublicTest = "TAJXTIHLM6GKENYTR7IIIAXAJFMBWQQ3GEGK7BQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest28(){
		const string publicKey = "E8B4CE09320311A6B82A8FF172CE12EF0D6832247FFC8D8CD2C6FB038E5F0335";
		const string addressPublic = "NBBVQXDKPBZBYCAIWO7ECZFNTT35XUYGNBXZP7I";
		const string addressPublicTest = "TBBVQXDKPBZBYCAIWO7ECZFNTT35XUYGNBCDQNY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest29(){
		const string publicKey = "7165B55E7214A2AC1A934ACE35242DA84E09E8BC5949882F1F63E020C7DADD1B";
		const string addressPublic = "NDBXZRBCBI6GL4PK5WXTPNWETRCX7WVBM6KRISI";
		const string addressPublicTest = "TDBXZRBCBI6GL4PK5WXTPNWETRCX7WVBM7AEF2A";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest30(){
		const string publicKey = "753A13EF3F79131364094622C55B535736A6EA1A5F316D65372C98EF675F946E";
		const string addressPublic = "NCJTDZXF244HUB2CHROFOENCZC7AACNULZBE3SY";
		const string addressPublicTest = "TCJTDZXF244HUB2CHROFOENCZC7AACNULZ5SH6Q";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest31(){
		const string publicKey = "FEE9A5DD6F1E8BC4A78948B08EF9F69E9556BD9CCC26DBEA33B5073341917359";
		const string addressPublic = "NA566D26ZPMT4SRNOY6WEZREDKGBIMAZIQNCH7Q";
		const string addressPublicTest = "TA566D26ZPMT4SRNOY6WEZREDKGBIMAZIQUPTFY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest32(){
		const string publicKey = "5FC13702DC01EA201D8F32DD9B1C83574B13BDC77B76EAFD25E6E492EAA287F7";
		const string addressPublic = "NBVUW2BRCJ7BBQG4NBLIPVXQHFFNWXFJ3DAD36Y";
		const string addressPublicTest = "TBVUW2BRCJ7BBQG4NBLIPVXQHFFNWXFJ3DUR6DY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest33(){
		const string publicKey = "A7DDE6DF318376DEB9A5604C4F3974BA47BA94750E5BD356FD1734B2616BE53C";
		const string addressPublic = "NBPEPAIZYAG6Q7EDJOO5JQ7UTNIEC7ENDLIDONA";
		const string addressPublicTest = "TBPEPAIZYAG6Q7EDJOO5JQ7UTNIEC7ENDJ2XWRA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest34(){
		const string publicKey = "67779DE5F1592429243D3818A9728C29F747C6666E473D72696EEF2430BE44EE";
		const string addressPublic = "NCSMWHUYHZCWC6P7WI4AE66377H7H5LNDDYGO5I";
		const string addressPublicTest = "TCSMWHUYHZCWC6P7WI4AE66377H7H5LNDCQFASY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest35(){
		const string publicKey = "CE38700FC21DCA03F8ED98C154B109CC7A8C949CC3CF5E55B3163E0E37CA2255";
		const string addressPublic = "NCZDUM4PB4DEDZNYSESA7GB4IGADEOF4V2M6SII";
		const string addressPublicTest = "TCZDUM4PB4DEDZNYSESA7GB4IGADEOF4V22SISA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest36(){
		const string publicKey = "0D84E9693C3D682475DD6700319A9ABD400F006BA9A39A0D5B135FF96A2D33D1";
		const string addressPublic = "NDDEMCLGPI7TK5LZIKWQYX3QJQ5S2AUDH7LSKTA";
		const string addressPublicTest = "TDDEMCLGPI7TK5LZIKWQYX3QJQ5S2AUDH4TUZVA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest37(){
		const string publicKey = "A9B1C508CB2FF7FBC7E159EA578DC5414423020034297C092D63ECBC0EE25794";
		const string addressPublic = "NBJ7HD7OO2GP6WJ5ILXSCHXSQILUF375V5Q6E3I";
		const string addressPublicTest = "TBJ7HD7OO2GP6WJ5ILXSCHXSQILUF375V6O3DGA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest38(){
		const string publicKey = "0A3FDE6333489A55B96C9249FF132CCEAC099CD0DD78825147C232FA3895EF2E";
		const string addressPublic = "NCOGCHZGX43EJR2TE247SAXTHHVO6FWGYVOPROA";
		const string addressPublicTest = "TCOGCHZGX43EJR2TE247SAXTHHVO6FWGYXQZZJQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest39(){
		const string publicKey = "F54ABDE55F127E1F3C17AC08356D022708D0B08C478D365F044EA562760F6A23";
		const string addressPublic = "NBT26QBLS3NBYBA7UWTWVUKGLS4YE2XL7U6QTGI";
		const string addressPublicTest = "TBT26QBLS3NBYBA7UWTWVUKGLS4YE2XL7XDPBZY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest40(){
		const string publicKey = "B5E57A064530A0EE26B2BCF3204094FF353650AAF678E3B28444B9127CEF6A1A";
		const string addressPublic = "NBBPUUZO4GOSMSVQ7SFYQRXA7YIWMUUSDXF547I";
		const string addressPublicTest = "TBBPUUZO4GOSMSVQ7SFYQRXA7YIWMUUSDUFVNWI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest41(){
		const string publicKey = "7DEB408A8C0DD9BC4BE52F7A3BD77FD19208607D408719B53783255812AAF85E";
		const string addressPublic = "NCP2ANFQEQ3N3ABAUVXR27K4DBDSJDRT2SNXW3Y";
		const string addressPublicTest = "TCP2ANFQEQ3N3ABAUVXR27K4DBDSJDRT2S2G7VA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest42(){
		const string publicKey = "8A4A955D608990E88E16F8A2B0D930721051335990F78E395ADB94737DDABD4A";
		const string addressPublic = "NCMLUZMDNAGNM5G6FVMYWBZZCTJIB762HAXWSCI";
		const string addressPublicTest = "TCMLUZMDNAGNM5G6FVMYWBZZCTJIB762HAIFHZQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest43(){
		const string publicKey = "58C850F60AB1CEBE91CAB1FB84F6BA7C508B104F1B33DC0FCA78349046F193AE";
		const string addressPublic = "NANTVW3F7XGWWOJEGMRJSGBLDO7TPS4OMGSH4BI";
		const string addressPublicTest = "TANTVW3F7XGWWOJEGMRJSGBLDO7TPS4OME7CO3Y";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest44(){
		const string publicKey = "3AA00A4C6513FDBA24FBCFABB198DD55F3313DE07497BDA1FD5B68FDB5719B45";
		const string addressPublic = "NDXYBWTF6HYRIKIYEKQWP5MY6X7KXSJZIUF4IMQ";
		const string addressPublicTest = "TDXYBWTF6HYRIKIYEKQWP5MY6X7KXSJZIV4KYNA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest45(){
		const string publicKey = "8A547404FDD238364A8ABD69DF08DFA8A06131CDA7ACB280D85CA4543BC363D4";
		const string addressPublic = "NABYZLVAZIYT3UQBQ4ZOFFZ7TRWHL5S2WYUIW5A";
		const string addressPublicTest = "TABYZLVAZIYT3UQBQ4ZOFFZ7TRWHL5S2WZXVGLQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest46(){
		const string publicKey = "46CB0DE73999493172B10BA860A50357A8BD155695CDEB47698643DF5D2CA822";
		const string addressPublic = "NAXJ6XG3IK5WTVCNEP3YPXGRK2DA6KAICCM7UMA";
		const string addressPublicTest = "TAXJ6XG3IK5WTVCNEP3YPXGRK2DA6KAICCUWDWA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest47(){
		const string publicKey = "8F7E1DD1D6AD9BD9E4D31B07662AC1FE61A33C36B5C2ED4CD63FACF2AA8EC5CA";
		const string addressPublic = "NDO55HCRRU4TTIWIGCO4YFQO5AWNEYXCTNOXWDQ";
		const string addressPublicTest = "TDO55HCRRU4TTIWIGCO4YFQO5AWNEYXCTONQWHQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest48(){
		const string publicKey = "336F5E8760B1F776B018F925859FC5FF9F36AB8A35C85F46644C2D332F66C3D9";
		const string addressPublic = "NBD5S554WDLNSB2OWYCSUBJNAP4O5W4DNPHELZY";
		const string addressPublicTest = "TBD5S554WDLNSB2OWYCSUBJNAP4O5W4DNOACGUY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest49(){
		const string publicKey = "9496F9AB5E7A67471B17AA03C08E713C1269D977BE8ED89E8E146C58E3D5D627";
		const string addressPublic = "NDTFG5VTWIFOKVBOC2Z3V4AV7ILYLP3ZT2CK5OQ";
		const string addressPublicTest = "TDTFG5VTWIFOKVBOC2Z3V4AV7ILYLP3ZT3GU7MA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest50(){
		const string publicKey = "EA0CFA0172516CDEDAFE699F36FCAE0FE83D214A42AF1C59BCC71F8CF99A082E";
		const string addressPublic = "NAYAFZG5ZQ5VQ4CO6WCQRHH5WO3UAVUL4KOGXHA";
		const string addressPublicTest = "TAYAFZG5ZQ5VQ4CO6WCQRHH5WO3UAVUL4KDU3AQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest51(){
		const string publicKey = "87BA32C5948ABB5201C147BCE9670B2742FCF736AC6194B0F34F9765B503C9FF";
		const string addressPublic = "NDXEUSXXKAKHE5UKWW7IPWTMOJPFJE4RCWLLOQI";
		const string addressPublicTest = "TDXEUSXXKAKHE5UKWW7IPWTMOJPFJE4RCXJBSKY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest52(){
		const string publicKey = "00084077DBEFAF96F323517413246C5987E9ADEE5515505797F8EC98F4FADC40";
		const string addressPublic = "NBYI2HV466HRSZXV4NHPXTLHXLB5BSYHT67XWPI";
		const string addressPublicTest = "TBYI2HV466HRSZXV4NHPXTLHXLB5BSYHT6CXMBI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest53(){
		const string publicKey = "9AE768899590E452E56271AF5ECAD1D87D30B312FE3CEE112BCDD1C328102960";
		const string addressPublic = "NAGHS7PQOVWDOX3V6LA5WRJXPURSFRDG25Z7XIY";
		const string addressPublicTest = "TAGHS7PQOVWDOX3V6LA5WRJXPURSFRDG26JQDAY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest54(){
		const string publicKey = "B05C89CAEC584724ABECA5F0AB84BB677945A4E1D937D09A7904AC0423FF9EFF";
		const string addressPublic = "NAQFT5NB4L6LXMS4FGKZ3PPHCRTSO7QH5YNKR2Q";
		const string addressPublicTest = "TAQFT5NB4L6LXMS4FGKZ3PPHCRTSO7QH5YHSHRQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest55(){
		const string publicKey = "D61CB8A4C94C10B38540335027AAB2C61436E11C51F74935672D0D89B6002E78";
		const string addressPublic = "NDY5JAQLSW3CFGQM5B4SI7FMYFV6TET6N6Q44AI";
		const string addressPublicTest = "TDY5JAQLSW3CFGQM5B4SI7FMYFV6TET6N75O5JQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest56(){
		const string publicKey = "70ED05BDC639E70CC191A4A19333319A7EB52AB5AC808FF315B48F4D598AE3FE";
		const string addressPublic = "NABS3YC5IHCPIO3ZVG4J6NMURUFWA3Z2ZKSFSXI";
		const string addressPublicTest = "TABS3YC5IHCPIO3ZVG4J6NMURUFWA3Z2ZKABLIY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest57(){
		const string publicKey = "74A9B0FD8F67F98085571CEFB7C618FA5CAF4AFB88641825E46214A74CCBA870";
		const string addressPublic = "NB3V2CXYTHU62Z55HCI2KEFRBQ6RYLXUSTCLPYQ";
		const string addressPublicTest = "TB3V2CXYTHU62Z55HCI2KEFRBQ6RYLXUSRPRSUI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest58(){
		const string publicKey = "720C805FEF9E0EDCC15DC9B73F3D125BA4AA989BB13FB612700F348533128238";
		const string addressPublic = "NDHHZKKJ2PS4WF6TMBGXGUYNVGLMU5Q5EV2RXBA";
		const string addressPublicTest = "TDHHZKKJ2PS4WF6TMBGXGUYNVGLMU5Q5EWW267I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest59(){
		const string publicKey = "BC0BDA1293549E2C1EC3AD2B92695BD8C0F4E9FDDA0C1A7908A446218803634F";
		const string addressPublic = "NDPOGIVO57Y5WEP4NPI6QMPVP3GYF7UK2ZOKVVA";
		const string addressPublicTest = "TDPOGIVO57Y5WEP4NPI6QMPVP3GYF7UK22ENOYA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest60(){
		const string publicKey = "5EC2A8B19099B5DF682C824115D29837DB3269F4C500114FAA9BB942EC2EA5DA";
		const string addressPublic = "NB3CMFBJHF7W6MNPU3FJBQPTU6BQXBTTJAETMAY";
		const string addressPublicTest = "TB3CMFBJHF7W6MNPU3FJBQPTU6BQXBTTJANUJCA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest61(){
		const string publicKey = "8AAA835DB08F9F0EE3E3827F19AE715AAB68F021C7F81809FEDE026EAEA9396D";
		const string addressPublic = "NAFNNSOGYDZCQA7WGPQM46JOMJSEMNPHIND7LAY";
		const string addressPublicTest = "TAFNNSOGYDZCQA7WGPQM46JOMJSEMNPHIONUQZA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest62(){
		const string publicKey = "B32DAFA0B390BA6C865B3925FB131660D8A93BC46B763CE93200602BEAB9A103";
		const string addressPublic = "NC57RKW5VYKLA75EVQVQUB6L65RR4YDUEDTI7OQ";
		const string addressPublicTest = "TC57RKW5VYKLA75EVQVQUB6L65RR4YDUECZE4IY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest63(){
		const string publicKey = "8F6D0FEAAB357BE092DF4004BFF33131DC3D9AC060130E266EDC549FAF01935C";
		const string addressPublic = "NBG6ZR6B7SUGLHKUPWW7GUWX4DDURETEAQ3A27A";
		const string addressPublicTest = "TBG6ZR6B7SUGLHKUPWW7GUWX4DDURETEAQKVYHY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest64(){
		const string publicKey = "7AAF72D71F4EA2A05BBD378999B2640EE3AB2B393A5E5BA5636B79DA5AEA70B0";
		const string addressPublic = "NALERCPSTMKJDCPYMSUCBFENMPJRHC6TTROJINI";
		const string addressPublicTest = "TALERCPSTMKJDCPYMSUCBFENMPJRHC6TTQOPAFI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest65(){
		const string publicKey = "55852179F31592896ED404AD3ECB67C17BA249B5ADFE5F6000595D03D143DD59";
		const string addressPublic = "NDMUVBO45KGR44KJNMN7WZCM2P2HROTDE4ZEQIY";
		const string addressPublicTest = "TDMUVBO45KGR44KJNMN7WZCM2P2HROTDE6WCPJQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest66(){
		const string publicKey = "A5FD3CB43E14510191632B93839AB438D81D4D2FF0340038DD7976BCD22881EE";
		const string addressPublic = "NCCRI2IIHT4CJTL6IHRWZU4VEQEC65FD6UDV3DY";
		const string addressPublicTest = "TCCRI2IIHT4CJTL6IHRWZU4VEQEC65FD6U36M3I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest67(){
		const string publicKey = "944703F34D243B95F2E8867156FEEF59B814833F1CB385EED49D9DB1ECB66E38";
		const string addressPublic = "NCBURPEQGQHFTWJVPENSRRZRDMLRT35PPIPLF5A";
		const string addressPublicTest = "TCBURPEQGQHFTWJVPENSRRZRDMLRT35PPILX27Q";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest68(){
		const string publicKey = "5D48594D696F64623F71F80EB11EDEF6F0526FE07BBC9D4CB34E463F777BC37D";
		const string addressPublic = "NCITMNC4BXHGK6LDAQTKMLZ3SMBCGK3ZTPADGPY";
		const string addressPublicTest = "TCITMNC4BXHGK6LDAQTKMLZ3SMBCGK3ZTN3NWMA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest69(){
		const string publicKey = "AE3D90A7DC53C642F75502988A649756D0E1C3C1F2418DFF380D0CA72A6BC029";
		const string addressPublic = "NA4PVM52XLUGA6MRALODLM4ZT75754GNSJYSWBI";
		const string addressPublicTest = "TA4PVM52XLUGA6MRALODLM4ZT75754GNSKN4FXA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest70(){
		const string publicKey = "E4CA2EE5722E0ACF9111A97DF9D0418345905A70D7CF2C7A4959CB96CDCC572B";
		const string addressPublic = "NCVDXDVZUHLBFU4KL4HCLVIEHYGSAW4ZJ3NPSBA";
		const string addressPublicTest = "TCVDXDVZUHLBFU4KL4HCLVIEHYGSAW4ZJ2IKNYA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest71(){
		const string publicKey = "E909826693D76A847FAB7361C3EF1D6DA2911A52205894D4EEBE811EBADC8B49";
		const string addressPublic = "NCTKAOMZ43Y6K6QKZE7V3I7YJRLE7MBWXHNRHFY";
		const string addressPublicTest = "TCTKAOMZ43Y6K6QKZE7V3I7YJRLE7MBWXG5ATMA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest72(){
		const string publicKey = "6C0B0E2F470D28BBD5E06CC94C0993B2CB9DE7593F5B98841BEBEE7C0E377528";
		const string addressPublic = "NB2Z3G2E3QJVUCLSD43MSWF7WHY2PSLY66USF4A";
		const string addressPublicTest = "TB2Z3G2E3QJVUCLSD43MSWF7WHY2PSLY64NYGCQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest73(){
		const string publicKey = "304A1C5C09B12E617F36F67A0B098D6EE736F5A9912740C30D90BB846E78B3EB";
		const string addressPublic = "NDHXJF3M2YRGOSMJBVJLCR7VLHNC5P3WSAIVLZY";
		const string addressPublicTest = "TDHXJF3M2YRGOSMJBVJLCR7VLHNC5P3WSBHFTRQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest74(){
		const string publicKey = "5407AA5484C94D604A066EB87753DF8383C5938DF65BFCED1B94F554CC7BB70E";
		const string addressPublic = "NB5XRUM5I6W6EO65US67YY4YC6O7JPGMLTUIW2Q";
		const string addressPublicTest = "TB5XRUM5I6W6EO65US67YY4YC6O7JPGMLQWEJKY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest75(){
		const string publicKey = "D467711AF6C44E79D9A7A0CFC41161310BD82BC9BA41674A5D6F2BC6EF4A6A53";
		const string addressPublic = "NAJVWOFJEYF3EMTBJUE6DUR6Z7AUIYGPGOZ7J7Q";
		const string addressPublicTest = "TAJVWOFJEYF3EMTBJUE6DUR6Z7AUIYGPGP5YKNQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest76(){
		const string publicKey = "5DECBBE27F7E02516C9136A3F46C92F43168C03EFD315E623F78E240DFFA5CB6";
		const string addressPublic = "NDQPZZPQISGAVLZOFLUQ7LFSLNGHEOO755R2AJA";
		const string addressPublicTest = "TDQPZZPQISGAVLZOFLUQ7LFSLNGHEOO755ZFHNA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest77(){
		const string publicKey = "F6AC6800032D29059CDF3B46C8D6B299902F29EDC98C12AC7C8DCDABD49D575E";
		const string addressPublic = "NCKPOQHRHQRHJ4OQAZIIKUSV5AHSWOBPQH6AOVA";
		const string addressPublicTest = "TCKPOQHRHQRHJ4OQAZIIKUSV5AHSWOBPQHEWDEQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest78(){
		const string publicKey = "4BDCC3997CF3C9C002E6CD042B8C47C2BFBDBC21883D1B67487A268C51A833AB";
		const string addressPublic = "NBAEHLDWRDEG4QQZHC27WHP5XEAXB6RG46JXXAY";
		const string addressPublicTest = "TBAEHLDWRDEG4QQZHC27WHP5XEAXB6RG47CR2WQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest79(){
		const string publicKey = "C17B6BD6F540B23744F089B89873C27549BAD8994320D38F6E675CA2253992F5";
		const string addressPublic = "NBD2W342RHREXWWFA5ODT7L6UDTCAMR3EMLDNOI";
		const string addressPublicTest = "TBD2W342RHREXWWFA5ODT7L6UDTCAMR3EPCC6UA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest80(){
		const string publicKey = "68E72F2A32C0010340EE6F5FC2568C4F6F8604F77551C047344C09AFF5A5F3F7";
		const string addressPublic = "NBR4Z353Q7OKJH6NWBYNO6FERR2TYWFEBX3IQ6I";
		const string addressPublicTest = "TBR4Z353Q7OKJH6NWBYNO6FERR2TYWFEBXRN6WI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest81(){
		const string publicKey = "B0D26474AA9F8D667EFBD486F8AE0470E7A180145F49014476401B6EA6CA5A48";
		const string addressPublic = "NCDPIJNTU7JDM3PUKMTTQGOHU2FMOVIHMHBDSPY";
		const string addressPublicTest = "TCDPIJNTU7JDM3PUKMTTQGOHU2FMOVIHMEHR4NA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest82(){
		const string publicKey = "D75944FEE125B1001663BC1FB122983508D25EA1A064DCB7C4F00A1512478F76";
		const string addressPublic = "NAJB4IBG3XJ7QAO4AG5BKK6GCKY2CWW6JRE5F6A";
		const string addressPublicTest = "TAJB4IBG3XJ7QAO4AG5BKK6GCKY2CWW6JQ7UFOI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest83(){
		const string publicKey = "C78A06F01DD4A4DF1D17FF3252F319CC37E1781AD23DD6E29F2B4EA594F0295E";
		const string addressPublic = "NB5UOTL4MCWZQ3VXCBN42NH57G7JSS3VIKBXQYY";
		const string addressPublicTest = "TB5UOTL4MCWZQ3VXCBN42NH57G7JSS3VIL6Z72A";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest84(){
		const string publicKey = "2A3085C19701086E08B762E5B63D46F0686E02D376E7B59634B4C636B9EE6139";
		const string addressPublic = "NCF2KRNZCTZJI2EBKZOFHZVKPKEFYWIW4MUKYCQ";
		const string addressPublicTest = "TCF2KRNZCTZJI2EBKZOFHZVKPKEFYWIW4NKUGEY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest85(){
		const string publicKey = "5E0D1CF2353BC177257A87CE0824EAF729954EA89DB2D212F582D371D4B093D9";
		const string addressPublic = "NAVDUF6TARTRZ3XSIJSJ3DYUIVYOAH7Z2BA6NRQ";
		const string addressPublicTest = "TAVDUF6TARTRZ3XSIJSJ3DYUIVYOAH7Z2AIX5GQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest86(){
		const string publicKey = "2E9683E77D6E3649A757334167C005EBEB18FAE4B627B531A6AE209964CB9924";
		const string addressPublic = "ND6FFODEM6CTNANQLK4W4CECOC2HVZSAMTT2DHY";
		const string addressPublicTest = "TD6FFODEM6CTNANQLK4W4CECOC2HVZSAMSSQWNY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest87(){
		const string publicKey = "DD644DAC7D463191072CE4CE1F66F22D9FBD49A5627131635D5A4A21F7E46293";
		const string addressPublic = "NCDMF3PHSGQ6YYZULHF3ODOTYPNJQ22UR3BFDGA";
		const string addressPublicTest = "TCDMF3PHSGQ6YYZULHF3ODOTYPNJQ22URZKS53I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest88(){
		const string publicKey = "DD12B744C6D609B73D6E5530F09531B7F550419711EDDC30BE9BF4757FD83E4F";
		const string addressPublic = "NBOQCRJD7KM4GWPZ3KCQRBXFCO5UZD2G33UPQVY";
		const string addressPublicTest = "TBOQCRJD7KM4GWPZ3KCQRBXFCO5UZD2G33R4MOI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest89(){
		const string publicKey = "83C65CE6D8EAFC8598BB551807998634C8392393018AC9F7233171EBF87665D0";
		const string addressPublic = "NBRHLGGLXMLTTACLLZPJHVS6CSXTSMEFMEGOLJQ";
		const string addressPublicTest = "TBRHLGGLXMLTTACLLZPJHVS6CSXTSMEFMFUZUYY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest90(){
		const string publicKey = "49CB996AEF0E981BA2E7C085E98827ACBB3516DF0A33098EBD3BEF3F13FC2DE6";
		const string addressPublic = "NCYPSUT5VUWWQ47VCAUWM2V5XQ4FC5WGAA7ST6I";
		const string addressPublicTest = "TCYPSUT5VUWWQ47VCAUWM2V5XQ4FC5WGABSCN6I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest91(){
		const string publicKey = "CA3709EB28ED7A4269373575DD4AB5EC0A8E833AC1365377268B4F304F84E417";
		const string addressPublic = "NDQH6CT4BQDV4OQ32FWJGZWMPTMVXBIPCCU4HWQ";
		const string addressPublicTest = "TDQH6CT4BQDV4OQ32FWJGZWMPTMVXBIPCDEIMJA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest92(){
		const string publicKey = "FA4C8249A845001CB31D4DD46F431C881C7115E448F7F76E21F1191F189A6D99";
		const string addressPublic = "NARTSZRFXJDOYK7CS4CQ6ZL3UVFSCO5XVDXMLBY";
		const string addressPublicTest = "TARTSZRFXJDOYK7CS4CQ6ZL3UVFSCO5XVCEJNVY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest93(){
		const string publicKey = "C6EA81E39EBD78E9991BC01D24290834B86F1D5BB10E9E95A1A1FD68EC1DC981";
		const string addressPublic = "NDCI7ZJTP4X7Y5FND3QSTTSZWAQ2AAMH2PBNQOI";
		const string addressPublicTest = "TDCI7ZJTP4X7Y5FND3QSTTSZWAQ2AAMH2NGE3CI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest94(){
		const string publicKey = "69CD731BF0B50DA4C92CC6456DD038F1AE888E1D8E03C2E0F67562D013F6C497";
		const string addressPublic = "NDAZENKNG2EHHFQLHRQABHCKQ32L3INAEVVO2VQ";
		const string addressPublicTest = "TDAZENKNG2EHHFQLHRQABHCKQ32L3INAEWHLIAQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest95(){
		const string publicKey = "4ED2853CEFD48B6DE9FE845D438BD749B1AD7EA468AA90E03824C5B54617E0D5";
		const string addressPublic = "NCHISSQVWOQDCEXCLYM6DBFPONAHFKU5R35NM7Q";
		const string addressPublicTest = "TCHISSQVWOQDCEXCLYM6DBFPONAHFKU5R2GR77Y";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest96(){
		const string publicKey = "941F12508F9349902CF74922F359DB46C025FB8C18DB02BAE2D49A89A72150CC";
		const string addressPublic = "NAOFXANOKDU32AFZGML5AWBGTAHRCGV3DUW4OPQ";
		const string addressPublicTest = "TAOFXANOKDU32AFZGML5AWBGTAHRCGV3DXEOY4A";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest97(){
		const string publicKey = "CAA5007ECE8A0FD64AC2E3E608F365641B3A5EB7BCC692538435B99999445195";
		const string addressPublic = "NATMPLPQ5OGUBBGIMUCDV5JRKSLC6S57ANFENLY";
		const string addressPublicTest = "TATMPLPQ5OGUBBGIMUCDV5JRKSLC6S57APVIK3I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest98(){
		const string publicKey = "2A55B2208801CF27DC653119318129803EB14217F0A2A0152293EFCECF68F05A";
		const string addressPublic = "NDLUPDKVRN4UR5J2A25Z3NJBZB7GP36XFBTDZTY";
		const string addressPublicTest = "TDLUPDKVRN4UR5J2A25Z3NJBZB7GP36XFDSJTVQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest99(){
		const string publicKey = "41978CA2D3D1FC82C295A3D1ED97C462A910DF939C6135E410C6F177A65D51C0";
		const string addressPublic = "NCE34LT6XVFFKZJQGQC32JW5DSFMAA3YKSZCRHI";
		const string addressPublicTest = "TCE34LT6XVFFKZJQGQC32JW5DSFMAA3YKSL32YI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest100(){
		const string publicKey = "561D099C7804B68A20F4F97C13FE1177900D5B7A25F44B287EFCC8E6CFA152D4";
		const string addressPublic = "NBJZHSEDD4DB3TD3L4PFWSFNHYBVSI7YF6SSE4Q";
		const string addressPublicTest = "TBJZHSEDD4DB3TD3L4PFWSFNHYBVSI7YF5RZ4RA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
}}