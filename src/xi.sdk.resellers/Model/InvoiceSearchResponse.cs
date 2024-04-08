/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    /// InvoiceSearchResponse
    /// </summary>
    [DataContract(Name = "InvoiceSearchResponse")]
    public partial class InvoiceSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchResponse" /> class.
        /// </summary>
        /// <param name="recordsFound">Total count of quotes retrieved in the request response..</param>
        /// <param name="pageSize">Number of records (quotes) displayed per page in the quote list..</param>
        /// <param name="pageNumber">Page index or page number for the list of quotes being returned..</param>
        /// <param name="invoices">The Invoices details for the requested criteria..</param>
        /// <param name="nextPage">Next page of the pagination..</param>
        public InvoiceSearchResponse(int recordsFound = default(int), int pageSize = default(int), int pageNumber = default(int), List<InvoiceSearchResponseInvoicesInner> invoices = default(List<InvoiceSearchResponseInvoicesInner>), string nextPage = default(string))
        {
            this.RecordsFound = recordsFound;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.Invoices = invoices;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Total count of quotes retrieved in the request response.
        /// </summary>
        /// <value>Total count of quotes retrieved in the request response.</value>
        [DataMember(Name = "recordsFound", EmitDefaultValue = false)]
        public int RecordsFound { get; set; }

        /// <summary>
        /// Number of records (quotes) displayed per page in the quote list.
        /// </summary>
        /// <value>Number of records (quotes) displayed per page in the quote list.</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Page index or page number for the list of quotes being returned.
        /// </summary>
        /// <value>Page index or page number for the list of quotes being returned.</value>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// The Invoices details for the requested criteria.
        /// </summary>
        /// <value>The Invoices details for the requested criteria.</value>
        [DataMember(Name = "invoices", EmitDefaultValue = false)]
        public List<InvoiceSearchResponseInvoicesInner> Invoices { get; set; }

        /// <summary>
        /// Next page of the pagination.
        /// </summary>
        /// <value>Next page of the pagination.</value>
        [DataMember(Name = "nextPage", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceSearchResponse {\n");
            sb.Append("  RecordsFound: ").Append(RecordsFound).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
