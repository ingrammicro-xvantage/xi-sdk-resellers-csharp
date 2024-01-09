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
    /// PriceAndAvailabilityRequestAvailabilityByWarehouseInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityRequest_availabilityByWarehouse_inner")]
    public partial class PriceAndAvailabilityRequestAvailabilityByWarehouseInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityRequestAvailabilityByWarehouseInner" /> class.
        /// </summary>
        /// <param name="availabilityByWarehouseId">Plant/warehouse Id of a particular location in order to get just the inventory of that location..</param>
        /// <param name="availabilityForAllLocation">Pass boolean value as input, if true the response will contain warehouse location details, if false the response will not hold warehouse location details. By default value is true..</param>
        public PriceAndAvailabilityRequestAvailabilityByWarehouseInner(string availabilityByWarehouseId = default(string), bool availabilityForAllLocation = default(bool))
        {
            this.AvailabilityByWarehouseId = availabilityByWarehouseId;
            this.AvailabilityForAllLocation = availabilityForAllLocation;
        }

        /// <summary>
        /// Plant/warehouse Id of a particular location in order to get just the inventory of that location.
        /// </summary>
        /// <value>Plant/warehouse Id of a particular location in order to get just the inventory of that location.</value>
        [DataMember(Name = "availabilityByWarehouseId", EmitDefaultValue = false)]
        public string AvailabilityByWarehouseId { get; set; }

        /// <summary>
        /// Pass boolean value as input, if true the response will contain warehouse location details, if false the response will not hold warehouse location details. By default value is true.
        /// </summary>
        /// <value>Pass boolean value as input, if true the response will contain warehouse location details, if false the response will not hold warehouse location details. By default value is true.</value>
        [DataMember(Name = "availabilityForAllLocation", EmitDefaultValue = true)]
        public bool AvailabilityForAllLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityRequestAvailabilityByWarehouseInner {\n");
            sb.Append("  AvailabilityByWarehouseId: ").Append(AvailabilityByWarehouseId).Append("\n");
            sb.Append("  AvailabilityForAllLocation: ").Append(AvailabilityForAllLocation).Append("\n");
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
