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
    /// OrderCreateRequestLinesInnerEndUserInfoInner
    /// </summary>
    [DataContract(Name = "OrderCreateRequest_lines_inner_endUserInfo_inner")]
    public partial class OrderCreateRequestLinesInnerEndUserInfoInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestLinesInnerEndUserInfoInner" /> class.
        /// </summary>
        /// <param name="endUserType">Specifies the type of endUser. It can be endUser or endUserContact for SAP flow..</param>
        /// <param name="endUserId">ID for the end user/customer in Ingram Micro&#39;s system..</param>
        /// <param name="contact">The contact name for the end user/customer..</param>
        /// <param name="companyName">The company name for the end user/customer..</param>
        /// <param name="name1">name1.</param>
        /// <param name="name2">name2.</param>
        /// <param name="addressLine1">The end user/customer&#39;s street address and building or house number..</param>
        /// <param name="addressLine2">The end user/customer&#39;s apartment number..</param>
        /// <param name="addressLine3">Line 3 of the address for the end user/customer..</param>
        /// <param name="addressLine4">Street address4.</param>
        /// <param name="city">The end user/customer&#39;s city..</param>
        /// <param name="state">The end user/customer&#39;s state..</param>
        /// <param name="postalCode">The end user/customer&#39;s zip or postal code..</param>
        /// <param name="countryCode">The end user/customer&#39;s two-character ISO country code..</param>
        /// <param name="phoneNumber">The end user/customer&#39;s phone number..</param>
        /// <param name="email">The end user/customer&#39;s email..</param>
        public OrderCreateRequestLinesInnerEndUserInfoInner(string endUserType = default(string), string endUserId = default(string), string contact = default(string), string companyName = default(string), string name1 = default(string), string name2 = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), decimal phoneNumber = default(decimal), string email = default(string))
        {
            this.EndUserType = endUserType;
            this.EndUserId = endUserId;
            this.Contact = contact;
            this.CompanyName = companyName;
            this.Name1 = name1;
            this.Name2 = name2;
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
        /// Specifies the type of endUser. It can be endUser or endUserContact for SAP flow.
        /// </summary>
        /// <value>Specifies the type of endUser. It can be endUser or endUserContact for SAP flow.</value>
        [DataMember(Name = "endUserType", EmitDefaultValue = false)]
        public string EndUserType { get; set; }

        /// <summary>
        /// ID for the end user/customer in Ingram Micro&#39;s system.
        /// </summary>
        /// <value>ID for the end user/customer in Ingram Micro&#39;s system.</value>
        [DataMember(Name = "endUserId", EmitDefaultValue = false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The contact name for the end user/customer.
        /// </summary>
        /// <value>The contact name for the end user/customer.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// The company name for the end user/customer.
        /// </summary>
        /// <value>The company name for the end user/customer.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// name1
        /// </summary>
        /// <value>name1</value>
        [DataMember(Name = "name1", EmitDefaultValue = false)]
        public string Name1 { get; set; }

        /// <summary>
        /// name2
        /// </summary>
        /// <value>name2</value>
        [DataMember(Name = "name2", EmitDefaultValue = false)]
        public string Name2 { get; set; }

        /// <summary>
        /// The end user/customer&#39;s street address and building or house number.
        /// </summary>
        /// <value>The end user/customer&#39;s street address and building or house number.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The end user/customer&#39;s apartment number.
        /// </summary>
        /// <value>The end user/customer&#39;s apartment number.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Line 3 of the address for the end user/customer.
        /// </summary>
        /// <value>Line 3 of the address for the end user/customer.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Street address4
        /// </summary>
        /// <value>Street address4</value>
        [DataMember(Name = "addressLine4", EmitDefaultValue = false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// The end user/customer&#39;s city.
        /// </summary>
        /// <value>The end user/customer&#39;s city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The end user/customer&#39;s state.
        /// </summary>
        /// <value>The end user/customer&#39;s state.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The end user/customer&#39;s zip or postal code.
        /// </summary>
        /// <value>The end user/customer&#39;s zip or postal code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The end user/customer&#39;s two-character ISO country code.
        /// </summary>
        /// <value>The end user/customer&#39;s two-character ISO country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The end user/customer&#39;s phone number.
        /// </summary>
        /// <value>The end user/customer&#39;s phone number.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public decimal PhoneNumber { get; set; }

        /// <summary>
        /// The end user/customer&#39;s email.
        /// </summary>
        /// <value>The end user/customer&#39;s email.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestLinesInnerEndUserInfoInner {\n");
            sb.Append("  EndUserType: ").Append(EndUserType).Append("\n");
            sb.Append("  EndUserId: ").Append(EndUserId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Name1: ").Append(Name1).Append("\n");
            sb.Append("  Name2: ").Append(Name2).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // EndUserId (string) maxLength
            if (this.EndUserId != null && this.EndUserId.Length > 10)
            {
                yield return new ValidationResult("Invalid value for EndUserId, length must be less than 10.", new [] { "EndUserId" });
            }

            // Name1 (string) maxLength
            if (this.Name1 != null && this.Name1.Length > 35)
            {
                yield return new ValidationResult("Invalid value for Name1, length must be less than 35.", new [] { "Name1" });
            }

            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 3)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be less than 3.", new [] { "CountryCode" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 241)
            {
                yield return new ValidationResult("Invalid value for Email, length must be less than 241.", new [] { "Email" });
            }

            yield break;
        }
    }

}
