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
    /// RenewalsDetailsResponse
    /// </summary>
    [DataContract(Name = "renewalsDetailsResponse")]
    public partial class RenewalsDetailsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsDetailsResponse" /> class.
        /// </summary>
        /// <param name="renewalId">Unique Ingram renewal ID..</param>
        /// <param name="ingramOrderNumber">The IngramMicro sales order number..</param>
        /// <param name="ingramOrderDate">The IngramMicro sales order date..</param>
        /// <param name="expirationDate">Renewal expiration date..</param>
        /// <param name="ingramPurchaseOrderNumber">Ingram purchase order number..</param>
        /// <param name="customerOrderNumber">The reseller&#39;s order number for reference in their system..</param>
        /// <param name="endCustomerOrderNumber">The end customer&#39;s order number for reference in their system..</param>
        /// <param name="renewalValue">The value of the renewal..</param>
        /// <param name="endUser">The company name for the end user/customer..</param>
        /// <param name="vendor">The name of the vendor..</param>
        /// <param name="status">The status of the renewal..</param>
        /// <param name="endUserInfo">endUserInfo.</param>
        /// <param name="referenceNumber">referenceNumber.</param>
        /// <param name="products">products.</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        public RenewalsDetailsResponse(string renewalId = default(string), string ingramOrderNumber = default(string), string ingramOrderDate = default(string), string expirationDate = default(string), string ingramPurchaseOrderNumber = default(string), string customerOrderNumber = default(string), string endCustomerOrderNumber = default(string), string renewalValue = default(string), string endUser = default(string), string vendor = default(string), string status = default(string), RenewalsDetailsResponseEndUserInfo endUserInfo = default(RenewalsDetailsResponseEndUserInfo), RenewalsDetailsResponseReferenceNumber referenceNumber = default(RenewalsDetailsResponseReferenceNumber), List<RenewalsDetailsResponseProductsInner> products = default(List<RenewalsDetailsResponseProductsInner>), List<RenewalsDetailsResponseAdditionalAttributesInner> additionalAttributes = default(List<RenewalsDetailsResponseAdditionalAttributesInner>))
        {
            this.RenewalId = renewalId;
            this.IngramOrderNumber = ingramOrderNumber;
            this.IngramOrderDate = ingramOrderDate;
            this.ExpirationDate = expirationDate;
            this.IngramPurchaseOrderNumber = ingramPurchaseOrderNumber;
            this.CustomerOrderNumber = customerOrderNumber;
            this.EndCustomerOrderNumber = endCustomerOrderNumber;
            this.RenewalValue = renewalValue;
            this.EndUser = endUser;
            this.Vendor = vendor;
            this.Status = status;
            this.EndUserInfo = endUserInfo;
            this.ReferenceNumber = referenceNumber;
            this.Products = products;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// Unique Ingram renewal ID.
        /// </summary>
        /// <value>Unique Ingram renewal ID.</value>
        [DataMember(Name = "renewalId", EmitDefaultValue = false)]
        public string RenewalId { get; set; }

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
        /// Renewal expiration date.
        /// </summary>
        /// <value>Renewal expiration date.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Ingram purchase order number.
        /// </summary>
        /// <value>Ingram purchase order number.</value>
        [DataMember(Name = "ingramPurchaseOrderNumber", EmitDefaultValue = false)]
        public string IngramPurchaseOrderNumber { get; set; }

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
        /// The value of the renewal.
        /// </summary>
        /// <value>The value of the renewal.</value>
        [DataMember(Name = "renewalValue", EmitDefaultValue = false)]
        public string RenewalValue { get; set; }

        /// <summary>
        /// The company name for the end user/customer.
        /// </summary>
        /// <value>The company name for the end user/customer.</value>
        [DataMember(Name = "endUser", EmitDefaultValue = false)]
        public string EndUser { get; set; }

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        /// <value>The name of the vendor.</value>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// The status of the renewal.
        /// </summary>
        /// <value>The status of the renewal.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets EndUserInfo
        /// </summary>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public RenewalsDetailsResponseEndUserInfo EndUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public RenewalsDetailsResponseReferenceNumber ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false)]
        public List<RenewalsDetailsResponseProductsInner> Products { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<RenewalsDetailsResponseAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsDetailsResponse {\n");
            sb.Append("  RenewalId: ").Append(RenewalId).Append("\n");
            sb.Append("  IngramOrderNumber: ").Append(IngramOrderNumber).Append("\n");
            sb.Append("  IngramOrderDate: ").Append(IngramOrderDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IngramPurchaseOrderNumber: ").Append(IngramPurchaseOrderNumber).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  EndCustomerOrderNumber: ").Append(EndCustomerOrderNumber).Append("\n");
            sb.Append("  RenewalValue: ").Append(RenewalValue).Append("\n");
            sb.Append("  EndUser: ").Append(EndUser).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
