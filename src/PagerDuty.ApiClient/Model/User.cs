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
    /// User
    /// </summary>
    [DataContract]
        public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// The type of object being created.
        /// </summary>
        /// <value>The type of object being created.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1        }
        /// <summary>
        /// The type of object being created.
        /// </summary>
        /// <value>The type of object being created.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The user role. Account must have the &#x60;read_only_users&#x60; ability to set a user as a &#x60;read_only_user&#x60; or a &#x60;read_only_limited_user&#x60;, and must have advanced permissions abilities to set a user as &#x60;observer&#x60; or &#x60;restricted_access&#x60;.
        /// </summary>
        /// <value>The user role. Account must have the &#x60;read_only_users&#x60; ability to set a user as a &#x60;read_only_user&#x60; or a &#x60;read_only_limited_user&#x60;, and must have advanced permissions abilities to set a user as &#x60;observer&#x60; or &#x60;restricted_access&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 1,
            /// <summary>
            /// Enum Limiteduser for value: limited_user
            /// </summary>
            [EnumMember(Value = "limited_user")]
            Limiteduser = 2,
            /// <summary>
            /// Enum Observer for value: observer
            /// </summary>
            [EnumMember(Value = "observer")]
            Observer = 3,
            /// <summary>
            /// Enum Owner for value: owner
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner = 4,
            /// <summary>
            /// Enum Readonlyuser for value: read_only_user
            /// </summary>
            [EnumMember(Value = "read_only_user")]
            Readonlyuser = 5,
            /// <summary>
            /// Enum Restrictedaccess for value: restricted_access
            /// </summary>
            [EnumMember(Value = "restricted_access")]
            Restrictedaccess = 6,
            /// <summary>
            /// Enum Readonlylimiteduser for value: read_only_limited_user
            /// </summary>
            [EnumMember(Value = "read_only_limited_user")]
            Readonlylimiteduser = 7,
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 8        }
        /// <summary>
        /// The user role. Account must have the &#x60;read_only_users&#x60; ability to set a user as a &#x60;read_only_user&#x60; or a &#x60;read_only_limited_user&#x60;, and must have advanced permissions abilities to set a user as &#x60;observer&#x60; or &#x60;restricted_access&#x60;.
        /// </summary>
        /// <value>The user role. Account must have the &#x60;read_only_users&#x60; ability to set a user as a &#x60;read_only_user&#x60; or a &#x60;read_only_limited_user&#x60;, and must have advanced permissions abilities to set a user as &#x60;observer&#x60; or &#x60;restricted_access&#x60;.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="name">The name of the user. (required).</param>
        /// <param name="type">The type of object being created. (required) (default to TypeEnum.User).</param>
        /// <param name="email">The user&#x27;s email address. (required).</param>
        /// <param name="timeZone">The preferred time zone name. If null, the account&#x27;s time zone will be used..</param>
        /// <param name="color">The schedule color..</param>
        /// <param name="role">The user role. Account must have the &#x60;read_only_users&#x60; ability to set a user as a &#x60;read_only_user&#x60; or a &#x60;read_only_limited_user&#x60;, and must have advanced permissions abilities to set a user as &#x60;observer&#x60; or &#x60;restricted_access&#x60;..</param>
        /// <param name="description">The user&#x27;s bio..</param>
        /// <param name="jobTitle">The user&#x27;s title..</param>
        /// <param name="license">The License assigned to the User.</param>
        public User(string name = default(string), TypeEnum type = TypeEnum.User, string email = default(string), string timeZone = default(string), string color = default(string), RoleEnum? role = default(RoleEnum?), string description = default(string), string jobTitle = default(string), Object license = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for User and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for User and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for User and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            this.TimeZone = timeZone;
            this.Color = color;
            this.Role = role;
            this.Description = description;
            this.JobTitle = jobTitle;
            this.License = license;
        }
        
        /// <summary>
        /// The name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// The user&#x27;s email address.
        /// </summary>
        /// <value>The user&#x27;s email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The preferred time zone name. If null, the account&#x27;s time zone will be used.
        /// </summary>
        /// <value>The preferred time zone name. If null, the account&#x27;s time zone will be used.</value>
        [DataMember(Name="time_zone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The schedule color.
        /// </summary>
        /// <value>The schedule color.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }


        /// <summary>
        /// The URL of the user&#x27;s avatar.
        /// </summary>
        /// <value>The URL of the user&#x27;s avatar.</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; private set; }

        /// <summary>
        /// The user&#x27;s bio.
        /// </summary>
        /// <value>The user&#x27;s bio.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// If true, the user has an outstanding invitation.
        /// </summary>
        /// <value>If true, the user has an outstanding invitation.</value>
        [DataMember(Name="invitation_sent", EmitDefaultValue=false)]
        public bool? InvitationSent { get; private set; }

        /// <summary>
        /// The user&#x27;s title.
        /// </summary>
        /// <value>The user&#x27;s title.</value>
        [DataMember(Name="job_title", EmitDefaultValue=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The list of teams to which the user belongs. Account must have the &#x60;teams&#x60; ability to set this.
        /// </summary>
        /// <value>The list of teams to which the user belongs. Account must have the &#x60;teams&#x60; ability to set this.</value>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<TeamReference> Teams { get; private set; }

        /// <summary>
        /// The list of contact methods for the user.
        /// </summary>
        /// <value>The list of contact methods for the user.</value>
        [DataMember(Name="contact_methods", EmitDefaultValue=false)]
        public List<ContactMethodReference> ContactMethods { get; private set; }

        /// <summary>
        /// The list of notification rules for the user.
        /// </summary>
        /// <value>The list of notification rules for the user.</value>
        [DataMember(Name="notification_rules", EmitDefaultValue=false)]
        public List<NotificationRuleReference> NotificationRules { get; private set; }

        /// <summary>
        /// The License assigned to the User
        /// </summary>
        /// <value>The License assigned to the User</value>
        [DataMember(Name="license", EmitDefaultValue=false)]
        public Object License { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InvitationSent: ").Append(InvitationSent).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  ContactMethods: ").Append(ContactMethods).Append("\n");
            sb.Append("  NotificationRules: ").Append(NotificationRules).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InvitationSent == input.InvitationSent ||
                    (this.InvitationSent != null &&
                    this.InvitationSent.Equals(input.InvitationSent))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    input.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
                ) && 
                (
                    this.ContactMethods == input.ContactMethods ||
                    this.ContactMethods != null &&
                    input.ContactMethods != null &&
                    this.ContactMethods.SequenceEqual(input.ContactMethods)
                ) && 
                (
                    this.NotificationRules == input.NotificationRules ||
                    this.NotificationRules != null &&
                    input.NotificationRules != null &&
                    this.NotificationRules.SequenceEqual(input.NotificationRules)
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InvitationSent != null)
                    hashCode = hashCode * 59 + this.InvitationSent.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
                if (this.ContactMethods != null)
                    hashCode = hashCode * 59 + this.ContactMethods.GetHashCode();
                if (this.NotificationRules != null)
                    hashCode = hashCode * 59 + this.NotificationRules.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
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