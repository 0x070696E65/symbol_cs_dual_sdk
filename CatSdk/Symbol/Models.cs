using CatSdk.Utils;
namespace CatSdk.Symbol;

public class Amount : BaseValue, ISerializer {
	private const byte SIZE = 8;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 4;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 4;

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
	private const byte SIZE = 4;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 8;

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
	private const byte SIZE = 24;

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
	private const byte SIZE = 24;

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
	private const byte SIZE = 32;

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
	private const byte SIZE = 64;

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
	private const byte SIZE = 32;

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
	private const byte SIZE = 32;

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
	private const byte SIZE = 64;

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

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"MosaicId", "pod:MosaicId"},
		{"Amount", "pod:Amount"}
	};

	public Mosaic() {
		MosaicId = new MosaicId();
		Amount = new Amount();
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

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"Amount", "pod:Amount"}
	};

	public UnresolvedMosaic() {
		MosaicId = new UnresolvedMosaicId();
		Amount = new Amount();
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
	public static readonly LinkAction UNLINK = new (0);

	public static readonly LinkAction LINK = new (1);

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
	public static readonly NetworkType MAINNET = new (104);

	public static readonly NetworkType TESTNET = new (152);

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
	public static readonly TransactionType ACCOUNT_KEY_LINK = new (16716);

	public static readonly TransactionType NODE_KEY_LINK = new (16972);

	public static readonly TransactionType AGGREGATE_COMPLETE = new (16705);

	public static readonly TransactionType AGGREGATE_BONDED = new (16961);

	public static readonly TransactionType VOTING_KEY_LINK = new (16707);

	public static readonly TransactionType VRF_KEY_LINK = new (16963);

	public static readonly TransactionType HASH_LOCK = new (16712);

	public static readonly TransactionType SECRET_LOCK = new (16722);

	public static readonly TransactionType SECRET_PROOF = new (16978);

	public static readonly TransactionType ACCOUNT_METADATA = new (16708);

	public static readonly TransactionType MOSAIC_METADATA = new (16964);

	public static readonly TransactionType NAMESPACE_METADATA = new (17220);

	public static readonly TransactionType MOSAIC_DEFINITION = new (16717);

	public static readonly TransactionType MOSAIC_SUPPLY_CHANGE = new (16973);

	public static readonly TransactionType MOSAIC_SUPPLY_REVOCATION = new (17229);

	public static readonly TransactionType MULTISIG_ACCOUNT_MODIFICATION = new (16725);

	public static readonly TransactionType ADDRESS_ALIAS = new (16974);

	public static readonly TransactionType MOSAIC_ALIAS = new (17230);

	public static readonly TransactionType NAMESPACE_REGISTRATION = new (16718);

	public static readonly TransactionType ACCOUNT_ADDRESS_RESTRICTION = new (16720);

	public static readonly TransactionType ACCOUNT_MOSAIC_RESTRICTION = new (16976);

	public static readonly TransactionType ACCOUNT_OPERATION_RESTRICTION = new (17232);

	public static readonly TransactionType MOSAIC_ADDRESS_RESTRICTION = new (16977);

	public static readonly TransactionType MOSAIC_GLOBAL_RESTRICTION = new (16721);

	public static readonly TransactionType TRANSFER = new (16724);

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

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public Dictionary<string, string> TypeHints { get; } = new (){
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

public class AccountKeyLinkTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public AccountKeyLinkTransaction() {
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

	public static AccountKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new AccountKeyLinkTransaction()
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

public class EmbeddedAccountKeyLinkTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedAccountKeyLinkTransaction() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
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

	public static EmbeddedAccountKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedAccountKeyLinkTransaction()
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

public class NodeKeyLinkTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NODE_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public NodeKeyLinkTransaction() {
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

	public static NodeKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new NodeKeyLinkTransaction()
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

public class EmbeddedNodeKeyLinkTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NODE_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedNodeKeyLinkTransaction() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
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

	public static EmbeddedNodeKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedNodeKeyLinkTransaction()
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

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"}
	};

	public Cosignature() {
		Version = 0;
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
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

	public Dictionary<string, string> TypeHints { get; } = new (){
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

public class AggregateCompleteTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.AGGREGATE_COMPLETE;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AggregateTransactionHeaderReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public AggregateCompleteTransaction() {
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

	public static AggregateCompleteTransaction Deserialize(BinaryReader br) {
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

		var instance = new AggregateCompleteTransaction()
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

public class AggregateBondedTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.AGGREGATE_BONDED;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AggregateTransactionHeaderReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public AggregateBondedTransaction() {
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

	public static AggregateBondedTransaction Deserialize(BinaryReader br) {
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

		var instance = new AggregateBondedTransaction()
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

public class VotingKeyLinkTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VOTING_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public VotingKeyLinkTransaction() {
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

	public static VotingKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new VotingKeyLinkTransaction()
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

public class EmbeddedVotingKeyLinkTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VOTING_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:VotingPublicKey"},
		{"StartEpoch", "pod:FinalizationEpoch"},
		{"EndEpoch", "pod:FinalizationEpoch"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedVotingKeyLinkTransaction() {
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

	public static EmbeddedVotingKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedVotingKeyLinkTransaction()
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

public class VrfKeyLinkTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VRF_KEY_LINK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public VrfKeyLinkTransaction() {
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

	public static VrfKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new VrfKeyLinkTransaction()
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

public class EmbeddedVrfKeyLinkTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.VRF_KEY_LINK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"LinkedPublicKey", "pod:PublicKey"},
		{"LinkAction", "enum:LinkAction"}
	};

	public EmbeddedVrfKeyLinkTransaction() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		LinkedPublicKey = new PublicKey();
		LinkAction = LinkAction.UNLINK;
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
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

	public static EmbeddedVrfKeyLinkTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedVrfKeyLinkTransaction()
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

public class HashLockTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.HASH_LOCK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public HashLockTransaction() {
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

	public static HashLockTransaction Deserialize(BinaryReader br) {
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

		var instance = new HashLockTransaction()
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

public class EmbeddedHashLockTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.HASH_LOCK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Mosaic", "struct:UnresolvedMosaic"},
		{"Duration", "pod:BlockDuration"},
		{"Hash", "pod:Hash256"}
	};

	public EmbeddedHashLockTransaction() {
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

	public static EmbeddedHashLockTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedHashLockTransaction()
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
	public static readonly LockHashAlgorithm SHA3_256 = new (0);

	public static readonly LockHashAlgorithm HASH_160 = new (1);

	public static readonly LockHashAlgorithm HASH_256 = new (2);

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

public class SecretLockTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_LOCK;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public SecretLockTransaction() {
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

	public static SecretLockTransaction Deserialize(BinaryReader br) {
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

		var instance = new SecretLockTransaction()
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

public class EmbeddedSecretLockTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_LOCK;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Secret", "pod:Hash256"},
		{"Mosaic", "struct:UnresolvedMosaic"},
		{"Duration", "pod:BlockDuration"},
		{"HashAlgorithm", "enum:LockHashAlgorithm"}
	};

	public EmbeddedSecretLockTransaction() {
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

	public static EmbeddedSecretLockTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedSecretLockTransaction()
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

public class SecretProofTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_PROOF;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public SecretProofTransaction() {
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

	public static SecretProofTransaction Deserialize(BinaryReader br) {
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

		var instance = new SecretProofTransaction()
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

public class EmbeddedSecretProofTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.SECRET_PROOF;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Secret", "pod:Hash256"},
		{"HashAlgorithm", "enum:LockHashAlgorithm"},
		{"Proof", "bytes_array"}
	};

	public EmbeddedSecretProofTransaction() {
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

	public static EmbeddedSecretProofTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedSecretProofTransaction()
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

public class AccountMetadataTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_METADATA;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"Value", "bytes_array"}
	};

	public AccountMetadataTransaction() {
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

	public static AccountMetadataTransaction Deserialize(BinaryReader br) {
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

		var instance = new AccountMetadataTransaction()
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

public class EmbeddedAccountMetadataTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_METADATA;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"Value", "bytes_array"}
	};

	public EmbeddedAccountMetadataTransaction() {
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

	public static EmbeddedAccountMetadataTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedAccountMetadataTransaction()
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

public class MosaicMetadataTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_METADATA;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public MosaicMetadataTransaction() {
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

	public static MosaicMetadataTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicMetadataTransaction()
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

public class EmbeddedMosaicMetadataTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_METADATA;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"TargetMosaicId", "pod:UnresolvedMosaicId"},
		{"Value", "bytes_array"}
	};

	public EmbeddedMosaicMetadataTransaction() {
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

	public static EmbeddedMosaicMetadataTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicMetadataTransaction()
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
	private const byte SIZE = 8;

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
	public static readonly NamespaceRegistrationType ROOT = new (0);

	public static readonly NamespaceRegistrationType CHILD = new (1);

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
	public static readonly AliasAction UNLINK = new (0);

	public static readonly AliasAction LINK = new (1);

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

public class NamespaceMetadataTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_METADATA;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public NamespaceMetadataTransaction() {
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

	public static NamespaceMetadataTransaction Deserialize(BinaryReader br) {
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

		var instance = new NamespaceMetadataTransaction()
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

public class EmbeddedNamespaceMetadataTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_METADATA;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"TargetAddress", "pod:UnresolvedAddress"},
		{"TargetNamespaceId", "pod:NamespaceId"},
		{"Value", "bytes_array"}
	};

	public EmbeddedNamespaceMetadataTransaction() {
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

	public static EmbeddedNamespaceMetadataTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedNamespaceMetadataTransaction()
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
	private const byte SIZE = 4;

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
	public static readonly MosaicFlags NONE = new (0);

	public static readonly MosaicFlags SUPPLY_MUTABLE = new (1);

	public static readonly MosaicFlags TRANSFERABLE = new (2);

	public static readonly MosaicFlags RESTRICTABLE = new (4);

	public static readonly MosaicFlags REVOKABLE = new (8);

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
	public static readonly MosaicSupplyChangeAction DECREASE = new (0);

	public static readonly MosaicSupplyChangeAction INCREASE = new (1);

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

public class MosaicDefinitionTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_DEFINITION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public MosaicDefinitionTransaction() {
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

	public static MosaicDefinitionTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicDefinitionTransaction()
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

public class EmbeddedMosaicDefinitionTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_DEFINITION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Id", "pod:MosaicId"},
		{"Duration", "pod:BlockDuration"},
		{"Nonce", "pod:MosaicNonce"},
		{"Flags", "enum:MosaicFlags"}
	};

	public EmbeddedMosaicDefinitionTransaction() {
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

	public static EmbeddedMosaicDefinitionTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicDefinitionTransaction()
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

public class MosaicSupplyChangeTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_CHANGE;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public MosaicSupplyChangeTransaction() {
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

	public static MosaicSupplyChangeTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicSupplyChangeTransaction()
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

public class EmbeddedMosaicSupplyChangeTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_CHANGE;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"Delta", "pod:Amount"},
		{"Action", "enum:MosaicSupplyChangeAction"}
	};

	public EmbeddedMosaicSupplyChangeTransaction() {
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

	public static EmbeddedMosaicSupplyChangeTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicSupplyChangeTransaction()
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

public class MosaicSupplyRevocationTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_REVOCATION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"SourceAddress", "pod:UnresolvedAddress"},
		{"Mosaic", "struct:UnresolvedMosaic"}
	};

	public MosaicSupplyRevocationTransaction() {
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

	public static MosaicSupplyRevocationTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicSupplyRevocationTransaction()
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

public class EmbeddedMosaicSupplyRevocationTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_REVOCATION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"SourceAddress", "pod:UnresolvedAddress"},
		{"Mosaic", "struct:UnresolvedMosaic"}
	};

	public EmbeddedMosaicSupplyRevocationTransaction() {
		SignerPublicKey = new PublicKey();
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Type = TRANSACTION_TYPE;
		SourceAddress = new UnresolvedAddress();
		Mosaic = new UnresolvedMosaic();
		EmbeddedTransactionHeaderReserved_1 = 0; // reserved field
		EntityBodyReserved_1 = 0; // reserved field
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

	public static EmbeddedMosaicSupplyRevocationTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicSupplyRevocationTransaction()
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

public class MultisigAccountModificationTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int MultisigAccountModificationTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"AddressAdditions", "array[UnresolvedAddress]"},
		{"AddressDeletions", "array[UnresolvedAddress]"}
	};

	public MultisigAccountModificationTransaction() {
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

	public static MultisigAccountModificationTransaction Deserialize(BinaryReader br) {
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

		var instance = new MultisigAccountModificationTransaction()
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

public class EmbeddedMultisigAccountModificationTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int MultisigAccountModificationTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"AddressAdditions", "array[UnresolvedAddress]"},
		{"AddressDeletions", "array[UnresolvedAddress]"}
	};

	public EmbeddedMultisigAccountModificationTransaction() {
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

	public static EmbeddedMultisigAccountModificationTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMultisigAccountModificationTransaction()
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

public class AddressAliasTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ADDRESS_ALIAS;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public AddressAliasTransaction() {
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

	public static AddressAliasTransaction Deserialize(BinaryReader br) {
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

		var instance = new AddressAliasTransaction()
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

public class EmbeddedAddressAliasTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ADDRESS_ALIAS;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"NamespaceId", "pod:NamespaceId"},
		{"Address", "pod:Address"},
		{"AliasAction", "enum:AliasAction"}
	};

	public EmbeddedAddressAliasTransaction() {
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

	public static EmbeddedAddressAliasTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedAddressAliasTransaction()
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

public class MosaicAliasTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ALIAS;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public MosaicAliasTransaction() {
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

	public static MosaicAliasTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicAliasTransaction()
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

public class EmbeddedMosaicAliasTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ALIAS;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"NamespaceId", "pod:NamespaceId"},
		{"MosaicId", "pod:MosaicId"},
		{"AliasAction", "enum:AliasAction"}
	};

	public EmbeddedMosaicAliasTransaction() {
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

	public static EmbeddedMosaicAliasTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicAliasTransaction()
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

public class NamespaceRegistrationTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_REGISTRATION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public NamespaceRegistrationTransaction() {
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

	public static NamespaceRegistrationTransaction Deserialize(BinaryReader br) {
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

		var instance = new NamespaceRegistrationTransaction()
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

public class EmbeddedNamespaceRegistrationTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_REGISTRATION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Duration", "pod:BlockDuration"},
		{"ParentId", "pod:NamespaceId"},
		{"Id", "pod:NamespaceId"},
		{"RegistrationType", "enum:NamespaceRegistrationType"},
		{"Name", "bytes_array"}
	};

	public EmbeddedNamespaceRegistrationTransaction() {
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

	public static EmbeddedNamespaceRegistrationTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedNamespaceRegistrationTransaction()
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
	public static readonly AccountRestrictionFlags ADDRESS = new (1);

	public static readonly AccountRestrictionFlags MOSAIC_ID = new (2);

	public static readonly AccountRestrictionFlags TRANSACTION_TYPE = new (4);

	public static readonly AccountRestrictionFlags OUTGOING = new (16384);

	public static readonly AccountRestrictionFlags BLOCK = new (32768);

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

public class AccountAddressRestrictionTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_ADDRESS_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public AccountAddressRestrictionTransaction() {
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

	public static AccountAddressRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new AccountAddressRestrictionTransaction()
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

public class EmbeddedAccountAddressRestrictionTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_ADDRESS_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[UnresolvedAddress]"},
		{"RestrictionDeletions", "array[UnresolvedAddress]"}
	};

	public EmbeddedAccountAddressRestrictionTransaction() {
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

	public static EmbeddedAccountAddressRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedAccountAddressRestrictionTransaction()
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

public class AccountMosaicRestrictionTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_MOSAIC_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public AccountMosaicRestrictionTransaction() {
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

	public static AccountMosaicRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new AccountMosaicRestrictionTransaction()
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

public class EmbeddedAccountMosaicRestrictionTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_MOSAIC_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[UnresolvedMosaicId]"},
		{"RestrictionDeletions", "array[UnresolvedMosaicId]"}
	};

	public EmbeddedAccountMosaicRestrictionTransaction() {
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

	public static EmbeddedAccountMosaicRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedAccountMosaicRestrictionTransaction()
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

public class AccountOperationRestrictionTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_OPERATION_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public AccountOperationRestrictionTransaction() {
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

	public static AccountOperationRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new AccountOperationRestrictionTransaction()
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

public class EmbeddedAccountOperationRestrictionTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_OPERATION_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int AccountRestrictionTransactionBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RestrictionFlags", "enum:AccountRestrictionFlags"},
		{"RestrictionAdditions", "array[TransactionType]"},
		{"RestrictionDeletions", "array[TransactionType]"}
	};

	public EmbeddedAccountOperationRestrictionTransaction() {
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

	public static EmbeddedAccountOperationRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedAccountOperationRestrictionTransaction()
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

public class MosaicAddressRestrictionTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ADDRESS_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"Signature", "pod:Signature"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"TargetAddress", "pod:UnresolvedAddress"}
	};

	public MosaicAddressRestrictionTransaction() {
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

	public static MosaicAddressRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicAddressRestrictionTransaction()
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

public class EmbeddedMosaicAddressRestrictionTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_ADDRESS_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"TargetAddress", "pod:UnresolvedAddress"}
	};

	public EmbeddedMosaicAddressRestrictionTransaction() {
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

	public static EmbeddedMosaicAddressRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicAddressRestrictionTransaction()
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
	private const byte SIZE = 8;

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
	public static readonly MosaicRestrictionType NONE = new (0);

	public static readonly MosaicRestrictionType EQ = new (1);

	public static readonly MosaicRestrictionType NE = new (2);

	public static readonly MosaicRestrictionType LT = new (3);

	public static readonly MosaicRestrictionType LE = new (4);

	public static readonly MosaicRestrictionType GT = new (5);

	public static readonly MosaicRestrictionType GE = new (6);

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

public class MosaicGlobalRestrictionTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_GLOBAL_RESTRICTION;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public MosaicGlobalRestrictionTransaction() {
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

	public static MosaicGlobalRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new MosaicGlobalRestrictionTransaction()
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

public class EmbeddedMosaicGlobalRestrictionTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_GLOBAL_RESTRICTION;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"MosaicId", "pod:UnresolvedMosaicId"},
		{"ReferenceMosaicId", "pod:UnresolvedMosaicId"},
		{"PreviousRestrictionType", "enum:MosaicRestrictionType"},
		{"NewRestrictionType", "enum:MosaicRestrictionType"}
	};

	public EmbeddedMosaicGlobalRestrictionTransaction() {
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

	public static EmbeddedMosaicGlobalRestrictionTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedMosaicGlobalRestrictionTransaction()
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

public class TransferTransaction : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int VerifiableEntityHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_2;

	public Dictionary<string, string> TypeHints { get; } = new (){
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

	public TransferTransaction() {
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

	public static TransferTransaction Deserialize(BinaryReader br) {
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

		var instance = new TransferTransaction()
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

public class EmbeddedTransferTransaction : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int EmbeddedTransactionHeaderReserved_1;
	private readonly int EntityBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_1;
	private readonly int TransferTransactionBodyReserved_2;

	public Dictionary<string, string> TypeHints { get; } = new (){
		{"SignerPublicKey", "pod:PublicKey"},
		{"Network", "enum:NetworkType"},
		{"Type", "enum:TransactionType"},
		{"RecipientAddress", "pod:UnresolvedAddress"},
		{"Mosaics", "array[UnresolvedMosaic]"},
		{"Message", "bytes_array"}
	};

	public EmbeddedTransferTransaction() {
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

	public static EmbeddedTransferTransaction Deserialize(BinaryReader br) {
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

		var instance = new EmbeddedTransferTransaction()
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
			{AccountKeyLinkTransaction.TRANSACTION_TYPE, AccountKeyLinkTransaction.Deserialize},
			{NodeKeyLinkTransaction.TRANSACTION_TYPE, NodeKeyLinkTransaction.Deserialize},
			{AggregateCompleteTransaction.TRANSACTION_TYPE, AggregateCompleteTransaction.Deserialize},
			{AggregateBondedTransaction.TRANSACTION_TYPE, AggregateBondedTransaction.Deserialize},
			{VotingKeyLinkTransaction.TRANSACTION_TYPE, VotingKeyLinkTransaction.Deserialize},
			{VrfKeyLinkTransaction.TRANSACTION_TYPE, VrfKeyLinkTransaction.Deserialize},
			{HashLockTransaction.TRANSACTION_TYPE, HashLockTransaction.Deserialize},
			{SecretLockTransaction.TRANSACTION_TYPE, SecretLockTransaction.Deserialize},
			{SecretProofTransaction.TRANSACTION_TYPE, SecretProofTransaction.Deserialize},
			{AccountMetadataTransaction.TRANSACTION_TYPE, AccountMetadataTransaction.Deserialize},
			{MosaicMetadataTransaction.TRANSACTION_TYPE, MosaicMetadataTransaction.Deserialize},
			{NamespaceMetadataTransaction.TRANSACTION_TYPE, NamespaceMetadataTransaction.Deserialize},
			{MosaicDefinitionTransaction.TRANSACTION_TYPE, MosaicDefinitionTransaction.Deserialize},
			{MosaicSupplyChangeTransaction.TRANSACTION_TYPE, MosaicSupplyChangeTransaction.Deserialize},
			{MosaicSupplyRevocationTransaction.TRANSACTION_TYPE, MosaicSupplyRevocationTransaction.Deserialize},
			{MultisigAccountModificationTransaction.TRANSACTION_TYPE, MultisigAccountModificationTransaction.Deserialize},
			{AddressAliasTransaction.TRANSACTION_TYPE, AddressAliasTransaction.Deserialize},
			{MosaicAliasTransaction.TRANSACTION_TYPE, MosaicAliasTransaction.Deserialize},
			{NamespaceRegistrationTransaction.TRANSACTION_TYPE, NamespaceRegistrationTransaction.Deserialize},
			{AccountAddressRestrictionTransaction.TRANSACTION_TYPE, AccountAddressRestrictionTransaction.Deserialize},
			{AccountMosaicRestrictionTransaction.TRANSACTION_TYPE, AccountMosaicRestrictionTransaction.Deserialize},
			{AccountOperationRestrictionTransaction.TRANSACTION_TYPE, AccountOperationRestrictionTransaction.Deserialize},
			{MosaicAddressRestrictionTransaction.TRANSACTION_TYPE, MosaicAddressRestrictionTransaction.Deserialize},
			{MosaicGlobalRestrictionTransaction.TRANSACTION_TYPE, MosaicGlobalRestrictionTransaction.Deserialize},
			{TransferTransaction.TRANSACTION_TYPE, TransferTransaction.Deserialize}
		};
		br.BaseStream.Position = position;
		return mapping[parent.Type](br);
	}

	public static ITransaction Deserialize(string payload) {
		using var ms = new MemoryStream(Converter.HexToBytes(payload).ToArray());
		using var br = new BinaryReader(ms);
		return Deserialize(br);
	}

	public static ITransaction CreateByName(TransactionType entityName) {
		var mapping = new Dictionary<TransactionType, ITransaction>
		{
			{AccountKeyLinkTransaction.TRANSACTION_TYPE, new AccountKeyLinkTransaction()},
			{NodeKeyLinkTransaction.TRANSACTION_TYPE, new NodeKeyLinkTransaction()},
			{AggregateCompleteTransaction.TRANSACTION_TYPE, new AggregateCompleteTransaction()},
			{AggregateBondedTransaction.TRANSACTION_TYPE, new AggregateBondedTransaction()},
			{VotingKeyLinkTransaction.TRANSACTION_TYPE, new VotingKeyLinkTransaction()},
			{VrfKeyLinkTransaction.TRANSACTION_TYPE, new VrfKeyLinkTransaction()},
			{HashLockTransaction.TRANSACTION_TYPE, new HashLockTransaction()},
			{SecretLockTransaction.TRANSACTION_TYPE, new SecretLockTransaction()},
			{SecretProofTransaction.TRANSACTION_TYPE, new SecretProofTransaction()},
			{AccountMetadataTransaction.TRANSACTION_TYPE, new AccountMetadataTransaction()},
			{MosaicMetadataTransaction.TRANSACTION_TYPE, new MosaicMetadataTransaction()},
			{NamespaceMetadataTransaction.TRANSACTION_TYPE, new NamespaceMetadataTransaction()},
			{MosaicDefinitionTransaction.TRANSACTION_TYPE, new MosaicDefinitionTransaction()},
			{MosaicSupplyChangeTransaction.TRANSACTION_TYPE, new MosaicSupplyChangeTransaction()},
			{MosaicSupplyRevocationTransaction.TRANSACTION_TYPE, new MosaicSupplyRevocationTransaction()},
			{MultisigAccountModificationTransaction.TRANSACTION_TYPE, new MultisigAccountModificationTransaction()},
			{AddressAliasTransaction.TRANSACTION_TYPE, new AddressAliasTransaction()},
			{MosaicAliasTransaction.TRANSACTION_TYPE, new MosaicAliasTransaction()},
			{NamespaceRegistrationTransaction.TRANSACTION_TYPE, new NamespaceRegistrationTransaction()},
			{AccountAddressRestrictionTransaction.TRANSACTION_TYPE, new AccountAddressRestrictionTransaction()},
			{AccountMosaicRestrictionTransaction.TRANSACTION_TYPE, new AccountMosaicRestrictionTransaction()},
			{AccountOperationRestrictionTransaction.TRANSACTION_TYPE, new AccountOperationRestrictionTransaction()},
			{MosaicAddressRestrictionTransaction.TRANSACTION_TYPE, new MosaicAddressRestrictionTransaction()},
			{MosaicGlobalRestrictionTransaction.TRANSACTION_TYPE, new MosaicGlobalRestrictionTransaction()},
			{TransferTransaction.TRANSACTION_TYPE, new TransferTransaction()}

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
			{EmbeddedAccountKeyLinkTransaction.TRANSACTION_TYPE, EmbeddedAccountKeyLinkTransaction.Deserialize},
			{EmbeddedNodeKeyLinkTransaction.TRANSACTION_TYPE, EmbeddedNodeKeyLinkTransaction.Deserialize},
			{EmbeddedVotingKeyLinkTransaction.TRANSACTION_TYPE, EmbeddedVotingKeyLinkTransaction.Deserialize},
			{EmbeddedVrfKeyLinkTransaction.TRANSACTION_TYPE, EmbeddedVrfKeyLinkTransaction.Deserialize},
			{EmbeddedHashLockTransaction.TRANSACTION_TYPE, EmbeddedHashLockTransaction.Deserialize},
			{EmbeddedSecretLockTransaction.TRANSACTION_TYPE, EmbeddedSecretLockTransaction.Deserialize},
			{EmbeddedSecretProofTransaction.TRANSACTION_TYPE, EmbeddedSecretProofTransaction.Deserialize},
			{EmbeddedAccountMetadataTransaction.TRANSACTION_TYPE, EmbeddedAccountMetadataTransaction.Deserialize},
			{EmbeddedMosaicMetadataTransaction.TRANSACTION_TYPE, EmbeddedMosaicMetadataTransaction.Deserialize},
			{EmbeddedNamespaceMetadataTransaction.TRANSACTION_TYPE, EmbeddedNamespaceMetadataTransaction.Deserialize},
			{EmbeddedMosaicDefinitionTransaction.TRANSACTION_TYPE, EmbeddedMosaicDefinitionTransaction.Deserialize},
			{EmbeddedMosaicSupplyChangeTransaction.TRANSACTION_TYPE, EmbeddedMosaicSupplyChangeTransaction.Deserialize},
			{EmbeddedMosaicSupplyRevocationTransaction.TRANSACTION_TYPE, EmbeddedMosaicSupplyRevocationTransaction.Deserialize},
			{EmbeddedMultisigAccountModificationTransaction.TRANSACTION_TYPE, EmbeddedMultisigAccountModificationTransaction.Deserialize},
			{EmbeddedAddressAliasTransaction.TRANSACTION_TYPE, EmbeddedAddressAliasTransaction.Deserialize},
			{EmbeddedMosaicAliasTransaction.TRANSACTION_TYPE, EmbeddedMosaicAliasTransaction.Deserialize},
			{EmbeddedNamespaceRegistrationTransaction.TRANSACTION_TYPE, EmbeddedNamespaceRegistrationTransaction.Deserialize},
			{EmbeddedAccountAddressRestrictionTransaction.TRANSACTION_TYPE, EmbeddedAccountAddressRestrictionTransaction.Deserialize},
			{EmbeddedAccountMosaicRestrictionTransaction.TRANSACTION_TYPE, EmbeddedAccountMosaicRestrictionTransaction.Deserialize},
			{EmbeddedAccountOperationRestrictionTransaction.TRANSACTION_TYPE, EmbeddedAccountOperationRestrictionTransaction.Deserialize},
			{EmbeddedMosaicAddressRestrictionTransaction.TRANSACTION_TYPE, EmbeddedMosaicAddressRestrictionTransaction.Deserialize},
			{EmbeddedMosaicGlobalRestrictionTransaction.TRANSACTION_TYPE, EmbeddedMosaicGlobalRestrictionTransaction.Deserialize},
			{EmbeddedTransferTransaction.TRANSACTION_TYPE, EmbeddedTransferTransaction.Deserialize}
		};
		br.BaseStream.Position = position;
		return mapping[parent.Type](br);
	}

	public static IBaseTransaction Deserialize(string payload) {
		using var ms = new MemoryStream(Converter.HexToBytes(payload).ToArray());
		using var br = new BinaryReader(ms);
		return Deserialize(br);
	}

	public static IBaseTransaction CreateByName(TransactionType entityName) {
		var mapping = new Dictionary<TransactionType, IBaseTransaction>
		{
			{EmbeddedAccountKeyLinkTransaction.TRANSACTION_TYPE, new EmbeddedAccountKeyLinkTransaction()},
			{EmbeddedNodeKeyLinkTransaction.TRANSACTION_TYPE, new EmbeddedNodeKeyLinkTransaction()},
			{EmbeddedVotingKeyLinkTransaction.TRANSACTION_TYPE, new EmbeddedVotingKeyLinkTransaction()},
			{EmbeddedVrfKeyLinkTransaction.TRANSACTION_TYPE, new EmbeddedVrfKeyLinkTransaction()},
			{EmbeddedHashLockTransaction.TRANSACTION_TYPE, new EmbeddedHashLockTransaction()},
			{EmbeddedSecretLockTransaction.TRANSACTION_TYPE, new EmbeddedSecretLockTransaction()},
			{EmbeddedSecretProofTransaction.TRANSACTION_TYPE, new EmbeddedSecretProofTransaction()},
			{EmbeddedAccountMetadataTransaction.TRANSACTION_TYPE, new EmbeddedAccountMetadataTransaction()},
			{EmbeddedMosaicMetadataTransaction.TRANSACTION_TYPE, new EmbeddedMosaicMetadataTransaction()},
			{EmbeddedNamespaceMetadataTransaction.TRANSACTION_TYPE, new EmbeddedNamespaceMetadataTransaction()},
			{EmbeddedMosaicDefinitionTransaction.TRANSACTION_TYPE, new EmbeddedMosaicDefinitionTransaction()},
			{EmbeddedMosaicSupplyChangeTransaction.TRANSACTION_TYPE, new EmbeddedMosaicSupplyChangeTransaction()},
			{EmbeddedMosaicSupplyRevocationTransaction.TRANSACTION_TYPE, new EmbeddedMosaicSupplyRevocationTransaction()},
			{EmbeddedMultisigAccountModificationTransaction.TRANSACTION_TYPE, new EmbeddedMultisigAccountModificationTransaction()},
			{EmbeddedAddressAliasTransaction.TRANSACTION_TYPE, new EmbeddedAddressAliasTransaction()},
			{EmbeddedMosaicAliasTransaction.TRANSACTION_TYPE, new EmbeddedMosaicAliasTransaction()},
			{EmbeddedNamespaceRegistrationTransaction.TRANSACTION_TYPE, new EmbeddedNamespaceRegistrationTransaction()},
			{EmbeddedAccountAddressRestrictionTransaction.TRANSACTION_TYPE, new EmbeddedAccountAddressRestrictionTransaction()},
			{EmbeddedAccountMosaicRestrictionTransaction.TRANSACTION_TYPE, new EmbeddedAccountMosaicRestrictionTransaction()},
			{EmbeddedAccountOperationRestrictionTransaction.TRANSACTION_TYPE, new EmbeddedAccountOperationRestrictionTransaction()},
			{EmbeddedMosaicAddressRestrictionTransaction.TRANSACTION_TYPE, new EmbeddedMosaicAddressRestrictionTransaction()},
			{EmbeddedMosaicGlobalRestrictionTransaction.TRANSACTION_TYPE, new EmbeddedMosaicGlobalRestrictionTransaction()},
			{EmbeddedTransferTransaction.TRANSACTION_TYPE, new EmbeddedTransferTransaction()}

		};
		return mapping[entityName];
	}
}
