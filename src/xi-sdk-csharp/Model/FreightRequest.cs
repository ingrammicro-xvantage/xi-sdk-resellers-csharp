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
    /// FreightRequest
    /// </summary>
    [DataContract(Name = "freightRequest")]
    public partial class FreightRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreightRequest" /> class.
        /// </summary>
        /// <param name="billToAddressId">Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit..</param>
        /// <param name="shipToAddressId">The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process..</param>
        /// <param name="shipToAddress">The shipping information..</param>
        /// <param name="lines">lines.</param>
        public FreightRequest(string billToAddressId = default(string), string shipToAddressId = default(string), List<FreightRequestShipToAddressInner> shipToAddress = default(List<FreightRequestShipToAddressInner>), List<FreightRequestLinesInner> lines = default(List<FreightRequestLinesInner>))
        {
            this.BillToAddressId = billToAddressId;
            this.ShipToAddressId = shipToAddressId;
            this.ShipToAddress = shipToAddress;
            this.Lines = lines;
        }

        /// <summary>
        /// Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit.
        /// </summary>
        /// <value>Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit.</value>
        [DataMember(Name = "billToAddressId", EmitDefaultValue = false)]
        public string BillToAddressId { get; set; }

        /// <summary>
        /// The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.
        /// </summary>
        /// <value>The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.</value>
        [DataMember(Name = "shipToAddressId", EmitDefaultValue = false)]
        public string ShipToAddressId { get; set; }

        /// <summary>
        /// The shipping information.
        /// </summary>
        /// <value>The shipping information.</value>
        [DataMember(Name = "shipToAddress", EmitDefaultValue = false)]
        public List<FreightRequestShipToAddressInner> ShipToAddress { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        public List<FreightRequestLinesInner> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FreightRequest {\n");
            sb.Append("  BillToAddressId: ").Append(BillToAddressId).Append("\n");
            sb.Append("  ShipToAddressId: ").Append(ShipToAddressId).Append("\n");
            sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
