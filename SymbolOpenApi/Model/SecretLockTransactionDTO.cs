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
    /// Transaction to sends mosaics to a recipient if the proof used is revealed. If the duration is reached, the locked funds go back to the sender of the transaction.
    /// </summary>
    [DataContract]
    public partial class SecretLockTransactionDTO :  IEquatable<SecretLockTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=true)]
        public LockHashAlgorithmEnum HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretLockTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockTransactionDTO" /> class.
        /// </summary>
        /// <param name="size">A number that allows uint 32 values. (required).</param>
        /// <param name="signature">Entity&#39;s signature generated by the signer. (required).</param>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="maxFee">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="deadline">Duration expressed in number of blocks. (required).</param>
        /// <param name="recipientAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="secret">secret (required).</param>
        /// <param name="mosaicId">Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier.  (required).</param>
        /// <param name="amount">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="duration">Duration expressed in number of blocks. (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm (required).</param>
        public SecretLockTransactionDTO(long size = default(long), string signature = default(string), string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string maxFee = default(string), string deadline = default(string), string recipientAddress = default(string), string secret = default(string), string mosaicId = default(string), string amount = default(string), string duration = default(string), LockHashAlgorithmEnum hashAlgorithm = default(LockHashAlgorithmEnum))
        {
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Size = size;
            }

            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }

            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "maxFee" is required (not null)
            if (maxFee == null)
            {
                throw new InvalidDataException("maxFee is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.MaxFee = maxFee;
            }

            // to ensure "deadline" is required (not null)
            if (deadline == null)
            {
                throw new InvalidDataException("deadline is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Deadline = deadline;
            }

            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new InvalidDataException("recipientAddress is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.RecipientAddress = recipientAddress;
            }

            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }

            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }

            // to ensure "hashAlgorithm" is required (not null)
            if (hashAlgorithm == null)
            {
                throw new InvalidDataException("hashAlgorithm is a required property for SecretLockTransactionDTO and cannot be null");
            }
            else
            {
                this.HashAlgorithm = hashAlgorithm;
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
        [DataMember(Name="recipientAddress", EmitDefaultValue=true)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=true)]
        public string Secret { get; set; }

        /// <summary>
        /// Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier. 
        /// </summary>
        /// <value>Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier. </value>
        [DataMember(Name="mosaicId", EmitDefaultValue=true)]
        public string MosaicId { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        [DataMember(Name="duration", EmitDefaultValue=true)]
        public string Duration { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretLockTransactionDTO {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxFee: ").Append(MaxFee).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
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
            return this.Equals(input as SecretLockTransactionDTO);
        }

        /// <summary>
        /// Returns true if SecretLockTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretLockTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretLockTransactionDTO input)
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
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.MosaicId == input.MosaicId ||
                    (this.MosaicId != null &&
                    this.MosaicId.Equals(input.MosaicId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
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
                if (this.RecipientAddress != null)
                    hashCode = hashCode * 59 + this.RecipientAddress.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.MosaicId != null)
                    hashCode = hashCode * 59 + this.MosaicId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.HashAlgorithm != null)
                    hashCode = hashCode * 59 + this.HashAlgorithm.GetHashCode();
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
