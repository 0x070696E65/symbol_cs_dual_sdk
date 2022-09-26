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
    /// NodeKeyLinkNetworkPropertiesDTO
    /// </summary>
    [DataContract]
    public partial class NodeKeyLinkNetworkPropertiesDTO :  IEquatable<NodeKeyLinkNetworkPropertiesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeKeyLinkNetworkPropertiesDTO" /> class.
        /// </summary>
        /// <param name="dummy">to trigger plugin load.</param>
        public NodeKeyLinkNetworkPropertiesDTO(string dummy = default(string))
        {
            this.Dummy = dummy;
        }

        /// <summary>
        /// to trigger plugin load
        /// </summary>
        /// <value>to trigger plugin load</value>
        [DataMember(Name="dummy", EmitDefaultValue=false)]
        public string Dummy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeKeyLinkNetworkPropertiesDTO {\n");
            sb.Append("  Dummy: ").Append(Dummy).Append("\n");
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
            return this.Equals(input as NodeKeyLinkNetworkPropertiesDTO);
        }

        /// <summary>
        /// Returns true if NodeKeyLinkNetworkPropertiesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeKeyLinkNetworkPropertiesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeKeyLinkNetworkPropertiesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dummy == input.Dummy ||
                    (this.Dummy != null &&
                    this.Dummy.Equals(input.Dummy))
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
                if (this.Dummy != null)
                    hashCode = hashCode * 59 + this.Dummy.GetHashCode();
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
