/*
 * Catapult REST Endpoints
 *
 * OpenAPI Specification of catapult-rest
 *
 * The version of the OpenAPI document: 1.0.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SymbolOpenApi.Client.OpenAPIDateConverter;

namespace SymbolOpenApi.Model
{
    /// <summary>
    /// Transaction to create or modify a multisig account.
    /// </summary>
    [DataContract]
    public partial class MosaicMetadataTransactionDTO :  IEquatable<MosaicMetadataTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicMetadataTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicMetadataTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicMetadataTransactionDTO" /> class.
        /// </summary>
        /// <param name="size">A number that allows uint 32 values. (required).</param>
        /// <param name="signature">Entity&#39;s signature generated by the signer. (required).</param>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="maxFee">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="deadline">Duration expressed in number of blocks. (required).</param>
        /// <param name="targetAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="scopedMetadataKey">Metadata key scoped to source, target and type expressed. (required).</param>
        /// <param name="targetMosaicId">Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier.  (required).</param>
        /// <param name="valueSizeDelta">Change in value size in bytes. (required).</param>
        /// <param name="valueSize">A number that allows uint 32 values. (required).</param>
        /// <param name="value">Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value). (required).</param>
        public MosaicMetadataTransactionDTO(long size = default(long), string signature = default(string), string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string maxFee = default(string), string deadline = default(string), string targetAddress = default(string), string scopedMetadataKey = default(string), string targetMosaicId = default(string), int valueSizeDelta = default(int), long valueSize = default(long), string value = default(string))
        {
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Size = size;
            }

            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }

            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "maxFee" is required (not null)
            if (maxFee == null)
            {
                throw new InvalidDataException("maxFee is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.MaxFee = maxFee;
            }

            // to ensure "deadline" is required (not null)
            if (deadline == null)
            {
                throw new InvalidDataException("deadline is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Deadline = deadline;
            }

            // to ensure "targetAddress" is required (not null)
            if (targetAddress == null)
            {
                throw new InvalidDataException("targetAddress is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.TargetAddress = targetAddress;
            }

            // to ensure "scopedMetadataKey" is required (not null)
            if (scopedMetadataKey == null)
            {
                throw new InvalidDataException("scopedMetadataKey is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.ScopedMetadataKey = scopedMetadataKey;
            }

            // to ensure "targetMosaicId" is required (not null)
            if (targetMosaicId == null)
            {
                throw new InvalidDataException("targetMosaicId is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.TargetMosaicId = targetMosaicId;
            }

            // to ensure "valueSizeDelta" is required (not null)
            if (valueSizeDelta == null)
            {
                throw new InvalidDataException("valueSizeDelta is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.ValueSizeDelta = valueSizeDelta;
            }

            // to ensure "valueSize" is required (not null)
            if (valueSize == null)
            {
                throw new InvalidDataException("valueSize is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.ValueSize = valueSize;
            }

            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for MosaicMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Value = value;
            }

        }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="size", EmitDefaultValue=true)]
        public long Size { get; set; }

        /// <summary>
        /// Entity&#39;s signature generated by the signer.
        /// </summary>
        /// <value>Entity&#39;s signature generated by the signer.</value>
        [DataMember(Name="signature", EmitDefaultValue=true)]
        public string Signature { get; set; }

        /// <summary>
        /// Public key.
        /// </summary>
        /// <value>Public key.</value>
        [DataMember(Name="signerPublicKey", EmitDefaultValue=true)]
        public string SignerPublicKey { get; set; }

        /// <summary>
        /// Entity version.
        /// </summary>
        /// <value>Entity version.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int Type { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        [DataMember(Name="maxFee", EmitDefaultValue=true)]
        public string MaxFee { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        [DataMember(Name="deadline", EmitDefaultValue=true)]
        public string Deadline { get; set; }

        /// <summary>
        /// Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA 
        /// </summary>
        /// <value>Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA </value>
        [DataMember(Name="targetAddress", EmitDefaultValue=true)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// Metadata key scoped to source, target and type expressed.
        /// </summary>
        /// <value>Metadata key scoped to source, target and type expressed.</value>
        [DataMember(Name="scopedMetadataKey", EmitDefaultValue=true)]
        public string ScopedMetadataKey { get; set; }

        /// <summary>
        /// Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier. 
        /// </summary>
        /// <value>Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier. </value>
        [DataMember(Name="targetMosaicId", EmitDefaultValue=true)]
        public string TargetMosaicId { get; set; }

        /// <summary>
        /// Change in value size in bytes.
        /// </summary>
        /// <value>Change in value size in bytes.</value>
        [DataMember(Name="valueSizeDelta", EmitDefaultValue=true)]
        public int ValueSizeDelta { get; set; }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="valueSize", EmitDefaultValue=true)]
        public long ValueSize { get; set; }

        /// <summary>
        /// Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value).
        /// </summary>
        /// <value>Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value).</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicMetadataTransactionDTO {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxFee: ").Append(MaxFee).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
            sb.Append("  ScopedMetadataKey: ").Append(ScopedMetadataKey).Append("\n");
            sb.Append("  TargetMosaicId: ").Append(TargetMosaicId).Append("\n");
            sb.Append("  ValueSizeDelta: ").Append(ValueSizeDelta).Append("\n");
            sb.Append("  ValueSize: ").Append(ValueSize).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MosaicMetadataTransactionDTO);
        }

        /// <summary>
        /// Returns true if MosaicMetadataTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicMetadataTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicMetadataTransactionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.SignerPublicKey == input.SignerPublicKey ||
                    (this.SignerPublicKey != null &&
                    this.SignerPublicKey.Equals(input.SignerPublicKey))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MaxFee == input.MaxFee ||
                    (this.MaxFee != null &&
                    this.MaxFee.Equals(input.MaxFee))
                ) && 
                (
                    this.Deadline == input.Deadline ||
                    (this.Deadline != null &&
                    this.Deadline.Equals(input.Deadline))
                ) && 
                (
                    this.TargetAddress == input.TargetAddress ||
                    (this.TargetAddress != null &&
                    this.TargetAddress.Equals(input.TargetAddress))
                ) && 
                (
                    this.ScopedMetadataKey == input.ScopedMetadataKey ||
                    (this.ScopedMetadataKey != null &&
                    this.ScopedMetadataKey.Equals(input.ScopedMetadataKey))
                ) && 
                (
                    this.TargetMosaicId == input.TargetMosaicId ||
                    (this.TargetMosaicId != null &&
                    this.TargetMosaicId.Equals(input.TargetMosaicId))
                ) && 
                (
                    this.ValueSizeDelta == input.ValueSizeDelta ||
                    (this.ValueSizeDelta != null &&
                    this.ValueSizeDelta.Equals(input.ValueSizeDelta))
                ) && 
                (
                    this.ValueSize == input.ValueSize ||
                    (this.ValueSize != null &&
                    this.ValueSize.Equals(input.ValueSize))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.SignerPublicKey != null)
                    hashCode = hashCode * 59 + this.SignerPublicKey.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MaxFee != null)
                    hashCode = hashCode * 59 + this.MaxFee.GetHashCode();
                if (this.Deadline != null)
                    hashCode = hashCode * 59 + this.Deadline.GetHashCode();
                if (this.TargetAddress != null)
                    hashCode = hashCode * 59 + this.TargetAddress.GetHashCode();
                if (this.ScopedMetadataKey != null)
                    hashCode = hashCode * 59 + this.ScopedMetadataKey.GetHashCode();
                if (this.TargetMosaicId != null)
                    hashCode = hashCode * 59 + this.TargetMosaicId.GetHashCode();
                if (this.ValueSizeDelta != null)
                    hashCode = hashCode * 59 + this.ValueSizeDelta.GetHashCode();
                if (this.ValueSize != null)
                    hashCode = hashCode * 59 + this.ValueSize.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
