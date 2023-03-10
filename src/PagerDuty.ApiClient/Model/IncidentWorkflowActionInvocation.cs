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
    /// IncidentWorkflowActionInvocation
    /// </summary>
    [DataContract]
        public partial class IncidentWorkflowActionInvocation :  IEquatable<IncidentWorkflowActionInvocation>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Actioninvocation for value: action_invocation
            /// </summary>
            [EnumMember(Value = "action_invocation")]
            Actioninvocation = 1        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentWorkflowActionInvocation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="actionId">Reference to the Action that was invoked.</param>
        /// <param name="inputs">inputs.</param>
        /// <param name="outputs">outputs.</param>
        public IncidentWorkflowActionInvocation(string id = default(string), TypeEnum? type = default(TypeEnum?), string actionId = default(string), List<AllOfIncidentWorkflowActionInvocationInputsItems> inputs = default(List<AllOfIncidentWorkflowActionInvocationInputsItems>), List<AllOfIncidentWorkflowActionInvocationOutputsItems> outputs = default(List<AllOfIncidentWorkflowActionInvocationOutputsItems>))
        {
            this.Id = id;
            this.Type = type;
            this.ActionId = actionId;
            this.Inputs = inputs;
            this.Outputs = outputs;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Reference to the Action that was invoked
        /// </summary>
        /// <value>Reference to the Action that was invoked</value>
        [DataMember(Name="action_id", EmitDefaultValue=false)]
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<AllOfIncidentWorkflowActionInvocationInputsItems> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<AllOfIncidentWorkflowActionInvocationOutputsItems> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncidentWorkflowActionInvocation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
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
            return this.Equals(input as IncidentWorkflowActionInvocation);
        }

        /// <summary>
        /// Returns true if IncidentWorkflowActionInvocation instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentWorkflowActionInvocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentWorkflowActionInvocation input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ActionId != null)
                    hashCode = hashCode * 59 + this.ActionId.GetHashCode();
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
