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
    /// sidecar - - The runner is backed by an external sidecar that polls for invocations. runbook - - The runner communicates directly with a runbook instance. 
    /// </summary>
    /// <value>sidecar - - The runner is backed by an external sidecar that polls for invocations. runbook - - The runner communicates directly with a runbook instance. </value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum AutomationActionsRunnerTypeEnum
    {
        /// <summary>
        /// Enum Sidecar for value: sidecar
        /// </summary>
        [EnumMember(Value = "sidecar")]
        Sidecar = 1,
        /// <summary>
        /// Enum Runbook for value: runbook
        /// </summary>
        [EnumMember(Value = "runbook")]
        Runbook = 2    }
}