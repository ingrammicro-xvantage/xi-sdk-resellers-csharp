/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// FreightRequestShipToAddressInner
    /// </summary>
    [DataContract(Name = "freightRequest_shipToAddress_inner")]
    public partial class FreightRequestShipToAddressInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreightRequestShipToAddressInner" /> class.
        /// </summary>
        /// <param name="companyName">The name of the company the order will be shipped to..</param>
        /// <param name="addressLine1">Line 1 of the address the order will be shipped to..</param>
        /// <param name="addressLine2">Line 2 of the address the order will be shipped to..</param>
        /// <param name="addressLine3">Line 3 of the address the order will be shipped to..</param>
        /// <param name="city">The city the order will be shipped to..</param>
        /// <param name="state">The state the order will be shipped to..</param>
        /// <param name="postalCode">The zip or postal code the order will be shipped to..</param>
        /// <param name="countryCode">The two-character ISO country code the order will be shipped to..</param>
        public FreightRequestShipToAddressInner(string companyName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string))
        {
            this.CompanyName = companyName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// The name of the company the order will be shipped to.
        /// </summary>
        /// <value>The name of the company the order will be shipped to.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Line 1 of the address the order will be shipped to.
        /// </summary>
        /// <value>Line 1 of the address the order will be shipped to.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Line 2 of the address the order will be shipped to.
        /// </summary>
        /// <value>Line 2 of the address the order will be shipped to.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Line 3 of the address the order will be shipped to.
        /// </summary>
        /// <value>Line 3 of the address the order will be shipped to.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city the order will be shipped to.
        /// </summary>
        /// <value>The city the order will be shipped to.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The state the order will be shipped to.
        /// </summary>
        /// <value>The state the order will be shipped to.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The zip or postal code the order will be shipped to.
        /// </summary>
        /// <value>The zip or postal code the order will be shipped to.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two-character ISO country code the order will be shipped to.
        /// </summary>
        /// <value>The two-character ISO country code the order will be shipped to.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FreightRequestShipToAddressInner {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
