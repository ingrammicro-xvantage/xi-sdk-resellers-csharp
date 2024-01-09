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
    /// ReturnsSearchResponseReturnsClaimsInner
    /// </summary>
    [DataContract(Name = "returnsSearchResponse_returnsClaims_inner")]
    public partial class ReturnsSearchResponseReturnsClaimsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsSearchResponseReturnsClaimsInner" /> class.
        /// </summary>
        /// <param name="returnClaimId">A unique return claim Id..</param>
        /// <param name="caseRequestNumber">A unique return request number..</param>
        /// <param name="createdOn">The date on which the return request was created. .</param>
        /// <param name="type">Type of request..</param>
        /// <param name="returnReason">The reason for the return..</param>
        /// <param name="referenceNumber">The reference number for the return..</param>
        /// <param name="estimatedTotalValue">The estimated total value of the return..</param>
        /// <param name="credit">The amount of credit..</param>
        /// <param name="modifiedOn">The date on which the return request was last updated..</param>
        /// <param name="status">The status of the request..</param>
        /// <param name="links">links.</param>
        public ReturnsSearchResponseReturnsClaimsInner(string returnClaimId = default(string), string caseRequestNumber = default(string), DateTime createdOn = default(DateTime), string type = default(string), string returnReason = default(string), string referenceNumber = default(string), DateTime estimatedTotalValue = default(DateTime), decimal credit = default(decimal), string modifiedOn = default(string), string status = default(string), List<ReturnsSearchResponseReturnsClaimsInnerLinksInner> links = default(List<ReturnsSearchResponseReturnsClaimsInnerLinksInner>))
        {
            this.ReturnClaimId = returnClaimId;
            this.CaseRequestNumber = caseRequestNumber;
            this.CreatedOn = createdOn;
            this.Type = type;
            this.ReturnReason = returnReason;
            this.ReferenceNumber = referenceNumber;
            this.EstimatedTotalValue = estimatedTotalValue;
            this.Credit = credit;
            this.ModifiedOn = modifiedOn;
            this.Status = status;
            this.Links = links;
        }

        /// <summary>
        /// A unique return claim Id.
        /// </summary>
        /// <value>A unique return claim Id.</value>
        [DataMember(Name = "returnClaimId", EmitDefaultValue = false)]
        public string ReturnClaimId { get; set; }

        /// <summary>
        /// A unique return request number.
        /// </summary>
        /// <value>A unique return request number.</value>
        [DataMember(Name = "caseRequestNumber", EmitDefaultValue = false)]
        public string CaseRequestNumber { get; set; }

        /// <summary>
        /// The date on which the return request was created. 
        /// </summary>
        /// <value>The date on which the return request was created. </value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Type of request.
        /// </summary>
        /// <value>Type of request.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The reason for the return.
        /// </summary>
        /// <value>The reason for the return.</value>
        [DataMember(Name = "returnReason", EmitDefaultValue = false)]
        public string ReturnReason { get; set; }

        /// <summary>
        /// The reference number for the return.
        /// </summary>
        /// <value>The reference number for the return.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The estimated total value of the return.
        /// </summary>
        /// <value>The estimated total value of the return.</value>
        [DataMember(Name = "estimatedTotalValue", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EstimatedTotalValue { get; set; }

        /// <summary>
        /// The amount of credit.
        /// </summary>
        /// <value>The amount of credit.</value>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public decimal Credit { get; set; }

        /// <summary>
        /// The date on which the return request was last updated.
        /// </summary>
        /// <value>The date on which the return request was last updated.</value>
        [DataMember(Name = "modifiedOn", EmitDefaultValue = false)]
        public string ModifiedOn { get; set; }

        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <value>The status of the request.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<ReturnsSearchResponseReturnsClaimsInnerLinksInner> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnsSearchResponseReturnsClaimsInner {\n");
            sb.Append("  ReturnClaimId: ").Append(ReturnClaimId).Append("\n");
            sb.Append("  CaseRequestNumber: ").Append(CaseRequestNumber).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReturnReason: ").Append(ReturnReason).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  EstimatedTotalValue: ").Append(EstimatedTotalValue).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
