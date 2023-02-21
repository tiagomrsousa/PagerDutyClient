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
    /// ResolveReason
    /// </summary>
    [DataContract]
        public partial class ResolveReason :  IEquatable<ResolveReason>, IValidatableObject
    {
        /// <summary>
        /// The reason the incident was resolved. The only reason currently supported is merge.
        /// </summary>
        /// <value>The reason the incident was resolved. The only reason currently supported is merge.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Mergeresolvereason for value: merge_resolve_reason
            /// </summary>
            [EnumMember(Value = "merge_resolve_reason")]
            Mergeresolvereason = 1        }
        /// <summary>
        /// The reason the incident was resolved. The only reason currently supported is merge.
        /// </summary>
        /// <value>The reason the incident was resolved. The only reason currently supported is merge.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveReason" /> class.
        /// </summary>
        /// <param name="type">The reason the incident was resolved. The only reason currently supported is merge. (default to TypeEnum.Mergeresolvereason).</param>
        /// <param name="incident">incident.</param>
        public ResolveReason(TypeEnum? type = TypeEnum.Mergeresolvereason, IncidentReference incident = default(IncidentReference))
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.Mergeresolvereason;
            }
            else
            {
                this.Type = type;
            }
            this.Incident = incident;
        }
        

        /// <summary>
        /// Gets or Sets Incident
        /// </summary>
        [DataMember(Name="incident", EmitDefaultValue=false)]
        public IncidentReference Incident { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResolveReason {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Incident: ").Append(Incident).Append("\n");
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
            return this.Equals(input as ResolveReason);
        }

        /// <summary>
        /// Returns true if ResolveReason instances are equal
        /// </summary>
        /// <param name="input">Instance of ResolveReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResolveReason input)
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
                    this.Incident == input.Incident ||
                    (this.Incident != null &&
                    this.Incident.Equals(input.Incident))
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
                if (this.Incident != null)
                    hashCode = hashCode * 59 + this.Incident.GetHashCode();
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
