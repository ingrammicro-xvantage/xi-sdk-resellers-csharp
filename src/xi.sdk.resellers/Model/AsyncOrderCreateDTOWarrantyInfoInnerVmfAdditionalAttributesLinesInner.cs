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
    /// AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner
    /// </summary>
    [DataContract(Name = "AsyncOrderCreateDTO_warrantyInfo_inner_vmfAdditionalAttributesLines_inner")]
    public partial class AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner" /> class.
        /// </summary>
        /// <param name="attributeName">The name of the line level field..</param>
        /// <param name="attributeValue">The value of the line level field..</param>
        public AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner(string attributeName = default(string), string attributeValue = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }

        /// <summary>
        /// The name of the line level field.
        /// </summary>
        /// <value>The name of the line level field.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The value of the line level field.
        /// </summary>
        /// <value>The value of the line level field.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  AttributeValue: ").Append(AttributeValue).Append("\n");
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
