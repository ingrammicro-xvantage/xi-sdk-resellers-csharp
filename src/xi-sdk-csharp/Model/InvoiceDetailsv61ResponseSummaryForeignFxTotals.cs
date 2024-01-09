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
    /// InvoiceDetailsv61ResponseSummaryForeignFxTotals
    /// </summary>
    [DataContract(Name = "InvoiceDetailsv6_1Response_summary_foreignFxTotals")]
    public partial class InvoiceDetailsv61ResponseSummaryForeignFxTotals : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsv61ResponseSummaryForeignFxTotals" /> class.
        /// </summary>
        /// <param name="foreignCurrencyCode">Foreign Currency Code..</param>
        /// <param name="foreignCurrencyFxRate">Foreign rate..</param>
        /// <param name="foreignTotalTaxableAmount">Foreign amount..</param>
        /// <param name="foreignTotalTaxAmount">Foreign amount..</param>
        /// <param name="foreignInvoiceAmountDue">Foreign due..</param>
        public InvoiceDetailsv61ResponseSummaryForeignFxTotals(string foreignCurrencyCode = default(string), double foreignCurrencyFxRate = default(double), string foreignTotalTaxableAmount = default(string), double foreignTotalTaxAmount = default(double), string foreignInvoiceAmountDue = default(string))
        {
            this.ForeignCurrencyCode = foreignCurrencyCode;
            this.ForeignCurrencyFxRate = foreignCurrencyFxRate;
            this.ForeignTotalTaxableAmount = foreignTotalTaxableAmount;
            this.ForeignTotalTaxAmount = foreignTotalTaxAmount;
            this.ForeignInvoiceAmountDue = foreignInvoiceAmountDue;
        }

        /// <summary>
        /// Foreign Currency Code.
        /// </summary>
        /// <value>Foreign Currency Code.</value>
        [DataMember(Name = "foreignCurrencyCode", EmitDefaultValue = false)]
        public string ForeignCurrencyCode { get; set; }

        /// <summary>
        /// Foreign rate.
        /// </summary>
        /// <value>Foreign rate.</value>
        [DataMember(Name = "foreignCurrencyFxRate", EmitDefaultValue = false)]
        public double ForeignCurrencyFxRate { get; set; }

        /// <summary>
        /// Foreign amount.
        /// </summary>
        /// <value>Foreign amount.</value>
        [DataMember(Name = "foreignTotalTaxableAmount", EmitDefaultValue = false)]
        public string ForeignTotalTaxableAmount { get; set; }

        /// <summary>
        /// Foreign amount.
        /// </summary>
        /// <value>Foreign amount.</value>
        [DataMember(Name = "foreignTotalTaxAmount", EmitDefaultValue = false)]
        public double ForeignTotalTaxAmount { get; set; }

        /// <summary>
        /// Foreign due.
        /// </summary>
        /// <value>Foreign due.</value>
        [DataMember(Name = "foreignInvoiceAmountDue", EmitDefaultValue = false)]
        public string ForeignInvoiceAmountDue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailsv61ResponseSummaryForeignFxTotals {\n");
            sb.Append("  ForeignCurrencyCode: ").Append(ForeignCurrencyCode).Append("\n");
            sb.Append("  ForeignCurrencyFxRate: ").Append(ForeignCurrencyFxRate).Append("\n");
            sb.Append("  ForeignTotalTaxableAmount: ").Append(ForeignTotalTaxableAmount).Append("\n");
            sb.Append("  ForeignTotalTaxAmount: ").Append(ForeignTotalTaxAmount).Append("\n");
            sb.Append("  ForeignInvoiceAmountDue: ").Append(ForeignInvoiceAmountDue).Append("\n");
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
