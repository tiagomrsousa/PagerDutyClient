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
    ///  Class for testing EscalationPoliciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EscalationPoliciesApiTests
    {
        private EscalationPoliciesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EscalationPoliciesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EscalationPoliciesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EscalationPoliciesApi
            //Assert.IsInstanceOfType(typeof(EscalationPoliciesApi), instance, "instance is a EscalationPoliciesApi");
        }

        /// <summary>
        /// Test CreateEscalationPolicy
        /// </summary>
        [Test]
        public void CreateEscalationPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //Object body = null;
            //string from = null;
            //var response = instance.CreateEscalationPolicy(accept, contentType, authorization, body, from);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteEscalationPolicy
        /// </summary>
        [Test]
        public void DeleteEscalationPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //instance.DeleteEscalationPolicy(accept, contentType, authorization, id);
            
        }
        /// <summary>
        /// Test GetEscalationPolicy
        /// </summary>
        [Test]
        public void GetEscalationPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string include = null;
            //var response = instance.GetEscalationPolicy(accept, contentType, authorization, id, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListEscalationPolicies
        /// </summary>
        [Test]
        public void ListEscalationPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //string query = null;
            //List<string> userIds = null;
            //List<string> teamIds = null;
            //string include = null;
            //string sortBy = null;
            //var response = instance.ListEscalationPolicies(accept, contentType, authorization, limit, offset, total, query, userIds, teamIds, include, sortBy);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListEscalationPolicyAuditRecords
        /// </summary>
        [Test]
        public void ListEscalationPolicyAuditRecordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //int? limit = null;
            //string cursor = null;
            //DateTime? since = null;
            //DateTime? until = null;
            //var response = instance.ListEscalationPolicyAuditRecords(accept, contentType, authorization, id, limit, cursor, since, until);
            //Assert.IsInstanceOf<AuditRecordResponseSchema> (response, "response is AuditRecordResponseSchema");
        }
        /// <summary>
        /// Test UpdateEscalationPolicy
        /// </summary>
        [Test]
        public void UpdateEscalationPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UpdateEscalationPolicy(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
