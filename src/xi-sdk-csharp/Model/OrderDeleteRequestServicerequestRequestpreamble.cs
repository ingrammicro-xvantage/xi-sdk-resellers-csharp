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
    /// OrderDeleteRequestServicerequestRequestpreamble
    /// </summary>
    [DataContract(Name = "orderDeleteRequest_servicerequest_requestpreamble")]
    public partial class OrderDeleteRequestServicerequestRequestpreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDeleteRequestServicerequestRequestpreamble" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderDeleteRequestServicerequestRequestpreamble() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDeleteRequestServicerequestRequestpreamble" /> class.
        /// </summary>
        /// <param name="isocountrycode">Country that Order is being place in. (required).</param>
        /// <param name="customerNumber">Account number order will be billed to. INGRAM MICRO ACCOUNT NUMBER REQUIRED (required).</param>
        public OrderDeleteRequestServicerequestRequestpreamble(string isocountrycode = default(string), string customerNumber = default(string))
        {
            // to ensure "isocountrycode" is required (not null)
            if (isocountrycode == null)
            {
                throw new ArgumentNullException("isocountrycode is a required property for OrderDeleteRequestServicerequestRequestpreamble and cannot be null");
            }
            this.Isocountrycode = isocountrycode;
            // to ensure "customerNumber" is required (not null)
            if (customerNumber == null)
            {
                throw new ArgumentNullException("customerNumber is a required property for OrderDeleteRequestServicerequestRequestpreamble and cannot be null");
            }
            this.CustomerNumber = customerNumber;
        }

        /// <summary>
        /// Country that Order is being place in.
        /// </summary>
        /// <value>Country that Order is being place in.</value>
        [DataMember(Name = "isocountrycode", IsRequired = true, EmitDefaultValue = true)]
        public string Isocountrycode { get; set; }

        /// <summary>
        /// Account number order will be billed to. INGRAM MICRO ACCOUNT NUMBER REQUIRED
        /// </summary>
        /// <value>Account number order will be billed to. INGRAM MICRO ACCOUNT NUMBER REQUIRED</value>
        [DataMember(Name = "customerNumber", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDeleteRequestServicerequestRequestpreamble {\n");
            sb.Append("  Isocountrycode: ").Append(Isocountrycode).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
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
