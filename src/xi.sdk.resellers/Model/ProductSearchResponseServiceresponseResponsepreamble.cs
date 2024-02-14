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
    /// ProductSearchResponseServiceresponseResponsepreamble
    /// </summary>
    [DataContract(Name = "productSearchResponse_serviceresponse_responsepreamble")]
    public partial class ProductSearchResponseServiceresponseResponsepreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSearchResponseServiceresponseResponsepreamble" /> class.
        /// </summary>
        /// <param name="requeststatus">requeststatus.</param>
        /// <param name="returncode">returncode.</param>
        /// <param name="returnmessage">returnmessage.</param>
        public ProductSearchResponseServiceresponseResponsepreamble(string requeststatus = default(string), string returncode = default(string), string returnmessage = default(string))
        {
            this.Requeststatus = requeststatus;
            this.Returncode = returncode;
            this.Returnmessage = returnmessage;
        }

        /// <summary>
        /// Gets or Sets Requeststatus
        /// </summary>
        [DataMember(Name = "requeststatus", EmitDefaultValue = false)]
        public string Requeststatus { get; set; }

        /// <summary>
        /// Gets or Sets Returncode
        /// </summary>
        [DataMember(Name = "returncode", EmitDefaultValue = false)]
        public string Returncode { get; set; }

        /// <summary>
        /// Gets or Sets Returnmessage
        /// </summary>
        [DataMember(Name = "returnmessage", EmitDefaultValue = false)]
        public string Returnmessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductSearchResponseServiceresponseResponsepreamble {\n");
            sb.Append("  Requeststatus: ").Append(Requeststatus).Append("\n");
            sb.Append("  Returncode: ").Append(Returncode).Append("\n");
            sb.Append("  Returnmessage: ").Append(Returnmessage).Append("\n");
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
