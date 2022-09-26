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
    /// MessageGroup
    /// </summary>
    [DataContract]
    public partial class MessageGroup :  IEquatable<MessageGroup>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="stage", EmitDefaultValue=true)]
        public StageEnum Stage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGroup" /> class.
        /// </summary>
        /// <param name="stage">stage (required).</param>
        /// <param name="height">Height of the blockchain. (required).</param>
        /// <param name="hashes">hashes (required).</param>
        /// <param name="signatures">signatures (required).</param>
        public MessageGroup(StageEnum stage = default(StageEnum), string height = default(string), List<string> hashes = default(List<string>), List<BmTreeSignature> signatures = default(List<BmTreeSignature>))
        {
            // to ensure "stage" is required (not null)
            if (stage == null)
            {
                throw new InvalidDataException("stage is a required property for MessageGroup and cannot be null");
            }
            else
            {
                this.Stage = stage;
            }

            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new InvalidDataException("height is a required property for MessageGroup and cannot be null");
            }
            else
            {
                this.Height = height;
            }

            // to ensure "hashes" is required (not null)
            if (hashes == null)
            {
                throw new InvalidDataException("hashes is a required property for MessageGroup and cannot be null");
            }
            else
            {
                this.Hashes = hashes;
            }

            // to ensure "signatures" is required (not null)
            if (signatures == null)
            {
                throw new InvalidDataException("signatures is a required property for MessageGroup and cannot be null");
            }
            else
            {
                this.Signatures = signatures;
            }

        }


        /// <summary>
        /// Height of the blockchain.
        /// </summary>
        /// <value>Height of the blockchain.</value>
        [DataMember(Name="height", EmitDefaultValue=true)]
        public string Height { get; set; }

        /// <summary>
        /// Gets or Sets Hashes
        /// </summary>
        [DataMember(Name="hashes", EmitDefaultValue=true)]
        public List<string> Hashes { get; set; }

        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        [DataMember(Name="signatures", EmitDefaultValue=true)]
        public List<BmTreeSignature> Signatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGroup {\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Hashes: ").Append(Hashes).Append("\n");
            sb.Append("  Signatures: ").Append(Signatures).Append("\n");
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
            return this.Equals(input as MessageGroup);
        }

        /// <summary>
        /// Returns true if MessageGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Hashes == input.Hashes ||
                    this.Hashes != null &&
                    input.Hashes != null &&
                    this.Hashes.SequenceEqual(input.Hashes)
                ) && 
                (
                    this.Signatures == input.Signatures ||
                    this.Signatures != null &&
                    input.Signatures != null &&
                    this.Signatures.SequenceEqual(input.Signatures)
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
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Hashes != null)
                    hashCode = hashCode * 59 + this.Hashes.GetHashCode();
                if (this.Signatures != null)
                    hashCode = hashCode * 59 + this.Signatures.GetHashCode();
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
