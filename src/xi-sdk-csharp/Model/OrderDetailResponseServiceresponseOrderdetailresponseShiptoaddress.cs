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
    /// OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress
    /// </summary>
    [DataContract(Name = "orderDetailResponse_serviceresponse_orderdetailresponse_shiptoaddress")]
    public partial class OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress" /> class.
        /// </summary>
        /// <param name="suffix">suffix.</param>
        /// <param name="attention">attention.</param>
        /// <param name="name">name.</param>
        /// <param name="addressline1">addressline1.</param>
        /// <param name="addressline2">addressline2.</param>
        /// <param name="addressline3">addressline3.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="postalcode">postalcode.</param>
        /// <param name="countrycode">countrycode.</param>
        public OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress(string suffix = default(string), string attention = default(string), string name = default(string), string addressline1 = default(string), string addressline2 = default(string), string addressline3 = default(string), string city = default(string), string state = default(string), string postalcode = default(string), string countrycode = default(string))
        {
            this.Suffix = suffix;
            this.Attention = attention;
            this.Name = name;
            this.Addressline1 = addressline1;
            this.Addressline2 = addressline2;
            this.Addressline3 = addressline3;
            this.City = city;
            this.State = state;
            this.Postalcode = postalcode;
            this.Countrycode = countrycode;
        }

        /// <summary>
        /// Gets or Sets Suffix
        /// </summary>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name = "attention", EmitDefaultValue = false)]
        public string Attention { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Addressline1
        /// </summary>
        [DataMember(Name = "addressline1", EmitDefaultValue = false)]
        public string Addressline1 { get; set; }

        /// <summary>
        /// Gets or Sets Addressline2
        /// </summary>
        [DataMember(Name = "addressline2", EmitDefaultValue = false)]
        public string Addressline2 { get; set; }

        /// <summary>
        /// Gets or Sets Addressline3
        /// </summary>
        [DataMember(Name = "addressline3", EmitDefaultValue = false)]
        public string Addressline3 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Postalcode
        /// </summary>
        [DataMember(Name = "postalcode", EmitDefaultValue = false)]
        public string Postalcode { get; set; }

        /// <summary>
        /// Gets or Sets Countrycode
        /// </summary>
        [DataMember(Name = "countrycode", EmitDefaultValue = false)]
        public string Countrycode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress {\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Addressline1: ").Append(Addressline1).Append("\n");
            sb.Append("  Addressline2: ").Append(Addressline2).Append("\n");
            sb.Append("  Addressline3: ").Append(Addressline3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postalcode: ").Append(Postalcode).Append("\n");
            sb.Append("  Countrycode: ").Append(Countrycode).Append("\n");
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
