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
    /// OrderDetailB2BLinesInnerServiceContractInfoContractInfo
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_serviceContractInfo_contractInfo")]
    public partial class OrderDetailB2BLinesInnerServiceContractInfoContractInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerServiceContractInfoContractInfo" /> class.
        /// </summary>
        /// <param name="contractDescription">The description of the contract..</param>
        /// <param name="contractNumber">Contract number..</param>
        /// <param name="contractStatus">The status of the contract..</param>
        /// <param name="contractStartDate">Start date of the contract..</param>
        /// <param name="contractEndDate">End date of the contract..</param>
        /// <param name="contractDuration">The duration of the contract..</param>
        public OrderDetailB2BLinesInnerServiceContractInfoContractInfo(string contractDescription = default(string), string contractNumber = default(string), string contractStatus = default(string), string contractStartDate = default(string), string contractEndDate = default(string), string contractDuration = default(string))
        {
            this.ContractDescription = contractDescription;
            this.ContractNumber = contractNumber;
            this.ContractStatus = contractStatus;
            this.ContractStartDate = contractStartDate;
            this.ContractEndDate = contractEndDate;
            this.ContractDuration = contractDuration;
        }

        /// <summary>
        /// The description of the contract.
        /// </summary>
        /// <value>The description of the contract.</value>
        [DataMember(Name = "contractDescription", EmitDefaultValue = false)]
        public string ContractDescription { get; set; }

        /// <summary>
        /// Contract number.
        /// </summary>
        /// <value>Contract number.</value>
        [DataMember(Name = "contractNumber", EmitDefaultValue = false)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// The status of the contract.
        /// </summary>
        /// <value>The status of the contract.</value>
        [DataMember(Name = "contractStatus", EmitDefaultValue = false)]
        public string ContractStatus { get; set; }

        /// <summary>
        /// Start date of the contract.
        /// </summary>
        /// <value>Start date of the contract.</value>
        [DataMember(Name = "contractStartDate", EmitDefaultValue = false)]
        public string ContractStartDate { get; set; }

        /// <summary>
        /// End date of the contract.
        /// </summary>
        /// <value>End date of the contract.</value>
        [DataMember(Name = "contractEndDate", EmitDefaultValue = false)]
        public string ContractEndDate { get; set; }

        /// <summary>
        /// The duration of the contract.
        /// </summary>
        /// <value>The duration of the contract.</value>
        [DataMember(Name = "contractDuration", EmitDefaultValue = false)]
        public string ContractDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerServiceContractInfoContractInfo {\n");
            sb.Append("  ContractDescription: ").Append(ContractDescription).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  ContractStatus: ").Append(ContractStatus).Append("\n");
            sb.Append("  ContractStartDate: ").Append(ContractStartDate).Append("\n");
            sb.Append("  ContractEndDate: ").Append(ContractEndDate).Append("\n");
            sb.Append("  ContractDuration: ").Append(ContractDuration).Append("\n");
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
