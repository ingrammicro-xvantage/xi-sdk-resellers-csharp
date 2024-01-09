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
    /// PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityRequest_products_inner_additionalAttributes_inner")]
    public partial class PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">governmentprogramcode: Special Discount details will be provided based on the governmentprogramcode if available. shiptostatebrazil: Attribute Specific to Brazil. shipfrombranchnumber: If provided, displays only the availability of the specified branch number..</param>
        /// <param name="attributeValue">key value pair -key value..</param>
        public PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }

        /// <summary>
        /// governmentprogramcode: Special Discount details will be provided based on the governmentprogramcode if available. shiptostatebrazil: Attribute Specific to Brazil. shipfrombranchnumber: If provided, displays only the availability of the specified branch number.
        /// </summary>
        /// <value>governmentprogramcode: Special Discount details will be provided based on the governmentprogramcode if available. shiptostatebrazil: Attribute Specific to Brazil. shipfrombranchnumber: If provided, displays only the availability of the specified branch number.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// key value pair -key value.
        /// </summary>
        /// <value>key value pair -key value.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner {\n");
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
