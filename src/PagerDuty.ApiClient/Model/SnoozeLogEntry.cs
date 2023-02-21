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
    /// SnoozeLogEntry
    /// </summary>
    [DataContract]
        public partial class SnoozeLogEntry : LogEntry,  IEquatable<SnoozeLogEntry>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Snoozelogentry for value: snooze_log_entry
            /// </summary>
            [EnumMember(Value = "snooze_log_entry")]
            Snoozelogentry = 1        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeLogEntry" /> class.
        /// </summary>
        /// <param name="changedActions">changedActions.</param>
        /// <param name="type">type.</param>
        public SnoozeLogEntry(List<IncidentAction> changedActions = default(List<IncidentAction>), TypeEnum? type = default(TypeEnum?), Channel channel = default(Channel), AgentReference agent = default(AgentReference), ServiceReference service = default(ServiceReference), UserReference user = default(UserReference), IncidentReference incident = default(IncidentReference)) : base(channel, agent, service, user, incident)
        {
            this.ChangedActions = changedActions;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ChangedActions
        /// </summary>
        [DataMember(Name="changed_actions", EmitDefaultValue=false)]
        public List<IncidentAction> ChangedActions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnoozeLogEntry {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ChangedActions: ").Append(ChangedActions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SnoozeLogEntry);
        }

        /// <summary>
        /// Returns true if SnoozeLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of SnoozeLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnoozeLogEntry input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ChangedActions == input.ChangedActions ||
                    this.ChangedActions != null &&
                    input.ChangedActions != null &&
                    this.ChangedActions.SequenceEqual(input.ChangedActions)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ChangedActions != null)
                    hashCode = hashCode * 59 + this.ChangedActions.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
