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
    /// OrderCreateResponseOrdersInnerRejectedLineItemsInner
    /// </summary>
    [DataContract(Name = "OrderCreateResponse_orders_inner_rejectedLineItems_inner")]
    public partial class OrderCreateResponseOrdersInnerRejectedLineItemsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponseOrdersInnerRejectedLineItemsInner" /> class.
        /// </summary>
        /// <param name="customerLinenumber">The reseller&#39;s line item number of the rejected item for their reference. Number.</param>
        /// <param name="ingramPartNumber">The Ingram Micro part number for the rejected line item..</param>
        /// <param name="vendorPartNumber">The vendor part number for the rejected line item..</param>
        /// <param name="quantityOrdered">The quantity ordered of the rejected line item..</param>
        /// <param name="rejectCode">The rejection code for the rejected line item. Ex: &#39;EN&#39; .</param>
        /// <param name="rejectReason">The rejection reason for the rejected line item. Ex: &#39;SKU-NOTFOUND    DF41281&#39; .</param>
        public OrderCreateResponseOrdersInnerRejectedLineItemsInner(string customerLinenumber = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), int quantityOrdered = default(int), string rejectCode = default(string), string rejectReason = default(string))
        {
            this.CustomerLinenumber = customerLinenumber;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.QuantityOrdered = quantityOrdered;
            this.RejectCode = rejectCode;
            this.RejectReason = rejectReason;
        }

        /// <summary>
        /// The reseller&#39;s line item number of the rejected item for their reference. Number
        /// </summary>
        /// <value>The reseller&#39;s line item number of the rejected item for their reference. Number</value>
        [DataMember(Name = "customerLinenumber", EmitDefaultValue = false)]
        public string CustomerLinenumber { get; set; }

        /// <summary>
        /// The Ingram Micro part number for the rejected line item.
        /// </summary>
        /// <value>The Ingram Micro part number for the rejected line item.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The vendor part number for the rejected line item.
        /// </summary>
        /// <value>The vendor part number for the rejected line item.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The quantity ordered of the rejected line item.
        /// </summary>
        /// <value>The quantity ordered of the rejected line item.</value>
        [DataMember(Name = "quantityOrdered", EmitDefaultValue = false)]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// The rejection code for the rejected line item. Ex: &#39;EN&#39; 
        /// </summary>
        /// <value>The rejection code for the rejected line item. Ex: &#39;EN&#39; </value>
        [DataMember(Name = "rejectCode", EmitDefaultValue = false)]
        public string RejectCode { get; set; }

        /// <summary>
        /// The rejection reason for the rejected line item. Ex: &#39;SKU-NOTFOUND    DF41281&#39; 
        /// </summary>
        /// <value>The rejection reason for the rejected line item. Ex: &#39;SKU-NOTFOUND    DF41281&#39; </value>
        [DataMember(Name = "rejectReason", EmitDefaultValue = false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponseOrdersInnerRejectedLineItemsInner {\n");
            sb.Append("  CustomerLinenumber: ").Append(CustomerLinenumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  RejectCode: ").Append(RejectCode).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
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
