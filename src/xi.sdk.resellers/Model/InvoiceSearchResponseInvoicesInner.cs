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
    /// InvoiceSearchResponseInvoicesInner
    /// </summary>
    [DataContract(Name = "InvoiceSearchResponse_invoices_inner")]
    public partial class InvoiceSearchResponseInvoicesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchResponseInvoicesInner" /> class.
        /// </summary>
        /// <param name="paymentTermsDueDate">Payment Terms Due date..</param>
        /// <param name="erpOrderNumber">Order number.</param>
        /// <param name="invoiceNumber">Invoice no..</param>
        /// <param name="invoiceStatus">Invoice Status..</param>
        /// <param name="invoiceDate">Invoice Date..</param>
        /// <param name="invoiceDueDate">Invoice Due Date..</param>
        /// <param name="invoicedAmountDue">Invoice Amount..</param>
        /// <param name="customerOrderNumber">Customer Order No..</param>
        /// <param name="orderCreateDate">Order Create Date..</param>
        /// <param name="endCustomerOrderNumber">End Customer Order number..</param>
        /// <param name="invoiceAmountInclTax">Invoice Amount Inclusive of Taxes.</param>
        public InvoiceSearchResponseInvoicesInner(string paymentTermsDueDate = default(string), string erpOrderNumber = default(string), string invoiceNumber = default(string), string invoiceStatus = default(string), string invoiceDate = default(string), string invoiceDueDate = default(string), decimal invoicedAmountDue = default(decimal), string customerOrderNumber = default(string), string orderCreateDate = default(string), string endCustomerOrderNumber = default(string), decimal invoiceAmountInclTax = default(decimal))
        {
            this.PaymentTermsDueDate = paymentTermsDueDate;
            this.ErpOrderNumber = erpOrderNumber;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceStatus = invoiceStatus;
            this.InvoiceDate = invoiceDate;
            this.InvoiceDueDate = invoiceDueDate;
            this.InvoicedAmountDue = invoicedAmountDue;
            this.CustomerOrderNumber = customerOrderNumber;
            this.OrderCreateDate = orderCreateDate;
            this.EndCustomerOrderNumber = endCustomerOrderNumber;
            this.InvoiceAmountInclTax = invoiceAmountInclTax;
        }

        /// <summary>
        /// Payment Terms Due date.
        /// </summary>
        /// <value>Payment Terms Due date.</value>
        [DataMember(Name = "paymentTermsDueDate", EmitDefaultValue = false)]
        public string PaymentTermsDueDate { get; set; }

        /// <summary>
        /// Order number
        /// </summary>
        /// <value>Order number</value>
        [DataMember(Name = "erpOrderNumber", EmitDefaultValue = false)]
        public string ErpOrderNumber { get; set; }

        /// <summary>
        /// Invoice no.
        /// </summary>
        /// <value>Invoice no.</value>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice Status.
        /// </summary>
        /// <value>Invoice Status.</value>
        [DataMember(Name = "invoiceStatus", EmitDefaultValue = false)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// Invoice Date.
        /// </summary>
        /// <value>Invoice Date.</value>
        [DataMember(Name = "invoiceDate", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Invoice Due Date.
        /// </summary>
        /// <value>Invoice Due Date.</value>
        [DataMember(Name = "invoiceDueDate", EmitDefaultValue = false)]
        public string InvoiceDueDate { get; set; }

        /// <summary>
        /// Invoice Amount.
        /// </summary>
        /// <value>Invoice Amount.</value>
        [DataMember(Name = "invoicedAmountDue", EmitDefaultValue = false)]
        public decimal InvoicedAmountDue { get; set; }

        /// <summary>
        /// Customer Order No.
        /// </summary>
        /// <value>Customer Order No.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// Order Create Date.
        /// </summary>
        /// <value>Order Create Date.</value>
        [DataMember(Name = "orderCreateDate", EmitDefaultValue = false)]
        public string OrderCreateDate { get; set; }

        /// <summary>
        /// End Customer Order number.
        /// </summary>
        /// <value>End Customer Order number.</value>
        [DataMember(Name = "endCustomerOrderNumber", EmitDefaultValue = false)]
        public string EndCustomerOrderNumber { get; set; }

        /// <summary>
        /// Invoice Amount Inclusive of Taxes
        /// </summary>
        /// <value>Invoice Amount Inclusive of Taxes</value>
        [DataMember(Name = "invoiceAmountInclTax", EmitDefaultValue = false)]
        public decimal InvoiceAmountInclTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceSearchResponseInvoicesInner {\n");
            sb.Append("  PaymentTermsDueDate: ").Append(PaymentTermsDueDate).Append("\n");
            sb.Append("  ErpOrderNumber: ").Append(ErpOrderNumber).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceDueDate: ").Append(InvoiceDueDate).Append("\n");
            sb.Append("  InvoicedAmountDue: ").Append(InvoicedAmountDue).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  OrderCreateDate: ").Append(OrderCreateDate).Append("\n");
            sb.Append("  EndCustomerOrderNumber: ").Append(EndCustomerOrderNumber).Append("\n");
            sb.Append("  InvoiceAmountInclTax: ").Append(InvoiceAmountInclTax).Append("\n");
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
