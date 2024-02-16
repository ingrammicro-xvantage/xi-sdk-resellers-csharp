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
    /// Cisco product related information.
    /// </summary>
    [DataContract(Name = "ProductDetailResponse_ciscoFields")]
    public partial class ProductDetailResponseCiscoFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailResponseCiscoFields" /> class.
        /// </summary>
        /// <param name="productSubGroup">Cisco product sub-group.</param>
        /// <param name="serviceProgramName">Cisco service program name.</param>
        /// <param name="itemCatalogCategory">Cisco item catalog category.</param>
        /// <param name="configurationIndicator">Cisco configuration indicator.</param>
        /// <param name="internalBusinessEntity">Cisco internal business entity.</param>
        /// <param name="itemType">Cisco item type.</param>
        /// <param name="globalListPrice">Cisco global list price.</param>
        public ProductDetailResponseCiscoFields(string productSubGroup = default(string), string serviceProgramName = default(string), string itemCatalogCategory = default(string), string configurationIndicator = default(string), string internalBusinessEntity = default(string), string itemType = default(string), string globalListPrice = default(string))
        {
            this.ProductSubGroup = productSubGroup;
            this.ServiceProgramName = serviceProgramName;
            this.ItemCatalogCategory = itemCatalogCategory;
            this.ConfigurationIndicator = configurationIndicator;
            this.InternalBusinessEntity = internalBusinessEntity;
            this.ItemType = itemType;
            this.GlobalListPrice = globalListPrice;
        }

        /// <summary>
        /// Cisco product sub-group
        /// </summary>
        /// <value>Cisco product sub-group</value>
        [DataMember(Name = "productSubGroup", EmitDefaultValue = false)]
        public string ProductSubGroup { get; set; }

        /// <summary>
        /// Cisco service program name
        /// </summary>
        /// <value>Cisco service program name</value>
        [DataMember(Name = "serviceProgramName", EmitDefaultValue = false)]
        public string ServiceProgramName { get; set; }

        /// <summary>
        /// Cisco item catalog category
        /// </summary>
        /// <value>Cisco item catalog category</value>
        [DataMember(Name = "itemCatalogCategory", EmitDefaultValue = false)]
        public string ItemCatalogCategory { get; set; }

        /// <summary>
        /// Cisco configuration indicator
        /// </summary>
        /// <value>Cisco configuration indicator</value>
        [DataMember(Name = "configurationIndicator", EmitDefaultValue = false)]
        public string ConfigurationIndicator { get; set; }

        /// <summary>
        /// Cisco internal business entity
        /// </summary>
        /// <value>Cisco internal business entity</value>
        [DataMember(Name = "internalBusinessEntity", EmitDefaultValue = false)]
        public string InternalBusinessEntity { get; set; }

        /// <summary>
        /// Cisco item type
        /// </summary>
        /// <value>Cisco item type</value>
        [DataMember(Name = "itemType", EmitDefaultValue = false)]
        public string ItemType { get; set; }

        /// <summary>
        /// Cisco global list price
        /// </summary>
        /// <value>Cisco global list price</value>
        [DataMember(Name = "globalListPrice", EmitDefaultValue = false)]
        public string GlobalListPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDetailResponseCiscoFields {\n");
            sb.Append("  ProductSubGroup: ").Append(ProductSubGroup).Append("\n");
            sb.Append("  ServiceProgramName: ").Append(ServiceProgramName).Append("\n");
            sb.Append("  ItemCatalogCategory: ").Append(ItemCatalogCategory).Append("\n");
            sb.Append("  ConfigurationIndicator: ").Append(ConfigurationIndicator).Append("\n");
            sb.Append("  InternalBusinessEntity: ").Append(InternalBusinessEntity).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  GlobalListPrice: ").Append(GlobalListPrice).Append("\n");
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