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
    /// PriceAndAvailabilityRequest
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityRequest")]
    public partial class PriceAndAvailabilityRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityRequest" /> class.
        /// </summary>
        /// <param name="showAvailableDiscounts">Boolean value that will display Discount details in the response when true..</param>
        /// <param name="showReserveInventoryDetails">Boolean value that will display reserve inventory details in the response when true..</param>
        /// <param name="specialBidNumber">Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers..</param>
        /// <param name="availabilityByWarehouse">availabilityByWarehouse.</param>
        /// <param name="products">products.</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        public PriceAndAvailabilityRequest(bool showAvailableDiscounts = default(bool), bool showReserveInventoryDetails = default(bool), string specialBidNumber = default(string), List<PriceAndAvailabilityRequestAvailabilityByWarehouseInner> availabilityByWarehouse = default(List<PriceAndAvailabilityRequestAvailabilityByWarehouseInner>), List<PriceAndAvailabilityRequestProductsInner> products = default(List<PriceAndAvailabilityRequestProductsInner>), List<PriceAndAvailabilityRequestAdditionalAttributesInner> additionalAttributes = default(List<PriceAndAvailabilityRequestAdditionalAttributesInner>))
        {
            this.ShowAvailableDiscounts = showAvailableDiscounts;
            this.ShowReserveInventoryDetails = showReserveInventoryDetails;
            this.SpecialBidNumber = specialBidNumber;
            this.AvailabilityByWarehouse = availabilityByWarehouse;
            this.Products = products;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// Boolean value that will display Discount details in the response when true.
        /// </summary>
        /// <value>Boolean value that will display Discount details in the response when true.</value>
        [DataMember(Name = "showAvailableDiscounts", EmitDefaultValue = true)]
        public bool ShowAvailableDiscounts { get; set; }

        /// <summary>
        /// Boolean value that will display reserve inventory details in the response when true.
        /// </summary>
        /// <value>Boolean value that will display reserve inventory details in the response when true.</value>
        [DataMember(Name = "showReserveInventoryDetails", EmitDefaultValue = true)]
        public bool ShowReserveInventoryDetails { get; set; }

        /// <summary>
        /// Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers.
        /// </summary>
        /// <value>Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = true)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityByWarehouse
        /// </summary>
        [DataMember(Name = "availabilityByWarehouse", EmitDefaultValue = true)]
        public List<PriceAndAvailabilityRequestAvailabilityByWarehouseInner> AvailabilityByWarehouse { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false)]
        public List<PriceAndAvailabilityRequestProductsInner> Products { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = true)]
        public List<PriceAndAvailabilityRequestAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityRequest {\n");
            sb.Append("  ShowAvailableDiscounts: ").Append(ShowAvailableDiscounts).Append("\n");
            sb.Append("  ShowReserveInventoryDetails: ").Append(ShowReserveInventoryDetails).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  AvailabilityByWarehouse: ").Append(AvailabilityByWarehouse).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
