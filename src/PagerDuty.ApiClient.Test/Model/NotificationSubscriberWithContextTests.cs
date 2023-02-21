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
    ///  Class for testing NotificationSubscriberWithContext
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NotificationSubscriberWithContextTests
    {
        // TODO uncomment below to declare an instance variable for NotificationSubscriberWithContext
        //private NotificationSubscriberWithContext instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NotificationSubscriberWithContext
            //instance = new NotificationSubscriberWithContext();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotificationSubscriberWithContext
        /// </summary>
        [Test]
        public void NotificationSubscriberWithContextInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NotificationSubscriberWithContext
            //Assert.IsInstanceOfType<NotificationSubscriberWithContext> (instance, "variable 'instance' is a NotificationSubscriberWithContext");
        }


        /// <summary>
        /// Test the property 'SubscriberId'
        /// </summary>
        [Test]
        public void SubscriberIdTest()
        {
            // TODO unit test for the property 'SubscriberId'
        }
        /// <summary>
        /// Test the property 'SubscriberType'
        /// </summary>
        [Test]
        public void SubscriberTypeTest()
        {
            // TODO unit test for the property 'SubscriberType'
        }
        /// <summary>
        /// Test the property 'HasIndirectSubscription'
        /// </summary>
        [Test]
        public void HasIndirectSubscriptionTest()
        {
            // TODO unit test for the property 'HasIndirectSubscription'
        }
        /// <summary>
        /// Test the property 'SubscribedVia'
        /// </summary>
        [Test]
        public void SubscribedViaTest()
        {
            // TODO unit test for the property 'SubscribedVia'
        }

    }

}
