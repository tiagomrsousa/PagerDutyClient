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
    /// AutomationActionsInvocation
    /// </summary>
    [DataContract]
        public partial class AutomationActionsInvocation :  IEquatable<AutomationActionsInvocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationActionsInvocation" /> class.
        /// </summary>
        /// <param name="actionSnapshot">actionSnapshot (required).</param>
        /// <param name="runnerId">runnerId (required).</param>
        /// <param name="timing">A list of state transitions with timestamps. Only the &#x27;created&#x27; transition is guaranteed to exist at any time. (required).</param>
        /// <param name="duration">The duration of the invocation&#x27;s execution time..</param>
        /// <param name="state">state (required).</param>
        /// <param name="actionId">actionId (required).</param>
        /// <param name="metadata">metadata (required).</param>
        public AutomationActionsInvocation(Object actionSnapshot = default(Object), string runnerId = default(string), List<Object> timing = default(List<Object>), int? duration = default(int?), ComponentsparametersautomationActionsInvocationStateschema state = default(ComponentsparametersautomationActionsInvocationStateschema), string actionId = default(string), Object metadata = default(Object))
        {
            // to ensure "actionSnapshot" is required (not null)
            if (actionSnapshot == null)
            {
                throw new InvalidDataException("actionSnapshot is a required property for AutomationActionsInvocation and cannot be null");
            }
            else
            {
                this.ActionSnapshot = actionSnapshot;
            }
            // to ensure "runnerId" is required (not null)
            if (runnerId == null)
            {
                throw new InvalidDataException("runnerId is a required property for AutomationActionsInvocation and cannot be null");
            }
            else
            {
                this.RunnerId = runnerId;
            }
            // to ensure "timing" is required (not null)
            if (timing == null)
            {
                throw new InvalidDataException("timing is a required property for AutomationActionsInvocation and cannot be null");
            }
            else
            {
                this.Timing = timing;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for AutomationActionsInvocation and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "actionId" is required (not null)
            if (actionId == null)
            {
                throw new InvalidDataException("actionId is a required property for AutomationActionsInvocation and cannot be null");
            }
            else
            {
                this.ActionId = actionId;
            }
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for AutomationActionsInvocation and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            this.Duration = duration;
        }
        
        /// <summary>
        /// Gets or Sets ActionSnapshot
        /// </summary>
        [DataMember(Name="action_snapshot", EmitDefaultValue=false)]
        public Object ActionSnapshot { get; set; }

        /// <summary>
        /// Gets or Sets RunnerId
        /// </summary>
        [DataMember(Name="runner_id", EmitDefaultValue=false)]
        public string RunnerId { get; set; }

        /// <summary>
        /// A list of state transitions with timestamps. Only the &#x27;created&#x27; transition is guaranteed to exist at any time.
        /// </summary>
        /// <value>A list of state transitions with timestamps. Only the &#x27;created&#x27; transition is guaranteed to exist at any time.</value>
        [DataMember(Name="timing", EmitDefaultValue=false)]
        public List<Object> Timing { get; set; }

        /// <summary>
        /// The duration of the invocation&#x27;s execution time.
        /// </summary>
        /// <value>The duration of the invocation&#x27;s execution time.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ComponentsparametersautomationActionsInvocationStateschema State { get; set; }

        /// <summary>
        /// Gets or Sets ActionId
        /// </summary>
        [DataMember(Name="action_id", EmitDefaultValue=false)]
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomationActionsInvocation {\n");
            sb.Append("  ActionSnapshot: ").Append(ActionSnapshot).Append("\n");
            sb.Append("  RunnerId: ").Append(RunnerId).Append("\n");
            sb.Append("  Timing: ").Append(Timing).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as AutomationActionsInvocation);
        }

        /// <summary>
        /// Returns true if AutomationActionsInvocation instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomationActionsInvocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomationActionsInvocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionSnapshot == input.ActionSnapshot ||
                    (this.ActionSnapshot != null &&
                    this.ActionSnapshot.Equals(input.ActionSnapshot))
                ) && 
                (
                    this.RunnerId == input.RunnerId ||
                    (this.RunnerId != null &&
                    this.RunnerId.Equals(input.RunnerId))
                ) && 
                (
                    this.Timing == input.Timing ||
                    this.Timing != null &&
                    input.Timing != null &&
                    this.Timing.SequenceEqual(input.Timing)
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.ActionSnapshot != null)
                    hashCode = hashCode * 59 + this.ActionSnapshot.GetHashCode();
                if (this.RunnerId != null)
                    hashCode = hashCode * 59 + this.RunnerId.GetHashCode();
                if (this.Timing != null)
                    hashCode = hashCode * 59 + this.Timing.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ActionId != null)
                    hashCode = hashCode * 59 + this.ActionId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
