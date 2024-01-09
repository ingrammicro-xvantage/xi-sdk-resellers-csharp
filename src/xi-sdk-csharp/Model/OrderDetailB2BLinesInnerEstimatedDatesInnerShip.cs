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
    /// OrderDetailB2BLinesInnerEstimatedDatesInnerShip
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_estimatedDates_inner_ship")]
    public partial class OrderDetailB2BLinesInnerEstimatedDatesInnerShip : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerEstimatedDatesInnerShip" /> class.
        /// </summary>
        /// <param name="shipDateType">Date type. Example Single or multiple dates..</param>
        /// <param name="shipDateRange">shipDateRange.</param>
        /// <param name="shipSource">Source of the shipment..</param>
        /// <param name="shipDescription">Shipment description..</param>
        /// <param name="shipDate">Ship date..</param>
        public OrderDetailB2BLinesInnerEstimatedDatesInnerShip(string shipDateType = default(string), OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange shipDateRange = default(OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange), string shipSource = default(string), string shipDescription = default(string), string shipDate = default(string))
        {
            this.ShipDateType = shipDateType;
            this.ShipDateRange = shipDateRange;
            this.ShipSource = shipSource;
            this.ShipDescription = shipDescription;
            this.ShipDate = shipDate;
        }

        /// <summary>
        /// Date type. Example Single or multiple dates.
        /// </summary>
        /// <value>Date type. Example Single or multiple dates.</value>
        [DataMember(Name = "shipDateType", EmitDefaultValue = false)]
        public string ShipDateType { get; set; }

        /// <summary>
        /// Gets or Sets ShipDateRange
        /// </summary>
        [DataMember(Name = "shipDateRange", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange ShipDateRange { get; set; }

        /// <summary>
        /// Source of the shipment.
        /// </summary>
        /// <value>Source of the shipment.</value>
        [DataMember(Name = "shipSource", EmitDefaultValue = false)]
        public string ShipSource { get; set; }

        /// <summary>
        /// Shipment description.
        /// </summary>
        /// <value>Shipment description.</value>
        [DataMember(Name = "shipDescription", EmitDefaultValue = false)]
        public string ShipDescription { get; set; }

        /// <summary>
        /// Ship date.
        /// </summary>
        /// <value>Ship date.</value>
        [DataMember(Name = "shipDate", EmitDefaultValue = false)]
        public string ShipDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerEstimatedDatesInnerShip {\n");
            sb.Append("  ShipDateType: ").Append(ShipDateType).Append("\n");
            sb.Append("  ShipDateRange: ").Append(ShipDateRange).Append("\n");
            sb.Append("  ShipSource: ").Append(ShipSource).Append("\n");
            sb.Append("  ShipDescription: ").Append(ShipDescription).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
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
