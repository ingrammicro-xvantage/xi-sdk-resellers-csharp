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
    /// OrderDetailB2BLinesInnerServiceContractInfo
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_serviceContractInfo")]
    public partial class OrderDetailB2BLinesInnerServiceContractInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerServiceContractInfo" /> class.
        /// </summary>
        /// <param name="contractInfo">contractInfo.</param>
        /// <param name="subscriptions">subscriptions.</param>
        /// <param name="licenseInfo">licenseInfo.</param>
        public OrderDetailB2BLinesInnerServiceContractInfo(OrderDetailB2BLinesInnerServiceContractInfoContractInfo contractInfo = default(OrderDetailB2BLinesInnerServiceContractInfoContractInfo), OrderDetailB2BLinesInnerServiceContractInfoSubscriptions subscriptions = default(OrderDetailB2BLinesInnerServiceContractInfoSubscriptions), OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo licenseInfo = default(OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo))
        {
            this.ContractInfo = contractInfo;
            this.Subscriptions = subscriptions;
            this.LicenseInfo = licenseInfo;
        }

        /// <summary>
        /// Gets or Sets ContractInfo
        /// </summary>
        [DataMember(Name = "contractInfo", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerServiceContractInfoContractInfo ContractInfo { get; set; }

        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerServiceContractInfoSubscriptions Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets LicenseInfo
        /// </summary>
        [DataMember(Name = "licenseInfo", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerServiceContractInfo {\n");
            sb.Append("  ContractInfo: ").Append(ContractInfo).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  LicenseInfo: ").Append(LicenseInfo).Append("\n");
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
