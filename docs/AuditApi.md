# PagerDuty.ApiClient.Api.AuditApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAuditRecords**](AuditApi.md#listauditrecords) | **GET** /audit/records | List audit records

<a name="listauditrecords"></a>
# **ListAuditRecords**
> AuditRecordResponseSchema ListAuditRecords (string accept, string contentType, string authorization, int? limit = null, string cursor = null, DateTime? since = null, DateTime? until = null, string rootResourceTypes = null, string actorType = null, string actorId = null, string methodType = null, string methodTruncatedToken = null, string actions = null)

List audit records

List audit trail records matching provided query params or default criteria.  The returned records are sorted by the `execution_time` from newest to oldest.  See [`Cursor-based pagination`](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for instructions on how to paginate through the result set.  Only admins, account owners, or global API tokens on PagerDuty account [pricing plans](https://www.pagerduty.com/pricing) with the \"Audit Trail\" feature can access this endpoint.  For other role based access to audit records by resource ID, see the resource's API documentation.  For more information see the [Audit API Document](https://developer.pagerduty.com/docs/rest-api-v2/audit-records-api/).  Scoped OAuth requires: `audit_records.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListAuditRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuditApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var limit = 56;  // int? | The minimum of the `limit` parameter used in the request or the maximum request size of the API. (optional) 
            var cursor = cursor_example;  // string | Optional parameter used to request the \"next\" set of results from an API.  The value provided here is most commonly obtained from the `next_cursor` field of the previous request.  When no value is provided, the request starts at the beginning of the result set.  (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. If not specified, defaults to `now() - 24 hours` (past 24 hours) (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. If not specified, defaults to `now()`. May not be more than 31 days after `since`. (optional) 
            var rootResourceTypes = rootResourceTypes_example;  // string | Resource type filter for the root_resource. (optional) 
            var actorType = actorType_example;  // string | Actor type filter. (optional) 
            var actorId = actorId_example;  // string | Actor Id filter. Must be qualified by providing the `actor_type` param. (optional) 
            var methodType = methodType_example;  // string | Method type filter. (optional) 
            var methodTruncatedToken = methodTruncatedToken_example;  // string | Method truncated_token filter. Must be qualified by providing the `method_type` param. (optional) 
            var actions = actions_example;  // string | Action filter (optional) 

            try
            {
                // List audit records
                AuditRecordResponseSchema result = apiInstance.ListAuditRecords(accept, contentType, authorization, limit, cursor, since, until, rootResourceTypes, actorType, actorId, methodType, methodTruncatedToken, actions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.ListAuditRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **contentType** | **string**|  | [default to application/json]
 **authorization** | **string**| The &#x60;Authorization&#x60; header is used as a versioning header. | [default to Token token&#x3D;y_NbAkKc66ryYTWUXYEu]
 **limit** | **int?**| The minimum of the &#x60;limit&#x60; parameter used in the request or the maximum request size of the API. | [optional] 
 **cursor** | **string**| Optional parameter used to request the \&quot;next\&quot; set of results from an API.  The value provided here is most commonly obtained from the &#x60;next_cursor&#x60; field of the previous request.  When no value is provided, the request starts at the beginning of the result set.  | [optional] 
 **since** | **DateTime?**| The start of the date range over which you want to search. If not specified, defaults to &#x60;now() - 24 hours&#x60; (past 24 hours) | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. If not specified, defaults to &#x60;now()&#x60;. May not be more than 31 days after &#x60;since&#x60;. | [optional] 
 **rootResourceTypes** | **string**| Resource type filter for the root_resource. | [optional] 
 **actorType** | **string**| Actor type filter. | [optional] 
 **actorId** | **string**| Actor Id filter. Must be qualified by providing the &#x60;actor_type&#x60; param. | [optional] 
 **methodType** | **string**| Method type filter. | [optional] 
 **methodTruncatedToken** | **string**| Method truncated_token filter. Must be qualified by providing the &#x60;method_type&#x60; param. | [optional] 
 **actions** | **string**| Action filter | [optional] 

### Return type

[**AuditRecordResponseSchema**](AuditRecordResponseSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
