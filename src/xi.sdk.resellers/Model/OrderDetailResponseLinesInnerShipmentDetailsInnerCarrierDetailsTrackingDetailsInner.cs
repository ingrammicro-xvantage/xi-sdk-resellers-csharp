/*
 * XI Sdk Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
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
    /// The tracking details for the shipment containing the line item.
    /// </summary>
    [DataContract(Name = "OrderDetailResponse_lines_inner_shipmentDetails_inner_carrierDetails_trackingDetails_inner")]
    public partial class OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInner" /> class.
        /// </summary>
        /// <param name="trackingNumber">The tracking number for the shipment containing the line item..</param>
        /// <param name="trackingUrl">The tracking URL for the shipment containing the line item..</param>
        /// <param name="packageWeight">The weight of the package for the line item..</param>
        /// <param name="cartonNumber">The shipment carton number that contains the line item..</param>
        /// <param name="quantityInBox">The quantity of line items in the box..</param>
        /// <param name="serialNumbers">serialNumbers.</param>
        public OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInner(string trackingNumber = default(string), string trackingUrl = default(string), string packageWeight = default(string), string cartonNumber = default(string), string quantityInBox = default(string), List<OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInnerSerialNumbersInner> serialNumbers = default(List<OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInnerSerialNumbersInner>))
        {
            this.TrackingNumber = trackingNumber;
            this.TrackingUrl = trackingUrl;
            this.PackageWeight = packageWeight;
            this.CartonNumber = cartonNumber;
            this.QuantityInBox = quantityInBox;
            this.SerialNumbers = serialNumbers;
        }

        /// <summary>
        /// The tracking number for the shipment containing the line item.
        /// </summary>
        /// <value>The tracking number for the shipment containing the line item.</value>
        [DataMember(Name = "trackingNumber", EmitDefaultValue = false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The tracking URL for the shipment containing the line item.
        /// </summary>
        /// <value>The tracking URL for the shipment containing the line item.</value>
        [DataMember(Name = "trackingUrl", EmitDefaultValue = false)]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// The weight of the package for the line item.
        /// </summary>
        /// <value>The weight of the package for the line item.</value>
        [DataMember(Name = "packageWeight", EmitDefaultValue = false)]
        public string PackageWeight { get; set; }

        /// <summary>
        /// The shipment carton number that contains the line item.
        /// </summary>
        /// <value>The shipment carton number that contains the line item.</value>
        [DataMember(Name = "cartonNumber", EmitDefaultValue = false)]
        public string CartonNumber { get; set; }

        /// <summary>
        /// The quantity of line items in the box.
        /// </summary>
        /// <value>The quantity of line items in the box.</value>
        [DataMember(Name = "quantityInBox", EmitDefaultValue = false)]
        public string QuantityInBox { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumbers
        /// </summary>
        [DataMember(Name = "SerialNumbers", EmitDefaultValue = false)]
        public List<OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInnerSerialNumbersInner> SerialNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetailsTrackingDetailsInner {\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  PackageWeight: ").Append(PackageWeight).Append("\n");
            sb.Append("  CartonNumber: ").Append(CartonNumber).Append("\n");
            sb.Append("  QuantityInBox: ").Append(QuantityInBox).Append("\n");
            sb.Append("  SerialNumbers: ").Append(SerialNumbers).Append("\n");
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
