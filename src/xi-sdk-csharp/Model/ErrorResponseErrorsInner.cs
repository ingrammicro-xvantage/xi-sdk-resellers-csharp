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
    /// ErrorResponseErrorsInner
    /// </summary>
    [DataContract(Name = "ErrorResponse_errors_inner")]
    public partial class ErrorResponseErrorsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorsInner" /> class.
        /// </summary>
        /// <param name="id">Unique Id to identify error..</param>
        /// <param name="type">Describes the type of the error..</param>
        /// <param name="message">Describes the error message..</param>
        /// <param name="fields">fields.</param>
        public ErrorResponseErrorsInner(string id = default(string), string type = default(string), string message = default(string), List<ErrorResponseErrorsInnerFieldsInner> fields = default(List<ErrorResponseErrorsInnerFieldsInner>))
        {
            this.Id = id;
            this.Type = type;
            this.Message = message;
            this.Fields = fields;
        }

        /// <summary>
        /// Unique Id to identify error.
        /// </summary>
        /// <value>Unique Id to identify error.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Describes the type of the error.
        /// </summary>
        /// <value>Describes the type of the error.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Describes the error message.
        /// </summary>
        /// <value>Describes the error message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<ErrorResponseErrorsInnerFieldsInner> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorResponseErrorsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
