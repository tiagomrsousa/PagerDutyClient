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
    /// Priority
    /// </summary>
    [DataContract]
        public partial class UserListItem :  IEquatable<UserListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Priority" /> class.
        /// </summary>
        /// <param name="name">The user-provided short name of the priority..</param>
        /// <param name="description">The user-provided description of the priority..</param>
        public UserListItem(string name = default(string), string email = default(string), string time_zone = default(string))
        {
            this.Name = name;
            this.Email = email;
            this.Time_Zone = time_zone;

        }


        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }
        [DataMember(Name = "time_zone", EmitDefaultValue = false)]
        public string Time_Zone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Time_Zone: ").Append(Time_Zone).Append("\n");

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
            return this.Equals(input as Priority);
        }

        /// <summary>
        /// Returns true if Priority instances are equal
        /// </summary>
        /// <param name="input">Instance of Priority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserListItem input)
        {
            if (input == null)
                return false;

            return true;
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
