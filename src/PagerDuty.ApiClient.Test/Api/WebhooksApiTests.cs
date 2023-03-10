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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Model;

namespace PagerDuty.ApiClient.Test
{
    /// <summary>
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WebhooksApiTests
    {
        private WebhooksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WebhooksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WebhooksApi
            //Assert.IsInstanceOfType(typeof(WebhooksApi), instance, "instance is a WebhooksApi");
        }

        /// <summary>
        /// Test CreateWebhookSubscription
        /// </summary>
        [Test]
        public void CreateWebhookSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //Object body = null;
            //var response = instance.CreateWebhookSubscription(accept, contentType, authorization, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteWebhookSubscription
        /// </summary>
        [Test]
        public void DeleteWebhookSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //instance.DeleteWebhookSubscription(accept, id);
            
        }
        /// <summary>
        /// Test EnableWebhookSubscription
        /// </summary>
        [Test]
        public void EnableWebhookSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //var response = instance.EnableWebhookSubscription(accept, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetWebhookSubscription
        /// </summary>
        [Test]
        public void GetWebhookSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //var response = instance.GetWebhookSubscription(accept, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListWebhookSubscriptions
        /// </summary>
        [Test]
        public void ListWebhookSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //string filterType = null;
            //string filterId = null;
            //var response = instance.ListWebhookSubscriptions(accept, limit, offset, total, filterType, filterId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test TestWebhookSubscription
        /// </summary>
        [Test]
        public void TestWebhookSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //instance.TestWebhookSubscription(accept, id);
            
        }
        /// <summary>
        /// Test UpdateWebhookSubscription
        /// </summary>
        [Test]
        public void UpdateWebhookSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //WebhookSubscriptionUpdate body = null;
            //var response = instance.UpdateWebhookSubscription(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
