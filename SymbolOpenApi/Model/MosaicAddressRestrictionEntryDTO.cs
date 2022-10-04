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
    /// MosaicAddressRestrictionEntryDTO
    /// </summary>
    [DataContract]
    public partial class MosaicAddressRestrictionEntryDTO :  IEquatable<MosaicAddressRestrictionEntryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicAddressRestrictionEntryDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicAddressRestrictionEntryDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicAddressRestrictionEntryDTO" /> class.
        /// </summary>
        /// <param name="key">Restriction key. (required).</param>
        /// <param name="value">Restriction value. (required).</param>
        public MosaicAddressRestrictionEntryDTO(string key = default(string), string value = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for MosaicAddressRestrictionEntryDTO and cannot be null");
            }
            else
            {
                this.Key = key;
            }

            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for MosaicAddressRestrictionEntryDTO and cannot be null");
            }
            else
            {
                this.Value = value;
            }

        }

        /// <summary>
        /// Restriction key.
        /// </summary>
        /// <value>Restriction key.</value>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Restriction value.
        /// </summary>
        /// <value>Restriction value.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicAddressRestrictionEntryDTO {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as MosaicAddressRestrictionEntryDTO);
        }

        /// <summary>
        /// Returns true if MosaicAddressRestrictionEntryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicAddressRestrictionEntryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicAddressRestrictionEntryDTO input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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