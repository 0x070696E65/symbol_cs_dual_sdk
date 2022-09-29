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
    /// ServerInfoDTO
    /// </summary>
    [DataContract]
    public partial class ServerInfoDTO :  IEquatable<ServerInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServerInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfoDTO" /> class.
        /// </summary>
        /// <param name="serverInfo">serverInfo (required).</param>
        public ServerInfoDTO(ServerDTO serverInfo = default(ServerDTO))
        {
            // to ensure "serverInfo" is required (not null)
            if (serverInfo == null)
            {
                throw new InvalidDataException("serverInfo is a required property for ServerInfoDTO and cannot be null");
            }
            else
            {
                this.ServerInfo = serverInfo;
            }

        }

        /// <summary>
        /// Gets or Sets ServerInfo
        /// </summary>
        [DataMember(Name="serverInfo", EmitDefaultValue=true)]
        public ServerDTO ServerInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerInfoDTO {\n");
            sb.Append("  ServerInfo: ").Append(ServerInfo).Append("\n");
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
            return this.Equals(input as ServerInfoDTO);
        }

        /// <summary>
        /// Returns true if ServerInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerInfo == input.ServerInfo ||
                    (this.ServerInfo != null &&
                    this.ServerInfo.Equals(input.ServerInfo))
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
                if (this.ServerInfo != null)
                    hashCode = hashCode * 59 + this.ServerInfo.GetHashCode();
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
