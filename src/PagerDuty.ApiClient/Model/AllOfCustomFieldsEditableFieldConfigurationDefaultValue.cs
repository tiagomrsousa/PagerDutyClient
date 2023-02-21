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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = PagerDuty.ApiClient.Client.SwaggerDateConverter;

namespace PagerDuty.ApiClient.Model
{
    /// <summary>
    /// The value to use for this field if none is provided. It must be specified if &#x60;required&#x60; is &#x60;true&#x60;, and may not be specified otherwise.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Datatype")]
        public partial class AllOfCustomFieldsEditableFieldConfigurationDefaultValue :  IEquatable<AllOfCustomFieldsEditableFieldConfigurationDefaultValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfCustomFieldsEditableFieldConfigurationDefaultValue" /> class.
        /// </summary>
        /// <param name="multiValue">If &#x60;true&#x60;, allows the custom field to store a set of values. Must match the Field&#x27;s &#x60;multi_value&#x60; setting. (required).</param>
        public AllOfCustomFieldsEditableFieldConfigurationDefaultValue(bool? multiValue = default(bool?))
        {
            // to ensure "multiValue" is required (not null)
            if (multiValue == null)
            {
                throw new InvalidDataException("multiValue is a required property for AllOfCustomFieldsEditableFieldConfigurationDefaultValue and cannot be null");
            }
            else
            {
                this.MultiValue = multiValue;
            }
        }
        
        /// <summary>
        /// If &#x60;true&#x60;, allows the custom field to store a set of values. Must match the Field&#x27;s &#x60;multi_value&#x60; setting.
        /// </summary>
        /// <value>If &#x60;true&#x60;, allows the custom field to store a set of values. Must match the Field&#x27;s &#x60;multi_value&#x60; setting.</value>
        [DataMember(Name="multi_value", EmitDefaultValue=false)]
        public bool? MultiValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfCustomFieldsEditableFieldConfigurationDefaultValue {\n");
            sb.Append("  MultiValue: ").Append(MultiValue).Append("\n");
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
            return this.Equals(input as AllOfCustomFieldsEditableFieldConfigurationDefaultValue);
        }

        /// <summary>
        /// Returns true if AllOfCustomFieldsEditableFieldConfigurationDefaultValue instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfCustomFieldsEditableFieldConfigurationDefaultValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfCustomFieldsEditableFieldConfigurationDefaultValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MultiValue == input.MultiValue ||
                    (this.MultiValue != null &&
                    this.MultiValue.Equals(input.MultiValue))
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
                if (this.MultiValue != null)
                    hashCode = hashCode * 59 + this.MultiValue.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}