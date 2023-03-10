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
    /// WeeklyRestriction
    /// </summary>
    [DataContract]
        public partial class WeeklyRestriction : Restriction,  IEquatable<WeeklyRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyRestriction" /> class.
        /// </summary>
        /// <param name="startDayOfWeek">The first day of the weekly rotation schedule as [ISO 8601 day](https://en.wikipedia.org/wiki/ISO_week_date) (1 is Monday, etc.) (required).</param>
        public WeeklyRestriction(int? startDayOfWeek = default(int?), TypeEnum type = default(TypeEnum), int? durationSeconds = default(int?), string startTimeOfDay = default(string)) : base(type, durationSeconds, startTimeOfDay, startDayOfWeek)
        {
            // to ensure "startDayOfWeek" is required (not null)
            if (startDayOfWeek == null)
            {
                throw new InvalidDataException("startDayOfWeek is a required property for WeeklyRestriction and cannot be null");
            }
            else
            {
                this.StartDayOfWeek = startDayOfWeek;
            }
        }
        
        /// <summary>
        /// The first day of the weekly rotation schedule as [ISO 8601 day](https://en.wikipedia.org/wiki/ISO_week_date) (1 is Monday, etc.)
        /// </summary>
        /// <value>The first day of the weekly rotation schedule as [ISO 8601 day](https://en.wikipedia.org/wiki/ISO_week_date) (1 is Monday, etc.)</value>
        [DataMember(Name="start_day_of_week", EmitDefaultValue=false)]
        public int? StartDayOfWeek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeeklyRestriction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as WeeklyRestriction);
        }

        /// <summary>
        /// Returns true if WeeklyRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of WeeklyRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeeklyRestriction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
            yield break;
        }
    }
}
