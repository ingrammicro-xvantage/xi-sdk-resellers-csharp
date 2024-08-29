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
    /// OrderDetailB2BLinesInnerEstimatedDatesInner
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_estimatedDates_inner")]
    public partial class OrderDetailB2BLinesInnerEstimatedDatesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerEstimatedDatesInner" /> class.
        /// </summary>
        /// <param name="ship">ship.</param>
        /// <param name="delivery">delivery.</param>
        public OrderDetailB2BLinesInnerEstimatedDatesInner(OrderDetailB2BLinesInnerEstimatedDatesInnerShip ship = default(OrderDetailB2BLinesInnerEstimatedDatesInnerShip), OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery delivery = default(OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery))
        {
            this.Ship = ship;
            this.Delivery = delivery;
        }

        /// <summary>
        /// Gets or Sets Ship
        /// </summary>
        [DataMember(Name = "ship", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerEstimatedDatesInnerShip Ship { get; set; }

        /// <summary>
        /// Gets or Sets Delivery
        /// </summary>
        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery Delivery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerEstimatedDatesInner {\n");
            sb.Append("  Ship: ").Append(Ship).Append("\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
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
