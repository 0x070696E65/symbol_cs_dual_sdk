
using System.Collections.Generic;
using NUnit.Framework;
using CatSdk.Facade;
using CatSdk.Nem.Factory;
using CatSdk.Nem;
using CatSdk.Utils;

namespace Test.Nem;
public class TransactionTest
{
    private readonly NemFacade Facade = new (Network.TestNet);    
	[Test]
	public void AccountKeyLinkTransaction_account_key_link_single_1(){
		var payload = "0108000001000098701EE77120000000A087A6358B302A25EDBD5B990AA0BBBC04C9C13911C579C8538CE880E368A8AC400000009CB67E932354C553B34E2B8E6253B3E0C3A30E00D97D3F402B846975D681650CFB5BEF94415FDFE02EDEC9EA0F45D4728E65588F21BCC8A465E16D356D209964E0FEEEEFFEEEEFFE0000000001000000200000006269E26026CECEFE640C3E0DE050CB9B3CFD279A0713CF00E16EDEF5D6C10EB9";
		var descriptor = new Dictionary<string, object>(){
			{"Type", "account_key_link_transaction"},
			{"LinkAction", LinkAction.LINK},
			{"RemotePublicKey", new PublicKey(Converter.HexToBytes("6269E26026CECEFE640C3E0DE050CB9B3CFD279A0713CF00E16EDEF5D6C10EB9"))},
			{"SignerPublicKey", new PublicKey(Converter.HexToBytes("a087a6358b302a25edbd5b990aa0bbbc04c9c13911c579c8538ce880e368a8ac"))},
			{"Signature", new Signature(Converter.HexToBytes("9CB67E932354C553B34E2B8E6253B3E0C3A30E00D97D3F402B846975D681650CFB5BEF94415FDFE02EDEC9EA0F45D4728E65588F21BCC8A465E16D356D209964"))},
			{"Fee", new Amount(18370164183782063840)},
			{"Timestamp", new Timestamp(1910972016)},
		};
		var tx = Facade.TransactionFactory.Create(descriptor);
		Assert.AreEqual(payload, Converter.BytesToHex(tx.Serialize()));
	}
}