/* 
 * PagerDuty API
 *
 * This document describes the PagerDuty REST APIs.  For guides and examples please visit our [Documentation.](https://developer.pagerduty.com/docs/get-started/getting-started/)  Our REST APIs are defined in OpenAPI v3.x. You can view the schema at [github.com/PagerDuty/api-schema](https://github.com/PagerDuty/api-schema).  Note that properties in some schemas have fields not shown by default such as `readOnly`, `format`, and `default`. Hover your cursor over the right column that looks like `optional+1` to see the full list of fields. 
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@pagerduty.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Model;
using PagerDuty.ApiClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace PagerDuty.ApiClient.Test
{
    /// <summary>
    ///  Class for testing IncidentUrgencyRule
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IncidentUrgencyRuleTests
    {
        // TODO uncomment below to declare an instance variable for IncidentUrgencyRule
        //private IncidentUrgencyRule instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IncidentUrgencyRule
            //instance = new IncidentUrgencyRule();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IncidentUrgencyRule
        /// </summary>
        [Test]
        public void IncidentUrgencyRuleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IncidentUrgencyRule
            //Assert.IsInstanceOfType<IncidentUrgencyRule> (instance, "variable 'instance' is a IncidentUrgencyRule");
        }


        /// <summary>
        /// Test the property 'DuringSupportHours'
        /// </summary>
        [Test]
        public void DuringSupportHoursTest()
        {
            // TODO unit test for the property 'DuringSupportHours'
        }
        /// <summary>
        /// Test the property 'OutsideSupportHours'
        /// </summary>
        [Test]
        public void OutsideSupportHoursTest()
        {
            // TODO unit test for the property 'OutsideSupportHours'
        }

    }

}