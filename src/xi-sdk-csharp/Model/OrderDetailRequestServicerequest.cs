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
    /// OrderDetailRequestServicerequest
    /// </summary>
    [DataContract(Name = "orderDetailRequest_servicerequest")]
    public partial class OrderDetailRequestServicerequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailRequestServicerequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderDetailRequestServicerequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailRequestServicerequest" /> class.
        /// </summary>
        /// <param name="requestpreamble">requestpreamble (required).</param>
        /// <param name="orderdetailrequest">orderdetailrequest.</param>
        public OrderDetailRequestServicerequest(InvoiceDetailRequestServicerequestRequestpreamble requestpreamble = default(InvoiceDetailRequestServicerequestRequestpreamble), OrderDetailRequestServicerequestOrderdetailrequest orderdetailrequest = default(OrderDetailRequestServicerequestOrderdetailrequest))
        {
            // to ensure "requestpreamble" is required (not null)
            if (requestpreamble == null)
            {
                throw new ArgumentNullException("requestpreamble is a required property for OrderDetailRequestServicerequest and cannot be null");
            }
            this.Requestpreamble = requestpreamble;
            this.Orderdetailrequest = orderdetailrequest;
        }

        /// <summary>
        /// Gets or Sets Requestpreamble
        /// </summary>
        [DataMember(Name = "requestpreamble", IsRequired = true, EmitDefaultValue = true)]
        public InvoiceDetailRequestServicerequestRequestpreamble Requestpreamble { get; set; }

        /// <summary>
        /// Gets or Sets Orderdetailrequest
        /// </summary>
        [DataMember(Name = "orderdetailrequest", EmitDefaultValue = false)]
        public OrderDetailRequestServicerequestOrderdetailrequest Orderdetailrequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailRequestServicerequest {\n");
            sb.Append("  Requestpreamble: ").Append(Requestpreamble).Append("\n");
            sb.Append("  Orderdetailrequest: ").Append(Orderdetailrequest).Append("\n");
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
