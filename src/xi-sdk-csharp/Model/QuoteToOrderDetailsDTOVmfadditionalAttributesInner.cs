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
    /// QuoteToOrderDetailsDTOVmfadditionalAttributesInner
    /// </summary>
    [DataContract(Name = "QuoteToOrderDetailsDTO_vmfadditionalAttributes_inner")]
    public partial class QuoteToOrderDetailsDTOVmfadditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteToOrderDetailsDTOVmfadditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">The name of the header level field..</param>
        /// <param name="attributeValue">The value of the header level field..</param>
        /// <param name="attributeDescription">The description of the header level field..</param>
        public QuoteToOrderDetailsDTOVmfadditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string), string attributeDescription = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
            this.AttributeDescription = attributeDescription;
        }

        /// <summary>
        /// The name of the header level field.
        /// </summary>
        /// <value>The name of the header level field.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The value of the header level field.
        /// </summary>
        /// <value>The value of the header level field.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// The description of the header level field.
        /// </summary>
        /// <value>The description of the header level field.</value>
        [DataMember(Name = "attributeDescription", EmitDefaultValue = false)]
        public string AttributeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteToOrderDetailsDTOVmfadditionalAttributesInner {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  AttributeValue: ").Append(AttributeValue).Append("\n");
            sb.Append("  AttributeDescription: ").Append(AttributeDescription).Append("\n");
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
