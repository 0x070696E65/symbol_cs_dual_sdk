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
    /// MosaicRestrictionsPage
    /// </summary>
    [DataContract]
    public partial class MosaicRestrictionsPage :  IEquatable<MosaicRestrictionsPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicRestrictionsPage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicRestrictionsPage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicRestrictionsPage" /> class.
        /// </summary>
        /// <param name="data">Array of mosaic restrictions. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public MosaicRestrictionsPage(List<MosaicRestrictionsPageDataInner> data = default(List<MosaicRestrictionsPageDataInner>), Pagination pagination = default(Pagination))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for MosaicRestrictionsPage and cannot be null");
            }
            else
            {
                this.Data = data;
            }

            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new InvalidDataException("pagination is a required property for MosaicRestrictionsPage and cannot be null");
            }
            else
            {
                this.Pagination = pagination;
            }

        }

        /// <summary>
        /// Array of mosaic restrictions.
        /// </summary>
        /// <value>Array of mosaic restrictions.</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<MosaicRestrictionsPageDataInner> Data { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=true)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicRestrictionsPage {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as MosaicRestrictionsPage);
        }

        /// <summary>
        /// Returns true if MosaicRestrictionsPage instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicRestrictionsPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicRestrictionsPage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
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
