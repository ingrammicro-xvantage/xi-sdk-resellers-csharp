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
    /// PriceAndAvailabilityResponseInnerAvailability
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_availability")]
    public partial class PriceAndAvailabilityResponseInnerAvailability : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerAvailability" /> class.
        /// </summary>
        /// <param name="available">Boolean that indicates if the product ordered is available.</param>
        /// <param name="totalAvailability">The total amount of available products.</param>
        /// <param name="availabilityByWarehouse">availabilityByWarehouse.</param>
        public PriceAndAvailabilityResponseInnerAvailability(bool available = default(bool), int totalAvailability = default(int), List<PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner> availabilityByWarehouse = default(List<PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner>))
        {
            this.Available = available;
            this.TotalAvailability = totalAvailability;
            this.AvailabilityByWarehouse = availabilityByWarehouse;
        }

        /// <summary>
        /// Boolean that indicates if the product ordered is available
        /// </summary>
        /// <value>Boolean that indicates if the product ordered is available</value>
        [DataMember(Name = "available", EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// The total amount of available products
        /// </summary>
        /// <value>The total amount of available products</value>
        [DataMember(Name = "totalAvailability", EmitDefaultValue = false)]
        public int TotalAvailability { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityByWarehouse
        /// </summary>
        [DataMember(Name = "availabilityByWarehouse", EmitDefaultValue = false)]
        public List<PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner> AvailabilityByWarehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerAvailability {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  TotalAvailability: ").Append(TotalAvailability).Append("\n");
            sb.Append("  AvailabilityByWarehouse: ").Append(AvailabilityByWarehouse).Append("\n");
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
