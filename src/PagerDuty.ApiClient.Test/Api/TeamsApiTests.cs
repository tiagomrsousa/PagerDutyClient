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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamsApiTests
    {
        private TeamsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamsApi
            //Assert.IsInstanceOfType(typeof(TeamsApi), instance, "instance is a TeamsApi");
        }

        /// <summary>
        /// Test CreateTeam
        /// </summary>
        [Test]
        public void CreateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //Object body = null;
            //var response = instance.CreateTeam(accept, contentType, authorization, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateTeamNotificationSubscriptions
        /// </summary>
        [Test]
        public void CreateTeamNotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateTeamNotificationSubscriptions(accept, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteTeam
        /// </summary>
        [Test]
        public void DeleteTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string reassignmentTeam = null;
            //instance.DeleteTeam(accept, contentType, authorization, id, reassignmentTeam);
            
        }
        /// <summary>
        /// Test DeleteTeamEscalationPolicy
        /// </summary>
        [Test]
        public void DeleteTeamEscalationPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string escalationPolicyId = null;
            //instance.DeleteTeamEscalationPolicy(accept, contentType, authorization, id, escalationPolicyId);
            
        }
        /// <summary>
        /// Test DeleteTeamUser
        /// </summary>
        [Test]
        public void DeleteTeamUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string userId = null;
            //instance.DeleteTeamUser(accept, contentType, authorization, id, userId);
            
        }
        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Test]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string include = null;
            //var response = instance.GetTeam(accept, contentType, authorization, id, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetTeamNotificationSubscriptions
        /// </summary>
        [Test]
        public void GetTeamNotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //var response = instance.GetTeamNotificationSubscriptions(accept, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListTeamUsers
        /// </summary>
        [Test]
        public void ListTeamUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //string include = null;
            //var response = instance.ListTeamUsers(accept, contentType, authorization, id, limit, offset, total, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListTeams
        /// </summary>
        [Test]
        public void ListTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //string query = null;
            //var response = instance.ListTeams(accept, contentType, authorization, limit, offset, total, query);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListTeamsAuditRecords
        /// </summary>
        [Test]
        public void ListTeamsAuditRecordsTest()
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
            //var response = instance.ListTeamsAuditRecords(accept, contentType, authorization, id, limit, cursor, since, until);
            //Assert.IsInstanceOf<AuditRecordResponseSchema> (response, "response is AuditRecordResponseSchema");
        }
        /// <summary>
        /// Test RemoveTeamNotificationSubscriptions
        /// </summary>
        [Test]
        public void RemoveTeamNotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //Object body = null;
            //var response = instance.RemoveTeamNotificationSubscriptions(accept, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateTeam
        /// </summary>
        [Test]
        public void UpdateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UpdateTeam(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateTeamEscalationPolicy
        /// </summary>
        [Test]
        public void UpdateTeamEscalationPolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string escalationPolicyId = null;
            //instance.UpdateTeamEscalationPolicy(accept, contentType, authorization, id, escalationPolicyId);
            
        }
        /// <summary>
        /// Test UpdateTeamUser
        /// </summary>
        [Test]
        public void UpdateTeamUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string userId = null;
            //Object body = null;
            //instance.UpdateTeamUser(accept, contentType, authorization, id, userId, body);
            
        }
    }

}
