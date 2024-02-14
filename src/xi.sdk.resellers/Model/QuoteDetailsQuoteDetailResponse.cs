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
    /// QuoteDetailsQuoteDetailResponse
    /// </summary>
    [DataContract(Name = "quoteDetails_quoteDetailResponse")]
    public partial class QuoteDetailsQuoteDetailResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsQuoteDetailResponse" /> class.
        /// </summary>
        /// <param name="responsePreamble">responsePreamble.</param>
        /// <param name="retrieveQuoteResponse">retrieveQuoteResponse.</param>
        /// <param name="quoteProductList">quoteProductList.</param>
        /// <param name="totalQuoteProductCount">totalQuoteProductCount.</param>
        /// <param name="totalExtendedMsrp">totalExtendedMsrp.</param>
        /// <param name="totalQuantity">totalQuantity.</param>
        /// <param name="totalExtendedQuotePrice">totalExtendedQuotePrice.</param>
        public QuoteDetailsQuoteDetailResponse(QuoteDetailsQuoteDetailResponseResponsePreamble responsePreamble = default(QuoteDetailsQuoteDetailResponseResponsePreamble), QuoteDetailsQuoteDetailResponseRetrieveQuoteResponse retrieveQuoteResponse = default(QuoteDetailsQuoteDetailResponseRetrieveQuoteResponse), List<QuoteProductList> quoteProductList = default(List<QuoteProductList>), string totalQuoteProductCount = default(string), string totalExtendedMsrp = default(string), int totalQuantity = default(int), string totalExtendedQuotePrice = default(string))
        {
            this.ResponsePreamble = responsePreamble;
            this.RetrieveQuoteResponse = retrieveQuoteResponse;
            this.QuoteProductList = quoteProductList;
            this.TotalQuoteProductCount = totalQuoteProductCount;
            this.TotalExtendedMsrp = totalExtendedMsrp;
            this.TotalQuantity = totalQuantity;
            this.TotalExtendedQuotePrice = totalExtendedQuotePrice;
        }

        /// <summary>
        /// Gets or Sets ResponsePreamble
        /// </summary>
        [DataMember(Name = "responsePreamble", EmitDefaultValue = false)]
        public QuoteDetailsQuoteDetailResponseResponsePreamble ResponsePreamble { get; set; }

        /// <summary>
        /// Gets or Sets RetrieveQuoteResponse
        /// </summary>
        [DataMember(Name = "retrieveQuoteResponse", EmitDefaultValue = false)]
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponse RetrieveQuoteResponse { get; set; }

        /// <summary>
        /// Gets or Sets QuoteProductList
        /// </summary>
        [DataMember(Name = "quoteProductList", EmitDefaultValue = false)]
        public List<QuoteProductList> QuoteProductList { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuoteProductCount
        /// </summary>
        [DataMember(Name = "totalQuoteProductCount", EmitDefaultValue = false)]
        public string TotalQuoteProductCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtendedMsrp
        /// </summary>
        [DataMember(Name = "totalExtendedMsrp", EmitDefaultValue = false)]
        public string TotalExtendedMsrp { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuantity
        /// </summary>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtendedQuotePrice
        /// </summary>
        [DataMember(Name = "totalExtendedQuotePrice", EmitDefaultValue = false)]
        public string TotalExtendedQuotePrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsQuoteDetailResponse {\n");
            sb.Append("  ResponsePreamble: ").Append(ResponsePreamble).Append("\n");
            sb.Append("  RetrieveQuoteResponse: ").Append(RetrieveQuoteResponse).Append("\n");
            sb.Append("  QuoteProductList: ").Append(QuoteProductList).Append("\n");
            sb.Append("  TotalQuoteProductCount: ").Append(TotalQuoteProductCount).Append("\n");
            sb.Append("  TotalExtendedMsrp: ").Append(TotalExtendedMsrp).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  TotalExtendedQuotePrice: ").Append(TotalExtendedQuotePrice).Append("\n");
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
