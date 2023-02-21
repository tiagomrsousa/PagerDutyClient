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
    /// Defines how alerts on this service are automatically suspended for a period of time before triggering, when identified as likely being transient. Note that automatically pausing notifications is only available on certain plans.
    /// </summary>
    [DataContract]
        public partial class AutoPauseNotificationsParameters :  IEquatable<AutoPauseNotificationsParameters>, IValidatableObject
    {
        /// <summary>
        /// Indicates in seconds how long alerts should be suspended before triggering
        /// </summary>
        /// <value>Indicates in seconds how long alerts should be suspended before triggering</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TimeoutEnum
        {
            /// <summary>
            /// Enum NUMBER_120 for value: 120
            /// </summary>
            [EnumMember(Value = "120")]
            NUMBER_120 = 1,
            /// <summary>
            /// Enum NUMBER_180 for value: 180
            /// </summary>
            [EnumMember(Value = "180")]
            NUMBER_180 = 2,
            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            [EnumMember(Value = "300")]
            NUMBER_300 = 3,
            /// <summary>
            /// Enum NUMBER_600 for value: 600
            /// </summary>
            [EnumMember(Value = "600")]
            NUMBER_600 = 4,
            /// <summary>
            /// Enum NUMBER_900 for value: 900
            /// </summary>
            [EnumMember(Value = "900")]
            NUMBER_900 = 5        }
        /// <summary>
        /// Indicates in seconds how long alerts should be suspended before triggering
        /// </summary>
        /// <value>Indicates in seconds how long alerts should be suspended before triggering</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public TimeoutEnum? Timeout { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoPauseNotificationsParameters" /> class.
        /// </summary>
        /// <param name="enabled">Indicates whether alerts should be automatically suspended when identified as transient (default to false).</param>
        /// <param name="timeout">Indicates in seconds how long alerts should be suspended before triggering.</param>
        public AutoPauseNotificationsParameters(bool? enabled = false, TimeoutEnum? timeout = default(TimeoutEnum?))
        {
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = enabled;
            }
            this.Timeout = timeout;
        }
        
        /// <summary>
        /// Indicates whether alerts should be automatically suspended when identified as transient
        /// </summary>
        /// <value>Indicates whether alerts should be automatically suspended when identified as transient</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoPauseNotificationsParameters {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as AutoPauseNotificationsParameters);
        }

        /// <summary>
        /// Returns true if AutoPauseNotificationsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoPauseNotificationsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoPauseNotificationsParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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