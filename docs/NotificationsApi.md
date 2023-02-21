# PagerDuty.ApiClient.Api.NotificationsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListNotifications**](NotificationsApi.md#listnotifications) | **GET** /notifications | List notifications

<a name="listnotifications"></a>
# **ListNotifications**
> Object ListNotifications (string accept, string contentType, string authorization, DateTime? since, DateTime? until, int? limit = null, int? offset = null, bool? total = null, string timeZone = null, string filter = null, string include = null)

List notifications

List notifications for a given time range, optionally filtered by type (sms_notification, email_notification, phone_notification, or push_notification).  A Notification is created when an Incident is triggered or escalated.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#notifications) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListNotificationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotificationsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. The time element is optional.
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. This should be in the same format as since. The size of the date range must be less than 3 months.
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var filter = filter_example;  // string | Return notification of this type only. (optional) 
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // List notifications
                Object result = apiInstance.ListNotifications(accept, contentType, authorization, since, until, limit, offset, total, timeZone, filter, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.ListNotifications: " + e.Message );
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
 **since** | **DateTime?**| The start of the date range over which you want to search. The time element is optional. | 
 **until** | **DateTime?**| The end of the date range over which you want to search. This should be in the same format as since. The size of the date range must be less than 3 months. | 
 **limit** | **int?**| The number of results per page. | [optional] 
 **offset** | **int?**| Offset to start pagination search results. | [optional] 
 **total** | **bool?**| By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  | [optional] [default to false]
 **timeZone** | **string**| Time zone in which dates in the result will be rendered. | [optional] [default to UTC]
 **filter** | **string**| Return notification of this type only. | [optional] 
 **include** | **string**| Array of additional details to include. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
