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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string from = null;
            //Object body = null;
            //var response = instance.CreateUser(accept, contentType, authorization, from, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateUserContactMethod
        /// </summary>
        [Test]
        public void CreateUserContactMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateUserContactMethod(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateUserHandoffNotificationRule
        /// </summary>
        [Test]
        public void CreateUserHandoffNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateUserHandoffNotificationRule(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateUserNotificationRule
        /// </summary>
        [Test]
        public void CreateUserNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateUserNotificationRule(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateUserNotificationSubscriptions
        /// </summary>
        [Test]
        public void CreateUserNotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateUserNotificationSubscriptions(accept, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateUserStatusUpdateNotificationRule
        /// </summary>
        [Test]
        public void CreateUserStatusUpdateNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string X_EARLY_ACCESS = null;
            //string id = null;
            //Object body = null;
            //var response = instance.CreateUserStatusUpdateNotificationRule(accept, contentType, authorization, X_EARLY_ACCESS, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //instance.DeleteUser(accept, contentType, authorization, id);
            
        }
        /// <summary>
        /// Test DeleteUserContactMethod
        /// </summary>
        [Test]
        public void DeleteUserContactMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string contactMethodId = null;
            //instance.DeleteUserContactMethod(accept, contentType, authorization, id, contactMethodId);
            
        }
        /// <summary>
        /// Test DeleteUserHandoffNotificationRule
        /// </summary>
        [Test]
        public void DeleteUserHandoffNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string oncallHandoffNotificationRuleId = null;
            //instance.DeleteUserHandoffNotificationRule(accept, contentType, authorization, id, oncallHandoffNotificationRuleId);
            
        }
        /// <summary>
        /// Test DeleteUserNotificationRule
        /// </summary>
        [Test]
        public void DeleteUserNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string notificationRuleId = null;
            //instance.DeleteUserNotificationRule(accept, contentType, authorization, id, notificationRuleId);
            
        }
        /// <summary>
        /// Test DeleteUserSession
        /// </summary>
        [Test]
        public void DeleteUserSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string type = null;
            //string sessionId = null;
            //instance.DeleteUserSession(accept, contentType, authorization, id, type, sessionId);
            
        }
        /// <summary>
        /// Test DeleteUserSessions
        /// </summary>
        [Test]
        public void DeleteUserSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //instance.DeleteUserSessions(accept, contentType, authorization, id);
            
        }
        /// <summary>
        /// Test DeleteUserStatusUpdateNotificationRule
        /// </summary>
        [Test]
        public void DeleteUserStatusUpdateNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string X_EARLY_ACCESS = null;
            //string id = null;
            //string statusUpdateNotificationRuleId = null;
            //instance.DeleteUserStatusUpdateNotificationRule(accept, contentType, authorization, X_EARLY_ACCESS, id, statusUpdateNotificationRuleId);
            
        }
        /// <summary>
        /// Test GetCurrentUser
        /// </summary>
        [Test]
        public void GetCurrentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string include = null;
            //var response = instance.GetCurrentUser(accept, contentType, authorization, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUser
        /// </summary>
        [Test]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string include = null;
            //var response = instance.GetUser(accept, contentType, authorization, id, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserContactMethod
        /// </summary>
        [Test]
        public void GetUserContactMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string contactMethodId = null;
            //var response = instance.GetUserContactMethod(accept, contentType, authorization, id, contactMethodId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserContactMethods
        /// </summary>
        [Test]
        public void GetUserContactMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.GetUserContactMethods(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserHandoffNotifiactionRule
        /// </summary>
        [Test]
        public void GetUserHandoffNotifiactionRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string oncallHandoffNotificationRuleId = null;
            //var response = instance.GetUserHandoffNotifiactionRule(accept, contentType, authorization, id, oncallHandoffNotificationRuleId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserHandoffNotificationRules
        /// </summary>
        [Test]
        public void GetUserHandoffNotificationRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.GetUserHandoffNotificationRules(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserLicense
        /// </summary>
        [Test]
        public void GetUserLicenseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.GetUserLicense(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserNotificationRule
        /// </summary>
        [Test]
        public void GetUserNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string notificationRuleId = null;
            //string include = null;
            //var response = instance.GetUserNotificationRule(accept, contentType, authorization, id, notificationRuleId, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserNotificationRules
        /// </summary>
        [Test]
        public void GetUserNotificationRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string include = null;
            //string urgency = null;
            //var response = instance.GetUserNotificationRules(accept, contentType, authorization, id, include, urgency);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserNotificationSubscriptions
        /// </summary>
        [Test]
        public void GetUserNotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //var response = instance.GetUserNotificationSubscriptions(accept, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserSession
        /// </summary>
        [Test]
        public void GetUserSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string type = null;
            //string sessionId = null;
            //var response = instance.GetUserSession(accept, contentType, authorization, id, type, sessionId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserSessions
        /// </summary>
        [Test]
        public void GetUserSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //var response = instance.GetUserSessions(accept, contentType, authorization, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserStatusUpdateNotificationRule
        /// </summary>
        [Test]
        public void GetUserStatusUpdateNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string X_EARLY_ACCESS = null;
            //string id = null;
            //string statusUpdateNotificationRuleId = null;
            //string include = null;
            //var response = instance.GetUserStatusUpdateNotificationRule(accept, contentType, authorization, X_EARLY_ACCESS, id, statusUpdateNotificationRuleId, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetUserStatusUpdateNotificationRules
        /// </summary>
        [Test]
        public void GetUserStatusUpdateNotificationRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string X_EARLY_ACCESS = null;
            //string include = null;
            //var response = instance.GetUserStatusUpdateNotificationRules(accept, contentType, authorization, id, X_EARLY_ACCESS, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListUsers
        /// </summary>
        [Test]
        public void ListUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string query = null;
            //List<string> teamIds = null;
            //int? limit = null;
            //int? offset = null;
            //bool? total = null;
            //string include = null;
            //var response = instance.ListUsers(accept, contentType, authorization, query, teamIds, limit, offset, total, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ListUsersAuditRecords
        /// </summary>
        [Test]
        public void ListUsersAuditRecordsTest()
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
            //var response = instance.ListUsersAuditRecords(accept, contentType, authorization, id, limit, cursor, since, until);
            //Assert.IsInstanceOf<AuditRecordResponseSchema> (response, "response is AuditRecordResponseSchema");
        }
        /// <summary>
        /// Test UnsubscribeUserNotificationSubscriptions
        /// </summary>
        [Test]
        public void UnsubscribeUserNotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UnsubscribeUserNotificationSubscriptions(accept, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //Object body = null;
            //var response = instance.UpdateUser(accept, contentType, authorization, id, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateUserContactMethod
        /// </summary>
        [Test]
        public void UpdateUserContactMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string contactMethodId = null;
            //Object body = null;
            //var response = instance.UpdateUserContactMethod(accept, contentType, authorization, id, contactMethodId, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateUserHandoffNotification
        /// </summary>
        [Test]
        public void UpdateUserHandoffNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string oncallHandoffNotificationRuleId = null;
            //Object body = null;
            //var response = instance.UpdateUserHandoffNotification(accept, contentType, authorization, id, oncallHandoffNotificationRuleId, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateUserNotificationRule
        /// </summary>
        [Test]
        public void UpdateUserNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string id = null;
            //string notificationRuleId = null;
            //Object body = null;
            //var response = instance.UpdateUserNotificationRule(accept, contentType, authorization, id, notificationRuleId, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateUserStatusUpdateNotificationRule
        /// </summary>
        [Test]
        public void UpdateUserStatusUpdateNotificationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string authorization = null;
            //string X_EARLY_ACCESS = null;
            //string id = null;
            //string statusUpdateNotificationRuleId = null;
            //Object body = null;
            //var response = instance.UpdateUserStatusUpdateNotificationRule(accept, contentType, authorization, X_EARLY_ACCESS, id, statusUpdateNotificationRuleId, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
