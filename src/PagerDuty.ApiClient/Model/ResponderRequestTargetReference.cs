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
    /// ResponderRequestTargetReference
    /// </summary>
    [DataContract]
        public partial class ResponderRequestTargetReference :  IEquatable<ResponderRequestTargetReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponderRequestTargetReference" /> class.
        /// </summary>
        /// <param name="type">The type of target (either a user or an escalation policy).</param>
        /// <param name="id">The id of the user or escalation policy.</param>
        /// <param name="summary">summary.</param>
        /// <param name="incidentResponders">An array of responders associated with the specified incident.</param>
        public ResponderRequestTargetReference(string type = default(string), string id = default(string), string summary = default(string), List<IncidentsRespondersReference> incidentResponders = default(List<IncidentsRespondersReference>))
        {
            this.Type = type;
            this.Id = id;
            this.Summary = summary;
            this.IncidentResponders = incidentResponders;
        }
        
        /// <summary>
        /// The type of target (either a user or an escalation policy)
        /// </summary>
        /// <value>The type of target (either a user or an escalation policy)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The id of the user or escalation policy
        /// </summary>
        /// <value>The id of the user or escalation policy</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// An array of responders associated with the specified incident
        /// </summary>
        /// <value>An array of responders associated with the specified incident</value>
        [DataMember(Name="incident_responders", EmitDefaultValue=false)]
        public List<IncidentsRespondersReference> IncidentResponders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponderRequestTargetReference {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  IncidentResponders: ").Append(IncidentResponders).Append("\n");
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
            return this.Equals(input as ResponderRequestTargetReference);
        }

        /// <summary>
        /// Returns true if ResponderRequestTargetReference instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponderRequestTargetReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponderRequestTargetReference input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.IncidentResponders == input.IncidentResponders ||
                    this.IncidentResponders != null &&
                    input.IncidentResponders != null &&
                    this.IncidentResponders.SequenceEqual(input.IncidentResponders)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.IncidentResponders != null)
                    hashCode = hashCode * 59 + this.IncidentResponders.GetHashCode();
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
