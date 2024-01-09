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
    /// OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner
    /// </summary>
    [DataContract(Name = "orderCreateRequest_ordercreaterequest_ordercreatedetails_lines_inner")]
    public partial class OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner : IValidatableObject
    {
        /// <summary>
        /// Values are “P” for product or “C” for comments. This can be left blank when ordering product and a “P” will be assumed.  If you are adding a COMMENT, then this value must be “C”.  Extended spec for comments:   Attribute Name: “commenttext” Attribute Value: “thank you for the order”  To make the comment invisible to the packing slip place “///” in front of the comment in the Attribute Value field.  This will allow the Ingram sales rep to see the comment on the order but will not forward on to shipping documents.
        /// </summary>
        /// <value>Values are “P” for product or “C” for comments. This can be left blank when ordering product and a “P” will be assumed.  If you are adding a COMMENT, then this value must be “C”.  Extended spec for comments:   Attribute Name: “commenttext” Attribute Value: “thank you for the order”  To make the comment invisible to the packing slip place “///” in front of the comment in the Attribute Value field.  This will allow the Ingram sales rep to see the comment on the order but will not forward on to shipping documents.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinetypeEnum
        {
            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 1,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 2
        }


        /// <summary>
        /// Values are “P” for product or “C” for comments. This can be left blank when ordering product and a “P” will be assumed.  If you are adding a COMMENT, then this value must be “C”.  Extended spec for comments:   Attribute Name: “commenttext” Attribute Value: “thank you for the order”  To make the comment invisible to the packing slip place “///” in front of the comment in the Attribute Value field.  This will allow the Ingram sales rep to see the comment on the order but will not forward on to shipping documents.
        /// </summary>
        /// <value>Values are “P” for product or “C” for comments. This can be left blank when ordering product and a “P” will be assumed.  If you are adding a COMMENT, then this value must be “C”.  Extended spec for comments:   Attribute Name: “commenttext” Attribute Value: “thank you for the order”  To make the comment invisible to the packing slip place “///” in front of the comment in the Attribute Value field.  This will allow the Ingram sales rep to see the comment on the order but will not forward on to shipping documents.</value>
        [DataMember(Name = "linetype", EmitDefaultValue = false)]
        public LinetypeEnum? Linetype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner" /> class.
        /// </summary>
        /// <param name="linetype">Values are “P” for product or “C” for comments. This can be left blank when ordering product and a “P” will be assumed.  If you are adding a COMMENT, then this value must be “C”.  Extended spec for comments:   Attribute Name: “commenttext” Attribute Value: “thank you for the order”  To make the comment invisible to the packing slip place “///” in front of the comment in the Attribute Value field.  This will allow the Ingram sales rep to see the comment on the order but will not forward on to shipping documents..</param>
        /// <param name="linenumber">This is used when a partner wants to use their own line number. Can be left blank..</param>
        /// <param name="ingrampartnumber">This is the Ingram sku number to be used for placing an order..</param>
        /// <param name="quantity">The quantity that is to be ordered. (required).</param>
        /// <param name="vendorpartnumber">The Manufacturer part number. Can be used to place an order instead of the Ingram sku.  If there are multiple Ingram part numbers to one vendor part number.  The order will be rejected..</param>
        /// <param name="customerpartnumber">This is the Customers unique part numbers that must be crossed referenced to the Ingram Micro Sku before it can be used.  Please contact your sales rep for additional information on how to set this up..</param>
        /// <param name="uPCCode">uPCCode.</param>
        /// <param name="warehouseid">warehouseid.</param>
        /// <param name="unitprice">This is a requested price from the customer. Pre-approval is necessary before using this feature.  A methodology called price variance to manage requested pricing needs to be setup in advance by your sales rep.  If unit price is provided without this advanced setup the unit price will be ignored and standard Ingram Micro pricing will apply..</param>
        /// <param name="enduser">enduser.</param>
        /// <param name="productextendedspecs">productextendedspecs.</param>
        public OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner(LinetypeEnum? linetype = default(LinetypeEnum?), string linenumber = default(string), string ingrampartnumber = default(string), string quantity = default(string), string vendorpartnumber = default(string), string customerpartnumber = default(string), string uPCCode = default(string), string warehouseid = default(string), string unitprice = default(string), OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser enduser = default(OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser), List<OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerProductextendedspecsInner> productextendedspecs = default(List<OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerProductextendedspecsInner>))
        {
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new ArgumentNullException("quantity is a required property for OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner and cannot be null");
            }
            this.Quantity = quantity;
            this.Linetype = linetype;
            this.Linenumber = linenumber;
            this.Ingrampartnumber = ingrampartnumber;
            this.Vendorpartnumber = vendorpartnumber;
            this.Customerpartnumber = customerpartnumber;
            this.UPCCode = uPCCode;
            this.Warehouseid = warehouseid;
            this.Unitprice = unitprice;
            this.Enduser = enduser;
            this.Productextendedspecs = productextendedspecs;
        }

        /// <summary>
        /// This is used when a partner wants to use their own line number. Can be left blank.
        /// </summary>
        /// <value>This is used when a partner wants to use their own line number. Can be left blank.</value>
        [DataMember(Name = "linenumber", EmitDefaultValue = false)]
        public string Linenumber { get; set; }

        /// <summary>
        /// This is the Ingram sku number to be used for placing an order.
        /// </summary>
        /// <value>This is the Ingram sku number to be used for placing an order.</value>
        [DataMember(Name = "ingrampartnumber", EmitDefaultValue = false)]
        public string Ingrampartnumber { get; set; }

        /// <summary>
        /// The quantity that is to be ordered.
        /// </summary>
        /// <value>The quantity that is to be ordered.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public string Quantity { get; set; }

        /// <summary>
        /// The Manufacturer part number. Can be used to place an order instead of the Ingram sku.  If there are multiple Ingram part numbers to one vendor part number.  The order will be rejected.
        /// </summary>
        /// <value>The Manufacturer part number. Can be used to place an order instead of the Ingram sku.  If there are multiple Ingram part numbers to one vendor part number.  The order will be rejected.</value>
        [DataMember(Name = "vendorpartnumber", EmitDefaultValue = false)]
        public string Vendorpartnumber { get; set; }

        /// <summary>
        /// This is the Customers unique part numbers that must be crossed referenced to the Ingram Micro Sku before it can be used.  Please contact your sales rep for additional information on how to set this up.
        /// </summary>
        /// <value>This is the Customers unique part numbers that must be crossed referenced to the Ingram Micro Sku before it can be used.  Please contact your sales rep for additional information on how to set this up.</value>
        [DataMember(Name = "customerpartnumber", EmitDefaultValue = false)]
        public string Customerpartnumber { get; set; }

        /// <summary>
        /// Gets or Sets UPCCode
        /// </summary>
        [DataMember(Name = "UPCCode", EmitDefaultValue = false)]
        public string UPCCode { get; set; }

        /// <summary>
        /// Gets or Sets Warehouseid
        /// </summary>
        [DataMember(Name = "warehouseid", EmitDefaultValue = false)]
        public string Warehouseid { get; set; }

        /// <summary>
        /// This is a requested price from the customer. Pre-approval is necessary before using this feature.  A methodology called price variance to manage requested pricing needs to be setup in advance by your sales rep.  If unit price is provided without this advanced setup the unit price will be ignored and standard Ingram Micro pricing will apply.
        /// </summary>
        /// <value>This is a requested price from the customer. Pre-approval is necessary before using this feature.  A methodology called price variance to manage requested pricing needs to be setup in advance by your sales rep.  If unit price is provided without this advanced setup the unit price will be ignored and standard Ingram Micro pricing will apply.</value>
        [DataMember(Name = "unitprice", EmitDefaultValue = false)]
        public string Unitprice { get; set; }

        /// <summary>
        /// Gets or Sets Enduser
        /// </summary>
        [DataMember(Name = "enduser", EmitDefaultValue = false)]
        public OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser Enduser { get; set; }

        /// <summary>
        /// Gets or Sets Productextendedspecs
        /// </summary>
        [DataMember(Name = "productextendedspecs", EmitDefaultValue = false)]
        public List<OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerProductextendedspecsInner> Productextendedspecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner {\n");
            sb.Append("  Linetype: ").Append(Linetype).Append("\n");
            sb.Append("  Linenumber: ").Append(Linenumber).Append("\n");
            sb.Append("  Ingrampartnumber: ").Append(Ingrampartnumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Vendorpartnumber: ").Append(Vendorpartnumber).Append("\n");
            sb.Append("  Customerpartnumber: ").Append(Customerpartnumber).Append("\n");
            sb.Append("  UPCCode: ").Append(UPCCode).Append("\n");
            sb.Append("  Warehouseid: ").Append(Warehouseid).Append("\n");
            sb.Append("  Unitprice: ").Append(Unitprice).Append("\n");
            sb.Append("  Enduser: ").Append(Enduser).Append("\n");
            sb.Append("  Productextendedspecs: ").Append(Productextendedspecs).Append("\n");
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
