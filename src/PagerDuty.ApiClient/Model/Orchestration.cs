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
    /// Orchestration
    /// </summary>
    [DataContract]
        public partial class Orchestration :  IEquatable<Orchestration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orchestration" /> class.
        /// </summary>
        /// <param name="name">Name of the Orchestration..</param>
        /// <param name="description">A description of this Orchestration&#x27;s purpose..</param>
        /// <param name="team">Reference to the team that owns the Orchestration. If none is specified, only admins have access..</param>
        public Orchestration(string name = default(string), string description = default(string), Object team = default(Object))
        {
            this.Name = name;
            this.Description = description;
            this.Team = team;
        }
        
        /// <summary>
        /// ID of the Orchestration.
        /// </summary>
        /// <value>ID of the Orchestration.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The API show URL at which the object is accessible
        /// </summary>
        /// <value>The API show URL at which the object is accessible</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; private set; }

        /// <summary>
        /// Name of the Orchestration.
        /// </summary>
        /// <value>Name of the Orchestration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of this Orchestration&#x27;s purpose.
        /// </summary>
        /// <value>A description of this Orchestration&#x27;s purpose.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Reference to the team that owns the Orchestration. If none is specified, only admins have access.
        /// </summary>
        /// <value>Reference to the team that owns the Orchestration. If none is specified, only admins have access.</value>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Object Team { get; set; }

        /// <summary>
        /// Gets or Sets Integrations
        /// </summary>
        [DataMember(Name="integrations", EmitDefaultValue=false)]
        public List<Object> Integrations { get; private set; }

        /// <summary>
        /// Number of different Service Orchestration being routed to
        /// </summary>
        /// <value>Number of different Service Orchestration being routed to</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public int? Routes { get; private set; }

        /// <summary>
        /// The date the Orchestration was created at.
        /// </summary>
        /// <value>The date the Orchestration was created at.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Reference to the user that has created the Orchestration.
        /// </summary>
        /// <value>Reference to the user that has created the Orchestration.</value>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public Object CreatedBy { get; private set; }

        /// <summary>
        /// The date the Orchestration was last updated.
        /// </summary>
        /// <value>The date the Orchestration was last updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Reference to the user that has updated the Orchestration last.
        /// </summary>
        /// <value>Reference to the user that has updated the Orchestration last.</value>
        [DataMember(Name="updated_by", EmitDefaultValue=false)]
        public Object UpdatedBy { get; private set; }

        /// <summary>
        /// Version of the Orchestration.
        /// </summary>
        /// <value>Version of the Orchestration.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Orchestration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Integrations: ").Append(Integrations).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Orchestration);
        }

        /// <summary>
        /// Returns true if Orchestration instances are equal
        /// </summary>
        /// <param name="input">Instance of Orchestration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Orchestration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Integrations == input.Integrations ||
                    this.Integrations != null &&
                    input.Integrations != null &&
                    this.Integrations.SequenceEqual(input.Integrations)
                ) && 
                (
                    this.Routes == input.Routes ||
                    (this.Routes != null &&
                    this.Routes.Equals(input.Routes))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Integrations != null)
                    hashCode = hashCode * 59 + this.Integrations.GetHashCode();
                if (this.Routes != null)
                    hashCode = hashCode * 59 + this.Routes.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
