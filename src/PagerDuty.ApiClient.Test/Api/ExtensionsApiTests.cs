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
    ///  Class for testing ExtensionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExtensionsApiTests
    {
        private ExtensionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExtensionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExtensionsApi
            //Assert.IsInstanceOfType(typeof(ExtensionsApi), instance, "instance is a ExtensionsApi");
        }

        /// <summary>
        /// Test CreateExtension
        /// </summary>
        [Test]
        public void CreateExtensionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //Object body = null;
            //var response = instance.CreateExtension(accept, contentType, authorization, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteExtension
        /// </summary>
        [Test]
        public void DeleteExtensionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //instance.DeleteExtension(accept, contentType, authorization, id);
            
        }
        /// <summary>
        /// Test EnableExtension
        /// </summary>
        [Test]
        public void EnableExtensionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.EnableExtension(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetExtension
        /// </summary>
        [Test]
        public void GetExtensionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string include = null;
            //var response = instance.GetExtension(accept, contentType, authorization, id, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListExtensions
        /// </summary>
        [Test]
        public void ListExtensionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //string query = null;
            //string extensionObjectId = null;
            //string extensionSchemaId = null;
            //string include = null;
            //var response = instance.ListExtensions(accept, contentType, authorization, limit, offset, total, query, extensionObjectId, extensionSchemaId, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateExtension
        /// </summary>
        [Test]
        public void UpdateExtensionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UpdateExtension(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}