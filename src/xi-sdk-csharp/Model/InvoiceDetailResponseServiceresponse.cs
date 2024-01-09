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
    /// InvoiceDetailResponseServiceresponse
    /// </summary>
    [DataContract(Name = "invoiceDetailResponse_serviceresponse")]
    public partial class InvoiceDetailResponseServiceresponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailResponseServiceresponse" /> class.
        /// </summary>
        /// <param name="responsepreamble">responsepreamble.</param>
        /// <param name="invoicedetailresponse">invoicedetailresponse.</param>
        public InvoiceDetailResponseServiceresponse(InvoiceDetailResponseServiceresponseResponsepreamble responsepreamble = default(InvoiceDetailResponseServiceresponseResponsepreamble), InvoiceDetailResponseServiceresponseInvoicedetailresponse invoicedetailresponse = default(InvoiceDetailResponseServiceresponseInvoicedetailresponse))
        {
            this.Responsepreamble = responsepreamble;
            this.Invoicedetailresponse = invoicedetailresponse;
        }

        /// <summary>
        /// Gets or Sets Responsepreamble
        /// </summary>
        [DataMember(Name = "responsepreamble", EmitDefaultValue = false)]
        public InvoiceDetailResponseServiceresponseResponsepreamble Responsepreamble { get; set; }

        /// <summary>
        /// Gets or Sets Invoicedetailresponse
        /// </summary>
        [DataMember(Name = "invoicedetailresponse", EmitDefaultValue = false)]
        public InvoiceDetailResponseServiceresponseInvoicedetailresponse Invoicedetailresponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailResponseServiceresponse {\n");
            sb.Append("  Responsepreamble: ").Append(Responsepreamble).Append("\n");
            sb.Append("  Invoicedetailresponse: ").Append(Invoicedetailresponse).Append("\n");
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
