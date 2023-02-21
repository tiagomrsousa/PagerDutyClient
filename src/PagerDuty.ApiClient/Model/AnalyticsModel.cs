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
    /// AnalyticsModel
    /// </summary>
    [DataContract]
        public partial class AnalyticsModel :  IEquatable<AnalyticsModel>, IValidatableObject
    {
        /// <summary>
        /// The time unit to aggregate metrics by.  If no value is provided, the metrics will be aggregated for the entire period.
        /// </summary>
        /// <value>The time unit to aggregate metrics by.  If no value is provided, the metrics will be aggregated for the entire period.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AggregateUnitEnum
        {
            /// <summary>
            /// Enum Day for value: day
            /// </summary>
            [EnumMember(Value = "day")]
            Day = 1,
            /// <summary>
            /// Enum Week for value: week
            /// </summary>
            [EnumMember(Value = "week")]
            Week = 2,
            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 3        }
        /// <summary>
        /// The time unit to aggregate metrics by.  If no value is provided, the metrics will be aggregated for the entire period.
        /// </summary>
        /// <value>The time unit to aggregate metrics by.  If no value is provided, the metrics will be aggregated for the entire period.</value>
        [DataMember(Name="aggregate_unit", EmitDefaultValue=false)]
        public AggregateUnitEnum? AggregateUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsModel" /> class.
        /// </summary>
        /// <param name="filters">Accepts a set of filters to apply to the Incidents before aggregating.  Any incidents that do not match the included filters will be omitted from the results.</param>
        /// <param name="timeZone">The time zone to use for the results and grouping..</param>
        /// <param name="aggregateUnit">The time unit to aggregate metrics by.  If no value is provided, the metrics will be aggregated for the entire period..</param>
        public AnalyticsModel(Object filters = default(Object), string timeZone = default(string), AggregateUnitEnum? aggregateUnit = default(AggregateUnitEnum?))
        {
            this.Filters = filters;
            this.TimeZone = timeZone;
            this.AggregateUnit = aggregateUnit;
        }
        
        /// <summary>
        /// Accepts a set of filters to apply to the Incidents before aggregating.  Any incidents that do not match the included filters will be omitted from the results
        /// </summary>
        /// <value>Accepts a set of filters to apply to the Incidents before aggregating.  Any incidents that do not match the included filters will be omitted from the results</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public Object Filters { get; set; }

        /// <summary>
        /// The time zone to use for the results and grouping.
        /// </summary>
        /// <value>The time zone to use for the results and grouping.</value>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsModel {\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  AggregateUnit: ").Append(AggregateUnit).Append("\n");
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
            return this.Equals(input as AnalyticsModel);
        }

        /// <summary>
        /// Returns true if AnalyticsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filters == input.Filters ||
                    (this.Filters != null &&
                    this.Filters.Equals(input.Filters))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.AggregateUnit == input.AggregateUnit ||
                    (this.AggregateUnit != null &&
                    this.AggregateUnit.Equals(input.AggregateUnit))
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
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.AggregateUnit != null)
                    hashCode = hashCode * 59 + this.AggregateUnit.GetHashCode();
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
