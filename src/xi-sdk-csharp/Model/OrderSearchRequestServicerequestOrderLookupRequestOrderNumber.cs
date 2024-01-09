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
    /// OrderSearchRequestServicerequestOrderLookupRequestOrderNumber
    /// </summary>
    [DataContract(Name = "orderSearchRequest_servicerequest_orderLookupRequest_orderNumber")]
    public partial class OrderSearchRequestServicerequestOrderLookupRequestOrderNumber : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchRequestServicerequestOrderLookupRequestOrderNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderSearchRequestServicerequestOrderLookupRequestOrderNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchRequestServicerequestOrderLookupRequestOrderNumber" /> class.
        /// </summary>
        /// <param name="entryDate">entryDate (required).</param>
        /// <param name="orderBranch">orderBranch (required).</param>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="distributionNumber">distributionNumber.</param>
        /// <param name="shipmentNumber">shipmentNumber.</param>
        public OrderSearchRequestServicerequestOrderLookupRequestOrderNumber(string entryDate = default(string), string orderBranch = default(string), string orderNumber = default(string), string distributionNumber = default(string), string shipmentNumber = default(string))
        {
            // to ensure "entryDate" is required (not null)
            if (entryDate == null)
            {
                throw new ArgumentNullException("entryDate is a required property for OrderSearchRequestServicerequestOrderLookupRequestOrderNumber and cannot be null");
            }
            this.EntryDate = entryDate;
            // to ensure "orderBranch" is required (not null)
            if (orderBranch == null)
            {
                throw new ArgumentNullException("orderBranch is a required property for OrderSearchRequestServicerequestOrderLookupRequestOrderNumber and cannot be null");
            }
            this.OrderBranch = orderBranch;
            this.OrderNumber = orderNumber;
            this.DistributionNumber = distributionNumber;
            this.ShipmentNumber = shipmentNumber;
        }

        /// <summary>
        /// Gets or Sets EntryDate
        /// </summary>
        [DataMember(Name = "entryDate", IsRequired = true, EmitDefaultValue = true)]
        public string EntryDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderBranch
        /// </summary>
        [DataMember(Name = "orderBranch", IsRequired = true, EmitDefaultValue = true)]
        public string OrderBranch { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets DistributionNumber
        /// </summary>
        [DataMember(Name = "distributionNumber", EmitDefaultValue = false)]
        public string DistributionNumber { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentNumber
        /// </summary>
        [DataMember(Name = "shipmentNumber", EmitDefaultValue = false)]
        public string ShipmentNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderSearchRequestServicerequestOrderLookupRequestOrderNumber {\n");
            sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
            sb.Append("  OrderBranch: ").Append(OrderBranch).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  DistributionNumber: ").Append(DistributionNumber).Append("\n");
            sb.Append("  ShipmentNumber: ").Append(ShipmentNumber).Append("\n");
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
