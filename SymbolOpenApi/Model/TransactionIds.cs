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
    /// TransactionIds
    /// </summary>
    [DataContract]
    public partial class TransactionIds :  IEquatable<TransactionIds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionIds" /> class.
        /// </summary>
        /// <param name="transactionIds">Array of transaction identifiers..</param>
        public TransactionIds(List<string> transactionIds = default(List<string>))
        {
            this._TransactionIds = transactionIds;
        }

        /// <summary>
        /// Array of transaction identifiers.
        /// </summary>
        /// <value>Array of transaction identifiers.</value>
        [DataMember(Name="transactionIds", EmitDefaultValue=false)]
        public List<string> _TransactionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionIds {\n");
            sb.Append("  _TransactionIds: ").Append(_TransactionIds).Append("\n");
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
            return this.Equals(input as TransactionIds);
        }

        /// <summary>
        /// Returns true if TransactionIds instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionIds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._TransactionIds == input._TransactionIds ||
                    this._TransactionIds != null &&
                    input._TransactionIds != null &&
                    this._TransactionIds.SequenceEqual(input._TransactionIds)
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
                if (this._TransactionIds != null)
                    hashCode = hashCode * 59 + this._TransactionIds.GetHashCode();
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
