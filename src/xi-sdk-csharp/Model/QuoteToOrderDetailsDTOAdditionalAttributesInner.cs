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
    /// QuoteToOrderDetailsDTOAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "QuoteToOrderDetailsDTO_additionalAttributes_inner")]
    public partial class QuoteToOrderDetailsDTOAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteToOrderDetailsDTOAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">The attribute name. allowDuplicateCustomerOrderNumber: Allow orders with duplicate customer PO numbers. Enables resellers to have the same PO number for multiple orders. enableCommentsAsLines:  It will enable comments as lines..</param>
        /// <param name="attributeValue">The attribute field data..</param>
        public QuoteToOrderDetailsDTOAdditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }

        /// <summary>
        /// The attribute name. allowDuplicateCustomerOrderNumber: Allow orders with duplicate customer PO numbers. Enables resellers to have the same PO number for multiple orders. enableCommentsAsLines:  It will enable comments as lines.
        /// </summary>
        /// <value>The attribute name. allowDuplicateCustomerOrderNumber: Allow orders with duplicate customer PO numbers. Enables resellers to have the same PO number for multiple orders. enableCommentsAsLines:  It will enable comments as lines.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The attribute field data.
        /// </summary>
        /// <value>The attribute field data.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteToOrderDetailsDTOAdditionalAttributesInner {\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
