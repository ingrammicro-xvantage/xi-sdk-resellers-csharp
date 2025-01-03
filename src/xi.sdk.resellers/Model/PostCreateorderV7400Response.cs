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
    /// PostCreateorderV7400Response
    /// </summary>
    [DataContract(Name = "post_createorder_v7_400_response")]
    public partial class PostCreateorderV7400Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCreateorderV7400Response" /> class.
        /// </summary>
        /// <param name="traceid">A unique trace id to identify the issue..</param>
        /// <param name="type">Type of the error message..</param>
        /// <param name="message">A detailed error message..</param>
        /// <param name="fields">fields.</param>
        public PostCreateorderV7400Response(string traceid = default(string), string type = default(string), string message = default(string), List<PostCreateorderV7400ResponseFieldsInner> fields = default(List<PostCreateorderV7400ResponseFieldsInner>))
        {
            this.Traceid = traceid;
            this.Type = type;
            this.Message = message;
            this.Fields = fields;
        }

        /// <summary>
        /// A unique trace id to identify the issue.
        /// </summary>
        /// <value>A unique trace id to identify the issue.</value>
        [DataMember(Name = "traceid", EmitDefaultValue = false)]
        public string Traceid { get; set; }

        /// <summary>
        /// Type of the error message.
        /// </summary>
        /// <value>Type of the error message.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// A detailed error message.
        /// </summary>
        /// <value>A detailed error message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<PostCreateorderV7400ResponseFieldsInner> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostCreateorderV7400Response {\n");
            sb.Append("  Traceid: ").Append(Traceid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
