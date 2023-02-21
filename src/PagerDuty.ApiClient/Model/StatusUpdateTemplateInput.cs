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
    /// StatusUpdateTemplateInput
    /// </summary>
    [DataContract]
        public partial class StatusUpdateTemplateInput :  IEquatable<StatusUpdateTemplateInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusUpdateTemplateInput" /> class.
        /// </summary>
        /// <param name="incidentId">The incident id to render the template for.</param>
        /// <param name="statusUpdate">statusUpdate.</param>
        /// <param name="external">An optional object collection that can be referenced in the template..</param>
        public StatusUpdateTemplateInput(string incidentId = default(string), Object statusUpdate = default(Object), Object external = default(Object))
        {
            this.IncidentId = incidentId;
            this.StatusUpdate = statusUpdate;
            this.External = external;
        }
        
        /// <summary>
        /// The incident id to render the template for
        /// </summary>
        /// <value>The incident id to render the template for</value>
        [DataMember(Name="incident_id", EmitDefaultValue=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// Gets or Sets StatusUpdate
        /// </summary>
        [DataMember(Name="status_update", EmitDefaultValue=false)]
        public Object StatusUpdate { get; set; }

        /// <summary>
        /// An optional object collection that can be referenced in the template.
        /// </summary>
        /// <value>An optional object collection that can be referenced in the template.</value>
        [DataMember(Name="external", EmitDefaultValue=false)]
        public Object External { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusUpdateTemplateInput {\n");
            sb.Append("  IncidentId: ").Append(IncidentId).Append("\n");
            sb.Append("  StatusUpdate: ").Append(StatusUpdate).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
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
            return this.Equals(input as StatusUpdateTemplateInput);
        }

        /// <summary>
        /// Returns true if StatusUpdateTemplateInput instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusUpdateTemplateInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusUpdateTemplateInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncidentId == input.IncidentId ||
                    (this.IncidentId != null &&
                    this.IncidentId.Equals(input.IncidentId))
                ) && 
                (
                    this.StatusUpdate == input.StatusUpdate ||
                    (this.StatusUpdate != null &&
                    this.StatusUpdate.Equals(input.StatusUpdate))
                ) && 
                (
                    this.External == input.External ||
                    (this.External != null &&
                    this.External.Equals(input.External))
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
                if (this.IncidentId != null)
                    hashCode = hashCode * 59 + this.IncidentId.GetHashCode();
                if (this.StatusUpdate != null)
                    hashCode = hashCode * 59 + this.StatusUpdate.GetHashCode();
                if (this.External != null)
                    hashCode = hashCode * 59 + this.External.GetHashCode();
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