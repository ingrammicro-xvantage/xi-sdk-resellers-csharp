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
    /// OrderCreateResponseOrdersInnerMiscellaneousChargesInner
    /// </summary>
    [DataContract(Name = "OrderCreateResponse_orders_inner_miscellaneousCharges_inner")]
    public partial class OrderCreateResponseOrdersInnerMiscellaneousChargesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponseOrdersInnerMiscellaneousChargesInner" /> class.
        /// </summary>
        /// <param name="subOrderNumber">The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number..</param>
        /// <param name="chargeLineReference">Impulse line number for the miscellaneous charge..</param>
        /// <param name="chargeDescription">Description of the miscellaneous charges for the order..</param>
        /// <param name="chargeAmount">The total amount of miscellaneous charges for the order..</param>
        public OrderCreateResponseOrdersInnerMiscellaneousChargesInner(string subOrderNumber = default(string), string chargeLineReference = default(string), string chargeDescription = default(string), decimal chargeAmount = default(decimal))
        {
            this.SubOrderNumber = subOrderNumber;
            this.ChargeLineReference = chargeLineReference;
            this.ChargeDescription = chargeDescription;
            this.ChargeAmount = chargeAmount;
        }

        /// <summary>
        /// The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.
        /// </summary>
        /// <value>The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.</value>
        [DataMember(Name = "subOrderNumber", EmitDefaultValue = false)]
        public string SubOrderNumber { get; set; }

        /// <summary>
        /// Impulse line number for the miscellaneous charge.
        /// </summary>
        /// <value>Impulse line number for the miscellaneous charge.</value>
        [DataMember(Name = "chargeLineReference", EmitDefaultValue = false)]
        public string ChargeLineReference { get; set; }

        /// <summary>
        /// Description of the miscellaneous charges for the order.
        /// </summary>
        /// <value>Description of the miscellaneous charges for the order.</value>
        [DataMember(Name = "chargeDescription", EmitDefaultValue = false)]
        public string ChargeDescription { get; set; }

        /// <summary>
        /// The total amount of miscellaneous charges for the order.
        /// </summary>
        /// <value>The total amount of miscellaneous charges for the order.</value>
        [DataMember(Name = "chargeAmount", EmitDefaultValue = false)]
        public decimal ChargeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponseOrdersInnerMiscellaneousChargesInner {\n");
            sb.Append("  SubOrderNumber: ").Append(SubOrderNumber).Append("\n");
            sb.Append("  ChargeLineReference: ").Append(ChargeLineReference).Append("\n");
            sb.Append("  ChargeDescription: ").Append(ChargeDescription).Append("\n");
            sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
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
