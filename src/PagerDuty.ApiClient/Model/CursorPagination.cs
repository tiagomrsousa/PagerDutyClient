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
    /// CursorPagination
    /// </summary>
    [DataContract]
        public partial class CursorPagination :  IEquatable<CursorPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPagination" /> class.
        /// </summary>
        public CursorPagination()
        {
        }
        
        /// <summary>
        /// The minimum of the &#x60;limit&#x60; parameter used in the request or the maximum request size of the API.
        /// </summary>
        /// <value>The minimum of the &#x60;limit&#x60; parameter used in the request or the maximum request size of the API.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; private set; }

        /// <summary>
        /// An opaque string than will deliver the next set of results when provided as the &#x60;cursor&#x60; parameter in a subsequent request.  A &#x60;null&#x60; value for this field indicates that there are no additional results. 
        /// </summary>
        /// <value>An opaque string than will deliver the next set of results when provided as the &#x60;cursor&#x60; parameter in a subsequent request.  A &#x60;null&#x60; value for this field indicates that there are no additional results. </value>
        [DataMember(Name="next_cursor", EmitDefaultValue=false)]
        public string NextCursor { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CursorPagination {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  NextCursor: ").Append(NextCursor).Append("\n");
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
            return this.Equals(input as CursorPagination);
        }

        /// <summary>
        /// Returns true if CursorPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of CursorPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CursorPagination input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.NextCursor == input.NextCursor ||
                    (this.NextCursor != null &&
                    this.NextCursor.Equals(input.NextCursor))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.NextCursor != null)
                    hashCode = hashCode * 59 + this.NextCursor.GetHashCode();
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
