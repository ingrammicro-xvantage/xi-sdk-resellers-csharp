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
    /// OrderCreateRequestOrdercreaterequestRequestpreamble
    /// </summary>
    [DataContract(Name = "orderCreateRequest_ordercreaterequest_requestpreamble")]
    public partial class OrderCreateRequestOrdercreaterequestRequestpreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestOrdercreaterequestRequestpreamble" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderCreateRequestOrdercreaterequestRequestpreamble() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestOrdercreaterequestRequestpreamble" /> class.
        /// </summary>
        /// <param name="isocountrycode">2 digit ISO country code (required).</param>
        /// <param name="customernumber">Your unique Ingram Micro customer number (required).</param>
        public OrderCreateRequestOrdercreaterequestRequestpreamble(string isocountrycode = default(string), string customernumber = default(string))
        {
            // to ensure "isocountrycode" is required (not null)
            if (isocountrycode == null)
            {
                throw new ArgumentNullException("isocountrycode is a required property for OrderCreateRequestOrdercreaterequestRequestpreamble and cannot be null");
            }
            this.Isocountrycode = isocountrycode;
            // to ensure "customernumber" is required (not null)
            if (customernumber == null)
            {
                throw new ArgumentNullException("customernumber is a required property for OrderCreateRequestOrdercreaterequestRequestpreamble and cannot be null");
            }
            this.Customernumber = customernumber;
        }

        /// <summary>
        /// 2 digit ISO country code
        /// </summary>
        /// <value>2 digit ISO country code</value>
        [DataMember(Name = "isocountrycode", IsRequired = true, EmitDefaultValue = true)]
        public string Isocountrycode { get; set; }

        /// <summary>
        /// Your unique Ingram Micro customer number
        /// </summary>
        /// <value>Your unique Ingram Micro customer number</value>
        /// <example>10-123456 or 123456</example>
        [DataMember(Name = "customernumber", IsRequired = true, EmitDefaultValue = true)]
        public string Customernumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestOrdercreaterequestRequestpreamble {\n");
            sb.Append("  Isocountrycode: ").Append(Isocountrycode).Append("\n");
            sb.Append("  Customernumber: ").Append(Customernumber).Append("\n");
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
