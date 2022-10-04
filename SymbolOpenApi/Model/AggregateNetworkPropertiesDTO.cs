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
    /// AggregateNetworkPropertiesDTO
    /// </summary>
    [DataContract]
    public partial class AggregateNetworkPropertiesDTO :  IEquatable<AggregateNetworkPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateNetworkPropertiesDTO" /> class.
        /// </summary>
        /// <param name="maxTransactionsPerAggregate">Maximum number of transactions per aggregate..</param>
        /// <param name="maxCosignaturesPerAggregate">Maximum number of cosignatures per aggregate..</param>
        /// <param name="enableStrictCosignatureCheck">Set to true if cosignatures must exactly match component signers. Set to false if cosignatures should be validated externally..</param>
        /// <param name="enableBondedAggregateSupport">Set to true if bonded aggregates should be allowed. Set to false if bonded aggregates should be rejected..</param>
        /// <param name="maxBondedTransactionLifetime">Maximum lifetime a bonded transaction can have before it expires..</param>
        public AggregateNetworkPropertiesDTO(string maxTransactionsPerAggregate = default(string), string maxCosignaturesPerAggregate = default(string), bool enableStrictCosignatureCheck = default(bool), bool enableBondedAggregateSupport = default(bool), string maxBondedTransactionLifetime = default(string))
        {
            this.MaxTransactionsPerAggregate = maxTransactionsPerAggregate;
            this.MaxCosignaturesPerAggregate = maxCosignaturesPerAggregate;
            this.EnableStrictCosignatureCheck = enableStrictCosignatureCheck;
            this.EnableBondedAggregateSupport = enableBondedAggregateSupport;
            this.MaxBondedTransactionLifetime = maxBondedTransactionLifetime;
        }

        /// <summary>
        /// Maximum number of transactions per aggregate.
        /// </summary>
        /// <value>Maximum number of transactions per aggregate.</value>
        [DataMember(Name="maxTransactionsPerAggregate", EmitDefaultValue=false)]
        public string MaxTransactionsPerAggregate { get; set; }

        /// <summary>
        /// Maximum number of cosignatures per aggregate.
        /// </summary>
        /// <value>Maximum number of cosignatures per aggregate.</value>
        [DataMember(Name="maxCosignaturesPerAggregate", EmitDefaultValue=false)]
        public string MaxCosignaturesPerAggregate { get; set; }

        /// <summary>
        /// Set to true if cosignatures must exactly match component signers. Set to false if cosignatures should be validated externally.
        /// </summary>
        /// <value>Set to true if cosignatures must exactly match component signers. Set to false if cosignatures should be validated externally.</value>
        [DataMember(Name="enableStrictCosignatureCheck", EmitDefaultValue=false)]
        public bool EnableStrictCosignatureCheck { get; set; }

        /// <summary>
        /// Set to true if bonded aggregates should be allowed. Set to false if bonded aggregates should be rejected.
        /// </summary>
        /// <value>Set to true if bonded aggregates should be allowed. Set to false if bonded aggregates should be rejected.</value>
        [DataMember(Name="enableBondedAggregateSupport", EmitDefaultValue=false)]
        public bool EnableBondedAggregateSupport { get; set; }

        /// <summary>
        /// Maximum lifetime a bonded transaction can have before it expires.
        /// </summary>
        /// <value>Maximum lifetime a bonded transaction can have before it expires.</value>
        [DataMember(Name="maxBondedTransactionLifetime", EmitDefaultValue=false)]
        public string MaxBondedTransactionLifetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregateNetworkPropertiesDTO {\n");
            sb.Append("  MaxTransactionsPerAggregate: ").Append(MaxTransactionsPerAggregate).Append("\n");
            sb.Append("  MaxCosignaturesPerAggregate: ").Append(MaxCosignaturesPerAggregate).Append("\n");
            sb.Append("  EnableStrictCosignatureCheck: ").Append(EnableStrictCosignatureCheck).Append("\n");
            sb.Append("  EnableBondedAggregateSupport: ").Append(EnableBondedAggregateSupport).Append("\n");
            sb.Append("  MaxBondedTransactionLifetime: ").Append(MaxBondedTransactionLifetime).Append("\n");
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
            return this.Equals(input as AggregateNetworkPropertiesDTO);
        }

        /// <summary>
        /// Returns true if AggregateNetworkPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregateNetworkPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateNetworkPropertiesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxTransactionsPerAggregate == input.MaxTransactionsPerAggregate ||
                    (this.MaxTransactionsPerAggregate != null &&
                    this.MaxTransactionsPerAggregate.Equals(input.MaxTransactionsPerAggregate))
                ) && 
                (
                    this.MaxCosignaturesPerAggregate == input.MaxCosignaturesPerAggregate ||
                    (this.MaxCosignaturesPerAggregate != null &&
                    this.MaxCosignaturesPerAggregate.Equals(input.MaxCosignaturesPerAggregate))
                ) && 
                (
                    this.EnableStrictCosignatureCheck == input.EnableStrictCosignatureCheck ||
                    (this.EnableStrictCosignatureCheck != null &&
                    this.EnableStrictCosignatureCheck.Equals(input.EnableStrictCosignatureCheck))
                ) && 
                (
                    this.EnableBondedAggregateSupport == input.EnableBondedAggregateSupport ||
                    (this.EnableBondedAggregateSupport != null &&
                    this.EnableBondedAggregateSupport.Equals(input.EnableBondedAggregateSupport))
                ) && 
                (
                    this.MaxBondedTransactionLifetime == input.MaxBondedTransactionLifetime ||
                    (this.MaxBondedTransactionLifetime != null &&
                    this.MaxBondedTransactionLifetime.Equals(input.MaxBondedTransactionLifetime))
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
                if (this.MaxTransactionsPerAggregate != null)
                    hashCode = hashCode * 59 + this.MaxTransactionsPerAggregate.GetHashCode();
                if (this.MaxCosignaturesPerAggregate != null)
                    hashCode = hashCode * 59 + this.MaxCosignaturesPerAggregate.GetHashCode();
                if (this.EnableStrictCosignatureCheck != null)
                    hashCode = hashCode * 59 + this.EnableStrictCosignatureCheck.GetHashCode();
                if (this.EnableBondedAggregateSupport != null)
                    hashCode = hashCode * 59 + this.EnableBondedAggregateSupport.GetHashCode();
                if (this.MaxBondedTransactionLifetime != null)
                    hashCode = hashCode * 59 + this.MaxBondedTransactionLifetime.GetHashCode();
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