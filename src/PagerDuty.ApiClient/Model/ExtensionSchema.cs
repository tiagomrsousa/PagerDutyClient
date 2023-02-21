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
    /// ExtensionSchema
    /// </summary>
    [DataContract]
        public partial class ExtensionSchema :  IEquatable<ExtensionSchema>, IValidatableObject
    {
        /// <summary>
        /// Defines SendTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SendTypesEnum
        {
            /// <summary>
            /// Enum Trigger for value: trigger
            /// </summary>
            [EnumMember(Value = "trigger")]
            Trigger = 1,
            /// <summary>
            /// Enum Acknowledge for value: acknowledge
            /// </summary>
            [EnumMember(Value = "acknowledge")]
            Acknowledge = 2,
            /// <summary>
            /// Enum Resolve for value: resolve
            /// </summary>
            [EnumMember(Value = "resolve")]
            Resolve = 3,
            /// <summary>
            /// Enum Delegate for value: delegate
            /// </summary>
            [EnumMember(Value = "delegate")]
            Delegate = 4,
            /// <summary>
            /// Enum Escalate for value: escalate
            /// </summary>
            [EnumMember(Value = "escalate")]
            Escalate = 5,
            /// <summary>
            /// Enum Unacknowledge for value: unacknowledge
            /// </summary>
            [EnumMember(Value = "unacknowledge")]
            Unacknowledge = 6,
            /// <summary>
            /// Enum Assign for value: assign
            /// </summary>
            [EnumMember(Value = "assign")]
            Assign = 7,
            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 8        }
        /// <summary>
        /// The types of PagerDuty incident events that will activate this Extension
        /// </summary>
        /// <value>The types of PagerDuty incident events that will activate this Extension</value>
        [DataMember(Name="send_types", EmitDefaultValue=false)]
        public List<SendTypesEnum> SendTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionSchema" /> class.
        /// </summary>
        /// <param name="description">The long description for the Extension.</param>
        /// <param name="sendTypes">The types of PagerDuty incident events that will activate this Extension.</param>
        public ExtensionSchema(string description = default(string), List<SendTypesEnum> sendTypes = default(List<SendTypesEnum>))
        {
            this.Description = description;
            this.SendTypes = sendTypes;
        }
        
        /// <summary>
        /// A small logo, 18-by-18 pixels.
        /// </summary>
        /// <value>A small logo, 18-by-18 pixels.</value>
        [DataMember(Name="icon_url", EmitDefaultValue=false)]
        public string IconUrl { get; private set; }

        /// <summary>
        /// A large logo, 75 pixels high and no more than 300 pixels wide.
        /// </summary>
        /// <value>A large logo, 75 pixels high and no more than 300 pixels wide.</value>
        [DataMember(Name="logo_url", EmitDefaultValue=false)]
        public string LogoUrl { get; private set; }

        /// <summary>
        /// Human friendly display label
        /// </summary>
        /// <value>Human friendly display label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; private set; }

        /// <summary>
        /// Machine friendly display label
        /// </summary>
        /// <value>Machine friendly display label</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; private set; }

        /// <summary>
        /// The long description for the Extension
        /// </summary>
        /// <value>The long description for the Extension</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A link to the extension&#x27;s support guide
        /// </summary>
        /// <value>A link to the extension&#x27;s support guide</value>
        [DataMember(Name="guide_url", EmitDefaultValue=false)]
        public string GuideUrl { get; private set; }


        /// <summary>
        /// The url that the webhook payload will be sent to for this Extension.
        /// </summary>
        /// <value>The url that the webhook payload will be sent to for this Extension.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionSchema {\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GuideUrl: ").Append(GuideUrl).Append("\n");
            sb.Append("  SendTypes: ").Append(SendTypes).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ExtensionSchema);
        }

        /// <summary>
        /// Returns true if ExtensionSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.GuideUrl == input.GuideUrl ||
                    (this.GuideUrl != null &&
                    this.GuideUrl.Equals(input.GuideUrl))
                ) && 
                (
                    this.SendTypes == input.SendTypes ||
                    this.SendTypes != null &&
                    input.SendTypes != null &&
                    this.SendTypes.SequenceEqual(input.SendTypes)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.LogoUrl != null)
                    hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GuideUrl != null)
                    hashCode = hashCode * 59 + this.GuideUrl.GetHashCode();
                if (this.SendTypes != null)
                    hashCode = hashCode * 59 + this.SendTypes.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
