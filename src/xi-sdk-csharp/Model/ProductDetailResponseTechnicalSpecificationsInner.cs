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
    /// ProductDetailResponseTechnicalSpecificationsInner
    /// </summary>
    [DataContract(Name = "ProductDetailResponse_technicalSpecifications_inner")]
    public partial class ProductDetailResponseTechnicalSpecificationsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailResponseTechnicalSpecificationsInner" /> class.
        /// </summary>
        /// <param name="headername">Example : &#39;Basic&#39;.</param>
        /// <param name="attributevalue">Example : &#39;LCD Monitor&#39;.</param>
        /// <param name="attributedisplay">Example : &#39;Basic|Product Type|LCD Monitor&#39;.</param>
        /// <param name="attributename">Example : &#39;Product Type&#39;.</param>
        public ProductDetailResponseTechnicalSpecificationsInner(string headername = default(string), string attributevalue = default(string), string attributedisplay = default(string), string attributename = default(string))
        {
            this.Headername = headername;
            this.Attributevalue = attributevalue;
            this.Attributedisplay = attributedisplay;
            this.Attributename = attributename;
        }

        /// <summary>
        /// Example : &#39;Basic&#39;
        /// </summary>
        /// <value>Example : &#39;Basic&#39;</value>
        [DataMember(Name = "headername", EmitDefaultValue = false)]
        public string Headername { get; set; }

        /// <summary>
        /// Example : &#39;LCD Monitor&#39;
        /// </summary>
        /// <value>Example : &#39;LCD Monitor&#39;</value>
        [DataMember(Name = "attributevalue", EmitDefaultValue = false)]
        public string Attributevalue { get; set; }

        /// <summary>
        /// Example : &#39;Basic|Product Type|LCD Monitor&#39;
        /// </summary>
        /// <value>Example : &#39;Basic|Product Type|LCD Monitor&#39;</value>
        [DataMember(Name = "attributedisplay", EmitDefaultValue = false)]
        public string Attributedisplay { get; set; }

        /// <summary>
        /// Example : &#39;Product Type&#39;
        /// </summary>
        /// <value>Example : &#39;Product Type&#39;</value>
        [DataMember(Name = "attributename", EmitDefaultValue = false)]
        public string Attributename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDetailResponseTechnicalSpecificationsInner {\n");
            sb.Append("  Headername: ").Append(Headername).Append("\n");
            sb.Append("  Attributevalue: ").Append(Attributevalue).Append("\n");
            sb.Append("  Attributedisplay: ").Append(Attributedisplay).Append("\n");
            sb.Append("  Attributename: ").Append(Attributename).Append("\n");
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
