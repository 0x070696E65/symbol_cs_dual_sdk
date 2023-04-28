using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CatSdk.Utils;
namespace CatSdk.Nem{

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

public class Timestamp : BaseValue, ISerializer {
	public const byte SIZE = 4;

	public Timestamp(uint timestamp = 0): base(SIZE, timestamp) {
	}

	public static Timestamp Deserialize(BinaryReader br) {
		return new Timestamp(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes((uint)Value);
	}
}

public class Address : ByteArray, ISerializer {
	public const byte SIZE = 40;

	public Address(byte[]? address = null): base(SIZE, address) {
	}

	public static Address Deserialize(BinaryReader br) {
		return new Address(br.ReadBytes(40));
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

public class TransactionType : IEnum<uint> {
	public static readonly TransactionType TRANSFER = new TransactionType(257);

	public static readonly TransactionType ACCOUNT_KEY_LINK = new TransactionType(2049);

	public static readonly TransactionType MULTISIG_ACCOUNT_MODIFICATION = new TransactionType(4097);

	public static readonly TransactionType MULTISIG_COSIGNATURE = new TransactionType(4098);

	public static readonly TransactionType MULTISIG_TRANSACTION = new TransactionType(4100);

	public static readonly TransactionType NAMESPACE_REGISTRATION = new TransactionType(8193);

	public static readonly TransactionType MOSAIC_DEFINITION = new TransactionType(16385);

	public static readonly TransactionType MOSAIC_SUPPLY_CHANGE = new TransactionType(16386);

	public uint Value { get; }

	public TransactionType(uint value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			257, 2049, 4097, 4098, 4100, 8193, 16385, 16386
		};
		var keys = new []{
			"TRANSFER", "ACCOUNT_KEY_LINK", "MULTISIG_ACCOUNT_MODIFICATION", "MULTISIG_COSIGNATURE", "MULTISIG_TRANSACTION",
			"NAMESPACE_REGISTRATION", "MOSAIC_DEFINITION", "MOSAIC_SUPPLY_CHANGE"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static TransactionType FromValue(uint value) {
		return value switch
		{
			257 => TRANSFER,
			2049 => ACCOUNT_KEY_LINK,
			4097 => MULTISIG_ACCOUNT_MODIFICATION,
			4098 => MULTISIG_COSIGNATURE,
			4100 => MULTISIG_TRANSACTION,
			8193 => NAMESPACE_REGISTRATION,
			16385 => MOSAIC_DEFINITION,
			16386 => MOSAIC_SUPPLY_CHANGE,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 4;
		}
	}

	public static TransactionType Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"TransactionType.{ValueToKey(Value)}";
	}
}

public class Transaction : ITransaction {
	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"}
	};

	public Transaction() {
		Type = TransactionType.TRANSFER;
		Version = 0;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			return size;
		}
	}

	public static Transaction Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);

		var instance = new Transaction()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += ")";
		return result;
	}
}

public class NonVerifiableTransaction : IBaseTransaction {
	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"}
	};

	public NonVerifiableTransaction() {
		Type = TransactionType.TRANSFER;
		Version = 0;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			return size;
		}
	}

	public static NonVerifiableTransaction Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);

		var instance = new NonVerifiableTransaction()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += ")";
		return result;
	}
}

public class LinkAction : IEnum<uint> {
	public static readonly LinkAction LINK = new LinkAction(1);

	public static readonly LinkAction UNLINK = new LinkAction(2);

	public uint Value { get; }

	public LinkAction(uint value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			1, 2
		};
		var keys = new []{
			"LINK", "UNLINK"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static LinkAction FromValue(uint value) {
		return value switch
		{
			1 => LINK,
			2 => UNLINK,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 4;
		}
	}

	public static LinkAction Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"LinkAction.{ValueToKey(Value)}";
	}
}

public class AccountKeyLinkTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_KEY_LINK;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int RemotePublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkAction", "enum:LinkAction"},
		{"RemotePublicKey", "pod:PublicKey"}
	};

	public AccountKeyLinkTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		LinkAction = LinkAction.LINK;
		RemotePublicKey = new PublicKey();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		RemotePublicKeySize = 32; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public LinkAction LinkAction { get; set; }

	public PublicKey RemotePublicKey { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += LinkAction.Size;
			size += 4;
			size += RemotePublicKey.Size;
			return size;
		}
	}

	public static AccountKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);
		var remotePublicKeySize = br.ReadUInt32();
		if (32 != remotePublicKeySize)
			throw new Exception($"Invalid value of reserved field ({remotePublicKeySize})");
		var remotePublicKey = PublicKey.Deserialize(br);

		var instance = new AccountKeyLinkTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			LinkAction = linkAction,
			RemotePublicKey = remotePublicKey
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RemotePublicKeySize)); 
		bw.Write(RemotePublicKey.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"linkAction: {LinkAction}, ";
		result += $"remotePublicKey: {RemotePublicKey}, ";
		result += ")";
		return result;
	}
}

public class NonVerifiableAccountKeyLinkTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.ACCOUNT_KEY_LINK;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int RemotePublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"LinkAction", "enum:LinkAction"},
		{"RemotePublicKey", "pod:PublicKey"}
	};

	public NonVerifiableAccountKeyLinkTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		LinkAction = LinkAction.LINK;
		RemotePublicKey = new PublicKey();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		RemotePublicKeySize = 32; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public LinkAction LinkAction { get; set; }

	public PublicKey RemotePublicKey { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += LinkAction.Size;
			size += 4;
			size += RemotePublicKey.Size;
			return size;
		}
	}

	public static NonVerifiableAccountKeyLinkTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var linkAction = LinkAction.Deserialize(br);
		var remotePublicKeySize = br.ReadUInt32();
		if (32 != remotePublicKeySize)
			throw new Exception($"Invalid value of reserved field ({remotePublicKeySize})");
		var remotePublicKey = PublicKey.Deserialize(br);

		var instance = new NonVerifiableAccountKeyLinkTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			LinkAction = linkAction,
			RemotePublicKey = remotePublicKey
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(LinkAction.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RemotePublicKeySize)); 
		bw.Write(RemotePublicKey.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"linkAction: {LinkAction}, ";
		result += $"remotePublicKey: {RemotePublicKey}, ";
		result += ")";
		return result;
	}
}

public class NamespaceId : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Name", "bytes_array"}
	};

	public NamespaceId() {
		Name = Array.Empty<byte>();
	}

	public void Sort() {
	}

	public byte[] Name { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += (uint)Name.Length;
			return size;
		}
	}

	public static NamespaceId Deserialize(BinaryReader br) {
		var nameSize = br.ReadUInt32();
		var name = br.ReadBytes((int)nameSize);

		var instance = new NamespaceId()
		{
			Name = name
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)(uint)Name.Length));  // bound: name_size
		bw.Write(Name); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		result += ")";
		return result;
	}
}

public class MosaicId : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"NamespaceId", "struct:NamespaceId"},
		{"Name", "bytes_array"}
	};

	public MosaicId() {
		NamespaceId = new NamespaceId();
		Name = Array.Empty<byte>();
	}

	public void Sort() {
		NamespaceId.Sort();
	}

	public NamespaceId NamespaceId { get; set; }

	public byte[] Name { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += NamespaceId.Size;
			size += 4;
			size += (uint)Name.Length;
			return size;
		}
	}

	public static MosaicId Deserialize(BinaryReader br) {
		var namespaceId = NamespaceId.Deserialize(br);
		var nameSize = br.ReadUInt32();
		var name = br.ReadBytes((int)nameSize);

		var instance = new MosaicId()
		{
			NamespaceId = namespaceId,
			Name = name
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(NamespaceId.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Name.Length));  // bound: name_size
		bw.Write(Name); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"namespaceId: {NamespaceId}, ";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		result += ")";
		return result;
	}
}

public class Mosaic : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"MosaicId", "struct:MosaicId"},
		{"Amount", "pod:Amount"}
	};

	public Mosaic() {
		MosaicId = new MosaicId();
		Amount = new Amount();
	}

	public void Sort() {
		MosaicId.Sort();
	}

	public MosaicId MosaicId { get; set; }

	public Amount Amount { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += MosaicId.Size;
			size += Amount.Size;
			return size;
		}
	}

	public static Mosaic Deserialize(BinaryReader br) {
		var mosaicIdSize = br.ReadUInt32();
		// marking sizeof field
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
		bw.Write(BitConverter.GetBytes((uint)MosaicId.Size));  // bound: mosaic_id_size
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

public class SizePrefixedMosaic : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Mosaic", "struct:Mosaic"}
	};

	public SizePrefixedMosaic() {
		Mosaic = new Mosaic();
	}

	public void Sort() {
		Mosaic.Sort();
	}

	public Mosaic Mosaic { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += Mosaic.Size;
			return size;
		}
	}

	public static SizePrefixedMosaic Deserialize(BinaryReader br) {
		var mosaicSize = br.ReadUInt32();
		// marking sizeof field
		var mosaic = Mosaic.Deserialize(br);

		var instance = new SizePrefixedMosaic()
		{
			Mosaic = mosaic
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)Mosaic.Size));  // bound: mosaic_size
		bw.Write(Mosaic.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"mosaic: {Mosaic}, ";
		result += ")";
		return result;
	}
}

public class MosaicTransferFeeType : IEnum<uint> {
	public static readonly MosaicTransferFeeType ABSOLUTE = new MosaicTransferFeeType(1);

	public static readonly MosaicTransferFeeType PERCENTILE = new MosaicTransferFeeType(2);

	public uint Value { get; }

	public MosaicTransferFeeType(uint value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			1, 2
		};
		var keys = new []{
			"ABSOLUTE", "PERCENTILE"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static MosaicTransferFeeType FromValue(uint value) {
		return value switch
		{
			1 => ABSOLUTE,
			2 => PERCENTILE,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 4;
		}
	}

	public static MosaicTransferFeeType Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"MosaicTransferFeeType.{ValueToKey(Value)}";
	}
}

public class MosaicLevy : IStruct {
	private readonly int RecipientAddressSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"TransferFeeType", "enum:MosaicTransferFeeType"},
		{"RecipientAddress", "pod:Address"},
		{"MosaicId", "struct:MosaicId"},
		{"Fee", "pod:Amount"}
	};

	public MosaicLevy() {
		TransferFeeType = MosaicTransferFeeType.ABSOLUTE;
		RecipientAddress = new Address();
		MosaicId = new MosaicId();
		Fee = new Amount();
		RecipientAddressSize = 40; // reserved field
	}

	public void Sort() {
		MosaicId.Sort();
	}

	public MosaicTransferFeeType TransferFeeType { get; set; }

	public Address RecipientAddress { get; set; }

	public MosaicId MosaicId { get; set; }

	public Amount Fee { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += TransferFeeType.Size;
			size += 4;
			size += RecipientAddress.Size;
			size += 4;
			size += MosaicId.Size;
			size += Fee.Size;
			return size;
		}
	}

	public static MosaicLevy Deserialize(BinaryReader br) {
		var transferFeeType = MosaicTransferFeeType.Deserialize(br);
		var recipientAddressSize = br.ReadUInt32();
		if (40 != recipientAddressSize)
			throw new Exception($"Invalid value of reserved field ({recipientAddressSize})");
		var recipientAddress = Address.Deserialize(br);
		var mosaicIdSize = br.ReadUInt32();
		// marking sizeof field
		var mosaicId = MosaicId.Deserialize(br);
		var fee = Amount.Deserialize(br);

		var instance = new MosaicLevy()
		{
			TransferFeeType = transferFeeType,
			RecipientAddress = recipientAddress,
			MosaicId = mosaicId,
			Fee = fee
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(TransferFeeType.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RecipientAddressSize)); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)MosaicId.Size));  // bound: mosaic_id_size
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Fee.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"transferFeeType: {TransferFeeType}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"fee: {Fee}, ";
		result += ")";
		return result;
	}
}

public class MosaicProperty : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Name", "bytes_array"},
		{"Value", "bytes_array"}
	};

	public MosaicProperty() {
		Name = Array.Empty<byte>();
		Value = Array.Empty<byte>();
	}

	public void Sort() {
	}

	public byte[] Name { get; set; }

	public byte[] Value { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += (uint)Name.Length;
			size += 4;
			size += (uint)Value.Length;
			return size;
		}
	}

	public static MosaicProperty Deserialize(BinaryReader br) {
		var nameSize = br.ReadUInt32();
		var name = br.ReadBytes((int)nameSize);
		var valueSize = br.ReadUInt32();
		var value = br.ReadBytes((int)valueSize);

		var instance = new MosaicProperty()
		{
			Name = name,
			Value = value
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)(uint)Name.Length));  // bound: name_size
		bw.Write(Name); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Value.Length));  // bound: value_size
		bw.Write(Value); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		result += $"value: hex({Converter.BytesToHex(Value)}), ";
		result += ")";
		return result;
	}
}

public class SizePrefixedMosaicProperty : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Property", "struct:MosaicProperty"}
	};

	public SizePrefixedMosaicProperty() {
		Property = new MosaicProperty();
	}

	public void Sort() {
		Property.Sort();
	}

	public MosaicProperty Property { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += Property.Size;
			return size;
		}
	}

	public static SizePrefixedMosaicProperty Deserialize(BinaryReader br) {
		var propertySize = br.ReadUInt32();
		// marking sizeof field
		var property = MosaicProperty.Deserialize(br);

		var instance = new SizePrefixedMosaicProperty()
		{
			Property = property
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)Property.Size));  // bound: property_size
		bw.Write(Property.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"property: {Property}, ";
		result += ")";
		return result;
	}
}

public class MosaicDefinition : IStruct {
	private readonly int OwnerPublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"OwnerPublicKey", "pod:PublicKey"},
		{"Id", "struct:MosaicId"},
		{"Description", "bytes_array"},
		{"Properties", "array[SizePrefixedMosaicProperty]"},
		{"Levy", "struct:MosaicLevy"}
	};

	public MosaicDefinition() {
		OwnerPublicKey = new PublicKey();
		Id = new MosaicId();
		Description = Array.Empty<byte>();
		Properties = Array.Empty<SizePrefixedMosaicProperty>();
		LevySize = 0;
		Levy = new MosaicLevy();
		OwnerPublicKeySize = 32; // reserved field
	}

	public void Sort() {
		Id.Sort();
		if (0 != LevySize)
			Levy.Sort();
	}

	public PublicKey OwnerPublicKey { get; set; }

	public MosaicId Id { get; set; }

	public byte[] Description { get; set; }

	public SizePrefixedMosaicProperty[] Properties { get; set; }

	public uint LevySize { get; set; }

	public MosaicLevy Levy { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += OwnerPublicKey.Size;
			size += 4;
			size += Id.Size;
			size += 4;
			size += (uint)Description.Length;
			size += 4;
			size += ArrayHelpers.Size(Properties);
			size += 4;
			if (0 != LevySize)
				size += Levy.Size;

			return size;
		}
	}

	public static MosaicDefinition Deserialize(BinaryReader br) {
		var ownerPublicKeySize = br.ReadUInt32();
		if (32 != ownerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({ownerPublicKeySize})");
		var ownerPublicKey = PublicKey.Deserialize(br);
		var idSize = br.ReadUInt32();
		// marking sizeof field
		var id = MosaicId.Deserialize(br);
		var descriptionSize = br.ReadUInt32();
		var description = br.ReadBytes((int)descriptionSize);
		var propertiesCount = br.ReadUInt32();
		var properties = ArrayHelpers.ReadArrayCount(br, SizePrefixedMosaicProperty.Deserialize, (byte)propertiesCount);
		var levySize = br.ReadUInt32();
		var levy = new MosaicLevy();
		if (0 != levySize) {
			{
				levy = MosaicLevy.Deserialize(br);
			}
		}

		var instance = new MosaicDefinition()
		{
			OwnerPublicKey = ownerPublicKey,
			Id = id,
			Description = description,
			Properties = properties,
			LevySize = levySize,
			Levy = levy
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)(uint)OwnerPublicKeySize)); 
		bw.Write(OwnerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)Id.Size));  // bound: id_size
		bw.Write(Id.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Description.Length));  // bound: description_size
		bw.Write(Description); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Properties.Length));  // bound: properties_count
		ArrayHelpers.WriteArray(bw, Properties);
		bw.Write(BitConverter.GetBytes((uint)(uint)LevySize)); 
		if (0 != LevySize)
			bw.Write(Levy.Serialize()); 

		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"ownerPublicKey: {OwnerPublicKey}, ";
		result += $"id: {Id}, ";
		result += $"description: hex({Converter.BytesToHex(Description)}), ";
		result += $"properties: [{string.Join(",", Properties.Select(e => e.ToString()))}], ";
		result += $"levySize: {Converter.ToString(LevySize)}, ";
		if (0 != LevySize)
			result += $"levy: {Levy}, ";

		result += ")";
		return result;
	}
}

public class MosaicDefinitionTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_DEFINITION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int RentalFeeSinkSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicDefinition", "struct:MosaicDefinition"},
		{"RentalFeeSink", "pod:Address"},
		{"RentalFee", "pod:Amount"}
	};

	public MosaicDefinitionTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicDefinition = new MosaicDefinition();
		RentalFeeSink = new Address();
		RentalFee = new Amount();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		RentalFeeSinkSize = 40; // reserved field
	}

	public void Sort() {
		MosaicDefinition.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public MosaicDefinition MosaicDefinition { get; set; }

	public Address RentalFeeSink { get; set; }

	public Amount RentalFee { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += MosaicDefinition.Size;
			size += 4;
			size += RentalFeeSink.Size;
			size += RentalFee.Size;
			return size;
		}
	}

	public static MosaicDefinitionTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicDefinitionSize = br.ReadUInt32();
		// marking sizeof field
		var mosaicDefinition = MosaicDefinition.Deserialize(br);
		var rentalFeeSinkSize = br.ReadUInt32();
		if (40 != rentalFeeSinkSize)
			throw new Exception($"Invalid value of reserved field ({rentalFeeSinkSize})");
		var rentalFeeSink = Address.Deserialize(br);
		var rentalFee = Amount.Deserialize(br);

		var instance = new MosaicDefinitionTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			MosaicDefinition = mosaicDefinition,
			RentalFeeSink = rentalFeeSink,
			RentalFee = rentalFee
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)MosaicDefinition.Size));  // bound: mosaic_definition_size
		bw.Write(MosaicDefinition.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RentalFeeSinkSize)); 
		bw.Write(RentalFeeSink.Serialize()); 
		bw.Write(RentalFee.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicDefinition: {MosaicDefinition}, ";
		result += $"rentalFeeSink: {RentalFeeSink}, ";
		result += $"rentalFee: {RentalFee}, ";
		result += ")";
		return result;
	}
}

public class NonVerifiableMosaicDefinitionTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_DEFINITION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int RentalFeeSinkSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicDefinition", "struct:MosaicDefinition"},
		{"RentalFeeSink", "pod:Address"},
		{"RentalFee", "pod:Amount"}
	};

	public NonVerifiableMosaicDefinitionTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicDefinition = new MosaicDefinition();
		RentalFeeSink = new Address();
		RentalFee = new Amount();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		RentalFeeSinkSize = 40; // reserved field
	}

	public void Sort() {
		MosaicDefinition.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public MosaicDefinition MosaicDefinition { get; set; }

	public Address RentalFeeSink { get; set; }

	public Amount RentalFee { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += MosaicDefinition.Size;
			size += 4;
			size += RentalFeeSink.Size;
			size += RentalFee.Size;
			return size;
		}
	}

	public static NonVerifiableMosaicDefinitionTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicDefinitionSize = br.ReadUInt32();
		// marking sizeof field
		var mosaicDefinition = MosaicDefinition.Deserialize(br);
		var rentalFeeSinkSize = br.ReadUInt32();
		if (40 != rentalFeeSinkSize)
			throw new Exception($"Invalid value of reserved field ({rentalFeeSinkSize})");
		var rentalFeeSink = Address.Deserialize(br);
		var rentalFee = Amount.Deserialize(br);

		var instance = new NonVerifiableMosaicDefinitionTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			MosaicDefinition = mosaicDefinition,
			RentalFeeSink = rentalFeeSink,
			RentalFee = rentalFee
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)MosaicDefinition.Size));  // bound: mosaic_definition_size
		bw.Write(MosaicDefinition.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RentalFeeSinkSize)); 
		bw.Write(RentalFeeSink.Serialize()); 
		bw.Write(RentalFee.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicDefinition: {MosaicDefinition}, ";
		result += $"rentalFeeSink: {RentalFeeSink}, ";
		result += $"rentalFee: {RentalFee}, ";
		result += ")";
		return result;
	}
}

public class MosaicSupplyChangeAction : IEnum<uint> {
	public static readonly MosaicSupplyChangeAction INCREASE = new MosaicSupplyChangeAction(1);

	public static readonly MosaicSupplyChangeAction DECREASE = new MosaicSupplyChangeAction(2);

	public uint Value { get; }

	public MosaicSupplyChangeAction(uint value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			1, 2
		};
		var keys = new []{
			"INCREASE", "DECREASE"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static MosaicSupplyChangeAction FromValue(uint value) {
		return value switch
		{
			1 => INCREASE,
			2 => DECREASE,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 4;
		}
	}

	public static MosaicSupplyChangeAction Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"MosaicSupplyChangeAction.{ValueToKey(Value)}";
	}
}

public class MosaicSupplyChangeTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_CHANGE;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicId", "struct:MosaicId"},
		{"Action", "enum:MosaicSupplyChangeAction"},
		{"Delta", "pod:Amount"}
	};

	public MosaicSupplyChangeTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicId = new MosaicId();
		Action = MosaicSupplyChangeAction.INCREASE;
		Delta = new Amount();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
	}

	public void Sort() {
		MosaicId.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public MosaicId MosaicId { get; set; }

	public MosaicSupplyChangeAction Action { get; set; }

	public Amount Delta { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += MosaicId.Size;
			size += Action.Size;
			size += Delta.Size;
			return size;
		}
	}

	public static MosaicSupplyChangeTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicIdSize = br.ReadUInt32();
		// marking sizeof field
		var mosaicId = MosaicId.Deserialize(br);
		var action = MosaicSupplyChangeAction.Deserialize(br);
		var delta = Amount.Deserialize(br);

		var instance = new MosaicSupplyChangeTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			MosaicId = mosaicId,
			Action = action,
			Delta = delta
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)MosaicId.Size));  // bound: mosaic_id_size
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Action.Serialize()); 
		bw.Write(Delta.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"action: {Action}, ";
		result += $"delta: {Delta}, ";
		result += ")";
		return result;
	}
}

public class NonVerifiableMosaicSupplyChangeTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MOSAIC_SUPPLY_CHANGE;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MosaicId", "struct:MosaicId"},
		{"Action", "enum:MosaicSupplyChangeAction"},
		{"Delta", "pod:Amount"}
	};

	public NonVerifiableMosaicSupplyChangeTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		MosaicId = new MosaicId();
		Action = MosaicSupplyChangeAction.INCREASE;
		Delta = new Amount();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
	}

	public void Sort() {
		MosaicId.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public MosaicId MosaicId { get; set; }

	public MosaicSupplyChangeAction Action { get; set; }

	public Amount Delta { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += MosaicId.Size;
			size += Action.Size;
			size += Delta.Size;
			return size;
		}
	}

	public static NonVerifiableMosaicSupplyChangeTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var mosaicIdSize = br.ReadUInt32();
		// marking sizeof field
		var mosaicId = MosaicId.Deserialize(br);
		var action = MosaicSupplyChangeAction.Deserialize(br);
		var delta = Amount.Deserialize(br);

		var instance = new NonVerifiableMosaicSupplyChangeTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			MosaicId = mosaicId,
			Action = action,
			Delta = delta
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)MosaicId.Size));  // bound: mosaic_id_size
		bw.Write(MosaicId.Serialize()); 
		bw.Write(Action.Serialize()); 
		bw.Write(Delta.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"mosaicId: {MosaicId}, ";
		result += $"action: {Action}, ";
		result += $"delta: {Delta}, ";
		result += ")";
		return result;
	}
}

public class MultisigAccountModificationType : IEnum<uint> {
	public static readonly MultisigAccountModificationType ADD_COSIGNATORY = new MultisigAccountModificationType(1);

	public static readonly MultisigAccountModificationType DELETE_COSIGNATORY = new MultisigAccountModificationType(2);

	public uint Value { get; }

	public MultisigAccountModificationType(uint value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			1, 2
		};
		var keys = new []{
			"ADD_COSIGNATORY", "DELETE_COSIGNATORY"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static MultisigAccountModificationType FromValue(uint value) {
		return value switch
		{
			1 => ADD_COSIGNATORY,
			2 => DELETE_COSIGNATORY,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 4;
		}
	}

	public static MultisigAccountModificationType Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"MultisigAccountModificationType.{ValueToKey(Value)}";
	}
}

public class MultisigAccountModification : IStruct {
	private readonly int CosignatoryPublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"ModificationType", "enum:MultisigAccountModificationType"},
		{"CosignatoryPublicKey", "pod:PublicKey"}
	};

	public MultisigAccountModification() {
		ModificationType = MultisigAccountModificationType.ADD_COSIGNATORY;
		CosignatoryPublicKey = new PublicKey();
		CosignatoryPublicKeySize = 32; // reserved field
	}

	public void Sort() {
	}

	public MultisigAccountModificationType ModificationType { get; set; }

	public PublicKey CosignatoryPublicKey { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += ModificationType.Size;
			size += 4;
			size += CosignatoryPublicKey.Size;
			return size;
		}
	}

	public static MultisigAccountModification Deserialize(BinaryReader br) {
		var modificationType = MultisigAccountModificationType.Deserialize(br);
		var cosignatoryPublicKeySize = br.ReadUInt32();
		if (32 != cosignatoryPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({cosignatoryPublicKeySize})");
		var cosignatoryPublicKey = PublicKey.Deserialize(br);

		var instance = new MultisigAccountModification()
		{
			ModificationType = modificationType,
			CosignatoryPublicKey = cosignatoryPublicKey
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(ModificationType.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)CosignatoryPublicKeySize)); 
		bw.Write(CosignatoryPublicKey.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"modificationType: {ModificationType}, ";
		result += $"cosignatoryPublicKey: {CosignatoryPublicKey}, ";
		result += ")";
		return result;
	}
}

public class SizePrefixedMultisigAccountModification : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Modification", "struct:MultisigAccountModification"}
	};

	public SizePrefixedMultisigAccountModification() {
		Modification = new MultisigAccountModification();
	}

	public void Sort() {
		Modification.Sort();
	}

	public MultisigAccountModification Modification { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += Modification.Size;
			return size;
		}
	}

	public static SizePrefixedMultisigAccountModification Deserialize(BinaryReader br) {
		var modificationSize = br.ReadUInt32();
		// marking sizeof field
		var modification = MultisigAccountModification.Deserialize(br);

		var instance = new SizePrefixedMultisigAccountModification()
		{
			Modification = modification
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)Modification.Size));  // bound: modification_size
		bw.Write(Modification.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"modification: {Modification}, ";
		result += ")";
		return result;
	}
}

public class MultisigAccountModificationTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Modifications", "array[SizePrefixedMultisigAccountModification]"}
	};

	public MultisigAccountModificationTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		Modifications = Array.Empty<SizePrefixedMultisigAccountModification>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
	}

	public void Sort() {
		Array.Sort(Modifications, (lhs, rhs) => {
		return ((ulong) ((lhs.Modification.GetType().GetMethod("Comparer") != null
		? lhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: lhs.Modification.GetType().GetField("Value").GetValue(lhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))
		.CompareTo((ulong) ((rhs.Modification.GetType().GetMethod("Comparer") != null
		? rhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: rhs.Modification.GetType().GetField("Value").GetValue(rhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));
		});
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public SizePrefixedMultisigAccountModification[] Modifications { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += ArrayHelpers.Size(Modifications);
			return size;
		}
	}

	public static MultisigAccountModificationTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var modificationsCount = br.ReadUInt32();
		var modifications = ArrayHelpers.ReadArrayCount(br, SizePrefixedMultisigAccountModification.Deserialize, (byte)modificationsCount);

		var instance = new MultisigAccountModificationTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			Modifications = modifications
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Modifications.Length));  // bound: modifications_count
		ArrayHelpers.WriteArray(bw, Modifications);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"modifications: [{string.Join(",", Modifications.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class NonVerifiableMultisigAccountModificationTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Modifications", "array[SizePrefixedMultisigAccountModification]"}
	};

	public NonVerifiableMultisigAccountModificationTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		Modifications = Array.Empty<SizePrefixedMultisigAccountModification>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
	}

	public void Sort() {
		Array.Sort(Modifications, (lhs, rhs) => {
		return ((ulong) ((lhs.Modification.GetType().GetMethod("Comparer") != null
		? lhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: lhs.Modification.GetType().GetField("Value").GetValue(lhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))
		.CompareTo((ulong) ((rhs.Modification.GetType().GetMethod("Comparer") != null
		? rhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: rhs.Modification.GetType().GetField("Value").GetValue(rhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));
		});
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public SizePrefixedMultisigAccountModification[] Modifications { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += ArrayHelpers.Size(Modifications);
			return size;
		}
	}

	public static NonVerifiableMultisigAccountModificationTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var modificationsCount = br.ReadUInt32();
		var modifications = ArrayHelpers.ReadArrayCount(br, SizePrefixedMultisigAccountModification.Deserialize, (byte)modificationsCount);

		var instance = new NonVerifiableMultisigAccountModificationTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			Modifications = modifications
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Modifications.Length));  // bound: modifications_count
		ArrayHelpers.WriteArray(bw, Modifications);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"modifications: [{string.Join(",", Modifications.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class MultisigAccountModificationTransactionV2 : ITransaction {
	public const byte TRANSACTION_VERSION = 2;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int MinApprovalDeltaSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Modifications", "array[SizePrefixedMultisigAccountModification]"}
	};

	public MultisigAccountModificationTransactionV2() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		Modifications = Array.Empty<SizePrefixedMultisigAccountModification>();
		MinApprovalDelta = 0;
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		MinApprovalDeltaSize = 4; // reserved field
	}

	public void Sort() {
		Array.Sort(Modifications, (lhs, rhs) => {
		return ((ulong) ((lhs.Modification.GetType().GetMethod("Comparer") != null
		? lhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: lhs.Modification.GetType().GetField("Value").GetValue(lhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))
		.CompareTo((ulong) ((rhs.Modification.GetType().GetMethod("Comparer") != null
		? rhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: rhs.Modification.GetType().GetField("Value").GetValue(rhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));
		});
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public SizePrefixedMultisigAccountModification[] Modifications { get; set; }

	public uint MinApprovalDelta { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += ArrayHelpers.Size(Modifications);
			size += 4;
			size += 4;
			return size;
		}
	}

	public static MultisigAccountModificationTransactionV2 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var modificationsCount = br.ReadUInt32();
		var modifications = ArrayHelpers.ReadArrayCount(br, SizePrefixedMultisigAccountModification.Deserialize, (byte)modificationsCount);
		var minApprovalDeltaSize = br.ReadUInt32();
		if (4 != minApprovalDeltaSize)
			throw new Exception($"Invalid value of reserved field ({minApprovalDeltaSize})");
		var minApprovalDelta = br.ReadUInt32();

		var instance = new MultisigAccountModificationTransactionV2()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			Modifications = modifications,
			MinApprovalDelta = minApprovalDelta
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Modifications.Length));  // bound: modifications_count
		ArrayHelpers.WriteArray(bw, Modifications);
		bw.Write(BitConverter.GetBytes((uint)(uint)MinApprovalDeltaSize)); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MinApprovalDelta)); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"modifications: [{string.Join(",", Modifications.Select(e => e.ToString()))}], ";
		result += $"minApprovalDelta: {Converter.ToString(MinApprovalDelta)}, ";
		result += ")";
		return result;
	}
}

public class NonVerifiableMultisigAccountModificationTransactionV2 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 2;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_ACCOUNT_MODIFICATION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int MinApprovalDeltaSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"Modifications", "array[SizePrefixedMultisigAccountModification]"}
	};

	public NonVerifiableMultisigAccountModificationTransactionV2() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		Modifications = Array.Empty<SizePrefixedMultisigAccountModification>();
		MinApprovalDelta = 0;
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		MinApprovalDeltaSize = 4; // reserved field
	}

	public void Sort() {
		Array.Sort(Modifications, (lhs, rhs) => {
		return ((ulong) ((lhs.Modification.GetType().GetMethod("Comparer") != null
		? lhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: lhs.Modification.GetType().GetField("Value").GetValue(lhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()))
		.CompareTo((ulong) ((rhs.Modification.GetType().GetMethod("Comparer") != null
		? rhs.Modification.GetType().GetMethod("Comparer")?.Invoke(null, new object[] {})
		: rhs.Modification.GetType().GetField("Value").GetValue(rhs.Modification) ?? throw new InvalidOperationException()) ?? throw new InvalidOperationException()));
		});
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public SizePrefixedMultisigAccountModification[] Modifications { get; set; }

	public uint MinApprovalDelta { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += ArrayHelpers.Size(Modifications);
			size += 4;
			size += 4;
			return size;
		}
	}

	public static NonVerifiableMultisigAccountModificationTransactionV2 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var modificationsCount = br.ReadUInt32();
		var modifications = ArrayHelpers.ReadArrayCount(br, SizePrefixedMultisigAccountModification.Deserialize, (byte)modificationsCount);
		var minApprovalDeltaSize = br.ReadUInt32();
		if (4 != minApprovalDeltaSize)
			throw new Exception($"Invalid value of reserved field ({minApprovalDeltaSize})");
		var minApprovalDelta = br.ReadUInt32();

		var instance = new NonVerifiableMultisigAccountModificationTransactionV2()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			Modifications = modifications,
			MinApprovalDelta = minApprovalDelta
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Modifications.Length));  // bound: modifications_count
		ArrayHelpers.WriteArray(bw, Modifications);
		bw.Write(BitConverter.GetBytes((uint)(uint)MinApprovalDeltaSize)); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MinApprovalDelta)); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"modifications: [{string.Join(",", Modifications.Select(e => e.ToString()))}], ";
		result += $"minApprovalDelta: {Converter.ToString(MinApprovalDelta)}, ";
		result += ")";
		return result;
	}
}

public class CosignatureV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_COSIGNATURE;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int MultisigTransactionHashOuterSize;
	private readonly int MultisigTransactionHashSize;
	private readonly int MultisigAccountAddressSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"MultisigTransactionHash", "pod:Hash256"},
		{"MultisigAccountAddress", "pod:Address"}
	};

	public CosignatureV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		MultisigTransactionHash = new Hash256();
		MultisigAccountAddress = new Address();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		MultisigTransactionHashOuterSize = 36; // reserved field
		MultisigTransactionHashSize = 32; // reserved field
		MultisigAccountAddressSize = 40; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Hash256 MultisigTransactionHash { get; set; }

	public Address MultisigAccountAddress { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += 4;
			size += MultisigTransactionHash.Size;
			size += 4;
			size += MultisigAccountAddress.Size;
			return size;
		}
	}

	public static CosignatureV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var multisigTransactionHashOuterSize = br.ReadUInt32();
		if (36 != multisigTransactionHashOuterSize)
			throw new Exception($"Invalid value of reserved field ({multisigTransactionHashOuterSize})");
		var multisigTransactionHashSize = br.ReadUInt32();
		if (32 != multisigTransactionHashSize)
			throw new Exception($"Invalid value of reserved field ({multisigTransactionHashSize})");
		var multisigTransactionHash = Hash256.Deserialize(br);
		var multisigAccountAddressSize = br.ReadUInt32();
		if (40 != multisigAccountAddressSize)
			throw new Exception($"Invalid value of reserved field ({multisigAccountAddressSize})");
		var multisigAccountAddress = Address.Deserialize(br);

		var instance = new CosignatureV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			MultisigTransactionHash = multisigTransactionHash,
			MultisigAccountAddress = multisigAccountAddress
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MultisigTransactionHashOuterSize)); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MultisigTransactionHashSize)); 
		bw.Write(MultisigTransactionHash.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MultisigAccountAddressSize)); 
		bw.Write(MultisigAccountAddress.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"multisigTransactionHash: {MultisigTransactionHash}, ";
		result += $"multisigAccountAddress: {MultisigAccountAddress}, ";
		result += ")";
		return result;
	}
}

public class SizePrefixedCosignatureV1 : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Cosignature", "struct:CosignatureV1"}
	};

	public SizePrefixedCosignatureV1() {
		Cosignature = new CosignatureV1();
	}

	public void Sort() {
		Cosignature.Sort();
	}

	public CosignatureV1 Cosignature { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += 4;
			size += Cosignature.Size;
			return size;
		}
	}

	public static SizePrefixedCosignatureV1 Deserialize(BinaryReader br) {
		var cosignatureSize = br.ReadUInt32();
		// marking sizeof field
		var cosignature = CosignatureV1.Deserialize(br);

		var instance = new SizePrefixedCosignatureV1()
		{
			Cosignature = cosignature
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(BitConverter.GetBytes((uint)Cosignature.Size));  // bound: cosignature_size
		bw.Write(Cosignature.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"cosignature: {Cosignature}, ";
		result += ")";
		return result;
	}
}

public class MultisigTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_TRANSACTION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"InnerTransaction", "struct:NonVerifiableTransaction"},
		{"Cosignatures", "array[SizePrefixedCosignatureV1]"}
	};

	public MultisigTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		InnerTransaction = new NonVerifiableTransaction();
		Cosignatures = Array.Empty<SizePrefixedCosignatureV1>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
	}

	public void Sort() {
		InnerTransaction.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public IBaseTransaction InnerTransaction { get; set; }

	public SizePrefixedCosignatureV1[] Cosignatures { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += InnerTransaction.Size;
			size += 4;
			size += ArrayHelpers.Size(Cosignatures);
			return size;
		}
	}

	public static MultisigTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var innerTransactionSize = br.ReadUInt32();
		// marking sizeof field
		var innerTransaction = (NonVerifiableTransaction)NonVerifiableTransactionFactory.Deserialize(br);
		var cosignaturesCount = br.ReadUInt32();
		var cosignatures = ArrayHelpers.ReadArrayCount(br, SizePrefixedCosignatureV1.Deserialize, (byte)cosignaturesCount);

		var instance = new MultisigTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			InnerTransaction = innerTransaction,
			Cosignatures = cosignatures
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)InnerTransaction.Size));  // bound: inner_transaction_size
		bw.Write(InnerTransaction.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Cosignatures.Length));  // bound: cosignatures_count
		ArrayHelpers.WriteArray(bw, Cosignatures);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"innerTransaction: {InnerTransaction}, ";
		result += $"cosignatures: [{string.Join(",", Cosignatures.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class NonVerifiableMultisigTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.MULTISIG_TRANSACTION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"InnerTransaction", "struct:NonVerifiableTransaction"}
	};

	public NonVerifiableMultisigTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		InnerTransaction = new NonVerifiableTransaction();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
	}

	public void Sort() {
		InnerTransaction.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public IBaseTransaction InnerTransaction { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += InnerTransaction.Size;
			return size;
		}
	}

	public static NonVerifiableMultisigTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var innerTransactionSize = br.ReadUInt32();
		// marking sizeof field
		var innerTransaction = (NonVerifiableTransaction)NonVerifiableTransactionFactory.Deserialize(br);

		var instance = new NonVerifiableMultisigTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			InnerTransaction = innerTransaction
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)InnerTransaction.Size));  // bound: inner_transaction_size
		bw.Write(InnerTransaction.Serialize()); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"innerTransaction: {InnerTransaction}, ";
		result += ")";
		return result;
	}
}

public class NamespaceRegistrationTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_REGISTRATION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int RentalFeeSinkSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RentalFeeSink", "pod:Address"},
		{"RentalFee", "pod:Amount"},
		{"Name", "bytes_array"},
		{"ParentName", "bytes_array"}
	};

	public NamespaceRegistrationTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		RentalFeeSink = new Address();
		RentalFee = new Amount();
		Name = Array.Empty<byte>();
		ParentName = Array.Empty<byte>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		RentalFeeSinkSize = 40; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Address RentalFeeSink { get; set; }

	public Amount RentalFee { get; set; }

	public byte[] Name { get; set; }

	public byte[] ParentName { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += RentalFeeSink.Size;
			size += RentalFee.Size;
			size += 4;
			size += (uint)Name.Length;
			size += 4;
			if (ParentName.Length > 0)
				size += (uint)ParentName.Length;

			return size;
		}
	}

	public static NamespaceRegistrationTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var rentalFeeSinkSize = br.ReadUInt32();
		if (40 != rentalFeeSinkSize)
			throw new Exception($"Invalid value of reserved field ({rentalFeeSinkSize})");
		var rentalFeeSink = Address.Deserialize(br);
		var rentalFee = Amount.Deserialize(br);
		var nameSize = br.ReadUInt32();
		var name = br.ReadBytes((int)nameSize);
		var parentNameSize = br.ReadUInt32();
		var parentName = new byte[]{};
		if (4294967295 != parentNameSize) {
			{
				parentName = br.ReadBytes((int)parentNameSize);
			}
		}

		var instance = new NamespaceRegistrationTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			RentalFeeSink = rentalFeeSink,
			RentalFee = rentalFee,
			Name = name,
			ParentName = parentName
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RentalFeeSinkSize)); 
		bw.Write(RentalFeeSink.Serialize()); 
		bw.Write(RentalFee.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Name.Length));  // bound: name_size
		bw.Write(Name); 
		bw.Write(BitConverter.GetBytes((uint)(ParentName.Length > 0 ? (uint)ParentName.Length : 4294967295)));  // bound: parent_name_size
		if (ParentName.Length > 0)
			bw.Write(ParentName); 

		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"rentalFeeSink: {RentalFeeSink}, ";
		result += $"rentalFee: {RentalFee}, ";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		if (ParentName.Length > 0)
			result += $"parentName: hex({Converter.BytesToHex(ParentName)}), ";

		result += ")";
		return result;
	}
}

public class NonVerifiableNamespaceRegistrationTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.NAMESPACE_REGISTRATION;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int RentalFeeSinkSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RentalFeeSink", "pod:Address"},
		{"RentalFee", "pod:Amount"},
		{"Name", "bytes_array"},
		{"ParentName", "bytes_array"}
	};

	public NonVerifiableNamespaceRegistrationTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		RentalFeeSink = new Address();
		RentalFee = new Amount();
		Name = Array.Empty<byte>();
		ParentName = Array.Empty<byte>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		RentalFeeSinkSize = 40; // reserved field
	}

	public void Sort() {
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Address RentalFeeSink { get; set; }

	public Amount RentalFee { get; set; }

	public byte[] Name { get; set; }

	public byte[] ParentName { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += RentalFeeSink.Size;
			size += RentalFee.Size;
			size += 4;
			size += (uint)Name.Length;
			size += 4;
			if (ParentName.Length > 0)
				size += (uint)ParentName.Length;

			return size;
		}
	}

	public static NonVerifiableNamespaceRegistrationTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var rentalFeeSinkSize = br.ReadUInt32();
		if (40 != rentalFeeSinkSize)
			throw new Exception($"Invalid value of reserved field ({rentalFeeSinkSize})");
		var rentalFeeSink = Address.Deserialize(br);
		var rentalFee = Amount.Deserialize(br);
		var nameSize = br.ReadUInt32();
		var name = br.ReadBytes((int)nameSize);
		var parentNameSize = br.ReadUInt32();
		var parentName = new byte[]{};
		if (4294967295 != parentNameSize) {
			{
				parentName = br.ReadBytes((int)parentNameSize);
			}
		}

		var instance = new NonVerifiableNamespaceRegistrationTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			RentalFeeSink = rentalFeeSink,
			RentalFee = rentalFee,
			Name = name,
			ParentName = parentName
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RentalFeeSinkSize)); 
		bw.Write(RentalFeeSink.Serialize()); 
		bw.Write(RentalFee.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)Name.Length));  // bound: name_size
		bw.Write(Name); 
		bw.Write(BitConverter.GetBytes((uint)(ParentName.Length > 0 ? (uint)ParentName.Length : 4294967295)));  // bound: parent_name_size
		if (ParentName.Length > 0)
			bw.Write(ParentName); 

		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"rentalFeeSink: {RentalFeeSink}, ";
		result += $"rentalFee: {RentalFee}, ";
		result += $"name: hex({Converter.BytesToHex(Name)}), ";
		if (ParentName.Length > 0)
			result += $"parentName: hex({Converter.BytesToHex(ParentName)}), ";

		result += ")";
		return result;
	}
}

public class MessageType : IEnum<uint> {
	public static readonly MessageType PLAIN = new MessageType(1);

	public static readonly MessageType ENCRYPTED = new MessageType(2);

	public uint Value { get; }

	public MessageType(uint value = 0) {
		Value = value;
	}

	internal static string ValueToKey(uint value) {
		var values = new uint[]{
			1, 2
		};
		var keys = new []{
			"PLAIN", "ENCRYPTED"
		};

		var index = Array.IndexOf(values, value);
		if (-1 == index)
			throw new Exception($"invalid enum value {value}");

		return keys[index];
	}

	internal static MessageType FromValue(uint value) {
		return value switch
		{
			1 => PLAIN,
			2 => ENCRYPTED,
			_ => throw new Exception($"invalid enum value {value}")
		};
	}

	public uint Size {
		get {
			return 4;
		}
	}

	public static MessageType Deserialize(BinaryReader br) {
		return FromValue(br.ReadUInt32());
	}

	public byte[] Serialize() {
		return BitConverter.GetBytes(Value);
	}

	public override string ToString() {
		return $"MessageType.{ValueToKey(Value)}";
	}
}

public class Message : IStruct {

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"MessageType", "enum:MessageType"},
		{"Message", "bytes_array"}
	};

	public Message() {
		MessageType = MessageType.PLAIN;
		MessageField = Array.Empty<byte>();
	}

	public void Sort() {
	}

	public MessageType MessageType { get; set; }

	public byte[] MessageField { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += MessageType.Size;
			size += 4;
			size += (uint)MessageField.Length;
			return size;
		}
	}

	public static Message Deserialize(BinaryReader br) {
		var messageType = MessageType.Deserialize(br);
		var messageSize = br.ReadUInt32();
		var message = br.ReadBytes((int)messageSize);

		var instance = new Message()
		{
			MessageType = messageType,
			MessageField = message
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(MessageType.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MessageField.Length));  // bound: message_size
		bw.Write(MessageField); 
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"messageType: {MessageType}, ";
		result += $"message: hex({Converter.BytesToHex(MessageField)}), ";
		result += ")";
		return result;
	}
}

public class TransferTransactionV1 : ITransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int RecipientAddressSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:Address"},
		{"Amount", "pod:Amount"},
		{"Message", "struct:Message"}
	};

	public TransferTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new Address();
		Amount = new Amount();
		MessageEnvelopeSize = 0;
		Message = new Message();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		RecipientAddressSize = 40; // reserved field
	}

	public void Sort() {
		if (0 != MessageEnvelopeSize)
			Message.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Address RecipientAddress { get; set; }

	public Amount Amount { get; set; }

	public uint MessageEnvelopeSize { get; set; }

	public Message Message { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += RecipientAddress.Size;
			size += Amount.Size;
			size += 4;
			if (0 != MessageEnvelopeSize)
				size += Message.Size;

			return size;
		}
	}

	public static TransferTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddressSize = br.ReadUInt32();
		if (40 != recipientAddressSize)
			throw new Exception($"Invalid value of reserved field ({recipientAddressSize})");
		var recipientAddress = Address.Deserialize(br);
		var amount = Amount.Deserialize(br);
		var messageEnvelopeSize = br.ReadUInt32();
		var message = new Message();
		if (0 != messageEnvelopeSize) {
			{
				message = Message.Deserialize(br);
			}
		}

		var instance = new TransferTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Amount = amount,
			MessageEnvelopeSize = messageEnvelopeSize,
			Message = message
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RecipientAddressSize)); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Amount.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MessageEnvelopeSize)); 
		if (0 != MessageEnvelopeSize)
			bw.Write(Message.Serialize()); 

		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"amount: {Amount}, ";
		result += $"messageEnvelopeSize: {Converter.ToString(MessageEnvelopeSize)}, ";
		if (0 != MessageEnvelopeSize)
			result += $"message: {Message}, ";

		result += ")";
		return result;
	}
}

public class NonVerifiableTransferTransactionV1 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 1;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int RecipientAddressSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:Address"},
		{"Amount", "pod:Amount"},
		{"Message", "struct:Message"}
	};

	public NonVerifiableTransferTransactionV1() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new Address();
		Amount = new Amount();
		MessageEnvelopeSize = 0;
		Message = new Message();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		RecipientAddressSize = 40; // reserved field
	}

	public void Sort() {
		if (0 != MessageEnvelopeSize)
			Message.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Address RecipientAddress { get; set; }

	public Amount Amount { get; set; }

	public uint MessageEnvelopeSize { get; set; }

	public Message Message { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += RecipientAddress.Size;
			size += Amount.Size;
			size += 4;
			if (0 != MessageEnvelopeSize)
				size += Message.Size;

			return size;
		}
	}

	public static NonVerifiableTransferTransactionV1 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddressSize = br.ReadUInt32();
		if (40 != recipientAddressSize)
			throw new Exception($"Invalid value of reserved field ({recipientAddressSize})");
		var recipientAddress = Address.Deserialize(br);
		var amount = Amount.Deserialize(br);
		var messageEnvelopeSize = br.ReadUInt32();
		var message = new Message();
		if (0 != messageEnvelopeSize) {
			{
				message = Message.Deserialize(br);
			}
		}

		var instance = new NonVerifiableTransferTransactionV1()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Amount = amount,
			MessageEnvelopeSize = messageEnvelopeSize,
			Message = message
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RecipientAddressSize)); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Amount.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MessageEnvelopeSize)); 
		if (0 != MessageEnvelopeSize)
			bw.Write(Message.Serialize()); 

		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"amount: {Amount}, ";
		result += $"messageEnvelopeSize: {Converter.ToString(MessageEnvelopeSize)}, ";
		if (0 != MessageEnvelopeSize)
			result += $"message: {Message}, ";

		result += ")";
		return result;
	}
}

public class TransferTransactionV2 : ITransaction {
	public const byte TRANSACTION_VERSION = 2;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int SignatureSize;
	private readonly int RecipientAddressSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Signature", "pod:Signature"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:Address"},
		{"Amount", "pod:Amount"},
		{"Message", "struct:Message"},
		{"Mosaics", "array[SizePrefixedMosaic]"}
	};

	public TransferTransactionV2() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Signature = new Signature();
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new Address();
		Amount = new Amount();
		MessageEnvelopeSize = 0;
		Message = new Message();
		Mosaics = Array.Empty<SizePrefixedMosaic>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		SignatureSize = 64; // reserved field
		RecipientAddressSize = 40; // reserved field
	}

	public void Sort() {
		if (0 != MessageEnvelopeSize)
			Message.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Signature Signature { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Address RecipientAddress { get; set; }

	public Amount Amount { get; set; }

	public uint MessageEnvelopeSize { get; set; }

	public Message Message { get; set; }

	public SizePrefixedMosaic[] Mosaics { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += 4;
			size += Signature.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += RecipientAddress.Size;
			size += Amount.Size;
			size += 4;
			if (0 != MessageEnvelopeSize)
				size += Message.Size;

			size += 4;
			size += ArrayHelpers.Size(Mosaics);
			return size;
		}
	}

	public static TransferTransactionV2 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var signatureSize = br.ReadUInt32();
		if (64 != signatureSize)
			throw new Exception($"Invalid value of reserved field ({signatureSize})");
		var signature = Signature.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddressSize = br.ReadUInt32();
		if (40 != recipientAddressSize)
			throw new Exception($"Invalid value of reserved field ({recipientAddressSize})");
		var recipientAddress = Address.Deserialize(br);
		var amount = Amount.Deserialize(br);
		var messageEnvelopeSize = br.ReadUInt32();
		var message = new Message();
		if (0 != messageEnvelopeSize) {
			{
				message = Message.Deserialize(br);
			}
		}
		var mosaicsCount = br.ReadUInt32();
		var mosaics = ArrayHelpers.ReadArrayCount(br, SizePrefixedMosaic.Deserialize, (byte)mosaicsCount);

		var instance = new TransferTransactionV2()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Signature = signature,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Amount = amount,
			MessageEnvelopeSize = messageEnvelopeSize,
			Message = message,
			Mosaics = mosaics
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignatureSize)); 
		bw.Write(Signature.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RecipientAddressSize)); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Amount.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MessageEnvelopeSize)); 
		if (0 != MessageEnvelopeSize)
			bw.Write(Message.Serialize()); 

		bw.Write(BitConverter.GetBytes((uint)(uint)Mosaics.Length));  // bound: mosaics_count
		ArrayHelpers.WriteArray(bw, Mosaics);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"signature: {Signature}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"amount: {Amount}, ";
		result += $"messageEnvelopeSize: {Converter.ToString(MessageEnvelopeSize)}, ";
		if (0 != MessageEnvelopeSize)
			result += $"message: {Message}, ";

		result += $"mosaics: [{string.Join(",", Mosaics.Select(e => e.ToString()))}], ";
		result += ")";
		return result;
	}
}

public class NonVerifiableTransferTransactionV2 : IBaseTransaction {
	public const byte TRANSACTION_VERSION = 2;

	public static readonly TransactionType TRANSACTION_TYPE = TransactionType.TRANSFER;

	private readonly int EntityBodyReserved_1;
	private readonly int SignerPublicKeySize;
	private readonly int RecipientAddressSize;

	public Dictionary<string, string> TypeHints { get; } = new Dictionary<string, string>(){
		{"Type", "enum:TransactionType"},
		{"Network", "enum:NetworkType"},
		{"Timestamp", "pod:Timestamp"},
		{"SignerPublicKey", "pod:PublicKey"},
		{"Fee", "pod:Amount"},
		{"Deadline", "pod:Timestamp"},
		{"RecipientAddress", "pod:Address"},
		{"Amount", "pod:Amount"},
		{"Message", "struct:Message"},
		{"Mosaics", "array[SizePrefixedMosaic]"}
	};

	public NonVerifiableTransferTransactionV2() {
		Type = TRANSACTION_TYPE;
		Version = TRANSACTION_VERSION;
		Network = NetworkType.MAINNET;
		Timestamp = new Timestamp();
		SignerPublicKey = new PublicKey();
		Fee = new Amount();
		Deadline = new Timestamp();
		RecipientAddress = new Address();
		Amount = new Amount();
		MessageEnvelopeSize = 0;
		Message = new Message();
		Mosaics = Array.Empty<SizePrefixedMosaic>();
		EntityBodyReserved_1 = 0; // reserved field
		SignerPublicKeySize = 32; // reserved field
		RecipientAddressSize = 40; // reserved field
	}

	public void Sort() {
		if (0 != MessageEnvelopeSize)
			Message.Sort();
	}

	public TransactionType Type { get; set; }

	public byte Version { get; set; }

	public NetworkType Network { get; set; }

	public Timestamp Timestamp { get; set; }

	public PublicKey SignerPublicKey { get; set; }

	public Amount Fee { get; set; }

	public Timestamp Deadline { get; set; }

	public Address RecipientAddress { get; set; }

	public Amount Amount { get; set; }

	public uint MessageEnvelopeSize { get; set; }

	public Message Message { get; set; }

	public SizePrefixedMosaic[] Mosaics { get; set; }

	public uint Size {
		get {
			uint size = 0;
			size += Type.Size;
			size += 1;
			size += 2;
			size += Network.Size;
			size += Timestamp.Size;
			size += 4;
			size += SignerPublicKey.Size;
			size += Fee.Size;
			size += Deadline.Size;
			size += 4;
			size += RecipientAddress.Size;
			size += Amount.Size;
			size += 4;
			if (0 != MessageEnvelopeSize)
				size += Message.Size;

			size += 4;
			size += ArrayHelpers.Size(Mosaics);
			return size;
		}
	}

	public static NonVerifiableTransferTransactionV2 Deserialize(BinaryReader br) {
		var type = TransactionType.Deserialize(br);
		var version = br.ReadByte();
		var entityBodyReserved_1 = br.ReadUInt16();
		if (0 != entityBodyReserved_1)
			throw new Exception($"Invalid value of reserved field ({entityBodyReserved_1})");
		var network = NetworkType.Deserialize(br);
		var timestamp = Timestamp.Deserialize(br);
		var signerPublicKeySize = br.ReadUInt32();
		if (32 != signerPublicKeySize)
			throw new Exception($"Invalid value of reserved field ({signerPublicKeySize})");
		var signerPublicKey = PublicKey.Deserialize(br);
		var fee = Amount.Deserialize(br);
		var deadline = Timestamp.Deserialize(br);
		var recipientAddressSize = br.ReadUInt32();
		if (40 != recipientAddressSize)
			throw new Exception($"Invalid value of reserved field ({recipientAddressSize})");
		var recipientAddress = Address.Deserialize(br);
		var amount = Amount.Deserialize(br);
		var messageEnvelopeSize = br.ReadUInt32();
		var message = new Message();
		if (0 != messageEnvelopeSize) {
			{
				message = Message.Deserialize(br);
			}
		}
		var mosaicsCount = br.ReadUInt32();
		var mosaics = ArrayHelpers.ReadArrayCount(br, SizePrefixedMosaic.Deserialize, (byte)mosaicsCount);

		var instance = new NonVerifiableTransferTransactionV2()
		{
			Type = type,
			Version = version,
			Network = network,
			Timestamp = timestamp,
			SignerPublicKey = signerPublicKey,
			Fee = fee,
			Deadline = deadline,
			RecipientAddress = recipientAddress,
			Amount = amount,
			MessageEnvelopeSize = messageEnvelopeSize,
			Message = message,
			Mosaics = mosaics
		};
		return instance;
	}

	public byte[] Serialize() {
		using var ms = new MemoryStream();
		using var bw = new BinaryWriter(ms);
		bw.Write(Type.Serialize()); 
		bw.Write((byte)Version); 
		bw.Write(BitConverter.GetBytes((ushort)(ushort)EntityBodyReserved_1)); 
		bw.Write(Network.Serialize()); 
		bw.Write(Timestamp.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)SignerPublicKeySize)); 
		bw.Write(SignerPublicKey.Serialize()); 
		bw.Write(Fee.Serialize()); 
		bw.Write(Deadline.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)RecipientAddressSize)); 
		bw.Write(RecipientAddress.Serialize()); 
		bw.Write(Amount.Serialize()); 
		bw.Write(BitConverter.GetBytes((uint)(uint)MessageEnvelopeSize)); 
		if (0 != MessageEnvelopeSize)
			bw.Write(Message.Serialize()); 

		bw.Write(BitConverter.GetBytes((uint)(uint)Mosaics.Length));  // bound: mosaics_count
		ArrayHelpers.WriteArray(bw, Mosaics);
		return ms.ToArray();
	}

	public override string ToString() {
		var result = "(";
		result += $"type: {Type}, ";
		result += $"version: {Converter.ToString(Version)}, ";
		result += $"network: {Network}, ";
		result += $"timestamp: {Timestamp}, ";
		result += $"signerPublicKey: {SignerPublicKey}, ";
		result += $"fee: {Fee}, ";
		result += $"deadline: {Deadline}, ";
		result += $"recipientAddress: {RecipientAddress}, ";
		result += $"amount: {Amount}, ";
		result += $"messageEnvelopeSize: {Converter.ToString(MessageEnvelopeSize)}, ";
		if (0 != MessageEnvelopeSize)
			result += $"message: {Message}, ";

		result += $"mosaics: [{string.Join(",", Mosaics.Select(e => e.ToString()))}], ";
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
			{MosaicDefinitionTransactionV1.TRANSACTION_TYPE, MosaicDefinitionTransactionV1.Deserialize},
			{MosaicSupplyChangeTransactionV1.TRANSACTION_TYPE, MosaicSupplyChangeTransactionV1.Deserialize},
			{MultisigAccountModificationTransactionV1.TRANSACTION_TYPE, MultisigAccountModificationTransactionV1.Deserialize},
			{MultisigAccountModificationTransactionV2.TRANSACTION_TYPE, MultisigAccountModificationTransactionV2.Deserialize},
			{CosignatureV1.TRANSACTION_TYPE, CosignatureV1.Deserialize},
			{MultisigTransactionV1.TRANSACTION_TYPE, MultisigTransactionV1.Deserialize},
			{NamespaceRegistrationTransactionV1.TRANSACTION_TYPE, NamespaceRegistrationTransactionV1.Deserialize},
			{TransferTransactionV1.TRANSACTION_TYPE, TransferTransactionV1.Deserialize},
			{TransferTransactionV2.TRANSACTION_TYPE, TransferTransactionV2.Deserialize}
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
			{"mosaic_definition_transaction_v1", new MosaicDefinitionTransactionV1()},
			{"mosaic_supply_change_transaction_v1", new MosaicSupplyChangeTransactionV1()},
			{"multisig_account_modification_transaction_v1", new MultisigAccountModificationTransactionV1()},
			{"multisig_account_modification_transaction_v2", new MultisigAccountModificationTransactionV2()},
			{"cosignature_v1", new CosignatureV1()},
			{"multisig_transaction_v1", new MultisigTransactionV1()},
			{"namespace_registration_transaction_v1", new NamespaceRegistrationTransactionV1()},
			{"transfer_transaction_v1", new TransferTransactionV1()},
			{"transfer_transaction_v2", new TransferTransactionV2()}

		};
		return mapping[entityName];
	}
}

public class NonVerifiableTransactionFactory {
	public static IBaseTransaction Deserialize(BinaryReader br) {
		var position = br.BaseStream.Position;
		var parent = NonVerifiableTransaction.Deserialize(br);
		var mapping = new Dictionary<TransactionType, Func<BinaryReader, IBaseTransaction>>
		{
			{NonVerifiableAccountKeyLinkTransactionV1.TRANSACTION_TYPE, NonVerifiableAccountKeyLinkTransactionV1.Deserialize},
			{NonVerifiableMosaicDefinitionTransactionV1.TRANSACTION_TYPE, NonVerifiableMosaicDefinitionTransactionV1.Deserialize},
			{NonVerifiableMosaicSupplyChangeTransactionV1.TRANSACTION_TYPE, NonVerifiableMosaicSupplyChangeTransactionV1.Deserialize},
			{NonVerifiableMultisigAccountModificationTransactionV1.TRANSACTION_TYPE, NonVerifiableMultisigAccountModificationTransactionV1.Deserialize},
			{NonVerifiableMultisigAccountModificationTransactionV2.TRANSACTION_TYPE, NonVerifiableMultisigAccountModificationTransactionV2.Deserialize},
			{NonVerifiableMultisigTransactionV1.TRANSACTION_TYPE, NonVerifiableMultisigTransactionV1.Deserialize},
			{NonVerifiableNamespaceRegistrationTransactionV1.TRANSACTION_TYPE, NonVerifiableNamespaceRegistrationTransactionV1.Deserialize},
			{NonVerifiableTransferTransactionV1.TRANSACTION_TYPE, NonVerifiableTransferTransactionV1.Deserialize},
			{NonVerifiableTransferTransactionV2.TRANSACTION_TYPE, NonVerifiableTransferTransactionV2.Deserialize}
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
			{"non_verifiable_account_key_link_transaction_v1", new NonVerifiableAccountKeyLinkTransactionV1()},
			{"non_verifiable_mosaic_definition_transaction_v1", new NonVerifiableMosaicDefinitionTransactionV1()},
			{"non_verifiable_mosaic_supply_change_transaction_v1", new NonVerifiableMosaicSupplyChangeTransactionV1()},
			{"non_verifiable_multisig_account_modification_transaction_v1", new NonVerifiableMultisigAccountModificationTransactionV1()},
			{"non_verifiable_multisig_account_modification_transaction_v2", new NonVerifiableMultisigAccountModificationTransactionV2()},
			{"non_verifiable_multisig_transaction_v1", new NonVerifiableMultisigTransactionV1()},
			{"non_verifiable_namespace_registration_transaction_v1", new NonVerifiableNamespaceRegistrationTransactionV1()},
			{"non_verifiable_transfer_transaction_v1", new NonVerifiableTransferTransactionV1()},
			{"non_verifiable_transfer_transaction_v2", new NonVerifiableTransferTransactionV2()}

		};
		return mapping[entityName];
	}
}
}