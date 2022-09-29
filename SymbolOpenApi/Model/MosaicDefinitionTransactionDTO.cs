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
    /// Transaction to create a new mosaic.
    /// </summary>
    [DataContract]
    public partial class MosaicDefinitionTransactionDTO :  IEquatable<MosaicDefinitionTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicDefinitionTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicDefinitionTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicDefinitionTransactionDTO" /> class.
        /// </summary>
        /// <param name="size">A number that allows uint 32 values. (required).</param>
        /// <param name="signature">Entity&#39;s signature generated by the signer. (required).</param>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="maxFee">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="deadline">Duration expressed in number of blocks. (required).</param>
        /// <param name="id">Mosaic identifier. (required).</param>
        /// <param name="duration">Duration expressed in number of blocks. (required).</param>
        /// <param name="nonce">A number that allows uint 32 values. (required).</param>
        /// <param name="flags">- 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user.  (required).</param>
        /// <param name="divisibility">Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6.  (required).</param>
        public MosaicDefinitionTransactionDTO(long size = default(long), string signature = default(string), string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string maxFee = default(string), string deadline = default(string), string id = default(string), string duration = default(string), long nonce = default(long), int flags = default(int), int divisibility = default(int))
        {
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Size = size;
            }

            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }

            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "maxFee" is required (not null)
            if (maxFee == null)
            {
                throw new InvalidDataException("maxFee is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.MaxFee = maxFee;
            }

            // to ensure "deadline" is required (not null)
            if (deadline == null)
            {
                throw new InvalidDataException("deadline is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Deadline = deadline;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }

            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new InvalidDataException("nonce is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Nonce = nonce;
            }

            // to ensure "flags" is required (not null)
            if (flags == null)
            {
                throw new InvalidDataException("flags is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Flags = flags;
            }

            // to ensure "divisibility" is required (not null)
            if (divisibility == null)
            {
                throw new InvalidDataException("divisibility is a required property for MosaicDefinitionTransactionDTO and cannot be null");
            }
            else
            {
                this.Divisibility = divisibility;
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
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        [DataMember(Name="duration", EmitDefaultValue=true)]
        public string Duration { get; set; }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="nonce", EmitDefaultValue=true)]
        public long Nonce { get; set; }

        /// <summary>
        /// - 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user. 
        /// </summary>
        /// <value>- 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user. </value>
        [DataMember(Name="flags", EmitDefaultValue=true)]
        public int Flags { get; set; }

        /// <summary>
        /// Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6. 
        /// </summary>
        /// <value>Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6. </value>
        [DataMember(Name="divisibility", EmitDefaultValue=true)]
        public int Divisibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicDefinitionTransactionDTO {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxFee: ").Append(MaxFee).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Divisibility: ").Append(Divisibility).Append("\n");
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
            return this.Equals(input as MosaicDefinitionTransactionDTO);
        }

        /// <summary>
        /// Returns true if MosaicDefinitionTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicDefinitionTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicDefinitionTransactionDTO input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
                ) && 
                (
                    this.Divisibility == input.Divisibility ||
                    (this.Divisibility != null &&
                    this.Divisibility.Equals(input.Divisibility))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Divisibility != null)
                    hashCode = hashCode * 59 + this.Divisibility.GetHashCode();
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
