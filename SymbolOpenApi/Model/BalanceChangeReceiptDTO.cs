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
    /// Receipt stored when a state change modified an account balance.
    /// </summary>
    [DataContract]
    public partial class BalanceChangeReceiptDTO :  IEquatable<BalanceChangeReceiptDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public ReceiptTypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceChangeReceiptDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceChangeReceiptDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceChangeReceiptDTO" /> class.
        /// </summary>
        /// <param name="version">Version of the receipt. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="mosaicId">Mosaic identifier. (required).</param>
        /// <param name="amount">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="targetAddress">Address encoded using a 32-character set. (required).</param>
        public BalanceChangeReceiptDTO(int version = default(int), ReceiptTypeEnum type = default(ReceiptTypeEnum), string mosaicId = default(string), string amount = default(string), string targetAddress = default(string))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for BalanceChangeReceiptDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BalanceChangeReceiptDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for BalanceChangeReceiptDTO and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for BalanceChangeReceiptDTO and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "targetAddress" is required (not null)
            if (targetAddress == null)
            {
                throw new InvalidDataException("targetAddress is a required property for BalanceChangeReceiptDTO and cannot be null");
            }
            else
            {
                this.TargetAddress = targetAddress;
            }

        }

        /// <summary>
        /// Version of the receipt.
        /// </summary>
        /// <value>Version of the receipt.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }


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
        [DataMember(Name="targetAddress", EmitDefaultValue=true)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceChangeReceiptDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
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
            return this.Equals(input as BalanceChangeReceiptDTO);
        }

        /// <summary>
        /// Returns true if BalanceChangeReceiptDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceChangeReceiptDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceChangeReceiptDTO input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.TargetAddress == input.TargetAddress ||
                    (this.TargetAddress != null &&
                    this.TargetAddress.Equals(input.TargetAddress))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MosaicId != null)
                    hashCode = hashCode * 59 + this.MosaicId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TargetAddress != null)
                    hashCode = hashCode * 59 + this.TargetAddress.GetHashCode();
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
