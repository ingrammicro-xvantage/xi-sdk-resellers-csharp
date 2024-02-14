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
    /// MultiSKUPriceAndStockRequestServicerequestPriceandstockrequestItem
    /// </summary>
    [DataContract(Name = "multiSKUPriceAndStockRequest_servicerequest_priceandstockrequest_item")]
    public partial class MultiSKUPriceAndStockRequestServicerequestPriceandstockrequestItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSKUPriceAndStockRequestServicerequestPriceandstockrequestItem" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="ingrampartnumber">Ingram Micro system specific SKU number for the product for which the price is requested at Ingram Micro.</param>
        /// <param name="vendorpartnumber">Vendor Part Number for the product for which the price is requested at Ingram Micro.</param>
        /// <param name="uPC">Universal Product code for the product for which the price is requested at Ingram Micro.</param>
        /// <param name="customerpartnumber">Unique identification number of customer. For this option the Ingram Micro Sales rep must set up a cross reference table. .</param>
        /// <param name="warehouseidlist">Unique identity for Ingram Micro warehouses against which stock details are returned..</param>
        public MultiSKUPriceAndStockRequestServicerequestPriceandstockrequestItem(int index = default(int), string ingrampartnumber = default(string), string vendorpartnumber = default(string), string uPC = default(string), string customerpartnumber = default(string), string warehouseidlist = default(string))
        {
            this.Index = index;
            this.Ingrampartnumber = ingrampartnumber;
            this.Vendorpartnumber = vendorpartnumber;
            this.UPC = uPC;
            this.Customerpartnumber = customerpartnumber;
            this.Warehouseidlist = warehouseidlist;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Ingram Micro system specific SKU number for the product for which the price is requested at Ingram Micro
        /// </summary>
        /// <value>Ingram Micro system specific SKU number for the product for which the price is requested at Ingram Micro</value>
        [DataMember(Name = "ingrampartnumber", EmitDefaultValue = false)]
        public string Ingrampartnumber { get; set; }

        /// <summary>
        /// Vendor Part Number for the product for which the price is requested at Ingram Micro
        /// </summary>
        /// <value>Vendor Part Number for the product for which the price is requested at Ingram Micro</value>
        [DataMember(Name = "vendorpartnumber", EmitDefaultValue = false)]
        public string Vendorpartnumber { get; set; }

        /// <summary>
        /// Universal Product code for the product for which the price is requested at Ingram Micro
        /// </summary>
        /// <value>Universal Product code for the product for which the price is requested at Ingram Micro</value>
        [DataMember(Name = "UPC", EmitDefaultValue = false)]
        public string UPC { get; set; }

        /// <summary>
        /// Unique identification number of customer. For this option the Ingram Micro Sales rep must set up a cross reference table. 
        /// </summary>
        /// <value>Unique identification number of customer. For this option the Ingram Micro Sales rep must set up a cross reference table. </value>
        [DataMember(Name = "customerpartnumber", EmitDefaultValue = false)]
        public string Customerpartnumber { get; set; }

        /// <summary>
        /// Unique identity for Ingram Micro warehouses against which stock details are returned.
        /// </summary>
        /// <value>Unique identity for Ingram Micro warehouses against which stock details are returned.</value>
        [DataMember(Name = "warehouseidlist", EmitDefaultValue = false)]
        public string Warehouseidlist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultiSKUPriceAndStockRequestServicerequestPriceandstockrequestItem {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Ingrampartnumber: ").Append(Ingrampartnumber).Append("\n");
            sb.Append("  Vendorpartnumber: ").Append(Vendorpartnumber).Append("\n");
            sb.Append("  UPC: ").Append(UPC).Append("\n");
            sb.Append("  Customerpartnumber: ").Append(Customerpartnumber).Append("\n");
            sb.Append("  Warehouseidlist: ").Append(Warehouseidlist).Append("\n");
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
