# PagerDuty.ApiClient.Api.BusinessServicesApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBusinessService**](BusinessServicesApi.md#createbusinessservice) | **POST** /business_services | Create a Business Service
[**CreateBusinessServiceAccountSubscription**](BusinessServicesApi.md#createbusinessserviceaccountsubscription) | **POST** /business_services/{id}/account_subscription | Create Business Service Account Subscription
[**CreateBusinessServiceNotificationSubscribers**](BusinessServicesApi.md#createbusinessservicenotificationsubscribers) | **POST** /business_services/{id}/subscribers | Create Business Service Subscribers
[**DeleteBusinessService**](BusinessServicesApi.md#deletebusinessservice) | **DELETE** /business_services/{id} | Delete a Business Service
[**DeleteBusinessServicePriorityThresholds**](BusinessServicesApi.md#deletebusinessserviceprioritythresholds) | **DELETE** /business_services/priority_thresholds | Deletes the account-level priority threshold for Business Service impact
[**GetBusinessService**](BusinessServicesApi.md#getbusinessservice) | **GET** /business_services/{id} | Get a Business Service
[**GetBusinessServiceImpacts**](BusinessServicesApi.md#getbusinessserviceimpacts) | **GET** /business_services/impacts | List Business Services sorted by impacted status
[**GetBusinessServicePriorityThresholds**](BusinessServicesApi.md#getbusinessserviceprioritythresholds) | **GET** /business_services/priority_thresholds | Get the global priority threshold for a Business Service to be considered impacted by an Incident
[**GetBusinessServiceSubscribers**](BusinessServicesApi.md#getbusinessservicesubscribers) | **GET** /business_services/{id}/subscribers | List Business Service Subscribers
[**GetBusinessServiceSupportingServiceImpacts**](BusinessServicesApi.md#getbusinessservicesupportingserviceimpacts) | **GET** /business_services/{id}/supporting_services/impacts | List the supporting Business Services for the given Business Service Id, sorted by impacted status.
[**GetBusinessServiceTopLevelImpactors**](BusinessServicesApi.md#getbusinessservicetoplevelimpactors) | **GET** /business_services/impactors | List Impactors affecting Business Services
[**ListBusinessServices**](BusinessServicesApi.md#listbusinessservices) | **GET** /business_services | List Business Services
[**PutBusinessServicePriorityThresholds**](BusinessServicesApi.md#putbusinessserviceprioritythresholds) | **PUT** /business_services/priority_thresholds | Set the Account-level priority threshold for Business Service impact.
[**RemoveBusinessServiceAccountSubscription**](BusinessServicesApi.md#removebusinessserviceaccountsubscription) | **DELETE** /business_services/{id}/account_subscription | Delete Business Service Account Subscription
[**RemoveBusinessServiceNotificationSubscriber**](BusinessServicesApi.md#removebusinessservicenotificationsubscriber) | **POST** /business_services/{id}/unsubscribe | Remove Business Service Subscribers
[**UpdateBusinessService**](BusinessServicesApi.md#updatebusinessservice) | **PUT** /business_services/{id} | Update a Business Service

<a name="createbusinessservice"></a>
# **CreateBusinessService**
> Object CreateBusinessService (string accept, string contentType, string authorization, Object body = null)

Create a Business Service

Create a new Business Service.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  There is a limit of 5,000 business services per account. If the limit is reached, the API will respond with an error.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateBusinessServiceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Business Service
                Object result = apiInstance.CreateBusinessService(accept, contentType, authorization, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.CreateBusinessService: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createbusinessserviceaccountsubscription"></a>
# **CreateBusinessServiceAccountSubscription**
> Object CreateBusinessServiceAccountSubscription (string accept, string id)

Create Business Service Account Subscription

Subscribe your Account to a Business Service.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateBusinessServiceAccountSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Create Business Service Account Subscription
                Object result = apiInstance.CreateBusinessServiceAccountSubscription(accept, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.CreateBusinessServiceAccountSubscription: " + e.Message );
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

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createbusinessservicenotificationsubscribers"></a>
# **CreateBusinessServiceNotificationSubscribers**
> Object CreateBusinessServiceNotificationSubscribers (string accept, string id, Object body = null)

Create Business Service Subscribers

Subscribe the given entities to the given Business Service.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateBusinessServiceNotificationSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The entities to subscribe. (optional) 

            try
            {
                // Create Business Service Subscribers
                Object result = apiInstance.CreateBusinessServiceNotificationSubscribers(accept, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.CreateBusinessServiceNotificationSubscribers: " + e.Message );
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
 **body** | [**Object**](Object.md)| The entities to subscribe. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebusinessservice"></a>
# **DeleteBusinessService**
> void DeleteBusinessService (string accept, string contentType, string authorization, string id)

Delete a Business Service

Delete an existing Business Service.  Once the service is deleted, it will not be accessible from the web UI and new incidents won't be able to be created for this service.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteBusinessServiceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Delete a Business Service
                apiInstance.DeleteBusinessService(accept, contentType, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.DeleteBusinessService: " + e.Message );
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
<a name="deletebusinessserviceprioritythresholds"></a>
# **DeleteBusinessServicePriorityThresholds**
> void DeleteBusinessServicePriorityThresholds (string accept, string X_EARLY_ACCESS)

Deletes the account-level priority threshold for Business Service impact

Clears the Priority Threshold for the account.  If the priority threshold is cleared, any Incident with a Priority set will be able to impact Business Services.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteBusinessServicePriorityThresholdsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)

            try
            {
                // Deletes the account-level priority threshold for Business Service impact
                apiInstance.DeleteBusinessServicePriorityThresholds(accept, X_EARLY_ACCESS);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.DeleteBusinessServicePriorityThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;business-impact-early-access&#x60;. Do not use this endpoint in production, as it may change! | [default to business-impact-early-access]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbusinessservice"></a>
# **GetBusinessService**
> Object GetBusinessService (string accept, string contentType, string authorization, string id)

Get a Business Service

Get details about an existing Business Service.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServiceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Get a Business Service
                Object result = apiInstance.GetBusinessService(accept, contentType, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.GetBusinessService: " + e.Message );
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

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbusinessserviceimpacts"></a>
# **GetBusinessServiceImpacts**
> Object GetBusinessServiceImpacts (string accept, string X_EARLY_ACCESS, string additionalFields = null, string ids = null)

List Business Services sorted by impacted status

Retrieve a list top-level Business Services sorted by highest Impact with `status` included. When called without the `ids[]` parameter, this endpoint does not return an exhaustive list of Business Services but rather provides access to the most impacted up to the limit of 200.  The returned Business Services are sorted first by Impact, secondarily by most recently impacted, and finally by name.  To get impact information about a specific set of Business Services, use the `ids[]` parameter.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServiceImpactsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)
            var additionalFields = additionalFields_example;  // string | Provides access to additional fields such as highest priority per business service and total impacted count (optional) 
            var ids = ids_example;  // string | The IDs of the resources. (optional) 

            try
            {
                // List Business Services sorted by impacted status
                Object result = apiInstance.GetBusinessServiceImpacts(accept, X_EARLY_ACCESS, additionalFields, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.GetBusinessServiceImpacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;business-impact-early-access&#x60;. Do not use this endpoint in production, as it may change! | [default to business-impact-early-access]
 **additionalFields** | **string**| Provides access to additional fields such as highest priority per business service and total impacted count | [optional] 
 **ids** | **string**| The IDs of the resources. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbusinessserviceprioritythresholds"></a>
# **GetBusinessServicePriorityThresholds**
> Object GetBusinessServicePriorityThresholds (string accept, string X_EARLY_ACCESS)

Get the global priority threshold for a Business Service to be considered impacted by an Incident

Retrieves the priority threshold information for an account.  Currently, there is a `global_threshold` that can be set for the account.  Incidents that have a priority meeting or exceeding this threshold will be considered impacting on any Business Service that depends on the Service to which the Incident belongs.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServicePriorityThresholdsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)

            try
            {
                // Get the global priority threshold for a Business Service to be considered impacted by an Incident
                Object result = apiInstance.GetBusinessServicePriorityThresholds(accept, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.GetBusinessServicePriorityThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;business-impact-early-access&#x60;. Do not use this endpoint in production, as it may change! | [default to business-impact-early-access]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbusinessservicesubscribers"></a>
# **GetBusinessServiceSubscribers**
> Object GetBusinessServiceSubscribers (string accept, string id)

List Business Service Subscribers

Retrieve a list of Notification Subscribers on the Business Service.  <!- - theme: warning - -> > Users must be added through `POST /business_services/{id}/subscribers` to be returned from this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServiceSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // List Business Service Subscribers
                Object result = apiInstance.GetBusinessServiceSubscribers(accept, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.GetBusinessServiceSubscribers: " + e.Message );
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

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbusinessservicesupportingserviceimpacts"></a>
# **GetBusinessServiceSupportingServiceImpacts**
> Object GetBusinessServiceSupportingServiceImpacts (string accept, string id, string X_EARLY_ACCESS, string additionalFields = null, string ids = null)

List the supporting Business Services for the given Business Service Id, sorted by impacted status.

Retrieve of Business Services that support the given Business Service sorted by highest Impact with `status` included. This endpoint does not return an exhaustive list of Business Services but rather provides access to the most impacted up to the limit of 200.  The returned Business Services are sorted first by Impact, secondarily by most recently impacted, and finally by name.  To get impact information about a specific set of Business Services, use the `ids[]` parameter on the `/business_services/impacts` endpoint.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServiceSupportingServiceImpactsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)
            var additionalFields = additionalFields_example;  // string | Provides access to additional fields such as highest priority per business service and total impacted count (optional) 
            var ids = ids_example;  // string | The IDs of the resources. (optional) 

            try
            {
                // List the supporting Business Services for the given Business Service Id, sorted by impacted status.
                Object result = apiInstance.GetBusinessServiceSupportingServiceImpacts(accept, id, X_EARLY_ACCESS, additionalFields, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.GetBusinessServiceSupportingServiceImpacts: " + e.Message );
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
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;business-impact-early-access&#x60;. Do not use this endpoint in production, as it may change! | [default to business-impact-early-access]
 **additionalFields** | **string**| Provides access to additional fields such as highest priority per business service and total impacted count | [optional] 
 **ids** | **string**| The IDs of the resources. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbusinessservicetoplevelimpactors"></a>
# **GetBusinessServiceTopLevelImpactors**
> Object GetBusinessServiceTopLevelImpactors (string accept, string X_EARLY_ACCESS, string ids = null)

List Impactors affecting Business Services

Retrieve a list of Impactors for the top-level Business Services on the account. Impactors are currently limited to Incidents.  This endpoint does not return an exhaustive list of Impactors but rather provides access to the highest priority Impactors for the Business Services in question up to the limit of 200.  To get Impactors for a specific set of Business Services, use the `ids[]` parameter.  The returned Impactors are sorted first by priority and secondarily by their creation date.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServiceTopLevelImpactorsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)
            var ids = ids_example;  // string | The IDs of the resources. (optional) 

            try
            {
                // List Impactors affecting Business Services
                Object result = apiInstance.GetBusinessServiceTopLevelImpactors(accept, X_EARLY_ACCESS, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.GetBusinessServiceTopLevelImpactors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;business-impact-early-access&#x60;. Do not use this endpoint in production, as it may change! | [default to business-impact-early-access]
 **ids** | **string**| The IDs of the resources. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listbusinessservices"></a>
# **ListBusinessServices**
> Object ListBusinessServices (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null)

List Business Services

List existing Business Services.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListBusinessServicesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // List Business Services
                Object result = apiInstance.ListBusinessServices(accept, contentType, authorization, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.ListBusinessServices: " + e.Message );
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

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putbusinessserviceprioritythresholds"></a>
# **PutBusinessServicePriorityThresholds**
> Object PutBusinessServicePriorityThresholds (string accept, string X_EARLY_ACCESS, Object body = null)

Set the Account-level priority threshold for Business Service impact.

Set the Account-level priority threshold for Business Service.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class PutBusinessServicePriorityThresholdsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)
            var body = new Object(); // Object | Set the `id` and `order` of the global Priority Threshold. These values can be obtained by calling the `/priorities` endpoint.

Once set, Incidents must be at or above the specified level in order to impact Business Services.  An exception to this rule is if the Incident has been added to the incident directly using the `PUT /incidents/{id}/business_services/{business_service_id}/impacts` endpoint. (optional) 

            try
            {
                // Set the Account-level priority threshold for Business Service impact.
                Object result = apiInstance.PutBusinessServicePriorityThresholds(accept, X_EARLY_ACCESS, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.PutBusinessServicePriorityThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value &#x60;business-impact-early-access&#x60;. Do not use this endpoint in production, as it may change! | [default to business-impact-early-access]
 **body** | [**Object**](Object.md)| Set the &#x60;id&#x60; and &#x60;order&#x60; of the global Priority Threshold. These values can be obtained by calling the &#x60;/priorities&#x60; endpoint.

Once set, Incidents must be at or above the specified level in order to impact Business Services.  An exception to this rule is if the Incident has been added to the incident directly using the &#x60;PUT /incidents/{id}/business_services/{business_service_id}/impacts&#x60; endpoint. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removebusinessserviceaccountsubscription"></a>
# **RemoveBusinessServiceAccountSubscription**
> void RemoveBusinessServiceAccountSubscription (string accept, string id)

Delete Business Service Account Subscription

Unsubscribe your Account from a Business Service.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class RemoveBusinessServiceAccountSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Delete Business Service Account Subscription
                apiInstance.RemoveBusinessServiceAccountSubscription(accept, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.RemoveBusinessServiceAccountSubscription: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removebusinessservicenotificationsubscriber"></a>
# **RemoveBusinessServiceNotificationSubscriber**
> Object RemoveBusinessServiceNotificationSubscriber (string accept, string id, Object body = null)

Remove Business Service Subscribers

Unsubscribes the matching Subscribers from a Business Service.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class RemoveBusinessServiceNotificationSubscriberExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The entities to unsubscribe. (optional) 

            try
            {
                // Remove Business Service Subscribers
                Object result = apiInstance.RemoveBusinessServiceNotificationSubscriber(accept, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.RemoveBusinessServiceNotificationSubscriber: " + e.Message );
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
 **body** | [**Object**](Object.md)| The entities to unsubscribe. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatebusinessservice"></a>
# **UpdateBusinessService**
> Object UpdateBusinessService (string accept, string contentType, string authorization, string id, Object body = null)

Update a Business Service

Update an existing Business Service. NOTE that this endpoint also accepts the PATCH verb.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateBusinessServiceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessServicesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update a Business Service
                Object result = apiInstance.UpdateBusinessService(accept, contentType, authorization, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessServicesApi.UpdateBusinessService: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
