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
    /// CommunicationTimestampsDTO
    /// </summary>
    [DataContract]
    public partial class CommunicationTimestampsDTO :  IEquatable<CommunicationTimestampsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationTimestampsDTO" /> class.
        /// </summary>
        /// <param name="sendTimestamp">Number of milliseconds elapsed since the creation of the nemesis block. This value can be converted to epoch time by adding the network&#39;s &#39;epochAdjustment&#39;..</param>
        /// <param name="receiveTimestamp">Number of milliseconds elapsed since the creation of the nemesis block. This value can be converted to epoch time by adding the network&#39;s &#39;epochAdjustment&#39;..</param>
        public CommunicationTimestampsDTO(string sendTimestamp = default(string), string receiveTimestamp = default(string))
        {
            this.SendTimestamp = sendTimestamp;
            this.ReceiveTimestamp = receiveTimestamp;
        }

        /// <summary>
        /// Number of milliseconds elapsed since the creation of the nemesis block. This value can be converted to epoch time by adding the network&#39;s &#39;epochAdjustment&#39;.
        /// </summary>
        /// <value>Number of milliseconds elapsed since the creation of the nemesis block. This value can be converted to epoch time by adding the network&#39;s &#39;epochAdjustment&#39;.</value>
        [DataMember(Name="sendTimestamp", EmitDefaultValue=false)]
        public string SendTimestamp { get; set; }

        /// <summary>
        /// Number of milliseconds elapsed since the creation of the nemesis block. This value can be converted to epoch time by adding the network&#39;s &#39;epochAdjustment&#39;.
        /// </summary>
        /// <value>Number of milliseconds elapsed since the creation of the nemesis block. This value can be converted to epoch time by adding the network&#39;s &#39;epochAdjustment&#39;.</value>
        [DataMember(Name="receiveTimestamp", EmitDefaultValue=false)]
        public string ReceiveTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommunicationTimestampsDTO {\n");
            sb.Append("  SendTimestamp: ").Append(SendTimestamp).Append("\n");
            sb.Append("  ReceiveTimestamp: ").Append(ReceiveTimestamp).Append("\n");
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
            return this.Equals(input as CommunicationTimestampsDTO);
        }

        /// <summary>
        /// Returns true if CommunicationTimestampsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CommunicationTimestampsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunicationTimestampsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SendTimestamp == input.SendTimestamp ||
                    (this.SendTimestamp != null &&
                    this.SendTimestamp.Equals(input.SendTimestamp))
                ) && 
                (
                    this.ReceiveTimestamp == input.ReceiveTimestamp ||
                    (this.ReceiveTimestamp != null &&
                    this.ReceiveTimestamp.Equals(input.ReceiveTimestamp))
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
                if (this.SendTimestamp != null)
                    hashCode = hashCode * 59 + this.SendTimestamp.GetHashCode();
                if (this.ReceiveTimestamp != null)
                    hashCode = hashCode * 59 + this.ReceiveTimestamp.GetHashCode();
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
