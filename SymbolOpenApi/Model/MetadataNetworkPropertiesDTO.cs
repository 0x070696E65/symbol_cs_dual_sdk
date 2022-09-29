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
    /// MetadataNetworkPropertiesDTO
    /// </summary>
    [DataContract]
    public partial class MetadataNetworkPropertiesDTO :  IEquatable<MetadataNetworkPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataNetworkPropertiesDTO" /> class.
        /// </summary>
        /// <param name="maxValueSize">Maximum metadata value size..</param>
        public MetadataNetworkPropertiesDTO(string maxValueSize = default(string))
        {
            this.MaxValueSize = maxValueSize;
        }

        /// <summary>
        /// Maximum metadata value size.
        /// </summary>
        /// <value>Maximum metadata value size.</value>
        [DataMember(Name="maxValueSize", EmitDefaultValue=false)]
        public string MaxValueSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataNetworkPropertiesDTO {\n");
            sb.Append("  MaxValueSize: ").Append(MaxValueSize).Append("\n");
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
            return this.Equals(input as MetadataNetworkPropertiesDTO);
        }

        /// <summary>
        /// Returns true if MetadataNetworkPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataNetworkPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataNetworkPropertiesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxValueSize == input.MaxValueSize ||
                    (this.MaxValueSize != null &&
                    this.MaxValueSize.Equals(input.MaxValueSize))
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
                if (this.MaxValueSize != null)
                    hashCode = hashCode * 59 + this.MaxValueSize.GetHashCode();
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
