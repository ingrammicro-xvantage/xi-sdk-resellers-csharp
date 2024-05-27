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
    /// OrderCreateResponseOrdersInnerLinesInner
    /// </summary>
    [DataContract(Name = "OrderCreateResponse_orders_inner_lines_inner")]
    public partial class OrderCreateResponseOrdersInnerLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponseOrdersInnerLinesInner" /> class.
        /// </summary>
        /// <param name="subOrderNumber">The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number..</param>
        /// <param name="ingramLineNumber">The Ingram Micro line number for the product..</param>
        /// <param name="customerLineNumber">The reseller&#39;s line number for reference in their system..</param>
        /// <param name="lineStatus">The status for the line item in the order. One of: Backordered, Open.</param>
        /// <param name="ingramPartNumber">The Ingram Micro part number for the line item..</param>
        /// <param name="vendorPartNumber">The vendor part number for the line item..</param>
        /// <param name="unitPrice">The unit price for the line item..</param>
        /// <param name="extendedUnitPrice">The extended list price (unit price X quantity) for the line item..</param>
        /// <param name="quantityOrdered">The quantity of the line item ordered..</param>
        /// <param name="quantityConfirmed">The quantity of the line item that has been confirmed..</param>
        /// <param name="quantityBackOrdered">The quantity of the line item that is backordered..</param>
        /// <param name="specialBidNumber">The bid number for the line item provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers..</param>
        /// <param name="notes">Line-level notes..</param>
        /// <param name="shipmentDetails">The shipment details for the line item..</param>
        /// <param name="additionalAttributes">SAP requested and country-specific line level details..</param>
        public OrderCreateResponseOrdersInnerLinesInner(string subOrderNumber = default(string), string ingramLineNumber = default(string), string customerLineNumber = default(string), string lineStatus = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), decimal unitPrice = default(decimal), decimal extendedUnitPrice = default(decimal), int quantityOrdered = default(int), int quantityConfirmed = default(int), int quantityBackOrdered = default(int), string specialBidNumber = default(string), string notes = default(string), List<OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner> shipmentDetails = default(List<OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner>), List<OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner> additionalAttributes = default(List<OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner>))
        {
            this.SubOrderNumber = subOrderNumber;
            this.IngramLineNumber = ingramLineNumber;
            this.CustomerLineNumber = customerLineNumber;
            this.LineStatus = lineStatus;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.UnitPrice = unitPrice;
            this.ExtendedUnitPrice = extendedUnitPrice;
            this.QuantityOrdered = quantityOrdered;
            this.QuantityConfirmed = quantityConfirmed;
            this.QuantityBackOrdered = quantityBackOrdered;
            this.SpecialBidNumber = specialBidNumber;
            this.Notes = notes;
            this.ShipmentDetails = shipmentDetails;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.
        /// </summary>
        /// <value>The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.</value>
        [DataMember(Name = "subOrderNumber", EmitDefaultValue = false)]
        public string SubOrderNumber { get; set; }

        /// <summary>
        /// The Ingram Micro line number for the product.
        /// </summary>
        /// <value>The Ingram Micro line number for the product.</value>
        [DataMember(Name = "ingramLineNumber", EmitDefaultValue = false)]
        public string IngramLineNumber { get; set; }

        /// <summary>
        /// The reseller&#39;s line number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s line number for reference in their system.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// The status for the line item in the order. One of: Backordered, Open
        /// </summary>
        /// <value>The status for the line item in the order. One of: Backordered, Open</value>
        [DataMember(Name = "lineStatus", EmitDefaultValue = false)]
        public string LineStatus { get; set; }

        /// <summary>
        /// The Ingram Micro part number for the line item.
        /// </summary>
        /// <value>The Ingram Micro part number for the line item.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The vendor part number for the line item.
        /// </summary>
        /// <value>The vendor part number for the line item.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The unit price for the line item.
        /// </summary>
        /// <value>The unit price for the line item.</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The extended list price (unit price X quantity) for the line item.
        /// </summary>
        /// <value>The extended list price (unit price X quantity) for the line item.</value>
        [DataMember(Name = "extendedUnitPrice", EmitDefaultValue = false)]
        public decimal ExtendedUnitPrice { get; set; }

        /// <summary>
        /// The quantity of the line item ordered.
        /// </summary>
        /// <value>The quantity of the line item ordered.</value>
        [DataMember(Name = "quantityOrdered", EmitDefaultValue = false)]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// The quantity of the line item that has been confirmed.
        /// </summary>
        /// <value>The quantity of the line item that has been confirmed.</value>
        [DataMember(Name = "quantityConfirmed", EmitDefaultValue = false)]
        public int QuantityConfirmed { get; set; }

        /// <summary>
        /// The quantity of the line item that is backordered.
        /// </summary>
        /// <value>The quantity of the line item that is backordered.</value>
        [DataMember(Name = "quantityBackOrdered", EmitDefaultValue = false)]
        public int QuantityBackOrdered { get; set; }

        /// <summary>
        /// The bid number for the line item provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.
        /// </summary>
        /// <value>The bid number for the line item provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Line-level notes.
        /// </summary>
        /// <value>Line-level notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The shipment details for the line item.
        /// </summary>
        /// <value>The shipment details for the line item.</value>
        [DataMember(Name = "shipmentDetails", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner> ShipmentDetails { get; set; }

        /// <summary>
        /// SAP requested and country-specific line level details.
        /// </summary>
        /// <value>SAP requested and country-specific line level details.</value>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponseOrdersInnerLinesInner {\n");
            sb.Append("  SubOrderNumber: ").Append(SubOrderNumber).Append("\n");
            sb.Append("  IngramLineNumber: ").Append(IngramLineNumber).Append("\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  LineStatus: ").Append(LineStatus).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  ExtendedUnitPrice: ").Append(ExtendedUnitPrice).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  QuantityConfirmed: ").Append(QuantityConfirmed).Append("\n");
            sb.Append("  QuantityBackOrdered: ").Append(QuantityBackOrdered).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ShipmentDetails: ").Append(ShipmentDetails).Append("\n");
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
