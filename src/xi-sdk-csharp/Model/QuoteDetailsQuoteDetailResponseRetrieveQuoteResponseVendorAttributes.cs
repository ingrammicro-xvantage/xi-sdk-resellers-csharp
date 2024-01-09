/*
 * Reseller API Documentation - United States
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
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
using OpenAPIDateConverter = xi-sdk-csharp.Client.OpenAPIDateConverter;

namespace xi-sdk-csharp.Model
{
    /// <summary>
    /// QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes
    /// </summary>
    [DataContract(Name = "quoteDetails_quoteDetailResponse_retrieveQuoteResponse_vendorAttributes")]
    public partial class QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes" /> class.
        /// </summary>
        /// <param name="estimateId">estimateId.</param>
        /// <param name="dealId">dealId.</param>
        /// <param name="vendorName">vendorName.</param>
        /// <param name="vendorSettingMessage">vendorSettingMessage.</param>
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes(string estimateId = default(string), string dealId = default(string), string vendorName = default(string), string vendorSettingMessage = default(string))
        {
            this.EstimateId = estimateId;
            this.DealId = dealId;
            this.VendorName = vendorName;
            this.VendorSettingMessage = vendorSettingMessage;
        }

        /// <summary>
        /// Gets or Sets EstimateId
        /// </summary>
        [DataMember(Name = "estimateId", EmitDefaultValue = false)]
        public string EstimateId { get; set; }

        /// <summary>
        /// Gets or Sets DealId
        /// </summary>
        [DataMember(Name = "dealId", EmitDefaultValue = false)]
        public string DealId { get; set; }

        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name = "vendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or Sets VendorSettingMessage
        /// </summary>
        [DataMember(Name = "vendorSettingMessage", EmitDefaultValue = false)]
        public string VendorSettingMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes {\n");
            sb.Append("  EstimateId: ").Append(EstimateId).Append("\n");
            sb.Append("  DealId: ").Append(DealId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  VendorSettingMessage: ").Append(VendorSettingMessage).Append("\n");
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
