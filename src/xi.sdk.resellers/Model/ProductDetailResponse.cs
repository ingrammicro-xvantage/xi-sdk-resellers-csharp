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
    /// ProductDetailResponse
    /// </summary>
    [DataContract(Name = "ProductDetailResponse")]
    public partial class ProductDetailResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailResponse" /> class.
        /// </summary>
        /// <param name="ingramPartNumber">Ingram Micro unique part number for the product..</param>
        /// <param name="vendorPartNumber">Vendor’s part number for the product..</param>
        /// <param name="customerPartNumber">Reseller / end-user’s part number for the product..</param>
        /// <param name="productAuthorized">Boolean that indicates whether a product is authorized..</param>
        /// <param name="description">The description given for the product..</param>
        /// <param name="productDetailDescription">The detailed description given for the product..</param>
        /// <param name="upc">The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item..</param>
        /// <param name="productCategory">The category of the product..</param>
        /// <param name="productSubcategory">The sub-category of the product..</param>
        /// <param name="vendorName">Vendor name for the order..</param>
        /// <param name="vendorNumber">Vendor number that identifies the product..</param>
        /// <param name="productStatusCode">Status code of the product..</param>
        /// <param name="productClass">Indicates whether the product is directly shipped from the vendor’s warehouse or if the product ships from Ingram Micro’s warehouse. Class Codes are Ingram classifications on how skus are stocked A &#x3D; Product that is stocked usually in all IM warehouses and replenished on a regular basis. B &#x3D; Product that is stocked in limited IM warehouses and replenished on a regular basis C &#x3D; Product that is stocked in fewer IM warehouses and replenished on a regular basis. D &#x3D; Product that Ingram Micro has elected to discontinue. E &#x3D; Product that will be phased out later, according to the vendor. You may not want to replenish this product, but instead sell down what is in stock. F &#x3D; Product that we carry for a specific customer or supplier under a contractual agreement. N &#x3D; New Sku. Classification before first receipt O &#x3D; Discontinued product to be liquidated S&#x3D; Order for Specialized Demand (Order to backorder) X&#x3D; direct ship from Vendor V &#x3D; product that vendor has elected to discontinue..</param>
        /// <param name="indicators">indicators.</param>
        /// <param name="ciscoFields">ciscoFields.</param>
        /// <param name="technicalSpecifications">Technical specifications of the product..</param>
        /// <param name="warrantyInformation">Warranty information related to the product..</param>
        /// <param name="additionalInformation">additionalInformation.</param>
        public ProductDetailResponse(string ingramPartNumber = default(string), string vendorPartNumber = default(string), string customerPartNumber = default(string), bool productAuthorized = default(bool), string description = default(string), string productDetailDescription = default(string), string upc = default(string), string productCategory = default(string), string productSubcategory = default(string), string vendorName = default(string), string vendorNumber = default(string), string productStatusCode = default(string), string productClass = default(string), ProductDetailResponseIndicators indicators = default(ProductDetailResponseIndicators), ProductDetailResponseCiscoFields ciscoFields = default(ProductDetailResponseCiscoFields), List<ProductDetailResponseTechnicalSpecificationsInner> technicalSpecifications = default(List<ProductDetailResponseTechnicalSpecificationsInner>), List<Object> warrantyInformation = default(List<Object>), ProductDetailResponseAdditionalInformation additionalInformation = default(ProductDetailResponseAdditionalInformation))
        {
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.CustomerPartNumber = customerPartNumber;
            this.ProductAuthorized = productAuthorized;
            this.Description = description;
            this.ProductDetailDescription = productDetailDescription;
            this.Upc = upc;
            this.ProductCategory = productCategory;
            this.ProductSubcategory = productSubcategory;
            this.VendorName = vendorName;
            this.VendorNumber = vendorNumber;
            this.ProductStatusCode = productStatusCode;
            this.ProductClass = productClass;
            this.Indicators = indicators;
            this.CiscoFields = ciscoFields;
            this.TechnicalSpecifications = technicalSpecifications;
            this.WarrantyInformation = warrantyInformation;
            this.AdditionalInformation = additionalInformation;
        }

        /// <summary>
        /// Ingram Micro unique part number for the product.
        /// </summary>
        /// <value>Ingram Micro unique part number for the product.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// Vendor’s part number for the product.
        /// </summary>
        /// <value>Vendor’s part number for the product.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Reseller / end-user’s part number for the product.
        /// </summary>
        /// <value>Reseller / end-user’s part number for the product.</value>
        [DataMember(Name = "customerPartNumber", EmitDefaultValue = false)]
        public string CustomerPartNumber { get; set; }

        /// <summary>
        /// Boolean that indicates whether a product is authorized.
        /// </summary>
        /// <value>Boolean that indicates whether a product is authorized.</value>
        [DataMember(Name = "productAuthorized", EmitDefaultValue = true)]
        public bool ProductAuthorized { get; set; }

        /// <summary>
        /// The description given for the product.
        /// </summary>
        /// <value>The description given for the product.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The detailed description given for the product.
        /// </summary>
        /// <value>The detailed description given for the product.</value>
        [DataMember(Name = "productDetailDescription", EmitDefaultValue = false)]
        public string ProductDetailDescription { get; set; }

        /// <summary>
        /// The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item.
        /// </summary>
        /// <value>The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item.</value>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        public string Upc { get; set; }

        /// <summary>
        /// The category of the product.
        /// </summary>
        /// <value>The category of the product.</value>
        [DataMember(Name = "productCategory", EmitDefaultValue = false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// The sub-category of the product.
        /// </summary>
        /// <value>The sub-category of the product.</value>
        [DataMember(Name = "productSubcategory", EmitDefaultValue = false)]
        public string ProductSubcategory { get; set; }

        /// <summary>
        /// Vendor name for the order.
        /// </summary>
        /// <value>Vendor name for the order.</value>
        [DataMember(Name = "vendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Vendor number that identifies the product.
        /// </summary>
        /// <value>Vendor number that identifies the product.</value>
        [DataMember(Name = "vendorNumber", EmitDefaultValue = false)]
        public string VendorNumber { get; set; }

        /// <summary>
        /// Status code of the product.
        /// </summary>
        /// <value>Status code of the product.</value>
        [DataMember(Name = "productStatusCode", EmitDefaultValue = false)]
        public string ProductStatusCode { get; set; }

        /// <summary>
        /// Indicates whether the product is directly shipped from the vendor’s warehouse or if the product ships from Ingram Micro’s warehouse. Class Codes are Ingram classifications on how skus are stocked A &#x3D; Product that is stocked usually in all IM warehouses and replenished on a regular basis. B &#x3D; Product that is stocked in limited IM warehouses and replenished on a regular basis C &#x3D; Product that is stocked in fewer IM warehouses and replenished on a regular basis. D &#x3D; Product that Ingram Micro has elected to discontinue. E &#x3D; Product that will be phased out later, according to the vendor. You may not want to replenish this product, but instead sell down what is in stock. F &#x3D; Product that we carry for a specific customer or supplier under a contractual agreement. N &#x3D; New Sku. Classification before first receipt O &#x3D; Discontinued product to be liquidated S&#x3D; Order for Specialized Demand (Order to backorder) X&#x3D; direct ship from Vendor V &#x3D; product that vendor has elected to discontinue.
        /// </summary>
        /// <value>Indicates whether the product is directly shipped from the vendor’s warehouse or if the product ships from Ingram Micro’s warehouse. Class Codes are Ingram classifications on how skus are stocked A &#x3D; Product that is stocked usually in all IM warehouses and replenished on a regular basis. B &#x3D; Product that is stocked in limited IM warehouses and replenished on a regular basis C &#x3D; Product that is stocked in fewer IM warehouses and replenished on a regular basis. D &#x3D; Product that Ingram Micro has elected to discontinue. E &#x3D; Product that will be phased out later, according to the vendor. You may not want to replenish this product, but instead sell down what is in stock. F &#x3D; Product that we carry for a specific customer or supplier under a contractual agreement. N &#x3D; New Sku. Classification before first receipt O &#x3D; Discontinued product to be liquidated S&#x3D; Order for Specialized Demand (Order to backorder) X&#x3D; direct ship from Vendor V &#x3D; product that vendor has elected to discontinue.</value>
        [DataMember(Name = "productClass", EmitDefaultValue = false)]
        public string ProductClass { get; set; }

        /// <summary>
        /// Gets or Sets Indicators
        /// </summary>
        [DataMember(Name = "indicators", EmitDefaultValue = false)]
        public ProductDetailResponseIndicators Indicators { get; set; }

        /// <summary>
        /// Gets or Sets CiscoFields
        /// </summary>
        [DataMember(Name = "ciscoFields", EmitDefaultValue = false)]
        public ProductDetailResponseCiscoFields CiscoFields { get; set; }

        /// <summary>
        /// Technical specifications of the product.
        /// </summary>
        /// <value>Technical specifications of the product.</value>
        [DataMember(Name = "technicalSpecifications", EmitDefaultValue = false)]
        public List<ProductDetailResponseTechnicalSpecificationsInner> TechnicalSpecifications { get; set; }

        /// <summary>
        /// Warranty information related to the product.
        /// </summary>
        /// <value>Warranty information related to the product.</value>
        [DataMember(Name = "warrantyInformation", EmitDefaultValue = false)]
        public List<Object> WarrantyInformation { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInformation
        /// </summary>
        [DataMember(Name = "additionalInformation", EmitDefaultValue = false)]
        public ProductDetailResponseAdditionalInformation AdditionalInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDetailResponse {\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  CustomerPartNumber: ").Append(CustomerPartNumber).Append("\n");
            sb.Append("  ProductAuthorized: ").Append(ProductAuthorized).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProductDetailDescription: ").Append(ProductDetailDescription).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  ProductCategory: ").Append(ProductCategory).Append("\n");
            sb.Append("  ProductSubcategory: ").Append(ProductSubcategory).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  VendorNumber: ").Append(VendorNumber).Append("\n");
            sb.Append("  ProductStatusCode: ").Append(ProductStatusCode).Append("\n");
            sb.Append("  ProductClass: ").Append(ProductClass).Append("\n");
            sb.Append("  Indicators: ").Append(Indicators).Append("\n");
            sb.Append("  CiscoFields: ").Append(CiscoFields).Append("\n");
            sb.Append("  TechnicalSpecifications: ").Append(TechnicalSpecifications).Append("\n");
            sb.Append("  WarrantyInformation: ").Append(WarrantyInformation).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
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
