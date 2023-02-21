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
    ///  Class for testing Webhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WebhookTests
    {
        // TODO uncomment below to declare an instance variable for Webhook
        //private Webhook instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Webhook
            //instance = new Webhook();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Webhook
        /// </summary>
        [Test]
        public void WebhookInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Webhook
            //Assert.IsInstanceOfType<Webhook> (instance, "variable 'instance' is a Webhook");
        }


        /// <summary>
        /// Test the property 'EndpointUrl'
        /// </summary>
        [Test]
        public void EndpointUrlTest()
        {
            // TODO unit test for the property 'EndpointUrl'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'WebhookObject'
        /// </summary>
        [Test]
        public void WebhookObjectTest()
        {
            // TODO unit test for the property 'WebhookObject'
        }
        /// <summary>
        /// Test the property 'Config'
        /// </summary>
        [Test]
        public void ConfigTest()
        {
            // TODO unit test for the property 'Config'
        }
        /// <summary>
        /// Test the property 'OutboundIntegration'
        /// </summary>
        [Test]
        public void OutboundIntegrationTest()
        {
            // TODO unit test for the property 'OutboundIntegration'
        }

    }

}
