/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// SaveCategoryResponseData
    /// </summary>
    [DataContract]
    public partial class SaveCategoryResponseData :  IEquatable<SaveCategoryResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveCategoryResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveCategoryResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveCategoryResponseData" /> class.
        /// </summary>
        /// <param name="category">category (required).</param>
        /// <param name="serverKnowledge">The knowledge of the server (required).</param>
        public SaveCategoryResponseData(Category category = default(Category), long serverKnowledge = default(long))
        {
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for SaveCategoryResponseData and cannot be null");
            }
            else
            {
                this.Category = category;
            }

            // to ensure "serverKnowledge" is required (not null)
            if (serverKnowledge == null)
            {
                throw new InvalidDataException("serverKnowledge is a required property for SaveCategoryResponseData and cannot be null");
            }
            else
            {
                this.ServerKnowledge = serverKnowledge;
            }

        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public Category Category { get; set; }

        /// <summary>
        /// The knowledge of the server
        /// </summary>
        /// <value>The knowledge of the server</value>
        [DataMember(Name="server_knowledge", EmitDefaultValue=false)]
        public long ServerKnowledge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveCategoryResponseData {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ServerKnowledge: ").Append(ServerKnowledge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaveCategoryResponseData);
        }

        /// <summary>
        /// Returns true if SaveCategoryResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveCategoryResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveCategoryResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ServerKnowledge == input.ServerKnowledge ||
                    this.ServerKnowledge.Equals(input.ServerKnowledge)
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.ServerKnowledge.GetHashCode();
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