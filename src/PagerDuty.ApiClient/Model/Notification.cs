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
    /// Notification
    /// </summary>
    [DataContract]
        public partial class Notification :  IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// The type of notification.
        /// </summary>
        /// <value>The type of notification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Smsnotification for value: sms_notification
            /// </summary>
            [EnumMember(Value = "sms_notification")]
            Smsnotification = 1,
            /// <summary>
            /// Enum Emailnotification for value: email_notification
            /// </summary>
            [EnumMember(Value = "email_notification")]
            Emailnotification = 2,
            /// <summary>
            /// Enum Phonenotification for value: phone_notification
            /// </summary>
            [EnumMember(Value = "phone_notification")]
            Phonenotification = 3,
            /// <summary>
            /// Enum Pushnotification for value: push_notification
            /// </summary>
            [EnumMember(Value = "push_notification")]
            Pushnotification = 4        }
        /// <summary>
        /// The type of notification.
        /// </summary>
        /// <value>The type of notification.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="conferenceAddress">The address of the conference bridge.</param>
        /// <param name="status">status.</param>
        /// <param name="">.</param>
        public Notification(UserReference user = default(UserReference), string conferenceAddress = default(string), string status = default(string), string someData  = default(string))
        {
            this.User = user;
            this.ConferenceAddress = conferenceAddress;
            this.Status = status;
            this.SomeData = someData;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }


        /// <summary>
        /// The time at which the notification was sent
        /// </summary>
        /// <value>The time at which the notification was sent</value>
        [DataMember(Name="started_at", EmitDefaultValue=false)]
        public DateTime? StartedAt { get; private set; }

        /// <summary>
        /// The address where the notification was sent. This will be null for notification type &#x60;push_notification&#x60;.
        /// </summary>
        /// <value>The address where the notification was sent. This will be null for notification type &#x60;push_notification&#x60;.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; private set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }

        /// <summary>
        /// The address of the conference bridge
        /// </summary>
        /// <value>The address of the conference bridge</value>
        [DataMember(Name="conferenceAddress", EmitDefaultValue=false)]
        public string ConferenceAddress { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets 
        /// </summary>
        [DataMember(Name= "someData", EmitDefaultValue=false)]
        public string SomeData  { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ConferenceAddress: ").Append(ConferenceAddress).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  : ").Append(SomeData).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
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
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.ConferenceAddress == input.ConferenceAddress ||
                    (this.ConferenceAddress != null &&
                    this.ConferenceAddress.Equals(input.ConferenceAddress))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SomeData == input.SomeData ||
                    (this.SomeData != null &&
                    this.SomeData.Equals(input.SomeData))
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
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ConferenceAddress != null)
                    hashCode = hashCode * 59 + this.ConferenceAddress.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SomeData != null)
                    hashCode = hashCode * 59 + this.SomeData.GetHashCode();
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
