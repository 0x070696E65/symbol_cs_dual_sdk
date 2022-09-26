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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// SecretLockTransactionBodyDTO
    /// </summary>
    [DataContract]
    public partial class SecretLockTransactionBodyDTO :  IEquatable<SecretLockTransactionBodyDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=true)]
        public LockHashAlgorithmEnum HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretLockTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="recipientAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="secret">secret (required).</param>
        /// <param name="mosaicId">Mosaic identifier. If the most significant bit of byte 0 is set, a namespaceId (alias) is used instead of the real mosaic identifier.  (required).</param>
        /// <param name="amount">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="duration">Duration expressed in number of blocks. (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm (required).</param>
        public SecretLockTransactionBodyDTO(string recipientAddress = default(string), string secret = default(string), string mosaicId = default(string), string amount = default(string), string duration = default(string), LockHashAlgorithmEnum hashAlgorithm = default(LockHashAlgorithmEnum))
        {
            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new InvalidDataException("recipientAddress is a required property for SecretLockTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.RecipientAddress = recipientAddress;
            }

            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for SecretLockTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }

            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for SecretLockTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SecretLockTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for SecretLockTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }

            // to ensure "hashAlgorithm" is required (not null)
            if (hashAlgorithm == null)
            {
                throw new InvalidDataException("hashAlgorithm is a required property for SecretLockTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.HashAlgorithm = hashAlgorithm;
            }

        }

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
            sb.Append("class SecretLockTransactionBodyDTO {\n");
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
            return this.Equals(input as SecretLockTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if SecretLockTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretLockTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretLockTransactionBodyDTO input)
        {
            if (input == null)
                return false;

            return 
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
