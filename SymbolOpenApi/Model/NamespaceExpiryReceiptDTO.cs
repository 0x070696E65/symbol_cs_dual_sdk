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
    /// Receipt stored when a namespace expires.
    /// </summary>
    [DataContract]
    public partial class NamespaceExpiryReceiptDTO :  IEquatable<NamespaceExpiryReceiptDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public ReceiptTypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceExpiryReceiptDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NamespaceExpiryReceiptDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceExpiryReceiptDTO" /> class.
        /// </summary>
        /// <param name="version">Version of the receipt. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="artifactId">Namespace identifier. (required).</param>
        public NamespaceExpiryReceiptDTO(int version = default(int), ReceiptTypeEnum type = default(ReceiptTypeEnum), string artifactId = default(string))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for NamespaceExpiryReceiptDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for NamespaceExpiryReceiptDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "artifactId" is required (not null)
            if (artifactId == null)
            {
                throw new InvalidDataException("artifactId is a required property for NamespaceExpiryReceiptDTO and cannot be null");
            }
            else
            {
                this.ArtifactId = artifactId;
            }

        }

        /// <summary>
        /// Version of the receipt.
        /// </summary>
        /// <value>Version of the receipt.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }


        /// <summary>
        /// Namespace identifier.
        /// </summary>
        /// <value>Namespace identifier.</value>
        [DataMember(Name="artifactId", EmitDefaultValue=true)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamespaceExpiryReceiptDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
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
            return this.Equals(input as NamespaceExpiryReceiptDTO);
        }

        /// <summary>
        /// Returns true if NamespaceExpiryReceiptDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NamespaceExpiryReceiptDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceExpiryReceiptDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ArtifactId == input.ArtifactId ||
                    (this.ArtifactId != null &&
                    this.ArtifactId.Equals(input.ArtifactId))
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
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ArtifactId != null)
                    hashCode = hashCode * 59 + this.ArtifactId.GetHashCode();
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