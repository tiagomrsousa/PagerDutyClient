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
    ///  Class for testing LogEntryReference
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LogEntryReferenceTests
    {
        // TODO uncomment below to declare an instance variable for LogEntryReference
        //private LogEntryReference instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LogEntryReference
            //instance = new LogEntryReference();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LogEntryReference
        /// </summary>
        [Test]
        public void LogEntryReferenceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LogEntryReference
            //Assert.IsInstanceOfType<LogEntryReference> (instance, "variable 'instance' is a LogEntryReference");
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}
