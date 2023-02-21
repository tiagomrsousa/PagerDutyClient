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
    /// The data for a type of relationship where the Incident is related due to Business or Technical Service dependencies.  Both &#x60;dependent_services&#x60; and &#x60;supporting_services&#x60; are returned to signify the dependencies between the Services that the Incident and Related Incident belong to.  Each Service reference returned in the list of supporting and dependent Services has a type of: [business_service_reference, technical_service_reference]. 
    /// </summary>
    [DataContract]
        public partial class RelatedIncidentServiceDependencyRelationship :  IEquatable<RelatedIncidentServiceDependencyRelationship>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedIncidentServiceDependencyRelationship" /> class.
        /// </summary>
        /// <param name="dependentServices">dependentServices.</param>
        /// <param name="supportingServices">supportingServices.</param>
        public RelatedIncidentServiceDependencyRelationship(List<RelatedIncidentServiceDependencyBase> dependentServices = default(List<RelatedIncidentServiceDependencyBase>), List<RelatedIncidentServiceDependencyBase> supportingServices = default(List<RelatedIncidentServiceDependencyBase>))
        {
            this.DependentServices = dependentServices;
            this.SupportingServices = supportingServices;
        }
        
        /// <summary>
        /// Gets or Sets DependentServices
        /// </summary>
        [DataMember(Name="dependent_services", EmitDefaultValue=false)]
        public List<RelatedIncidentServiceDependencyBase> DependentServices { get; set; }

        /// <summary>
        /// Gets or Sets SupportingServices
        /// </summary>
        [DataMember(Name="supporting_services", EmitDefaultValue=false)]
        public List<RelatedIncidentServiceDependencyBase> SupportingServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatedIncidentServiceDependencyRelationship {\n");
            sb.Append("  DependentServices: ").Append(DependentServices).Append("\n");
            sb.Append("  SupportingServices: ").Append(SupportingServices).Append("\n");
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
            return this.Equals(input as RelatedIncidentServiceDependencyRelationship);
        }

        /// <summary>
        /// Returns true if RelatedIncidentServiceDependencyRelationship instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedIncidentServiceDependencyRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedIncidentServiceDependencyRelationship input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DependentServices == input.DependentServices ||
                    this.DependentServices != null &&
                    input.DependentServices != null &&
                    this.DependentServices.SequenceEqual(input.DependentServices)
                ) && 
                (
                    this.SupportingServices == input.SupportingServices ||
                    this.SupportingServices != null &&
                    input.SupportingServices != null &&
                    this.SupportingServices.SequenceEqual(input.SupportingServices)
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
                if (this.DependentServices != null)
                    hashCode = hashCode * 59 + this.DependentServices.GetHashCode();
                if (this.SupportingServices != null)
                    hashCode = hashCode * 59 + this.SupportingServices.GetHashCode();
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
