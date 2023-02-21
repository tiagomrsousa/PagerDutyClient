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
    /// ResponderRequest
    /// </summary>
    [DataContract]
        public partial class ResponderRequest :  IEquatable<ResponderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponderRequest" /> class.
        /// </summary>
        /// <param name="incident">incident.</param>
        /// <param name="requester">requester.</param>
        /// <param name="requestedAt">The time the request was made.</param>
        /// <param name="message">The message sent with the responder request.</param>
        /// <param name="responderRequestTargets">The array of targets the responder request is being sent to.</param>
        public ResponderRequest(IncidentReference incident = default(IncidentReference), UserReference requester = default(UserReference), string requestedAt = default(string), string message = default(string), List<ResponderRequestTargetReference> responderRequestTargets = default(List<ResponderRequestTargetReference>))
        {
            this.Incident = incident;
            this.Requester = requester;
            this.RequestedAt = requestedAt;
            this.Message = message;
            this.ResponderRequestTargets = responderRequestTargets;
        }
        
        /// <summary>
        /// Gets or Sets Incident
        /// </summary>
        [DataMember(Name="incident", EmitDefaultValue=false)]
        public IncidentReference Incident { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name="requester", EmitDefaultValue=false)]
        public UserReference Requester { get; set; }

        /// <summary>
        /// The time the request was made
        /// </summary>
        /// <value>The time the request was made</value>
        [DataMember(Name="requested_at", EmitDefaultValue=false)]
        public string RequestedAt { get; set; }

        /// <summary>
        /// The message sent with the responder request
        /// </summary>
        /// <value>The message sent with the responder request</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The array of targets the responder request is being sent to
        /// </summary>
        /// <value>The array of targets the responder request is being sent to</value>
        [DataMember(Name="responder_request_targets", EmitDefaultValue=false)]
        public List<ResponderRequestTargetReference> ResponderRequestTargets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponderRequest {\n");
            sb.Append("  Incident: ").Append(Incident).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  RequestedAt: ").Append(RequestedAt).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ResponderRequestTargets: ").Append(ResponderRequestTargets).Append("\n");
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
            return this.Equals(input as ResponderRequest);
        }

        /// <summary>
        /// Returns true if ResponderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Incident == input.Incident ||
                    (this.Incident != null &&
                    this.Incident.Equals(input.Incident))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.RequestedAt == input.RequestedAt ||
                    (this.RequestedAt != null &&
                    this.RequestedAt.Equals(input.RequestedAt))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ResponderRequestTargets == input.ResponderRequestTargets ||
                    this.ResponderRequestTargets != null &&
                    input.ResponderRequestTargets != null &&
                    this.ResponderRequestTargets.SequenceEqual(input.ResponderRequestTargets)
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
                if (this.Incident != null)
                    hashCode = hashCode * 59 + this.Incident.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.RequestedAt != null)
                    hashCode = hashCode * 59 + this.RequestedAt.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ResponderRequestTargets != null)
                    hashCode = hashCode * 59 + this.ResponderRequestTargets.GetHashCode();
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
