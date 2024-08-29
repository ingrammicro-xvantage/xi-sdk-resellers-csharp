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
    /// DealsSearchResponseDealsInner
    /// </summary>
    [DataContract(Name = "dealsSearchResponse_deals_inner")]
    public partial class DealsSearchResponseDealsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DealsSearchResponseDealsInner" /> class.
        /// </summary>
        /// <param name="dealId">Deal/Special bid number..</param>
        /// <param name="varVersion">Most recent version number of the deal..</param>
        /// <param name="endUser">The end user/customer&#39;s name..</param>
        /// <param name="vendor">The vendor&#39;s name..</param>
        /// <param name="dealExpiryDate">Expiration date of the deal/Special bid..</param>
        /// <param name="links">links.</param>
        public DealsSearchResponseDealsInner(string dealId = default(string), string varVersion = default(string), string endUser = default(string), string vendor = default(string), string dealExpiryDate = default(string), RenewalsSearchResponseRenewalsInnerLinksInner links = default(RenewalsSearchResponseRenewalsInnerLinksInner))
        {
            this.DealId = dealId;
            this.VarVersion = varVersion;
            this.EndUser = endUser;
            this.Vendor = vendor;
            this.DealExpiryDate = dealExpiryDate;
            this.Links = links;
        }

        /// <summary>
        /// Deal/Special bid number.
        /// </summary>
        /// <value>Deal/Special bid number.</value>
        [DataMember(Name = "dealId", EmitDefaultValue = false)]
        public string DealId { get; set; }

        /// <summary>
        /// Most recent version number of the deal.
        /// </summary>
        /// <value>Most recent version number of the deal.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// The end user/customer&#39;s name.
        /// </summary>
        /// <value>The end user/customer&#39;s name.</value>
        [DataMember(Name = "endUser", EmitDefaultValue = false)]
        public string EndUser { get; set; }

        /// <summary>
        /// The vendor&#39;s name.
        /// </summary>
        /// <value>The vendor&#39;s name.</value>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Expiration date of the deal/Special bid.
        /// </summary>
        /// <value>Expiration date of the deal/Special bid.</value>
        [DataMember(Name = "dealExpiryDate", EmitDefaultValue = false)]
        public string DealExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public RenewalsSearchResponseRenewalsInnerLinksInner Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DealsSearchResponseDealsInner {\n");
            sb.Append("  DealId: ").Append(DealId).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  EndUser: ").Append(EndUser).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  DealExpiryDate: ").Append(DealExpiryDate).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
