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
    /// MosaicIds
    /// </summary>
    [DataContract]
    public partial class MosaicIds :  IEquatable<MosaicIds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MosaicIds" /> class.
        /// </summary>
        /// <param name="mosaicIds">Array of mosaic identifiers..</param>
        public MosaicIds(List<string> mosaicIds = default(List<string>))
        {
            this._MosaicIds = mosaicIds;
        }

        /// <summary>
        /// Array of mosaic identifiers.
        /// </summary>
        /// <value>Array of mosaic identifiers.</value>
        [DataMember(Name="mosaicIds", EmitDefaultValue=false)]
        public List<string> _MosaicIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MosaicIds {\n");
            sb.Append("  _MosaicIds: ").Append(_MosaicIds).Append("\n");
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
            return this.Equals(input as MosaicIds);
        }

        /// <summary>
        /// Returns true if MosaicIds instances are equal
        /// </summary>
        /// <param name="input">Instance of MosaicIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MosaicIds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._MosaicIds == input._MosaicIds ||
                    this._MosaicIds != null &&
                    input._MosaicIds != null &&
                    this._MosaicIds.SequenceEqual(input._MosaicIds)
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
                if (this._MosaicIds != null)
                    hashCode = hashCode * 59 + this._MosaicIds.GetHashCode();
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
