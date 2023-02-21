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
    /// The data for a type of relationship where the Incident is related due to our machine learning algorithm. 
    /// </summary>
    [DataContract]
        public partial class RelatedIncidentMachineLearningRelationship :  IEquatable<RelatedIncidentMachineLearningRelationship>, IValidatableObject
    {
        /// <summary>
        /// The classification for why this Related Incident was grouped into this group. Values can be one of: [similar_contents, prior_feedback], where: similar_contents - The Related Incident was due to similar contents of the Incidents. prior_feedback - The Related Incident was determined to be related, based on User feedback or Incident merge/unmerge actions. 
        /// </summary>
        /// <value>The classification for why this Related Incident was grouped into this group. Values can be one of: [similar_contents, prior_feedback], where: similar_contents - The Related Incident was due to similar contents of the Incidents. prior_feedback - The Related Incident was determined to be related, based on User feedback or Incident merge/unmerge actions. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GroupingClassificationEnum
        {
            /// <summary>
            /// Enum Similarcontents for value: similar_contents
            /// </summary>
            [EnumMember(Value = "similar_contents")]
            Similarcontents = 1,
            /// <summary>
            /// Enum Priorfeedback for value: prior_feedback
            /// </summary>
            [EnumMember(Value = "prior_feedback")]
            Priorfeedback = 2        }
        /// <summary>
        /// The classification for why this Related Incident was grouped into this group. Values can be one of: [similar_contents, prior_feedback], where: similar_contents - The Related Incident was due to similar contents of the Incidents. prior_feedback - The Related Incident was determined to be related, based on User feedback or Incident merge/unmerge actions. 
        /// </summary>
        /// <value>The classification for why this Related Incident was grouped into this group. Values can be one of: [similar_contents, prior_feedback], where: similar_contents - The Related Incident was due to similar contents of the Incidents. prior_feedback - The Related Incident was determined to be related, based on User feedback or Incident merge/unmerge actions. </value>
        [DataMember(Name="grouping_classification", EmitDefaultValue=false)]
        public GroupingClassificationEnum? GroupingClassification { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedIncidentMachineLearningRelationship" /> class.
        /// </summary>
        /// <param name="groupingClassification">The classification for why this Related Incident was grouped into this group. Values can be one of: [similar_contents, prior_feedback], where: similar_contents - The Related Incident was due to similar contents of the Incidents. prior_feedback - The Related Incident was determined to be related, based on User feedback or Incident merge/unmerge actions. .</param>
        /// <param name="userFeedback">The feedback provided from Users to influence the machine learning algorithm for future Related Incidents..</param>
        public RelatedIncidentMachineLearningRelationship(GroupingClassificationEnum? groupingClassification = default(GroupingClassificationEnum?), Object userFeedback = default(Object))
        {
            this.GroupingClassification = groupingClassification;
            this.UserFeedback = userFeedback;
        }
        

        /// <summary>
        /// The feedback provided from Users to influence the machine learning algorithm for future Related Incidents.
        /// </summary>
        /// <value>The feedback provided from Users to influence the machine learning algorithm for future Related Incidents.</value>
        [DataMember(Name="user_feedback", EmitDefaultValue=false)]
        public Object UserFeedback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatedIncidentMachineLearningRelationship {\n");
            sb.Append("  GroupingClassification: ").Append(GroupingClassification).Append("\n");
            sb.Append("  UserFeedback: ").Append(UserFeedback).Append("\n");
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
            return this.Equals(input as RelatedIncidentMachineLearningRelationship);
        }

        /// <summary>
        /// Returns true if RelatedIncidentMachineLearningRelationship instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedIncidentMachineLearningRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedIncidentMachineLearningRelationship input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupingClassification == input.GroupingClassification ||
                    (this.GroupingClassification != null &&
                    this.GroupingClassification.Equals(input.GroupingClassification))
                ) && 
                (
                    this.UserFeedback == input.UserFeedback ||
                    (this.UserFeedback != null &&
                    this.UserFeedback.Equals(input.UserFeedback))
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
                if (this.GroupingClassification != null)
                    hashCode = hashCode * 59 + this.GroupingClassification.GetHashCode();
                if (this.UserFeedback != null)
                    hashCode = hashCode * 59 + this.UserFeedback.GetHashCode();
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
