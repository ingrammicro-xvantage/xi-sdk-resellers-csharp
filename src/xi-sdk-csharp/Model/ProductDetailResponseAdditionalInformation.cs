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
    /// Additional Information related to the product.
    /// </summary>
    [DataContract(Name = "ProductDetailResponse_additionalInformation")]
    public partial class ProductDetailResponseAdditionalInformation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailResponseAdditionalInformation" /> class.
        /// </summary>
        /// <param name="productWeight">Weight information related to the product..</param>
        /// <param name="isBulkFreight">Example : true or false.</param>
        /// <param name="height">Example : &#39;5.2 Inches&#39;.</param>
        /// <param name="width">Example : &#39;13 inches&#39;.</param>
        /// <param name="length">Example : &#39;20.4 inches&#39;.</param>
        /// <param name="netWeight">Example : &#39;10 lb&#39;.</param>
        /// <param name="dimensionUnit">Example : &#39;Unit value&#39;.</param>
        public ProductDetailResponseAdditionalInformation(List<ProductDetailResponseAdditionalInformationProductWeightInner> productWeight = default(List<ProductDetailResponseAdditionalInformationProductWeightInner>), bool isBulkFreight = default(bool), string height = default(string), string width = default(string), string length = default(string), string netWeight = default(string), string dimensionUnit = default(string))
        {
            this.ProductWeight = productWeight;
            this.IsBulkFreight = isBulkFreight;
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.NetWeight = netWeight;
            this.DimensionUnit = dimensionUnit;
        }

        /// <summary>
        /// Weight information related to the product.
        /// </summary>
        /// <value>Weight information related to the product.</value>
        [DataMember(Name = "productWeight", EmitDefaultValue = false)]
        public List<ProductDetailResponseAdditionalInformationProductWeightInner> ProductWeight { get; set; }

        /// <summary>
        /// Example : true or false
        /// </summary>
        /// <value>Example : true or false</value>
        [DataMember(Name = "isBulkFreight", EmitDefaultValue = true)]
        public bool IsBulkFreight { get; set; }

        /// <summary>
        /// Example : &#39;5.2 Inches&#39;
        /// </summary>
        /// <value>Example : &#39;5.2 Inches&#39;</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public string Height { get; set; }

        /// <summary>
        /// Example : &#39;13 inches&#39;
        /// </summary>
        /// <value>Example : &#39;13 inches&#39;</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public string Width { get; set; }

        /// <summary>
        /// Example : &#39;20.4 inches&#39;
        /// </summary>
        /// <value>Example : &#39;20.4 inches&#39;</value>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public string Length { get; set; }

        /// <summary>
        /// Example : &#39;10 lb&#39;
        /// </summary>
        /// <value>Example : &#39;10 lb&#39;</value>
        [DataMember(Name = "netWeight", EmitDefaultValue = false)]
        public string NetWeight { get; set; }

        /// <summary>
        /// Example : &#39;Unit value&#39;
        /// </summary>
        /// <value>Example : &#39;Unit value&#39;</value>
        [DataMember(Name = "dimensionUnit", EmitDefaultValue = false)]
        public string DimensionUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDetailResponseAdditionalInformation {\n");
            sb.Append("  ProductWeight: ").Append(ProductWeight).Append("\n");
            sb.Append("  IsBulkFreight: ").Append(IsBulkFreight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  NetWeight: ").Append(NetWeight).Append("\n");
            sb.Append("  DimensionUnit: ").Append(DimensionUnit).Append("\n");
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
