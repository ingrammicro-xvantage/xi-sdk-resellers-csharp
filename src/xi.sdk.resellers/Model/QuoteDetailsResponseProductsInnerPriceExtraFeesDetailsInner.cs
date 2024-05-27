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
    /// QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse_products_inner_price_extraFeesDetails_inner")]
    public partial class QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner" /> class.
        /// </summary>
        /// <param name="extraFeesDescription">extraFeesDescription.</param>
        /// <param name="extraFeesAmount">extraFeesAmount.</param>
        public QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner(string extraFeesDescription = default(string), decimal extraFeesAmount = default(decimal))
        {
            this.ExtraFeesDescription = extraFeesDescription;
            this.ExtraFeesAmount = extraFeesAmount;
        }

        /// <summary>
        /// Gets or Sets ExtraFeesDescription
        /// </summary>
        [DataMember(Name = "extraFeesDescription", EmitDefaultValue = false)]
        public string ExtraFeesDescription { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFeesAmount
        /// </summary>
        [DataMember(Name = "extraFeesAmount", EmitDefaultValue = false)]
        public decimal ExtraFeesAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner {\n");
            sb.Append("  ExtraFeesDescription: ").Append(ExtraFeesDescription).Append("\n");
            sb.Append("  ExtraFeesAmount: ").Append(ExtraFeesAmount).Append("\n");
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