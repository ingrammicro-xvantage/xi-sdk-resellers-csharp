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
    /// PostCreateorderV7400ResponseFieldsInner
    /// </summary>
    [DataContract(Name = "post_createorder_v7_400_response_fields_inner")]
    public partial class PostCreateorderV7400ResponseFieldsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCreateorderV7400ResponseFieldsInner" /> class.
        /// </summary>
        /// <param name="field">Name of the field..</param>
        /// <param name="message">A filed level error message..</param>
        /// <param name="value">Value of the message..</param>
        public PostCreateorderV7400ResponseFieldsInner(string field = default(string), string message = default(string), string value = default(string))
        {
            this.Field = field;
            this.Message = message;
            this.Value = value;
        }

        /// <summary>
        /// Name of the field.
        /// </summary>
        /// <value>Name of the field.</value>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// A filed level error message.
        /// </summary>
        /// <value>A filed level error message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Value of the message.
        /// </summary>
        /// <value>Value of the message.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostCreateorderV7400ResponseFieldsInner {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
