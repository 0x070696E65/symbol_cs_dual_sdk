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
    /// EmbeddedNamespaceMetadataTransactionDTO
    /// </summary>
    [DataContract]
    public partial class EmbeddedNamespaceMetadataTransactionDTO :  IEquatable<EmbeddedNamespaceMetadataTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedNamespaceMetadataTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedNamespaceMetadataTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedNamespaceMetadataTransactionDTO" /> class.
        /// </summary>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="targetAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="scopedMetadataKey">Metadata key scoped to source, target and type expressed. (required).</param>
        /// <param name="targetNamespaceId">Namespace identifier..</param>
        /// <param name="valueSizeDelta">Change in value size in bytes. (required).</param>
        /// <param name="valueSize">A number that allows uint 32 values. (required).</param>
        /// <param name="value">Metadata value. If embedded in a transaction, this is calculated as xor(previous-value, value). (required).</param>
        public EmbeddedNamespaceMetadataTransactionDTO(string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string targetAddress = default(string), string scopedMetadataKey = default(string), string targetNamespaceId = default(string), int valueSizeDelta = default(int), long valueSize = default(long), string value = default(string))
        {
            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "targetAddress" is required (not null)
            if (targetAddress == null)
            {
                throw new InvalidDataException("targetAddress is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.TargetAddress = targetAddress;
            }

            // to ensure "scopedMetadataKey" is required (not null)
            if (scopedMetadataKey == null)
            {
                throw new InvalidDataException("scopedMetadataKey is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.ScopedMetadataKey = scopedMetadataKey;
            }

            // to ensure "valueSizeDelta" is required (not null)
            if (valueSizeDelta == null)
            {
                throw new InvalidDataException("valueSizeDelta is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.ValueSizeDelta = valueSizeDelta;
            }

            // to ensure "valueSize" is required (not null)
            if (valueSize == null)
            {
                throw new InvalidDataException("valueSize is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.ValueSize = valueSize;
            }

            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for EmbeddedNamespaceMetadataTransactionDTO and cannot be null");
            }
            else
            {
                this.Value = value;
            }

            this.TargetNamespaceId = targetNamespaceId;
        }

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
        /// Namespace identifier.
        /// </summary>
        /// <value>Namespace identifier.</value>
        [DataMember(Name="targetNamespaceId", EmitDefaultValue=false)]
        public string TargetNamespaceId { get; set; }

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
            sb.Append("class EmbeddedNamespaceMetadataTransactionDTO {\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
            sb.Append("  ScopedMetadataKey: ").Append(ScopedMetadataKey).Append("\n");
            sb.Append("  TargetNamespaceId: ").Append(TargetNamespaceId).Append("\n");
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
            return this.Equals(input as EmbeddedNamespaceMetadataTransactionDTO);
        }

        /// <summary>
        /// Returns true if EmbeddedNamespaceMetadataTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedNamespaceMetadataTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedNamespaceMetadataTransactionDTO input)
        {
            if (input == null)
                return false;

            return 
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
                    this.TargetNamespaceId == input.TargetNamespaceId ||
                    (this.TargetNamespaceId != null &&
                    this.TargetNamespaceId.Equals(input.TargetNamespaceId))
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
                if (this.SignerPublicKey != null)
                    hashCode = hashCode * 59 + this.SignerPublicKey.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TargetAddress != null)
                    hashCode = hashCode * 59 + this.TargetAddress.GetHashCode();
                if (this.ScopedMetadataKey != null)
                    hashCode = hashCode * 59 + this.ScopedMetadataKey.GetHashCode();
                if (this.TargetNamespaceId != null)
                    hashCode = hashCode * 59 + this.TargetNamespaceId.GetHashCode();
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