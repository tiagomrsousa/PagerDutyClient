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
    /// Acknowledgement
    /// </summary>
    [DataContract]
        public partial class Acknowledgement :  IEquatable<Acknowledgement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Acknowledgement" /> class.
        /// </summary>
        /// <param name="at">Time at which the acknowledgement was created. (required).</param>
        /// <param name="acknowledger">acknowledger (required).</param>
        public Acknowledgement(DateTime? at = default(DateTime?), AcknowledgerReference acknowledger = default(AcknowledgerReference))
        {
            // to ensure "at" is required (not null)
            if (at == null)
            {
                throw new InvalidDataException("at is a required property for Acknowledgement and cannot be null");
            }
            else
            {
                this.At = at;
            }
            // to ensure "acknowledger" is required (not null)
            if (acknowledger == null)
            {
                throw new InvalidDataException("acknowledger is a required property for Acknowledgement and cannot be null");
            }
            else
            {
                this.Acknowledger = acknowledger;
            }
        }
        
        /// <summary>
        /// Time at which the acknowledgement was created.
        /// </summary>
        /// <value>Time at which the acknowledgement was created.</value>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public DateTime? At { get; set; }

        /// <summary>
        /// Gets or Sets Acknowledger
        /// </summary>
        [DataMember(Name="acknowledger", EmitDefaultValue=false)]
        public AcknowledgerReference Acknowledger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Acknowledgement {\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  Acknowledger: ").Append(Acknowledger).Append("\n");
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
            return this.Equals(input as Acknowledgement);
        }

        /// <summary>
        /// Returns true if Acknowledgement instances are equal
        /// </summary>
        /// <param name="input">Instance of Acknowledgement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Acknowledgement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.Acknowledger == input.Acknowledger ||
                    (this.Acknowledger != null &&
                    this.Acknowledger.Equals(input.Acknowledger))
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
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.Acknowledger != null)
                    hashCode = hashCode * 59 + this.Acknowledger.GetHashCode();
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
