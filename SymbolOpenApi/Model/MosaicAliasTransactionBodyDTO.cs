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
    /// MosaicAliasTransactionBodyDTO
    /// </summary>
    [DataContract]
    public partial class MosaicAliasTransactionBodyDTO :  IEquatable<MosaicAliasTransactionBodyDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AliasAction
        /// </summary>
        [DataMember(Name="aliasAction", EmitDefaultValue=true)]
        public AliasActionEnum AliasAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicAliasTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicAliasTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicAliasTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="namespaceId">Namespace identifier. (required).</param>
        /// <param name="mosaicId">Mosaic identifier. (required).</param>
        /// <param name="aliasAction">aliasAction (required).</param>
        public MosaicAliasTransactionBodyDTO(string namespaceId = default(string), string mosaicId = default(string), AliasActionEnum aliasAction = default(AliasActionEnum))
        {
            // to ensure "namespaceId" is required (not null)
            if (namespaceId == null)
            {
                throw new InvalidDataException("namespaceId is a required property for MosaicAliasTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.NamespaceId = namespaceId;
            }

            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for MosaicAliasTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "aliasAction" is required (not null)
            if (aliasAction == null)
            {
                throw new InvalidDataException("aliasAction is a required property for MosaicAliasTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.AliasAction = aliasAction;
            }

        }

        /// <summary>
        /// Namespace identifier.
        /// </summary>
        /// <value>Namespace identifier.</value>
        [DataMember(Name="namespaceId", EmitDefaultValue=true)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        [DataMember(Name="mosaicId", EmitDefaultValue=true)]
        public string MosaicId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicAliasTransactionBodyDTO {\n");
            sb.Append("  NamespaceId: ").Append(NamespaceId).Append("\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  AliasAction: ").Append(AliasAction).Append("\n");
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
            return this.Equals(input as MosaicAliasTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if MosaicAliasTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicAliasTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicAliasTransactionBodyDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NamespaceId == input.NamespaceId ||
                    (this.NamespaceId != null &&
                    this.NamespaceId.Equals(input.NamespaceId))
                ) && 
                (
                    this.MosaicId == input.MosaicId ||
                    (this.MosaicId != null &&
                    this.MosaicId.Equals(input.MosaicId))
                ) && 
                (
                    this.AliasAction == input.AliasAction ||
                    (this.AliasAction != null &&
                    this.AliasAction.Equals(input.AliasAction))
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
                if (this.NamespaceId != null)
                    hashCode = hashCode * 59 + this.NamespaceId.GetHashCode();
                if (this.MosaicId != null)
                    hashCode = hashCode * 59 + this.MosaicId.GetHashCode();
                if (this.AliasAction != null)
                    hashCode = hashCode * 59 + this.AliasAction.GetHashCode();
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
