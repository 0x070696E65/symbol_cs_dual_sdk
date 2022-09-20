
using CatSdk.Facade;
using CatSdk.Nem.Factory;
using CatSdk.Utils;
using NUnit.Framework;

namespace Test.Nem;
public class AddressTest
{
    private readonly NemFacade MainFacade = new (Network.MainNet);
    private readonly NemFacade TestFacade = new (Network.TestNet);
	[Test]
	public void AddressTest0(){
		const string publicKey = "C5F54BA980FCBB657DBAAA42700539B207873E134D2375EFEAB5F1AB52F87844";
		const string addressPublic = "NDD2CT6LQLIYQ56KIXI3ENTM6EK3D44P5JFXJ4R4";
		const string addressPublicTest = "TDD2CT6LQLIYQ56KIXI3ENTM6EK3D44P5KZPFMK2";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest1(){
		const string publicKey = "96EB2A145211B1B7AB5F0D4B14F8ABC8D695C7AEE31A3CFC2D4881313C68EEA3";
		const string addressPublic = "NABHFGE5ORQD3LE4O6B7JUFN47ECOFBFASC3SCAC";
		const string addressPublicTest = "TABHFGE5ORQD3LE4O6B7JUFN47ECOFBFATE53N2I";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest2(){
		const string publicKey = "2D8425E4CA2D8926346C7A7CA39826ACD881A8639E81BD68820409C6E30D142A";
		const string addressPublic = "NAVOZX4HDVOAR4W6K4WJHWPD3MOFU27DFHC7KZOZ";
		const string addressPublicTest = "TAVOZX4HDVOAR4W6K4WJHWPD3MOFU27DFEJDR2PR";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest3(){
		const string publicKey = "4FEED486777ED38E44C489C7C4E93A830E4C4A907FA19A174E630EF0F6ED0409";
		const string addressPublic = "NBZ6JK5YOCU6UPSSZ5D3G27UHAPHTY5HDQMGE6TT";
		const string addressPublicTest = "TBZ6JK5YOCU6UPSSZ5D3G27UHAPHTY5HDQCDS5YA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest4(){
		const string publicKey = "83EE32E4E145024D29BCA54F71FA335A98B3E68283F1A3099C4D4AE113B53E54";
		const string addressPublic = "NCQW2P5DNZ5BBXQVGS367DQ4AHC3RXOEVGRCLY6V";
		const string addressPublicTest = "TCQW2P5DNZ5BBXQVGS367DQ4AHC3RXOEVFZOQCJ6";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest5(){
		const string publicKey = "6D34C04F3A0E42F0C3C6F50E475AE018CFA2F56DF58C481AD4300424A6270CBB";
		const string addressPublic = "NA5IG3XFXZHIPJ5QLKX2FBJPEZYPMBPPK2ZRC3EH";
		const string addressPublicTest = "TA5IG3XFXZHIPJ5QLKX2FBJPEZYPMBPPKYOTH5YB";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest6(){
		const string publicKey = "A8FEFD72A3B833DC7C7ED7D57ED86906DAC22F88F1F4331873EB2DA3152A3E77";
		const string addressPublic = "NAABHVFJDBM74XMJJ52R7QN2MTTG2ZUXPQS62QZ7";
		const string addressPublicTest = "TAABHVFJDBM74XMJJ52R7QN2MTTG2ZUXPQ3F2EPH";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest7(){
		const string publicKey = "C92F761E6D83D20068FD46FE4BD5B97F4C6BA05D23180679B718D1F3E4FB066E";
		const string addressPublic = "NCLK3OLMHR3F2E3KSBUIZ4K5PNWUDN37MLSJBJZP";
		const string addressPublicTest = "TCLK3OLMHR3F2E3KSBUIZ4K5PNWUDN37MIBR5TMD";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest8(){
		const string publicKey = "EAF16A4833E59370A04CCD5C63395058DE34877B48C17174C71DB5ED37B537ED";
		const string addressPublic = "ND3AHW4VTI5R5QE5V44KIGPRU5FBJ5AFUCJXOY5H";
		const string addressPublicTest = "TD3AHW4VTI5R5QE5V44KIGPRU5FBJ5AFUCOCH2F6";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest9(){
		const string publicKey = "0F74A2F537CD9C986DF018994DDE75BDEEE05E35EB9FE27ADF506CA8475064F7";
		const string addressPublic = "NCTZ4YAP43ONK3UYTASQVNDMBO24ZHJE65F3QPYE";
		const string addressPublicTest = "TCTZ4YAP43ONK3UYTASQVNDMBO24ZHJE6463O47W";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest10(){
		const string publicKey = "2EBFF201255F6CF948C78F528658B99A7C13AC791942FA22D59AF610558111F5";
		const string addressPublic = "NDQ2TMCMXBSFPZQPE2YKH6XLC24HD6LUMN6Z4GIC";
		const string addressPublicTest = "TDQ2TMCMXBSFPZQPE2YKH6XLC24HD6LUMPY4ZMGO";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest11(){
		const string publicKey = "419ED11D48730E4AE2C93F0EA4DF853B8D578713A36DAB227517CF965861AF4E";
		const string addressPublic = "NA32IDDW2C53BDSBJNFL3Z6UU3J5CJZJMCZDXCF4";
		const string addressPublicTest = "TA32IDDW2C53BDSBJNFL3Z6UU3J5CJZJMCFK5INY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest12(){
		const string publicKey = "A160E6F9112233A7CE94202ED7A4443E1DAC444B5095F9FECBB965FBA3F92CAC";
		const string addressPublic = "NADUCEQLC3FTGB25GTA5HOUTB53CBVQNVOIP7NTJ";
		const string addressPublicTest = "TADUCEQLC3FTGB25GTA5HOUTB53CBVQNVOWQQSXC";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest13(){
		const string publicKey = "FBB91B16DF828E21A9802980A44FC757C588BC1382A4CEA429D6FA2AE0333F56";
		const string addressPublic = "NBAF3BFLLPWH33MYE6VUPP5T6DQBZBKIDEQKZQOE";
		const string addressPublicTest = "TBAF3BFLLPWH33MYE6VUPP5T6DQBZBKIDGA56VWB";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest14(){
		const string publicKey = "2232F24DDA0F2DED3ECD831210D4E8521A096B50CADD5A34F3F7083374E1EC12";
		const string addressPublic = "NBOGTK2I2ATOGGD7ZFJHROG5MWL7XCKAUKSWIVSA";
		const string addressPublicTest = "TBOGTK2I2ATOGGD7ZFJHROG5MWL7XCKAUKIJSRTQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest15(){
		const string publicKey = "C334C6C0DAD5AAA2A0D0FB4C6032CB6A0EDD96BF61125B5EA9062D5A00EE0EEE";
		const string addressPublic = "NCLERTEFYXKLK7RA4MVACEFMXMK3P7QMWTM7FBW2";
		const string addressPublicTest = "TCLERTEFYXKLK7RA4MVACEFMXMK3P7QMWT6VIJME";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest16(){
		const string publicKey = "518C4DE412EFA93DE06A55947D11F697639443916EC8FCF04EBC3E6D17D0BD93";
		const string addressPublic = "NB5V4BPIJHXVONO7UGMJDPFARMFA73BOBNOOYCOV";
		const string addressPublicTest = "TB5V4BPIJHXVONO7UGMJDPFARMFA73BOBPC7ZUD4";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest17(){
		const string publicKey = "B3D16F4EAD9DE67C290144DA535A0ED2504B03C05E5F1CEB8C7863762F786857";
		const string addressPublic = "NC4PBAO5TPCAVQKBVOC4F6DMZP3CFSQBU46PSKBD";
		const string addressPublicTest = "TC4PBAO5TPCAVQKBVOC4F6DMZP3CFSQBU4MRJ3UN";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest18(){
		const string publicKey = "7E7716E4CEBCEB731D6F1FD28676F34888E9A0000FCFA1471DB1C616C2DDF559";
		const string addressPublic = "NCFW2LPXIWLBWAQN2QVIWEOD7IVDO3HQBD2OU56K";
		const string addressPublicTest = "TCFW2LPXIWLBWAQN2QVIWEOD7IVDO3HQBD7CFIUG";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest19(){
		const string publicKey = "114171230AD6F8522A000CDC73FBC5C733B30BB71F2B146CCBDF34499F79A810";
		const string addressPublic = "NCUKWDY3J3THKQHAKOK5ALF6ANJQABZHCH7VN6DP";
		const string addressPublicTest = "TCUKWDY3J3THKQHAKOK5ALF6ANJQABZHCFN6NTQ3";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest20(){
		const string publicKey = "45805BBFDB19429A966594E9B9952103DB3D2BA22F05D1C1A2E761076A5E01ED";
		const string addressPublic = "NCFYU27SUDN6CKMS5QTYJW4FG6T7M3VTZWYT73J5";
		const string addressPublicTest = "TCFYU27SUDN6CKMS5QTYJW4FG6T7M3VTZVHCD2LC";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest21(){
		const string publicKey = "259B1AF615E30F99B9CD424EE0E18E24A2721560A9E02CD7A21AC13FBDDC967E";
		const string addressPublic = "NDBESMFCE3VQ5JIBL2U2DZLOKB4EWSKMX357J72A";
		const string addressPublicTest = "TDBESMFCE3VQ5JIBL2U2DZLOKB4EWSKMXZ4LWA7L";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest22(){
		const string publicKey = "F2A4D7F476F3EE9A961CDEF405DD7504B38D64D14C4E17B7AB71E71C8FB3B4E7";
		const string addressPublic = "NCNRRYOUAVHXA2LZHJPONSPZQ36QYSSESUEVKJLO";
		const string addressPublicTest = "TCNRRYOUAVHXA2LZHJPONSPZQ36QYSSESW66QRCG";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest23(){
		const string publicKey = "3490D4F6C9AA283B67AE4A9B2E65346462237705D98433351FEBFF457956D89F";
		const string addressPublic = "NDESTDJAZ42BQVFM7O7LITP22FE5Z7VR6FNU7BZ6";
		const string addressPublicTest = "TDESTDJAZ42BQVFM7O7LITP22FE5Z7VR6G6XCGXP";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest24(){
		const string publicKey = "EA3A5D45CB356E72771009253A385B6267BBDDE1863CBCC687793508F5B659C3";
		const string addressPublic = "NCLP3JRVI2S7LTZJYEUVUTWXI54QJ5ZBJLTFP3QN";
		const string addressPublicTest = "TCLP3JRVI2S7LTZJYEUVUTWXI54QJ5ZBJLGM5BZE";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest25(){
		const string publicKey = "F8D82B7C69C7B7FB7DBD3CC11591E6B0163E0F4C17644F3B935E0D8A096C7CE1";
		const string addressPublic = "NDLGVZZU5V2VVEJ6BIZDQI6HYEPSMJ5LJFUF7U46";
		const string addressPublicTest = "TDLGVZZU5V2VVEJ6BIZDQI6HYEPSMJ5LJE4GH4JS";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest26(){
		const string publicKey = "7FAA6F65050C5AC97F6FD907555764232CF69307C123C0A197A8B8A2715FE8A9";
		const string addressPublic = "NAOSK7KRU3XOD2UCBMTUIBXV4CSPRLKY756UMG24";
		const string addressPublicTest = "TAOSK7KRU3XOD2UCBMTUIBXV4CSPRLKY77XK3R73";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest27(){
		const string publicKey = "6726D4CFA270165CE4C10CA6FFA15035679889A976FE5925A58ED642EC90AD35";
		const string addressPublic = "NBYB5MIVLX4YKD7TTSJMF2ZROJMAWVT64KUFU4VB";
		const string addressPublicTest = "TBYB5MIVLX4YKD7TTSJMF2ZROJMAWVT64JW54ORN";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest28(){
		const string publicKey = "9F68BD343B565D2333EE1E507541411868C4D15727F6D7451E31F2FC20084268";
		const string addressPublic = "NBADKGYLJAFLZ4GQE4RSKSCQZFBAV5TP7ARRQ3XO";
		const string addressPublicTest = "TBADKGYLJAFLZ4GQE4RSKSCQZFBAV5TP7B6YX3OT";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest29(){
		const string publicKey = "D556956E4AE43D4146335820819018C2F0723E4D5C03B18FFFFA8FC1096B832D";
		const string addressPublic = "NCZRJTC75YILMUCCEPNHSLFLOGPMR3CQUJS2ZXFL";
		const string addressPublicTest = "TCZRJTC75YILMUCCEPNHSLFLOGPMR3CQUIB6IQ33";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest30(){
		const string publicKey = "06B4E42DF71524D7EF443DEC4EB95F701990799C796F695C2933F856465F8CB4";
		const string addressPublic = "ND7JJ3NWV5JGMRA46MJLT7JO5K354YMVWG45CSP5";
		const string addressPublicTest = "TD7JJ3NWV5JGMRA46MJLT7JO5K354YMVWF3ERFEE";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest31(){
		const string publicKey = "3BDEFE140C710AE70EC227396CFF553DB8310DAD36CDCFC6904FA02B917F75B9";
		const string addressPublic = "NAN346HPWBUYNN7HFPPUJOPUSIC4F44QPLD26JQ6";
		const string addressPublicTest = "TAN346HPWBUYNN7HFPPUJOPUSIC4F44QPI5APOHI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest32(){
		const string publicKey = "A8B5BE9454477CF3A8F811D27582E3DAC210A44AE6F839F11849FA6DB5A4B1B0";
		const string addressPublic = "NABEJ57HBE27RU47EBR3CWPDSVOW3QI5J2EW4YYL";
		const string addressPublicTest = "TABEJ57HBE27RU47EBR3CWPDSVOW3QI5JYK3CONO";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest33(){
		const string publicKey = "F25E35D046714A74079F60EA83C8011C746768A77E5D7CEDF8EDFEC17379FBD5";
		const string addressPublic = "NAWCD4PWVZQSXPXTRPC3MX5ODGGQ4GBTCSV4L5QY";
		const string addressPublicTest = "TAWCD4PWVZQSXPXTRPC3MX5ODGGQ4GBTCSMD5YWH";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest34(){
		const string publicKey = "66D5EE2F7A9A29CC9F17B9B89EF829311698AF97CC76B3B480EE9E50BB3E666B";
		const string addressPublic = "NBB6U5PPRFMTG2Y4JIXLN75RM2XRX2GVHECVZVP2";
		const string addressPublicTest = "TBB6U5PPRFMTG2Y4JIXLN75RM2XRX2GVHEYCNUA7";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest35(){
		const string publicKey = "2E6A2F37B6C1B30B3695E9019DFFE12D41FCB94937C41A91009230E6AAC8A387";
		const string addressPublic = "NADZTPHU4NOR4RDM2TTRDGJ3CMSP7WX7SX5XGJLW";
		const string addressPublicTest = "TADZTPHU4NOR4RDM2TTRDGJ3CMSP7WX7SUW26EH4";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest36(){
		const string publicKey = "8B69D79F0F4B8D990EE1BC0A748D6257445A3F14C8BE716375A6770D510C2177";
		const string addressPublic = "NAME6JRX3Y6DN2TPORXO5C7TLRFD7EH4ERGU25VT";
		const string addressPublicTest = "TAME6JRX3Y6DN2TPORXO5C7TLRFD7EH4ETH6LXA6";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest37(){
		const string publicKey = "29F98A5CD53748837221ACA6FCB0A81A3843DB7C58543AA56771D0671701384D";
		const string addressPublic = "NDT7V4JBORZJITRIWJAWHLVQELKVHCEIEVFKA5YM";
		const string addressPublicTest = "TDT7V4JBORZJITRIWJAWHLVQELKVHCEIEUO4CFSG";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest38(){
		const string publicKey = "846781656FFFF388FA0A3E269CC6FA47111C35F4239F7D3B31F4186CF3E685AC";
		const string addressPublic = "NB4BJOXS345QEQ6VPGTMMOXAIXJ3PL765HHSS3WJ";
		const string addressPublicTest = "TB4BJOXS345QEQ6VPGTMMOXAIXJ3PL765GGV4LDT";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest39(){
		const string publicKey = "9D12D7E8AEBCB5B051CC7A5E294DD1F155D41203AB9B49C16DA7025CD07C8BFF";
		const string addressPublic = "NAYSINTQORROCA2SL7Y4E7HYXDZC6UEV4SVQHOEQ";
		const string addressPublicTest = "TAYSINTQORROCA2SL7Y4E7HYXDZC6UEV4STJK2PL";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest40(){
		const string publicKey = "8BF389B6002627096A3EF7E2A887E3A9CF75D5CEC129EE868A9AEF003F905CDA";
		const string addressPublic = "NB74OGBUWV7WXCUVQRTZDMTCKEHOZPUJYRGM5ABN";
		const string addressPublicTest = "TB74OGBUWV7WXCUVQRTZDMTCKEHOZPUJYS3KFNIL";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest41(){
		const string publicKey = "93A007AC04D2A3C23E18C47EF2DB530611DBF7AB3F46B9A5AE7E679811149D5D";
		const string addressPublic = "NDUDMB5ZDM2RIKTUY5UPZPJDJGE5K3BCI6VWEQSW";
		const string addressPublicTest = "TDUDMB5ZDM2RIKTUY5UPZPJDJGE5K3BCI6D3G32K";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest42(){
		const string publicKey = "DC6BBF9B99DBB3F0C78B5D8A05C64CF8A1C57DF717E45B3C0141BE6B8813F59D";
		const string addressPublic = "NCBL3M4KSBTF3SLPRKJEJPNQ7WIIZ5YG7N6QGKIH";
		const string addressPublicTest = "TCBL3M4KSBTF3SLPRKJEJPNQ7WIIZ5YG7OTXRTLX";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest43(){
		const string publicKey = "E9AA7F6098BA2724AF5242896A011799EF68FDC8D32C9E7BDBFB302B8EE08624";
		const string addressPublic = "NAY6MZJXKAYUK3FQ6A63S4WCGCU7AL6ESNWMRUAE";
		const string addressPublicTest = "TAY6MZJXKAYUK3FQ6A63S4WCGCU7AL6ESOGHKC4M";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest44(){
		const string publicKey = "74823277F456E17E0F23D1DD6CB4BF6CA7400D4A2773C2D6038D15908D34AEB8";
		const string addressPublic = "NCYWGHHWFBM7S7P5G77HK45OAEWZFSNZG7IYQVWB";
		const string addressPublicTest = "TCYWGHHWFBM7S7P5G77HK45OAEWZFSNZG5RYN6YL";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest45(){
		const string publicKey = "D85DA973EAD32FCFBF530CE3439376B6C9AD586A5E50DF02CE59AB6306C1F2DE";
		const string addressPublic = "NBKRNTCH2IMIX4R4IQ6DLCQMP6WH36K65BWFP4XE";
		const string addressPublicTest = "TBKRNTCH2IMIX4R4IQ6DLCQMP6WH36K65CDWY7TO";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest46(){
		const string publicKey = "4B0613DBC252DD4B2AE64EDDB6D129A5DF8D101B0E1F89D52DD0F86B597EB8BA";
		const string addressPublic = "NA552MN4NV4BZMYPZN57SXC37UPGWYRL7EYAPLSX";
		const string addressPublicTest = "TA552MN4NV4BZMYPZN57SXC37UPGWYRL7GYBAO5J";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest47(){
		const string publicKey = "4C99395D0B568DF09965A751EBF8B27B892C7E4369BD44DA6088FA4247224A23";
		const string addressPublic = "NDGSAMNUPE6QDSF47GCQLVU2BDDVWSONBEH4DVUF";
		const string addressPublicTest = "TDGSAMNUPE6QDSF47GCQLVU2BDDVWSONBEPOD4UT";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest48(){
		const string publicKey = "5473F2A2959545FC666BAB2CDC9819EE31D4E9B35E8671E60F09608ECF716F44";
		const string addressPublic = "NDV6S7KBE4AFNE5TP5CZZDL3CG64WBTCUQWUTBTE";
		const string addressPublicTest = "TDV6S7KBE4AFNE5TP5CZZDL3CG64WBTCUR4NQVSC";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest49(){
		const string publicKey = "CAA4ED99B20B2DF6ACFADF8CD96249C64A543E96672F18347D36DA9F2706DAAE";
		const string addressPublic = "NBQ6YHOHHNN6XLGM3KNGFVONAKGPAVXBGTBDERCL";
		const string addressPublicTest = "TBQ6YHOHHNN6XLGM3KNGFVONAKGPAVXBGQAWL32N";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest50(){
		const string publicKey = "20E88DCED65AA9F79824414B6BD1E4818E55291368E5685BFB2584F209530019";
		const string addressPublic = "NC65FTL2VVWKR4MAHN3T5I2RFQS5GEYJQRNIEWNR";
		const string addressPublicTest = "TC65FTL2VVWKR4MAHN3T5I2RFQS5GEYJQRJCP2DA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest51(){
		const string publicKey = "635E447622429E5A29B95D06D3C06933A93258ECFAE8C194E828AC41256B4FDB";
		const string addressPublic = "NAAEBHZTU7IBFMW74UVMGQCDLSJEEGUKF2QZQAKZ";
		const string addressPublicTest = "TAAEBHZTU7IBFMW74UVMGQCDLSJEEGUKFZ7LPCDC";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest52(){
		const string publicKey = "81AE7A3865B751C106AD25F5E061FC388320F74007CCB8C0CFB056838B73DD8D";
		const string addressPublic = "NCPEHY3JOEISNA5M2CCO7P25G6PD5J76XESK5G2U";
		const string addressPublicTest = "TCPEHY3JOEISNA5M2CCO7P25G6PD5J76XEAFQDEQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest53(){
		const string publicKey = "C5D57D018E10194EBEC1D17ABA6F2CCEE5C89346256AB7239C0C99AA878CCC05";
		const string addressPublic = "NDHUHVEZJVKIHW3VBKXEV5UP4QEAZXRJL3IME5HH";
		const string addressPublicTest = "TDHUHVEZJVKIHW3VBKXEV5UP4QEAZXRJL2AY4EGY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest54(){
		const string publicKey = "CEB8C611DDDF3010C39DA7D037C1C329605E138155CE54EE13CE839F33AF01BA";
		const string addressPublic = "NBCBJ7XIDZJZO4GML56VBRA5LYQKR7JFKOGAPW2O";
		const string addressPublicTest = "TBCBJ7XIDZJZO4GML56VBRA5LYQKR7JFKMDUI7IK";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest55(){
		const string publicKey = "04B3096BEB55E71F9F0894AEF76755FA42DB3FE203FAF53F43669840F1D6E98A";
		const string addressPublic = "NBLBELHQ4KKUQR3TT4VUDXQJJCS72C2SYV2KAICT";
		const string addressPublicTest = "TBLBELHQ4KKUQR3TT4VUDXQJJCS72C2SYURRU3FM";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest56(){
		const string publicKey = "8EFE7BF9BF22CC16EA8D2AD69A28AEDF96E013A537EF67D7F67ED8347A70E101";
		const string addressPublic = "NCNBFLUZYLUJL4JTM6JGRJVVGM6BSGUQO3YBBXPR";
		const string addressPublicTest = "TCNBFLUZYLUJL4JTM6JGRJVVGM6BSGUQO3Y44C7K";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest57(){
		const string publicKey = "94F69C18DD6CBF4FC5315CF8AC81EC2D1904612E516509FAC4CFB2AFDC391BE4";
		const string addressPublic = "NAMLW7L5U7BOWT6U2XQLZGJJX6NLHLFG4Y576UD7";
		const string addressPublicTest = "TAMLW7L5U7BOWT6U2XQLZGJJX6NLHLFG43JC2USM";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest58(){
		const string publicKey = "73630D4DAD66BD21554E664771BE3B977F0EFB465B350E9BAC71A7D88C53BEC7";
		const string addressPublic = "NCWSBPHCQST6GG3CFKM57K6NFH4OWKYHQEIWSC7E";
		const string addressPublicTest = "TCWSBPHCQST6GG3CFKM57K6NFH4OWKYHQEDAAKPF";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest59(){
		const string publicKey = "6EF9EEA4D5F7488D7EBDB2D8E988FD5E500FB2E86A8D066E9000D7DF8F2E553E";
		const string addressPublic = "NBBCBRW7ZZGHEC6WCZXIPCXHCIQM577UCGBJGHL4";
		const string addressPublicTest = "TBBCBRW7ZZGHEC6WCZXIPCXHCIQM577UCFQXNLSF";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest60(){
		const string publicKey = "378DD0C80D407CEBF6646386F23F6B1DC1A93FCCE72C0DBBF4961152B5F96135";
		const string addressPublic = "NBAU5GIWGVD7XF7QG66NB7FMWCLMXGPGO6IYXROH";
		const string addressPublicTest = "TBAU5GIWGVD7XF7QG66NB7FMWCLMXGPGO6WBQLWI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest61(){
		const string publicKey = "AE89210A00582BE6234AB161ECBFE833B5CF002B130790B246D172B017842C57";
		const string addressPublic = "NB3ROQY6QKAHBKDBBGITRGW65NJCKNM7P535TMLR";
		const string addressPublicTest = "TB3ROQY6QKAHBKDBBGITRGW65NJCKNM7P4V5FCNU";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest62(){
		const string publicKey = "6E692FA360E2EB870D0C5CEF7CA48B3638BE5FB669DEAD7498A6EA3DF00DEB5A";
		const string addressPublic = "NAEZGTDJAWBL6NSHZQRPYGJQHWYQJM6UEOGH74UU";
		const string addressPublicTest = "TAEZGTDJAWBL6NSHZQRPYGJQHWYQJM6UEPBZ4FVH";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest63(){
		const string publicKey = "72E1850D494669F6D66B373C756950A85327F8F907A7B34FFF5F19BDD5B396EA";
		const string addressPublic = "NBRE3BR76OYSBUY4LIXQBINL5TWUCTZ6N6X4665K";
		const string addressPublicTest = "TBRE3BR76OYSBUY4LIXQBINL5TWUCTZ6N4METFSV";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest64(){
		const string publicKey = "4534662EB281B0B10749BE7F48DEDE1214FEEA33E10277E9DBB36A78377C27E6";
		const string addressPublic = "ND4HSLNH6NTPBFD7FUNOFNKBHGHSIDH7HOK6QXBW";
		const string addressPublicTest = "TD4HSLNH6NTPBFD7FUNOFNKBHGHSIDH7HMDRLFY5";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest65(){
		const string publicKey = "5987B772E5F920F478CD7145B138550CFBE98C61480A465732154B2E006A62BB";
		const string addressPublic = "NAVVBJMAJXUJW3KC53K6RNIZMDR4ZPEGVTJCCGWA";
		const string addressPublicTest = "TAVVBJMAJXUJW3KC53K6RNIZMDR4ZPEGVQSEJENA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest66(){
		const string publicKey = "717AF33A5B7563A9F89628689337095104B60536FF27158A5E5C83579912091C";
		const string addressPublic = "NAAZMTDTLQKJOWSNRXQLYIO6JGSFCPH5FKBLFNHQ";
		const string addressPublicTest = "TAAZMTDTLQKJOWSNRXQLYIO6JGSFCPH5FLQPADLD";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest67(){
		const string publicKey = "92B3BE33317D31B75FCB4D66D38834B3A22785774D8BD9D024C76C52EE74D0F3";
		const string addressPublic = "NBUUXDLE7NNG6H55OQ2MYFEFI726L2GX3PLUNB5Z";
		const string addressPublicTest = "TBUUXDLE7NNG6H55OQ2MYFEFI726L2GX3MB7IVY5";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest68(){
		const string publicKey = "13B18C4AC2F57D8A8B2E2CB86FC6EE6E3B240202D96AC858116A568F2879C32C";
		const string addressPublic = "NAWUXZATK2REXNYJUYRDFYYRS4PCYOGR4WOZ3Q34";
		const string addressPublicTest = "TAWUXZATK2REXNYJUYRDFYYRS4PCYOGR4W2QZ7VY";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest69(){
		const string publicKey = "42554B1120BF811430C46C287383C49E4120D651D04BA6C3D27247A792C9BB8E";
		const string addressPublic = "NAQQ6MEBR2E3R733OU6WLGZ6RHO2LOX64T3A2TUV";
		const string addressPublicTest = "TAQQ6MEBR2E3R733OU6WLGZ6RHO2LOX64QE37ZZA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest70(){
		const string publicKey = "19A017A739D57C8C3EFE8C70F659D5DA3836C7623BD12C2C6C938D963FEBC3A7";
		const string addressPublic = "NCFEEAVSZAPFP6GRWTO63GXERCB4OCYT3LWRMP37";
		const string addressPublicTest = "TCFEEAVSZAPFP6GRWTO63GXERCB4OCYT3LDM3LOO";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest71(){
		const string publicKey = "D278BD0429CEF8C98A6F2578A0B5C22473F6E4075F6F78CF97FF308EFC6EB8EE";
		const string addressPublic = "NBS4OD7T77R5SOQGZ5A7CBW5XHEGSH32WY2KA634";
		const string addressPublicTest = "TBS4OD7T77R5SOQGZ5A7CBW5XHEGSH32WZKRW5HI";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest72(){
		const string publicKey = "37D53D4C441ADAAD6C58CAECABEF0C94C619EB498002942C95C5250E0C0C1FD6";
		const string addressPublic = "NDDP2HPLQOQAPZAF54ISMWXCXQXBQVHS3ZBCIIYA";
		const string addressPublicTest = "TDDP2HPLQOQAPZAF54ISMWXCXQXBQVHS32CSSXJK";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest73(){
		const string publicKey = "82BD01F5161E282AFCDBD9E826CACCB09AE7AB04FF5C7056E11472EC83E73162";
		const string addressPublic = "ND3VXKFTTIEKYV63DJENJEHN2UWVFS7YJ3ZH5NWZ";
		const string addressPublicTest = "TD3VXKFTTIEKYV63DJENJEHN2UWVFS7YJ3L3OJCV";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest74(){
		const string publicKey = "70FF48C3BA2D3C5B3689BB37208742947BE6E2E4F733CB46B4C0805B8FEDE3AF";
		const string addressPublic = "NDGCIXMC6PJMZU77X4XVP7VCRSWIYSJBP7327O77";
		const string addressPublicTest = "TDGCIXMC6PJMZU77X4XVP7VCRSWIYSJBP6TOMXDL";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest75(){
		const string publicKey = "9C2761EB63CAB8BEA09AB0C5764A3AB51FA5B033FBF3803E3C419FF26E57B94F";
		const string addressPublic = "NAHYFYC56TI3RNFX7WCF6FUANIHHM7VWWTJ4HS4Y";
		const string addressPublicTest = "TAHYFYC56TI3RNFX7WCF6FUANIHHM7VWWRXENIIL";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest76(){
		const string publicKey = "91819FC4315B9F596661ADF1243369B540752A3BDFC84ED1B6F5DFD6A6BA52D2";
		const string addressPublic = "NDAJP6EOIZVWFKBXFVAZITHH5ELM6JALGJGCYISR";
		const string addressPublicTest = "TDAJP6EOIZVWFKBXFVAZITHH5ELM6JALGKH6BYEC";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest77(){
		const string publicKey = "EDD43646F677EBCA32BBB9E66C3A87BDEB6AAB77AF515E879EDC5CEFFF6FA5BE";
		const string addressPublic = "NBNZHYHHZS7P4I4UK3XN37WBGD2AEYDV6ZRPSBEQ";
		const string addressPublicTest = "TBNZHYHHZS7P4I4UK3XN37WBGD2AEYDV62LUXXEE";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest78(){
		const string publicKey = "B8BC4A02489CE1F25F30C9C931F40EC808E7D0D5079B8445AFD8039A3EC85B8D";
		const string addressPublic = "NB47BK5CPZU5C4BN7XTSS3MBSAYXWZG5KVQDTQGP";
		const string addressPublicTest = "TB47BK5CPZU5C4BN7XTSS3MBSAYXWZG5KWXTAWE6";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest79(){
		const string publicKey = "35FB191592199A1E8D0F827A9729DBE36A149C01B9B8290DFA65E30F3333F07A";
		const string addressPublic = "NDZT6AOU5ASUEMFEMCIJPRTMB33LL62QV7XWGCGV";
		const string addressPublicTest = "TDZT6AOU5ASUEMFEMCIJPRTMB33LL62QV6DNE6S2";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest80(){
		const string publicKey = "54C876736017EE2BC5970CB9B94229C3FD3E0201AEAF183134D3D4E8A6EEF73B";
		const string addressPublic = "NBQCADWFAH2JLV5STAQSYZ3RIQARC2LHSSVI6HY6";
		const string addressPublicTest = "TBQCADWFAH2JLV5STAQSYZ3RIQARC2LHSQEGO34V";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest81(){
		const string publicKey = "8EEB4AEFB49BB75BBC2AC979E9A90DBEF7C82A57F9A756454488E9071F52DF3A";
		const string addressPublic = "NDV27AJKLMES76WV6RY2B4E23SE2PEZCYY7OJFTS";
		const string addressPublicTest = "TDV27AJKLMES76WV6RY2B4E23SE2PEZCY2Q5KMSA";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest82(){
		const string publicKey = "8F61F18CC2297DC364F2A34E9CD255923B2CBE21004201A337BED4A7B71BED27";
		const string addressPublic = "NC4PSRKCXJHIFSQAWCHNAMF7ZO7UDPWSVDJ472YR";
		const string addressPublicTest = "TC4PSRKCXJHIFSQAWCHNAMF7ZO7UDPWSVCOWXKCD";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest83(){
		const string publicKey = "A6623C70B5924EEE7E12DEA59947020FA7D881F6B8089B36935DB9F1247EFC77";
		const string addressPublic = "ND2SDSMSKFOXBDVY4HGONO77PRYFLLE724RZDGHM";
		const string addressPublicTest = "TD2SDSMSKFOXBDVY4HGONO77PRYFLLE725LU6LW2";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest84(){
		const string publicKey = "D4714F69C3704B1B0B2DA350C6534BC74B20CF473F2EAF7B745A6A5A9ED59300";
		const string addressPublic = "NC5TE6IPSV4STHWNLBG5FP7M7T5ZVQNAKOYY6DW2";
		const string addressPublicTest = "TC5TE6IPSV4STHWNLBG5FP7M7T5ZVQNAKPO5Z7C4";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest85(){
		const string publicKey = "1FB915EB23EFCF1445AD94736D65A350743C2B200F7C71AB90242832B435E378";
		const string addressPublic = "NBP6AR2Q6742W57UA62CZ5GDHLHDLWI3ACTCDLD2";
		const string addressPublicTest = "TBP6AR2Q6742W57UA62CZ5GDHLHDLWI3ABVN2WDM";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest86(){
		const string publicKey = "8C03CA739E667154333939F1BC72C13E2BD424027FDEEA00EC5D53AE5C4E8381";
		const string addressPublic = "NBEOXMTQDLFJQER4BMR4O3HS2YGCQ7YPNZK44JOV";
		const string addressPublicTest = "TBEOXMTQDLFJQER4BMR4O3HS2YGCQ7YPNYUQJVT2";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest87(){
		const string publicKey = "D39AD162F80C8F46388FC0F6554FAEDACD103A542EF182C3E769F98CF1DBCD4E";
		const string addressPublic = "ND6F7B2QSCXRJIECHAVBDWOC4X4GZMDW2RTRL7BW";
		const string addressPublicTest = "TD6F7B2QSCXRJIECHAVBDWOC4X4GZMDW2SOUX4MF";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest88(){
		const string publicKey = "B03868BD563619A306A51E357DDE3F5EE3AB7F0C92054F9B91E2A15BC64778A5";
		const string addressPublic = "NBW52U3YKMF3BQTZMMDCPQ7IAN7Q3XKW75PZ5BQI";
		const string addressPublicTest = "TBW52U3YKMF3BQTZMMDCPQ7IAN7Q3XKW7644W6RM";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest89(){
		const string publicKey = "58194AE528AC47A580BA0B22A7EBC5D0C39FA61BC5B31F75D7CBF744FF2806CD";
		const string addressPublic = "NDA42LD56DVS76OP6VBQGPIDM5QNC5O7OXTKVOHH";
		const string addressPublicTest = "TDA42LD56DVS76OP6VBQGPIDM5QNC5O7OVLLW6FZ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest90(){
		const string publicKey = "B913FA2AA54D1E6D069B0B00E17CC400B918D9B58C7BE7065894363D63637E32";
		const string addressPublic = "NB7R3E4EHQSTBHQC6NNZ6UE4ZVVPW4BURMUEZHOH";
		const string addressPublicTest = "TB7R3E4EHQSTBHQC6NNZ6UE4ZVVPW4BURNNXCG34";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest91(){
		const string publicKey = "BFDB6844940A6384B87CFBAC23FEA0D14E9546C61C402C001A6019275964ACEA";
		const string addressPublic = "NCGWXEBJSZT2FVFM3Q5MOXZH4P7NOVM7LORBNNM4";
		const string addressPublicTest = "TCGWXEBJSZT2FVFM3Q5MOXZH4P7NOVM7LMT3IE2R";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest92(){
		const string publicKey = "8EE9C6705F62D6A313F7107D714C774E58842C78CE8456032F82ED2AD53A7619";
		const string addressPublic = "NA63NOWQR6C3PGVLO3MWNVTIMKLWI5JJIMVLZQ4E";
		const string addressPublicTest = "TA63NOWQR6C3PGVLO3MWNVTIMKLWI5JJINX26DMQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest93(){
		const string publicKey = "A4D2AAB0D41B05505C68B247C0F33B0BF4E69C470313D13A9D9562CDCC1A65C5";
		const string addressPublic = "NANANV6GBTTYMSKUPIGLM42HVQ3BR6IJ27YMAVXZ";
		const string addressPublicTest = "TANANV6GBTTYMSKUPIGLM42HVQ3BR6IJ27IZB6ON";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest94(){
		const string publicKey = "34F6C1C312BBAE520F3B1C9AC3FA82F8B4627F63BC5FC448E8AE8BF7668A16A1";
		const string addressPublic = "NCOG4OAXYF4ZMSA7Y5KK2FRIE7SMDX7V2RVQCXCL";
		const string addressPublicTest = "TCOG4OAXYF4ZMSA7Y5KK2FRIE7SMDX7V2TOBR4XW";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest95(){
		const string publicKey = "9B08C8E9792CF4475E30D69FF81D51F6D2C25B20ACF4FFCC825718B0D95D987A";
		const string addressPublic = "ND6VXNWHPB27CJLCHFZHIVMSGJPATEOOWZ3AKUWH";
		const string addressPublicTest = "TD6VXNWHPB27CJLCHFZHIVMSGJPATEOOWYEENKOQ";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest96(){
		const string publicKey = "4F7F8B5368C079066D4473D9D29809AA9D305A4E9DEB580DC44E0D87FF99832E";
		const string addressPublic = "NAXSRIAGQWLZCG6P6W4VRL5DN4SOW7TXM3GAOWGQ";
		const string addressPublicTest = "TAXSRIAGQWLZCG6P6W4VRL5DN4SOW7TXMZ3G7UFF";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest97(){
		const string publicKey = "2556E669D10695653C62E319636250A0F1A64513029E7D7899B302338AF374C4";
		const string addressPublic = "NA5E5XWJCS3S3RPDUCHXPE7C7VE4PUW4VLUTYDGT";
		const string addressPublicTest = "TA5E5XWJCS3S3RPDUCHXPE7C7VE4PUW4VJ7VJANL";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest98(){
		const string publicKey = "0F1722EF86DD54D30192F6B60822D1B52C9DBD014A720DA641528E20CEC72CD0";
		const string addressPublic = "NC7ZWGCSHD3TA2KESMFMRZZPQFEMSI6BNXMCPB6Z";
		const string addressPublicTest = "TC7ZWGCSHD3TA2KESMFMRZZPQFEMSI6BNVNON5B7";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest99(){
		const string publicKey = "D984038FDE5FA6274A2B3E485F060832894E44664F0C58097C8866290A7ACAB2";
		const string addressPublic = "NACOURFE7GRWUXMJ57FYLQCDBUH6SJRRDC2J5YBB";
		const string addressPublicTest = "TACOURFE7GRWUXMJ57FYLQCDBUH6SJRRDBPSO3VO";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
	[Test]
	public void AddressTest100(){
		const string publicKey = "DD57802D5A89FB10A653B81E2FDD43C128D55CB77D2078CFD574EC52905658C8";
		const string addressPublic = "NCYTWYHTWT3EQLWT6UYBG23NMVDUXUL6H2CYDNHB";
		const string addressPublicTest = "TCYTWYHTWT3EQLWT6UYBG23NMVDUXUL6HYH5FLL2";
		var mainAddress = MainFacade.Network.PublicKeyToAddress(publicKey).ToString();
		var testAddress = TestFacade.Network.PublicKeyToAddress(publicKey).ToString();
		Assert.AreEqual(addressPublic, mainAddress);
		Assert.AreEqual(addressPublicTest, testAddress);
	}
}