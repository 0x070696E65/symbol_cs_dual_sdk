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
    /// NamespaceExpiryReceiptDTOAllOf
    /// </summary>
    [DataContract]
    public partial class NamespaceExpiryReceiptDTOAllOf :  IEquatable<NamespaceExpiryReceiptDTOAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceExpiryReceiptDTOAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NamespaceExpiryReceiptDTOAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceExpiryReceiptDTOAllOf" /> class.
        /// </summary>
        /// <param name="artifactId">Namespace identifier. (required).</param>
        public NamespaceExpiryReceiptDTOAllOf(string artifactId = default(string))
        {
            // to ensure "artifactId" is required (not null)
            if (artifactId == null)
            {
                throw new InvalidDataException("artifactId is a required property for NamespaceExpiryReceiptDTOAllOf and cannot be null");
            }
            else
            {
                this.ArtifactId = artifactId;
            }

        }

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
            sb.Append("class NamespaceExpiryReceiptDTOAllOf {\n");
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
            return this.Equals(input as NamespaceExpiryReceiptDTOAllOf);
        }

        /// <summary>
        /// Returns true if NamespaceExpiryReceiptDTOAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NamespaceExpiryReceiptDTOAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceExpiryReceiptDTOAllOf input)
        {
            if (input == null)
                return false;

            return 
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
