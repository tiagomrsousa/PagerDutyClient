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

namespace PagerDuty.ApiClient.Test
{
    /// <summary>
    ///  Class for testing ChangeEventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChangeEventsApiTests
    {
        private ChangeEventsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChangeEventsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChangeEventsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChangeEventsApi
            //Assert.IsInstanceOfType(typeof(ChangeEventsApi), instance, "instance is a ChangeEventsApi");
        }

        /// <summary>
        /// Test CreateChangeEvent
        /// </summary>
        [Test]
        public void CreateChangeEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //instance.CreateChangeEvent(accept, contentType, authorization);
            
        }
        /// <summary>
        /// Test GetChangeEvent
        /// </summary>
        [Test]
        public void GetChangeEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.GetChangeEvent(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListChangeEvents
        /// </summary>
        [Test]
        public void ListChangeEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //List<string> teamIds = null;
            //List<string> integrationIds = null;
            //DateTime? since = null;
            //DateTime? until = null;
            //var response = instance.ListChangeEvents(accept, contentType, authorization, limit, offset, total, teamIds, integrationIds, since, until);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListIncidentRelatedChangeEvents
        /// </summary>
        [Test]
        public void ListIncidentRelatedChangeEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //var response = instance.ListIncidentRelatedChangeEvents(id, accept, contentType, authorization, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListServiceChangeEvents
        /// </summary>
        [Test]
        public void ListServiceChangeEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //DateTime? since = null;
            //DateTime? until = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //List<string> teamIds = null;
            //List<string> integrationIds = null;
            //var response = instance.ListServiceChangeEvents(id, accept, contentType, authorization, since, until, limit, offset, total, teamIds, integrationIds);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateChangeEvent
        /// </summary>
        [Test]
        public void UpdateChangeEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UpdateChangeEvent(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}