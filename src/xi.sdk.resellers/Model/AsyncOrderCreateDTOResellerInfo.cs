/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    /// The address and contact information provided by the reseller.
    /// </summary>
    [DataContract(Name = "AsyncOrderCreateDTO_resellerInfo")]
    public partial class AsyncOrderCreateDTOResellerInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateDTOResellerInfo" /> class.
        /// </summary>
        /// <param name="resellerId">The reseller&#39;s Id..</param>
        /// <param name="companyName">The reseller&#39;s company name..</param>
        /// <param name="contact">The reseller&#39;s contact name..</param>
        /// <param name="addressLine1">The reseller&#39;s address line 1..</param>
        /// <param name="addressLine2">The reseller&#39;s address line 2..</param>
        /// <param name="addressLine3">The reseller&#39;s address line 3..</param>
        /// <param name="addressLine4">The reseller&#39;s address line 4..</param>
        /// <param name="city">The reseller&#39;s city..</param>
        /// <param name="state">The reseller&#39;s state..</param>
        /// <param name="postalCode">The reseller&#39;s zip or postal code..</param>
        /// <param name="countryCode">The reseller&#39;s two-character ISO country code..</param>
        /// <param name="phoneNumber">The reseller&#39;s phone number..</param>
        /// <param name="email">The reseller&#39;s Email Address..</param>
        public AsyncOrderCreateDTOResellerInfo(string resellerId = default(string), string companyName = default(string), string contact = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), string phoneNumber = default(string), string email = default(string))
        {
            this.ResellerId = resellerId;
            this.CompanyName = companyName;
            this.Contact = contact;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// The reseller&#39;s Id.
        /// </summary>
        /// <value>The reseller&#39;s Id.</value>
        [DataMember(Name = "resellerId", EmitDefaultValue = false)]
        public string ResellerId { get; set; }

        /// <summary>
        /// The reseller&#39;s company name.
        /// </summary>
        /// <value>The reseller&#39;s company name.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The reseller&#39;s contact name.
        /// </summary>
        /// <value>The reseller&#39;s contact name.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// The reseller&#39;s address line 1.
        /// </summary>
        /// <value>The reseller&#39;s address line 1.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The reseller&#39;s address line 2.
        /// </summary>
        /// <value>The reseller&#39;s address line 2.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The reseller&#39;s address line 3.
        /// </summary>
        /// <value>The reseller&#39;s address line 3.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The reseller&#39;s address line 4.
        /// </summary>
        /// <value>The reseller&#39;s address line 4.</value>
        [DataMember(Name = "addressLine4", EmitDefaultValue = false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// The reseller&#39;s city.
        /// </summary>
        /// <value>The reseller&#39;s city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The reseller&#39;s state.
        /// </summary>
        /// <value>The reseller&#39;s state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The reseller&#39;s zip or postal code.
        /// </summary>
        /// <value>The reseller&#39;s zip or postal code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The reseller&#39;s two-character ISO country code.
        /// </summary>
        /// <value>The reseller&#39;s two-character ISO country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The reseller&#39;s phone number.
        /// </summary>
        /// <value>The reseller&#39;s phone number.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The reseller&#39;s Email Address.
        /// </summary>
        /// <value>The reseller&#39;s Email Address.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsyncOrderCreateDTOResellerInfo {\n");
            sb.Append("  ResellerId: ").Append(ResellerId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
