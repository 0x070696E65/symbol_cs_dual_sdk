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
    /// MetadataInfoDTO
    /// </summary>
    [DataContract]
    public partial class MetadataInfoDTO :  IEquatable<MetadataInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetadataInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataInfoDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="metadataEntry">metadataEntry (required).</param>
        public MetadataInfoDTO(string id = default(string), MetadataEntryDTO metadataEntry = default(MetadataEntryDTO))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MetadataInfoDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "metadataEntry" is required (not null)
            if (metadataEntry == null)
            {
                throw new InvalidDataException("metadataEntry is a required property for MetadataInfoDTO and cannot be null");
            }
            else
            {
                this.MetadataEntry = metadataEntry;
            }

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets MetadataEntry
        /// </summary>
        [DataMember(Name="metadataEntry", EmitDefaultValue=true)]
        public MetadataEntryDTO MetadataEntry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MetadataEntry: ").Append(MetadataEntry).Append("\n");
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
            return this.Equals(input as MetadataInfoDTO);
        }

        /// <summary>
        /// Returns true if MetadataInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MetadataEntry == input.MetadataEntry ||
                    (this.MetadataEntry != null &&
                    this.MetadataEntry.Equals(input.MetadataEntry))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MetadataEntry != null)
                    hashCode = hashCode * 59 + this.MetadataEntry.GetHashCode();
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
