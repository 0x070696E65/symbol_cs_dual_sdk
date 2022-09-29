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
    /// A resolution statement keeps the relation between a namespace alias used in a transaction and the real address or mosaicId. 
    /// </summary>
    [DataContract]
    public partial class ResolutionStatementInfoDTO :  IEquatable<ResolutionStatementInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolutionStatementInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResolutionStatementInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolutionStatementInfoDTO" /> class.
        /// </summary>
        /// <param name="id">Internal resource identifier. (required).</param>
        /// <param name="meta">meta (required).</param>
        /// <param name="statement">statement (required).</param>
        public ResolutionStatementInfoDTO(string id = default(string), StatementMetaDTO meta = default(StatementMetaDTO), ResolutionStatementDTO statement = default(ResolutionStatementDTO))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ResolutionStatementInfoDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "meta" is required (not null)
            if (meta == null)
            {
                throw new InvalidDataException("meta is a required property for ResolutionStatementInfoDTO and cannot be null");
            }
            else
            {
                this.Meta = meta;
            }

            // to ensure "statement" is required (not null)
            if (statement == null)
            {
                throw new InvalidDataException("statement is a required property for ResolutionStatementInfoDTO and cannot be null");
            }
            else
            {
                this.Statement = statement;
            }

        }

        /// <summary>
        /// Internal resource identifier.
        /// </summary>
        /// <value>Internal resource identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=true)]
        public StatementMetaDTO Meta { get; set; }

        /// <summary>
        /// Gets or Sets Statement
        /// </summary>
        [DataMember(Name="statement", EmitDefaultValue=true)]
        public ResolutionStatementDTO Statement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResolutionStatementInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Statement: ").Append(Statement).Append("\n");
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
            return this.Equals(input as ResolutionStatementInfoDTO);
        }

        /// <summary>
        /// Returns true if ResolutionStatementInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ResolutionStatementInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResolutionStatementInfoDTO input)
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
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Statement == input.Statement ||
                    (this.Statement != null &&
                    this.Statement.Equals(input.Statement))
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
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Statement != null)
                    hashCode = hashCode * 59 + this.Statement.GetHashCode();
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
