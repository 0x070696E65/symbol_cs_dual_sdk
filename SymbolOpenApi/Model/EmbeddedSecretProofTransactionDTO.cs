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
    /// EmbeddedSecretProofTransactionDTO
    /// </summary>
    [DataContract]
    public partial class EmbeddedSecretProofTransactionDTO :  IEquatable<EmbeddedSecretProofTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=true)]
        public LockHashAlgorithmEnum HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSecretProofTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedSecretProofTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSecretProofTransactionDTO" /> class.
        /// </summary>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="recipientAddress">Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA  (required).</param>
        /// <param name="secret">secret (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm (required).</param>
        /// <param name="proof">Original random set of bytes. (required).</param>
        public EmbeddedSecretProofTransactionDTO(string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string recipientAddress = default(string), string secret = default(string), LockHashAlgorithmEnum hashAlgorithm = default(LockHashAlgorithmEnum), string proof = default(string))
        {
            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new InvalidDataException("recipientAddress is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.RecipientAddress = recipientAddress;
            }

            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new InvalidDataException("secret is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.Secret = secret;
            }

            // to ensure "hashAlgorithm" is required (not null)
            if (hashAlgorithm == null)
            {
                throw new InvalidDataException("hashAlgorithm is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.HashAlgorithm = hashAlgorithm;
            }

            // to ensure "proof" is required (not null)
            if (proof == null)
            {
                throw new InvalidDataException("proof is a required property for EmbeddedSecretProofTransactionDTO and cannot be null");
            }
            else
            {
                this.Proof = proof;
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
        /// Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA 
        /// </summary>
        /// <value>Address expressed in Base32 format. If the bit 0 of byte 0 is not set (like in 0x90), then it is a regular address. Example: TAOXUJOTTW3W5XTBQMQEX3SQNA6MCUVGXLXR3TA.  Otherwise (e.g. 0x91) it represents a namespace id which starts at byte 1. Example: THBIMC3THGH5RUYAAAAAAAAAAAAAAAAAAAAAAAA </value>
        [DataMember(Name="recipientAddress", EmitDefaultValue=true)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=true)]
        public string Secret { get; set; }


        /// <summary>
        /// Original random set of bytes.
        /// </summary>
        /// <value>Original random set of bytes.</value>
        [DataMember(Name="proof", EmitDefaultValue=true)]
        public string Proof { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedSecretProofTransactionDTO {\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
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
            return this.Equals(input as EmbeddedSecretProofTransactionDTO);
        }

        /// <summary>
        /// Returns true if EmbeddedSecretProofTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedSecretProofTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedSecretProofTransactionDTO input)
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
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
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
                if (this.RecipientAddress != null)
                    hashCode = hashCode * 59 + this.RecipientAddress.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.HashAlgorithm != null)
                    hashCode = hashCode * 59 + this.HashAlgorithm.GetHashCode();
                if (this.Proof != null)
                    hashCode = hashCode * 59 + this.Proof.GetHashCode();
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
