# PagerDuty.ApiClient.Api.OnCallsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListOnCalls**](OnCallsApi.md#listoncalls) | **GET** /oncalls | List all of the on-calls

<a name="listoncalls"></a>
# **ListOnCalls**
> Object ListOnCalls (string accept, string contentType, string authorization, string timeZone = null, int? limit = null, int? offset = null, bool? total = null, string include = null, List<string> userIds = null, List<string> escalationPolicyIds = null, List<string> scheduleIds = null, DateTime? since = null, DateTime? until = null, bool? earliest = null)

List all of the on-calls

List the on-call entries during a given time range.  An on-call represents a contiguous unit of time for which a User will be on call for a given Escalation Policy and Escalation Rules.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#on-calls) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListOnCallsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnCallsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var include = include_example;  // string | Array of additional details to include. (optional) 
            var userIds = new List<string>(); // List<string> | Filters the results, showing only on-calls for the specified user IDs. (optional) 
            var escalationPolicyIds = new List<string>(); // List<string> | Filters the results, showing only on-calls for the specified escalation policy IDs. (optional) 
            var scheduleIds = new List<string>(); // List<string> | Filters the results, showing only on-calls for the specified schedule IDs. If `null` is provided in the array, it includes permanent on-calls due to direct user escalation targets. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the time range over which you want to search. If an on-call period overlaps with the range, it will be included in the result. Defaults to current time. The search range cannot exceed 3 months. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the time range over which you want to search. If an on-call period overlaps with the range, it will be included in the result. Defaults to current time. The search range cannot exceed 3 months, and the `until` time cannot be before the `since` time. (optional) 
            var earliest = true;  // bool? | This will filter on-calls such that only the earliest on-call for each combination of escalation policy, escalation level, and user is returned. This is useful for determining when the \"next\" on-calls are for a given set of filters. (optional) 

            try
            {
                // List all of the on-calls
                Object result = apiInstance.ListOnCalls(accept, contentType, authorization, timeZone, limit, offset, total, include, userIds, escalationPolicyIds, scheduleIds, since, until, earliest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnCallsApi.ListOnCalls: " + e.Message );
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
 **timeZone** | **string**| Time zone in which dates in the result will be rendered. | [optional] [default to UTC]
 **limit** | **int?**| The number of results per page. | [optional] 
 **offset** | **int?**| Offset to start pagination search results. | [optional] 
 **total** | **bool?**| By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  | [optional] [default to false]
 **include** | **string**| Array of additional details to include. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| Filters the results, showing only on-calls for the specified user IDs. | [optional] 
 **escalationPolicyIds** | [**List&lt;string&gt;**](string.md)| Filters the results, showing only on-calls for the specified escalation policy IDs. | [optional] 
 **scheduleIds** | [**List&lt;string&gt;**](string.md)| Filters the results, showing only on-calls for the specified schedule IDs. If &#x60;null&#x60; is provided in the array, it includes permanent on-calls due to direct user escalation targets. | [optional] 
 **since** | **DateTime?**| The start of the time range over which you want to search. If an on-call period overlaps with the range, it will be included in the result. Defaults to current time. The search range cannot exceed 3 months. | [optional] 
 **until** | **DateTime?**| The end of the time range over which you want to search. If an on-call period overlaps with the range, it will be included in the result. Defaults to current time. The search range cannot exceed 3 months, and the &#x60;until&#x60; time cannot be before the &#x60;since&#x60; time. | [optional] 
 **earliest** | **bool?**| This will filter on-calls such that only the earliest on-call for each combination of escalation policy, escalation level, and user is returned. This is useful for determining when the \&quot;next\&quot; on-calls are for a given set of filters. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
