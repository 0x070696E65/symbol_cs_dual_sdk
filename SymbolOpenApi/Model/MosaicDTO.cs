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
    /// MosaicDTO
    /// </summary>
    [DataContract]
    public partial class MosaicDTO :  IEquatable<MosaicDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MosaicDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicDTO" /> class.
        /// </summary>
        /// <param name="version">The version of the state (required).</param>
        /// <param name="id">Mosaic identifier. (required).</param>
        /// <param name="supply">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="startHeight">Height of the blockchain. (required).</param>
        /// <param name="ownerAddress">Address encoded using a 32-character set. (required).</param>
        /// <param name="revision">A number that allows uint 32 values. (required).</param>
        /// <param name="flags">- 0x00 (none) - No flags present. - 0x01 (supplyMutable) - Mosaic supports supply changes even when mosaic owner owns partial supply. - 0x02 (transferable) - Mosaic supports transfers between arbitrary accounts. When not set, mosaic can only be transferred to and from mosaic owner. - 0x04 (restrictable) - Mosaic supports custom restrictions configured by mosaic owner. - 0x08 (revokable) - Mosaic allows creator to revoke balances from another user.  (required).</param>
        /// <param name="divisibility">Determines up to what decimal place the mosaic can be divided. Divisibility of 3 means that a mosaic can be divided into smallest parts of 0.001 mosaics. The divisibility must be in the range of 0 and 6.  (required).</param>
        /// <param name="duration">Duration expressed in number of blocks. (required).</param>
        public MosaicDTO(int version = default(int), string id = default(string), string supply = default(string), string startHeight = default(string), string ownerAddress = default(string), long revision = default(long), int flags = default(int), int divisibility = default(int), string duration = default(string))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "supply" is required (not null)
            if (supply == null)
            {
                throw new InvalidDataException("supply is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.Supply = supply;
            }

            // to ensure "startHeight" is required (not null)
            if (startHeight == null)
            {
                throw new InvalidDataException("startHeight is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.StartHeight = startHeight;
            }

            // to ensure "ownerAddress" is required (not null)
            if (ownerAddress == null)
            {
                throw new InvalidDataException("ownerAddress is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.OwnerAddress = ownerAddress;
            }

            // to ensure "revision" is required (not null)
            if (revision == null)
            {
                throw new InvalidDataException("revision is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.Revision = revision;
            }

            // to ensure "flags" is required (not null)
            if (flags == null)
            {
                throw new InvalidDataException("flags is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.Flags = flags;
            }

            // to ensure "divisibility" is required (not null)
            if (divisibility == null)
            {
                throw new InvalidDataException("divisibility is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.Divisibility = divisibility;
            }

            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for MosaicDTO and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }

        }

        /// <summary>
        /// The version of the state
        /// </summary>
        /// <value>The version of the state</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }

        /// <summary>
        /// Mosaic identifier.
        /// </summary>
        /// <value>Mosaic identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        [DataMember(Name="supply", EmitDefaultValue=true)]
        public string Supply { get; set; }

        /// <summary>
        /// Height of the blockchain.
        /// </summary>
        /// <value>Height of the blockchain.</value>
        [DataMember(Name="startHeight", EmitDefaultValue=true)]
        public string StartHeight { get; set; }

        /// <summary>
        /// Address encoded using a 32-character set.
        /// </summary>
        /// <value>Address encoded using a 32-character set.</value>
        [DataMember(Name="ownerAddress", EmitDefaultValue=true)]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="revision", EmitDefaultValue=true)]
        public long Revision { get; set; }

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
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        [DataMember(Name="duration", EmitDefaultValue=true)]
        public string Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicDTO {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Supply: ").Append(Supply).Append("\n");
            sb.Append("  StartHeight: ").Append(StartHeight).Append("\n");
            sb.Append("  OwnerAddress: ").Append(OwnerAddress).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Divisibility: ").Append(Divisibility).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as MosaicDTO);
        }

        /// <summary>
        /// Returns true if MosaicDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicDTO input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Supply == input.Supply ||
                    (this.Supply != null &&
                    this.Supply.Equals(input.Supply))
                ) && 
                (
                    this.StartHeight == input.StartHeight ||
                    (this.StartHeight != null &&
                    this.StartHeight.Equals(input.StartHeight))
                ) && 
                (
                    this.OwnerAddress == input.OwnerAddress ||
                    (this.OwnerAddress != null &&
                    this.OwnerAddress.Equals(input.OwnerAddress))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
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
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Supply != null)
                    hashCode = hashCode * 59 + this.Supply.GetHashCode();
                if (this.StartHeight != null)
                    hashCode = hashCode * 59 + this.StartHeight.GetHashCode();
                if (this.OwnerAddress != null)
                    hashCode = hashCode * 59 + this.OwnerAddress.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Divisibility != null)
                    hashCode = hashCode * 59 + this.Divisibility.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
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