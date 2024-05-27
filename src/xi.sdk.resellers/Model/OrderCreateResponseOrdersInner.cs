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
    /// OrderCreateResponseOrdersInner
    /// </summary>
    [DataContract(Name = "OrderCreateResponse_orders_inner")]
    public partial class OrderCreateResponseOrdersInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponseOrdersInner" /> class.
        /// </summary>
        /// <param name="numberOfLinesWithSuccess">The number of lines in the order that were successful..</param>
        /// <param name="numberOfLinesWithError">The number of lines in the order that have errors..</param>
        /// <param name="numberOfLinesWithWarning">The number of lines in the order that have a warning..</param>
        /// <param name="ingramOrderNumber">The Ingram Micro order number..</param>
        /// <param name="ingramOrderDate">The date in UTC format that the order was created in Ingram Micro&#39;s system..</param>
        /// <param name="notes">Order-level notes..</param>
        /// <param name="orderType">The order typer. One of: S&#x3D;Stocked PO D&#x3D;Direct Ship PO.</param>
        /// <param name="orderTotal">The total price for the order..</param>
        /// <param name="freightCharges">The total freight charges for the order..</param>
        /// <param name="totalTax">The total tax for the order..</param>
        /// <param name="currencyCode">The country-specific three character ISO 4217 currency code used for the order..</param>
        /// <param name="lines">The line-level details for the order..</param>
        /// <param name="miscellaneousCharges">miscellaneousCharges.</param>
        /// <param name="links">Link to Order Details for the order(s)..</param>
        /// <param name="rejectedLineItems">A list of rejected line items..</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        public OrderCreateResponseOrdersInner(int numberOfLinesWithSuccess = default(int), int numberOfLinesWithError = default(int), int numberOfLinesWithWarning = default(int), string ingramOrderNumber = default(string), string ingramOrderDate = default(string), string notes = default(string), string orderType = default(string), decimal orderTotal = default(decimal), decimal freightCharges = default(decimal), decimal totalTax = default(decimal), string currencyCode = default(string), List<OrderCreateResponseOrdersInnerLinesInner> lines = default(List<OrderCreateResponseOrdersInnerLinesInner>), List<OrderCreateResponseOrdersInnerMiscellaneousChargesInner> miscellaneousCharges = default(List<OrderCreateResponseOrdersInnerMiscellaneousChargesInner>), List<OrderCreateResponseOrdersInnerLinksInner> links = default(List<OrderCreateResponseOrdersInnerLinksInner>), List<OrderCreateResponseOrdersInnerRejectedLineItemsInner> rejectedLineItems = default(List<OrderCreateResponseOrdersInnerRejectedLineItemsInner>), List<OrderCreateResponseOrdersInnerAdditionalAttributesInner> additionalAttributes = default(List<OrderCreateResponseOrdersInnerAdditionalAttributesInner>))
        {
            this.NumberOfLinesWithSuccess = numberOfLinesWithSuccess;
            this.NumberOfLinesWithError = numberOfLinesWithError;
            this.NumberOfLinesWithWarning = numberOfLinesWithWarning;
            this.IngramOrderNumber = ingramOrderNumber;
            this.IngramOrderDate = ingramOrderDate;
            this.Notes = notes;
            this.OrderType = orderType;
            this.OrderTotal = orderTotal;
            this.FreightCharges = freightCharges;
            this.TotalTax = totalTax;
            this.CurrencyCode = currencyCode;
            this.Lines = lines;
            this.MiscellaneousCharges = miscellaneousCharges;
            this.Links = links;
            this.RejectedLineItems = rejectedLineItems;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// The number of lines in the order that were successful.
        /// </summary>
        /// <value>The number of lines in the order that were successful.</value>
        [DataMember(Name = "numberOfLinesWithSuccess", EmitDefaultValue = false)]
        public int NumberOfLinesWithSuccess { get; set; }

        /// <summary>
        /// The number of lines in the order that have errors.
        /// </summary>
        /// <value>The number of lines in the order that have errors.</value>
        [DataMember(Name = "numberOfLinesWithError", EmitDefaultValue = false)]
        public int NumberOfLinesWithError { get; set; }

        /// <summary>
        /// The number of lines in the order that have a warning.
        /// </summary>
        /// <value>The number of lines in the order that have a warning.</value>
        [DataMember(Name = "numberOfLinesWithWarning", EmitDefaultValue = false)]
        public int NumberOfLinesWithWarning { get; set; }

        /// <summary>
        /// The Ingram Micro order number.
        /// </summary>
        /// <value>The Ingram Micro order number.</value>
        [DataMember(Name = "ingramOrderNumber", EmitDefaultValue = false)]
        public string IngramOrderNumber { get; set; }

        /// <summary>
        /// The date in UTC format that the order was created in Ingram Micro&#39;s system.
        /// </summary>
        /// <value>The date in UTC format that the order was created in Ingram Micro&#39;s system.</value>
        [DataMember(Name = "ingramOrderDate", EmitDefaultValue = false)]
        public string IngramOrderDate { get; set; }

        /// <summary>
        /// Order-level notes.
        /// </summary>
        /// <value>Order-level notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The order typer. One of: S&#x3D;Stocked PO D&#x3D;Direct Ship PO
        /// </summary>
        /// <value>The order typer. One of: S&#x3D;Stocked PO D&#x3D;Direct Ship PO</value>
        [DataMember(Name = "orderType", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The total price for the order.
        /// </summary>
        /// <value>The total price for the order.</value>
        [DataMember(Name = "orderTotal", EmitDefaultValue = false)]
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// The total freight charges for the order.
        /// </summary>
        /// <value>The total freight charges for the order.</value>
        [DataMember(Name = "freightCharges", EmitDefaultValue = false)]
        public decimal FreightCharges { get; set; }

        /// <summary>
        /// The total tax for the order.
        /// </summary>
        /// <value>The total tax for the order.</value>
        [DataMember(Name = "totalTax", EmitDefaultValue = false)]
        public decimal TotalTax { get; set; }

        /// <summary>
        /// The country-specific three character ISO 4217 currency code used for the order.
        /// </summary>
        /// <value>The country-specific three character ISO 4217 currency code used for the order.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The line-level details for the order.
        /// </summary>
        /// <value>The line-level details for the order.</value>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerLinesInner> Lines { get; set; }

        /// <summary>
        /// Gets or Sets MiscellaneousCharges
        /// </summary>
        [DataMember(Name = "miscellaneousCharges", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerMiscellaneousChargesInner> MiscellaneousCharges { get; set; }

        /// <summary>
        /// Link to Order Details for the order(s).
        /// </summary>
        /// <value>Link to Order Details for the order(s).</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerLinksInner> Links { get; set; }

        /// <summary>
        /// A list of rejected line items.
        /// </summary>
        /// <value>A list of rejected line items.</value>
        [DataMember(Name = "rejectedLineItems", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerRejectedLineItemsInner> RejectedLineItems { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponseOrdersInner {\n");
            sb.Append("  NumberOfLinesWithSuccess: ").Append(NumberOfLinesWithSuccess).Append("\n");
            sb.Append("  NumberOfLinesWithError: ").Append(NumberOfLinesWithError).Append("\n");
            sb.Append("  NumberOfLinesWithWarning: ").Append(NumberOfLinesWithWarning).Append("\n");
            sb.Append("  IngramOrderNumber: ").Append(IngramOrderNumber).Append("\n");
            sb.Append("  IngramOrderDate: ").Append(IngramOrderDate).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OrderTotal: ").Append(OrderTotal).Append("\n");
            sb.Append("  FreightCharges: ").Append(FreightCharges).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  MiscellaneousCharges: ").Append(MiscellaneousCharges).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  RejectedLineItems: ").Append(RejectedLineItems).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
