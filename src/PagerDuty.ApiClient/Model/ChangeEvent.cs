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
    /// ChangeEvent
    /// </summary>
    [DataContract]
        public partial class ChangeEvent :  IEquatable<ChangeEvent>, IValidatableObject
    {
        /// <summary>
        /// The type of object being created.
        /// </summary>
        /// <value>The type of object being created.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Changeevent for value: change_event
            /// </summary>
            [EnumMember(Value = "change_event")]
            Changeevent = 1        }
        /// <summary>
        /// The type of object being created.
        /// </summary>
        /// <value>The type of object being created.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeEvent" /> class.
        /// </summary>
        /// <param name="integration">integration.</param>
        /// <param name="summary">A brief text summary of the event. Displayed in PagerDuty to provide information about the change. The maximum permitted length of this property is 1024 characters..</param>
        /// <param name="customDetails">Additional details about the change event..</param>
        public ChangeEvent(Object integration = default(Object), string summary = default(string), Object customDetails = default(Object))
        {
            this.Integration = integration;
            this.Summary = summary;
            this.CustomDetails = customDetails;
        }
        
        /// <summary>
        /// The time at which the emitting tool detected or generated the event.
        /// </summary>
        /// <value>The time at which the emitting tool detected or generated the event.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; private set; }


        /// <summary>
        /// An array containing Service objects that this change event is associated with.
        /// </summary>
        /// <value>An array containing Service objects that this change event is associated with.</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<ServiceReference> Services { get; private set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public Object Integration { get; set; }

        /// <summary>
        /// This is the 32 character Integration Key for an Integration on a Service. The same Integration Key can be used for both alert and change events.
        /// </summary>
        /// <value>This is the 32 character Integration Key for an Integration on a Service. The same Integration Key can be used for both alert and change events.</value>
        [DataMember(Name="routing_key", EmitDefaultValue=false)]
        public string RoutingKey { get; private set; }

        /// <summary>
        /// A brief text summary of the event. Displayed in PagerDuty to provide information about the change. The maximum permitted length of this property is 1024 characters.
        /// </summary>
        /// <value>A brief text summary of the event. Displayed in PagerDuty to provide information about the change. The maximum permitted length of this property is 1024 characters.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// The unique name of the location where the Change Event occurred.
        /// </summary>
        /// <value>The unique name of the location where the Change Event occurred.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; private set; }

        /// <summary>
        /// List of links to include.
        /// </summary>
        /// <value>List of links to include.</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Object> Links { get; private set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<Object> Images { get; private set; }

        /// <summary>
        /// Additional details about the change event.
        /// </summary>
        /// <value>Additional details about the change event.</value>
        [DataMember(Name="custom_details", EmitDefaultValue=false)]
        public Object CustomDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeEvent {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  RoutingKey: ").Append(RoutingKey).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  CustomDetails: ").Append(CustomDetails).Append("\n");
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
            return this.Equals(input as ChangeEvent);
        }

        /// <summary>
        /// Returns true if ChangeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && 
                (
                    this.RoutingKey == input.RoutingKey ||
                    (this.RoutingKey != null &&
                    this.RoutingKey.Equals(input.RoutingKey))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.CustomDetails == input.CustomDetails ||
                    (this.CustomDetails != null &&
                    this.CustomDetails.Equals(input.CustomDetails))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                if (this.RoutingKey != null)
                    hashCode = hashCode * 59 + this.RoutingKey.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.CustomDetails != null)
                    hashCode = hashCode * 59 + this.CustomDetails.GetHashCode();
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
