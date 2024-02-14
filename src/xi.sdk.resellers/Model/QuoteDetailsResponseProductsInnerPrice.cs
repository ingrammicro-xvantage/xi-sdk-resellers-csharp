/*
 * XI Sdk Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
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
    /// QuoteDetailsResponseProductsInnerPrice
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse_products_inner_price")]
    public partial class QuoteDetailsResponseProductsInnerPrice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseProductsInnerPrice" /> class.
        /// </summary>
        /// <param name="quotePrice">Ingram Micro quoted price specific to the reseller and quote..</param>
        /// <param name="msrp">Manufacturer Suggested Retail Price.</param>
        /// <param name="extendedMsrp">Extended MSRP - Manufacturer Suggested Retail Price X Quantity.</param>
        /// <param name="extendedQuotePrice">Extended reseller quoted price (cost to reseller) X Quantity.</param>
        /// <param name="discountOffList">Discount off list percentage.</param>
        public QuoteDetailsResponseProductsInnerPrice(int quotePrice = default(int), int msrp = default(int), int extendedMsrp = default(int), int extendedQuotePrice = default(int), decimal discountOffList = default(decimal))
        {
            this.QuotePrice = quotePrice;
            this.Msrp = msrp;
            this.ExtendedMsrp = extendedMsrp;
            this.ExtendedQuotePrice = extendedQuotePrice;
            this.DiscountOffList = discountOffList;
        }

        /// <summary>
        /// Ingram Micro quoted price specific to the reseller and quote.
        /// </summary>
        /// <value>Ingram Micro quoted price specific to the reseller and quote.</value>
        [DataMember(Name = "quotePrice", EmitDefaultValue = false)]
        public int QuotePrice { get; set; }

        /// <summary>
        /// Manufacturer Suggested Retail Price
        /// </summary>
        /// <value>Manufacturer Suggested Retail Price</value>
        [DataMember(Name = "msrp", EmitDefaultValue = false)]
        public int Msrp { get; set; }

        /// <summary>
        /// Extended MSRP - Manufacturer Suggested Retail Price X Quantity
        /// </summary>
        /// <value>Extended MSRP - Manufacturer Suggested Retail Price X Quantity</value>
        [DataMember(Name = "extendedMsrp", EmitDefaultValue = false)]
        public int ExtendedMsrp { get; set; }

        /// <summary>
        /// Extended reseller quoted price (cost to reseller) X Quantity
        /// </summary>
        /// <value>Extended reseller quoted price (cost to reseller) X Quantity</value>
        [DataMember(Name = "extendedQuotePrice", EmitDefaultValue = false)]
        public int ExtendedQuotePrice { get; set; }

        /// <summary>
        /// Discount off list percentage
        /// </summary>
        /// <value>Discount off list percentage</value>
        [DataMember(Name = "discountOffList", EmitDefaultValue = false)]
        public decimal DiscountOffList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseProductsInnerPrice {\n");
            sb.Append("  QuotePrice: ").Append(QuotePrice).Append("\n");
            sb.Append("  Msrp: ").Append(Msrp).Append("\n");
            sb.Append("  ExtendedMsrp: ").Append(ExtendedMsrp).Append("\n");
            sb.Append("  ExtendedQuotePrice: ").Append(ExtendedQuotePrice).Append("\n");
            sb.Append("  DiscountOffList: ").Append(DiscountOffList).Append("\n");
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
