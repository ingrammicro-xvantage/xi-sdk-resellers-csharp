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
    /// QuoteProductListPrice
    /// </summary>
    [DataContract(Name = "quoteProductList_price")]
    public partial class QuoteProductListPrice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteProductListPrice" /> class.
        /// </summary>
        /// <param name="quotePrice">quotePrice.</param>
        /// <param name="msrp">msrp.</param>
        /// <param name="extendedMsrp">extendedMsrp.</param>
        /// <param name="extendedQuotePrice">extendedQuotePrice.</param>
        public QuoteProductListPrice(decimal quotePrice = default(decimal), decimal msrp = default(decimal), decimal extendedMsrp = default(decimal), decimal extendedQuotePrice = default(decimal))
        {
            this.QuotePrice = quotePrice;
            this.Msrp = msrp;
            this.ExtendedMsrp = extendedMsrp;
            this.ExtendedQuotePrice = extendedQuotePrice;
        }

        /// <summary>
        /// Gets or Sets QuotePrice
        /// </summary>
        [DataMember(Name = "quotePrice", EmitDefaultValue = false)]
        public decimal QuotePrice { get; set; }

        /// <summary>
        /// Gets or Sets Msrp
        /// </summary>
        [DataMember(Name = "msrp", EmitDefaultValue = false)]
        public decimal Msrp { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedMsrp
        /// </summary>
        [DataMember(Name = "extendedMsrp", EmitDefaultValue = false)]
        public decimal ExtendedMsrp { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedQuotePrice
        /// </summary>
        [DataMember(Name = "extendedQuotePrice", EmitDefaultValue = false)]
        public decimal ExtendedQuotePrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteProductListPrice {\n");
            sb.Append("  QuotePrice: ").Append(QuotePrice).Append("\n");
            sb.Append("  Msrp: ").Append(Msrp).Append("\n");
            sb.Append("  ExtendedMsrp: ").Append(ExtendedMsrp).Append("\n");
            sb.Append("  ExtendedQuotePrice: ").Append(ExtendedQuotePrice).Append("\n");
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
