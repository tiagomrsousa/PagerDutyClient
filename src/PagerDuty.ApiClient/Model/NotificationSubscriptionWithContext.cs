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
    /// An object describing the relationship of a NotificationSubscriber and a NotificationSubscribable with additional context on status of subscription attempt.
    /// </summary>
    [DataContract]
        public partial class NotificationSubscriptionWithContext :  IEquatable<NotificationSubscriptionWithContext>, IValidatableObject
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
        /// The resulting status of the subscription
        /// </summary>
        /// <value>The resulting status of the subscription</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ResultEnum
        {
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,
            /// <summary>
            /// Enum Duplicate for value: duplicate
            /// </summary>
            [EnumMember(Value = "duplicate")]
            Duplicate = 2,
            /// <summary>
            /// Enum Unauthorized for value: unauthorized
            /// </summary>
            [EnumMember(Value = "unauthorized")]
            Unauthorized = 3        }
        /// <summary>
        /// The resulting status of the subscription
        /// </summary>
        /// <value>The resulting status of the subscription</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ResultEnum? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSubscriptionWithContext" /> class.
        /// </summary>
        /// <param name="subscriberId">The ID of the entity being subscribed.</param>
        /// <param name="subscriberType">The type of the entity being subscribed.</param>
        /// <param name="subscribableId">The ID of the entity being subscribed to.</param>
        /// <param name="subscribableType">The type of the entity being subscribed to.</param>
        /// <param name="accountId">The type of the entity being subscribed to.</param>
        /// <param name="result">The resulting status of the subscription.</param>
        public NotificationSubscriptionWithContext(string subscriberId = default(string), SubscriberTypeEnum? subscriberType = default(SubscriberTypeEnum?), string subscribableId = default(string), SubscribableTypeEnum? subscribableType = default(SubscribableTypeEnum?), string accountId = default(string), ResultEnum? result = default(ResultEnum?))
        {
            this.SubscriberId = subscriberId;
            this.SubscriberType = subscriberType;
            this.SubscribableId = subscribableId;
            this.SubscribableType = subscribableType;
            this.AccountId = accountId;
            this.Result = result;
        }
        
        /// <summary>
        /// The ID of the entity being subscribed
        /// </summary>
        /// <value>The ID of the entity being subscribed</value>
        [DataMember(Name="subscriber_id", EmitDefaultValue=false)]
        public string SubscriberId { get; set; }


        /// <summary>
        /// The ID of the entity being subscribed to
        /// </summary>
        /// <value>The ID of the entity being subscribed to</value>
        [DataMember(Name="subscribable_id", EmitDefaultValue=false)]
        public string SubscribableId { get; set; }


        /// <summary>
        /// The type of the entity being subscribed to
        /// </summary>
        /// <value>The type of the entity being subscribed to</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSubscriptionWithContext {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  SubscriberType: ").Append(SubscriberType).Append("\n");
            sb.Append("  SubscribableId: ").Append(SubscribableId).Append("\n");
            sb.Append("  SubscribableType: ").Append(SubscribableType).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as NotificationSubscriptionWithContext);
        }

        /// <summary>
        /// Returns true if NotificationSubscriptionWithContext instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationSubscriptionWithContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationSubscriptionWithContext input)
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
                    this.SubscribableId == input.SubscribableId ||
                    (this.SubscribableId != null &&
                    this.SubscribableId.Equals(input.SubscribableId))
                ) && 
                (
                    this.SubscribableType == input.SubscribableType ||
                    (this.SubscribableType != null &&
                    this.SubscribableType.Equals(input.SubscribableType))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.SubscribableId != null)
                    hashCode = hashCode * 59 + this.SubscribableId.GetHashCode();
                if (this.SubscribableType != null)
                    hashCode = hashCode * 59 + this.SubscribableType.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
