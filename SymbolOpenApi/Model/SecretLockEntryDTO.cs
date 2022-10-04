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
    /// SecretLockEntryDTO
    /// </summary>
    [DataContract]
    public partial class SecretLockEntryDTO :  IEquatable<SecretLockEntryDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public LockStatus Status { get; set; }
        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=true)]
        public LockHashAlgorithmEnum HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockEntryDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretLockEntryDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockEntryDTO" /> class.
        /// </summary>
        /// <param name="version">The version of the state (required).</param>
        /// <param name="ownerAddress">Address encoded using a 32-character set. (required).</param>
        /// <param name="mosaicId">Mosaic identifier. (required).</param>
        /// <param name="amount">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="endHeight">Height of the blockchain. (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm (required).</param>
        /// <param name="secret">Secret. (required).</param>
        /// <param name="recipientAddress">Address encoded using a 32-character set. (required).</param>
        /// <param name="compositeHash">compositeHash (required).</param>
        public SecretLockEntryDTO(int version = default(int), string ownerAddress = default(string), string mosaicId = default(string), string amount = default(string), string endHeight = default(string), LockStatus status = default(LockStatus), LockHashAlgorithmEnum hashAlgorithm = default(LockHashAlgorithmEnum), string secret = default(string), string recipientAddress = default(string), string compositeHash = default(string))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "ownerAddress" is required (not null)
            if (ownerAddress == null)
            {
                throw new InvalidDataException("ownerAddress is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.OwnerAddress = ownerAddress;
            }

            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "endHeight" is required (not null)
            if (endHeight == null)
            {
                throw new InvalidDataException("endHeight is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.EndHeight = endHeight;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "hashAlgorithm" is required (not null)
            if (hashAlgorithm == null)
            {
                throw new InvalidDataException("hashAlgorithm is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.HashAlgorithm = hashAlgorithm;
            }

            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }

            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new InvalidDataException("recipientAddress is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.RecipientAddress = recipientAddress;
            }

            // to ensure "compositeHash" is required (not null)
            if (compositeHash == null)
            {
                throw new InvalidDataException("compositeHash is a required property for SecretLockEntryDTO and cannot be null");
            }
            else
            {
                this.CompositeHash = compositeHash;
            }

        }

        /// <summary>
        /// The version of the state
        /// </summary>
        /// <value>The version of the state</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        [DataMember(Name="ownerAddress", EmitDefaultValue=true)]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        [DataMember(Name="mosaicId", EmitDefaultValue=true)]
        public string MosaicId { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

        /// <summary>
        /// Height of the blockchain.
        /// </summary>
        /// <value>Height of the blockchain.</value>
        [DataMember(Name="endHeight", EmitDefaultValue=true)]
        public string EndHeight { get; set; }



        /// <summary>
        /// Secret.
        /// </summary>
        /// <value>Secret.</value>
        [DataMember(Name="secret", EmitDefaultValue=true)]
        public string Secret { get; set; }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        [DataMember(Name="recipientAddress", EmitDefaultValue=true)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Gets or Sets CompositeHash
        /// </summary>
        [DataMember(Name="compositeHash", EmitDefaultValue=true)]
        public string CompositeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretLockEntryDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  OwnerAddress: ").Append(OwnerAddress).Append("\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  EndHeight: ").Append(EndHeight).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  CompositeHash: ").Append(CompositeHash).Append("\n");
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
            return this.Equals(input as SecretLockEntryDTO);
        }

        /// <summary>
        /// Returns true if SecretLockEntryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretLockEntryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretLockEntryDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.OwnerAddress == input.OwnerAddress ||
                    (this.OwnerAddress != null &&
                    this.OwnerAddress.Equals(input.OwnerAddress))
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
                    this.EndHeight == input.EndHeight ||
                    (this.EndHeight != null &&
                    this.EndHeight.Equals(input.EndHeight))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.CompositeHash == input.CompositeHash ||
                    (this.CompositeHash != null &&
                    this.CompositeHash.Equals(input.CompositeHash))
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
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.OwnerAddress != null)
                    hashCode = hashCode * 59 + this.OwnerAddress.GetHashCode();
                if (this.MosaicId != null)
                    hashCode = hashCode * 59 + this.MosaicId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.EndHeight != null)
                    hashCode = hashCode * 59 + this.EndHeight.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.HashAlgorithm != null)
                    hashCode = hashCode * 59 + this.HashAlgorithm.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.RecipientAddress != null)
                    hashCode = hashCode * 59 + this.RecipientAddress.GetHashCode();
                if (this.CompositeHash != null)
                    hashCode = hashCode * 59 + this.CompositeHash.GetHashCode();
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