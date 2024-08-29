/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// RenewalsSearchRequestDateType
    /// </summary>
    [DataContract(Name = "renewalsSearchRequest_dateType")]
    public partial class RenewalsSearchRequestDateType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsSearchRequestDateType" /> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="invoiceDate">invoiceDate.</param>
        /// <param name="expirationDate">expirationDate.</param>
        public RenewalsSearchRequestDateType(RenewalsSearchRequestDateTypeStartDate startDate = default(RenewalsSearchRequestDateTypeStartDate), RenewalsSearchRequestDateTypeEndDate endDate = default(RenewalsSearchRequestDateTypeEndDate), RenewalsSearchRequestDateTypeInvoiceDate invoiceDate = default(RenewalsSearchRequestDateTypeInvoiceDate), RenewalsSearchRequestDateTypeExpirationDate expirationDate = default(RenewalsSearchRequestDateTypeExpirationDate))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.InvoiceDate = invoiceDate;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public RenewalsSearchRequestDateTypeStartDate StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public RenewalsSearchRequestDateTypeEndDate EndDate { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name = "invoiceDate", EmitDefaultValue = false)]
        public RenewalsSearchRequestDateTypeInvoiceDate InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public RenewalsSearchRequestDateTypeExpirationDate ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsSearchRequestDateType {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
