/*
 * Reseller API Documentation - United States
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = xi-sdk-csharp.Client.OpenAPIDateConverter;

namespace xi-sdk-csharp.Model
{
    /// <summary>
    /// QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo
    /// </summary>
    [DataContract(Name = "quoteDetails_quoteDetailResponse_retrieveQuoteResponse_contactInfo")]
    public partial class QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo" /> class.
        /// </summary>
        /// <param name="contactEmail">contactEmail.</param>
        /// <param name="contactName">contactName.</param>
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo(string contactEmail = default(string), string contactName = default(string))
        {
            this.ContactEmail = contactEmail;
            this.ContactName = contactName;
        }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name = "contactEmail", EmitDefaultValue = false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name = "contactName", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo {\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
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
