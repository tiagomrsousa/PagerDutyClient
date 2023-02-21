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
    /// Restriction
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(WeeklyRestriction), "WeeklyRestriction")]
        public partial class Restriction :  IEquatable<Restriction>, IValidatableObject
    {
        /// <summary>
        /// Specify the types of &#x60;restriction&#x60;.
        /// </summary>
        /// <value>Specify the types of &#x60;restriction&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Dailyrestriction for value: daily_restriction
            /// </summary>
            [EnumMember(Value = "daily_restriction")]
            Dailyrestriction = 1,
            /// <summary>
            /// Enum Weeklyrestriction for value: weekly_restriction
            /// </summary>
            [EnumMember(Value = "weekly_restriction")]
            Weeklyrestriction = 2        }
        /// <summary>
        /// Specify the types of &#x60;restriction&#x60;.
        /// </summary>
        /// <value>Specify the types of &#x60;restriction&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Restriction" /> class.
        /// </summary>
        /// <param name="type">Specify the types of &#x60;restriction&#x60;. (required).</param>
        /// <param name="durationSeconds">The duration of the restriction in seconds. (required).</param>
        /// <param name="startTimeOfDay">The start time in HH:mm:ss format. (required).</param>
        /// <param name="startDayOfWeek">Only required for use with a &#x60;weekly_restriction&#x60; restriction type. The first day of the weekly rotation schedule as [ISO 8601 day](https://en.wikipedia.org/wiki/ISO_week_date) (1 is Monday, etc.).</param>
        public Restriction(TypeEnum type = default(TypeEnum), int? durationSeconds = default(int?), string startTimeOfDay = default(string), int? startDayOfWeek = default(int?))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Restriction and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "durationSeconds" is required (not null)
            if (durationSeconds == null)
            {
                throw new InvalidDataException("durationSeconds is a required property for Restriction and cannot be null");
            }
            else
            {
                this.DurationSeconds = durationSeconds;
            }
            // to ensure "startTimeOfDay" is required (not null)
            if (startTimeOfDay == null)
            {
                throw new InvalidDataException("startTimeOfDay is a required property for Restriction and cannot be null");
            }
            else
            {
                this.StartTimeOfDay = startTimeOfDay;
            }
            this.StartDayOfWeek = startDayOfWeek;
        }
        

        /// <summary>
        /// The duration of the restriction in seconds.
        /// </summary>
        /// <value>The duration of the restriction in seconds.</value>
        [DataMember(Name="duration_seconds", EmitDefaultValue=false)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// The start time in HH:mm:ss format.
        /// </summary>
        /// <value>The start time in HH:mm:ss format.</value>
        [DataMember(Name="start_time_of_day", EmitDefaultValue=false)]
        public string StartTimeOfDay { get; set; }

        /// <summary>
        /// Only required for use with a &#x60;weekly_restriction&#x60; restriction type. The first day of the weekly rotation schedule as [ISO 8601 day](https://en.wikipedia.org/wiki/ISO_week_date) (1 is Monday, etc.)
        /// </summary>
        /// <value>Only required for use with a &#x60;weekly_restriction&#x60; restriction type. The first day of the weekly rotation schedule as [ISO 8601 day](https://en.wikipedia.org/wiki/ISO_week_date) (1 is Monday, etc.)</value>
        [DataMember(Name="start_day_of_week", EmitDefaultValue=false)]
        public int? StartDayOfWeek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Restriction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  StartTimeOfDay: ").Append(StartTimeOfDay).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
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
            return this.Equals(input as Restriction);
        }

        /// <summary>
        /// Returns true if Restriction instances are equal
        /// </summary>
        /// <param name="input">Instance of Restriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Restriction input)
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
                    this.DurationSeconds == input.DurationSeconds ||
                    (this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(input.DurationSeconds))
                ) && 
                (
                    this.StartTimeOfDay == input.StartTimeOfDay ||
                    (this.StartTimeOfDay != null &&
                    this.StartTimeOfDay.Equals(input.StartTimeOfDay))
                ) && 
                (
                    this.StartDayOfWeek == input.StartDayOfWeek ||
                    (this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(input.StartDayOfWeek))
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
                if (this.DurationSeconds != null)
                    hashCode = hashCode * 59 + this.DurationSeconds.GetHashCode();
                if (this.StartTimeOfDay != null)
                    hashCode = hashCode * 59 + this.StartTimeOfDay.GetHashCode();
                if (this.StartDayOfWeek != null)
                    hashCode = hashCode * 59 + this.StartDayOfWeek.GetHashCode();
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
