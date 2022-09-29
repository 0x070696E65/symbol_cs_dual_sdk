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
    /// MosaicDefinitionTransactionBodyDTO
    /// </summary>
    [DataContract]
    public partial class MosaicDefinitionTransactionBodyDTO :  IEquatable<MosaicDefinitionTransactionBodyDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicDefinitionTransactionBodyDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicDefinitionTransactionBodyDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicDefinitionTransactionBodyDTO" /> class.
        /// </summary>
        /// <param name="id">Mosaic identifier. (required).</param>
        /// <param name="duration">Duration expressed in number of blocks. (required).</param>
        /// <param name="nonce">A number that allows uint 32 values. (required).</param>
        /// <param name="flags">- 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user.  (required).</param>
        /// <param name="divisibility">Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6.  (required).</param>
        public MosaicDefinitionTransactionBodyDTO(string id = default(string), string duration = default(string), long nonce = default(long), int flags = default(int), int divisibility = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MosaicDefinitionTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for MosaicDefinitionTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }

            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new InvalidDataException("nonce is a required property for MosaicDefinitionTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Nonce = nonce;
            }

            // to ensure "flags" is required (not null)
            if (flags == null)
            {
                throw new InvalidDataException("flags is a required property for MosaicDefinitionTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Flags = flags;
            }

            // to ensure "divisibility" is required (not null)
            if (divisibility == null)
            {
                throw new InvalidDataException("divisibility is a required property for MosaicDefinitionTransactionBodyDTO and cannot be null");
            }
            else
            {
                this.Divisibility = divisibility;
            }

        }

        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        [DataMember(Name="duration", EmitDefaultValue=true)]
        public string Duration { get; set; }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="nonce", EmitDefaultValue=true)]
        public long Nonce { get; set; }

        /// <summary>
        /// - 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user. 
        /// </summary>
        /// <value>- 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user. </value>
        [DataMember(Name="flags", EmitDefaultValue=true)]
        public int Flags { get; set; }

        /// <summary>
        /// Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6. 
        /// </summary>
        /// <value>Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6. </value>
        [DataMember(Name="divisibility", EmitDefaultValue=true)]
        public int Divisibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicDefinitionTransactionBodyDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Divisibility: ").Append(Divisibility).Append("\n");
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
            return this.Equals(input as MosaicDefinitionTransactionBodyDTO);
        }

        /// <summary>
        /// Returns true if MosaicDefinitionTransactionBodyDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicDefinitionTransactionBodyDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicDefinitionTransactionBodyDTO input)
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
                ) && 
                (
                    this.Divisibility == input.Divisibility ||
                    (this.Divisibility != null &&
                    this.Divisibility.Equals(input.Divisibility))
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Divisibility != null)
                    hashCode = hashCode * 59 + this.Divisibility.GetHashCode();
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
