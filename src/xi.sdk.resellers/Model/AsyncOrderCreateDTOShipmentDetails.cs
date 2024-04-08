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
    /// Shipping details for the order provided by the customer.
    /// </summary>
    [DataContract(Name = "AsyncOrderCreateDTO_shipmentDetails")]
    public partial class AsyncOrderCreateDTOShipmentDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateDTOShipmentDetails" /> class.
        /// </summary>
        /// <param name="carrierCode">The code for the shipping carrier for the line item..</param>
        /// <param name="requestedDeliveryDate">The reseller-requested delivery date in UTC format. Delivery date is not guaranteed..</param>
        /// <param name="shipComplete">Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E..</param>
        /// <param name="shippingInstructions">Any special shipping instructions for the order..</param>
        /// <param name="freightAccountNumber">The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier..</param>
        /// <param name="signatureRequired">Specifies whether a signature is required for delivery. Default is False..</param>
        public AsyncOrderCreateDTOShipmentDetails(string carrierCode = default(string), string requestedDeliveryDate = default(string), string shipComplete = default(string), string shippingInstructions = default(string), string freightAccountNumber = default(string), bool signatureRequired = default(bool))
        {
            this.CarrierCode = carrierCode;
            this.RequestedDeliveryDate = requestedDeliveryDate;
            this.ShipComplete = shipComplete;
            this.ShippingInstructions = shippingInstructions;
            this.FreightAccountNumber = freightAccountNumber;
            this.SignatureRequired = signatureRequired;
        }

        /// <summary>
        /// The code for the shipping carrier for the line item.
        /// </summary>
        /// <value>The code for the shipping carrier for the line item.</value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The reseller-requested delivery date in UTC format. Delivery date is not guaranteed.
        /// </summary>
        /// <value>The reseller-requested delivery date in UTC format. Delivery date is not guaranteed.</value>
        [DataMember(Name = "requestedDeliveryDate", EmitDefaultValue = false)]
        public string RequestedDeliveryDate { get; set; }

        /// <summary>
        /// Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E.
        /// </summary>
        /// <value>Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E.</value>
        [DataMember(Name = "shipComplete", EmitDefaultValue = false)]
        public string ShipComplete { get; set; }

        /// <summary>
        /// Any special shipping instructions for the order.
        /// </summary>
        /// <value>Any special shipping instructions for the order.</value>
        [DataMember(Name = "shippingInstructions", EmitDefaultValue = false)]
        public string ShippingInstructions { get; set; }

        /// <summary>
        /// The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier.
        /// </summary>
        /// <value>The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier.</value>
        [DataMember(Name = "freightAccountNumber", EmitDefaultValue = false)]
        public string FreightAccountNumber { get; set; }

        /// <summary>
        /// Specifies whether a signature is required for delivery. Default is False.
        /// </summary>
        /// <value>Specifies whether a signature is required for delivery. Default is False.</value>
        [DataMember(Name = "signatureRequired", EmitDefaultValue = true)]
        public bool SignatureRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsyncOrderCreateDTOShipmentDetails {\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  RequestedDeliveryDate: ").Append(RequestedDeliveryDate).Append("\n");
            sb.Append("  ShipComplete: ").Append(ShipComplete).Append("\n");
            sb.Append("  ShippingInstructions: ").Append(ShippingInstructions).Append("\n");
            sb.Append("  FreightAccountNumber: ").Append(FreightAccountNumber).Append("\n");
            sb.Append("  SignatureRequired: ").Append(SignatureRequired).Append("\n");
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
