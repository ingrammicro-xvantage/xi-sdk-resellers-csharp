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
    /// OrderModifyResponseRejectedLineItemsInner
    /// </summary>
    [DataContract(Name = "OrderModifyResponse_rejectedLineItems_inner")]
    public partial class OrderModifyResponseRejectedLineItemsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderModifyResponseRejectedLineItemsInner" /> class.
        /// </summary>
        /// <param name="ingramLineNumber">The IngramMicro line number for the failed line item..</param>
        /// <param name="customerLineNumber">The reseller&#39;s line number of the failed line item for reference in their system..</param>
        /// <param name="ingramPartNumber">The IngramMicro part number for the failed line item..</param>
        /// <param name="vendorPartNumber">The vendor&#39;s part number for the failed line item..</param>
        /// <param name="quantityOrdered">The quantity ordered of the failed line item..</param>
        /// <param name="rejectCode">The rejection code for the failed line item..</param>
        /// <param name="rejectReason">The rejection reason for the failed line item..</param>
        public OrderModifyResponseRejectedLineItemsInner(string ingramLineNumber = default(string), string customerLineNumber = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), int quantityOrdered = default(int), string rejectCode = default(string), string rejectReason = default(string))
        {
            this.IngramLineNumber = ingramLineNumber;
            this.CustomerLineNumber = customerLineNumber;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.QuantityOrdered = quantityOrdered;
            this.RejectCode = rejectCode;
            this.RejectReason = rejectReason;
        }

        /// <summary>
        /// The IngramMicro line number for the failed line item.
        /// </summary>
        /// <value>The IngramMicro line number for the failed line item.</value>
        [DataMember(Name = "ingramLineNumber", EmitDefaultValue = false)]
        public string IngramLineNumber { get; set; }

        /// <summary>
        /// The reseller&#39;s line number of the failed line item for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s line number of the failed line item for reference in their system.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// The IngramMicro part number for the failed line item.
        /// </summary>
        /// <value>The IngramMicro part number for the failed line item.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s part number for the failed line item.
        /// </summary>
        /// <value>The vendor&#39;s part number for the failed line item.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The quantity ordered of the failed line item.
        /// </summary>
        /// <value>The quantity ordered of the failed line item.</value>
        [DataMember(Name = "quantityOrdered", EmitDefaultValue = false)]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// The rejection code for the failed line item.
        /// </summary>
        /// <value>The rejection code for the failed line item.</value>
        [DataMember(Name = "rejectCode", EmitDefaultValue = false)]
        public string RejectCode { get; set; }

        /// <summary>
        /// The rejection reason for the failed line item.
        /// </summary>
        /// <value>The rejection reason for the failed line item.</value>
        [DataMember(Name = "rejectReason", EmitDefaultValue = false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderModifyResponseRejectedLineItemsInner {\n");
            sb.Append("  IngramLineNumber: ").Append(IngramLineNumber).Append("\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
