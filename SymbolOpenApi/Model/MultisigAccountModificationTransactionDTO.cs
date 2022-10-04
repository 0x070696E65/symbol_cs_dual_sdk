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
    /// Transaction to create or modify a multisig account.
    /// </summary>
    [DataContract]
    public partial class MultisigAccountModificationTransactionDTO :  IEquatable<MultisigAccountModificationTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=true)]
        public NetworkTypeEnum Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultisigAccountModificationTransactionDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultisigAccountModificationTransactionDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultisigAccountModificationTransactionDTO" /> class.
        /// </summary>
        /// <param name="size">A number that allows uint 32 values. (required).</param>
        /// <param name="signature">Entity&#39;s signature generated by the signer. (required).</param>
        /// <param name="signerPublicKey">Public key. (required).</param>
        /// <param name="version">Entity version. (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="maxFee">Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative). (required).</param>
        /// <param name="deadline">Duration expressed in number of blocks. (required).</param>
        /// <param name="minRemovalDelta">Number of signatures needed to remove a cosignatory. If we are modifying an existing multisig account, this indicates the relative change of the minimum cosignatories.  (required).</param>
        /// <param name="minApprovalDelta">Number of signatures needed to approve a transaction. If we are modifying an existing multisig account, this indicates the relative change of the minimum cosignatories.  (required).</param>
        /// <param name="addressAdditions">Array of cosignatory accounts to add. (required).</param>
        /// <param name="addressDeletions">Array of cosignatory accounts to delete. (required).</param>
        public MultisigAccountModificationTransactionDTO(long size = default(long), string signature = default(string), string signerPublicKey = default(string), int version = default(int), NetworkTypeEnum network = default(NetworkTypeEnum), int type = default(int), string maxFee = default(string), string deadline = default(string), int minRemovalDelta = default(int), int minApprovalDelta = default(int), List<string> addressAdditions = default(List<string>), List<string> addressDeletions = default(List<string>))
        {
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.Size = size;
            }

            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }

            // to ensure "signerPublicKey" is required (not null)
            if (signerPublicKey == null)
            {
                throw new InvalidDataException("signerPublicKey is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.SignerPublicKey = signerPublicKey;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.Network = network;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "maxFee" is required (not null)
            if (maxFee == null)
            {
                throw new InvalidDataException("maxFee is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.MaxFee = maxFee;
            }

            // to ensure "deadline" is required (not null)
            if (deadline == null)
            {
                throw new InvalidDataException("deadline is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.Deadline = deadline;
            }

            // to ensure "minRemovalDelta" is required (not null)
            if (minRemovalDelta == null)
            {
                throw new InvalidDataException("minRemovalDelta is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.MinRemovalDelta = minRemovalDelta;
            }

            // to ensure "minApprovalDelta" is required (not null)
            if (minApprovalDelta == null)
            {
                throw new InvalidDataException("minApprovalDelta is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.MinApprovalDelta = minApprovalDelta;
            }

            // to ensure "addressAdditions" is required (not null)
            if (addressAdditions == null)
            {
                throw new InvalidDataException("addressAdditions is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.AddressAdditions = addressAdditions;
            }

            // to ensure "addressDeletions" is required (not null)
            if (addressDeletions == null)
            {
                throw new InvalidDataException("addressDeletions is a required property for MultisigAccountModificationTransactionDTO and cannot be null");
            }
            else
            {
                this.AddressDeletions = addressDeletions;
            }

        }

        /// <summary>
        /// A number that allows uint 32 values.
        /// </summary>
        /// <value>A number that allows uint 32 values.</value>
        [DataMember(Name="size", EmitDefaultValue=true)]
        public long Size { get; set; }

        /// <summary>
        /// Entity&#39;s signature generated by the signer.
        /// </summary>
        /// <value>Entity&#39;s signature generated by the signer.</value>
        [DataMember(Name="signature", EmitDefaultValue=true)]
        public string Signature { get; set; }

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
        /// Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).
        /// </summary>
        /// <value>Absolute amount. An amount of 123456789 (absolute) for a mosaic with divisibility 6 means 123.456789 (relative).</value>
        [DataMember(Name="maxFee", EmitDefaultValue=true)]
        public string MaxFee { get; set; }

        /// <summary>
        /// Duration expressed in number of blocks.
        /// </summary>
        /// <value>Duration expressed in number of blocks.</value>
        [DataMember(Name="deadline", EmitDefaultValue=true)]
        public string Deadline { get; set; }

        /// <summary>
        /// Number of signatures needed to remove a cosignatory. If we are modifying an existing multisig account, this indicates the relative change of the minimum cosignatories. 
        /// </summary>
        /// <value>Number of signatures needed to remove a cosignatory. If we are modifying an existing multisig account, this indicates the relative change of the minimum cosignatories. </value>
        [DataMember(Name="minRemovalDelta", EmitDefaultValue=true)]
        public int MinRemovalDelta { get; set; }

        /// <summary>
        /// Number of signatures needed to approve a transaction. If we are modifying an existing multisig account, this indicates the relative change of the minimum cosignatories. 
        /// </summary>
        /// <value>Number of signatures needed to approve a transaction. If we are modifying an existing multisig account, this indicates the relative change of the minimum cosignatories. </value>
        [DataMember(Name="minApprovalDelta", EmitDefaultValue=true)]
        public int MinApprovalDelta { get; set; }

        /// <summary>
        /// Array of cosignatory accounts to add.
        /// </summary>
        /// <value>Array of cosignatory accounts to add.</value>
        [DataMember(Name="addressAdditions", EmitDefaultValue=true)]
        public List<string> AddressAdditions { get; set; }

        /// <summary>
        /// Array of cosignatory accounts to delete.
        /// </summary>
        /// <value>Array of cosignatory accounts to delete.</value>
        [DataMember(Name="addressDeletions", EmitDefaultValue=true)]
        public List<string> AddressDeletions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultisigAccountModificationTransactionDTO {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignerPublicKey: ").Append(SignerPublicKey).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxFee: ").Append(MaxFee).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  MinRemovalDelta: ").Append(MinRemovalDelta).Append("\n");
            sb.Append("  MinApprovalDelta: ").Append(MinApprovalDelta).Append("\n");
            sb.Append("  AddressAdditions: ").Append(AddressAdditions).Append("\n");
            sb.Append("  AddressDeletions: ").Append(AddressDeletions).Append("\n");
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
            return this.Equals(input as MultisigAccountModificationTransactionDTO);
        }

        /// <summary>
        /// Returns true if MultisigAccountModificationTransactionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MultisigAccountModificationTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultisigAccountModificationTransactionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
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
                    this.MaxFee == input.MaxFee ||
                    (this.MaxFee != null &&
                    this.MaxFee.Equals(input.MaxFee))
                ) && 
                (
                    this.Deadline == input.Deadline ||
                    (this.Deadline != null &&
                    this.Deadline.Equals(input.Deadline))
                ) && 
                (
                    this.MinRemovalDelta == input.MinRemovalDelta ||
                    (this.MinRemovalDelta != null &&
                    this.MinRemovalDelta.Equals(input.MinRemovalDelta))
                ) && 
                (
                    this.MinApprovalDelta == input.MinApprovalDelta ||
                    (this.MinApprovalDelta != null &&
                    this.MinApprovalDelta.Equals(input.MinApprovalDelta))
                ) && 
                (
                    this.AddressAdditions == input.AddressAdditions ||
                    this.AddressAdditions != null &&
                    input.AddressAdditions != null &&
                    this.AddressAdditions.SequenceEqual(input.AddressAdditions)
                ) && 
                (
                    this.AddressDeletions == input.AddressDeletions ||
                    this.AddressDeletions != null &&
                    input.AddressDeletions != null &&
                    this.AddressDeletions.SequenceEqual(input.AddressDeletions)
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.SignerPublicKey != null)
                    hashCode = hashCode * 59 + this.SignerPublicKey.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MaxFee != null)
                    hashCode = hashCode * 59 + this.MaxFee.GetHashCode();
                if (this.Deadline != null)
                    hashCode = hashCode * 59 + this.Deadline.GetHashCode();
                if (this.MinRemovalDelta != null)
                    hashCode = hashCode * 59 + this.MinRemovalDelta.GetHashCode();
                if (this.MinApprovalDelta != null)
                    hashCode = hashCode * 59 + this.MinApprovalDelta.GetHashCode();
                if (this.AddressAdditions != null)
                    hashCode = hashCode * 59 + this.AddressAdditions.GetHashCode();
                if (this.AddressDeletions != null)
                    hashCode = hashCode * 59 + this.AddressDeletions.GetHashCode();
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