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
    /// RelatedIncidentServiceDependencyBase
    /// </summary>
    [DataContract]
        public partial class RelatedIncidentServiceDependencyBase :  IEquatable<RelatedIncidentServiceDependencyBase>, IValidatableObject
    {
        /// <summary>
        /// The type of the related Service.
        /// </summary>
        /// <value>The type of the related Service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Businessservicereference for value: business_service_reference
            /// </summary>
            [EnumMember(Value = "business_service_reference")]
            Businessservicereference = 1,
            /// <summary>
            /// Enum Technicalservicereference for value: technical_service_reference
            /// </summary>
            [EnumMember(Value = "technical_service_reference")]
            Technicalservicereference = 2        }
        /// <summary>
        /// The type of the related Service.
        /// </summary>
        /// <value>The type of the related Service.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedIncidentServiceDependencyBase" /> class.
        /// </summary>
        /// <param name="type">The type of the related Service..</param>
        public RelatedIncidentServiceDependencyBase(TypeEnum? type = default(TypeEnum?))
        {
            this.Type = type;
        }
        
        /// <summary>
        /// The ID of the Service referenced.
        /// </summary>
        /// <value>The ID of the Service referenced.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }


        /// <summary>
        /// The API show URL at which the object is accessible.
        /// </summary>
        /// <value>The API show URL at which the object is accessible.</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatedIncidentServiceDependencyBase {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(input as RelatedIncidentServiceDependencyBase);
        }

        /// <summary>
        /// Returns true if RelatedIncidentServiceDependencyBase instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedIncidentServiceDependencyBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedIncidentServiceDependencyBase input)
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
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
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