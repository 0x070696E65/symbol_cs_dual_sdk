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
    /// EmbeddedVotingKeyLinkTransactionDTO
    /// </summary>
    [DataContract]
    public partial class EmbeddedVotingKeyLinkTransactionDTO :  IEquatable<EmbeddedVotingKeyLinkTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Gets or Sets LinkAction
        /// </summary>
        [DataMember(Name="linkAction", EmitDefaultValue=true)]
        public LinkActionEnum LinkAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedVotingKeyLinkTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedVotingKeyLinkTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedVotingKeyLinkTransactionDTO" /> class.
        /// </summary>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="linkedPublicKey">32 bytes voting public key. (required).</param>
        /// <param name="startEpoch">Finalization Epoch (required).</param>
        /// <param name="endEpoch">Finalization Epoch (required).</param>
        /// <param name="linkAction">linkAction (required).</param>
        public EmbeddedVotingKeyLinkTransactionDTO(string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string linkedPublicKey = default(string), long startEpoch = default(long), long endEpoch = default(long), LinkActionEnum linkAction = default(LinkActionEnum))
        {
            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "linkedPublicKey" is required (not null)
            if (linkedPublicKey == null)
            {
                throw new InvalidDataException("linkedPublicKey is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.LinkedPublicKey = linkedPublicKey;
            }

            // to ensure "startEpoch" is required (not null)
            if (startEpoch == null)
            {
                throw new InvalidDataException("startEpoch is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.StartEpoch = startEpoch;
            }

            // to ensure "endEpoch" is required (not null)
            if (endEpoch == null)
            {
                throw new InvalidDataException("endEpoch is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.EndEpoch = endEpoch;
            }

            // to ensure "linkAction" is required (not null)
            if (linkAction == null)
            {
                throw new InvalidDataException("linkAction is a required property for EmbeddedVotingKeyLinkTransactionDTO and cannot be null");
            }
            else
            {
                this.LinkAction = linkAction;
            }

        }

        /// <summary>
        /// Public key.
        /// </summary>
        /// <value>Public key.</value>
        [DataMember(Name="signerPublicKey", EmitDefaultValue=true)]
        public string SignerPublicKey { get; set; }

        /// <summary>
        /// Entity version.
        /// </summary>
        /// <value>Entity version.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int _Version { get; set; }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int Type { get; set; }

        /// <summary>
        /// 32 bytes voting public key.
        /// </summary>
        /// <value>32 bytes voting public key.</value>
        [DataMember(Name="linkedPublicKey", EmitDefaultValue=true)]
        public string LinkedPublicKey { get; set; }

        /// <summary>
        /// Finalization Epoch
        /// </summary>
        /// <value>Finalization Epoch</value>
        [DataMember(Name="startEpoch", EmitDefaultValue=true)]
        public long StartEpoch { get; set; }

        /// <summary>
        /// Finalization Epoch
        /// </summary>
        /// <value>Finalization Epoch</value>
        [DataMember(Name="endEpoch", EmitDefaultValue=true)]
        public long EndEpoch { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedVotingKeyLinkTransactionDTO {\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LinkedPublicKey: ").Append(LinkedPublicKey).Append("\n");
            sb.Append("  StartEpoch: ").Append(StartEpoch).Append("\n");
            sb.Append("  EndEpoch: ").Append(EndEpoch).Append("\n");
            sb.Append("  LinkAction: ").Append(LinkAction).Append("\n");
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
            return this.Equals(input as EmbeddedVotingKeyLinkTransactionDTO);
        }

        /// <summary>
        /// Returns true if EmbeddedVotingKeyLinkTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedVotingKeyLinkTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedVotingKeyLinkTransactionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignerPublicKey == input.SignerPublicKey ||
                    (this.SignerPublicKey != null &&
                    this.SignerPublicKey.Equals(input.SignerPublicKey))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.LinkedPublicKey == input.LinkedPublicKey ||
                    (this.LinkedPublicKey != null &&
                    this.LinkedPublicKey.Equals(input.LinkedPublicKey))
                ) && 
                (
                    this.StartEpoch == input.StartEpoch ||
                    (this.StartEpoch != null &&
                    this.StartEpoch.Equals(input.StartEpoch))
                ) && 
                (
                    this.EndEpoch == input.EndEpoch ||
                    (this.EndEpoch != null &&
                    this.EndEpoch.Equals(input.EndEpoch))
                ) && 
                (
                    this.LinkAction == input.LinkAction ||
                    (this.LinkAction != null &&
                    this.LinkAction.Equals(input.LinkAction))
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
                if (this.SignerPublicKey != null)
                    hashCode = hashCode * 59 + this.SignerPublicKey.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LinkedPublicKey != null)
                    hashCode = hashCode * 59 + this.LinkedPublicKey.GetHashCode();
                if (this.StartEpoch != null)
                    hashCode = hashCode * 59 + this.StartEpoch.GetHashCode();
                if (this.EndEpoch != null)
                    hashCode = hashCode * 59 + this.EndEpoch.GetHashCode();
                if (this.LinkAction != null)
                    hashCode = hashCode * 59 + this.LinkAction.GetHashCode();
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
