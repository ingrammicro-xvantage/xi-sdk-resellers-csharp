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
    /// OrderDetailB2B
    /// </summary>
    [DataContract(Name = "OrderDetailB2B")]
    public partial class OrderDetailB2B : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2B" /> class.
        /// </summary>
        /// <param name="ingramOrderNumber">The IngramMicro sales order number..</param>
        /// <param name="ingramOrderDate">The IngramMicro sales order date..</param>
        /// <param name="orderType">The IngramMicro sales order type..</param>
        /// <param name="customerOrderNumber">The reseller&#39;s order number for reference in their system..</param>
        /// <param name="endCustomerOrderNumber">The end customer&#39;s order number for reference in their system..</param>
        /// <param name="webOrderId">The web order id of the order..</param>
        /// <param name="vendorSalesOrderNumber">The vendor&#39;s order number for reference in their system.</param>
        /// <param name="ingramPurchaseOrderNumber">Ingram purchase order number..</param>
        /// <param name="orderStatus">The header-level status of the order. One of- Shipped, Canceled, Backordered, Processing, On Hold, Delivered..</param>
        /// <param name="orderTotal">The total cost for the order, includes subtotal, freight charges, and tax..</param>
        /// <param name="orderSubTotal">The sub total cost for the order, not including tax and freight..</param>
        /// <param name="freightCharges">The freight charges for the order..</param>
        /// <param name="currencyCode">The country-specific three digit ISO 4217 currency code for the order..</param>
        /// <param name="totalWeight">Total order weight. unit - - North america - Pounds , other countries will be KG..</param>
        /// <param name="totalTax">Total tax on the orders placed..</param>
        /// <param name="totalFees">Total fees on the orders placed..</param>
        /// <param name="paymentTerms">The payment terms of the order. (Ex- Net 30 days)..</param>
        /// <param name="notes">The header-level notes for the order..</param>
        /// <param name="billToInfo">billToInfo.</param>
        /// <param name="shipToInfo">shipToInfo.</param>
        /// <param name="endUserInfo">endUserInfo.</param>
        /// <param name="lines">lines.</param>
        /// <param name="miscellaneousCharges">miscellaneousCharges.</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        public OrderDetailB2B(string ingramOrderNumber = default(string), string ingramOrderDate = default(string), string orderType = default(string), string customerOrderNumber = default(string), string endCustomerOrderNumber = default(string), string webOrderId = default(string), string vendorSalesOrderNumber = default(string), string ingramPurchaseOrderNumber = default(string), string orderStatus = default(string), double orderTotal = default(double), double orderSubTotal = default(double), double freightCharges = default(double), string currencyCode = default(string), double totalWeight = default(double), double totalTax = default(double), double totalFees = default(double), string paymentTerms = default(string), string notes = default(string), OrderDetailB2BBillToInfo billToInfo = default(OrderDetailB2BBillToInfo), OrderDetailB2BShipToInfo shipToInfo = default(OrderDetailB2BShipToInfo), OrderDetailB2BEndUserInfo endUserInfo = default(OrderDetailB2BEndUserInfo), List<OrderDetailB2BLinesInner> lines = default(List<OrderDetailB2BLinesInner>), List<OrderDetailB2BMiscellaneousChargesInner> miscellaneousCharges = default(List<OrderDetailB2BMiscellaneousChargesInner>), List<OrderDetailB2BAdditionalAttributesInner> additionalAttributes = default(List<OrderDetailB2BAdditionalAttributesInner>))
        {
            this.IngramOrderNumber = ingramOrderNumber;
            this.IngramOrderDate = ingramOrderDate;
            this.OrderType = orderType;
            this.CustomerOrderNumber = customerOrderNumber;
            this.EndCustomerOrderNumber = endCustomerOrderNumber;
            this.WebOrderId = webOrderId;
            this.VendorSalesOrderNumber = vendorSalesOrderNumber;
            this.IngramPurchaseOrderNumber = ingramPurchaseOrderNumber;
            this.OrderStatus = orderStatus;
            this.OrderTotal = orderTotal;
            this.OrderSubTotal = orderSubTotal;
            this.FreightCharges = freightCharges;
            this.CurrencyCode = currencyCode;
            this.TotalWeight = totalWeight;
            this.TotalTax = totalTax;
            this.TotalFees = totalFees;
            this.PaymentTerms = paymentTerms;
            this.Notes = notes;
            this.BillToInfo = billToInfo;
            this.ShipToInfo = shipToInfo;
            this.EndUserInfo = endUserInfo;
            this.Lines = lines;
            this.MiscellaneousCharges = miscellaneousCharges;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// The IngramMicro sales order number.
        /// </summary>
        /// <value>The IngramMicro sales order number.</value>
        [DataMember(Name = "ingramOrderNumber", EmitDefaultValue = false)]
        public string IngramOrderNumber { get; set; }

        /// <summary>
        /// The IngramMicro sales order date.
        /// </summary>
        /// <value>The IngramMicro sales order date.</value>
        [DataMember(Name = "ingramOrderDate", EmitDefaultValue = false)]
        public string IngramOrderDate { get; set; }

        /// <summary>
        /// The IngramMicro sales order type.
        /// </summary>
        /// <value>The IngramMicro sales order type.</value>
        [DataMember(Name = "orderType", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The reseller&#39;s order number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s order number for reference in their system.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// The end customer&#39;s order number for reference in their system.
        /// </summary>
        /// <value>The end customer&#39;s order number for reference in their system.</value>
        [DataMember(Name = "endCustomerOrderNumber", EmitDefaultValue = false)]
        public string EndCustomerOrderNumber { get; set; }

        /// <summary>
        /// The web order id of the order.
        /// </summary>
        /// <value>The web order id of the order.</value>
        [DataMember(Name = "webOrderId", EmitDefaultValue = false)]
        public string WebOrderId { get; set; }

        /// <summary>
        /// The vendor&#39;s order number for reference in their system
        /// </summary>
        /// <value>The vendor&#39;s order number for reference in their system</value>
        [DataMember(Name = "vendorSalesOrderNumber", EmitDefaultValue = false)]
        public string VendorSalesOrderNumber { get; set; }

        /// <summary>
        /// Ingram purchase order number.
        /// </summary>
        /// <value>Ingram purchase order number.</value>
        [DataMember(Name = "ingramPurchaseOrderNumber", EmitDefaultValue = false)]
        public string IngramPurchaseOrderNumber { get; set; }

        /// <summary>
        /// The header-level status of the order. One of- Shipped, Canceled, Backordered, Processing, On Hold, Delivered.
        /// </summary>
        /// <value>The header-level status of the order. One of- Shipped, Canceled, Backordered, Processing, On Hold, Delivered.</value>
        [DataMember(Name = "orderStatus", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// The total cost for the order, includes subtotal, freight charges, and tax.
        /// </summary>
        /// <value>The total cost for the order, includes subtotal, freight charges, and tax.</value>
        [DataMember(Name = "orderTotal", EmitDefaultValue = false)]
        public double OrderTotal { get; set; }

        /// <summary>
        /// The sub total cost for the order, not including tax and freight.
        /// </summary>
        /// <value>The sub total cost for the order, not including tax and freight.</value>
        [DataMember(Name = "orderSubTotal", EmitDefaultValue = false)]
        public double OrderSubTotal { get; set; }

        /// <summary>
        /// The freight charges for the order.
        /// </summary>
        /// <value>The freight charges for the order.</value>
        [DataMember(Name = "freightCharges", EmitDefaultValue = false)]
        public double FreightCharges { get; set; }

        /// <summary>
        /// The country-specific three digit ISO 4217 currency code for the order.
        /// </summary>
        /// <value>The country-specific three digit ISO 4217 currency code for the order.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Total order weight. unit - - North america - Pounds , other countries will be KG.
        /// </summary>
        /// <value>Total order weight. unit - - North america - Pounds , other countries will be KG.</value>
        [DataMember(Name = "totalWeight", EmitDefaultValue = false)]
        public double TotalWeight { get; set; }

        /// <summary>
        /// Total tax on the orders placed.
        /// </summary>
        /// <value>Total tax on the orders placed.</value>
        [DataMember(Name = "totalTax", EmitDefaultValue = false)]
        public double TotalTax { get; set; }

        /// <summary>
        /// Total fees on the orders placed.
        /// </summary>
        /// <value>Total fees on the orders placed.</value>
        [DataMember(Name = "totalFees", EmitDefaultValue = false)]
        public double TotalFees { get; set; }

        /// <summary>
        /// The payment terms of the order. (Ex- Net 30 days).
        /// </summary>
        /// <value>The payment terms of the order. (Ex- Net 30 days).</value>
        [DataMember(Name = "paymentTerms", EmitDefaultValue = false)]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// The header-level notes for the order.
        /// </summary>
        /// <value>The header-level notes for the order.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets BillToInfo
        /// </summary>
        [DataMember(Name = "billToInfo", EmitDefaultValue = false)]
        public OrderDetailB2BBillToInfo BillToInfo { get; set; }

        /// <summary>
        /// Gets or Sets ShipToInfo
        /// </summary>
        [DataMember(Name = "shipToInfo", EmitDefaultValue = false)]
        public OrderDetailB2BShipToInfo ShipToInfo { get; set; }

        /// <summary>
        /// Gets or Sets EndUserInfo
        /// </summary>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public OrderDetailB2BEndUserInfo EndUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = true)]
        public List<OrderDetailB2BLinesInner> Lines { get; set; }

        /// <summary>
        /// Gets or Sets MiscellaneousCharges
        /// </summary>
        [DataMember(Name = "miscellaneousCharges", EmitDefaultValue = true)]
        public List<OrderDetailB2BMiscellaneousChargesInner> MiscellaneousCharges { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = true)]
        public List<OrderDetailB2BAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2B {\n");
            sb.Append("  IngramOrderNumber: ").Append(IngramOrderNumber).Append("\n");
            sb.Append("  IngramOrderDate: ").Append(IngramOrderDate).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  EndCustomerOrderNumber: ").Append(EndCustomerOrderNumber).Append("\n");
            sb.Append("  WebOrderId: ").Append(WebOrderId).Append("\n");
            sb.Append("  VendorSalesOrderNumber: ").Append(VendorSalesOrderNumber).Append("\n");
            sb.Append("  IngramPurchaseOrderNumber: ").Append(IngramPurchaseOrderNumber).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderTotal: ").Append(OrderTotal).Append("\n");
            sb.Append("  OrderSubTotal: ").Append(OrderSubTotal).Append("\n");
            sb.Append("  FreightCharges: ").Append(FreightCharges).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  TotalFees: ").Append(TotalFees).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  BillToInfo: ").Append(BillToInfo).Append("\n");
            sb.Append("  ShipToInfo: ").Append(ShipToInfo).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  MiscellaneousCharges: ").Append(MiscellaneousCharges).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
