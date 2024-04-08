/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    /// PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_discounts_inner_quantityDiscounts_inner")]
    public partial class PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner" /> class.
        /// </summary>
        /// <param name="conditionType">Indicates when the discount is applied after ordering the product..</param>
        /// <param name="currencyCode">The country-specific three digit ISO 4217 currency code for the order..</param>
        /// <param name="currencyType">Type of currency..</param>
        /// <param name="quantity">The total discounted quantity of the product..</param>
        /// <param name="amount">The total price of all the discounts applied..</param>
        public PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner(string conditionType = default(string), string currencyCode = default(string), string currencyType = default(string), int quantity = default(int), decimal amount = default(decimal))
        {
            this.ConditionType = conditionType;
            this.CurrencyCode = currencyCode;
            this.CurrencyType = currencyType;
            this.Quantity = quantity;
            this.Amount = amount;
        }

        /// <summary>
        /// Indicates when the discount is applied after ordering the product.
        /// </summary>
        /// <value>Indicates when the discount is applied after ordering the product.</value>
        /// <example>Total fee</example>
        [DataMember(Name = "conditionType", EmitDefaultValue = false)]
        public string ConditionType { get; set; }

        /// <summary>
        /// The country-specific three digit ISO 4217 currency code for the order.
        /// </summary>
        /// <value>The country-specific three digit ISO 4217 currency code for the order.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Type of currency.
        /// </summary>
        /// <value>Type of currency.</value>
        [DataMember(Name = "currencyType", EmitDefaultValue = false)]
        public string CurrencyType { get; set; }

        /// <summary>
        /// The total discounted quantity of the product.
        /// </summary>
        /// <value>The total discounted quantity of the product.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The total price of all the discounts applied.
        /// </summary>
        /// <value>The total price of all the discounts applied.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner {\n");
            sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyType: ").Append(CurrencyType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
