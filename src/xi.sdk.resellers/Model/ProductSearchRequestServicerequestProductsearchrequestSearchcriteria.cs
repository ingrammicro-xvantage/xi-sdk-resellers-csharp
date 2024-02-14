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
    /// ProductSearchRequestServicerequestProductsearchrequestSearchcriteria
    /// </summary>
    [DataContract(Name = "productSearchRequest_servicerequest_productsearchrequest_searchcriteria")]
    public partial class ProductSearchRequestServicerequestProductsearchrequestSearchcriteria : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSearchRequestServicerequestProductsearchrequestSearchcriteria" /> class.
        /// </summary>
        /// <param name="vendor">Name of the vendor or manufacturer or brand of the product.</param>
        /// <param name="vendorpartnumber">Vendor provided part number.</param>
        /// <param name="partdescription">This field seraches the decriptioon of the product..</param>
        /// <param name="uPC">Universal Product Code.</param>
        /// <param name="customerpartnumber">Customer’s designated part number .</param>
        public ProductSearchRequestServicerequestProductsearchrequestSearchcriteria(string vendor = default(string), string vendorpartnumber = default(string), string partdescription = default(string), string uPC = default(string), string customerpartnumber = default(string))
        {
            this.Vendor = vendor;
            this.Vendorpartnumber = vendorpartnumber;
            this.Partdescription = partdescription;
            this.UPC = uPC;
            this.Customerpartnumber = customerpartnumber;
        }

        /// <summary>
        /// Name of the vendor or manufacturer or brand of the product
        /// </summary>
        /// <value>Name of the vendor or manufacturer or brand of the product</value>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Vendor provided part number
        /// </summary>
        /// <value>Vendor provided part number</value>
        /// <example>WKB-1500GB</example>
        [DataMember(Name = "vendorpartnumber", EmitDefaultValue = false)]
        public string Vendorpartnumber { get; set; }

        /// <summary>
        /// This field seraches the decriptioon of the product.
        /// </summary>
        /// <value>This field seraches the decriptioon of the product.</value>
        /// <example>WRLS ERGO KEYBOARD &amp; MOUSE</example>
        [DataMember(Name = "partdescription", EmitDefaultValue = false)]
        public string Partdescription { get; set; }

        /// <summary>
        /// Universal Product Code
        /// </summary>
        /// <value>Universal Product Code</value>
        /// <example>783750005524</example>
        [DataMember(Name = "UPC", EmitDefaultValue = false)]
        public string UPC { get; set; }

        /// <summary>
        /// Customer’s designated part number 
        /// </summary>
        /// <value>Customer’s designated part number </value>
        [DataMember(Name = "customerpartnumber", EmitDefaultValue = false)]
        public string Customerpartnumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductSearchRequestServicerequestProductsearchrequestSearchcriteria {\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Vendorpartnumber: ").Append(Vendorpartnumber).Append("\n");
            sb.Append("  Partdescription: ").Append(Partdescription).Append("\n");
            sb.Append("  UPC: ").Append(UPC).Append("\n");
            sb.Append("  Customerpartnumber: ").Append(Customerpartnumber).Append("\n");
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
