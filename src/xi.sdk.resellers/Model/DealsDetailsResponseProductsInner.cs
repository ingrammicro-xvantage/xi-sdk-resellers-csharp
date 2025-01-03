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
    /// DealsDetailsResponseProductsInner
    /// </summary>
    [DataContract(Name = "dealsDetailsResponse_products_inner")]
    public partial class DealsDetailsResponseProductsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DealsDetailsResponseProductsInner" /> class.
        /// </summary>
        /// <param name="ingramPartNumber">Unique Ingram part number..</param>
        /// <param name="vendorPartNumber">Vendor Part number for the product..</param>
        /// <param name="upc">The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item..</param>
        /// <param name="productDescription">Description of the product..</param>
        /// <param name="msrp">Manufacturer Suggested Retail Price..</param>
        /// <param name="extendedMSRP">Extended MSRP - Manufacturer Suggested Retail Price X Quantity..</param>
        /// <param name="standardPrice">Standard price of the line item..</param>
        /// <param name="approvedQuantity">Total quantity approved for the deal..</param>
        /// <param name="remainingQuantity">The quantity remaining as part of the deal for the customer to order..</param>
        /// <param name="comments">Comments of the deal..</param>
        /// <param name="specialConditions">Special conditions of the deal..</param>
        /// <param name="startDate">Start Date..</param>
        /// <param name="expirationDate">Expiration date..</param>
        /// <param name="daysRemaining">Number of days remaining before the deal expires..</param>
        public DealsDetailsResponseProductsInner(string ingramPartNumber = default(string), string vendorPartNumber = default(string), string upc = default(string), string productDescription = default(string), decimal msrp = default(decimal), decimal extendedMSRP = default(decimal), decimal standardPrice = default(decimal), int approvedQuantity = default(int), int remainingQuantity = default(int), string comments = default(string), string specialConditions = default(string), string startDate = default(string), string expirationDate = default(string), int daysRemaining = default(int))
        {
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.Upc = upc;
            this.ProductDescription = productDescription;
            this.Msrp = msrp;
            this.ExtendedMSRP = extendedMSRP;
            this.StandardPrice = standardPrice;
            this.ApprovedQuantity = approvedQuantity;
            this.RemainingQuantity = remainingQuantity;
            this.Comments = comments;
            this.SpecialConditions = specialConditions;
            this.StartDate = startDate;
            this.ExpirationDate = expirationDate;
            this.DaysRemaining = daysRemaining;
        }

        /// <summary>
        /// Unique Ingram part number.
        /// </summary>
        /// <value>Unique Ingram part number.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// Vendor Part number for the product.
        /// </summary>
        /// <value>Vendor Part number for the product.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item.
        /// </summary>
        /// <value>The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item.</value>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        public string Upc { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        /// <value>Description of the product.</value>
        [DataMember(Name = "productDescription", EmitDefaultValue = false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Manufacturer Suggested Retail Price.
        /// </summary>
        /// <value>Manufacturer Suggested Retail Price.</value>
        [DataMember(Name = "msrp", EmitDefaultValue = false)]
        public decimal Msrp { get; set; }

        /// <summary>
        /// Extended MSRP - Manufacturer Suggested Retail Price X Quantity.
        /// </summary>
        /// <value>Extended MSRP - Manufacturer Suggested Retail Price X Quantity.</value>
        [DataMember(Name = "extendedMSRP", EmitDefaultValue = false)]
        public decimal ExtendedMSRP { get; set; }

        /// <summary>
        /// Standard price of the line item.
        /// </summary>
        /// <value>Standard price of the line item.</value>
        [DataMember(Name = "standardPrice", EmitDefaultValue = false)]
        public decimal StandardPrice { get; set; }

        /// <summary>
        /// Total quantity approved for the deal.
        /// </summary>
        /// <value>Total quantity approved for the deal.</value>
        [DataMember(Name = "approvedQuantity", EmitDefaultValue = false)]
        public int ApprovedQuantity { get; set; }

        /// <summary>
        /// The quantity remaining as part of the deal for the customer to order.
        /// </summary>
        /// <value>The quantity remaining as part of the deal for the customer to order.</value>
        [DataMember(Name = "remainingQuantity", EmitDefaultValue = false)]
        public int RemainingQuantity { get; set; }

        /// <summary>
        /// Comments of the deal.
        /// </summary>
        /// <value>Comments of the deal.</value>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// Special conditions of the deal.
        /// </summary>
        /// <value>Special conditions of the deal.</value>
        [DataMember(Name = "specialConditions", EmitDefaultValue = false)]
        public string SpecialConditions { get; set; }

        /// <summary>
        /// Start Date.
        /// </summary>
        /// <value>Start Date.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        /// <value>Expiration date.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Number of days remaining before the deal expires.
        /// </summary>
        /// <value>Number of days remaining before the deal expires.</value>
        [DataMember(Name = "daysRemaining", EmitDefaultValue = false)]
        public int DaysRemaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DealsDetailsResponseProductsInner {\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  Msrp: ").Append(Msrp).Append("\n");
            sb.Append("  ExtendedMSRP: ").Append(ExtendedMSRP).Append("\n");
            sb.Append("  StandardPrice: ").Append(StandardPrice).Append("\n");
            sb.Append("  ApprovedQuantity: ").Append(ApprovedQuantity).Append("\n");
            sb.Append("  RemainingQuantity: ").Append(RemainingQuantity).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  SpecialConditions: ").Append(SpecialConditions).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  DaysRemaining: ").Append(DaysRemaining).Append("\n");
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
