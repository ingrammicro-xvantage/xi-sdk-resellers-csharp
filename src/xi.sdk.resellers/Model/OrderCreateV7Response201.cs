/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// OrderCreateV7Response201
    /// </summary>
    [DataContract(Name = "OrderCreateV7Response201")]
    public partial class OrderCreateV7Response201 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateV7Response201" /> class.
        /// </summary>
        /// <param name="quoteNumber">A unique identifier generated by Ingram Micro&#39;s CRM specific to each quote..</param>
        /// <param name="confirmationNumber">A unique confirmation number for tracking purposes..</param>
        /// <param name="message">A confirmation message..</param>
        public OrderCreateV7Response201(string quoteNumber = default(string), string confirmationNumber = default(string), string message = default(string))
        {
            this.QuoteNumber = quoteNumber;
            this.ConfirmationNumber = confirmationNumber;
            this.Message = message;
        }

        /// <summary>
        /// A unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.
        /// </summary>
        /// <value>A unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.</value>
        [DataMember(Name = "quoteNumber", EmitDefaultValue = true)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// A unique confirmation number for tracking purposes.
        /// </summary>
        /// <value>A unique confirmation number for tracking purposes.</value>
        /*
        <example>987654322</example>
        */
        [DataMember(Name = "confirmationNumber", EmitDefaultValue = false)]
        public string ConfirmationNumber { get; set; }

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
            sb.Append("class OrderCreateV7Response201 {\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
