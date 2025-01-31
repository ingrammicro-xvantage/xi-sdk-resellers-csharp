/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// InvoiceDetailsv61ResponseLinesInner
    /// </summary>
    [DataContract(Name = "InvoiceDetailsv6_1Response_lines_inner")]
    public partial class InvoiceDetailsv61ResponseLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsv61ResponseLinesInner" /> class.
        /// </summary>
        /// <param name="ingramLineNumber">Unique line number from Ingram..</param>
        /// <param name="customerLineNumber">Line number passes by customer while creating an order. (default to &quot;0&quot;).</param>
        /// <param name="ingramPartNumber">Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes..</param>
        /// <param name="upc">upc.</param>
        /// <param name="vendorPartNumber">Vendor Part Number..</param>
        /// <param name="customerPartNumber">Part number from customer&#39;s system..</param>
        /// <param name="vendorName">Name of the vendor..</param>
        /// <param name="productDescription">Description of the product..</param>
        /// <param name="unitWeight">Weight of the product..</param>
        /// <param name="quantity">Quantity of the product..</param>
        /// <param name="unitPrice">Unit price of the product..</param>
        /// <param name="unitOfMeasure">Unit of measure of the product..</param>
        /// <param name="currencyCode">Currency code..</param>
        /// <param name="extendedPrice">Extended price of the product..</param>
        /// <param name="taxPercentage">Tax percentage.</param>
        /// <param name="taxRate">Tax rate.</param>
        /// <param name="taxAmount">Line level tax amount..</param>
        /// <param name="serialNumbers">serialNumbers.</param>
        /// <param name="quantityOrdered">Quantity ordered by the customer..</param>
        /// <param name="quantityShipped">Quantity shipped to the customer..</param>
        public InvoiceDetailsv61ResponseLinesInner(string ingramLineNumber = default(string), string customerLineNumber = @"0", string ingramPartNumber = default(string), string upc = default(string), string vendorPartNumber = default(string), string customerPartNumber = default(string), string vendorName = default(string), string productDescription = default(string), decimal unitWeight = default(decimal), int quantity = default(int), double unitPrice = default(double), string unitOfMeasure = default(string), string currencyCode = default(string), double extendedPrice = default(double), double taxPercentage = default(double), double taxRate = default(double), double taxAmount = default(double), List<InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner> serialNumbers = default(List<InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner>), int quantityOrdered = default(int), int quantityShipped = default(int))
        {
            this.IngramLineNumber = ingramLineNumber;
            // use default value if no "customerLineNumber" provided
            this.CustomerLineNumber = customerLineNumber ?? @"0";
            this.IngramPartNumber = ingramPartNumber;
            this.Upc = upc;
            this.VendorPartNumber = vendorPartNumber;
            this.CustomerPartNumber = customerPartNumber;
            this.VendorName = vendorName;
            this.ProductDescription = productDescription;
            this.UnitWeight = unitWeight;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.UnitOfMeasure = unitOfMeasure;
            this.CurrencyCode = currencyCode;
            this.ExtendedPrice = extendedPrice;
            this.TaxPercentage = taxPercentage;
            this.TaxRate = taxRate;
            this.TaxAmount = taxAmount;
            this.SerialNumbers = serialNumbers;
            this.QuantityOrdered = quantityOrdered;
            this.QuantityShipped = quantityShipped;
        }

        /// <summary>
        /// Unique line number from Ingram.
        /// </summary>
        /// <value>Unique line number from Ingram.</value>
        [DataMember(Name = "ingramLineNumber", EmitDefaultValue = false)]
        public string IngramLineNumber { get; set; }

        /// <summary>
        /// Line number passes by customer while creating an order.
        /// </summary>
        /// <value>Line number passes by customer while creating an order.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes.
        /// </summary>
        /// <value>Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets Upc
        /// </summary>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        public string Upc { get; set; }

        /// <summary>
        /// Vendor Part Number.
        /// </summary>
        /// <value>Vendor Part Number.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Part number from customer&#39;s system.
        /// </summary>
        /// <value>Part number from customer&#39;s system.</value>
        [DataMember(Name = "customerPartNumber", EmitDefaultValue = false)]
        public string CustomerPartNumber { get; set; }

        /// <summary>
        /// Name of the vendor.
        /// </summary>
        /// <value>Name of the vendor.</value>
        [DataMember(Name = "vendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        /// <value>Description of the product.</value>
        [DataMember(Name = "productDescription", EmitDefaultValue = false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Weight of the product.
        /// </summary>
        /// <value>Weight of the product.</value>
        [DataMember(Name = "unitWeight", EmitDefaultValue = false)]
        public decimal UnitWeight { get; set; }

        /// <summary>
        /// Quantity of the product.
        /// </summary>
        /// <value>Quantity of the product.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Unit price of the product.
        /// </summary>
        /// <value>Unit price of the product.</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public double UnitPrice { get; set; }

        /// <summary>
        /// Unit of measure of the product.
        /// </summary>
        /// <value>Unit of measure of the product.</value>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Currency code.
        /// </summary>
        /// <value>Currency code.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Extended price of the product.
        /// </summary>
        /// <value>Extended price of the product.</value>
        [DataMember(Name = "extendedPrice", EmitDefaultValue = false)]
        public double ExtendedPrice { get; set; }

        /// <summary>
        /// Tax percentage
        /// </summary>
        /// <value>Tax percentage</value>
        [DataMember(Name = "taxPercentage", EmitDefaultValue = false)]
        public double TaxPercentage { get; set; }

        /// <summary>
        /// Tax rate
        /// </summary>
        /// <value>Tax rate</value>
        [DataMember(Name = "taxRate", EmitDefaultValue = false)]
        public double TaxRate { get; set; }

        /// <summary>
        /// Line level tax amount.
        /// </summary>
        /// <value>Line level tax amount.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public double TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumbers
        /// </summary>
        [DataMember(Name = "serialNumbers", EmitDefaultValue = true)]
        public List<InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner> SerialNumbers { get; set; }

        /// <summary>
        /// Quantity ordered by the customer.
        /// </summary>
        /// <value>Quantity ordered by the customer.</value>
        [DataMember(Name = "quantityOrdered", EmitDefaultValue = false)]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// Quantity shipped to the customer.
        /// </summary>
        /// <value>Quantity shipped to the customer.</value>
        [DataMember(Name = "quantityShipped", EmitDefaultValue = false)]
        public int QuantityShipped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailsv61ResponseLinesInner {\n");
            sb.Append("  IngramLineNumber: ").Append(IngramLineNumber).Append("\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  CustomerPartNumber: ").Append(CustomerPartNumber).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  UnitWeight: ").Append(UnitWeight).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ExtendedPrice: ").Append(ExtendedPrice).Append("\n");
            sb.Append("  TaxPercentage: ").Append(TaxPercentage).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  SerialNumbers: ").Append(SerialNumbers).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  QuantityShipped: ").Append(QuantityShipped).Append("\n");
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
