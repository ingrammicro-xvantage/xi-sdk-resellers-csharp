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
    /// InvoiceDetailsv61ResponseSummary
    /// </summary>
    [DataContract(Name = "InvoiceDetailsv6_1Response_summary")]
    public partial class InvoiceDetailsv61ResponseSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsv61ResponseSummary" /> class.
        /// </summary>
        /// <param name="lines">lines.</param>
        /// <param name="miscCharges">Miscellaneous charges..</param>
        /// <param name="totals">totals.</param>
        /// <param name="foreignFxTotals">foreignFxTotals.</param>
        public InvoiceDetailsv61ResponseSummary(InvoiceDetailsv61ResponseSummaryLines lines = default(InvoiceDetailsv61ResponseSummaryLines), List<InvoiceDetailsv61ResponseSummaryMiscChargesInner> miscCharges = default(List<InvoiceDetailsv61ResponseSummaryMiscChargesInner>), InvoiceDetailsv61ResponseSummaryTotals totals = default(InvoiceDetailsv61ResponseSummaryTotals), InvoiceDetailsv61ResponseSummaryForeignFxTotals foreignFxTotals = default(InvoiceDetailsv61ResponseSummaryForeignFxTotals))
        {
            this.Lines = lines;
            this.MiscCharges = miscCharges;
            this.Totals = totals;
            this.ForeignFxTotals = foreignFxTotals;
        }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        public InvoiceDetailsv61ResponseSummaryLines Lines { get; set; }

        /// <summary>
        /// Miscellaneous charges.
        /// </summary>
        /// <value>Miscellaneous charges.</value>
        [DataMember(Name = "miscCharges", EmitDefaultValue = true)]
        public List<InvoiceDetailsv61ResponseSummaryMiscChargesInner> MiscCharges { get; set; }

        /// <summary>
        /// Gets or Sets Totals
        /// </summary>
        [DataMember(Name = "totals", EmitDefaultValue = false)]
        public InvoiceDetailsv61ResponseSummaryTotals Totals { get; set; }

        /// <summary>
        /// Gets or Sets ForeignFxTotals
        /// </summary>
        [DataMember(Name = "foreignFxTotals", EmitDefaultValue = false)]
        public InvoiceDetailsv61ResponseSummaryForeignFxTotals ForeignFxTotals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailsv61ResponseSummary {\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  MiscCharges: ").Append(MiscCharges).Append("\n");
            sb.Append("  Totals: ").Append(Totals).Append("\n");
            sb.Append("  ForeignFxTotals: ").Append(ForeignFxTotals).Append("\n");
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
