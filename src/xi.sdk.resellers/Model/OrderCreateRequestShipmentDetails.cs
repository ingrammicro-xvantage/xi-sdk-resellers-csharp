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
    /// Shipping details for the order provided by the customer.
    /// </summary>
    [DataContract(Name = "OrderCreateRequest_shipmentDetails")]
    public partial class OrderCreateRequestShipmentDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestShipmentDetails" /> class.
        /// </summary>
        /// <param name="carrierCode">The code for the shipping carrier for the line item..</param>
        /// <param name="freightAccountNumber">The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier..</param>
        /// <param name="shipComplete">Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E.    With value as true or C, backorderflag will be set as C.    With value as P, or E, backorderflag will be set as P or E respectively.    C &#x3D; Ship complete at distribution level.    P &#x3D; ship complete at line level.    E &#x3D; ship complete across all distributions. .</param>
        /// <param name="requestedDeliveryDate">The reseller-requested delivery date in UTC format. Delivery date is not guaranteed..</param>
        /// <param name="signatureRequired">Specifies whether a signature is required for delivery. Default is False..</param>
        /// <param name="shippingInstructions">shippingInstructions.</param>
        public OrderCreateRequestShipmentDetails(string carrierCode = default(string), string freightAccountNumber = default(string), string shipComplete = default(string), DateOnly requestedDeliveryDate = default(DateOnly), bool signatureRequired = default(bool), string shippingInstructions = default(string))
        {
            this.CarrierCode = carrierCode;
            this.FreightAccountNumber = freightAccountNumber;
            this.ShipComplete = shipComplete;
            this.RequestedDeliveryDate = requestedDeliveryDate;
            this.SignatureRequired = signatureRequired;
            this.ShippingInstructions = shippingInstructions;
        }

        /// <summary>
        /// The code for the shipping carrier for the line item.
        /// </summary>
        /// <value>The code for the shipping carrier for the line item.</value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier.
        /// </summary>
        /// <value>The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier.</value>
        [DataMember(Name = "freightAccountNumber", EmitDefaultValue = false)]
        public string FreightAccountNumber { get; set; }

        /// <summary>
        /// Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E.    With value as true or C, backorderflag will be set as C.    With value as P, or E, backorderflag will be set as P or E respectively.    C &#x3D; Ship complete at distribution level.    P &#x3D; ship complete at line level.    E &#x3D; ship complete across all distributions. 
        /// </summary>
        /// <value>Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E.    With value as true or C, backorderflag will be set as C.    With value as P, or E, backorderflag will be set as P or E respectively.    C &#x3D; Ship complete at distribution level.    P &#x3D; ship complete at line level.    E &#x3D; ship complete across all distributions. </value>
        [DataMember(Name = "shipComplete", EmitDefaultValue = false)]
        public string ShipComplete { get; set; }

        /// <summary>
        /// The reseller-requested delivery date in UTC format. Delivery date is not guaranteed.
        /// </summary>
        /// <value>The reseller-requested delivery date in UTC format. Delivery date is not guaranteed.</value>
        [DataMember(Name = "requestedDeliveryDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly RequestedDeliveryDate { get; set; }

        /// <summary>
        /// Specifies whether a signature is required for delivery. Default is False.
        /// </summary>
        /// <value>Specifies whether a signature is required for delivery. Default is False.</value>
        [DataMember(Name = "signatureRequired", EmitDefaultValue = true)]
        public bool SignatureRequired { get; set; }

        /// <summary>
        /// Gets or Sets ShippingInstructions
        /// </summary>
        [DataMember(Name = "shippingInstructions", EmitDefaultValue = false)]
        public string ShippingInstructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestShipmentDetails {\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  FreightAccountNumber: ").Append(FreightAccountNumber).Append("\n");
            sb.Append("  ShipComplete: ").Append(ShipComplete).Append("\n");
            sb.Append("  RequestedDeliveryDate: ").Append(RequestedDeliveryDate).Append("\n");
            sb.Append("  SignatureRequired: ").Append(SignatureRequired).Append("\n");
            sb.Append("  ShippingInstructions: ").Append(ShippingInstructions).Append("\n");
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
            // CarrierCode (string) maxLength
            if (this.CarrierCode != null && this.CarrierCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierCode, length must be less than 10.", new [] { "CarrierCode" });
            }

            // ShipComplete (string) maxLength
            if (this.ShipComplete != null && this.ShipComplete.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShipComplete, length must be less than 1.", new [] { "ShipComplete" });
            }

            // ShippingInstructions (string) maxLength
            if (this.ShippingInstructions != null && this.ShippingInstructions.Length > 132)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingInstructions, length must be less than 132.", new [] { "ShippingInstructions" });
            }

            yield break;
        }
    }

}
