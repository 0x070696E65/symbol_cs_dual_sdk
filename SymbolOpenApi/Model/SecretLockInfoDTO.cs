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
    /// SecretLockInfoDTO
    /// </summary>
    [DataContract]
    public partial class SecretLockInfoDTO :  IEquatable<SecretLockInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockInfoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretLockInfoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretLockInfoDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="_lock">_lock (required).</param>
        public SecretLockInfoDTO(string id = default(string), SecretLockEntryDTO _lock = default(SecretLockEntryDTO))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SecretLockInfoDTO and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "_lock" is required (not null)
            if (_lock == null)
            {
                throw new InvalidDataException("_lock is a required property for SecretLockInfoDTO and cannot be null");
            }
            else
            {
                this.Lock = _lock;
            }

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Lock
        /// </summary>
        [DataMember(Name="lock", EmitDefaultValue=true)]
        public SecretLockEntryDTO Lock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretLockInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Lock: ").Append(Lock).Append("\n");
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
            return this.Equals(input as SecretLockInfoDTO);
        }

        /// <summary>
        /// Returns true if SecretLockInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretLockInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretLockInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Lock == input.Lock ||
                    (this.Lock != null &&
                    this.Lock.Equals(input.Lock))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Lock != null)
                    hashCode = hashCode * 59 + this.Lock.GetHashCode();
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