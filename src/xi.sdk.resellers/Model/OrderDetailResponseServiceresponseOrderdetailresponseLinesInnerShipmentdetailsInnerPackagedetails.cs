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
    /// OrderDetailResponseServiceresponseOrderdetailresponseLinesInnerShipmentdetailsInnerPackagedetails
    /// </summary>
    [DataContract(Name = "orderDetailResponse_serviceresponse_orderdetailresponse_lines_inner_shipmentdetails_inner_packagedetails")]
    public partial class OrderDetailResponseServiceresponseOrderdetailresponseLinesInnerShipmentdetailsInnerPackagedetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailResponseServiceresponseOrderdetailresponseLinesInnerShipmentdetailsInnerPackagedetails" /> class.
        /// </summary>
        /// <param name="trackingnumber">trackingnumber.</param>
        /// <param name="packageweight">packageweight.</param>
        /// <param name="cartonnumber">cartonnumber.</param>
        /// <param name="quantityinbox">quantityinbox.</param>
        public OrderDetailResponseServiceresponseOrderdetailresponseLinesInnerShipmentdetailsInnerPackagedetails(string trackingnumber = default(string), string packageweight = default(string), string cartonnumber = default(string), string quantityinbox = default(string))
        {
            this.Trackingnumber = trackingnumber;
            this.Packageweight = packageweight;
            this.Cartonnumber = cartonnumber;
            this.Quantityinbox = quantityinbox;
        }

        /// <summary>
        /// Gets or Sets Trackingnumber
        /// </summary>
        [DataMember(Name = "trackingnumber", EmitDefaultValue = false)]
        public string Trackingnumber { get; set; }

        /// <summary>
        /// Gets or Sets Packageweight
        /// </summary>
        [DataMember(Name = "packageweight", EmitDefaultValue = false)]
        public string Packageweight { get; set; }

        /// <summary>
        /// Gets or Sets Cartonnumber
        /// </summary>
        [DataMember(Name = "cartonnumber", EmitDefaultValue = false)]
        public string Cartonnumber { get; set; }

        /// <summary>
        /// Gets or Sets Quantityinbox
        /// </summary>
        [DataMember(Name = "quantityinbox", EmitDefaultValue = false)]
        public string Quantityinbox { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailResponseServiceresponseOrderdetailresponseLinesInnerShipmentdetailsInnerPackagedetails {\n");
            sb.Append("  Trackingnumber: ").Append(Trackingnumber).Append("\n");
            sb.Append("  Packageweight: ").Append(Packageweight).Append("\n");
            sb.Append("  Cartonnumber: ").Append(Cartonnumber).Append("\n");
            sb.Append("  Quantityinbox: ").Append(Quantityinbox).Append("\n");
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
