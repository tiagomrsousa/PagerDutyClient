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
    ///  Class for testing RulesetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RulesetsApiTests
    {
        private RulesetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RulesetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RulesetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RulesetsApi
            //Assert.IsInstanceOfType(typeof(RulesetsApi), instance, "instance is a RulesetsApi");
        }

        /// <summary>
        /// Test CreateRuleset
        /// </summary>
        [Test]
        public void CreateRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //Object body = null;
            //var response = instance.CreateRuleset(accept, contentType, authorization, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateRulesetEventRule
        /// </summary>
        [Test]
        public void CreateRulesetEventRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateRulesetEventRule(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteRuleset
        /// </summary>
        [Test]
        public void DeleteRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //instance.DeleteRuleset(accept, contentType, authorization, id);
            
        }
        /// <summary>
        /// Test DeleteRulesetEventRule
        /// </summary>
        [Test]
        public void DeleteRulesetEventRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string ruleId = null;
            //instance.DeleteRulesetEventRule(accept, contentType, authorization, id, ruleId);
            
        }
        /// <summary>
        /// Test GetRuleset
        /// </summary>
        [Test]
        public void GetRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.GetRuleset(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetRulesetEventRule
        /// </summary>
        [Test]
        public void GetRulesetEventRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string ruleId = null;
            //var response = instance.GetRulesetEventRule(accept, contentType, authorization, id, ruleId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListRulesetEventRules
        /// </summary>
        [Test]
        public void ListRulesetEventRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //var response = instance.ListRulesetEventRules(accept, contentType, authorization, id, limit, offset, total);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListRulesets
        /// </summary>
        [Test]
        public void ListRulesetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //var response = instance.ListRulesets(accept, contentType, authorization, limit, offset, total);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateRuleset
        /// </summary>
        [Test]
        public void UpdateRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UpdateRuleset(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateRulesetEventRule
        /// </summary>
        [Test]
        public void UpdateRulesetEventRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string ruleId = null;
            //Object body = null;
            //var response = instance.UpdateRulesetEventRule(accept, contentType, authorization, id, ruleId, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
