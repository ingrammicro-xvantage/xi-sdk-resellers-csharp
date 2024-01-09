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
    /// RenewalsSearchRequestDataTypeStartDate
    /// </summary>
    [DataContract(Name = "renewalsSearchRequest_dataType_startDate")]
    public partial class RenewalsSearchRequestDataTypeStartDate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsSearchRequestDataTypeStartDate" /> class.
        /// </summary>
        /// <param name="customStartDate">Custom from date for Renewal Start date..</param>
        /// <param name="customEndDate">Custom to date for Renewal Start date..</param>
        public RenewalsSearchRequestDataTypeStartDate(string customStartDate = default(string), string customEndDate = default(string))
        {
            this.CustomStartDate = customStartDate;
            this.CustomEndDate = customEndDate;
        }

        /// <summary>
        /// Custom from date for Renewal Start date.
        /// </summary>
        /// <value>Custom from date for Renewal Start date.</value>
        [DataMember(Name = "customStartDate", EmitDefaultValue = false)]
        public string CustomStartDate { get; set; }

        /// <summary>
        /// Custom to date for Renewal Start date.
        /// </summary>
        /// <value>Custom to date for Renewal Start date.</value>
        [DataMember(Name = "customEndDate", EmitDefaultValue = false)]
        public string CustomEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsSearchRequestDataTypeStartDate {\n");
            sb.Append("  CustomStartDate: ").Append(CustomStartDate).Append("\n");
            sb.Append("  CustomEndDate: ").Append(CustomEndDate).Append("\n");
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
