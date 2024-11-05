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
    /// PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_subscriptionPrice_inner_options_inner")]
    public partial class PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner" /> class.
        /// </summary>
        /// <param name="resourceId">resourceId.</param>
        /// <param name="resourceUId">The resource id of the subscription product..</param>
        /// <param name="resourceName">The name of the resource of the subscription product..</param>
        /// <param name="vendorPartNumber">Vendor’s part number for the subscription product..</param>
        /// <param name="minUnits">Minimum unit needs to purchased..</param>
        /// <param name="maxUnits">Maximum unit available for a purchase..</param>
        /// <param name="recurringpricemodel">Recurring price model.</param>
        /// <param name="unitOfMeasure">Unit of mesaure for a subscription product..</param>
        /// <param name="resourcePricing">resourcePricing.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="fees">fees.</param>
        public PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner(string resourceId = default(string), string resourceUId = default(string), string resourceName = default(string), string vendorPartNumber = default(string), decimal minUnits = default(decimal), decimal maxUnits = default(decimal), string recurringpricemodel = default(string), string unitOfMeasure = default(string), List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerResourcePricingInner> resourcePricing = default(List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerResourcePricingInner>), List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInner> discounts = default(List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInner>), List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerFeesInner> fees = default(List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerFeesInner>))
        {
            this.ResourceId = resourceId;
            this.ResourceUId = resourceUId;
            this.ResourceName = resourceName;
            this.VendorPartNumber = vendorPartNumber;
            this.MinUnits = minUnits;
            this.MaxUnits = maxUnits;
            this.Recurringpricemodel = recurringpricemodel;
            this.UnitOfMeasure = unitOfMeasure;
            this.ResourcePricing = resourcePricing;
            this.Discounts = discounts;
            this.Fees = fees;
        }

        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name = "resourceId", EmitDefaultValue = false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The resource id of the subscription product.
        /// </summary>
        /// <value>The resource id of the subscription product.</value>
        [DataMember(Name = "resourceUId", EmitDefaultValue = false)]
        public string ResourceUId { get; set; }

        /// <summary>
        /// The name of the resource of the subscription product.
        /// </summary>
        /// <value>The name of the resource of the subscription product.</value>
        [DataMember(Name = "resourceName", EmitDefaultValue = false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Vendor’s part number for the subscription product.
        /// </summary>
        /// <value>Vendor’s part number for the subscription product.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Minimum unit needs to purchased.
        /// </summary>
        /// <value>Minimum unit needs to purchased.</value>
        [DataMember(Name = "minUnits", EmitDefaultValue = false)]
        public decimal MinUnits { get; set; }

        /// <summary>
        /// Maximum unit available for a purchase.
        /// </summary>
        /// <value>Maximum unit available for a purchase.</value>
        [DataMember(Name = "maxUnits", EmitDefaultValue = false)]
        public decimal MaxUnits { get; set; }

        /// <summary>
        /// Recurring price model
        /// </summary>
        /// <value>Recurring price model</value>
        [DataMember(Name = "recurringpricemodel", EmitDefaultValue = false)]
        public string Recurringpricemodel { get; set; }

        /// <summary>
        /// Unit of mesaure for a subscription product.
        /// </summary>
        /// <value>Unit of mesaure for a subscription product.</value>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets ResourcePricing
        /// </summary>
        [DataMember(Name = "resourcePricing", EmitDefaultValue = false)]
        public List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerResourcePricingInner> ResourcePricing { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name = "discounts", EmitDefaultValue = false)]
        public List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInner> Discounts { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        public List<PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerFeesInner> Fees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner {\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceUId: ").Append(ResourceUId).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  MinUnits: ").Append(MinUnits).Append("\n");
            sb.Append("  MaxUnits: ").Append(MaxUnits).Append("\n");
            sb.Append("  Recurringpricemodel: ").Append(Recurringpricemodel).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  ResourcePricing: ").Append(ResourcePricing).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
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
