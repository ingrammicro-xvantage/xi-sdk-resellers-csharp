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
    /// AsyncOrderCreateDTOLinesInner
    /// </summary>
    [DataContract(Name = "AsyncOrderCreateDTO_lines_inner")]
    public partial class AsyncOrderCreateDTOLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateDTOLinesInner" /> class.
        /// </summary>
        /// <param name="customerLineNumber">The reseller&#39;s line item number for reference in their system..</param>
        /// <param name="ingramPartNumber">Unique IngramMicro part number..</param>
        /// <param name="quantity">The quantity of the line item..</param>
        /// <param name="unitPrice">Unit Price of Item.</param>
        /// <param name="specialBidNumber">specialBidNumber.</param>
        /// <param name="endUserPrice">endUserPrice.</param>
        /// <param name="notes">notes.</param>
        /// <param name="endUserInfo">The contact information for the end user/customer provided by the reseller. Used to determine pricing and discounts..</param>
        public AsyncOrderCreateDTOLinesInner(string customerLineNumber = default(string), string ingramPartNumber = default(string), string quantity = default(string), string unitPrice = default(string), string specialBidNumber = default(string), string endUserPrice = default(string), string notes = default(string), List<AsyncOrderCreateDTOLinesInnerEndUserInfoInner> endUserInfo = default(List<AsyncOrderCreateDTOLinesInnerEndUserInfoInner>))
        {
            this.CustomerLineNumber = customerLineNumber;
            this.IngramPartNumber = ingramPartNumber;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.SpecialBidNumber = specialBidNumber;
            this.EndUserPrice = endUserPrice;
            this.Notes = notes;
            this.EndUserInfo = endUserInfo;
        }

        /// <summary>
        /// The reseller&#39;s line item number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s line item number for reference in their system.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// Unique IngramMicro part number.
        /// </summary>
        /// <value>Unique IngramMicro part number.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        /// <value>The quantity of the line item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Unit Price of Item
        /// </summary>
        /// <value>Unit Price of Item</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets SpecialBidNumber
        /// </summary>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Gets or Sets EndUserPrice
        /// </summary>
        [DataMember(Name = "endUserPrice", EmitDefaultValue = false)]
        public string EndUserPrice { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The contact information for the end user/customer provided by the reseller. Used to determine pricing and discounts.
        /// </summary>
        /// <value>The contact information for the end user/customer provided by the reseller. Used to determine pricing and discounts.</value>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public List<AsyncOrderCreateDTOLinesInnerEndUserInfoInner> EndUserInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsyncOrderCreateDTOLinesInner {\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  EndUserPrice: ").Append(EndUserPrice).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
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
