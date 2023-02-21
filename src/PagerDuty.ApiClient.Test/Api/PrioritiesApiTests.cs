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
    ///  Class for testing PrioritiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PrioritiesApiTests
    {
        private PrioritiesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PrioritiesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PrioritiesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PrioritiesApi
            //Assert.IsInstanceOfType(typeof(PrioritiesApi), instance, "instance is a PrioritiesApi");
        }

        /// <summary>
        /// Test ListPriorities
        /// </summary>
        [Test]
        public void ListPrioritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //var response = instance.ListPriorities(accept, contentType, authorization, limit, offset, total);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
