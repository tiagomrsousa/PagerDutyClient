# PagerDuty.ApiClient.Api.ServiceDependenciesApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateServiceDependency**](ServiceDependenciesApi.md#createservicedependency) | **POST** /service_dependencies/associate | Associate service dependencies
[**DeleteServiceDependency**](ServiceDependenciesApi.md#deleteservicedependency) | **POST** /service_dependencies/disassociate | Disassociate service dependencies
[**GetBusinessServiceServiceDependencies**](ServiceDependenciesApi.md#getbusinessserviceservicedependencies) | **GET** /service_dependencies/business_services/{id} | Get Business Service dependencies
[**GetTechnicalServiceServiceDependencies**](ServiceDependenciesApi.md#gettechnicalserviceservicedependencies) | **GET** /service_dependencies/technical_services/{id} | Get technical service dependencies

<a name="createservicedependency"></a>
# **CreateServiceDependency**
> Object CreateServiceDependency (string accept, string contentType, string authorization, Object body = null)

Associate service dependencies

Create new dependencies between two services.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  A service can have a maximum of 2,000 dependencies with a depth limit of 100. If the limit is reached, the API will respond with an error.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateServiceDependencyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDependenciesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Associate service dependencies
                Object result = apiInstance.CreateServiceDependency(accept, contentType, authorization, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceDependenciesApi.CreateServiceDependency: " + e.Message );
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
<a name="deleteservicedependency"></a>
# **DeleteServiceDependency**
> Object DeleteServiceDependency (string accept, string contentType, string authorization, Object body = null)

Disassociate service dependencies

Disassociate dependencies between two services.  Business services model capabilities that span multiple technical services and that may be owned by several different teams.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteServiceDependencyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDependenciesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Disassociate service dependencies
                Object result = apiInstance.DeleteServiceDependency(accept, contentType, authorization, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceDependenciesApi.DeleteServiceDependency: " + e.Message );
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
<a name="getbusinessserviceservicedependencies"></a>
# **GetBusinessServiceServiceDependencies**
> Object GetBusinessServiceServiceDependencies (string accept, string contentType, string authorization, string id)

Get Business Service dependencies

Get all immediate dependencies of any Business Service.  Business Services model capabilities that span multiple technical services and that may be owned by several different teams.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#business-services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetBusinessServiceServiceDependenciesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDependenciesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Get Business Service dependencies
                Object result = apiInstance.GetBusinessServiceServiceDependencies(accept, contentType, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceDependenciesApi.GetBusinessServiceServiceDependencies: " + e.Message );
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
<a name="gettechnicalserviceservicedependencies"></a>
# **GetTechnicalServiceServiceDependencies**
> Object GetTechnicalServiceServiceDependencies (string accept, string contentType, string authorization, string id)

Get technical service dependencies

Get all immediate dependencies of any technical service. Technical services are also known as `services`.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#services) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetTechnicalServiceServiceDependenciesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDependenciesApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Get technical service dependencies
                Object result = apiInstance.GetTechnicalServiceServiceDependencies(accept, contentType, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceDependenciesApi.GetTechnicalServiceServiceDependencies: " + e.Message );
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
