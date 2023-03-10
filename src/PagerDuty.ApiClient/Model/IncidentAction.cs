/* 
 * PagerDuty API
 *
 * This document describes the PagerDuty REST APIs.  For guides and examples please visit our [Documentation.](https://developer.pagerduty.com/docs/get-started/getting-started/)  Our REST APIs are defined in OpenAPI v3.x. You can view the schema at [github.com/PagerDuty/api-schema](https://github.com/PagerDuty/api-schema).  Note that properties in some schemas have fields not shown by default such as `readOnly`, `format`, and `default`. Hover your cursor over the right column that looks like `optional+1` to see the full list of fields. 
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@pagerduty.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = PagerDuty.ApiClient.Client.SwaggerDateConverter;

namespace PagerDuty.ApiClient.Model
{
    /// <summary>
    /// An incident action is a pending change to an incident that will automatically happen at some future time.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
        public partial class IncidentAction :  IEquatable<IncidentAction>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Unacknowledge for value: unacknowledge
            /// </summary>
            [EnumMember(Value = "unacknowledge")]
            Unacknowledge = 1,
            /// <summary>
            /// Enum Escalate for value: escalate
            /// </summary>
            [EnumMember(Value = "escalate")]
            Escalate = 2,
            /// <summary>
            /// Enum Resolve for value: resolve
            /// </summary>
            [EnumMember(Value = "resolve")]
            Resolve = 3,
            /// <summary>
            /// Enum Urgencychange for value: urgency_change
            /// </summary>
            [EnumMember(Value = "urgency_change")]
            Urgencychange = 4        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentAction" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="at">at (required).</param>
        public IncidentAction(TypeEnum type = default(TypeEnum), DateTime? at = default(DateTime?))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for IncidentAction and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "at" is required (not null)
            if (at == null)
            {
                throw new InvalidDataException("at is a required property for IncidentAction and cannot be null");
            }
            else
            {
                this.At = at;
            }
        }
        

        /// <summary>
        /// Gets or Sets At
        /// </summary>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public DateTime? At { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncidentAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncidentAction);
        }

        /// <summary>
        /// Returns true if IncidentAction instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
