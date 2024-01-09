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
    /// QuoteSearchResponseQuotesInner
    /// </summary>
    [DataContract(Name = "QuoteSearchResponse_quotes_inner")]
    public partial class QuoteSearchResponseQuotesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSearchResponseQuotesInner" /> class.
        /// </summary>
        /// <param name="quoteName">Quote Name given to quote by sales team or system generated.  Generally used as a reference to identify the quote..</param>
        /// <param name="quoteNumber">Unique identifier generated by Ingram Micros CRM specific to each quote.  When applying a filter to the quoteNumber and including a partial quote number in the filter, all quotes containing any information included in the filter can be retrieved as a subset of all available customer quotes..</param>
        /// <param name="revision">When a quote has been revised and updated, the quote number remains the same throughout the lifecycle of the quote, however, a Revision number is updated for each revision of the quote.  The revision numbers is associated with the Unique Quote Number..</param>
        /// <param name="endUserContact">End User Name is the end customer name that is associated with a quote in Ingram Micros CRM..</param>
        /// <param name="specialBidNumber">Special Pricing Bid Number, also refers to as Dart Number relates to a unique pricing deal associated with a vendor for the quote..</param>
        /// <param name="quoteTotal">Total amount of quoted price for all products in the quote..</param>
        /// <param name="quoteStatus">This refers to the primary status of the quote..</param>
        /// <param name="ingramQuoteDate">Date the Quote was initially Created..</param>
        /// <param name="lastModifiedDate">Date the Quote was last updated or modified..</param>
        /// <param name="ingramQuoteExpiryDate">Date when the Quote Expires..</param>
        /// <param name="vendor">Name of the vendor..</param>
        /// <param name="createdBy">Name of the end user/customer who created a quote..</param>
        public QuoteSearchResponseQuotesInner(string quoteName = default(string), string quoteNumber = default(string), string revision = default(string), string endUserContact = default(string), string specialBidNumber = default(string), decimal quoteTotal = default(decimal), string quoteStatus = default(string), string ingramQuoteDate = default(string), string lastModifiedDate = default(string), string ingramQuoteExpiryDate = default(string), string vendor = default(string), string createdBy = default(string))
        {
            this.QuoteName = quoteName;
            this.QuoteNumber = quoteNumber;
            this.Revision = revision;
            this.EndUserContact = endUserContact;
            this.SpecialBidNumber = specialBidNumber;
            this.QuoteTotal = quoteTotal;
            this.QuoteStatus = quoteStatus;
            this.IngramQuoteDate = ingramQuoteDate;
            this.LastModifiedDate = lastModifiedDate;
            this.IngramQuoteExpiryDate = ingramQuoteExpiryDate;
            this.Vendor = vendor;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Quote Name given to quote by sales team or system generated.  Generally used as a reference to identify the quote.
        /// </summary>
        /// <value>Quote Name given to quote by sales team or system generated.  Generally used as a reference to identify the quote.</value>
        [DataMember(Name = "quoteName", EmitDefaultValue = false)]
        public string QuoteName { get; set; }

        /// <summary>
        /// Unique identifier generated by Ingram Micros CRM specific to each quote.  When applying a filter to the quoteNumber and including a partial quote number in the filter, all quotes containing any information included in the filter can be retrieved as a subset of all available customer quotes.
        /// </summary>
        /// <value>Unique identifier generated by Ingram Micros CRM specific to each quote.  When applying a filter to the quoteNumber and including a partial quote number in the filter, all quotes containing any information included in the filter can be retrieved as a subset of all available customer quotes.</value>
        [DataMember(Name = "quoteNumber", EmitDefaultValue = false)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// When a quote has been revised and updated, the quote number remains the same throughout the lifecycle of the quote, however, a Revision number is updated for each revision of the quote.  The revision numbers is associated with the Unique Quote Number.
        /// </summary>
        /// <value>When a quote has been revised and updated, the quote number remains the same throughout the lifecycle of the quote, however, a Revision number is updated for each revision of the quote.  The revision numbers is associated with the Unique Quote Number.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public string Revision { get; set; }

        /// <summary>
        /// End User Name is the end customer name that is associated with a quote in Ingram Micros CRM.
        /// </summary>
        /// <value>End User Name is the end customer name that is associated with a quote in Ingram Micros CRM.</value>
        [DataMember(Name = "endUserContact", EmitDefaultValue = false)]
        public string EndUserContact { get; set; }

        /// <summary>
        /// Special Pricing Bid Number, also refers to as Dart Number relates to a unique pricing deal associated with a vendor for the quote.
        /// </summary>
        /// <value>Special Pricing Bid Number, also refers to as Dart Number relates to a unique pricing deal associated with a vendor for the quote.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Total amount of quoted price for all products in the quote.
        /// </summary>
        /// <value>Total amount of quoted price for all products in the quote.</value>
        [DataMember(Name = "quoteTotal", EmitDefaultValue = false)]
        public decimal QuoteTotal { get; set; }

        /// <summary>
        /// This refers to the primary status of the quote.
        /// </summary>
        /// <value>This refers to the primary status of the quote.</value>
        [DataMember(Name = "quoteStatus", EmitDefaultValue = false)]
        public string QuoteStatus { get; set; }

        /// <summary>
        /// Date the Quote was initially Created.
        /// </summary>
        /// <value>Date the Quote was initially Created.</value>
        [DataMember(Name = "ingramQuoteDate", EmitDefaultValue = false)]
        public string IngramQuoteDate { get; set; }

        /// <summary>
        /// Date the Quote was last updated or modified.
        /// </summary>
        /// <value>Date the Quote was last updated or modified.</value>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Date when the Quote Expires.
        /// </summary>
        /// <value>Date when the Quote Expires.</value>
        [DataMember(Name = "ingramQuoteExpiryDate", EmitDefaultValue = false)]
        public string IngramQuoteExpiryDate { get; set; }

        /// <summary>
        /// Name of the vendor.
        /// </summary>
        /// <value>Name of the vendor.</value>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Name of the end user/customer who created a quote.
        /// </summary>
        /// <value>Name of the end user/customer who created a quote.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteSearchResponseQuotesInner {\n");
            sb.Append("  QuoteName: ").Append(QuoteName).Append("\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  EndUserContact: ").Append(EndUserContact).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  QuoteTotal: ").Append(QuoteTotal).Append("\n");
            sb.Append("  QuoteStatus: ").Append(QuoteStatus).Append("\n");
            sb.Append("  IngramQuoteDate: ").Append(IngramQuoteDate).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  IngramQuoteExpiryDate: ").Append(IngramQuoteExpiryDate).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
