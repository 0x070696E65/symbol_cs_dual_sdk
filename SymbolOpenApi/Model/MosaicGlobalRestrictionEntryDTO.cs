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
    /// MosaicGlobalRestrictionEntryDTO
    /// </summary>
    [DataContract]
    public partial class MosaicGlobalRestrictionEntryDTO :  IEquatable<MosaicGlobalRestrictionEntryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicGlobalRestrictionEntryDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicGlobalRestrictionEntryDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicGlobalRestrictionEntryDTO" /> class.
        /// </summary>
        /// <param name="key">Restriction key. (required).</param>
        /// <param name="restriction">restriction (required).</param>
        public MosaicGlobalRestrictionEntryDTO(string key = default(string), MosaicGlobalRestrictionEntryRestrictionDTO restriction = default(MosaicGlobalRestrictionEntryRestrictionDTO))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for MosaicGlobalRestrictionEntryDTO and cannot be null");
            }
            else
            {
                this.Key = key;
            }

            // to ensure "restriction" is required (not null)
            if (restriction == null)
            {
                throw new InvalidDataException("restriction is a required property for MosaicGlobalRestrictionEntryDTO and cannot be null");
            }
            else
            {
                this.Restriction = restriction;
            }

        }

        /// <summary>
        /// Restriction key.
        /// </summary>
        /// <value>Restriction key.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Restriction
        /// </summary>
        [DataMember(Name="restriction", EmitDefaultValue=true)]
        public MosaicGlobalRestrictionEntryRestrictionDTO Restriction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicGlobalRestrictionEntryDTO {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Restriction: ").Append(Restriction).Append("\n");
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
            return this.Equals(input as MosaicGlobalRestrictionEntryDTO);
        }

        /// <summary>
        /// Returns true if MosaicGlobalRestrictionEntryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicGlobalRestrictionEntryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicGlobalRestrictionEntryDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Restriction == input.Restriction ||
                    (this.Restriction != null &&
                    this.Restriction.Equals(input.Restriction))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Restriction != null)
                    hashCode = hashCode * 59 + this.Restriction.GetHashCode();
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