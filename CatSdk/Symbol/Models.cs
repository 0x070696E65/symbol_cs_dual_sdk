using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CatSdk.Utils;
namespace CatSdk.Symbol{

public class Amount : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public Amount(ulong amount = 0): base(SIZE, amount) {
	}

	public static Amount Deserialize(BinaryReader br) {
		return new Amount(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class BlockDuration : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public BlockDuration(ulong blockDuration = 0): base(SIZE, blockDuration) {
	}

	public static BlockDuration Deserialize(BinaryReader br) {
		return new BlockDuration(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class BlockFeeMultiplier : BaseValue, ISerializer {
	public const byte SIZE = 4;

	public BlockFeeMultiplier(uint blockFeeMultiplier = 0): base(SIZE, blockFeeMultiplier) {
	}

	public static BlockFeeMultiplier Deserialize(BinaryReader br) {
		return new BlockFeeMultiplier(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((uint)Value);
	}
}

public class Difficulty : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public Difficulty(ulong difficulty = 0): base(SIZE, difficulty) {
	}

	public static Difficulty Deserialize(BinaryReader br) {
		return new Difficulty(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class FinalizationEpoch : BaseValue, ISerializer {
	public const byte SIZE = 4;

	public FinalizationEpoch(uint finalizationEpoch = 0): base(SIZE, finalizationEpoch) {
	}

	public static FinalizationEpoch Deserialize(BinaryReader br) {
		return new FinalizationEpoch(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((uint)Value);
	}
}

public class FinalizationPoint : BaseValue, ISerializer {
	public const byte SIZE = 4;

	public FinalizationPoint(uint finalizationPoint = 0): base(SIZE, finalizationPoint) {
	}

	public static FinalizationPoint Deserialize(BinaryReader br) {
		return new FinalizationPoint(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((uint)Value);
	}
}

public class Height : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public Height(ulong height = 0): base(SIZE, height) {
	}

	public static Height Deserialize(BinaryReader br) {
		return new Height(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class Importance : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public Importance(ulong importance = 0): base(SIZE, importance) {
	}

	public static Importance Deserialize(BinaryReader br) {
		return new Importance(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class ImportanceHeight : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public ImportanceHeight(ulong importanceHeight = 0): base(SIZE, importanceHeight) {
	}

	public static ImportanceHeight Deserialize(BinaryReader br) {
		return new ImportanceHeight(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class UnresolvedMosaicId : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public UnresolvedMosaicId(ulong unresolvedMosaicId = 0): base(SIZE, unresolvedMosaicId) {
	}

	public static UnresolvedMosaicId Deserialize(BinaryReader br) {
		return new UnresolvedMosaicId(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class MosaicId : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public MosaicId(ulong mosaicId = 0): base(SIZE, mosaicId) {
	}

	public static MosaicId Deserialize(BinaryReader br) {
		return new MosaicId(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class Timestamp : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public Timestamp(ulong timestamp = 0): base(SIZE, timestamp) {
	}

	public static Timestamp Deserialize(BinaryReader br) {
		return new Timestamp(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class UnresolvedAddress : ByteArray, ISerializer {
	public const byte SIZE = 24;

	public UnresolvedAddress(byte[]? unresolvedAddress = null): base(SIZE, unresolvedAddress) {
	}

	public static UnresolvedAddress Deserialize(BinaryReader br) {
		return new UnresolvedAddress(br.ReadBytes(24));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class Address : ByteArray, ISerializer {
	public const byte SIZE = 24;

	public Address(byte[]? address = null): base(SIZE, address) {
	}

	public static Address Deserialize(BinaryReader br) {
		return new Address(br.ReadBytes(24));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class Hash256 : ByteArray, ISerializer {
	public const byte SIZE = 32;

	public Hash256(byte[]? hash256 = null): base(SIZE, hash256) {
	}

	public static Hash256 Deserialize(BinaryReader br) {
		return new Hash256(br.ReadBytes(32));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class Hash512 : ByteArray, ISerializer {
	public const byte SIZE = 64;

	public Hash512(byte[]? hash512 = null): base(SIZE, hash512) {
	}

	public static Hash512 Deserialize(BinaryReader br) {
		return new Hash512(br.ReadBytes(64));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class PublicKey : ByteArray, ISerializer {
	public const byte SIZE = 32;

	public PublicKey(byte[]? publicKey = null): base(SIZE, publicKey) {
	}

	public static PublicKey Deserialize(BinaryReader br) {
		return new PublicKey(br.ReadBytes(32));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class VotingPublicKey : ByteArray, ISerializer {
	public const byte SIZE = 32;

	public VotingPublicKey(byte[]? votingPublicKey = null): base(SIZE, votingPublicKey) {
	}

	public static VotingPublicKey Deserialize(BinaryReader br) {
		return new VotingPublicKey(br.ReadBytes(32));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class Signature : ByteArray, ISerializer {
	public const byte SIZE = 64;

	public Signature(byte[]? signature = null): base(SIZE, signature) {
	}

	public static Signature Deserialize(BinaryReader br) {
		return new Signature(br.ReadBytes(64));
	}

	public byte[] Serialize() {
		return bytes;
	}
}

public class Mosaic : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"MosaicId", "pod:MosaicId"},
		{"Amount", "pod:Amount"}
	};

	public Mosaic() {
		MosaicId = new MosaicId();
		Amount = new Amount();
	}

	public void Sort() {
	}

	public MosaicId MosaicId { get; set; }

	public Amount Amount { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += MosaicId.Size;
			size += Amount.Size;
			return size;
		}
	}

	public static Mosaic Deserialize(BinaryReader br) {
		var mosaicId = MosaicId.Deserialize(br);
		var amount = Amount.Deserialize(br);

		var instance = new Mosaic()
		{
			MosaicId = mosaicId,
			Amount = amount
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Amount.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"mosaicId: {MosaicId}, ";
		result += $"amount: {Amount}, ";
		result += ")";
		return result;
	}
}

public class UnresolvedMosaic : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"Amount", "pod:Amount"}
	};

	public UnresolvedMosaic() {
		MosaicId = new UnresolvedMosaicId();
		Amount = new Amount();
	}

	public void Sort() {
	}

	public UnresolvedMosaicId MosaicId { get; set; }

	public Amount Amount { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += MosaicId.Size;
			size += Amount.Size;
			return size;
		}
	}

	public static UnresolvedMosaic Deserialize(BinaryReader br) {
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var amount = Amount.Deserialize(br);

		var instance = new UnresolvedMosaic()
		{
			MosaicId = mosaicId,
			Amount = amount
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Amount.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"mosaicId: {MosaicId}, ";
		result += $"amount: {Amount}, ";
		result += ")";
		return result;
	}
}

public class LinkAction : IEnum<byte> {
	public static readonly LinkAction UNLINK = new LinkAction(0);

	public static readonly LinkAction LINK = new LinkAction(1);

	public byte Value { get; }

	public LinkAction(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			0, 1
		};
		var keys = new []{
			"UNLINK", "LINK"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static LinkAction FromValue(uint value) {
		return value switch
		{
			0 => UNLINK,
			1 => LINK,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static LinkAction Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"LinkAction.{ValueToKey(Value)}";
	}
}

public class NetworkType : IEnum<byte> {
	public static readonly NetworkType MAINNET = new NetworkType(104);

	public static readonly NetworkType TESTNET = new NetworkType(152);

	public byte Value { get; }

	public NetworkType(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			104, 152
		};
		var keys = new []{
			"MAINNET", "TESTNET"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static NetworkType FromValue(uint value) {
		return value switch
		{
			104 => MAINNET,
			152 => TESTNET,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static NetworkType Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"NetworkType.{ValueToKey(Value)}";
	}
}

public class TransactionType : IEnum<ushort> {
	public static readonly TransactionType ACCOUNT_KEY_LINK = new TransactionType(16716);

	public static readonly TransactionType NODE_KEY_LINK = new TransactionType(16972);

	public static readonly TransactionType AGGREGATE_COMPLETE = new TransactionType(16705);

	public static readonly TransactionType AGGREGATE_BONDED = new TransactionType(16961);

	public static readonly TransactionType VOTING_KEY_LINK = new TransactionType(16707);

	public static readonly TransactionType VRF_KEY_LINK = new TransactionType(16963);

	public static readonly TransactionType HASH_LOCK = new TransactionType(16712);

	public static readonly TransactionType SECRET_LOCK = new TransactionType(16722);

	public static readonly TransactionType SECRET_PROOF = new TransactionType(16978);

	public static readonly TransactionType ACCOUNT_METADATA = new TransactionType(16708);

	public static readonly TransactionType MOSAIC_METADATA = new TransactionType(16964);

	public static readonly TransactionType NAMESPACE_METADATA = new TransactionType(17220);

	public static readonly TransactionType MOSAIC_DEFINITION = new TransactionType(16717);

	public static readonly TransactionType MOSAIC_SUPPLY_CHANGE = new TransactionType(16973);

	public static readonly TransactionType MOSAIC_SUPPLY_REVOCATION = new TransactionType(17229);

	public static readonly TransactionType MULTISIG_ACCOUNT_MODIFICATION = new TransactionType(16725);

	public static readonly TransactionType ADDRESS_ALIAS = new TransactionType(16974);

	public static readonly TransactionType MOSAIC_ALIAS = new TransactionType(17230);

	public static readonly TransactionType NAMESPACE_REGISTRATION = new TransactionType(16718);

	public static readonly TransactionType ACCOUNT_ADDRESS_RESTRICTION = new TransactionType(16720);

	public static readonly TransactionType ACCOUNT_MOSAIC_RESTRICTION = new TransactionType(16976);

	public static readonly TransactionType ACCOUNT_OPERATION_RESTRICTION = new TransactionType(17232);

	public static readonly TransactionType MOSAIC_ADDRESS_RESTRICTION = new TransactionType(16977);

	public static readonly TransactionType MOSAIC_GLOBAL_RESTRICTION = new TransactionType(16721);

	public static readonly TransactionType TRANSFER = new TransactionType(16724);

	public ushort Value { get; }

	public TransactionType(ushort value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			16716, 16972, 16705, 16961, 16707, 16963, 16712, 16722, 16978, 16708, 16964, 17220, 16717, 16973, 17229, 16725, 16974, 17230,
			16718, 16720, 16976, 17232, 16977, 16721, 16724
		};
		var keys = new []{
			"ACCOUNT_KEY_LINK", "NODE_KEY_LINK", "AGGREGATE_COMPLETE", "AGGREGATE_BONDED", "VOTING_KEY_LINK", "VRF_KEY_LINK", "HASH_LOCK",
			"SECRET_LOCK", "SECRET_PROOF", "ACCOUNT_METADATA", "MOSAIC_METADATA", "NAMESPACE_METADATA", "MOSAIC_DEFINITION",
			"MOSAIC_SUPPLY_CHANGE", "MOSAIC_SUPPLY_REVOCATION", "MULTISIG_ACCOUNT_MODIFICATION", "ADDRESS_ALIAS", "MOSAIC_ALIAS",
			"NAMESPACE_REGISTRATION", "ACCOUNT_ADDRESS_RESTRICTION", "ACCOUNT_MOSAIC_RESTRICTION", "ACCOUNT_OPERATION_RESTRICTION",
			"MOSAIC_ADDRESS_RESTRICTION", "MOSAIC_GLOBAL_RESTRICTION", "TRANSFER"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static TransactionType FromValue(uint value) {
		return value switch
		{
			16716 => ACCOUNT_KEY_LINK,
			16972 => NODE_KEY_LINK,
			16705 => AGGREGATE_COMPLETE,
			16961 => AGGREGATE_BONDED,
			16707 => VOTING_KEY_LINK,
			16963 => VRF_KEY_LINK,
			16712 => HASH_LOCK,
			16722 => SECRET_LOCK,
			16978 => SECRET_PROOF,
			16708 => ACCOUNT_METADATA,
			16964 => MOSAIC_METADATA,
			17220 => NAMESPACE_METADATA,
			16717 => MOSAIC_DEFINITION,
			16973 => MOSAIC_SUPPLY_CHANGE,
			17229 => MOSAIC_SUPPLY_REVOCATION,
			16725 => MULTISIG_ACCOUNT_MODIFICATION,
			16974 => ADDRESS_ALIAS,
			17230 => MOSAIC_ALIAS,
			16718 => NAMESPACE_REGISTRATION,
			16720 => ACCOUNT_ADDRESS_RESTRICTION,
			16976 => ACCOUNT_MOSAIC_RESTRICTION,
			17232 => ACCOUNT_OPERATION_RESTRICTION,
			16977 => MOSAIC_ADDRESS_RESTRICTION,
			16721 => MOSAIC_GLOBAL_RESTRICTION,
			16724 => TRANSFER,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 2;
		}
	}

	public static TransactionType Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt16());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"TransactionType.{ValueToKey(Value)}";
	}
}

public class Transaction : ITransaction {
	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"}
	};

	public Transaction() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = 0;
		Network = NetworkType.MAINNET;
		Type = TransactionType.ACCOUNT_KEY_LINK;
		Fee = new Amount();
		Deadline = new Timestamp();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			return size;
		}
	}

	public static Transaction Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);

		var instance = new Transaction()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedTransaction : IBaseTransaction {
	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"}
	};

	public EmbeddedTransaction() {
		SignerPublicKey = new PublicKey();
		Version = 0;
		Network = NetworkType.MAINNET;
		Type = TransactionType.ACCOUNT_KEY_LINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			return size;
		}
	}

	public static EmbeddedTransaction Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);

		var instance = new EmbeddedTransaction()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += ")";
		return result;
	}
}

public class AccountKeyLinkTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public AccountKeyLinkTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public PublicKey LinkedPublicKey { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += LinkedPublicKey.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static AccountKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var linkedPublicKey = PublicKey.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new AccountKeyLinkTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			LinkedPublicKey = linkedPublicKey,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedAccountKeyLinkTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedAccountKeyLinkTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public PublicKey LinkedPublicKey { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += LinkedPublicKey.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static EmbeddedAccountKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var linkedPublicKey = PublicKey.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new EmbeddedAccountKeyLinkTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			LinkedPublicKey = linkedPublicKey,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class NodeKeyLinkTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NODE_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public NodeKeyLinkTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public PublicKey LinkedPublicKey { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += LinkedPublicKey.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static NodeKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var linkedPublicKey = PublicKey.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new NodeKeyLinkTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			LinkedPublicKey = linkedPublicKey,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedNodeKeyLinkTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NODE_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedNodeKeyLinkTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public PublicKey LinkedPublicKey { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += LinkedPublicKey.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static EmbeddedNodeKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var linkedPublicKey = PublicKey.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new EmbeddedNodeKeyLinkTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			LinkedPublicKey = linkedPublicKey,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class Cosignature : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"}
	};

	public Cosignature() {
		Version = 0;
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
	}

	public void Sort() {
	}

	public ulong Version { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 8;
			size += SignerPublicKey.Size;
			size += Signature.Size;
			return size;
		}
	}

	public static Cosignature Deserialize(BinaryReader br) {
		var version = br.ReadUInt64();
		var signerPublicKey = PublicKey.Deserialize(br);
		var signature = Signature.Deserialize(br);

		var instance = new Cosignature()
		{
			Version = version,
			SignerPublicKey = signerPublicKey,
			Signature = signature
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((ulong)(ulong)Version)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Signature.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += ")";
		return result;
	}
}

public class DetachedCosignature : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"ParentHash", "pod:Hash256"}
	};

	public DetachedCosignature() {
		Version = 0;
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		ParentHash = new Hash256();
	}

	public void Sort() {
	}

	public ulong Version { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Hash256 ParentHash { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 8;
			size += SignerPublicKey.Size;
			size += Signature.Size;
			size += ParentHash.Size;
			return size;
		}
	}

	public static DetachedCosignature Deserialize(BinaryReader br) {
		var version = br.ReadUInt64();
		var signerPublicKey = PublicKey.Deserialize(br);
		var signature = Signature.Deserialize(br);
		var parentHash = Hash256.Deserialize(br);

		var instance = new DetachedCosignature()
		{
			Version = version,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			ParentHash = parentHash
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((ulong)(ulong)Version)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Signature.Serialize()); 
		bw.Write(ParentHash.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"parentHash: {ParentHash}, ";
		result += ")";
		return result;
	}
}

public class AggregateCompleteTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.AGGREGATE_COMPLETE;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AggregateTransactionHeaderReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TransactionsHash", "pod:Hash256"},
		{"Transactions", "array[EmbeddedTransaction]"},
		{"Cosignatures", "array[Cosignature]"}
	};

	public AggregateCompleteTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TransactionsHash = new Hash256();
		Transactions = Array.Empty<IBaseTransaction>();
		Cosignatures = Array.Empty<Cosignature>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AggregateTransactionHeaderReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Hash256 TransactionsHash { get; set; }

	public IBaseTransaction[] Transactions { get; set; }

	public Cosignature[] Cosignatures { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TransactionsHash.Size;
			size += 4;
			size += 4;
			size += ArrayHelpers.Size(Transactions, 8);
			size += ArrayHelpers.Size(Cosignatures);
			return size;
		}
	}

	public static AggregateCompleteTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var transactionsHash = Hash256.Deserialize(br);
		var payloadSize = br.ReadUInt32();
		var aggregateTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != aggregateTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({aggregateTransactionHeaderReserved_1})");
		var transactions = ArrayHelpers.ReadVariableSizeElements(br, EmbeddedTransactionFactory.Deserialize, payloadSize, 8);
		var cosignatures = ArrayHelpers.ReadArray(br, Cosignature.Deserialize);

		var instance = new AggregateCompleteTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TransactionsHash = transactionsHash,
			Transactions = transactions,
			Cosignatures = cosignatures
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TransactionsHash.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)ArrayHelpers.Size(Transactions, 8)));  // bound: payload_size
		bw.Write(BitConverter.GetBytes((uint)(uint)AggregateTransactionHeaderReserved_1)); 
		ArrayHelpers.WriteVariableSizeElements(bw, Transactions, 8);
		ArrayHelpers.WriteArray(bw, Cosignatures);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"transactionsHash: {TransactionsHash}, ";
		result += $"transactions: [{string.Join(",", Transactions.Select(e => e.ToString()))}], ";
		result += $"cosignatures: [{string.Join(",", Cosignatures.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class AggregateCompleteTransactionV2 : ITransaction {
	public const byte TRANSACTION_VERSION = 2;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.AGGREGATE_COMPLETE;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AggregateTransactionHeaderReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TransactionsHash", "pod:Hash256"},
		{"Transactions", "array[EmbeddedTransaction]"},
		{"Cosignatures", "array[Cosignature]"}
	};

	public AggregateCompleteTransactionV2() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TransactionsHash = new Hash256();
		Transactions = Array.Empty<IBaseTransaction>();
		Cosignatures = Array.Empty<Cosignature>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AggregateTransactionHeaderReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Hash256 TransactionsHash { get; set; }

	public IBaseTransaction[] Transactions { get; set; }

	public Cosignature[] Cosignatures { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TransactionsHash.Size;
			size += 4;
			size += 4;
			size += ArrayHelpers.Size(Transactions, 8);
			size += ArrayHelpers.Size(Cosignatures);
			return size;
		}
	}

	public static AggregateCompleteTransactionV2 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var transactionsHash = Hash256.Deserialize(br);
		var payloadSize = br.ReadUInt32();
		var aggregateTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != aggregateTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({aggregateTransactionHeaderReserved_1})");
		var transactions = ArrayHelpers.ReadVariableSizeElements(br, EmbeddedTransactionFactory.Deserialize, payloadSize, 8);
		var cosignatures = ArrayHelpers.ReadArray(br, Cosignature.Deserialize);

		var instance = new AggregateCompleteTransactionV2()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TransactionsHash = transactionsHash,
			Transactions = transactions,
			Cosignatures = cosignatures
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TransactionsHash.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)ArrayHelpers.Size(Transactions, 8)));  // bound: payload_size
		bw.Write(BitConverter.GetBytes((uint)(uint)AggregateTransactionHeaderReserved_1)); 
		ArrayHelpers.WriteVariableSizeElements(bw, Transactions, 8);
		ArrayHelpers.WriteArray(bw, Cosignatures);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"transactionsHash: {TransactionsHash}, ";
		result += $"transactions: [{string.Join(",", Transactions.Select(e => e.ToString()))}], ";
		result += $"cosignatures: [{string.Join(",", Cosignatures.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class AggregateBondedTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.AGGREGATE_BONDED;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AggregateTransactionHeaderReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TransactionsHash", "pod:Hash256"},
		{"Transactions", "array[EmbeddedTransaction]"},
		{"Cosignatures", "array[Cosignature]"}
	};

	public AggregateBondedTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TransactionsHash = new Hash256();
		Transactions = Array.Empty<IBaseTransaction>();
		Cosignatures = Array.Empty<Cosignature>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AggregateTransactionHeaderReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Hash256 TransactionsHash { get; set; }

	public IBaseTransaction[] Transactions { get; set; }

	public Cosignature[] Cosignatures { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TransactionsHash.Size;
			size += 4;
			size += 4;
			size += ArrayHelpers.Size(Transactions, 8);
			size += ArrayHelpers.Size(Cosignatures);
			return size;
		}
	}

	public static AggregateBondedTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var transactionsHash = Hash256.Deserialize(br);
		var payloadSize = br.ReadUInt32();
		var aggregateTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != aggregateTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({aggregateTransactionHeaderReserved_1})");
		var transactions = ArrayHelpers.ReadVariableSizeElements(br, EmbeddedTransactionFactory.Deserialize, payloadSize, 8);
		var cosignatures = ArrayHelpers.ReadArray(br, Cosignature.Deserialize);

		var instance = new AggregateBondedTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TransactionsHash = transactionsHash,
			Transactions = transactions,
			Cosignatures = cosignatures
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TransactionsHash.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)ArrayHelpers.Size(Transactions, 8)));  // bound: payload_size
		bw.Write(BitConverter.GetBytes((uint)(uint)AggregateTransactionHeaderReserved_1)); 
		ArrayHelpers.WriteVariableSizeElements(bw, Transactions, 8);
		ArrayHelpers.WriteArray(bw, Cosignatures);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"transactionsHash: {TransactionsHash}, ";
		result += $"transactions: [{string.Join(",", Transactions.Select(e => e.ToString()))}], ";
		result += $"cosignatures: [{string.Join(",", Cosignatures.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class AggregateBondedTransactionV2 : ITransaction {
	public const byte TRANSACTION_VERSION = 2;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.AGGREGATE_BONDED;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AggregateTransactionHeaderReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TransactionsHash", "pod:Hash256"},
		{"Transactions", "array[EmbeddedTransaction]"},
		{"Cosignatures", "array[Cosignature]"}
	};

	public AggregateBondedTransactionV2() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TransactionsHash = new Hash256();
		Transactions = Array.Empty<IBaseTransaction>();
		Cosignatures = Array.Empty<Cosignature>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AggregateTransactionHeaderReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Hash256 TransactionsHash { get; set; }

	public IBaseTransaction[] Transactions { get; set; }

	public Cosignature[] Cosignatures { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TransactionsHash.Size;
			size += 4;
			size += 4;
			size += ArrayHelpers.Size(Transactions, 8);
			size += ArrayHelpers.Size(Cosignatures);
			return size;
		}
	}

	public static AggregateBondedTransactionV2 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var transactionsHash = Hash256.Deserialize(br);
		var payloadSize = br.ReadUInt32();
		var aggregateTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != aggregateTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({aggregateTransactionHeaderReserved_1})");
		var transactions = ArrayHelpers.ReadVariableSizeElements(br, EmbeddedTransactionFactory.Deserialize, payloadSize, 8);
		var cosignatures = ArrayHelpers.ReadArray(br, Cosignature.Deserialize);

		var instance = new AggregateBondedTransactionV2()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TransactionsHash = transactionsHash,
			Transactions = transactions,
			Cosignatures = cosignatures
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TransactionsHash.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)ArrayHelpers.Size(Transactions, 8)));  // bound: payload_size
		bw.Write(BitConverter.GetBytes((uint)(uint)AggregateTransactionHeaderReserved_1)); 
		ArrayHelpers.WriteVariableSizeElements(bw, Transactions, 8);
		ArrayHelpers.WriteArray(bw, Cosignatures);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"transactionsHash: {TransactionsHash}, ";
		result += $"transactions: [{string.Join(",", Transactions.Select(e => e.ToString()))}], ";
		result += $"cosignatures: [{string.Join(",", Cosignatures.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class VotingKeyLinkTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VOTING_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:VotingPublicKey"},
		{"StartEpoch", "pod:FinalizationEpoch"},
		{"EndEpoch", "pod:FinalizationEpoch"},
		{"LinkAction", "enum:LinkAction"}
	};

	public VotingKeyLinkTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		LinkedPublicKey = new VotingPublicKey();
		StartEpoch = new FinalizationEpoch();
		EndEpoch = new FinalizationEpoch();
		LinkAction = LinkAction.UNLINK;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public VotingPublicKey LinkedPublicKey { get; set; }

	public FinalizationEpoch StartEpoch { get; set; }

	public FinalizationEpoch EndEpoch { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += LinkedPublicKey.Size;
			size += StartEpoch.Size;
			size += EndEpoch.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static VotingKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var linkedPublicKey = VotingPublicKey.Deserialize(br);
		var startEpoch = FinalizationEpoch.Deserialize(br);
		var endEpoch = FinalizationEpoch.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new VotingKeyLinkTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			LinkedPublicKey = linkedPublicKey,
			StartEpoch = startEpoch,
			EndEpoch = endEpoch,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(StartEpoch.Serialize()); 
		bw.Write(EndEpoch.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"startEpoch: {StartEpoch}, ";
		result += $"endEpoch: {EndEpoch}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedVotingKeyLinkTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VOTING_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:VotingPublicKey"},
		{"StartEpoch", "pod:FinalizationEpoch"},
		{"EndEpoch", "pod:FinalizationEpoch"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedVotingKeyLinkTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new VotingPublicKey();
		StartEpoch = new FinalizationEpoch();
		EndEpoch = new FinalizationEpoch();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public VotingPublicKey LinkedPublicKey { get; set; }

	public FinalizationEpoch StartEpoch { get; set; }

	public FinalizationEpoch EndEpoch { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += LinkedPublicKey.Size;
			size += StartEpoch.Size;
			size += EndEpoch.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static EmbeddedVotingKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var linkedPublicKey = VotingPublicKey.Deserialize(br);
		var startEpoch = FinalizationEpoch.Deserialize(br);
		var endEpoch = FinalizationEpoch.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new EmbeddedVotingKeyLinkTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			LinkedPublicKey = linkedPublicKey,
			StartEpoch = startEpoch,
			EndEpoch = endEpoch,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(StartEpoch.Serialize()); 
		bw.Write(EndEpoch.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"startEpoch: {StartEpoch}, ";
		result += $"endEpoch: {EndEpoch}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class VrfKeyLinkTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VRF_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public VrfKeyLinkTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public PublicKey LinkedPublicKey { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += LinkedPublicKey.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static VrfKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var linkedPublicKey = PublicKey.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new VrfKeyLinkTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			LinkedPublicKey = linkedPublicKey,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedVrfKeyLinkTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VRF_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedVrfKeyLinkTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public PublicKey LinkedPublicKey { get; set; }

	public LinkAction LinkAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += LinkedPublicKey.Size;
			size += LinkAction.Size;
			return size;
		}
	}

	public static EmbeddedVrfKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var linkedPublicKey = PublicKey.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);

		var instance = new EmbeddedVrfKeyLinkTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			LinkedPublicKey = linkedPublicKey,
			LinkAction = linkAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(LinkedPublicKey.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"linkedPublicKey: {LinkedPublicKey}, ";
		result += $"linkAction: {LinkAction}, ";
		result += ")";
		return result;
	}
}

public class HashLockTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.HASH_LOCK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Mosaic", "struct:UnresolvedMosaic"},
		{"Duration", "pod:BlockDuration"},
		{"Hash", "pod:Hash256"}
	};

	public HashLockTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		Mosaic = new UnresolvedMosaic();
		Duration = new BlockDuration();
		Hash = new Hash256();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedMosaic Mosaic { get; set; }

	public BlockDuration Duration { get; set; }

	public Hash256 Hash { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += Mosaic.Size;
			size += Duration.Size;
			size += Hash.Size;
			return size;
		}
	}

	public static HashLockTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaic = UnresolvedMosaic.Deserialize(br);
		var duration = BlockDuration.Deserialize(br);
		var hash = Hash256.Deserialize(br);

		var instance = new HashLockTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			Mosaic = mosaic,
			Duration = duration,
			Hash = hash
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(Mosaic.Serialize()); 
		bw.Write(Duration.Serialize()); 
		bw.Write(Hash.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaic: {Mosaic}, ";
		result += $"duration: {Duration}, ";
		result += $"hash: {Hash}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedHashLockTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.HASH_LOCK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Mosaic", "struct:UnresolvedMosaic"},
		{"Duration", "pod:BlockDuration"},
		{"Hash", "pod:Hash256"}
	};

	public EmbeddedHashLockTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Mosaic = new UnresolvedMosaic();
		Duration = new BlockDuration();
		Hash = new Hash256();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedMosaic Mosaic { get; set; }

	public BlockDuration Duration { get; set; }

	public Hash256 Hash { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Mosaic.Size;
			size += Duration.Size;
			size += Hash.Size;
			return size;
		}
	}

	public static EmbeddedHashLockTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var mosaic = UnresolvedMosaic.Deserialize(br);
		var duration = BlockDuration.Deserialize(br);
		var hash = Hash256.Deserialize(br);

		var instance = new EmbeddedHashLockTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Mosaic = mosaic,
			Duration = duration,
			Hash = hash
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Mosaic.Serialize()); 
		bw.Write(Duration.Serialize()); 
		bw.Write(Hash.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"mosaic: {Mosaic}, ";
		result += $"duration: {Duration}, ";
		result += $"hash: {Hash}, ";
		result += ")";
		return result;
	}
}

public class LockHashAlgorithm : IEnum<byte> {
	public static readonly LockHashAlgorithm SHA3_256 = new LockHashAlgorithm(0);

	public static readonly LockHashAlgorithm HASH_160 = new LockHashAlgorithm(1);

	public static readonly LockHashAlgorithm HASH_256 = new LockHashAlgorithm(2);

	public byte Value { get; }

	public LockHashAlgorithm(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			0, 1, 2
		};
		var keys = new []{
			"SHA3_256", "HASH_160", "HASH_256"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static LockHashAlgorithm FromValue(uint value) {
		return value switch
		{
			0 => SHA3_256,
			1 => HASH_160,
			2 => HASH_256,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static LockHashAlgorithm Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"LockHashAlgorithm.{ValueToKey(Value)}";
	}
}

public class SecretLockTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_LOCK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Secret", "pod:Hash256"},
		{"Mosaic", "struct:UnresolvedMosaic"},
		{"Duration", "pod:BlockDuration"},
		{"HashAlgorithm", "enum:LockHashAlgorithm"}
	};

	public SecretLockTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new UnresolvedAddress();
		Secret = new Hash256();
		Mosaic = new UnresolvedMosaic();
		Duration = new BlockDuration();
		HashAlgorithm = LockHashAlgorithm.SHA3_256;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress RecipientAddress { get; set; }

	public Hash256 Secret { get; set; }

	public UnresolvedMosaic Mosaic { get; set; }

	public BlockDuration Duration { get; set; }

	public LockHashAlgorithm HashAlgorithm { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += RecipientAddress.Size;
			size += Secret.Size;
			size += Mosaic.Size;
			size += Duration.Size;
			size += HashAlgorithm.Size;
			return size;
		}
	}

	public static SecretLockTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddress = UnresolvedAddress.Deserialize(br);
		var secret = Hash256.Deserialize(br);
		var mosaic = UnresolvedMosaic.Deserialize(br);
		var duration = BlockDuration.Deserialize(br);
		var hashAlgorithm = LockHashAlgorithm.Deserialize(br);

		var instance = new SecretLockTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Secret = secret,
			Mosaic = mosaic,
			Duration = duration,
			HashAlgorithm = hashAlgorithm
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Secret.Serialize()); 
		bw.Write(Mosaic.Serialize()); 
		bw.Write(Duration.Serialize()); 
		bw.Write(HashAlgorithm.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"secret: {Secret}, ";
		result += $"mosaic: {Mosaic}, ";
		result += $"duration: {Duration}, ";
		result += $"hashAlgorithm: {HashAlgorithm}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedSecretLockTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_LOCK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Secret", "pod:Hash256"},
		{"Mosaic", "struct:UnresolvedMosaic"},
		{"Duration", "pod:BlockDuration"},
		{"HashAlgorithm", "enum:LockHashAlgorithm"}
	};

	public EmbeddedSecretLockTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		RecipientAddress = new UnresolvedAddress();
		Secret = new Hash256();
		Mosaic = new UnresolvedMosaic();
		Duration = new BlockDuration();
		HashAlgorithm = LockHashAlgorithm.SHA3_256;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress RecipientAddress { get; set; }

	public Hash256 Secret { get; set; }

	public UnresolvedMosaic Mosaic { get; set; }

	public BlockDuration Duration { get; set; }

	public LockHashAlgorithm HashAlgorithm { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += RecipientAddress.Size;
			size += Secret.Size;
			size += Mosaic.Size;
			size += Duration.Size;
			size += HashAlgorithm.Size;
			return size;
		}
	}

	public static EmbeddedSecretLockTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var recipientAddress = UnresolvedAddress.Deserialize(br);
		var secret = Hash256.Deserialize(br);
		var mosaic = UnresolvedMosaic.Deserialize(br);
		var duration = BlockDuration.Deserialize(br);
		var hashAlgorithm = LockHashAlgorithm.Deserialize(br);

		var instance = new EmbeddedSecretLockTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			RecipientAddress = recipientAddress,
			Secret = secret,
			Mosaic = mosaic,
			Duration = duration,
			HashAlgorithm = hashAlgorithm
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Secret.Serialize()); 
		bw.Write(Mosaic.Serialize()); 
		bw.Write(Duration.Serialize()); 
		bw.Write(HashAlgorithm.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"secret: {Secret}, ";
		result += $"mosaic: {Mosaic}, ";
		result += $"duration: {Duration}, ";
		result += $"hashAlgorithm: {HashAlgorithm}, ";
		result += ")";
		return result;
	}
}

public class SecretProofTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_PROOF;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Secret", "pod:Hash256"},
		{"HashAlgorithm", "enum:LockHashAlgorithm"},
		{"Proof", "bytes_array"}
	};

	public SecretProofTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new UnresolvedAddress();
		Secret = new Hash256();
		HashAlgorithm = LockHashAlgorithm.SHA3_256;
		Proof = Array.Empty<byte>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress RecipientAddress { get; set; }

	public Hash256 Secret { get; set; }

	public LockHashAlgorithm HashAlgorithm { get; set; }

	public byte[] Proof { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += RecipientAddress.Size;
			size += Secret.Size;
			size += 2;
			size += HashAlgorithm.Size;
			size += (uint)Proof.Length;
			return size;
		}
	}

	public static SecretProofTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddress = UnresolvedAddress.Deserialize(br);
		var secret = Hash256.Deserialize(br);
		var proofSize = br.ReadUInt16();
		var hashAlgorithm = LockHashAlgorithm.Deserialize(br);
		var proof = br.ReadBytes((int)proofSize);

		var instance = new SecretProofTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Secret = secret,
			HashAlgorithm = hashAlgorithm,
			Proof = proof
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Secret.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Proof.Length));  // bound: proof_size
		bw.Write(HashAlgorithm.Serialize()); 
		bw.Write(Proof); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"secret: {Secret}, ";
		result += $"hashAlgorithm: {HashAlgorithm}, ";
		result += $"proof: hex({Converter.BytesToHex(Proof)}), ";
		result += ")";
		return result;
	}
}

public class EmbeddedSecretProofTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_PROOF;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Secret", "pod:Hash256"},
		{"HashAlgorithm", "enum:LockHashAlgorithm"},
		{"Proof", "bytes_array"}
	};

	public EmbeddedSecretProofTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		RecipientAddress = new UnresolvedAddress();
		Secret = new Hash256();
		HashAlgorithm = LockHashAlgorithm.SHA3_256;
		Proof = Array.Empty<byte>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress RecipientAddress { get; set; }

	public Hash256 Secret { get; set; }

	public LockHashAlgorithm HashAlgorithm { get; set; }

	public byte[] Proof { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += RecipientAddress.Size;
			size += Secret.Size;
			size += 2;
			size += HashAlgorithm.Size;
			size += (uint)Proof.Length;
			return size;
		}
	}

	public static EmbeddedSecretProofTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var recipientAddress = UnresolvedAddress.Deserialize(br);
		var secret = Hash256.Deserialize(br);
		var proofSize = br.ReadUInt16();
		var hashAlgorithm = LockHashAlgorithm.Deserialize(br);
		var proof = br.ReadBytes((int)proofSize);

		var instance = new EmbeddedSecretProofTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			RecipientAddress = recipientAddress,
			Secret = secret,
			HashAlgorithm = hashAlgorithm,
			Proof = proof
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Secret.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Proof.Length));  // bound: proof_size
		bw.Write(HashAlgorithm.Serialize()); 
		bw.Write(Proof); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"secret: {Secret}, ";
		result += $"hashAlgorithm: {HashAlgorithm}, ";
		result += $"proof: hex({Converter.BytesToHex(Proof)}), ";
		result += ")";
		return result;
	}
}

public class AccountMetadataTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_METADATA;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"Value", "bytes_array"}
	};

	public AccountMetadataTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TargetAddress = new UnresolvedAddress();
		ScopedMetadataKey = 0;
		ValueSizeDelta = 0;
		Value = Array.Empty<byte>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public ulong ScopedMetadataKey { get; set; }

	public ushort ValueSizeDelta { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TargetAddress.Size;
			size += 8;
			size += 2;
			size += 2;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static AccountMetadataTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var targetAddress = UnresolvedAddress.Deserialize(br);
		var scopedMetadataKey = br.ReadUInt64();
		var valueSizeDelta = br.ReadUInt16();
		var valueSize = br.ReadUInt16();
		var value = br.ReadBytes((int)valueSize);

		var instance = new AccountMetadataTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TargetAddress = targetAddress,
			ScopedMetadataKey = scopedMetadataKey,
			ValueSizeDelta = valueSizeDelta,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TargetAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)ScopedMetadataKey)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)ValueSizeDelta)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += $"scopedMetadataKey: {Converter.ToString(ScopedMetadataKey)}, ";
		result += $"valueSizeDelta: {Converter.ToString(ValueSizeDelta)}, ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class EmbeddedAccountMetadataTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_METADATA;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"Value", "bytes_array"}
	};

	public EmbeddedAccountMetadataTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		TargetAddress = new UnresolvedAddress();
		ScopedMetadataKey = 0;
		ValueSizeDelta = 0;
		Value = Array.Empty<byte>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public ulong ScopedMetadataKey { get; set; }

	public ushort ValueSizeDelta { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += TargetAddress.Size;
			size += 8;
			size += 2;
			size += 2;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static EmbeddedAccountMetadataTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var targetAddress = UnresolvedAddress.Deserialize(br);
		var scopedMetadataKey = br.ReadUInt64();
		var valueSizeDelta = br.ReadUInt16();
		var valueSize = br.ReadUInt16();
		var value = br.ReadBytes((int)valueSize);

		var instance = new EmbeddedAccountMetadataTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			TargetAddress = targetAddress,
			ScopedMetadataKey = scopedMetadataKey,
			ValueSizeDelta = valueSizeDelta,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(TargetAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)ScopedMetadataKey)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)ValueSizeDelta)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += $"scopedMetadataKey: {Converter.ToString(ScopedMetadataKey)}, ";
		result += $"valueSizeDelta: {Converter.ToString(ValueSizeDelta)}, ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class MosaicMetadataTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_METADATA;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"TargetMosaicId", "pod:UnresolvedMosaicId"},
		{"Value", "bytes_array"}
	};

	public MosaicMetadataTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TargetAddress = new UnresolvedAddress();
		ScopedMetadataKey = 0;
		TargetMosaicId = new UnresolvedMosaicId();
		ValueSizeDelta = 0;
		Value = Array.Empty<byte>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public ulong ScopedMetadataKey { get; set; }

	public UnresolvedMosaicId TargetMosaicId { get; set; }

	public ushort ValueSizeDelta { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TargetAddress.Size;
			size += 8;
			size += TargetMosaicId.Size;
			size += 2;
			size += 2;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static MosaicMetadataTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var targetAddress = UnresolvedAddress.Deserialize(br);
		var scopedMetadataKey = br.ReadUInt64();
		var targetMosaicId = UnresolvedMosaicId.Deserialize(br);
		var valueSizeDelta = br.ReadUInt16();
		var valueSize = br.ReadUInt16();
		var value = br.ReadBytes((int)valueSize);

		var instance = new MosaicMetadataTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TargetAddress = targetAddress,
			ScopedMetadataKey = scopedMetadataKey,
			TargetMosaicId = targetMosaicId,
			ValueSizeDelta = valueSizeDelta,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TargetAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)ScopedMetadataKey)); 
		bw.Write(TargetMosaicId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)ValueSizeDelta)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += $"scopedMetadataKey: {Converter.ToString(ScopedMetadataKey)}, ";
		result += $"targetMosaicId: {TargetMosaicId}, ";
		result += $"valueSizeDelta: {Converter.ToString(ValueSizeDelta)}, ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicMetadataTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_METADATA;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"TargetMosaicId", "pod:UnresolvedMosaicId"},
		{"Value", "bytes_array"}
	};

	public EmbeddedMosaicMetadataTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		TargetAddress = new UnresolvedAddress();
		ScopedMetadataKey = 0;
		TargetMosaicId = new UnresolvedMosaicId();
		ValueSizeDelta = 0;
		Value = Array.Empty<byte>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public ulong ScopedMetadataKey { get; set; }

	public UnresolvedMosaicId TargetMosaicId { get; set; }

	public ushort ValueSizeDelta { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += TargetAddress.Size;
			size += 8;
			size += TargetMosaicId.Size;
			size += 2;
			size += 2;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static EmbeddedMosaicMetadataTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var targetAddress = UnresolvedAddress.Deserialize(br);
		var scopedMetadataKey = br.ReadUInt64();
		var targetMosaicId = UnresolvedMosaicId.Deserialize(br);
		var valueSizeDelta = br.ReadUInt16();
		var valueSize = br.ReadUInt16();
		var value = br.ReadBytes((int)valueSize);

		var instance = new EmbeddedMosaicMetadataTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			TargetAddress = targetAddress,
			ScopedMetadataKey = scopedMetadataKey,
			TargetMosaicId = targetMosaicId,
			ValueSizeDelta = valueSizeDelta,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(TargetAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)ScopedMetadataKey)); 
		bw.Write(TargetMosaicId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)ValueSizeDelta)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += $"scopedMetadataKey: {Converter.ToString(ScopedMetadataKey)}, ";
		result += $"targetMosaicId: {TargetMosaicId}, ";
		result += $"valueSizeDelta: {Converter.ToString(ValueSizeDelta)}, ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class NamespaceId : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public NamespaceId(ulong namespaceId = 0): base(SIZE, namespaceId) {
	}

	public static NamespaceId Deserialize(BinaryReader br) {
		return new NamespaceId(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class NamespaceRegistrationType : IEnum<byte> {
	public static readonly NamespaceRegistrationType ROOT = new NamespaceRegistrationType(0);

	public static readonly NamespaceRegistrationType CHILD = new NamespaceRegistrationType(1);

	public byte Value { get; }

	public NamespaceRegistrationType(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			0, 1
		};
		var keys = new []{
			"ROOT", "CHILD"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static NamespaceRegistrationType FromValue(uint value) {
		return value switch
		{
			0 => ROOT,
			1 => CHILD,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static NamespaceRegistrationType Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"NamespaceRegistrationType.{ValueToKey(Value)}";
	}
}

public class AliasAction : IEnum<byte> {
	public static readonly AliasAction UNLINK = new AliasAction(0);

	public static readonly AliasAction LINK = new AliasAction(1);

	public byte Value { get; }

	public AliasAction(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			0, 1
		};
		var keys = new []{
			"UNLINK", "LINK"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static AliasAction FromValue(uint value) {
		return value switch
		{
			0 => UNLINK,
			1 => LINK,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static AliasAction Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"AliasAction.{ValueToKey(Value)}";
	}
}

public class NamespaceMetadataTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_METADATA;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"TargetNamespaceId", "pod:NamespaceId"},
		{"Value", "bytes_array"}
	};

	public NamespaceMetadataTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		TargetAddress = new UnresolvedAddress();
		ScopedMetadataKey = 0;
		TargetNamespaceId = new NamespaceId();
		ValueSizeDelta = 0;
		Value = Array.Empty<byte>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public ulong ScopedMetadataKey { get; set; }

	public NamespaceId TargetNamespaceId { get; set; }

	public ushort ValueSizeDelta { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += TargetAddress.Size;
			size += 8;
			size += TargetNamespaceId.Size;
			size += 2;
			size += 2;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static NamespaceMetadataTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var targetAddress = UnresolvedAddress.Deserialize(br);
		var scopedMetadataKey = br.ReadUInt64();
		var targetNamespaceId = NamespaceId.Deserialize(br);
		var valueSizeDelta = br.ReadUInt16();
		var valueSize = br.ReadUInt16();
		var value = br.ReadBytes((int)valueSize);

		var instance = new NamespaceMetadataTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			TargetAddress = targetAddress,
			ScopedMetadataKey = scopedMetadataKey,
			TargetNamespaceId = targetNamespaceId,
			ValueSizeDelta = valueSizeDelta,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(TargetAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)ScopedMetadataKey)); 
		bw.Write(TargetNamespaceId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)ValueSizeDelta)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += $"scopedMetadataKey: {Converter.ToString(ScopedMetadataKey)}, ";
		result += $"targetNamespaceId: {TargetNamespaceId}, ";
		result += $"valueSizeDelta: {Converter.ToString(ValueSizeDelta)}, ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class EmbeddedNamespaceMetadataTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_METADATA;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"TargetNamespaceId", "pod:NamespaceId"},
		{"Value", "bytes_array"}
	};

	public EmbeddedNamespaceMetadataTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		TargetAddress = new UnresolvedAddress();
		ScopedMetadataKey = 0;
		TargetNamespaceId = new NamespaceId();
		ValueSizeDelta = 0;
		Value = Array.Empty<byte>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public ulong ScopedMetadataKey { get; set; }

	public NamespaceId TargetNamespaceId { get; set; }

	public ushort ValueSizeDelta { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += TargetAddress.Size;
			size += 8;
			size += TargetNamespaceId.Size;
			size += 2;
			size += 2;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static EmbeddedNamespaceMetadataTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var targetAddress = UnresolvedAddress.Deserialize(br);
		var scopedMetadataKey = br.ReadUInt64();
		var targetNamespaceId = NamespaceId.Deserialize(br);
		var valueSizeDelta = br.ReadUInt16();
		var valueSize = br.ReadUInt16();
		var value = br.ReadBytes((int)valueSize);

		var instance = new EmbeddedNamespaceMetadataTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			TargetAddress = targetAddress,
			ScopedMetadataKey = scopedMetadataKey,
			TargetNamespaceId = targetNamespaceId,
			ValueSizeDelta = valueSizeDelta,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(TargetAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)ScopedMetadataKey)); 
		bw.Write(TargetNamespaceId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)ValueSizeDelta)); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += $"scopedMetadataKey: {Converter.ToString(ScopedMetadataKey)}, ";
		result += $"targetNamespaceId: {TargetNamespaceId}, ";
		result += $"valueSizeDelta: {Converter.ToString(ValueSizeDelta)}, ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class MosaicNonce : BaseValue, ISerializer {
	public const byte SIZE = 4;

	public MosaicNonce(uint mosaicNonce = 0): base(SIZE, mosaicNonce) {
	}

	public static MosaicNonce Deserialize(BinaryReader br) {
		return new MosaicNonce(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((uint)Value);
	}
}

public class MosaicFlags : IEnum<byte> {
	public static readonly MosaicFlags NONE = new MosaicFlags(0);

	public static readonly MosaicFlags SUPPLY_MUTABLE = new MosaicFlags(1);

	public static readonly MosaicFlags TRANSFERABLE = new MosaicFlags(2);

	public static readonly MosaicFlags RESTRICTABLE = new MosaicFlags(4);

	public static readonly MosaicFlags REVOKABLE = new MosaicFlags(8);

	public byte Value { get; }

	public MosaicFlags(byte value = 0) {
		Value = value;
	}

	public bool Has(uint flag) {
		return 0 != (Value & flag);
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static MosaicFlags Deserialize(BinaryReader br) {
		return new MosaicFlags(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		var values = new uint[]{
			0, 1, 2, 4, 8
		};
		var keys = new []{
			"NONE", "SUPPLY_MUTABLE", "TRANSFERABLE", "RESTRICTABLE", "REVOKABLE"
		};

		if (0 == Value) {
			var index = Array.IndexOf(values, Value);
			return $"MosaicFlags.{keys[index]}";
		}

		var positions = values.ToList().Select((flag, i) => new {flag, Index = i}).Where(flag => (Value & flag.flag) != 0).ToList();
		return string.Join("|", positions.Select(n => $"MosaicFlags.{keys[n.Index]}"));
	}
}

public class MosaicSupplyChangeAction : IEnum<byte> {
	public static readonly MosaicSupplyChangeAction DECREASE = new MosaicSupplyChangeAction(0);

	public static readonly MosaicSupplyChangeAction INCREASE = new MosaicSupplyChangeAction(1);

	public byte Value { get; }

	public MosaicSupplyChangeAction(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			0, 1
		};
		var keys = new []{
			"DECREASE", "INCREASE"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static MosaicSupplyChangeAction FromValue(uint value) {
		return value switch
		{
			0 => DECREASE,
			1 => INCREASE,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static MosaicSupplyChangeAction Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"MosaicSupplyChangeAction.{ValueToKey(Value)}";
	}
}

public class MosaicDefinitionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_DEFINITION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Id", "pod:MosaicId"},
		{"Duration", "pod:BlockDuration"},
		{"Nonce", "pod:MosaicNonce"},
		{"Flags", "enum:MosaicFlags"}
	};

	public MosaicDefinitionTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		Id = new MosaicId();
		Duration = new BlockDuration();
		Nonce = new MosaicNonce();
		Flags = MosaicFlags.NONE;
		Divisibility = 0;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public MosaicId Id { get; set; }

	public BlockDuration Duration { get; set; }

	public MosaicNonce Nonce { get; set; }

	public MosaicFlags Flags { get; set; }

	public byte Divisibility { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += Id.Size;
			size += Duration.Size;
			size += Nonce.Size;
			size += Flags.Size;
			size += 1;
			return size;
		}
	}

	public static MosaicDefinitionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var id = MosaicId.Deserialize(br);
		var duration = BlockDuration.Deserialize(br);
		var nonce = MosaicNonce.Deserialize(br);
		var flags = MosaicFlags.Deserialize(br);
		var divisibility = br.ReadByte();

		var instance = new MosaicDefinitionTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			Id = id,
			Duration = duration,
			Nonce = nonce,
			Flags = flags,
			Divisibility = divisibility
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(Id.Serialize()); 
		bw.Write(Duration.Serialize()); 
		bw.Write(Nonce.Serialize()); 
		bw.Write(Flags.Serialize()); 
		bw.Write((byte)Divisibility); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"id: {Id}, ";
		result += $"duration: {Duration}, ";
		result += $"nonce: {Nonce}, ";
		result += $"flags: {Flags}, ";
		result += $"divisibility: {Converter.ToString(Divisibility)}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicDefinitionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_DEFINITION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Id", "pod:MosaicId"},
		{"Duration", "pod:BlockDuration"},
		{"Nonce", "pod:MosaicNonce"},
		{"Flags", "enum:MosaicFlags"}
	};

	public EmbeddedMosaicDefinitionTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Id = new MosaicId();
		Duration = new BlockDuration();
		Nonce = new MosaicNonce();
		Flags = MosaicFlags.NONE;
		Divisibility = 0;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public MosaicId Id { get; set; }

	public BlockDuration Duration { get; set; }

	public MosaicNonce Nonce { get; set; }

	public MosaicFlags Flags { get; set; }

	public byte Divisibility { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Id.Size;
			size += Duration.Size;
			size += Nonce.Size;
			size += Flags.Size;
			size += 1;
			return size;
		}
	}

	public static EmbeddedMosaicDefinitionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var id = MosaicId.Deserialize(br);
		var duration = BlockDuration.Deserialize(br);
		var nonce = MosaicNonce.Deserialize(br);
		var flags = MosaicFlags.Deserialize(br);
		var divisibility = br.ReadByte();

		var instance = new EmbeddedMosaicDefinitionTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Id = id,
			Duration = duration,
			Nonce = nonce,
			Flags = flags,
			Divisibility = divisibility
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Id.Serialize()); 
		bw.Write(Duration.Serialize()); 
		bw.Write(Nonce.Serialize()); 
		bw.Write(Flags.Serialize()); 
		bw.Write((byte)Divisibility); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"id: {Id}, ";
		result += $"duration: {Duration}, ";
		result += $"nonce: {Nonce}, ";
		result += $"flags: {Flags}, ";
		result += $"divisibility: {Converter.ToString(Divisibility)}, ";
		result += ")";
		return result;
	}
}

public class MosaicSupplyChangeTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_CHANGE;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"Delta", "pod:Amount"},
		{"Action", "enum:MosaicSupplyChangeAction"}
	};

	public MosaicSupplyChangeTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicId = new UnresolvedMosaicId();
		Delta = new Amount();
		Action = MosaicSupplyChangeAction.DECREASE;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedMosaicId MosaicId { get; set; }

	public Amount Delta { get; set; }

	public MosaicSupplyChangeAction Action { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += MosaicId.Size;
			size += Delta.Size;
			size += Action.Size;
			return size;
		}
	}

	public static MosaicSupplyChangeTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var delta = Amount.Deserialize(br);
		var action = MosaicSupplyChangeAction.Deserialize(br);

		var instance = new MosaicSupplyChangeTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			MosaicId = mosaicId,
			Delta = delta,
			Action = action
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Delta.Serialize()); 
		bw.Write(Action.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"delta: {Delta}, ";
		result += $"action: {Action}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicSupplyChangeTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_CHANGE;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"Delta", "pod:Amount"},
		{"Action", "enum:MosaicSupplyChangeAction"}
	};

	public EmbeddedMosaicSupplyChangeTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		MosaicId = new UnresolvedMosaicId();
		Delta = new Amount();
		Action = MosaicSupplyChangeAction.DECREASE;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedMosaicId MosaicId { get; set; }

	public Amount Delta { get; set; }

	public MosaicSupplyChangeAction Action { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += MosaicId.Size;
			size += Delta.Size;
			size += Action.Size;
			return size;
		}
	}

	public static EmbeddedMosaicSupplyChangeTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var delta = Amount.Deserialize(br);
		var action = MosaicSupplyChangeAction.Deserialize(br);

		var instance = new EmbeddedMosaicSupplyChangeTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			MosaicId = mosaicId,
			Delta = delta,
			Action = action
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Delta.Serialize()); 
		bw.Write(Action.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"delta: {Delta}, ";
		result += $"action: {Action}, ";
		result += ")";
		return result;
	}
}

public class MosaicSupplyRevocationTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_REVOCATION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"SourceAddress", "pod:UnresolvedAddress"},
		{"Mosaic", "struct:UnresolvedMosaic"}
	};

	public MosaicSupplyRevocationTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		SourceAddress = new UnresolvedAddress();
		Mosaic = new UnresolvedMosaic();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress SourceAddress { get; set; }

	public UnresolvedMosaic Mosaic { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += SourceAddress.Size;
			size += Mosaic.Size;
			return size;
		}
	}

	public static MosaicSupplyRevocationTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var sourceAddress = UnresolvedAddress.Deserialize(br);
		var mosaic = UnresolvedMosaic.Deserialize(br);

		var instance = new MosaicSupplyRevocationTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			SourceAddress = sourceAddress,
			Mosaic = mosaic
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(SourceAddress.Serialize()); 
		bw.Write(Mosaic.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"sourceAddress: {SourceAddress}, ";
		result += $"mosaic: {Mosaic}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicSupplyRevocationTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_REVOCATION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"SourceAddress", "pod:UnresolvedAddress"},
		{"Mosaic", "struct:UnresolvedMosaic"}
	};

	public EmbeddedMosaicSupplyRevocationTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		SourceAddress = new UnresolvedAddress();
		Mosaic = new UnresolvedMosaic();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress SourceAddress { get; set; }

	public UnresolvedMosaic Mosaic { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += SourceAddress.Size;
			size += Mosaic.Size;
			return size;
		}
	}

	public static EmbeddedMosaicSupplyRevocationTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var sourceAddress = UnresolvedAddress.Deserialize(br);
		var mosaic = UnresolvedMosaic.Deserialize(br);

		var instance = new EmbeddedMosaicSupplyRevocationTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			SourceAddress = sourceAddress,
			Mosaic = mosaic
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(SourceAddress.Serialize()); 
		bw.Write(Mosaic.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"sourceAddress: {SourceAddress}, ";
		result += $"mosaic: {Mosaic}, ";
		result += ")";
		return result;
	}
}

public class MultisigAccountModificationTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int MultisigAccountModificationTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"AddressAdditions", "array[UnresolvedAddress]"},
		{"AddressDeletions", "array[UnresolvedAddress]"}
	};

	public MultisigAccountModificationTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		MinRemovalDelta = 0;
		MinApprovalDelta = 0;
		AddressAdditions = Array.Empty<UnresolvedAddress>();
		AddressDeletions = Array.Empty<UnresolvedAddress>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		MultisigAccountModificationTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public byte MinRemovalDelta { get; set; }

	public byte MinApprovalDelta { get; set; }

	public UnresolvedAddress[] AddressAdditions { get; set; }

	public UnresolvedAddress[] AddressDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 1;
			size += 1;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(AddressAdditions);
			size += ArrayHelpers.Size(AddressDeletions);
			return size;
		}
	}

	public static MultisigAccountModificationTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var minRemovalDelta = br.ReadByte();
		var minApprovalDelta = br.ReadByte();
		var addressAdditionsCount = br.ReadByte();
		var addressDeletionsCount = br.ReadByte();
		var multisigAccountModificationTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != multisigAccountModificationTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({multisigAccountModificationTransactionBodyReserved_1})");
		var addressAdditions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)addressAdditionsCount);
		var addressDeletions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)addressDeletionsCount);

		var instance = new MultisigAccountModificationTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			MinRemovalDelta = minRemovalDelta,
			MinApprovalDelta = minApprovalDelta,
			AddressAdditions = addressAdditions,
			AddressDeletions = addressDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write((byte)MinRemovalDelta); 
		bw.Write((byte)MinApprovalDelta); 
		bw.Write((byte)AddressAdditions.Length);  // bound: address_additions_count
		bw.Write((byte)AddressDeletions.Length);  // bound: address_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)MultisigAccountModificationTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, AddressAdditions);
		ArrayHelpers.WriteArray(bw, AddressDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"minRemovalDelta: {Converter.ToString(MinRemovalDelta)}, ";
		result += $"minApprovalDelta: {Converter.ToString(MinApprovalDelta)}, ";
		result += $"addressAdditions: [{string.Join(",", AddressAdditions.Select(e => e.ToString()))}], ";
		result += $"addressDeletions: [{string.Join(",", AddressDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class EmbeddedMultisigAccountModificationTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int MultisigAccountModificationTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"AddressAdditions", "array[UnresolvedAddress]"},
		{"AddressDeletions", "array[UnresolvedAddress]"}
	};

	public EmbeddedMultisigAccountModificationTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		MinRemovalDelta = 0;
		MinApprovalDelta = 0;
		AddressAdditions = Array.Empty<UnresolvedAddress>();
		AddressDeletions = Array.Empty<UnresolvedAddress>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		MultisigAccountModificationTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public byte MinRemovalDelta { get; set; }

	public byte MinApprovalDelta { get; set; }

	public UnresolvedAddress[] AddressAdditions { get; set; }

	public UnresolvedAddress[] AddressDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += 1;
			size += 1;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(AddressAdditions);
			size += ArrayHelpers.Size(AddressDeletions);
			return size;
		}
	}

	public static EmbeddedMultisigAccountModificationTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var minRemovalDelta = br.ReadByte();
		var minApprovalDelta = br.ReadByte();
		var addressAdditionsCount = br.ReadByte();
		var addressDeletionsCount = br.ReadByte();
		var multisigAccountModificationTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != multisigAccountModificationTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({multisigAccountModificationTransactionBodyReserved_1})");
		var addressAdditions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)addressAdditionsCount);
		var addressDeletions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)addressDeletionsCount);

		var instance = new EmbeddedMultisigAccountModificationTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			MinRemovalDelta = minRemovalDelta,
			MinApprovalDelta = minApprovalDelta,
			AddressAdditions = addressAdditions,
			AddressDeletions = addressDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write((byte)MinRemovalDelta); 
		bw.Write((byte)MinApprovalDelta); 
		bw.Write((byte)AddressAdditions.Length);  // bound: address_additions_count
		bw.Write((byte)AddressDeletions.Length);  // bound: address_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)MultisigAccountModificationTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, AddressAdditions);
		ArrayHelpers.WriteArray(bw, AddressDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"minRemovalDelta: {Converter.ToString(MinRemovalDelta)}, ";
		result += $"minApprovalDelta: {Converter.ToString(MinApprovalDelta)}, ";
		result += $"addressAdditions: [{string.Join(",", AddressAdditions.Select(e => e.ToString()))}], ";
		result += $"addressDeletions: [{string.Join(",", AddressDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class AddressAliasTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ADDRESS_ALIAS;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"NamespaceId", "pod:NamespaceId"},
		{"Address", "pod:Address"},
		{"AliasAction", "enum:AliasAction"}
	};

	public AddressAliasTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		NamespaceId = new NamespaceId();
		Address = new Address();
		AliasAction = AliasAction.UNLINK;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public NamespaceId NamespaceId { get; set; }

	public Address Address { get; set; }

	public AliasAction AliasAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += NamespaceId.Size;
			size += Address.Size;
			size += AliasAction.Size;
			return size;
		}
	}

	public static AddressAliasTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var namespaceId = NamespaceId.Deserialize(br);
		var address = Address.Deserialize(br);
		var aliasAction = AliasAction.Deserialize(br);

		var instance = new AddressAliasTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			NamespaceId = namespaceId,
			Address = address,
			AliasAction = aliasAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(NamespaceId.Serialize()); 
		bw.Write(Address.Serialize()); 
		bw.Write(AliasAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"namespaceId: {NamespaceId}, ";
		result += $"address: {Address}, ";
		result += $"aliasAction: {AliasAction}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedAddressAliasTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ADDRESS_ALIAS;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"NamespaceId", "pod:NamespaceId"},
		{"Address", "pod:Address"},
		{"AliasAction", "enum:AliasAction"}
	};

	public EmbeddedAddressAliasTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		NamespaceId = new NamespaceId();
		Address = new Address();
		AliasAction = AliasAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public NamespaceId NamespaceId { get; set; }

	public Address Address { get; set; }

	public AliasAction AliasAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += NamespaceId.Size;
			size += Address.Size;
			size += AliasAction.Size;
			return size;
		}
	}

	public static EmbeddedAddressAliasTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var namespaceId = NamespaceId.Deserialize(br);
		var address = Address.Deserialize(br);
		var aliasAction = AliasAction.Deserialize(br);

		var instance = new EmbeddedAddressAliasTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			NamespaceId = namespaceId,
			Address = address,
			AliasAction = aliasAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(NamespaceId.Serialize()); 
		bw.Write(Address.Serialize()); 
		bw.Write(AliasAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"namespaceId: {NamespaceId}, ";
		result += $"address: {Address}, ";
		result += $"aliasAction: {AliasAction}, ";
		result += ")";
		return result;
	}
}

public class MosaicAliasTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ALIAS;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"NamespaceId", "pod:NamespaceId"},
		{"MosaicId", "pod:MosaicId"},
		{"AliasAction", "enum:AliasAction"}
	};

	public MosaicAliasTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		NamespaceId = new NamespaceId();
		MosaicId = new MosaicId();
		AliasAction = AliasAction.UNLINK;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public NamespaceId NamespaceId { get; set; }

	public MosaicId MosaicId { get; set; }

	public AliasAction AliasAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += NamespaceId.Size;
			size += MosaicId.Size;
			size += AliasAction.Size;
			return size;
		}
	}

	public static MosaicAliasTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var namespaceId = NamespaceId.Deserialize(br);
		var mosaicId = MosaicId.Deserialize(br);
		var aliasAction = AliasAction.Deserialize(br);

		var instance = new MosaicAliasTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			NamespaceId = namespaceId,
			MosaicId = mosaicId,
			AliasAction = aliasAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(NamespaceId.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(AliasAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"namespaceId: {NamespaceId}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"aliasAction: {AliasAction}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicAliasTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ALIAS;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"NamespaceId", "pod:NamespaceId"},
		{"MosaicId", "pod:MosaicId"},
		{"AliasAction", "enum:AliasAction"}
	};

	public EmbeddedMosaicAliasTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		NamespaceId = new NamespaceId();
		MosaicId = new MosaicId();
		AliasAction = AliasAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public NamespaceId NamespaceId { get; set; }

	public MosaicId MosaicId { get; set; }

	public AliasAction AliasAction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += NamespaceId.Size;
			size += MosaicId.Size;
			size += AliasAction.Size;
			return size;
		}
	}

	public static EmbeddedMosaicAliasTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var namespaceId = NamespaceId.Deserialize(br);
		var mosaicId = MosaicId.Deserialize(br);
		var aliasAction = AliasAction.Deserialize(br);

		var instance = new EmbeddedMosaicAliasTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			NamespaceId = namespaceId,
			MosaicId = mosaicId,
			AliasAction = aliasAction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(NamespaceId.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(AliasAction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"namespaceId: {NamespaceId}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"aliasAction: {AliasAction}, ";
		result += ")";
		return result;
	}
}

public class NamespaceRegistrationTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_REGISTRATION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Duration", "pod:BlockDuration"},
		{"ParentId", "pod:NamespaceId"},
		{"Id", "pod:NamespaceId"},
		{"RegistrationType", "enum:NamespaceRegistrationType"},
		{"Name", "bytes_array"}
	};

	public NamespaceRegistrationTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		Duration = new BlockDuration();
		ParentId = new NamespaceId();
		Id = new NamespaceId();
		RegistrationType = NamespaceRegistrationType.ROOT;
		Name = Array.Empty<byte>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public BlockDuration Duration { get; set; }

	public NamespaceId ParentId { get; set; }

	public NamespaceId Id { get; set; }

	public NamespaceRegistrationType RegistrationType { get; set; }

	public byte[] Name { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			if (NamespaceRegistrationType.ROOT.Value == RegistrationType.Value)
				size += Duration.Size;

			if (NamespaceRegistrationType.CHILD.Value == RegistrationType.Value)
				size += ParentId.Size;

			size += Id.Size;
			size += RegistrationType.Size;
			size += 1;
			size += (uint)Name.Length;
			return size;
		}
	}

	public static NamespaceRegistrationTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		// deserialize to temporary buffer for further processing
		var durationTemporary = BlockDuration.Deserialize(br);
		var id = NamespaceId.Deserialize(br);
		var registrationType = NamespaceRegistrationType.Deserialize(br);
		var duration = new BlockDuration();
		if (NamespaceRegistrationType.ROOT.Value == registrationType.Value) {
			{
				var tempMs = new MemoryStream(durationTemporary.Serialize());
				var tempBr = new BinaryReader(tempMs);
				duration = BlockDuration.Deserialize(tempBr);
			}
		}
		var parentId = new NamespaceId();
		if (NamespaceRegistrationType.CHILD.Value == registrationType.Value) {
			{
				var tempMs = new MemoryStream(durationTemporary.Serialize());
				var tempBr = new BinaryReader(tempMs);
				parentId = NamespaceId.Deserialize(tempBr);
			}
		}
		var nameSize = br.ReadByte();
		var name = br.ReadBytes((int)nameSize);

		var instance = new NamespaceRegistrationTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			Duration = duration,
			ParentId = parentId,
			Id = id,
			RegistrationType = registrationType,
			Name = name
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		if (NamespaceRegistrationType.ROOT.Value == RegistrationType.Value)
			bw.Write(Duration.Serialize()); 

		if (NamespaceRegistrationType.CHILD.Value == RegistrationType.Value)
			bw.Write(ParentId.Serialize()); 

		bw.Write(Id.Serialize()); 
		bw.Write(RegistrationType.Serialize()); 
		bw.Write((byte)Name.Length);  // bound: name_size
		bw.Write(Name); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		if (NamespaceRegistrationType.ROOT.Value == RegistrationType.Value)
			result += $"duration: {Duration}, ";

		if (NamespaceRegistrationType.CHILD.Value == RegistrationType.Value)
			result += $"parentId: {ParentId}, ";

		result += $"id: {Id}, ";
		result += $"registrationType: {RegistrationType}, ";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		result += ")";
		return result;
	}
}

public class EmbeddedNamespaceRegistrationTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_REGISTRATION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Duration", "pod:BlockDuration"},
		{"ParentId", "pod:NamespaceId"},
		{"Id", "pod:NamespaceId"},
		{"RegistrationType", "enum:NamespaceRegistrationType"},
		{"Name", "bytes_array"}
	};

	public EmbeddedNamespaceRegistrationTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Duration = new BlockDuration();
		ParentId = new NamespaceId();
		Id = new NamespaceId();
		RegistrationType = NamespaceRegistrationType.ROOT;
		Name = Array.Empty<byte>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public BlockDuration Duration { get; set; }

	public NamespaceId ParentId { get; set; }

	public NamespaceId Id { get; set; }

	public NamespaceRegistrationType RegistrationType { get; set; }

	public byte[] Name { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			if (NamespaceRegistrationType.ROOT.Value == RegistrationType.Value)
				size += Duration.Size;

			if (NamespaceRegistrationType.CHILD.Value == RegistrationType.Value)
				size += ParentId.Size;

			size += Id.Size;
			size += RegistrationType.Size;
			size += 1;
			size += (uint)Name.Length;
			return size;
		}
	}

	public static EmbeddedNamespaceRegistrationTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		// deserialize to temporary buffer for further processing
		var durationTemporary = BlockDuration.Deserialize(br);
		var id = NamespaceId.Deserialize(br);
		var registrationType = NamespaceRegistrationType.Deserialize(br);
		var duration = new BlockDuration();
		if (NamespaceRegistrationType.ROOT.Value == registrationType.Value) {
			{
				var tempMs = new MemoryStream(durationTemporary.Serialize());
				var tempBr = new BinaryReader(tempMs);
				duration = BlockDuration.Deserialize(tempBr);
			}
		}
		var parentId = new NamespaceId();
		if (NamespaceRegistrationType.CHILD.Value == registrationType.Value) {
			{
				var tempMs = new MemoryStream(durationTemporary.Serialize());
				var tempBr = new BinaryReader(tempMs);
				parentId = NamespaceId.Deserialize(tempBr);
			}
		}
		var nameSize = br.ReadByte();
		var name = br.ReadBytes((int)nameSize);

		var instance = new EmbeddedNamespaceRegistrationTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Duration = duration,
			ParentId = parentId,
			Id = id,
			RegistrationType = registrationType,
			Name = name
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		if (NamespaceRegistrationType.ROOT.Value == RegistrationType.Value)
			bw.Write(Duration.Serialize()); 

		if (NamespaceRegistrationType.CHILD.Value == RegistrationType.Value)
			bw.Write(ParentId.Serialize()); 

		bw.Write(Id.Serialize()); 
		bw.Write(RegistrationType.Serialize()); 
		bw.Write((byte)Name.Length);  // bound: name_size
		bw.Write(Name); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		if (NamespaceRegistrationType.ROOT.Value == RegistrationType.Value)
			result += $"duration: {Duration}, ";

		if (NamespaceRegistrationType.CHILD.Value == RegistrationType.Value)
			result += $"parentId: {ParentId}, ";

		result += $"id: {Id}, ";
		result += $"registrationType: {RegistrationType}, ";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		result += ")";
		return result;
	}
}

public class AccountRestrictionFlags : IEnum<ushort> {
	public static readonly AccountRestrictionFlags ADDRESS = new AccountRestrictionFlags(1);

	public static readonly AccountRestrictionFlags MOSAIC_ID = new AccountRestrictionFlags(2);

	public static readonly AccountRestrictionFlags TRANSACTION_TYPE = new AccountRestrictionFlags(4);

	public static readonly AccountRestrictionFlags OUTGOING = new AccountRestrictionFlags(16384);

	public static readonly AccountRestrictionFlags BLOCK = new AccountRestrictionFlags(32768);

	public ushort Value { get; }

	public AccountRestrictionFlags(ushort value = 0) {
		Value = value;
	}

	public bool Has(uint flag) {
		return 0 != (Value & flag);
	}

	public uint Size {
		get {
			return 2;
		}
	}

	public static AccountRestrictionFlags Deserialize(BinaryReader br) {
		return new AccountRestrictionFlags(br.ReadUInt16());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		var values = new uint[]{
			1, 2, 4, 16384, 32768
		};
		var keys = new []{
			"ADDRESS", "MOSAIC_ID", "TRANSACTION_TYPE", "OUTGOING", "BLOCK"
		};

		if (0 == Value) {
			var index = Array.IndexOf(values, Value);
			return $"AccountRestrictionFlags.{keys[index]}";
		}

		var positions = values.ToList().Select((flag, i) => new {flag, Index = i}).Where(flag => (Value & flag.flag) != 0).ToList();
		return string.Join("|", positions.Select(n => $"AccountRestrictionFlags.{keys[n.Index]}"));
	}
}

public class AccountAddressRestrictionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_ADDRESS_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[UnresolvedAddress]"},
		{"RestrictionDeletions", "array[UnresolvedAddress]"}
	};

	public AccountAddressRestrictionTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		RestrictionFlags = AccountRestrictionFlags.ADDRESS;
		RestrictionAdditions = Array.Empty<UnresolvedAddress>();
		RestrictionDeletions = Array.Empty<UnresolvedAddress>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AccountRestrictionTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public AccountRestrictionFlags RestrictionFlags { get; set; }

	public UnresolvedAddress[] RestrictionAdditions { get; set; }

	public UnresolvedAddress[] RestrictionDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += RestrictionFlags.Size;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(RestrictionAdditions);
			size += ArrayHelpers.Size(RestrictionDeletions);
			return size;
		}
	}

	public static AccountAddressRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var restrictionFlags = AccountRestrictionFlags.Deserialize(br);
		var restrictionAdditionsCount = br.ReadByte();
		var restrictionDeletionsCount = br.ReadByte();
		var accountRestrictionTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != accountRestrictionTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({accountRestrictionTransactionBodyReserved_1})");
		var restrictionAdditions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)restrictionAdditionsCount);
		var restrictionDeletions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)restrictionDeletionsCount);

		var instance = new AccountAddressRestrictionTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			RestrictionFlags = restrictionFlags,
			RestrictionAdditions = restrictionAdditions,
			RestrictionDeletions = restrictionDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(RestrictionFlags.Serialize()); 
		bw.Write((byte)RestrictionAdditions.Length);  // bound: restriction_additions_count
		bw.Write((byte)RestrictionDeletions.Length);  // bound: restriction_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)AccountRestrictionTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, RestrictionAdditions);
		ArrayHelpers.WriteArray(bw, RestrictionDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"restrictionFlags: {RestrictionFlags}, ";
		result += $"restrictionAdditions: [{string.Join(",", RestrictionAdditions.Select(e => e.ToString()))}], ";
		result += $"restrictionDeletions: [{string.Join(",", RestrictionDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class EmbeddedAccountAddressRestrictionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_ADDRESS_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[UnresolvedAddress]"},
		{"RestrictionDeletions", "array[UnresolvedAddress]"}
	};

	public EmbeddedAccountAddressRestrictionTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		RestrictionFlags = AccountRestrictionFlags.ADDRESS;
		RestrictionAdditions = Array.Empty<UnresolvedAddress>();
		RestrictionDeletions = Array.Empty<UnresolvedAddress>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AccountRestrictionTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public AccountRestrictionFlags RestrictionFlags { get; set; }

	public UnresolvedAddress[] RestrictionAdditions { get; set; }

	public UnresolvedAddress[] RestrictionDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += RestrictionFlags.Size;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(RestrictionAdditions);
			size += ArrayHelpers.Size(RestrictionDeletions);
			return size;
		}
	}

	public static EmbeddedAccountAddressRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var restrictionFlags = AccountRestrictionFlags.Deserialize(br);
		var restrictionAdditionsCount = br.ReadByte();
		var restrictionDeletionsCount = br.ReadByte();
		var accountRestrictionTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != accountRestrictionTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({accountRestrictionTransactionBodyReserved_1})");
		var restrictionAdditions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)restrictionAdditionsCount);
		var restrictionDeletions = ArrayHelpers.ReadArrayCount(br, UnresolvedAddress.Deserialize, (byte)restrictionDeletionsCount);

		var instance = new EmbeddedAccountAddressRestrictionTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			RestrictionFlags = restrictionFlags,
			RestrictionAdditions = restrictionAdditions,
			RestrictionDeletions = restrictionDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(RestrictionFlags.Serialize()); 
		bw.Write((byte)RestrictionAdditions.Length);  // bound: restriction_additions_count
		bw.Write((byte)RestrictionDeletions.Length);  // bound: restriction_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)AccountRestrictionTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, RestrictionAdditions);
		ArrayHelpers.WriteArray(bw, RestrictionDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"restrictionFlags: {RestrictionFlags}, ";
		result += $"restrictionAdditions: [{string.Join(",", RestrictionAdditions.Select(e => e.ToString()))}], ";
		result += $"restrictionDeletions: [{string.Join(",", RestrictionDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class AccountMosaicRestrictionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_MOSAIC_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[UnresolvedMosaicId]"},
		{"RestrictionDeletions", "array[UnresolvedMosaicId]"}
	};

	public AccountMosaicRestrictionTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		RestrictionFlags = AccountRestrictionFlags.ADDRESS;
		RestrictionAdditions = Array.Empty<UnresolvedMosaicId>();
		RestrictionDeletions = Array.Empty<UnresolvedMosaicId>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AccountRestrictionTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public AccountRestrictionFlags RestrictionFlags { get; set; }

	public UnresolvedMosaicId[] RestrictionAdditions { get; set; }

	public UnresolvedMosaicId[] RestrictionDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += RestrictionFlags.Size;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(RestrictionAdditions);
			size += ArrayHelpers.Size(RestrictionDeletions);
			return size;
		}
	}

	public static AccountMosaicRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var restrictionFlags = AccountRestrictionFlags.Deserialize(br);
		var restrictionAdditionsCount = br.ReadByte();
		var restrictionDeletionsCount = br.ReadByte();
		var accountRestrictionTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != accountRestrictionTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({accountRestrictionTransactionBodyReserved_1})");
		var restrictionAdditions = ArrayHelpers.ReadArrayCount(br, UnresolvedMosaicId.Deserialize, (byte)restrictionAdditionsCount);
		var restrictionDeletions = ArrayHelpers.ReadArrayCount(br, UnresolvedMosaicId.Deserialize, (byte)restrictionDeletionsCount);

		var instance = new AccountMosaicRestrictionTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			RestrictionFlags = restrictionFlags,
			RestrictionAdditions = restrictionAdditions,
			RestrictionDeletions = restrictionDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(RestrictionFlags.Serialize()); 
		bw.Write((byte)RestrictionAdditions.Length);  // bound: restriction_additions_count
		bw.Write((byte)RestrictionDeletions.Length);  // bound: restriction_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)AccountRestrictionTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, RestrictionAdditions);
		ArrayHelpers.WriteArray(bw, RestrictionDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"restrictionFlags: {RestrictionFlags}, ";
		result += $"restrictionAdditions: [{string.Join(",", RestrictionAdditions.Select(e => e.ToString()))}], ";
		result += $"restrictionDeletions: [{string.Join(",", RestrictionDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class EmbeddedAccountMosaicRestrictionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_MOSAIC_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[UnresolvedMosaicId]"},
		{"RestrictionDeletions", "array[UnresolvedMosaicId]"}
	};

	public EmbeddedAccountMosaicRestrictionTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		RestrictionFlags = AccountRestrictionFlags.ADDRESS;
		RestrictionAdditions = Array.Empty<UnresolvedMosaicId>();
		RestrictionDeletions = Array.Empty<UnresolvedMosaicId>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AccountRestrictionTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public AccountRestrictionFlags RestrictionFlags { get; set; }

	public UnresolvedMosaicId[] RestrictionAdditions { get; set; }

	public UnresolvedMosaicId[] RestrictionDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += RestrictionFlags.Size;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(RestrictionAdditions);
			size += ArrayHelpers.Size(RestrictionDeletions);
			return size;
		}
	}

	public static EmbeddedAccountMosaicRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var restrictionFlags = AccountRestrictionFlags.Deserialize(br);
		var restrictionAdditionsCount = br.ReadByte();
		var restrictionDeletionsCount = br.ReadByte();
		var accountRestrictionTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != accountRestrictionTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({accountRestrictionTransactionBodyReserved_1})");
		var restrictionAdditions = ArrayHelpers.ReadArrayCount(br, UnresolvedMosaicId.Deserialize, (byte)restrictionAdditionsCount);
		var restrictionDeletions = ArrayHelpers.ReadArrayCount(br, UnresolvedMosaicId.Deserialize, (byte)restrictionDeletionsCount);

		var instance = new EmbeddedAccountMosaicRestrictionTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			RestrictionFlags = restrictionFlags,
			RestrictionAdditions = restrictionAdditions,
			RestrictionDeletions = restrictionDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(RestrictionFlags.Serialize()); 
		bw.Write((byte)RestrictionAdditions.Length);  // bound: restriction_additions_count
		bw.Write((byte)RestrictionDeletions.Length);  // bound: restriction_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)AccountRestrictionTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, RestrictionAdditions);
		ArrayHelpers.WriteArray(bw, RestrictionDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"restrictionFlags: {RestrictionFlags}, ";
		result += $"restrictionAdditions: [{string.Join(",", RestrictionAdditions.Select(e => e.ToString()))}], ";
		result += $"restrictionDeletions: [{string.Join(",", RestrictionDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class AccountOperationRestrictionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_OPERATION_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[TransactionType]"},
		{"RestrictionDeletions", "array[TransactionType]"}
	};

	public AccountOperationRestrictionTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		RestrictionFlags = AccountRestrictionFlags.ADDRESS;
		RestrictionAdditions = Array.Empty<TransactionType>();
		RestrictionDeletions = Array.Empty<TransactionType>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AccountRestrictionTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public AccountRestrictionFlags RestrictionFlags { get; set; }

	public TransactionType[] RestrictionAdditions { get; set; }

	public TransactionType[] RestrictionDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += RestrictionFlags.Size;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(RestrictionAdditions);
			size += ArrayHelpers.Size(RestrictionDeletions);
			return size;
		}
	}

	public static AccountOperationRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var restrictionFlags = AccountRestrictionFlags.Deserialize(br);
		var restrictionAdditionsCount = br.ReadByte();
		var restrictionDeletionsCount = br.ReadByte();
		var accountRestrictionTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != accountRestrictionTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({accountRestrictionTransactionBodyReserved_1})");
		var restrictionAdditions = ArrayHelpers.ReadArrayCount(br, TransactionType.Deserialize, (byte)restrictionAdditionsCount);
		var restrictionDeletions = ArrayHelpers.ReadArrayCount(br, TransactionType.Deserialize, (byte)restrictionDeletionsCount);

		var instance = new AccountOperationRestrictionTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			RestrictionFlags = restrictionFlags,
			RestrictionAdditions = restrictionAdditions,
			RestrictionDeletions = restrictionDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(RestrictionFlags.Serialize()); 
		bw.Write((byte)RestrictionAdditions.Length);  // bound: restriction_additions_count
		bw.Write((byte)RestrictionDeletions.Length);  // bound: restriction_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)AccountRestrictionTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, RestrictionAdditions);
		ArrayHelpers.WriteArray(bw, RestrictionDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"restrictionFlags: {RestrictionFlags}, ";
		result += $"restrictionAdditions: [{string.Join(",", RestrictionAdditions.Select(e => e.ToString()))}], ";
		result += $"restrictionDeletions: [{string.Join(",", RestrictionDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class EmbeddedAccountOperationRestrictionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_OPERATION_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[TransactionType]"},
		{"RestrictionDeletions", "array[TransactionType]"}
	};

	public EmbeddedAccountOperationRestrictionTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		RestrictionFlags = AccountRestrictionFlags.ADDRESS;
		RestrictionAdditions = Array.Empty<TransactionType>();
		RestrictionDeletions = Array.Empty<TransactionType>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		AccountRestrictionTransactionBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public AccountRestrictionFlags RestrictionFlags { get; set; }

	public TransactionType[] RestrictionAdditions { get; set; }

	public TransactionType[] RestrictionDeletions { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += RestrictionFlags.Size;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(RestrictionAdditions);
			size += ArrayHelpers.Size(RestrictionDeletions);
			return size;
		}
	}

	public static EmbeddedAccountOperationRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var restrictionFlags = AccountRestrictionFlags.Deserialize(br);
		var restrictionAdditionsCount = br.ReadByte();
		var restrictionDeletionsCount = br.ReadByte();
		var accountRestrictionTransactionBodyReserved_1 = br.ReadUInt32();
		if (0 != accountRestrictionTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({accountRestrictionTransactionBodyReserved_1})");
		var restrictionAdditions = ArrayHelpers.ReadArrayCount(br, TransactionType.Deserialize, (byte)restrictionAdditionsCount);
		var restrictionDeletions = ArrayHelpers.ReadArrayCount(br, TransactionType.Deserialize, (byte)restrictionDeletionsCount);

		var instance = new EmbeddedAccountOperationRestrictionTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			RestrictionFlags = restrictionFlags,
			RestrictionAdditions = restrictionAdditions,
			RestrictionDeletions = restrictionDeletions
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(RestrictionFlags.Serialize()); 
		bw.Write((byte)RestrictionAdditions.Length);  // bound: restriction_additions_count
		bw.Write((byte)RestrictionDeletions.Length);  // bound: restriction_deletions_count
		bw.Write(BitConverter.GetBytes((uint)(uint)AccountRestrictionTransactionBodyReserved_1)); 
		ArrayHelpers.WriteArray(bw, RestrictionAdditions);
		ArrayHelpers.WriteArray(bw, RestrictionDeletions);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"restrictionFlags: {RestrictionFlags}, ";
		result += $"restrictionAdditions: [{string.Join(",", RestrictionAdditions.Select(e => e.ToString()))}], ";
		result += $"restrictionDeletions: [{string.Join(",", RestrictionDeletions.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class MosaicAddressRestrictionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ADDRESS_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"TargetAddress", "pod:UnresolvedAddress"}
	};

	public MosaicAddressRestrictionTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicId = new UnresolvedMosaicId();
		RestrictionKey = 0;
		PreviousRestrictionValue = 0;
		NewRestrictionValue = 0;
		TargetAddress = new UnresolvedAddress();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedMosaicId MosaicId { get; set; }

	public ulong RestrictionKey { get; set; }

	public ulong PreviousRestrictionValue { get; set; }

	public ulong NewRestrictionValue { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += MosaicId.Size;
			size += 8;
			size += 8;
			size += 8;
			size += TargetAddress.Size;
			return size;
		}
	}

	public static MosaicAddressRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var restrictionKey = br.ReadUInt64();
		var previousRestrictionValue = br.ReadUInt64();
		var newRestrictionValue = br.ReadUInt64();
		var targetAddress = UnresolvedAddress.Deserialize(br);

		var instance = new MosaicAddressRestrictionTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			MosaicId = mosaicId,
			RestrictionKey = restrictionKey,
			PreviousRestrictionValue = previousRestrictionValue,
			NewRestrictionValue = newRestrictionValue,
			TargetAddress = targetAddress
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)RestrictionKey)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)PreviousRestrictionValue)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)NewRestrictionValue)); 
		bw.Write(TargetAddress.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"restrictionKey: {Converter.ToString(RestrictionKey)}, ";
		result += $"previousRestrictionValue: {Converter.ToString(PreviousRestrictionValue)}, ";
		result += $"newRestrictionValue: {Converter.ToString(NewRestrictionValue)}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicAddressRestrictionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ADDRESS_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"TargetAddress", "pod:UnresolvedAddress"}
	};

	public EmbeddedMosaicAddressRestrictionTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		MosaicId = new UnresolvedMosaicId();
		RestrictionKey = 0;
		PreviousRestrictionValue = 0;
		NewRestrictionValue = 0;
		TargetAddress = new UnresolvedAddress();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedMosaicId MosaicId { get; set; }

	public ulong RestrictionKey { get; set; }

	public ulong PreviousRestrictionValue { get; set; }

	public ulong NewRestrictionValue { get; set; }

	public UnresolvedAddress TargetAddress { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += MosaicId.Size;
			size += 8;
			size += 8;
			size += 8;
			size += TargetAddress.Size;
			return size;
		}
	}

	public static EmbeddedMosaicAddressRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var restrictionKey = br.ReadUInt64();
		var previousRestrictionValue = br.ReadUInt64();
		var newRestrictionValue = br.ReadUInt64();
		var targetAddress = UnresolvedAddress.Deserialize(br);

		var instance = new EmbeddedMosaicAddressRestrictionTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			MosaicId = mosaicId,
			RestrictionKey = restrictionKey,
			PreviousRestrictionValue = previousRestrictionValue,
			NewRestrictionValue = newRestrictionValue,
			TargetAddress = targetAddress
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)RestrictionKey)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)PreviousRestrictionValue)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)NewRestrictionValue)); 
		bw.Write(TargetAddress.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"restrictionKey: {Converter.ToString(RestrictionKey)}, ";
		result += $"previousRestrictionValue: {Converter.ToString(PreviousRestrictionValue)}, ";
		result += $"newRestrictionValue: {Converter.ToString(NewRestrictionValue)}, ";
		result += $"targetAddress: {TargetAddress}, ";
		result += ")";
		return result;
	}
}

public class MosaicRestrictionKey : BaseValue, ISerializer {
	public const byte SIZE = 8;

	public MosaicRestrictionKey(ulong mosaicRestrictionKey = 0): base(SIZE, mosaicRestrictionKey) {
	}

	public static MosaicRestrictionKey Deserialize(BinaryReader br) {
		return new MosaicRestrictionKey(br.ReadUInt64());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((ulong)Value);
	}
}

public class MosaicRestrictionType : IEnum<byte> {
	public static readonly MosaicRestrictionType NONE = new MosaicRestrictionType(0);

	public static readonly MosaicRestrictionType EQ = new MosaicRestrictionType(1);

	public static readonly MosaicRestrictionType NE = new MosaicRestrictionType(2);

	public static readonly MosaicRestrictionType LT = new MosaicRestrictionType(3);

	public static readonly MosaicRestrictionType LE = new MosaicRestrictionType(4);

	public static readonly MosaicRestrictionType GT = new MosaicRestrictionType(5);

	public static readonly MosaicRestrictionType GE = new MosaicRestrictionType(6);

	public byte Value { get; }

	public MosaicRestrictionType(byte value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			0, 1, 2, 3, 4, 5, 6
		};
		var keys = new []{
			"NONE", "EQ", "NE", "LT", "LE", "GT", "GE"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static MosaicRestrictionType FromValue(uint value) {
		return value switch
		{
			0 => NONE,
			1 => EQ,
			2 => NE,
			3 => LT,
			4 => LE,
			5 => GT,
			6 => GE,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 1;
		}
	}

	public static MosaicRestrictionType Deserialize(BinaryReader br) {
		return FromValue(br.ReadByte());
	}

	public byte[] Serialize() {
		return new []{Value};
	}

	public override string ToString() {
		return $"MosaicRestrictionType.{ValueToKey(Value)}";
	}
}

public class MosaicGlobalRestrictionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_GLOBAL_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"ReferenceMosaicId", "pod:UnresolvedMosaicId"},
		{"PreviousRestrictionType", "enum:MosaicRestrictionType"},
		{"NewRestrictionType", "enum:MosaicRestrictionType"}
	};

	public MosaicGlobalRestrictionTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicId = new UnresolvedMosaicId();
		ReferenceMosaicId = new UnresolvedMosaicId();
		RestrictionKey = 0;
		PreviousRestrictionValue = 0;
		NewRestrictionValue = 0;
		PreviousRestrictionType = MosaicRestrictionType.NONE;
		NewRestrictionType = MosaicRestrictionType.NONE;
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedMosaicId MosaicId { get; set; }

	public UnresolvedMosaicId ReferenceMosaicId { get; set; }

	public ulong RestrictionKey { get; set; }

	public ulong PreviousRestrictionValue { get; set; }

	public ulong NewRestrictionValue { get; set; }

	public MosaicRestrictionType PreviousRestrictionType { get; set; }

	public MosaicRestrictionType NewRestrictionType { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += MosaicId.Size;
			size += ReferenceMosaicId.Size;
			size += 8;
			size += 8;
			size += 8;
			size += PreviousRestrictionType.Size;
			size += NewRestrictionType.Size;
			return size;
		}
	}

	public static MosaicGlobalRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var referenceMosaicId = UnresolvedMosaicId.Deserialize(br);
		var restrictionKey = br.ReadUInt64();
		var previousRestrictionValue = br.ReadUInt64();
		var newRestrictionValue = br.ReadUInt64();
		var previousRestrictionType = MosaicRestrictionType.Deserialize(br);
		var newRestrictionType = MosaicRestrictionType.Deserialize(br);

		var instance = new MosaicGlobalRestrictionTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			MosaicId = mosaicId,
			ReferenceMosaicId = referenceMosaicId,
			RestrictionKey = restrictionKey,
			PreviousRestrictionValue = previousRestrictionValue,
			NewRestrictionValue = newRestrictionValue,
			PreviousRestrictionType = previousRestrictionType,
			NewRestrictionType = newRestrictionType
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(ReferenceMosaicId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)RestrictionKey)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)PreviousRestrictionValue)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)NewRestrictionValue)); 
		bw.Write(PreviousRestrictionType.Serialize()); 
		bw.Write(NewRestrictionType.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"referenceMosaicId: {ReferenceMosaicId}, ";
		result += $"restrictionKey: {Converter.ToString(RestrictionKey)}, ";
		result += $"previousRestrictionValue: {Converter.ToString(PreviousRestrictionValue)}, ";
		result += $"newRestrictionValue: {Converter.ToString(NewRestrictionValue)}, ";
		result += $"previousRestrictionType: {PreviousRestrictionType}, ";
		result += $"newRestrictionType: {NewRestrictionType}, ";
		result += ")";
		return result;
	}
}

public class EmbeddedMosaicGlobalRestrictionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_GLOBAL_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"ReferenceMosaicId", "pod:UnresolvedMosaicId"},
		{"PreviousRestrictionType", "enum:MosaicRestrictionType"},
		{"NewRestrictionType", "enum:MosaicRestrictionType"}
	};

	public EmbeddedMosaicGlobalRestrictionTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		MosaicId = new UnresolvedMosaicId();
		ReferenceMosaicId = new UnresolvedMosaicId();
		RestrictionKey = 0;
		PreviousRestrictionValue = 0;
		NewRestrictionValue = 0;
		PreviousRestrictionType = MosaicRestrictionType.NONE;
		NewRestrictionType = MosaicRestrictionType.NONE;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
	}

	public void Sort() {
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedMosaicId MosaicId { get; set; }

	public UnresolvedMosaicId ReferenceMosaicId { get; set; }

	public ulong RestrictionKey { get; set; }

	public ulong PreviousRestrictionValue { get; set; }

	public ulong NewRestrictionValue { get; set; }

	public MosaicRestrictionType PreviousRestrictionType { get; set; }

	public MosaicRestrictionType NewRestrictionType { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += MosaicId.Size;
			size += ReferenceMosaicId.Size;
			size += 8;
			size += 8;
			size += 8;
			size += PreviousRestrictionType.Size;
			size += NewRestrictionType.Size;
			return size;
		}
	}

	public static EmbeddedMosaicGlobalRestrictionTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var mosaicId = UnresolvedMosaicId.Deserialize(br);
		var referenceMosaicId = UnresolvedMosaicId.Deserialize(br);
		var restrictionKey = br.ReadUInt64();
		var previousRestrictionValue = br.ReadUInt64();
		var newRestrictionValue = br.ReadUInt64();
		var previousRestrictionType = MosaicRestrictionType.Deserialize(br);
		var newRestrictionType = MosaicRestrictionType.Deserialize(br);

		var instance = new EmbeddedMosaicGlobalRestrictionTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			MosaicId = mosaicId,
			ReferenceMosaicId = referenceMosaicId,
			RestrictionKey = restrictionKey,
			PreviousRestrictionValue = previousRestrictionValue,
			NewRestrictionValue = newRestrictionValue,
			PreviousRestrictionType = previousRestrictionType,
			NewRestrictionType = newRestrictionType
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(MosaicId.Serialize()); 
		bw.Write(ReferenceMosaicId.Serialize()); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)RestrictionKey)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)PreviousRestrictionValue)); 
		bw.Write(BitConverter.GetBytes((ulong)(ulong)NewRestrictionValue)); 
		bw.Write(PreviousRestrictionType.Serialize()); 
		bw.Write(NewRestrictionType.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"referenceMosaicId: {ReferenceMosaicId}, ";
		result += $"restrictionKey: {Converter.ToString(RestrictionKey)}, ";
		result += $"previousRestrictionValue: {Converter.ToString(PreviousRestrictionValue)}, ";
		result += $"newRestrictionValue: {Converter.ToString(NewRestrictionValue)}, ";
		result += $"previousRestrictionType: {PreviousRestrictionType}, ";
		result += $"newRestrictionType: {NewRestrictionType}, ";
		result += ")";
		return result;
	}
}

public class TransferTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_2;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Mosaics", "array[UnresolvedMosaic]"},
		{"Message", "bytes_array"}
	};

	public TransferTransactionV1() {
		Signature = new Signature();
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new UnresolvedAddress();
		Mosaics = Array.Empty<UnresolvedMosaic>();
		Message = Array.Empty<byte>();
		VerifiableEntityHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		TransferTransactionBodyReserved_1 = 0; // reserved field
		TransferTransactionBodyReserved_2 = 0; // reserved field
	}

	public void Sort() {
		Array.Sort(Mosaics, (lhs, rhs) => {
		return ((ulong) ((lhs.MosaicId.GetType().GetMethod("Comparer") != null
		? lhs.MosaicId.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: lhs.MosaicId.GetType().GetField("Value").GetValue(lhs.MosaicId) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))
		.CompareTo((ulong) ((rhs.MosaicId.GetType().GetMethod("Comparer") != null
		? rhs.MosaicId.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: rhs.MosaicId.GetType().GetField("Value").GetValue(rhs.MosaicId) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));
		});
	}

	public Signature Signature { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public UnresolvedAddress RecipientAddress { get; set; }

	public UnresolvedMosaic[] Mosaics { get; set; }

	public byte[] Message { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += Signature.Size;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += RecipientAddress.Size;
			size += 2;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(Mosaics);
			size += (uint)Message.Length;
			return size;
		}
	}

	public static TransferTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var verifiableEntityHeaderReserved_1 = br.ReadUInt32();
		if (0 != verifiableEntityHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({verifiableEntityHeaderReserved_1})");
		var signature = Signature.Deserialize(br);
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddress = UnresolvedAddress.Deserialize(br);
		var messageSize = br.ReadUInt16();
		var mosaicsCount = br.ReadByte();
		var transferTransactionBodyReserved_1 = br.ReadByte();
		if (0 != transferTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({transferTransactionBodyReserved_1})");
		var transferTransactionBodyReserved_2 = br.ReadUInt32();
		if (0 != transferTransactionBodyReserved_2)
			throw new Exception($"Invalid value of reserved field ({transferTransactionBodyReserved_2})");
		var mosaics = ArrayHelpers.ReadArrayCount(br, UnresolvedMosaic.Deserialize, (byte)mosaicsCount);
		var message = br.ReadBytes((int)messageSize);

		var instance = new TransferTransactionV1()
		{
			Signature = signature,
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Mosaics = mosaics,
			Message = message
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)VerifiableEntityHeaderReserved_1)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Message.Length));  // bound: message_size
		bw.Write((byte)Mosaics.Length);  // bound: mosaics_count
		bw.Write((byte)TransferTransactionBodyReserved_1); 
		bw.Write(BitConverter.GetBytes((uint)(uint)TransferTransactionBodyReserved_2)); 
		ArrayHelpers.WriteArray(bw, Mosaics);
		bw.Write(Message); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signature: {Signature}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"mosaics: [{string.Join(",", Mosaics.Select(e => e.ToString()))}], ";
		result += $"message: hex({Converter.BytesToHex(Message)}), ";
		result += ")";
		return result;
	}
}

public class EmbeddedTransferTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_2;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Mosaics", "array[UnresolvedMosaic]"},
		{"Message", "bytes_array"}
	};

	public EmbeddedTransferTransactionV1() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		RecipientAddress = new UnresolvedAddress();
		Mosaics = Array.Empty<UnresolvedMosaic>();
		Message = Array.Empty<byte>();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
		TransferTransactionBodyReserved_1 = 0; // reserved field
		TransferTransactionBodyReserved_2 = 0; // reserved field
	}

	public void Sort() {
		Array.Sort(Mosaics, (lhs, rhs) => {
		return ((ulong) ((lhs.MosaicId.GetType().GetMethod("Comparer") != null
		? lhs.MosaicId.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: lhs.MosaicId.GetType().GetField("Value").GetValue(lhs.MosaicId) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))
		.CompareTo((ulong) ((rhs.MosaicId.GetType().GetMethod("Comparer") != null
		? rhs.MosaicId.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: rhs.MosaicId.GetType().GetField("Value").GetValue(rhs.MosaicId) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));
		});
	}

	public PublicKey SignerPublicKey { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public TransactionType Type { get; set; }

	public UnresolvedAddress RecipientAddress { get; set; }

	public UnresolvedMosaic[] Mosaics { get; set; }

	public byte[] Message { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += 1;
			size += Network.Size;
			size += Type.Size;
			size += RecipientAddress.Size;
			size += 2;
			size += 1;
			size += 1;
			size += 4;
			size += ArrayHelpers.Size(Mosaics);
			size += (uint)Message.Length;
			return size;
		}
	}

	public static EmbeddedTransferTransactionV1 Deserialize(BinaryReader br) {
		var size = br.ReadUInt32();
		var embeddedTransactionHeaderReserved_1 = br.ReadUInt32();
		if (0 != embeddedTransactionHeaderReserved_1)
			throw new Exception($"Invalid value of reserved field ({embeddedTransactionHeaderReserved_1})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var entityBodyReserved_1 = br.ReadUInt32();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var version = br.ReadByte();
		var network = NetworkType.Deserialize(br);
		var type = TransactionType.Deserialize(br);
		var recipientAddress = UnresolvedAddress.Deserialize(br);
		var messageSize = br.ReadUInt16();
		var mosaicsCount = br.ReadByte();
		var transferTransactionBodyReserved_1 = br.ReadByte();
		if (0 != transferTransactionBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({transferTransactionBodyReserved_1})");
		var transferTransactionBodyReserved_2 = br.ReadUInt32();
		if (0 != transferTransactionBodyReserved_2)
			throw new Exception($"Invalid value of reserved field ({transferTransactionBodyReserved_2})");
		var mosaics = ArrayHelpers.ReadArrayCount(br, UnresolvedMosaic.Deserialize, (byte)mosaicsCount);
		var message = br.ReadBytes((int)messageSize);

		var instance = new EmbeddedTransferTransactionV1()
		{
			SignerPublicKey = signerPublicKey,
			Version = version,
			Network = network,
			Type = type,
			RecipientAddress = recipientAddress,
			Mosaics = mosaics,
			Message = message
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Size);
		bw.Write(BitConverter.GetBytes((uint)(uint)EmbeddedTransactionHeaderReserved_1)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)EntityBodyReserved_1)); 
		bw.Write((byte)Version); 
		bw.Write(Network.Serialize()); 
		bw.Write(Type.Serialize()); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)Message.Length));  // bound: message_size
		bw.Write((byte)Mosaics.Length);  // bound: mosaics_count
		bw.Write((byte)TransferTransactionBodyReserved_1); 
		bw.Write(BitConverter.GetBytes((uint)(uint)TransferTransactionBodyReserved_2)); 
		ArrayHelpers.WriteArray(bw, Mosaics);
		bw.Write(Message); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"type: {Type}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"mosaics: [{string.Join(",", Mosaics.Select(e => e.ToString()))}], ";
		result += $"message: hex({Converter.BytesToHex(Message)}), ";
		result += ")";
		return result;
	}
}

public class TransactionFactory {
	public static ITransaction Deserialize(BinaryReader br) {
		var position = br.BaseStream.Position;
		var parent = Transaction.Deserialize(br);
		var mapping = new Dictionary<TransactionType, Func<BinaryReader, ITransaction>>
		{
			{AccountKeyLinkTransactionV1.TRANSACTION_TYPE, AccountKeyLinkTransactionV1.Deserialize},
			{NodeKeyLinkTransactionV1.TRANSACTION_TYPE, NodeKeyLinkTransactionV1.Deserialize},
			{AggregateCompleteTransactionV1.TRANSACTION_TYPE, AggregateCompleteTransactionV1.Deserialize},
			{AggregateCompleteTransactionV2.TRANSACTION_TYPE, AggregateCompleteTransactionV2.Deserialize},
			{AggregateBondedTransactionV1.TRANSACTION_TYPE, AggregateBondedTransactionV1.Deserialize},
			{AggregateBondedTransactionV2.TRANSACTION_TYPE, AggregateBondedTransactionV2.Deserialize},
			{VotingKeyLinkTransactionV1.TRANSACTION_TYPE, VotingKeyLinkTransactionV1.Deserialize},
			{VrfKeyLinkTransactionV1.TRANSACTION_TYPE, VrfKeyLinkTransactionV1.Deserialize},
			{HashLockTransactionV1.TRANSACTION_TYPE, HashLockTransactionV1.Deserialize},
			{SecretLockTransactionV1.TRANSACTION_TYPE, SecretLockTransactionV1.Deserialize},
			{SecretProofTransactionV1.TRANSACTION_TYPE, SecretProofTransactionV1.Deserialize},
			{AccountMetadataTransactionV1.TRANSACTION_TYPE, AccountMetadataTransactionV1.Deserialize},
			{MosaicMetadataTransactionV1.TRANSACTION_TYPE, MosaicMetadataTransactionV1.Deserialize},
			{NamespaceMetadataTransactionV1.TRANSACTION_TYPE, NamespaceMetadataTransactionV1.Deserialize},
			{MosaicDefinitionTransactionV1.TRANSACTION_TYPE, MosaicDefinitionTransactionV1.Deserialize},
			{MosaicSupplyChangeTransactionV1.TRANSACTION_TYPE, MosaicSupplyChangeTransactionV1.Deserialize},
			{MosaicSupplyRevocationTransactionV1.TRANSACTION_TYPE, MosaicSupplyRevocationTransactionV1.Deserialize},
			{MultisigAccountModificationTransactionV1.TRANSACTION_TYPE, MultisigAccountModificationTransactionV1.Deserialize},
			{AddressAliasTransactionV1.TRANSACTION_TYPE, AddressAliasTransactionV1.Deserialize},
			{MosaicAliasTransactionV1.TRANSACTION_TYPE, MosaicAliasTransactionV1.Deserialize},
			{NamespaceRegistrationTransactionV1.TRANSACTION_TYPE, NamespaceRegistrationTransactionV1.Deserialize},
			{AccountAddressRestrictionTransactionV1.TRANSACTION_TYPE, AccountAddressRestrictionTransactionV1.Deserialize},
			{AccountMosaicRestrictionTransactionV1.TRANSACTION_TYPE, AccountMosaicRestrictionTransactionV1.Deserialize},
			{AccountOperationRestrictionTransactionV1.TRANSACTION_TYPE, AccountOperationRestrictionTransactionV1.Deserialize},
			{MosaicAddressRestrictionTransactionV1.TRANSACTION_TYPE, MosaicAddressRestrictionTransactionV1.Deserialize},
			{MosaicGlobalRestrictionTransactionV1.TRANSACTION_TYPE, MosaicGlobalRestrictionTransactionV1.Deserialize},
			{TransferTransactionV1.TRANSACTION_TYPE, TransferTransactionV1.Deserialize}
		};
		br.BaseStream.Position = position;
		return mapping[parent.Type](br);
	}

	public static ITransaction Deserialize(string payload) {
		using var ms = new MemoryStream(Converter.HexToBytes(payload).ToArray());
		using var br = new BinaryReader(ms);
		return Deserialize(br);
	}

	public static ITransaction CreateByName(string entityName) {
		var mapping = new Dictionary<string, ITransaction>
		{
			{"account_key_link_transaction_v1", new AccountKeyLinkTransactionV1()},
			{"node_key_link_transaction_v1", new NodeKeyLinkTransactionV1()},
			{"aggregate_complete_transaction_v1", new AggregateCompleteTransactionV1()},
			{"aggregate_complete_transaction_v2", new AggregateCompleteTransactionV2()},
			{"aggregate_bonded_transaction_v1", new AggregateBondedTransactionV1()},
			{"aggregate_bonded_transaction_v2", new AggregateBondedTransactionV2()},
			{"voting_key_link_transaction_v1", new VotingKeyLinkTransactionV1()},
			{"vrf_key_link_transaction_v1", new VrfKeyLinkTransactionV1()},
			{"hash_lock_transaction_v1", new HashLockTransactionV1()},
			{"secret_lock_transaction_v1", new SecretLockTransactionV1()},
			{"secret_proof_transaction_v1", new SecretProofTransactionV1()},
			{"account_metadata_transaction_v1", new AccountMetadataTransactionV1()},
			{"mosaic_metadata_transaction_v1", new MosaicMetadataTransactionV1()},
			{"namespace_metadata_transaction_v1", new NamespaceMetadataTransactionV1()},
			{"mosaic_definition_transaction_v1", new MosaicDefinitionTransactionV1()},
			{"mosaic_supply_change_transaction_v1", new MosaicSupplyChangeTransactionV1()},
			{"mosaic_supply_revocation_transaction_v1", new MosaicSupplyRevocationTransactionV1()},
			{"multisig_account_modification_transaction_v1", new MultisigAccountModificationTransactionV1()},
			{"address_alias_transaction_v1", new AddressAliasTransactionV1()},
			{"mosaic_alias_transaction_v1", new MosaicAliasTransactionV1()},
			{"namespace_registration_transaction_v1", new NamespaceRegistrationTransactionV1()},
			{"account_address_restriction_transaction_v1", new AccountAddressRestrictionTransactionV1()},
			{"account_mosaic_restriction_transaction_v1", new AccountMosaicRestrictionTransactionV1()},
			{"account_operation_restriction_transaction_v1", new AccountOperationRestrictionTransactionV1()},
			{"mosaic_address_restriction_transaction_v1", new MosaicAddressRestrictionTransactionV1()},
			{"mosaic_global_restriction_transaction_v1", new MosaicGlobalRestrictionTransactionV1()},
			{"transfer_transaction_v1", new TransferTransactionV1()}

		};
		return mapping[entityName];
	}
}

public class EmbeddedTransactionFactory {
	public static IBaseTransaction Deserialize(BinaryReader br) {
		var position = br.BaseStream.Position;
		var parent = EmbeddedTransaction.Deserialize(br);
		var mapping = new Dictionary<TransactionType, Func<BinaryReader, IBaseTransaction>>
		{
			{EmbeddedAccountKeyLinkTransactionV1.TRANSACTION_TYPE, EmbeddedAccountKeyLinkTransactionV1.Deserialize},
			{EmbeddedNodeKeyLinkTransactionV1.TRANSACTION_TYPE, EmbeddedNodeKeyLinkTransactionV1.Deserialize},
			{EmbeddedVotingKeyLinkTransactionV1.TRANSACTION_TYPE, EmbeddedVotingKeyLinkTransactionV1.Deserialize},
			{EmbeddedVrfKeyLinkTransactionV1.TRANSACTION_TYPE, EmbeddedVrfKeyLinkTransactionV1.Deserialize},
			{EmbeddedHashLockTransactionV1.TRANSACTION_TYPE, EmbeddedHashLockTransactionV1.Deserialize},
			{EmbeddedSecretLockTransactionV1.TRANSACTION_TYPE, EmbeddedSecretLockTransactionV1.Deserialize},
			{EmbeddedSecretProofTransactionV1.TRANSACTION_TYPE, EmbeddedSecretProofTransactionV1.Deserialize},
			{EmbeddedAccountMetadataTransactionV1.TRANSACTION_TYPE, EmbeddedAccountMetadataTransactionV1.Deserialize},
			{EmbeddedMosaicMetadataTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicMetadataTransactionV1.Deserialize},
			{EmbeddedNamespaceMetadataTransactionV1.TRANSACTION_TYPE, EmbeddedNamespaceMetadataTransactionV1.Deserialize},
			{EmbeddedMosaicDefinitionTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicDefinitionTransactionV1.Deserialize},
			{EmbeddedMosaicSupplyChangeTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicSupplyChangeTransactionV1.Deserialize},
			{EmbeddedMosaicSupplyRevocationTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicSupplyRevocationTransactionV1.Deserialize},
			{EmbeddedMultisigAccountModificationTransactionV1.TRANSACTION_TYPE, EmbeddedMultisigAccountModificationTransactionV1.Deserialize},
			{EmbeddedAddressAliasTransactionV1.TRANSACTION_TYPE, EmbeddedAddressAliasTransactionV1.Deserialize},
			{EmbeddedMosaicAliasTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicAliasTransactionV1.Deserialize},
			{EmbeddedNamespaceRegistrationTransactionV1.TRANSACTION_TYPE, EmbeddedNamespaceRegistrationTransactionV1.Deserialize},
			{EmbeddedAccountAddressRestrictionTransactionV1.TRANSACTION_TYPE, EmbeddedAccountAddressRestrictionTransactionV1.Deserialize},
			{EmbeddedAccountMosaicRestrictionTransactionV1.TRANSACTION_TYPE, EmbeddedAccountMosaicRestrictionTransactionV1.Deserialize},
			{EmbeddedAccountOperationRestrictionTransactionV1.TRANSACTION_TYPE, EmbeddedAccountOperationRestrictionTransactionV1.Deserialize},
			{EmbeddedMosaicAddressRestrictionTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicAddressRestrictionTransactionV1.Deserialize},
			{EmbeddedMosaicGlobalRestrictionTransactionV1.TRANSACTION_TYPE, EmbeddedMosaicGlobalRestrictionTransactionV1.Deserialize},
			{EmbeddedTransferTransactionV1.TRANSACTION_TYPE, EmbeddedTransferTransactionV1.Deserialize}
		};
		br.BaseStream.Position = position;
		return mapping[parent.Type](br);
	}

	public static IBaseTransaction Deserialize(string payload) {
		using var ms = new MemoryStream(Converter.HexToBytes(payload).ToArray());
		using var br = new BinaryReader(ms);
		return Deserialize(br);
	}

	public static IBaseTransaction CreateByName(string entityName) {
		var mapping = new Dictionary<string, IBaseTransaction>
		{
			{"account_key_link_transaction_v1", new EmbeddedAccountKeyLinkTransactionV1()},
			{"node_key_link_transaction_v1", new EmbeddedNodeKeyLinkTransactionV1()},
			{"voting_key_link_transaction_v1", new EmbeddedVotingKeyLinkTransactionV1()},
			{"vrf_key_link_transaction_v1", new EmbeddedVrfKeyLinkTransactionV1()},
			{"hash_lock_transaction_v1", new EmbeddedHashLockTransactionV1()},
			{"secret_lock_transaction_v1", new EmbeddedSecretLockTransactionV1()},
			{"secret_proof_transaction_v1", new EmbeddedSecretProofTransactionV1()},
			{"account_metadata_transaction_v1", new EmbeddedAccountMetadataTransactionV1()},
			{"mosaic_metadata_transaction_v1", new EmbeddedMosaicMetadataTransactionV1()},
			{"namespace_metadata_transaction_v1", new EmbeddedNamespaceMetadataTransactionV1()},
			{"mosaic_definition_transaction_v1", new EmbeddedMosaicDefinitionTransactionV1()},
			{"mosaic_supply_change_transaction_v1", new EmbeddedMosaicSupplyChangeTransactionV1()},
			{"mosaic_supply_revocation_transaction_v1", new EmbeddedMosaicSupplyRevocationTransactionV1()},
			{"multisig_account_modification_transaction_v1", new EmbeddedMultisigAccountModificationTransactionV1()},
			{"address_alias_transaction_v1", new EmbeddedAddressAliasTransactionV1()},
			{"mosaic_alias_transaction_v1", new EmbeddedMosaicAliasTransactionV1()},
			{"namespace_registration_transaction_v1", new EmbeddedNamespaceRegistrationTransactionV1()},
			{"account_address_restriction_transaction_v1", new EmbeddedAccountAddressRestrictionTransactionV1()},
			{"account_mosaic_restriction_transaction_v1", new EmbeddedAccountMosaicRestrictionTransactionV1()},
			{"account_operation_restriction_transaction_v1", new EmbeddedAccountOperationRestrictionTransactionV1()},
			{"mosaic_address_restriction_transaction_v1", new EmbeddedMosaicAddressRestrictionTransactionV1()},
			{"mosaic_global_restriction_transaction_v1", new EmbeddedMosaicGlobalRestrictionTransactionV1()},
			{"transfer_transaction_v1", new EmbeddedTransferTransactionV1()}

		};
		return mapping[entityName];
	}
}
}