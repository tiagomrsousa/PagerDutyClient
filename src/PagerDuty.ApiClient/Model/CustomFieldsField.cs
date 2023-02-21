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
    /// CustomFieldsField
    /// </summary>
    [DataContract]
        public partial class CustomFieldsField : CustomFieldsEditableField,  IEquatable<CustomFieldsField>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Field for value: field
            /// </summary>
            [EnumMember(Value = "field")]
            Field = 1        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldsField" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="datatype">datatype (required).</param>
        /// <param name="multiValue">multiValue (required).</param>
        /// <param name="fixedOptions">fixedOptions (required).</param>
        public CustomFieldsField(TypeEnum type = default(TypeEnum), CustomFieldsFieldValuepropertiesdatatype datatype = default(CustomFieldsFieldValuepropertiesdatatype), CustomFieldsFieldValuepropertiesmultiValue multiValue = default(CustomFieldsFieldValuepropertiesmultiValue), CustomFieldsFieldValuepropertiesfixedOptions fixedOptions = default(CustomFieldsFieldValuepropertiesfixedOptions), CustomFieldsFieldValuepropertiesdisplayName displayName = default(CustomFieldsFieldValuepropertiesdisplayName), CustomFieldsFieldValuepropertiesdescription description = default(CustomFieldsFieldValuepropertiesdescription)) : base(displayName, description)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CustomFieldsField and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "datatype" is required (not null)
            if (datatype == null)
            {
                throw new InvalidDataException("datatype is a required property for CustomFieldsField and cannot be null");
            }
            else
            {
                this.Datatype = datatype;
            }
            // to ensure "multiValue" is required (not null)
            if (multiValue == null)
            {
                throw new InvalidDataException("multiValue is a required property for CustomFieldsField and cannot be null");
            }
            else
            {
                this.MultiValue = multiValue;
            }
            // to ensure "fixedOptions" is required (not null)
            if (fixedOptions == null)
            {
                throw new InvalidDataException("fixedOptions is a required property for CustomFieldsField and cannot be null");
            }
            else
            {
                this.FixedOptions = fixedOptions;
            }
        }
        
        /// <summary>
        /// The ID of the resource.
        /// </summary>
        /// <value>The ID of the resource.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// A short-form, server-generated string that provides succinct, important information about an object suitable for primary labeling of an entity in a client. In many cases, this will be identical to &#x60;name&#x60;, though it is not intended to be an identifier.
        /// </summary>
        /// <value>A short-form, server-generated string that provides succinct, important information about an object suitable for primary labeling of an entity in a client. In many cases, this will be identical to &#x60;name&#x60;, though it is not intended to be an identifier.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; private set; }

        /// <summary>
        /// The API show URL at which the object is accessible
        /// </summary>
        /// <value>The API show URL at which the object is accessible</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; private set; }


        /// <summary>
        /// The date/time the object was created at.
        /// </summary>
        /// <value>The date/time the object was created at.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// The date/time the object was last updated.
        /// </summary>
        /// <value>The date/time the object was last updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Datatype
        /// </summary>
        [DataMember(Name="datatype", EmitDefaultValue=false)]
        public CustomFieldsFieldValuepropertiesdatatype Datatype { get; set; }

        /// <summary>
        /// Gets or Sets MultiValue
        /// </summary>
        [DataMember(Name="multi_value", EmitDefaultValue=false)]
        public CustomFieldsFieldValuepropertiesmultiValue MultiValue { get; set; }

        /// <summary>
        /// Gets or Sets FixedOptions
        /// </summary>
        [DataMember(Name="fixed_options", EmitDefaultValue=false)]
        public CustomFieldsFieldValuepropertiesfixedOptions FixedOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFieldsField {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Datatype: ").Append(Datatype).Append("\n");
            sb.Append("  MultiValue: ").Append(MultiValue).Append("\n");
            sb.Append("  FixedOptions: ").Append(FixedOptions).Append("\n");
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
            return this.Equals(input as CustomFieldsField);
        }

        /// <summary>
        /// Returns true if CustomFieldsField instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFieldsField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFieldsField input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && base.Equals(input) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && base.Equals(input) && 
                (
                    this.Datatype == input.Datatype ||
                    (this.Datatype != null &&
                    this.Datatype.Equals(input.Datatype))
                ) && base.Equals(input) && 
                (
                    this.MultiValue == input.MultiValue ||
                    (this.MultiValue != null &&
                    this.MultiValue.Equals(input.MultiValue))
                ) && base.Equals(input) && 
                (
                    this.FixedOptions == input.FixedOptions ||
                    (this.FixedOptions != null &&
                    this.FixedOptions.Equals(input.FixedOptions))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Datatype != null)
                    hashCode = hashCode * 59 + this.Datatype.GetHashCode();
                if (this.MultiValue != null)
                    hashCode = hashCode * 59 + this.MultiValue.GetHashCode();
                if (this.FixedOptions != null)
                    hashCode = hashCode * 59 + this.FixedOptions.GetHashCode();
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
