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
    /// HashLockNetworkPropertiesDTO
    /// </summary>
    [DataContract]
    public partial class HashLockNetworkPropertiesDTO :  IEquatable<HashLockNetworkPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HashLockNetworkPropertiesDTO" /> class.
        /// </summary>
        /// <param name="lockedFundsPerAggregate">Amount that has to be locked per aggregate in partial cache..</param>
        /// <param name="maxHashLockDuration">Maximum number of blocks for which a hash lock can exist..</param>
        public HashLockNetworkPropertiesDTO(string lockedFundsPerAggregate = default(string), string maxHashLockDuration = default(string))
        {
            this.LockedFundsPerAggregate = lockedFundsPerAggregate;
            this.MaxHashLockDuration = maxHashLockDuration;
        }

        /// <summary>
        /// Amount that has to be locked per aggregate in partial cache.
        /// </summary>
        /// <value>Amount that has to be locked per aggregate in partial cache.</value>
        [DataMember(Name="lockedFundsPerAggregate", EmitDefaultValue=false)]
        public string LockedFundsPerAggregate { get; set; }

        /// <summary>
        /// Maximum number of blocks for which a hash lock can exist.
        /// </summary>
        /// <value>Maximum number of blocks for which a hash lock can exist.</value>
        [DataMember(Name="maxHashLockDuration", EmitDefaultValue=false)]
        public string MaxHashLockDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HashLockNetworkPropertiesDTO {\n");
            sb.Append("  LockedFundsPerAggregate: ").Append(LockedFundsPerAggregate).Append("\n");
            sb.Append("  MaxHashLockDuration: ").Append(MaxHashLockDuration).Append("\n");
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
            return this.Equals(input as HashLockNetworkPropertiesDTO);
        }

        /// <summary>
        /// Returns true if HashLockNetworkPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of HashLockNetworkPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HashLockNetworkPropertiesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LockedFundsPerAggregate == input.LockedFundsPerAggregate ||
                    (this.LockedFundsPerAggregate != null &&
                    this.LockedFundsPerAggregate.Equals(input.LockedFundsPerAggregate))
                ) && 
                (
                    this.MaxHashLockDuration == input.MaxHashLockDuration ||
                    (this.MaxHashLockDuration != null &&
                    this.MaxHashLockDuration.Equals(input.MaxHashLockDuration))
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
                if (this.LockedFundsPerAggregate != null)
                    hashCode = hashCode * 59 + this.LockedFundsPerAggregate.GetHashCode();
                if (this.MaxHashLockDuration != null)
                    hashCode = hashCode * 59 + this.MaxHashLockDuration.GetHashCode();
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