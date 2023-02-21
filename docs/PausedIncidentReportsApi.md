# PagerDuty.ApiClient.Api.PausedIncidentReportsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPausedIncidentReportAlerts**](PausedIncidentReportsApi.md#getpausedincidentreportalerts) | **GET** /paused_incident_reports/alerts | Get Paused Incident Reporting on Alerts
[**GetPausedIncidentReportCounts**](PausedIncidentReportsApi.md#getpausedincidentreportcounts) | **GET** /paused_incident_reports/counts | Get Paused Incident Reporting counts

<a name="getpausedincidentreportalerts"></a>
# **GetPausedIncidentReportAlerts**
> Object GetPausedIncidentReportAlerts (string accept, string contentType, string authorization, DateTime? since = null, DateTime? until = null, string serviceId = null, string suspendedBy = null)

Get Paused Incident Reporting on Alerts

Returns the 5 most recent alerts that were triggered after being paused and the 5 most recent alerts that were resolved after being paused for a given reporting period (maximum 6 months lookback period).  Note: This feature is currently available as part of the Event Intelligence package or Digital Operations plan only.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#paused-incident-reports)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetPausedIncidentReportAlertsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PausedIncidentReportsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. (optional) 
            var serviceId = serviceId_example;  // string | Specifies a filter to limit the scope of reporting to a particular service (optional) 
            var suspendedBy = new string(); // string | Specifies a filter to scope the response to either alerts suspended by Auto Pause or Event Rules. (optional) 

            try
            {
                // Get Paused Incident Reporting on Alerts
                Object result = apiInstance.GetPausedIncidentReportAlerts(accept, contentType, authorization, since, until, serviceId, suspendedBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PausedIncidentReportsApi.GetPausedIncidentReportAlerts: " + e.Message );
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
 **since** | **DateTime?**| The start of the date range over which you want to search. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. | [optional] 
 **serviceId** | **string**| Specifies a filter to limit the scope of reporting to a particular service | [optional] 
 **suspendedBy** | [**string**](string.md)| Specifies a filter to scope the response to either alerts suspended by Auto Pause or Event Rules. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpausedincidentreportcounts"></a>
# **GetPausedIncidentReportCounts**
> Object GetPausedIncidentReportCounts (string accept, string contentType, string authorization, DateTime? since = null, DateTime? until = null, string serviceId = null, string suspendedBy = null)

Get Paused Incident Reporting counts

Returns reporting counts for paused Incident usage for a given reporting period (maximum 6 months lookback period).  Note: This feature is currently available as part of the Event Intelligence package or Digital Operations plan only.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#paused-incident-reports)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetPausedIncidentReportCountsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PausedIncidentReportsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. (optional) 
            var serviceId = serviceId_example;  // string | Specifies a filter to limit the scope of reporting to a particular service (optional) 
            var suspendedBy = new string(); // string | Specifies a filter to scope the response to either alerts suspended by Auto Pause or Event Rules. (optional) 

            try
            {
                // Get Paused Incident Reporting counts
                Object result = apiInstance.GetPausedIncidentReportCounts(accept, contentType, authorization, since, until, serviceId, suspendedBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PausedIncidentReportsApi.GetPausedIncidentReportCounts: " + e.Message );
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
 **since** | **DateTime?**| The start of the date range over which you want to search. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. | [optional] 
 **serviceId** | **string**| Specifies a filter to limit the scope of reporting to a particular service | [optional] 
 **suspendedBy** | [**string**](string.md)| Specifies a filter to scope the response to either alerts suspended by Auto Pause or Event Rules. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
