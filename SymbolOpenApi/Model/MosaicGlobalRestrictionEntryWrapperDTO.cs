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
    /// MosaicGlobalRestrictionEntryWrapperDTO
    /// </summary>
    [DataContract]
    public partial class MosaicGlobalRestrictionEntryWrapperDTO :  IEquatable<MosaicGlobalRestrictionEntryWrapperDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name="entryType", EmitDefaultValue=true)]
        public MosaicRestrictionEntryTypeEnum EntryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicGlobalRestrictionEntryWrapperDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicGlobalRestrictionEntryWrapperDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicGlobalRestrictionEntryWrapperDTO" /> class.
        /// </summary>
        /// <param name="version">The version of the state (required).</param>
        /// <param name="compositeHash">compositeHash (required).</param>
        /// <param name="entryType">entryType (required).</param>
        /// <param name="mosaicId">Mosaic identifier. (required).</param>
        /// <param name="restrictions">restrictions (required).</param>
        public MosaicGlobalRestrictionEntryWrapperDTO(int version = default(int), string compositeHash = default(string), MosaicRestrictionEntryTypeEnum entryType = default(MosaicRestrictionEntryTypeEnum), string mosaicId = default(string), List<MosaicGlobalRestrictionEntryDTO> restrictions = default(List<MosaicGlobalRestrictionEntryDTO>))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for MosaicGlobalRestrictionEntryWrapperDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "compositeHash" is required (not null)
            if (compositeHash == null)
            {
                throw new InvalidDataException("compositeHash is a required property for MosaicGlobalRestrictionEntryWrapperDTO and cannot be null");
            }
            else
            {
                this.CompositeHash = compositeHash;
            }

            // to ensure "entryType" is required (not null)
            if (entryType == null)
            {
                throw new InvalidDataException("entryType is a required property for MosaicGlobalRestrictionEntryWrapperDTO and cannot be null");
            }
            else
            {
                this.EntryType = entryType;
            }

            // to ensure "mosaicId" is required (not null)
            if (mosaicId == null)
            {
                throw new InvalidDataException("mosaicId is a required property for MosaicGlobalRestrictionEntryWrapperDTO and cannot be null");
            }
            else
            {
                this.MosaicId = mosaicId;
            }

            // to ensure "restrictions" is required (not null)
            if (restrictions == null)
            {
                throw new InvalidDataException("restrictions is a required property for MosaicGlobalRestrictionEntryWrapperDTO and cannot be null");
            }
            else
            {
                this.Restrictions = restrictions;
            }

        }

        /// <summary>
        /// The version of the state
        /// </summary>
        /// <value>The version of the state</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets CompositeHash
        /// </summary>
        [DataMember(Name="compositeHash", EmitDefaultValue=true)]
        public string CompositeHash { get; set; }


        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        [DataMember(Name="mosaicId", EmitDefaultValue=true)]
        public string MosaicId { get; set; }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name="restrictions", EmitDefaultValue=true)]
        public List<MosaicGlobalRestrictionEntryDTO> Restrictions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicGlobalRestrictionEntryWrapperDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  CompositeHash: ").Append(CompositeHash).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  MosaicId: ").Append(MosaicId).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
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
            return this.Equals(input as MosaicGlobalRestrictionEntryWrapperDTO);
        }

        /// <summary>
        /// Returns true if MosaicGlobalRestrictionEntryWrapperDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicGlobalRestrictionEntryWrapperDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicGlobalRestrictionEntryWrapperDTO input)
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
                    this.CompositeHash == input.CompositeHash ||
                    (this.CompositeHash != null &&
                    this.CompositeHash.Equals(input.CompositeHash))
                ) && 
                (
                    this.EntryType == input.EntryType ||
                    (this.EntryType != null &&
                    this.EntryType.Equals(input.EntryType))
                ) && 
                (
                    this.MosaicId == input.MosaicId ||
                    (this.MosaicId != null &&
                    this.MosaicId.Equals(input.MosaicId))
                ) && 
                (
                    this.Restrictions == input.Restrictions ||
                    this.Restrictions != null &&
                    input.Restrictions != null &&
                    this.Restrictions.SequenceEqual(input.Restrictions)
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
                if (this.CompositeHash != null)
                    hashCode = hashCode * 59 + this.CompositeHash.GetHashCode();
                if (this.EntryType != null)
                    hashCode = hashCode * 59 + this.EntryType.GetHashCode();
                if (this.MosaicId != null)
                    hashCode = hashCode * 59 + this.MosaicId.GetHashCode();
                if (this.Restrictions != null)
                    hashCode = hashCode * 59 + this.Restrictions.GetHashCode();
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
