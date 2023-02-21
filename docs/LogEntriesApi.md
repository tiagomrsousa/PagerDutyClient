# PagerDuty.ApiClient.Api.LogEntriesApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLogEntry**](LogEntriesApi.md#getlogentry) | **GET** /log_entries/{id} | Get a log entry
[**ListLogEntries**](LogEntriesApi.md#listlogentries) | **GET** /log_entries | List log entries
[**UpdateLogEntryChannel**](LogEntriesApi.md#updatelogentrychannel) | **PUT** /log_entries/{id}/channel | Update log entry channel information.

<a name="getlogentry"></a>
# **GetLogEntry**
> Object GetLogEntry (string accept, string contentType, string authorization, string id, string timeZone = null, string include = null)

Get a log entry

Get details for a specific incident log entry. This method provides additional information you can use to get at raw event data.  A log of all the events that happen to an Incident, and these are exposed as Log Entries.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#log-entries) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetLogEntryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LogEntriesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var include = include_example;  // string | Array of additional Models to include in response. (optional) 

            try
            {
                // Get a log entry
                Object result = apiInstance.GetLogEntry(accept, contentType, authorization, id, timeZone, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogEntriesApi.GetLogEntry: " + e.Message );
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
 **id** | **string**| The ID of the resource. | 
 **timeZone** | **string**| Time zone in which dates in the result will be rendered. | [optional] [default to UTC]
 **include** | **string**| Array of additional Models to include in response. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listlogentries"></a>
# **ListLogEntries**
> Object ListLogEntries (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null, string timeZone = null, DateTime? since = null, DateTime? until = null, bool? isOverview = null, string include = null, List<string> teamIds = null)

List log entries

List all of the incident log entries across the entire account.  A log of all the events that happen to an Incident, and these are exposed as Log Entries.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#log-entries) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListLogEntriesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LogEntriesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. (optional) 
            var isOverview = true;  // bool? | If `true`, will return a subset of log entries that show only the most important changes to the incident. (optional)  (default to false)
            var include = include_example;  // string | Array of additional Models to include in response. (optional) 
            var teamIds = new List<string>(); // List<string> | An array of team IDs. Only results related to these teams will be returned. Account must have the `teams` ability to use this parameter. (optional) 

            try
            {
                // List log entries
                Object result = apiInstance.ListLogEntries(accept, contentType, authorization, limit, offset, total, timeZone, since, until, isOverview, include, teamIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogEntriesApi.ListLogEntries: " + e.Message );
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
 **limit** | **int?**| The number of results per page. | [optional] 
 **offset** | **int?**| Offset to start pagination search results. | [optional] 
 **total** | **bool?**| By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  | [optional] [default to false]
 **timeZone** | **string**| Time zone in which dates in the result will be rendered. | [optional] [default to UTC]
 **since** | **DateTime?**| The start of the date range over which you want to search. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. | [optional] 
 **isOverview** | **bool?**| If &#x60;true&#x60;, will return a subset of log entries that show only the most important changes to the incident. | [optional] [default to false]
 **include** | **string**| Array of additional Models to include in response. | [optional] 
 **teamIds** | [**List&lt;string&gt;**](string.md)| An array of team IDs. Only results related to these teams will be returned. Account must have the &#x60;teams&#x60; ability to use this parameter. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatelogentrychannel"></a>
# **UpdateLogEntryChannel**
> void UpdateLogEntryChannel (string accept, string contentType, string authorization, string from, string id, Object body = null)

Update log entry channel information.

Update an existing incident log entry channel.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#log-entries) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateLogEntryChannelExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LogEntriesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The log entry channel to be updated. (optional) 

            try
            {
                // Update log entry channel information.
                apiInstance.UpdateLogEntryChannel(accept, contentType, authorization, from, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogEntriesApi.UpdateLogEntryChannel: " + e.Message );
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
 **from** | **string**| The email address of a valid user associated with the account making the request. | 
 **id** | **string**| The ID of the resource. | 
 **body** | [**Object**](Object.md)| The log entry channel to be updated. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
