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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = PagerDuty.ApiClient.Client.SwaggerDateConverter;

namespace PagerDuty.ApiClient.Model
{
    /// <summary>
    /// IncidentUrgencyType
    /// </summary>
    [DataContract]
        public partial class IncidentUrgencyType :  IEquatable<IncidentUrgencyType>, IValidatableObject
    {
        /// <summary>
        /// The type of incident urgency: whether it&#x27;s constant, or it&#x27;s dependent on the support hours.
        /// </summary>
        /// <value>The type of incident urgency: whether it&#x27;s constant, or it&#x27;s dependent on the support hours.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Constant for value: constant
            /// </summary>
            [EnumMember(Value = "constant")]
            Constant = 1,
            /// <summary>
            /// Enum Usesupporthours for value: use_support_hours
            /// </summary>
            [EnumMember(Value = "use_support_hours")]
            Usesupporthours = 2        }
        /// <summary>
        /// The type of incident urgency: whether it&#x27;s constant, or it&#x27;s dependent on the support hours.
        /// </summary>
        /// <value>The type of incident urgency: whether it&#x27;s constant, or it&#x27;s dependent on the support hours.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The incidents&#x27; urgency, if type is constant.
        /// </summary>
        /// <value>The incidents&#x27; urgency, if type is constant.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UrgencyEnum
        {
            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 1,
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 2,
            /// <summary>
            /// Enum Severitybased for value: severity_based
            /// </summary>
            [EnumMember(Value = "severity_based")]
            Severitybased = 3        }
        /// <summary>
        /// The incidents&#x27; urgency, if type is constant.
        /// </summary>
        /// <value>The incidents&#x27; urgency, if type is constant.</value>
        [DataMember(Name="urgency", EmitDefaultValue=false)]
        public UrgencyEnum? Urgency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentUrgencyType" /> class.
        /// </summary>
        /// <param name="type">The type of incident urgency: whether it&#x27;s constant, or it&#x27;s dependent on the support hours. (default to TypeEnum.Constant).</param>
        /// <param name="urgency">The incidents&#x27; urgency, if type is constant. (default to UrgencyEnum.High).</param>
        public IncidentUrgencyType(TypeEnum? type = TypeEnum.Constant, UrgencyEnum? urgency = UrgencyEnum.High)
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.Constant;
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "urgency" provided
            if (urgency == null)
            {
                this.Urgency = UrgencyEnum.High;
            }
            else
            {
                this.Urgency = urgency;
            }
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncidentUrgencyType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Urgency: ").Append(Urgency).Append("\n");
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
            return this.Equals(input as IncidentUrgencyType);
        }

        /// <summary>
        /// Returns true if IncidentUrgencyType instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentUrgencyType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentUrgencyType input)
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
                    this.Urgency == input.Urgency ||
                    (this.Urgency != null &&
                    this.Urgency.Equals(input.Urgency))
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
                if (this.Urgency != null)
                    hashCode = hashCode * 59 + this.Urgency.GetHashCode();
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
            yield break;
        }
    }
}