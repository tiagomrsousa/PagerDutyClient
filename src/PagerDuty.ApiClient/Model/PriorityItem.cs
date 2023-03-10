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
        public partial class PriorityItem :  IEquatable<PriorityItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Priority" /> class.
        /// </summary>
        /// <param name="name">The user-provided short name of the priority..</param>
        /// <param name="description">The user-provided description of the priority..</param>
        public PriorityItem(string id = default(string), string type = default(string), string summary = default(string), string self = default(string), string html_url = default(string), 
            string account_id = default(string), string color = default(string), DateTime created_at = default(DateTime), string description = default(string), string name = default(string), string order = default(string),
            int schema_version = default(int), DateTime updated_at = default(DateTime))
        {
            this.Id = id;
            this.Type = type;
            this.Summary = summary;
            this.Self = self;
            this.Html_Url = html_url;
            this.Account_Id = account_id;
            this.Color = color;
            this.Created_At = created_at;
            this.Description = description;
            this.Name = name;
            this.Order = order;
            this.Schema_Version = schema_version;
            this.Updated_At = updated_at;
        }
        
        /// <summary>
        /// The user-provided short name of the priority.
        /// </summary>
        /// <value>The user-provided short name of the priority.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public string Order { get;  set; }
        [DataMember(Name = "schema_version", EmitDefaultValue = false)]
        public int Schema_Version { get;  set; }
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime Updated_At { get;  set; }

        /// <summary>
        /// The user-provided description of the priority.
        /// </summary>
        /// <value>The user-provided description of the priority.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get;  set; }
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get;  set; }
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get;  set; }
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get;  set; }
        [DataMember(Name = "html_url", EmitDefaultValue = false)]
        public string Html_Url { get;  set; }
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string Account_Id { get;  set; }
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; private set; }
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime Created_At { get;  set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriorityItem {\n");
            sb.Append("     Name: ").Append(Name).Append("\n");
            sb.Append("     Order: ").Append(Order).Append("\n");
            sb.Append("     Schema_Version: ").Append(Schema_Version).Append("\n");
            sb.Append("     Updated_At: ").Append(Updated_At).Append("\n");
            sb.Append("     Description: ").Append(Description).Append("\n");
            sb.Append("     Id: ").Append(Id).Append("\n");
            sb.Append("     Type: ").Append(Type).Append("\n");
            sb.Append("     Summary: ").Append(Summary).Append("\n");
            sb.Append("     Self: ").Append(Self).Append("\n");
            sb.Append("     Html_Url: ").Append(Html_Url).Append("\n");
            sb.Append("     Account_Id: ").Append(Account_Id).Append("\n");
            sb.Append("     Color: ").Append(Color).Append("\n");
            sb.Append("     Created_At: ").Append(Created_At).Append("\n");
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
            return this.Equals(input as Priority);
        }

        /// <summary>
        /// Returns true if Priority instances are equal
        /// </summary>
        /// <param name="input">Instance of Priority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriorityItem input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
