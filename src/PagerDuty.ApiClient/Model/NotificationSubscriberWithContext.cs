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
    /// A reference of a subscriber entity with additional subscription context.
    /// </summary>
    [DataContract]
        public partial class NotificationSubscriberWithContext :  IEquatable<NotificationSubscriberWithContext>, IValidatableObject
    {
        /// <summary>
        /// The type of the entity being subscribed
        /// </summary>
        /// <value>The type of the entity being subscribed</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SubscriberTypeEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,
            /// <summary>
            /// Enum Team for value: team
            /// </summary>
            [EnumMember(Value = "team")]
            Team = 2        }
        /// <summary>
        /// The type of the entity being subscribed
        /// </summary>
        /// <value>The type of the entity being subscribed</value>
        [DataMember(Name="subscriber_type", EmitDefaultValue=false)]
        public SubscriberTypeEnum? SubscriberType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSubscriberWithContext" /> class.
        /// </summary>
        /// <param name="subscriberId">The ID of the entity being subscribed.</param>
        /// <param name="subscriberType">The type of the entity being subscribed.</param>
        /// <param name="hasIndirectSubscription">If this subcriber has an indirect subscription to this incident via another object.</param>
        /// <param name="subscribedVia">subscribedVia.</param>
        public NotificationSubscriberWithContext(string subscriberId = default(string), SubscriberTypeEnum? subscriberType = default(SubscriberTypeEnum?), bool? hasIndirectSubscription = default(bool?), List<Object> subscribedVia = default(List<Object>))
        {
            this.SubscriberId = subscriberId;
            this.SubscriberType = subscriberType;
            this.HasIndirectSubscription = hasIndirectSubscription;
            this.SubscribedVia = subscribedVia;
        }
        
        /// <summary>
        /// The ID of the entity being subscribed
        /// </summary>
        /// <value>The ID of the entity being subscribed</value>
        [DataMember(Name="subscriber_id", EmitDefaultValue=false)]
        public string SubscriberId { get; set; }


        /// <summary>
        /// If this subcriber has an indirect subscription to this incident via another object
        /// </summary>
        /// <value>If this subcriber has an indirect subscription to this incident via another object</value>
        [DataMember(Name="has_indirect_subscription", EmitDefaultValue=false)]
        public bool? HasIndirectSubscription { get; set; }

        /// <summary>
        /// Gets or Sets SubscribedVia
        /// </summary>
        [DataMember(Name="subscribed_via", EmitDefaultValue=false)]
        public List<Object> SubscribedVia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSubscriberWithContext {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  SubscriberType: ").Append(SubscriberType).Append("\n");
            sb.Append("  HasIndirectSubscription: ").Append(HasIndirectSubscription).Append("\n");
            sb.Append("  SubscribedVia: ").Append(SubscribedVia).Append("\n");
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
            return this.Equals(input as NotificationSubscriberWithContext);
        }

        /// <summary>
        /// Returns true if NotificationSubscriberWithContext instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationSubscriberWithContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationSubscriberWithContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriberId == input.SubscriberId ||
                    (this.SubscriberId != null &&
                    this.SubscriberId.Equals(input.SubscriberId))
                ) && 
                (
                    this.SubscriberType == input.SubscriberType ||
                    (this.SubscriberType != null &&
                    this.SubscriberType.Equals(input.SubscriberType))
                ) && 
                (
                    this.HasIndirectSubscription == input.HasIndirectSubscription ||
                    (this.HasIndirectSubscription != null &&
                    this.HasIndirectSubscription.Equals(input.HasIndirectSubscription))
                ) && 
                (
                    this.SubscribedVia == input.SubscribedVia ||
                    this.SubscribedVia != null &&
                    input.SubscribedVia != null &&
                    this.SubscribedVia.SequenceEqual(input.SubscribedVia)
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
                if (this.SubscriberId != null)
                    hashCode = hashCode * 59 + this.SubscriberId.GetHashCode();
                if (this.SubscriberType != null)
                    hashCode = hashCode * 59 + this.SubscriberType.GetHashCode();
                if (this.HasIndirectSubscription != null)
                    hashCode = hashCode * 59 + this.HasIndirectSubscription.GetHashCode();
                if (this.SubscribedVia != null)
                    hashCode = hashCode * 59 + this.SubscribedVia.GetHashCode();
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
