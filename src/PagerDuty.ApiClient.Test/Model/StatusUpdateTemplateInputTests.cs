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
    ///  Class for testing StatusUpdateTemplateInput
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StatusUpdateTemplateInputTests
    {
        // TODO uncomment below to declare an instance variable for StatusUpdateTemplateInput
        //private StatusUpdateTemplateInput instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of StatusUpdateTemplateInput
            //instance = new StatusUpdateTemplateInput();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StatusUpdateTemplateInput
        /// </summary>
        [Test]
        public void StatusUpdateTemplateInputInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" StatusUpdateTemplateInput
            //Assert.IsInstanceOfType<StatusUpdateTemplateInput> (instance, "variable 'instance' is a StatusUpdateTemplateInput");
        }


        /// <summary>
        /// Test the property 'IncidentId'
        /// </summary>
        [Test]
        public void IncidentIdTest()
        {
            // TODO unit test for the property 'IncidentId'
        }
        /// <summary>
        /// Test the property 'StatusUpdate'
        /// </summary>
        [Test]
        public void StatusUpdateTest()
        {
            // TODO unit test for the property 'StatusUpdate'
        }
        /// <summary>
        /// Test the property 'External'
        /// </summary>
        [Test]
        public void ExternalTest()
        {
            // TODO unit test for the property 'External'
        }

    }

}
