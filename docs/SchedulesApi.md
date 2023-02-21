# PagerDuty.ApiClient.Api.SchedulesApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSchedule**](SchedulesApi.md#createschedule) | **POST** /schedules | Create a schedule
[**CreateScheduleOverride**](SchedulesApi.md#createscheduleoverride) | **POST** /schedules/{id}/overrides | Create one or more overrides
[**CreateSchedulePreview**](SchedulesApi.md#createschedulepreview) | **POST** /schedules/preview | Preview a schedule
[**DeleteSchedule**](SchedulesApi.md#deleteschedule) | **DELETE** /schedules/{id} | Delete a schedule
[**DeleteScheduleOverride**](SchedulesApi.md#deletescheduleoverride) | **DELETE** /schedules/{id}/overrides/{override_id} | Delete an override
[**GetSchedule**](SchedulesApi.md#getschedule) | **GET** /schedules/{id} | Get a schedule
[**ListScheduleOverrides**](SchedulesApi.md#listscheduleoverrides) | **GET** /schedules/{id}/overrides | List overrides
[**ListScheduleUsers**](SchedulesApi.md#listscheduleusers) | **GET** /schedules/{id}/users | List users on call.
[**ListSchedules**](SchedulesApi.md#listschedules) | **GET** /schedules | List schedules
[**ListSchedulesAuditRecords**](SchedulesApi.md#listschedulesauditrecords) | **GET** /schedules/{id}/audit/records | List audit records for a schedule
[**UpdateSchedule**](SchedulesApi.md#updateschedule) | **PUT** /schedules/{id} | Update a schedule

<a name="createschedule"></a>
# **CreateSchedule**
> Object CreateSchedule (string accept, string contentType, string authorization, Object body = null, bool? overflow = null)

Create a schedule

Create a new on-call schedule.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules)  Scoped OAuth requires: `event_rules.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateScheduleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var body = new Object(); // Object | The schedule to be created. (optional) 
            var overflow = true;  // bool? | Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter `overflow=true` is passed. This parameter defaults to false. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from `2011-06-01T10:00:00Z` to `2011-06-01T14:00:00Z`:   - If you don't pass the `overflow=true` parameter, you will get one schedule entry returned with a start of `2011-06-01T10:00:00Z` and end of `2011-06-01T14:00:00Z`. - If you do pass the `overflow=true` parameter, you will get one schedule entry returned with a start of `2011-06-01T00:00:00Z` and end of `2011-06-02T00:00:00Z`.  (optional)  (default to false)

            try
            {
                // Create a schedule
                Object result = apiInstance.CreateSchedule(accept, contentType, authorization, body, overflow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.CreateSchedule: " + e.Message );
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
 **body** | [**Object**](Object.md)| The schedule to be created. | [optional] 
 **overflow** | **bool?**| Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter &#x60;overflow&#x3D;true&#x60; is passed. This parameter defaults to false. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from &#x60;2011-06-01T10:00:00Z&#x60; to &#x60;2011-06-01T14:00:00Z&#x60;:   - If you don&#x27;t pass the &#x60;overflow&#x3D;true&#x60; parameter, you will get one schedule entry returned with a start of &#x60;2011-06-01T10:00:00Z&#x60; and end of &#x60;2011-06-01T14:00:00Z&#x60;. - If you do pass the &#x60;overflow&#x3D;true&#x60; parameter, you will get one schedule entry returned with a start of &#x60;2011-06-01T00:00:00Z&#x60; and end of &#x60;2011-06-02T00:00:00Z&#x60;.  | [optional] [default to false]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createscheduleoverride"></a>
# **CreateScheduleOverride**
> List<Object> CreateScheduleOverride (Object body, string accept, string contentType, string authorization, string id)

Create one or more overrides

Create one or more overrides, each for a specific user covering a specified time range. If you create an override on top of an existing override, the last created override will have priority.  A Schedule determines the time periods that users are On-Call.  Note: An older implementation of this endpoint only supported creating a single ocverride per request. That functionality is still supported, but deprecated and may be removed in the future.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateScheduleOverrideExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var body = new Object(); // Object | The overrides to be created
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Create one or more overrides
                List&lt;Object&gt; result = apiInstance.CreateScheduleOverride(body, accept, contentType, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.CreateScheduleOverride: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)| The overrides to be created | 
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **contentType** | **string**|  | [default to application/json]
 **authorization** | **string**| The &#x60;Authorization&#x60; header is used as a versioning header. | [default to Token token&#x3D;y_NbAkKc66ryYTWUXYEu]
 **id** | **string**| The ID of the resource. | 

### Return type

**List<Object>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createschedulepreview"></a>
# **CreateSchedulePreview**
> Object CreateSchedulePreview (string accept, string contentType, string authorization, Object body = null, DateTime? since = null, DateTime? until = null, bool? overflow = null)

Preview a schedule

Preview what an on-call schedule would look like without saving it.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateSchedulePreviewExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var body = new Object(); // Object | The schedule to be previewed. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. (optional) 
            var overflow = true;  // bool? | Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter `overflow=true` is passed. This parameter defaults to false. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from `2011-06-01T10:00:00Z` to `2011-06-01T14:00:00Z`:   - If you don't pass the `overflow=true` parameter, you will get one schedule entry returned with a start of `2011-06-01T10:00:00Z` and end of `2011-06-01T14:00:00Z`. - If you do pass the `overflow=true` parameter, you will get one schedule entry returned with a start of `2011-06-01T00:00:00Z` and end of `2011-06-02T00:00:00Z`.  (optional)  (default to false)

            try
            {
                // Preview a schedule
                Object result = apiInstance.CreateSchedulePreview(accept, contentType, authorization, body, since, until, overflow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.CreateSchedulePreview: " + e.Message );
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
 **body** | [**Object**](Object.md)| The schedule to be previewed. | [optional] 
 **since** | **DateTime?**| The start of the date range over which you want to search. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. | [optional] 
 **overflow** | **bool?**| Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter &#x60;overflow&#x3D;true&#x60; is passed. This parameter defaults to false. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from &#x60;2011-06-01T10:00:00Z&#x60; to &#x60;2011-06-01T14:00:00Z&#x60;:   - If you don&#x27;t pass the &#x60;overflow&#x3D;true&#x60; parameter, you will get one schedule entry returned with a start of &#x60;2011-06-01T10:00:00Z&#x60; and end of &#x60;2011-06-01T14:00:00Z&#x60;. - If you do pass the &#x60;overflow&#x3D;true&#x60; parameter, you will get one schedule entry returned with a start of &#x60;2011-06-01T00:00:00Z&#x60; and end of &#x60;2011-06-02T00:00:00Z&#x60;.  | [optional] [default to false]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteschedule"></a>
# **DeleteSchedule**
> void DeleteSchedule (string accept, string contentType, string authorization, string id)

Delete a schedule

Delete an on-call schedule.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteScheduleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Delete a schedule
                apiInstance.DeleteSchedule(accept, contentType, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.DeleteSchedule: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletescheduleoverride"></a>
# **DeleteScheduleOverride**
> void DeleteScheduleOverride (string accept, string contentType, string authorization, string id, string overrideId)

Delete an override

Remove an override.  You cannot remove a past override.  If the override start time is before the current time, but the end time is after the current time, the override will be truncated to the current time.  If the override is truncated, the status code will be 200 OK, as opposed to a 204 No Content for a successful delete.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteScheduleOverrideExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var overrideId = overrideId_example;  // string | The override ID on the schedule.

            try
            {
                // Delete an override
                apiInstance.DeleteScheduleOverride(accept, contentType, authorization, id, overrideId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.DeleteScheduleOverride: " + e.Message );
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
 **overrideId** | **string**| The override ID on the schedule. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getschedule"></a>
# **GetSchedule**
> Object GetSchedule (string accept, string contentType, string authorization, string id, string timeZone = null, DateTime? since = null, DateTime? until = null)

Get a schedule

Show detailed information about a schedule, including entries for each layer and sub-schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetScheduleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to show schedule entries. Defaults to 2 weeks before until if an until is given. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to show schedule entries. Defaults to 2 weeks after since if a since is given. (optional) 

            try
            {
                // Get a schedule
                Object result = apiInstance.GetSchedule(accept, contentType, authorization, id, timeZone, since, until);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.GetSchedule: " + e.Message );
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
 **since** | **DateTime?**| The start of the date range over which you want to show schedule entries. Defaults to 2 weeks before until if an until is given. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to show schedule entries. Defaults to 2 weeks after since if a since is given. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listscheduleoverrides"></a>
# **ListScheduleOverrides**
> Object ListScheduleOverrides (string accept, string contentType, string authorization, string id, DateTime? since, DateTime? until, bool? editable = null, bool? overflow = null)

List overrides

List overrides for a given time range.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListScheduleOverridesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search.
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search.
            var editable = true;  // bool? | When this parameter is present, only editable overrides will be returned. The result will only include the id of the override if this parameter is present. Only future overrides are editable. (optional) 
            var overflow = true;  // bool? | Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter overflow=true is passed. This parameter defaults to false. (optional) 

            try
            {
                // List overrides
                Object result = apiInstance.ListScheduleOverrides(accept, contentType, authorization, id, since, until, editable, overflow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ListScheduleOverrides: " + e.Message );
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
 **since** | **DateTime?**| The start of the date range over which you want to search. | 
 **until** | **DateTime?**| The end of the date range over which you want to search. | 
 **editable** | **bool?**| When this parameter is present, only editable overrides will be returned. The result will only include the id of the override if this parameter is present. Only future overrides are editable. | [optional] 
 **overflow** | **bool?**| Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter overflow&#x3D;true is passed. This parameter defaults to false. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listscheduleusers"></a>
# **ListScheduleUsers**
> Object ListScheduleUsers (string accept, string contentType, string authorization, string id, DateTime? since = null, DateTime? until = null)

List users on call.

List all of the users on call in a given schedule for a given time range.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListScheduleUsersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. (optional) 

            try
            {
                // List users on call.
                Object result = apiInstance.ListScheduleUsers(accept, contentType, authorization, id, since, until);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ListScheduleUsers: " + e.Message );
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
 **since** | **DateTime?**| The start of the date range over which you want to search. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listschedules"></a>
# **ListSchedules**
> Object ListSchedules (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null, string query = null, string include = null)

List schedules

List the on-call schedules.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListSchedulesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var query = query_example;  // string | Filters the result, showing only the records whose name matches the query. (optional) 
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // List schedules
                Object result = apiInstance.ListSchedules(accept, contentType, authorization, limit, offset, total, query, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ListSchedules: " + e.Message );
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
 **query** | **string**| Filters the result, showing only the records whose name matches the query. | [optional] 
 **include** | **string**| Array of additional details to include. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listschedulesauditrecords"></a>
# **ListSchedulesAuditRecords**
> AuditRecordResponseSchema ListSchedulesAuditRecords (string accept, string contentType, string authorization, string id, int? limit = null, string cursor = null, DateTime? since = null, DateTime? until = null)

List audit records for a schedule

The returned records are sorted by the `execution_time` from newest to oldest.  See [`Cursor-based pagination`](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for instructions on how to paginate through the result set.  For more information see the [Audit API Document](https://developer.pagerduty.com/docs/rest-api-v2/audit-records-api/).  Scoped OAuth requires: `audit_records.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListSchedulesAuditRecordsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var limit = 56;  // int? | The minimum of the `limit` parameter used in the request or the maximum request size of the API. (optional) 
            var cursor = cursor_example;  // string | Optional parameter used to request the \"next\" set of results from an API.  The value provided here is most commonly obtained from the `next_cursor` field of the previous request.  When no value is provided, the request starts at the beginning of the result set.  (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. If not specified, defaults to `now() - 24 hours` (past 24 hours) (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. If not specified, defaults to `now()`. May not be more than 31 days after `since`. (optional) 

            try
            {
                // List audit records for a schedule
                AuditRecordResponseSchema result = apiInstance.ListSchedulesAuditRecords(accept, contentType, authorization, id, limit, cursor, since, until);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.ListSchedulesAuditRecords: " + e.Message );
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
 **limit** | **int?**| The minimum of the &#x60;limit&#x60; parameter used in the request or the maximum request size of the API. | [optional] 
 **cursor** | **string**| Optional parameter used to request the \&quot;next\&quot; set of results from an API.  The value provided here is most commonly obtained from the &#x60;next_cursor&#x60; field of the previous request.  When no value is provided, the request starts at the beginning of the result set.  | [optional] 
 **since** | **DateTime?**| The start of the date range over which you want to search. If not specified, defaults to &#x60;now() - 24 hours&#x60; (past 24 hours) | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. If not specified, defaults to &#x60;now()&#x60;. May not be more than 31 days after &#x60;since&#x60;. | [optional] 

### Return type

[**AuditRecordResponseSchema**](AuditRecordResponseSchema.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateschedule"></a>
# **UpdateSchedule**
> Object UpdateSchedule (string accept, string contentType, string authorization, string id, Object body = null, bool? overflow = null)

Update a schedule

Update an existing on-call schedule.  A Schedule determines the time periods that users are On-Call.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#schedules) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateScheduleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SchedulesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The schedule to be updated. (optional) 
            var overflow = true;  // bool? | Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter `overflow=true` is passed. This parameter defaults to false. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from `2011-06-01T10:00:00Z` to `2011-06-01T14:00:00Z`:   - If you don't pass the `overflow=true` parameter, you will get one schedule entry returned with a start of `2011-06-01T10:00:00Z` and end of `2011-06-01T14:00:00Z`. - If you do pass the `overflow=true` parameter, you will get one schedule entry returned with a start of `2011-06-01T00:00:00Z` and end of `2011-06-02T00:00:00Z`.  (optional)  (default to false)

            try
            {
                // Update a schedule
                Object result = apiInstance.UpdateSchedule(accept, contentType, authorization, id, body, overflow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulesApi.UpdateSchedule: " + e.Message );
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
 **body** | [**Object**](Object.md)| The schedule to be updated. | [optional] 
 **overflow** | **bool?**| Any on-call schedule entries that pass the date range bounds will be truncated at the bounds, unless the parameter &#x60;overflow&#x3D;true&#x60; is passed. This parameter defaults to false. For instance, if your schedule is a rotation that changes daily at midnight UTC, and your date range is from &#x60;2011-06-01T10:00:00Z&#x60; to &#x60;2011-06-01T14:00:00Z&#x60;:   - If you don&#x27;t pass the &#x60;overflow&#x3D;true&#x60; parameter, you will get one schedule entry returned with a start of &#x60;2011-06-01T10:00:00Z&#x60; and end of &#x60;2011-06-01T14:00:00Z&#x60;. - If you do pass the &#x60;overflow&#x3D;true&#x60; parameter, you will get one schedule entry returned with a start of &#x60;2011-06-01T00:00:00Z&#x60; and end of &#x60;2011-06-02T00:00:00Z&#x60;.  | [optional] [default to false]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
