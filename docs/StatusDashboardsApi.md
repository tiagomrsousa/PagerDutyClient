# PagerDuty.ApiClient.Api.StatusDashboardsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatusDashboardById**](StatusDashboardsApi.md#getstatusdashboardbyid) | **GET** /status_dashboards/{id} | Get a single Status Dashboard by &#x60;id&#x60;
[**GetStatusDashboardByUrlSlug**](StatusDashboardsApi.md#getstatusdashboardbyurlslug) | **GET** /status_dashboards/url_slugs/{url_slug} | Get a single Status Dashboard by &#x60;url_slug&#x60;
[**GetStatusDashboardServiceImpactsById**](StatusDashboardsApi.md#getstatusdashboardserviceimpactsbyid) | **GET** /status_dashboards/{id}/service_impacts | Get impacted Business Services for a Status Dashboard by &#x60;id&#x60;.
[**GetStatusDashboardServiceImpactsByUrlSlug**](StatusDashboardsApi.md#getstatusdashboardserviceimpactsbyurlslug) | **GET** /status_dashboards/url_slugs/{url_slug}/service_impacts | Get impacted Business Services for a  Status Dashboard by &#x60;url_slug&#x60;
[**ListStatusDashboards**](StatusDashboardsApi.md#liststatusdashboards) | **GET** /status_dashboards | List Status Dashboards

<a name="getstatusdashboardbyid"></a>
# **GetStatusDashboardById**
> Object GetStatusDashboardById (string accept, string id, string X_EARLY_ACCESS)

Get a single Status Dashboard by `id`

Get a Status Dashboard by its PagerDuty `id`.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetStatusDashboardByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatusDashboardsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `status-dashboards`. Do not use this endpoint in production, as it may change! (default to status-dashboards)

            try
            {
                // Get a single Status Dashboard by `id`
                Object result = apiInstance.GetStatusDashboardById(accept, id, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusDashboardsApi.GetStatusDashboardById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **id** | **string**| The ID of the resource. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;status-dashboards&#x60;. Do not use this endpoint in production, as it may change! | [default to status-dashboards]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatusdashboardbyurlslug"></a>
# **GetStatusDashboardByUrlSlug**
> Object GetStatusDashboardByUrlSlug (string accept, string urlSlug, string X_EARLY_ACCESS)

Get a single Status Dashboard by `url_slug`

Get a Status Dashboard by its PagerDuty `url_slug`.  A `url_slug` is a human-readable reference for a custom Status Dashboard that may be created or changed in the UI. It will generally be a `dash-separated-string-like-this`.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetStatusDashboardByUrlSlugExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatusDashboardsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var urlSlug = urlSlug_example;  // string | The `url_slug` for a status dashboard
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `status-dashboards`. Do not use this endpoint in production, as it may change! (default to status-dashboards)

            try
            {
                // Get a single Status Dashboard by `url_slug`
                Object result = apiInstance.GetStatusDashboardByUrlSlug(accept, urlSlug, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusDashboardsApi.GetStatusDashboardByUrlSlug: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **urlSlug** | **string**| The &#x60;url_slug&#x60; for a status dashboard | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;status-dashboards&#x60;. Do not use this endpoint in production, as it may change! | [default to status-dashboards]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatusdashboardserviceimpactsbyid"></a>
# **GetStatusDashboardServiceImpactsById**
> Object GetStatusDashboardServiceImpactsById (string accept, string id, string X_EARLY_ACCESS, string additionalFields = null)

Get impacted Business Services for a Status Dashboard by `id`.

Get impacted Business Services for a Status Dashboard by `id`  This endpoint does not return an exhaustive list of Business Services but rather provides access to the most impacted on the specified Status Dashboard up to the limit of 200.  The returned Business Services are sorted first by Impact, secondarily by most recently impacted, and finally by name.  To get Impact information about a specific Business Service on the Status Dashboard that does not appear in the Impact-sorted response, use the `ids[]` parameter on the `/business_services/impacts` endpoint.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetStatusDashboardServiceImpactsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatusDashboardsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `status-dashboards`. Do not use this endpoint in production, as it may change! (default to status-dashboards)
            var additionalFields = additionalFields_example;  // string | Provides access to additional fields such as highest priority per business service and total impacted count (optional) 

            try
            {
                // Get impacted Business Services for a Status Dashboard by `id`.
                Object result = apiInstance.GetStatusDashboardServiceImpactsById(accept, id, X_EARLY_ACCESS, additionalFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusDashboardsApi.GetStatusDashboardServiceImpactsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **id** | **string**| The ID of the resource. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;status-dashboards&#x60;. Do not use this endpoint in production, as it may change! | [default to status-dashboards]
 **additionalFields** | **string**| Provides access to additional fields such as highest priority per business service and total impacted count | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatusdashboardserviceimpactsbyurlslug"></a>
# **GetStatusDashboardServiceImpactsByUrlSlug**
> Object GetStatusDashboardServiceImpactsByUrlSlug (string accept, string urlSlug, string X_EARLY_ACCESS, string additionalFields = null)

Get impacted Business Services for a  Status Dashboard by `url_slug`

Get Business Service Impacts for the Business Services on a Status Dashboard by its `url_slug`. A `url_slug` is a human-readable reference for a custom Status Dashboard that may be created or changed in the UI. It will generally be a `dash-separated-string-like-this`.  This endpoint does not return an exhaustive list of Business Services but rather provides access to the most impacted on the Status Dashboard up to the limit of 200.  The returned Business Services are sorted first by Impact, secondarily by most recently impacted, and finally by name.  To get impact information about a specific Business Service on the Status Dashboard that does not appear in the Impact-sored response, use the `ids[]` parameter on the `/business_services/impacts` endpoint.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetStatusDashboardServiceImpactsByUrlSlugExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatusDashboardsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var urlSlug = urlSlug_example;  // string | The `url_slug` for a status dashboard
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `status-dashboards`. Do not use this endpoint in production, as it may change! (default to status-dashboards)
            var additionalFields = additionalFields_example;  // string | Provides access to additional fields such as highest priority per business service and total impacted count (optional) 

            try
            {
                // Get impacted Business Services for a  Status Dashboard by `url_slug`
                Object result = apiInstance.GetStatusDashboardServiceImpactsByUrlSlug(accept, urlSlug, X_EARLY_ACCESS, additionalFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusDashboardsApi.GetStatusDashboardServiceImpactsByUrlSlug: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **urlSlug** | **string**| The &#x60;url_slug&#x60; for a status dashboard | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;status-dashboards&#x60;. Do not use this endpoint in production, as it may change! | [default to status-dashboards]
 **additionalFields** | **string**| Provides access to additional fields such as highest priority per business service and total impacted count | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="liststatusdashboards"></a>
# **ListStatusDashboards**
> Object ListStatusDashboards (string accept, string X_EARLY_ACCESS)

List Status Dashboards

Get all your account's custom Status Dashboard views  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListStatusDashboardsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatusDashboardsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `status-dashboards`. Do not use this endpoint in production, as it may change! (default to status-dashboards)

            try
            {
                // List Status Dashboards
                Object result = apiInstance.ListStatusDashboards(accept, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatusDashboardsApi.ListStatusDashboards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;status-dashboards&#x60;. Do not use this endpoint in production, as it may change! | [default to status-dashboards]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
