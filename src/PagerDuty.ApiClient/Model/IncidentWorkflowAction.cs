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
    /// IncidentWorkflowAction
    /// </summary>
    [DataContract]
        public partial class IncidentWorkflowAction :  IEquatable<IncidentWorkflowAction>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Action for value: action
            /// </summary>
            [EnumMember(Value = "action")]
            Action = 1        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The type of Action
        /// </summary>
        /// <value>The type of Action</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ActionTypeEnum
        {
            /// <summary>
            /// Enum Action for value: action
            /// </summary>
            [EnumMember(Value = "action")]
            Action = 1,
            /// <summary>
            /// Enum Trigger for value: trigger
            /// </summary>
            [EnumMember(Value = "trigger")]
            Trigger = 2        }
        /// <summary>
        /// The type of Action
        /// </summary>
        /// <value>The type of Action</value>
        [DataMember(Name="action_type", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        /// <summary>
        /// The type of Trigger this Action is, if action_type is trigger
        /// </summary>
        /// <value>The type of Trigger this Action is, if action_type is trigger</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TriggerTypeEnum
        {
            /// <summary>
            /// Enum Polling for value: polling
            /// </summary>
            [EnumMember(Value = "polling")]
            Polling = 1,
            /// <summary>
            /// Enum Subscription for value: subscription
            /// </summary>
            [EnumMember(Value = "subscription")]
            Subscription = 2,
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 3        }
        /// <summary>
        /// The type of Trigger this Action is, if action_type is trigger
        /// </summary>
        /// <value>The type of Trigger this Action is, if action_type is trigger</value>
        [DataMember(Name="trigger_type", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentWorkflowAction" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="domainName">The Verified Domain of the account that created the action.</param>
        /// <param name="packageName">The Package Name corresponding to the broad category of the Action.</param>
        /// <param name="functionName">The Function Name describing the specific functionality of the Action.</param>
        /// <param name="version">The version of the Action.</param>
        /// <param name="name">The descriptive name of the Action.</param>
        /// <param name="description">A description of the Action.</param>
        /// <param name="actionType">The type of Action.</param>
        /// <param name="triggerType">The type of Trigger this Action is, if action_type is trigger.</param>
        /// <param name="tags">A set of tags to apply to this action..</param>
        /// <param name="searchKeywords">A set of search keywords to apply to this action..</param>
        /// <param name="metadata">JSON-formatted string of metadata pertaining to the Action.</param>
        /// <param name="createdAt">The date-time at which this Action was created.</param>
        /// <param name="createdByUserId">The obfuscated Id of the User who created this Action.</param>
        /// <param name="inputs">Inputs whose values used during Action execution.</param>
        public IncidentWorkflowAction(TypeEnum? type = default(TypeEnum?), string domainName = default(string), string packageName = default(string), string functionName = default(string), decimal? version = default(decimal?), string name = default(string), string description = default(string), ActionTypeEnum? actionType = default(ActionTypeEnum?), TriggerTypeEnum? triggerType = default(TriggerTypeEnum?), List<string> tags = default(List<string>), List<string> searchKeywords = default(List<string>), string metadata = default(string), DateTime? createdAt = default(DateTime?), string createdByUserId = default(string), List<Object> inputs = default(List<Object>))
        {
            this.Type = type;
            this.DomainName = domainName;
            this.PackageName = packageName;
            this.FunctionName = functionName;
            this.Version = version;
            this.Name = name;
            this.Description = description;
            this.ActionType = actionType;
            this.TriggerType = triggerType;
            this.Tags = tags;
            this.SearchKeywords = searchKeywords;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.CreatedByUserId = createdByUserId;
            this.Inputs = inputs;
        }
        

        /// <summary>
        /// The Verified Domain of the account that created the action
        /// </summary>
        /// <value>The Verified Domain of the account that created the action</value>
        [DataMember(Name="domain_name", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The Package Name corresponding to the broad category of the Action
        /// </summary>
        /// <value>The Package Name corresponding to the broad category of the Action</value>
        [DataMember(Name="package_name", EmitDefaultValue=false)]
        public string PackageName { get; set; }

        /// <summary>
        /// The Function Name describing the specific functionality of the Action
        /// </summary>
        /// <value>The Function Name describing the specific functionality of the Action</value>
        [DataMember(Name="function_name", EmitDefaultValue=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The version of the Action
        /// </summary>
        /// <value>The version of the Action</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public decimal? Version { get; set; }

        /// <summary>
        /// The descriptive name of the Action
        /// </summary>
        /// <value>The descriptive name of the Action</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the Action
        /// </summary>
        /// <value>A description of the Action</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// A set of tags to apply to this action.
        /// </summary>
        /// <value>A set of tags to apply to this action.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A set of search keywords to apply to this action.
        /// </summary>
        /// <value>A set of search keywords to apply to this action.</value>
        [DataMember(Name="search_keywords", EmitDefaultValue=false)]
        public List<string> SearchKeywords { get; set; }

        /// <summary>
        /// JSON-formatted string of metadata pertaining to the Action
        /// </summary>
        /// <value>JSON-formatted string of metadata pertaining to the Action</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// The date-time at which this Action was created
        /// </summary>
        /// <value>The date-time at which this Action was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The obfuscated Id of the User who created this Action
        /// </summary>
        /// <value>The obfuscated Id of the User who created this Action</value>
        [DataMember(Name="created_by_user_id", EmitDefaultValue=false)]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// Inputs whose values used during Action execution
        /// </summary>
        /// <value>Inputs whose values used during Action execution</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<Object> Inputs { get; set; }

        /// <summary>
        /// Outputs whose values set during Action execution
        /// </summary>
        /// <value>Outputs whose values set during Action execution</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<Object> Outputs { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncidentWorkflowAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  PackageName: ").Append(PackageName).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(input as IncidentWorkflowAction);
        }

        /// <summary>
        /// Returns true if IncidentWorkflowAction instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentWorkflowAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentWorkflowAction input)
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
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.PackageName == input.PackageName ||
                    (this.PackageName != null &&
                    this.PackageName.Equals(input.PackageName))
                ) && 
                (
                    this.FunctionName == input.FunctionName ||
                    (this.FunctionName != null &&
                    this.FunctionName.Equals(input.FunctionName))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    (this.TriggerType != null &&
                    this.TriggerType.Equals(input.TriggerType))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.SearchKeywords == input.SearchKeywords ||
                    this.SearchKeywords != null &&
                    input.SearchKeywords != null &&
                    this.SearchKeywords.SequenceEqual(input.SearchKeywords)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.PackageName != null)
                    hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.FunctionName != null)
                    hashCode = hashCode * 59 + this.FunctionName.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ActionType != null)
                    hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.TriggerType != null)
                    hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SearchKeywords != null)
                    hashCode = hashCode * 59 + this.SearchKeywords.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
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
