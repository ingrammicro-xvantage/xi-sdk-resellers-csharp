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
    /// OrderCreateRequest
    /// </summary>
    [DataContract(Name = "OrderCreateRequest")]
    public partial class OrderCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequest" /> class.
        /// </summary>
        /// <param name="customerOrderNumber">The reseller&#39;s unique PO/Order number. (required).</param>
        /// <param name="endCustomerOrderNumber">The end user/customer&#39;s Purchase Order number..</param>
        /// <param name="billToAddressId">Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit..</param>
        /// <param name="specialBidNumber">The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers..</param>
        /// <param name="notes">Order level notes..</param>
        /// <param name="acceptBackOrder">ENUM [\&quot;true\&quot;,\&quot;false\&quot;] - accept order if this item is backordered. This field along with shipComplete field decides the value of backorderflag. The value of this field is ignored when shipComplete field is present..</param>
        /// <param name="resellerInfo">resellerInfo.</param>
        /// <param name="vmf">vmf.</param>
        /// <param name="shipToInfo">shipToInfo.</param>
        /// <param name="endUserInfo">endUserInfo.</param>
        /// <param name="lines">The line-level details of the order..</param>
        /// <param name="shipmentDetails">shipmentDetails.</param>
        /// <param name="additionalAttributes">Shipment-level additional attributes..</param>
        public OrderCreateRequest(string customerOrderNumber = default(string), string endCustomerOrderNumber = default(string), string billToAddressId = default(string), string specialBidNumber = default(string), string notes = default(string), bool acceptBackOrder = default(bool), OrderCreateRequestResellerInfo resellerInfo = default(OrderCreateRequestResellerInfo), OrderCreateRequestVmf vmf = default(OrderCreateRequestVmf), OrderCreateRequestShipToInfo shipToInfo = default(OrderCreateRequestShipToInfo), OrderCreateRequestEndUserInfo endUserInfo = default(OrderCreateRequestEndUserInfo), List<OrderCreateRequestLinesInner> lines = default(List<OrderCreateRequestLinesInner>), OrderCreateRequestShipmentDetails shipmentDetails = default(OrderCreateRequestShipmentDetails), List<OrderCreateRequestAdditionalAttributesInner> additionalAttributes = default(List<OrderCreateRequestAdditionalAttributesInner>))
        {
            // to ensure "customerOrderNumber" is required (not null)
            if (customerOrderNumber == null)
            {
                throw new ArgumentNullException("customerOrderNumber is a required property for OrderCreateRequest and cannot be null");
            }
            this.CustomerOrderNumber = customerOrderNumber;
            this.EndCustomerOrderNumber = endCustomerOrderNumber;
            this.BillToAddressId = billToAddressId;
            this.SpecialBidNumber = specialBidNumber;
            this.Notes = notes;
            this.AcceptBackOrder = acceptBackOrder;
            this.ResellerInfo = resellerInfo;
            this.Vmf = vmf;
            this.ShipToInfo = shipToInfo;
            this.EndUserInfo = endUserInfo;
            this.Lines = lines;
            this.ShipmentDetails = shipmentDetails;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// The reseller&#39;s unique PO/Order number.
        /// </summary>
        /// <value>The reseller&#39;s unique PO/Order number.</value>
        [DataMember(Name = "customerOrderNumber", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// The end user/customer&#39;s Purchase Order number.
        /// </summary>
        /// <value>The end user/customer&#39;s Purchase Order number.</value>
        [DataMember(Name = "endCustomerOrderNumber", EmitDefaultValue = false)]
        public string EndCustomerOrderNumber { get; set; }

        /// <summary>
        /// Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit.
        /// </summary>
        /// <value>Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit.</value>
        [DataMember(Name = "billToAddressId", EmitDefaultValue = false)]
        public string BillToAddressId { get; set; }

        /// <summary>
        /// The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.
        /// </summary>
        /// <value>The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Order level notes.
        /// </summary>
        /// <value>Order level notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// ENUM [\&quot;true\&quot;,\&quot;false\&quot;] - accept order if this item is backordered. This field along with shipComplete field decides the value of backorderflag. The value of this field is ignored when shipComplete field is present.
        /// </summary>
        /// <value>ENUM [\&quot;true\&quot;,\&quot;false\&quot;] - accept order if this item is backordered. This field along with shipComplete field decides the value of backorderflag. The value of this field is ignored when shipComplete field is present.</value>
        [DataMember(Name = "acceptBackOrder", EmitDefaultValue = true)]
        public bool AcceptBackOrder { get; set; }

        /// <summary>
        /// Gets or Sets ResellerInfo
        /// </summary>
        [DataMember(Name = "resellerInfo", EmitDefaultValue = false)]
        public OrderCreateRequestResellerInfo ResellerInfo { get; set; }

        /// <summary>
        /// Gets or Sets Vmf
        /// </summary>
        [DataMember(Name = "vmf", EmitDefaultValue = false)]
        public OrderCreateRequestVmf Vmf { get; set; }

        /// <summary>
        /// Gets or Sets ShipToInfo
        /// </summary>
        [DataMember(Name = "shipToInfo", EmitDefaultValue = false)]
        public OrderCreateRequestShipToInfo ShipToInfo { get; set; }

        /// <summary>
        /// Gets or Sets EndUserInfo
        /// </summary>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public OrderCreateRequestEndUserInfo EndUserInfo { get; set; }

        /// <summary>
        /// The line-level details of the order.
        /// </summary>
        /// <value>The line-level details of the order.</value>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        public List<OrderCreateRequestLinesInner> Lines { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentDetails
        /// </summary>
        [DataMember(Name = "shipmentDetails", EmitDefaultValue = false)]
        public OrderCreateRequestShipmentDetails ShipmentDetails { get; set; }

        /// <summary>
        /// Shipment-level additional attributes.
        /// </summary>
        /// <value>Shipment-level additional attributes.</value>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<OrderCreateRequestAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequest {\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  EndCustomerOrderNumber: ").Append(EndCustomerOrderNumber).Append("\n");
            sb.Append("  BillToAddressId: ").Append(BillToAddressId).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  AcceptBackOrder: ").Append(AcceptBackOrder).Append("\n");
            sb.Append("  ResellerInfo: ").Append(ResellerInfo).Append("\n");
            sb.Append("  Vmf: ").Append(Vmf).Append("\n");
            sb.Append("  ShipToInfo: ").Append(ShipToInfo).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  ShipmentDetails: ").Append(ShipmentDetails).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
            // CustomerOrderNumber (string) maxLength
            if (this.CustomerOrderNumber != null && this.CustomerOrderNumber.Length > 35)
            {
                yield return new ValidationResult("Invalid value for CustomerOrderNumber, length must be less than 35.", new [] { "CustomerOrderNumber" });
            }

            // BillToAddressId (string) maxLength
            if (this.BillToAddressId != null && this.BillToAddressId.Length > 10)
            {
                yield return new ValidationResult("Invalid value for BillToAddressId, length must be less than 10.", new [] { "BillToAddressId" });
            }

            yield break;
        }
    }

}
