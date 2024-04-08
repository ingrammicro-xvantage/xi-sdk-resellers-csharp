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
    /// InvoiceDetailsv61ResponseBillToInfo
    /// </summary>
    [DataContract(Name = "InvoiceDetailsv6_1Response_billToInfo")]
    public partial class InvoiceDetailsv61ResponseBillToInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsv61ResponseBillToInfo" /> class.
        /// </summary>
        /// <param name="contact">Bill to Name..</param>
        /// <param name="companyName">Bill to company..</param>
        /// <param name="addressLine1">Bill to Address Line1..</param>
        /// <param name="addressLine2">Bill to Address Line2..</param>
        /// <param name="addressLine3">Bill to Address Line3..</param>
        /// <param name="city">Bill to City..</param>
        /// <param name="state">Bill to State code.</param>
        /// <param name="postalCode">Bill to Postalcode code..</param>
        /// <param name="countryCode">Bill to Country code..</param>
        /// <param name="phoneNumber">Phone number of the bill to company..</param>
        /// <param name="email">Email address of the bill to company..</param>
        public InvoiceDetailsv61ResponseBillToInfo(string contact = default(string), string companyName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), string phoneNumber = default(string), string email = default(string))
        {
            this.Contact = contact;
            this.CompanyName = companyName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// Bill to Name.
        /// </summary>
        /// <value>Bill to Name.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// Bill to company.
        /// </summary>
        /// <value>Bill to company.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Bill to Address Line1.
        /// </summary>
        /// <value>Bill to Address Line1.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Bill to Address Line2.
        /// </summary>
        /// <value>Bill to Address Line2.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Bill to Address Line3.
        /// </summary>
        /// <value>Bill to Address Line3.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Bill to City.
        /// </summary>
        /// <value>Bill to City.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Bill to State code
        /// </summary>
        /// <value>Bill to State code</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Bill to Postalcode code.
        /// </summary>
        /// <value>Bill to Postalcode code.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Bill to Country code.
        /// </summary>
        /// <value>Bill to Country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Phone number of the bill to company.
        /// </summary>
        /// <value>Phone number of the bill to company.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email address of the bill to company.
        /// </summary>
        /// <value>Email address of the bill to company.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailsv61ResponseBillToInfo {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
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
