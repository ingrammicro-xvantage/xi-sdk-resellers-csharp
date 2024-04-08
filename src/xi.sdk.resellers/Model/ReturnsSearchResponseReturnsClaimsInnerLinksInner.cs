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
    /// ReturnsSearchResponseReturnsClaimsInnerLinksInner
    /// </summary>
    [DataContract(Name = "returnsSearchResponse_returnsClaims_inner_links_inner")]
    public partial class ReturnsSearchResponseReturnsClaimsInnerLinksInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsSearchResponseReturnsClaimsInnerLinksInner" /> class.
        /// </summary>
        /// <param name="topic">Provides the details of the return..</param>
        /// <param name="href">The URL endpoint for accessing the relevant data..</param>
        /// <param name="type">The type of call that can be made to the href link (GET, POST, Etc.)..</param>
        public ReturnsSearchResponseReturnsClaimsInnerLinksInner(string topic = default(string), string href = default(string), string type = default(string))
        {
            this.Topic = topic;
            this.Href = href;
            this.Type = type;
        }

        /// <summary>
        /// Provides the details of the return.
        /// </summary>
        /// <value>Provides the details of the return.</value>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

        /// <summary>
        /// The URL endpoint for accessing the relevant data.
        /// </summary>
        /// <value>The URL endpoint for accessing the relevant data.</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// The type of call that can be made to the href link (GET, POST, Etc.).
        /// </summary>
        /// <value>The type of call that can be made to the href link (GET, POST, Etc.).</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnsSearchResponseReturnsClaimsInnerLinksInner {\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
