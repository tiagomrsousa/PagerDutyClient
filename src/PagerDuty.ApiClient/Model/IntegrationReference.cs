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
    /// IntegrationReference
    /// </summary>
    [DataContract]
        public partial class IntegrationReference : Reference,  IEquatable<IntegrationReference>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Awscloudwatchinboundintegrationreference for value: aws_cloudwatch_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "aws_cloudwatch_inbound_integration_reference")]
            Awscloudwatchinboundintegrationreference = 1,
            /// <summary>
            /// Enum Cloudkickinboundintegrationreference for value: cloudkick_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "cloudkick_inbound_integration_reference")]
            Cloudkickinboundintegrationreference = 2,
            /// <summary>
            /// Enum Eventtransformerapiinboundintegrationreference for value: event_transformer_api_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "event_transformer_api_inbound_integration_reference")]
            Eventtransformerapiinboundintegrationreference = 3,
            /// <summary>
            /// Enum Genericemailinboundintegrationreference for value: generic_email_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "generic_email_inbound_integration_reference")]
            Genericemailinboundintegrationreference = 4,
            /// <summary>
            /// Enum Genericeventsapiinboundintegrationreference for value: generic_events_api_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "generic_events_api_inbound_integration_reference")]
            Genericeventsapiinboundintegrationreference = 5,
            /// <summary>
            /// Enum Keynoteinboundintegrationreference for value: keynote_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "keynote_inbound_integration_reference")]
            Keynoteinboundintegrationreference = 6,
            /// <summary>
            /// Enum Nagiosinboundintegrationreference for value: nagios_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "nagios_inbound_integration_reference")]
            Nagiosinboundintegrationreference = 7,
            /// <summary>
            /// Enum Pingdominboundintegrationreference for value: pingdom_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "pingdom_inbound_integration_reference")]
            Pingdominboundintegrationreference = 8,
            /// <summary>
            /// Enum Sqlmonitorinboundintegrationreference for value: sql_monitor_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "sql_monitor_inbound_integration_reference")]
            Sqlmonitorinboundintegrationreference = 9,
            /// <summary>
            /// Enum Eventsapiv2inboundintegrationreference for value: events_api_v2_inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "events_api_v2_inbound_integration_reference")]
            Eventsapiv2inboundintegrationreference = 10,
            /// <summary>
            /// Enum Inboundintegrationreference for value: inbound_integration_reference
            /// </summary>
            [EnumMember(Value = "inbound_integration_reference")]
            Inboundintegrationreference = 11        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationReference" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        public IntegrationReference(TypeEnum? type = default(TypeEnum?)) : base()
        {
            this.Type = type;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationReference {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as IntegrationReference);
        }

        /// <summary>
        /// Returns true if IntegrationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationReference input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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