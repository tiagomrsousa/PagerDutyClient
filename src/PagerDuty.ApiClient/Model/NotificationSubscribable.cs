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
    /// A reference of a subscribable entity.
    /// </summary>
    [DataContract]
        public partial class NotificationSubscribable :  IEquatable<NotificationSubscribable>, IValidatableObject
    {
        /// <summary>
        /// The type of the entity being subscribed to
        /// </summary>
        /// <value>The type of the entity being subscribed to</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SubscribableTypeEnum
        {
            /// <summary>
            /// Enum Incident for value: incident
            /// </summary>
            [EnumMember(Value = "incident")]
            Incident = 1,
            /// <summary>
            /// Enum Businessservice for value: business_service
            /// </summary>
            [EnumMember(Value = "business_service")]
            Businessservice = 2        }
        /// <summary>
        /// The type of the entity being subscribed to
        /// </summary>
        /// <value>The type of the entity being subscribed to</value>
        [DataMember(Name="subscribable_type", EmitDefaultValue=false)]
        public SubscribableTypeEnum? SubscribableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSubscribable" /> class.
        /// </summary>
        /// <param name="subscribableId">The ID of the entity to subscribe to.</param>
        /// <param name="subscribableType">The type of the entity being subscribed to.</param>
        public NotificationSubscribable(string subscribableId = default(string), SubscribableTypeEnum? subscribableType = default(SubscribableTypeEnum?))
        {
            this.SubscribableId = subscribableId;
            this.SubscribableType = subscribableType;
        }
        
        /// <summary>
        /// The ID of the entity to subscribe to
        /// </summary>
        /// <value>The ID of the entity to subscribe to</value>
        [DataMember(Name="subscribable_id", EmitDefaultValue=false)]
        public string SubscribableId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSubscribable {\n");
            sb.Append("  SubscribableId: ").Append(SubscribableId).Append("\n");
            sb.Append("  SubscribableType: ").Append(SubscribableType).Append("\n");
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
            return this.Equals(input as NotificationSubscribable);
        }

        /// <summary>
        /// Returns true if NotificationSubscribable instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationSubscribable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationSubscribable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscribableId == input.SubscribableId ||
                    (this.SubscribableId != null &&
                    this.SubscribableId.Equals(input.SubscribableId))
                ) && 
                (
                    this.SubscribableType == input.SubscribableType ||
                    (this.SubscribableType != null &&
                    this.SubscribableType.Equals(input.SubscribableType))
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
                if (this.SubscribableId != null)
                    hashCode = hashCode * 59 + this.SubscribableId.GetHashCode();
                if (this.SubscribableType != null)
                    hashCode = hashCode * 59 + this.SubscribableType.GetHashCode();
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
