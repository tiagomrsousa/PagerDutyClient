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
    /// EscalationPolicy
    /// </summary>
    [DataContract]
        public partial class EscalationPolicy :  IEquatable<EscalationPolicy>, IValidatableObject
    {
        /// <summary>
        /// The type of object being created.
        /// </summary>
        /// <value>The type of object being created.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Escalationpolicy for value: escalation_policy
            /// </summary>
            [EnumMember(Value = "escalation_policy")]
            Escalationpolicy = 1        }
        /// <summary>
        /// The type of object being created.
        /// </summary>
        /// <value>The type of object being created.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Determines how on call handoff notifications will be sent for users on the escalation policy. Defaults to \&quot;if_has_services\&quot;.
        /// </summary>
        /// <value>Determines how on call handoff notifications will be sent for users on the escalation policy. Defaults to \&quot;if_has_services\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OnCallHandoffNotificationsEnum
        {
            /// <summary>
            /// Enum Ifhasservices for value: if_has_services
            /// </summary>
            [EnumMember(Value = "if_has_services")]
            Ifhasservices = 1,
            /// <summary>
            /// Enum Always for value: always
            /// </summary>
            [EnumMember(Value = "always")]
            Always = 2        }
        /// <summary>
        /// Determines how on call handoff notifications will be sent for users on the escalation policy. Defaults to \&quot;if_has_services\&quot;.
        /// </summary>
        /// <value>Determines how on call handoff notifications will be sent for users on the escalation policy. Defaults to \&quot;if_has_services\&quot;.</value>
        [DataMember(Name="on_call_handoff_notifications", EmitDefaultValue=false)]
        public OnCallHandoffNotificationsEnum? OnCallHandoffNotifications { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationPolicy" /> class.
        /// </summary>
        /// <param name="type">The type of object being created. (required) (default to TypeEnum.Escalationpolicy).</param>
        /// <param name="name">The name of the escalation policy. (required).</param>
        /// <param name="description">Escalation policy description..</param>
        /// <param name="numLoops">The number of times the escalation policy will repeat after reaching the end of its escalation. (default to 0).</param>
        /// <param name="onCallHandoffNotifications">Determines how on call handoff notifications will be sent for users on the escalation policy. Defaults to \&quot;if_has_services\&quot;..</param>
        /// <param name="escalationRules">escalationRules (required).</param>
        /// <param name="teams">Teams associated with the policy. Account must have the &#x60;teams&#x60; ability to use this parameter..</param>
        public EscalationPolicy(TypeEnum type = TypeEnum.Escalationpolicy, string name = default(string), string description = default(string), int? numLoops = 0, OnCallHandoffNotificationsEnum? onCallHandoffNotifications = default(OnCallHandoffNotificationsEnum?), List<EscalationRule> escalationRules = default(List<EscalationRule>), List<TeamReference> teams = default(List<TeamReference>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for EscalationPolicy and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EscalationPolicy and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "escalationRules" is required (not null)
            if (escalationRules == null)
            {
                throw new InvalidDataException("escalationRules is a required property for EscalationPolicy and cannot be null");
            }
            else
            {
                this.EscalationRules = escalationRules;
            }
            this.Description = description;
            // use default value if no "numLoops" provided
            if (numLoops == null)
            {
                this.NumLoops = 0;
            }
            else
            {
                this.NumLoops = numLoops;
            }
            this.OnCallHandoffNotifications = onCallHandoffNotifications;
            this.Teams = teams;
        }
        

        /// <summary>
        /// The name of the escalation policy.
        /// </summary>
        /// <value>The name of the escalation policy.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Escalation policy description.
        /// </summary>
        /// <value>Escalation policy description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of times the escalation policy will repeat after reaching the end of its escalation.
        /// </summary>
        /// <value>The number of times the escalation policy will repeat after reaching the end of its escalation.</value>
        [DataMember(Name="num_loops", EmitDefaultValue=false)]
        public int? NumLoops { get; set; }


        /// <summary>
        /// Gets or Sets EscalationRules
        /// </summary>
        [DataMember(Name="escalation_rules", EmitDefaultValue=false)]
        public List<EscalationRule> EscalationRules { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<ServiceReference> Services { get; private set; }

        /// <summary>
        /// Teams associated with the policy. Account must have the &#x60;teams&#x60; ability to use this parameter.
        /// </summary>
        /// <value>Teams associated with the policy. Account must have the &#x60;teams&#x60; ability to use this parameter.</value>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<TeamReference> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EscalationPolicy {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NumLoops: ").Append(NumLoops).Append("\n");
            sb.Append("  OnCallHandoffNotifications: ").Append(OnCallHandoffNotifications).Append("\n");
            sb.Append("  EscalationRules: ").Append(EscalationRules).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(input as EscalationPolicy);
        }

        /// <summary>
        /// Returns true if EscalationPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of EscalationPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EscalationPolicy input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.NumLoops == input.NumLoops ||
                    (this.NumLoops != null &&
                    this.NumLoops.Equals(input.NumLoops))
                ) && 
                (
                    this.OnCallHandoffNotifications == input.OnCallHandoffNotifications ||
                    (this.OnCallHandoffNotifications != null &&
                    this.OnCallHandoffNotifications.Equals(input.OnCallHandoffNotifications))
                ) && 
                (
                    this.EscalationRules == input.EscalationRules ||
                    this.EscalationRules != null &&
                    input.EscalationRules != null &&
                    this.EscalationRules.SequenceEqual(input.EscalationRules)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    input.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.NumLoops != null)
                    hashCode = hashCode * 59 + this.NumLoops.GetHashCode();
                if (this.OnCallHandoffNotifications != null)
                    hashCode = hashCode * 59 + this.OnCallHandoffNotifications.GetHashCode();
                if (this.EscalationRules != null)
                    hashCode = hashCode * 59 + this.EscalationRules.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
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
