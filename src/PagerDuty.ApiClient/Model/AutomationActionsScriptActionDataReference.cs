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
    /// AutomationActionsScriptActionDataReference
    /// </summary>
    [DataContract]
        public partial class AutomationActionsScriptActionDataReference :  IEquatable<AutomationActionsScriptActionDataReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationActionsScriptActionDataReference" /> class.
        /// </summary>
        /// <param name="script">Body of the script to be executed on the Runner. To execute it, the Runner will write the content of the property into a temp file, make the file executable and execute it. It is assumed that the Runner has a properly configured environment to run the script as an executable file. This behaviour can be altered by providing the &#x60;invocation_command&#x60; property. The maxLength value is specified in bytes. (required).</param>
        /// <param name="invocationCommand">The command to executed a script with. With the body of the script written into a temp file, the Runner will execute the &#x60;&lt;invocation_command&gt; &lt;temp_file&gt;&#x60; command. The maxLength value is specified in bytes..</param>
        public AutomationActionsScriptActionDataReference(string script = default(string), string invocationCommand = default(string))
        {
            // to ensure "script" is required (not null)
            if (script == null)
            {
                throw new InvalidDataException("script is a required property for AutomationActionsScriptActionDataReference and cannot be null");
            }
            else
            {
                this.Script = script;
            }
            this.InvocationCommand = invocationCommand;
        }
        
        /// <summary>
        /// Body of the script to be executed on the Runner. To execute it, the Runner will write the content of the property into a temp file, make the file executable and execute it. It is assumed that the Runner has a properly configured environment to run the script as an executable file. This behaviour can be altered by providing the &#x60;invocation_command&#x60; property. The maxLength value is specified in bytes.
        /// </summary>
        /// <value>Body of the script to be executed on the Runner. To execute it, the Runner will write the content of the property into a temp file, make the file executable and execute it. It is assumed that the Runner has a properly configured environment to run the script as an executable file. This behaviour can be altered by providing the &#x60;invocation_command&#x60; property. The maxLength value is specified in bytes.</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public string Script { get; set; }

        /// <summary>
        /// The command to executed a script with. With the body of the script written into a temp file, the Runner will execute the &#x60;&lt;invocation_command&gt; &lt;temp_file&gt;&#x60; command. The maxLength value is specified in bytes.
        /// </summary>
        /// <value>The command to executed a script with. With the body of the script written into a temp file, the Runner will execute the &#x60;&lt;invocation_command&gt; &lt;temp_file&gt;&#x60; command. The maxLength value is specified in bytes.</value>
        [DataMember(Name="invocation_command", EmitDefaultValue=false)]
        public string InvocationCommand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomationActionsScriptActionDataReference {\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  InvocationCommand: ").Append(InvocationCommand).Append("\n");
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
            return this.Equals(input as AutomationActionsScriptActionDataReference);
        }

        /// <summary>
        /// Returns true if AutomationActionsScriptActionDataReference instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomationActionsScriptActionDataReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomationActionsScriptActionDataReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Script == input.Script ||
                    (this.Script != null &&
                    this.Script.Equals(input.Script))
                ) && 
                (
                    this.InvocationCommand == input.InvocationCommand ||
                    (this.InvocationCommand != null &&
                    this.InvocationCommand.Equals(input.InvocationCommand))
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
                if (this.Script != null)
                    hashCode = hashCode * 59 + this.Script.GetHashCode();
                if (this.InvocationCommand != null)
                    hashCode = hashCode * 59 + this.InvocationCommand.GetHashCode();
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
