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
    /// ServerDTO
    /// </summary>
    [DataContract]
    public partial class ServerDTO :  IEquatable<ServerDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServerDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerDTO" /> class.
        /// </summary>
        /// <param name="restVersion">catapult-rest component version. (required).</param>
        /// <param name="sdkVersion">catapult-sdk component version. (required).</param>
        /// <param name="deployment">deployment (required).</param>
        public ServerDTO(string restVersion = default(string), string sdkVersion = default(string), DeploymentDTO deployment = default(DeploymentDTO))
        {
            // to ensure "restVersion" is required (not null)
            if (restVersion == null)
            {
                throw new InvalidDataException("restVersion is a required property for ServerDTO and cannot be null");
            }
            else
            {
                this.RestVersion = restVersion;
            }

            // to ensure "sdkVersion" is required (not null)
            if (sdkVersion == null)
            {
                throw new InvalidDataException("sdkVersion is a required property for ServerDTO and cannot be null");
            }
            else
            {
                this.SdkVersion = sdkVersion;
            }

            // to ensure "deployment" is required (not null)
            if (deployment == null)
            {
                throw new InvalidDataException("deployment is a required property for ServerDTO and cannot be null");
            }
            else
            {
                this.Deployment = deployment;
            }

        }

        /// <summary>
        /// catapult-rest component version.
        /// </summary>
        /// <value>catapult-rest component version.</value>
        [DataMember(Name="restVersion", EmitDefaultValue=true)]
        public string RestVersion { get; set; }

        /// <summary>
        /// catapult-sdk component version.
        /// </summary>
        /// <value>catapult-sdk component version.</value>
        [DataMember(Name="sdkVersion", EmitDefaultValue=true)]
        public string SdkVersion { get; set; }

        /// <summary>
        /// Gets or Sets Deployment
        /// </summary>
        [DataMember(Name="deployment", EmitDefaultValue=true)]
        public DeploymentDTO Deployment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerDTO {\n");
            sb.Append("  RestVersion: ").Append(RestVersion).Append("\n");
            sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
            sb.Append("  Deployment: ").Append(Deployment).Append("\n");
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
            return this.Equals(input as ServerDTO);
        }

        /// <summary>
        /// Returns true if ServerDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestVersion == input.RestVersion ||
                    (this.RestVersion != null &&
                    this.RestVersion.Equals(input.RestVersion))
                ) && 
                (
                    this.SdkVersion == input.SdkVersion ||
                    (this.SdkVersion != null &&
                    this.SdkVersion.Equals(input.SdkVersion))
                ) && 
                (
                    this.Deployment == input.Deployment ||
                    (this.Deployment != null &&
                    this.Deployment.Equals(input.Deployment))
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
                if (this.RestVersion != null)
                    hashCode = hashCode * 59 + this.RestVersion.GetHashCode();
                if (this.SdkVersion != null)
                    hashCode = hashCode * 59 + this.SdkVersion.GetHashCode();
                if (this.Deployment != null)
                    hashCode = hashCode * 59 + this.Deployment.GetHashCode();
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
