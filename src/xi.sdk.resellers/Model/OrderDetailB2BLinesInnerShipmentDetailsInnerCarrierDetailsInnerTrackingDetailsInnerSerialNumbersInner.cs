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
    /// OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_shipmentDetails_inner_carrierDetails_inner_trackingDetails_inner_serialNumbers_inner")]
    public partial class OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner" /> class.
        /// </summary>
        /// <param name="serialNumber">The serial number for the line item..</param>
        public OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner(string serialNumber = default(string))
        {
            this.SerialNumber = serialNumber;
        }

        /// <summary>
        /// The serial number for the line item.
        /// </summary>
        /// <value>The serial number for the line item.</value>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner {\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
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
