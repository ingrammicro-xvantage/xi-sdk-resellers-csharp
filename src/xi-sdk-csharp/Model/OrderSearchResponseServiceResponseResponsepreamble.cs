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
    /// OrderSearchResponseServiceResponseResponsepreamble
    /// </summary>
    [DataContract(Name = "orderSearchResponse_serviceResponse_responsepreamble")]
    public partial class OrderSearchResponseServiceResponseResponsepreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchResponseServiceResponseResponsepreamble" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderSearchResponseServiceResponseResponsepreamble() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchResponseServiceResponseResponsepreamble" /> class.
        /// </summary>
        /// <param name="requeststatus">requeststatus (required).</param>
        /// <param name="returnmessage">returnmessage (required).</param>
        public OrderSearchResponseServiceResponseResponsepreamble(string requeststatus = default(string), string returnmessage = default(string))
        {
            // to ensure "requeststatus" is required (not null)
            if (requeststatus == null)
            {
                throw new ArgumentNullException("requeststatus is a required property for OrderSearchResponseServiceResponseResponsepreamble and cannot be null");
            }
            this.Requeststatus = requeststatus;
            // to ensure "returnmessage" is required (not null)
            if (returnmessage == null)
            {
                throw new ArgumentNullException("returnmessage is a required property for OrderSearchResponseServiceResponseResponsepreamble and cannot be null");
            }
            this.Returnmessage = returnmessage;
        }

        /// <summary>
        /// Gets or Sets Requeststatus
        /// </summary>
        [DataMember(Name = "requeststatus", IsRequired = true, EmitDefaultValue = true)]
        public string Requeststatus { get; set; }

        /// <summary>
        /// Gets or Sets Returnmessage
        /// </summary>
        [DataMember(Name = "returnmessage", IsRequired = true, EmitDefaultValue = true)]
        public string Returnmessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderSearchResponseServiceResponseResponsepreamble {\n");
            sb.Append("  Requeststatus: ").Append(Requeststatus).Append("\n");
            sb.Append("  Returnmessage: ").Append(Returnmessage).Append("\n");
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
