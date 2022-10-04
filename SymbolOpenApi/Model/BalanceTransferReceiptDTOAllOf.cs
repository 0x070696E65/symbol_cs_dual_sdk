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
    /// BalanceTransferReceiptDTOAllOf
    /// </summary>
    [DataContract]
    public partial class BalanceTransferReceiptDTOAllOf :  IEquatable<BalanceTransferReceiptDTOAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferReceiptDTOAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceTransferReceiptDTOAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferReceiptDTOAllOf" /> class.
        /// </summary>
        /// <param name="mosaicId">Mosaic identifier. (required).</param>
        /// <param name="amount">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="senderAddress">Address encoded using a 32-character set. (required).</param>
        /// <param name="recipientAddress">Address encoded using a 32-character set. (required).</param>
        public BalanceTransferReceiptDTOAllOf(string mosaicId = default(string), string amount = default(string), string senderAddress = default(string), string recipientAddress = default(string))
        {
            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for BalanceTransferReceiptDTOAllOf and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for BalanceTransferReceiptDTOAllOf and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "senderAddress" is required (not null)
            if (senderAddress == null)
            {
                throw new InvalidDataException("senderAddress is a required property for BalanceTransferReceiptDTOAllOf and cannot be null");
            }
            else
            {
                this.SenderAddress = senderAddress;
            }

            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new InvalidDataException("recipientAddress is a required property for BalanceTransferReceiptDTOAllOf and cannot be null");
            }
            else
            {
                this.RecipientAddress = recipientAddress;
            }

        }

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
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        [DataMember(Name="senderAddress", EmitDefaultValue=true)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        [DataMember(Name="recipientAddress", EmitDefaultValue=true)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceTransferReceiptDTOAllOf {\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
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
            return this.Equals(input as BalanceTransferReceiptDTOAllOf);
        }

        /// <summary>
        /// Returns true if BalanceTransferReceiptDTOAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceTransferReceiptDTOAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceTransferReceiptDTOAllOf input)
        {
            if (input == null)
                return false;

            return 
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
                    this.SenderAddress == input.SenderAddress ||
                    (this.SenderAddress != null &&
                    this.SenderAddress.Equals(input.SenderAddress))
                ) && 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
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
                if (this.MosaicId != null)
                    hashCode = hashCode * 59 + this.MosaicId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.SenderAddress != null)
                    hashCode = hashCode * 59 + this.SenderAddress.GetHashCode();
                if (this.RecipientAddress != null)
                    hashCode = hashCode * 59 + this.RecipientAddress.GetHashCode();
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