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
    /// BlockPage
    /// </summary>
    [DataContract]
    public partial class BlockPage :  IEquatable<BlockPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockPage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockPage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockPage" /> class.
        /// </summary>
        /// <param name="data">Array of blocks. (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public BlockPage(List<BlockInfoDTO> data = default(List<BlockInfoDTO>), Pagination pagination = default(Pagination))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for BlockPage and cannot be null");
            }
            else
            {
                this.Data = data;
            }

            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new InvalidDataException("pagination is a required property for BlockPage and cannot be null");
            }
            else
            {
                this.Pagination = pagination;
            }

        }

        /// <summary>
        /// Array of blocks.
        /// </summary>
        /// <value>Array of blocks.</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<BlockInfoDTO> Data { get; set; }

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
            sb.Append("class BlockPage {\n");
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
            return this.Equals(input as BlockPage);
        }

        /// <summary>
        /// Returns true if BlockPage instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockPage input)
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
