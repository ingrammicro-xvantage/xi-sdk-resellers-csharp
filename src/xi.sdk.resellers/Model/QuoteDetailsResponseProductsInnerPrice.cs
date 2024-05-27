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
        /// <param name="discountOffList">Discount off list percentage extended.</param>
        /// <param name="type">type.</param>
        /// <param name="recurringPriceModel">recurringPriceModel.</param>
        /// <param name="unitOfMeasure">unitOfMeasure.</param>
        /// <param name="tax">tax.</param>
        /// <param name="extrafees">extrafees.</param>
        /// <param name="extraFeesDetails">extraFeesDetails.</param>
        /// <param name="discounts">discounts.</param>
        public QuoteDetailsResponseProductsInnerPrice(decimal quotePrice = default(decimal), decimal msrp = default(decimal), decimal extendedMsrp = default(decimal), decimal extendedQuotePrice = default(decimal), string discountOffList = default(string), string type = default(string), string recurringPriceModel = default(string), string unitOfMeasure = default(string), decimal tax = default(decimal), decimal extrafees = default(decimal), List<QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner> extraFeesDetails = default(List<QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner>), List<QuoteDetailsResponseProductsInnerPriceDiscountsInner> discounts = default(List<QuoteDetailsResponseProductsInnerPriceDiscountsInner>))
        {
            this.QuotePrice = quotePrice;
            this.Msrp = msrp;
            this.ExtendedMsrp = extendedMsrp;
            this.ExtendedQuotePrice = extendedQuotePrice;
            this.DiscountOffList = discountOffList;
            this.Type = type;
            this.RecurringPriceModel = recurringPriceModel;
            this.UnitOfMeasure = unitOfMeasure;
            this.Tax = tax;
            this.Extrafees = extrafees;
            this.ExtraFeesDetails = extraFeesDetails;
            this.Discounts = discounts;
        }

        /// <summary>
        /// Ingram Micro quoted price specific to the reseller and quote.
        /// </summary>
        /// <value>Ingram Micro quoted price specific to the reseller and quote.</value>
        [DataMember(Name = "quotePrice", EmitDefaultValue = false)]
        public decimal QuotePrice { get; set; }

        /// <summary>
        /// Manufacturer Suggested Retail Price
        /// </summary>
        /// <value>Manufacturer Suggested Retail Price</value>
        [DataMember(Name = "msrp", EmitDefaultValue = false)]
        public decimal Msrp { get; set; }

        /// <summary>
        /// Extended MSRP - Manufacturer Suggested Retail Price X Quantity
        /// </summary>
        /// <value>Extended MSRP - Manufacturer Suggested Retail Price X Quantity</value>
        [DataMember(Name = "extendedMsrp", EmitDefaultValue = false)]
        public decimal ExtendedMsrp { get; set; }

        /// <summary>
        /// Extended reseller quoted price (cost to reseller) X Quantity
        /// </summary>
        /// <value>Extended reseller quoted price (cost to reseller) X Quantity</value>
        [DataMember(Name = "extendedQuotePrice", EmitDefaultValue = false)]
        public decimal ExtendedQuotePrice { get; set; }

        /// <summary>
        /// Discount off list percentage extended
        /// </summary>
        /// <value>Discount off list percentage extended</value>
        [DataMember(Name = "discountOffList", EmitDefaultValue = false)]
        public string DiscountOffList { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RecurringPriceModel
        /// </summary>
        [DataMember(Name = "recurringPriceModel", EmitDefaultValue = false)]
        public string RecurringPriceModel { get; set; }

        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public decimal Tax { get; set; }

        /// <summary>
        /// Gets or Sets Extrafees
        /// </summary>
        [DataMember(Name = "extrafees", EmitDefaultValue = false)]
        public decimal Extrafees { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFeesDetails
        /// </summary>
        [DataMember(Name = "extraFeesDetails", EmitDefaultValue = false)]
        public List<QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner> ExtraFeesDetails { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name = "discounts", EmitDefaultValue = false)]
        public List<QuoteDetailsResponseProductsInnerPriceDiscountsInner> Discounts { get; set; }

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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RecurringPriceModel: ").Append(RecurringPriceModel).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Extrafees: ").Append(Extrafees).Append("\n");
            sb.Append("  ExtraFeesDetails: ").Append(ExtraFeesDetails).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
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
