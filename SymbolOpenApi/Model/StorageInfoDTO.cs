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
    /// StorageInfoDTO
    /// </summary>
    [DataContract]
    public partial class StorageInfoDTO :  IEquatable<StorageInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageInfoDTO" /> class.
        /// </summary>
        /// <param name="numBlocks">Number of blocks stored. (required).</param>
        /// <param name="numTransactions">Number of transactions stored. (required).</param>
        /// <param name="numAccounts">Number of accounts created. (required).</param>
        public StorageInfoDTO(int numBlocks = default(int), int numTransactions = default(int), int numAccounts = default(int))
        {
            // to ensure "numBlocks" is required (not null)
            if (numBlocks == null)
            {
                throw new InvalidDataException("numBlocks is a required property for StorageInfoDTO and cannot be null");
            }
            else
            {
                this.NumBlocks = numBlocks;
            }

            // to ensure "numTransactions" is required (not null)
            if (numTransactions == null)
            {
                throw new InvalidDataException("numTransactions is a required property for StorageInfoDTO and cannot be null");
            }
            else
            {
                this.NumTransactions = numTransactions;
            }

            // to ensure "numAccounts" is required (not null)
            if (numAccounts == null)
            {
                throw new InvalidDataException("numAccounts is a required property for StorageInfoDTO and cannot be null");
            }
            else
            {
                this.NumAccounts = numAccounts;
            }

        }

        /// <summary>
        /// Number of blocks stored.
        /// </summary>
        /// <value>Number of blocks stored.</value>
        [DataMember(Name="numBlocks", EmitDefaultValue=true)]
        public int NumBlocks { get; set; }

        /// <summary>
        /// Number of transactions stored.
        /// </summary>
        /// <value>Number of transactions stored.</value>
        [DataMember(Name="numTransactions", EmitDefaultValue=true)]
        public int NumTransactions { get; set; }

        /// <summary>
        /// Number of accounts created.
        /// </summary>
        /// <value>Number of accounts created.</value>
        [DataMember(Name="numAccounts", EmitDefaultValue=true)]
        public int NumAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageInfoDTO {\n");
            sb.Append("  NumBlocks: ").Append(NumBlocks).Append("\n");
            sb.Append("  NumTransactions: ").Append(NumTransactions).Append("\n");
            sb.Append("  NumAccounts: ").Append(NumAccounts).Append("\n");
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
            return this.Equals(input as StorageInfoDTO);
        }

        /// <summary>
        /// Returns true if StorageInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumBlocks == input.NumBlocks ||
                    (this.NumBlocks != null &&
                    this.NumBlocks.Equals(input.NumBlocks))
                ) && 
                (
                    this.NumTransactions == input.NumTransactions ||
                    (this.NumTransactions != null &&
                    this.NumTransactions.Equals(input.NumTransactions))
                ) && 
                (
                    this.NumAccounts == input.NumAccounts ||
                    (this.NumAccounts != null &&
                    this.NumAccounts.Equals(input.NumAccounts))
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
                if (this.NumBlocks != null)
                    hashCode = hashCode * 59 + this.NumBlocks.GetHashCode();
                if (this.NumTransactions != null)
                    hashCode = hashCode * 59 + this.NumTransactions.GetHashCode();
                if (this.NumAccounts != null)
                    hashCode = hashCode * 59 + this.NumAccounts.GetHashCode();
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
