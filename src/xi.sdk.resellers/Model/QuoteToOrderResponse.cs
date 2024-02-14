/*
 * XI Sdk Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 1.0.0
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
using FileParameter = xi.sdk.resellers.Client.FileParameter;
using OpenAPIDateConverter = xi.sdk.resellers.Client.OpenAPIDateConverter;

namespace xi.sdk.resellers.Model
{
    /// <summary>
    /// QuoteToOrderResponse
    /// </summary>
    [DataContract(Name = "QuoteToOrderResponse")]
    public partial class QuoteToOrderResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteToOrderResponse" /> class.
        /// </summary>
        /// <param name="quoteNumber">Unique identifier generated by Ingram Micro&#39;s CRM specific to each quote..</param>
        /// <param name="confirmationNumber">A unique confirmation number for tracking purposes..</param>
        /// <param name="message">A confirmation message..</param>
        public QuoteToOrderResponse(string quoteNumber = default(string), decimal confirmationNumber = default(decimal), string message = default(string))
        {
            this.QuoteNumber = quoteNumber;
            this.ConfirmationNumber = confirmationNumber;
            this.Message = message;
        }

        /// <summary>
        /// Unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.
        /// </summary>
        /// <value>Unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.</value>
        /// <example>QUO-14551943-D2Y9L9</example>
        [DataMember(Name = "quoteNumber", EmitDefaultValue = false)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// A unique confirmation number for tracking purposes.
        /// </summary>
        /// <value>A unique confirmation number for tracking purposes.</value>
        /// <example>987654322</example>
        [DataMember(Name = "confirmationNumber", EmitDefaultValue = false)]
        public decimal ConfirmationNumber { get; set; }

        /// <summary>
        /// A confirmation message.
        /// </summary>
        /// <value>A confirmation message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteToOrderResponse {\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
            sb.Append("  ConfirmationNumber: ").Append(ConfirmationNumber).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
