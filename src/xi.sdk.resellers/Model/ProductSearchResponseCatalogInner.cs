/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// ProductSearchResponseCatalogInner
    /// </summary>
    [DataContract(Name = "ProductSearch_Response_catalog_inner")]
    public partial class ProductSearchResponseCatalogInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSearchResponseCatalogInner" /> class.
        /// </summary>
        /// <param name="description">The description of the product..</param>
        /// <param name="category">The category of the product. Example: Displays..</param>
        /// <param name="subCategory">The sub category for the product. Example: ComputernMonitors..</param>
        /// <param name="productType">The product type of the product. Example: LCD Monitors..</param>
        /// <param name="ingramPartNumber">The Unique IngramMicro part number for the product..</param>
        /// <param name="vendorPartNumber">The vendor part number for the product..</param>
        /// <param name="upcCode">The UPC code for the product. Consists of 12 numeric digits that are uniquly assigned to each trade item..</param>
        /// <param name="vendorName">The name of the vendor/manufacturer of the product..</param>
        /// <param name="endUserRequired">Indicates whether the contact information for the end user/customer is required, which determines pricing and discounts..</param>
        /// <param name="hasDiscounts">Specifies if there are discounts available for the product..</param>
        /// <param name="type">The SKU type of product. One of Physical, Digital, or Any..</param>
        /// <param name="discontinued">Indicates if the product has been discontinued..</param>
        /// <param name="newProduct">Indicates if the product is new. For digital products, newer than 10 days. For physical products, newer than 150 days..</param>
        /// <param name="directShip">Indicates if the product will be shipped directly to the reseller or end user from the vendor/manufacturer..</param>
        /// <param name="hasWarranty">Indicates if the product has a warranty..</param>
        /// <param name="links">links.</param>
        /// <param name="extraDescription">The extended description of the product..</param>
        /// <param name="replacementSku">Identifies a SKU that is a comparable subsititution of the current SKU if available..</param>
        /// <param name="authorizedToPurchase">It is true when it exists in matched queries field of ealstic search API..</param>
        public ProductSearchResponseCatalogInner(string description = default(string), string category = default(string), string subCategory = default(string), string productType = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), string upcCode = default(string), string vendorName = default(string), string endUserRequired = default(string), string hasDiscounts = default(string), string type = default(string), string discontinued = default(string), string newProduct = default(string), string directShip = default(string), string hasWarranty = default(string), List<ProductSearchResponseCatalogInnerLinksInner> links = default(List<ProductSearchResponseCatalogInnerLinksInner>), string extraDescription = default(string), string replacementSku = default(string), string authorizedToPurchase = default(string))
        {
            this.Description = description;
            this.Category = category;
            this.SubCategory = subCategory;
            this.ProductType = productType;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.UpcCode = upcCode;
            this.VendorName = vendorName;
            this.EndUserRequired = endUserRequired;
            this.HasDiscounts = hasDiscounts;
            this.Type = type;
            this.Discontinued = discontinued;
            this.NewProduct = newProduct;
            this.DirectShip = directShip;
            this.HasWarranty = hasWarranty;
            this.Links = links;
            this.ExtraDescription = extraDescription;
            this.ReplacementSku = replacementSku;
            this.AuthorizedToPurchase = authorizedToPurchase;
        }

        /// <summary>
        /// The description of the product.
        /// </summary>
        /// <value>The description of the product.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The category of the product. Example: Displays.
        /// </summary>
        /// <value>The category of the product. Example: Displays.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// The sub category for the product. Example: ComputernMonitors.
        /// </summary>
        /// <value>The sub category for the product. Example: ComputernMonitors.</value>
        [DataMember(Name = "subCategory", EmitDefaultValue = false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// The product type of the product. Example: LCD Monitors.
        /// </summary>
        /// <value>The product type of the product. Example: LCD Monitors.</value>
        [DataMember(Name = "productType", EmitDefaultValue = false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The Unique IngramMicro part number for the product.
        /// </summary>
        /// <value>The Unique IngramMicro part number for the product.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The vendor part number for the product.
        /// </summary>
        /// <value>The vendor part number for the product.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The UPC code for the product. Consists of 12 numeric digits that are uniquly assigned to each trade item.
        /// </summary>
        /// <value>The UPC code for the product. Consists of 12 numeric digits that are uniquly assigned to each trade item.</value>
        [DataMember(Name = "upcCode", EmitDefaultValue = false)]
        public string UpcCode { get; set; }

        /// <summary>
        /// The name of the vendor/manufacturer of the product.
        /// </summary>
        /// <value>The name of the vendor/manufacturer of the product.</value>
        [DataMember(Name = "vendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Indicates whether the contact information for the end user/customer is required, which determines pricing and discounts.
        /// </summary>
        /// <value>Indicates whether the contact information for the end user/customer is required, which determines pricing and discounts.</value>
        [DataMember(Name = "endUserRequired", EmitDefaultValue = false)]
        public string EndUserRequired { get; set; }

        /// <summary>
        /// Specifies if there are discounts available for the product.
        /// </summary>
        /// <value>Specifies if there are discounts available for the product.</value>
        [DataMember(Name = "hasDiscounts", EmitDefaultValue = false)]
        public string HasDiscounts { get; set; }

        /// <summary>
        /// The SKU type of product. One of Physical, Digital, or Any.
        /// </summary>
        /// <value>The SKU type of product. One of Physical, Digital, or Any.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Indicates if the product has been discontinued.
        /// </summary>
        /// <value>Indicates if the product has been discontinued.</value>
        [DataMember(Name = "discontinued", EmitDefaultValue = false)]
        public string Discontinued { get; set; }

        /// <summary>
        /// Indicates if the product is new. For digital products, newer than 10 days. For physical products, newer than 150 days.
        /// </summary>
        /// <value>Indicates if the product is new. For digital products, newer than 10 days. For physical products, newer than 150 days.</value>
        [DataMember(Name = "newProduct", EmitDefaultValue = false)]
        public string NewProduct { get; set; }

        /// <summary>
        /// Indicates if the product will be shipped directly to the reseller or end user from the vendor/manufacturer.
        /// </summary>
        /// <value>Indicates if the product will be shipped directly to the reseller or end user from the vendor/manufacturer.</value>
        [DataMember(Name = "directShip", EmitDefaultValue = false)]
        public string DirectShip { get; set; }

        /// <summary>
        /// Indicates if the product has a warranty.
        /// </summary>
        /// <value>Indicates if the product has a warranty.</value>
        [DataMember(Name = "hasWarranty", EmitDefaultValue = false)]
        public string HasWarranty { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<ProductSearchResponseCatalogInnerLinksInner> Links { get; set; }

        /// <summary>
        /// The extended description of the product.
        /// </summary>
        /// <value>The extended description of the product.</value>
        [DataMember(Name = "extraDescription", EmitDefaultValue = false)]
        public string ExtraDescription { get; set; }

        /// <summary>
        /// Identifies a SKU that is a comparable subsititution of the current SKU if available.
        /// </summary>
        /// <value>Identifies a SKU that is a comparable subsititution of the current SKU if available.</value>
        [DataMember(Name = "replacementSku", EmitDefaultValue = false)]
        public string ReplacementSku { get; set; }

        /// <summary>
        /// It is true when it exists in matched queries field of ealstic search API.
        /// </summary>
        /// <value>It is true when it exists in matched queries field of ealstic search API.</value>
        [DataMember(Name = "authorizedToPurchase", EmitDefaultValue = false)]
        public string AuthorizedToPurchase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductSearchResponseCatalogInner {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  SubCategory: ").Append(SubCategory).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  UpcCode: ").Append(UpcCode).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  EndUserRequired: ").Append(EndUserRequired).Append("\n");
            sb.Append("  HasDiscounts: ").Append(HasDiscounts).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Discontinued: ").Append(Discontinued).Append("\n");
            sb.Append("  NewProduct: ").Append(NewProduct).Append("\n");
            sb.Append("  DirectShip: ").Append(DirectShip).Append("\n");
            sb.Append("  HasWarranty: ").Append(HasWarranty).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ExtraDescription: ").Append(ExtraDescription).Append("\n");
            sb.Append("  ReplacementSku: ").Append(ReplacementSku).Append("\n");
            sb.Append("  AuthorizedToPurchase: ").Append(AuthorizedToPurchase).Append("\n");
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
