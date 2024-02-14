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
    /// OrderSearchRequestServicerequestOrderLookupRequest
    /// </summary>
    [DataContract(Name = "orderSearchRequest_servicerequest_orderLookupRequest")]
    public partial class OrderSearchRequestServicerequestOrderLookupRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchRequestServicerequestOrderLookupRequest" /> class.
        /// </summary>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="customerOrderNumber">customerOrderNumber.</param>
        public OrderSearchRequestServicerequestOrderLookupRequest(OrderSearchRequestServicerequestOrderLookupRequestOrderNumber orderNumber = default(OrderSearchRequestServicerequestOrderLookupRequestOrderNumber), OrderSearchRequestServicerequestOrderLookupRequestCustomerOrderNumber customerOrderNumber = default(OrderSearchRequestServicerequestOrderLookupRequestCustomerOrderNumber))
        {
            this.OrderNumber = orderNumber;
            this.CustomerOrderNumber = customerOrderNumber;
        }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public OrderSearchRequestServicerequestOrderLookupRequestOrderNumber OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerOrderNumber
        /// </summary>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public OrderSearchRequestServicerequestOrderLookupRequestCustomerOrderNumber CustomerOrderNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderSearchRequestServicerequestOrderLookupRequest {\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
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
