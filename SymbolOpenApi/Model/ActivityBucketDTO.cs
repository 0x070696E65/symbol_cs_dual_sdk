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
    /// Supplementary data stored for importance recalculation. At each importance recalculation, existing buckets are shifted, the working bucket is finalized and a new working bucket is created. Each bucket influences at most five importance recalculations. 
    /// </summary>
    [DataContract]
    public partial class ActivityBucketDTO :  IEquatable<ActivityBucketDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityBucketDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityBucketDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityBucketDTO" /> class.
        /// </summary>
        /// <param name="startHeight">Height of the blockchain. (required).</param>
        /// <param name="totalFeesPaid">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="beneficiaryCount">A number that allows uint 32 values. (required).</param>
        /// <param name="rawScore">Probability of an account to harvest the next block. (required).</param>
        public ActivityBucketDTO(string startHeight = default(string), string totalFeesPaid = default(string), long beneficiaryCount = default(long), string rawScore = default(string))
        {
            // to ensure "startHeight" is required (not null)
            if (startHeight == null)
            {
                throw new InvalidDataException("startHeight is a required property for ActivityBucketDTO and cannot be null");
            }
            else
            {
                this.StartHeight = startHeight;
            }

            // to ensure "totalFeesPaid" is required (not null)
            if (totalFeesPaid == null)
            {
                throw new InvalidDataException("totalFeesPaid is a required property for ActivityBucketDTO and cannot be null");
            }
            else
            {
                this.TotalFeesPaid = totalFeesPaid;
            }

            // to ensure "beneficiaryCount" is required (not null)
            if (beneficiaryCount == null)
            {
                throw new InvalidDataException("beneficiaryCount is a required property for ActivityBucketDTO and cannot be null");
            }
            else
            {
                this.BeneficiaryCount = beneficiaryCount;
            }

            // to ensure "rawScore" is required (not null)
            if (rawScore == null)
            {
                throw new InvalidDataException("rawScore is a required property for ActivityBucketDTO and cannot be null");
            }
            else
            {
                this.RawScore = rawScore;
            }

        }

        /// <summary>
        /// Height of the blockchain.
        /// </summary>
        /// <value>Height of the blockchain.</value>
        [DataMember(Name="startHeight", EmitDefaultValue=true)]
        public string StartHeight { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        [DataMember(Name="totalFeesPaid", EmitDefaultValue=true)]
        public string TotalFeesPaid { get; set; }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="beneficiaryCount", EmitDefaultValue=true)]
        public long BeneficiaryCount { get; set; }

        /// <summary>
        /// Probability of an account to harvest the next block.
        /// </summary>
        /// <value>Probability of an account to harvest the next block.</value>
        [DataMember(Name="rawScore", EmitDefaultValue=true)]
        public string RawScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityBucketDTO {\n");
            sb.Append("  StartHeight: ").Append(StartHeight).Append("\n");
            sb.Append("  TotalFeesPaid: ").Append(TotalFeesPaid).Append("\n");
            sb.Append("  BeneficiaryCount: ").Append(BeneficiaryCount).Append("\n");
            sb.Append("  RawScore: ").Append(RawScore).Append("\n");
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
            return this.Equals(input as ActivityBucketDTO);
        }

        /// <summary>
        /// Returns true if ActivityBucketDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityBucketDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityBucketDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartHeight == input.StartHeight ||
                    (this.StartHeight != null &&
                    this.StartHeight.Equals(input.StartHeight))
                ) && 
                (
                    this.TotalFeesPaid == input.TotalFeesPaid ||
                    (this.TotalFeesPaid != null &&
                    this.TotalFeesPaid.Equals(input.TotalFeesPaid))
                ) && 
                (
                    this.BeneficiaryCount == input.BeneficiaryCount ||
                    (this.BeneficiaryCount != null &&
                    this.BeneficiaryCount.Equals(input.BeneficiaryCount))
                ) && 
                (
                    this.RawScore == input.RawScore ||
                    (this.RawScore != null &&
                    this.RawScore.Equals(input.RawScore))
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
                if (this.StartHeight != null)
                    hashCode = hashCode * 59 + this.StartHeight.GetHashCode();
                if (this.TotalFeesPaid != null)
                    hashCode = hashCode * 59 + this.TotalFeesPaid.GetHashCode();
                if (this.BeneficiaryCount != null)
                    hashCode = hashCode * 59 + this.BeneficiaryCount.GetHashCode();
                if (this.RawScore != null)
                    hashCode = hashCode * 59 + this.RawScore.GetHashCode();
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
