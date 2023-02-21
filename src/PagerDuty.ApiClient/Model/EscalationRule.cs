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
    /// EscalationRule
    /// </summary>
    [DataContract]
        public partial class EscalationRule :  IEquatable<EscalationRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationRule" /> class.
        /// </summary>
        /// <param name="escalationDelayInMinutes">The number of minutes before an unacknowledged incident escalates away from this rule. (required).</param>
        /// <param name="targets">The targets an incident should be assigned to upon reaching this rule. (required).</param>
        public EscalationRule(int? escalationDelayInMinutes = default(int?), List<EscalationTargetReference> targets = default(List<EscalationTargetReference>))
        {
            // to ensure "escalationDelayInMinutes" is required (not null)
            if (escalationDelayInMinutes == null)
            {
                throw new InvalidDataException("escalationDelayInMinutes is a required property for EscalationRule and cannot be null");
            }
            else
            {
                this.EscalationDelayInMinutes = escalationDelayInMinutes;
            }
            // to ensure "targets" is required (not null)
            if (targets == null)
            {
                throw new InvalidDataException("targets is a required property for EscalationRule and cannot be null");
            }
            else
            {
                this.Targets = targets;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The number of minutes before an unacknowledged incident escalates away from this rule.
        /// </summary>
        /// <value>The number of minutes before an unacknowledged incident escalates away from this rule.</value>
        [DataMember(Name="escalation_delay_in_minutes", EmitDefaultValue=false)]
        public int? EscalationDelayInMinutes { get; set; }

        /// <summary>
        /// The targets an incident should be assigned to upon reaching this rule.
        /// </summary>
        /// <value>The targets an incident should be assigned to upon reaching this rule.</value>
        [DataMember(Name="targets", EmitDefaultValue=false)]
        public List<EscalationTargetReference> Targets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EscalationRule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EscalationDelayInMinutes: ").Append(EscalationDelayInMinutes).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
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
            return this.Equals(input as EscalationRule);
        }

        /// <summary>
        /// Returns true if EscalationRule instances are equal
        /// </summary>
        /// <param name="input">Instance of EscalationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EscalationRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EscalationDelayInMinutes == input.EscalationDelayInMinutes ||
                    (this.EscalationDelayInMinutes != null &&
                    this.EscalationDelayInMinutes.Equals(input.EscalationDelayInMinutes))
                ) && 
                (
                    this.Targets == input.Targets ||
                    this.Targets != null &&
                    input.Targets != null &&
                    this.Targets.SequenceEqual(input.Targets)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EscalationDelayInMinutes != null)
                    hashCode = hashCode * 59 + this.EscalationDelayInMinutes.GetHashCode();
                if (this.Targets != null)
                    hashCode = hashCode * 59 + this.Targets.GetHashCode();
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