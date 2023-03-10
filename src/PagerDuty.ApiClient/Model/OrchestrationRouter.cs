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
    /// OrchestrationRouter
    /// </summary>
    [DataContract]
        public partial class OrchestrationRouter :  IEquatable<OrchestrationRouter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestrationRouter" /> class.
        /// </summary>
        /// <param name="orchestrationPath">orchestrationPath.</param>
        public OrchestrationRouter(Object orchestrationPath = default(Object))
        {
            this.OrchestrationPath = orchestrationPath;
        }
        
        /// <summary>
        /// Gets or Sets OrchestrationPath
        /// </summary>
        [DataMember(Name="orchestration_path", EmitDefaultValue=false)]
        public Object OrchestrationPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrchestrationRouter {\n");
            sb.Append("  OrchestrationPath: ").Append(OrchestrationPath).Append("\n");
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
            return this.Equals(input as OrchestrationRouter);
        }

        /// <summary>
        /// Returns true if OrchestrationRouter instances are equal
        /// </summary>
        /// <param name="input">Instance of OrchestrationRouter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrchestrationRouter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrchestrationPath == input.OrchestrationPath ||
                    (this.OrchestrationPath != null &&
                    this.OrchestrationPath.Equals(input.OrchestrationPath))
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
                if (this.OrchestrationPath != null)
                    hashCode = hashCode * 59 + this.OrchestrationPath.GetHashCode();
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
