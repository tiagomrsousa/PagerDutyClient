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
    /// ServiceEventRule
    /// </summary>
    [DataContract]
        public partial class ServiceEventRule :  IEquatable<ServiceEventRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceEventRule" /> class.
        /// </summary>
        /// <param name="position">Position/index of the Event Rule on the Service.  Starting from position 0 (the first rule), rules are evaluated one-by-one until a matching Event Rule is found or the end of the list is reached..</param>
        /// <param name="actions">actions.</param>
        public ServiceEventRule(int? position = default(int?), EventRuleActionsCommon actions = default(EventRuleActionsCommon))
        {
            this.Position = position;
            this.Actions = actions;
        }
        
        /// <summary>
        /// Position/index of the Event Rule on the Service.  Starting from position 0 (the first rule), rules are evaluated one-by-one until a matching Event Rule is found or the end of the list is reached.
        /// </summary>
        /// <value>Position/index of the Event Rule on the Service.  Starting from position 0 (the first rule), rules are evaluated one-by-one until a matching Event Rule is found or the end of the list is reached.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public EventRuleActionsCommon Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceEventRule {\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as ServiceEventRule);
        }

        /// <summary>
        /// Returns true if ServiceEventRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceEventRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceEventRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Actions == input.Actions ||
                    (this.Actions != null &&
                    this.Actions.Equals(input.Actions))
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
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
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
