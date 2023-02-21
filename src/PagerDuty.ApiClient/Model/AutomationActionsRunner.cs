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
    /// AutomationActionsRunner
    /// </summary>
    [DataContract]
        public partial class AutomationActionsRunner :  IEquatable<AutomationActionsRunner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationActionsRunner" /> class.
        /// </summary>
        /// <param name="runnerType">runnerType (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="lastSeen">lastSeen.</param>
        /// <param name="status">status (required).</param>
        /// <param name="creationTime">creationTime (required).</param>
        /// <param name="runbookBaseUri">runbookBaseUri.</param>
        /// <param name="privileges">privileges.</param>
        /// <param name="associatedActions">References to at most 3 actions associated with the Runner. Use appropriate endpoints to retrieve the full list of associated actions..</param>
        /// <param name="metadata">Additional metadata.</param>
        public AutomationActionsRunner(AutomationActionsRunnerTypeEnum runnerType = default(AutomationActionsRunnerTypeEnum), string name = default(string), string description = default(string), DateTime? lastSeen = default(DateTime?), AutomationActionsRunnerStatusEnum status = default(AutomationActionsRunnerStatusEnum), DateTime? creationTime = default(DateTime?), string runbookBaseUri = default(string), AutomationActionsUserPermissions privileges = default(AutomationActionsUserPermissions), Object associatedActions = default(Object), Object metadata = default(Object))
        {
            // to ensure "runnerType" is required (not null)
            if (runnerType == null)
            {
                throw new InvalidDataException("runnerType is a required property for AutomationActionsRunner and cannot be null");
            }
            else
            {
                this.RunnerType = runnerType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AutomationActionsRunner and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for AutomationActionsRunner and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "creationTime" is required (not null)
            if (creationTime == null)
            {
                throw new InvalidDataException("creationTime is a required property for AutomationActionsRunner and cannot be null");
            }
            else
            {
                this.CreationTime = creationTime;
            }
            this.Description = description;
            this.LastSeen = lastSeen;
            this.RunbookBaseUri = runbookBaseUri;
            this.Privileges = privileges;
            this.AssociatedActions = associatedActions;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets RunnerType
        /// </summary>
        [DataMember(Name="runner_type", EmitDefaultValue=false)]
        public AutomationActionsRunnerTypeEnum RunnerType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets LastSeen
        /// </summary>
        [DataMember(Name="last_seen", EmitDefaultValue=false)]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public AutomationActionsRunnerStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or Sets RunbookBaseUri
        /// </summary>
        [DataMember(Name="runbook_base_uri", EmitDefaultValue=false)]
        public string RunbookBaseUri { get; set; }

        /// <summary>
        /// The list of teams associated with the Runner
        /// </summary>
        /// <value>The list of teams associated with the Runner</value>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<TeamReference> Teams { get; private set; }

        /// <summary>
        /// Gets or Sets Privileges
        /// </summary>
        [DataMember(Name="privileges", EmitDefaultValue=false)]
        public AutomationActionsUserPermissions Privileges { get; set; }

        /// <summary>
        /// References to at most 3 actions associated with the Runner. Use appropriate endpoints to retrieve the full list of associated actions.
        /// </summary>
        /// <value>References to at most 3 actions associated with the Runner. Use appropriate endpoints to retrieve the full list of associated actions.</value>
        [DataMember(Name="associated_actions", EmitDefaultValue=false)]
        public Object AssociatedActions { get; set; }

        /// <summary>
        /// Additional metadata
        /// </summary>
        /// <value>Additional metadata</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomationActionsRunner {\n");
            sb.Append("  RunnerType: ").Append(RunnerType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  RunbookBaseUri: ").Append(RunbookBaseUri).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Privileges: ").Append(Privileges).Append("\n");
            sb.Append("  AssociatedActions: ").Append(AssociatedActions).Append("\n");
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
            return this.Equals(input as AutomationActionsRunner);
        }

        /// <summary>
        /// Returns true if AutomationActionsRunner instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomationActionsRunner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomationActionsRunner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RunnerType == input.RunnerType ||
                    (this.RunnerType != null &&
                    this.RunnerType.Equals(input.RunnerType))
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
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.RunbookBaseUri == input.RunbookBaseUri ||
                    (this.RunbookBaseUri != null &&
                    this.RunbookBaseUri.Equals(input.RunbookBaseUri))
                ) && 
                (
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    input.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    (this.Privileges != null &&
                    this.Privileges.Equals(input.Privileges))
                ) && 
                (
                    this.AssociatedActions == input.AssociatedActions ||
                    (this.AssociatedActions != null &&
                    this.AssociatedActions.Equals(input.AssociatedActions))
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
                if (this.RunnerType != null)
                    hashCode = hashCode * 59 + this.RunnerType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastSeen != null)
                    hashCode = hashCode * 59 + this.LastSeen.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.RunbookBaseUri != null)
                    hashCode = hashCode * 59 + this.RunbookBaseUri.GetHashCode();
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.AssociatedActions != null)
                    hashCode = hashCode * 59 + this.AssociatedActions.GetHashCode();
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
