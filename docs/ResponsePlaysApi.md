# PagerDuty.ApiClient.Api.ResponsePlaysApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateResponsePlay**](ResponsePlaysApi.md#createresponseplay) | **POST** /response_plays | Create a Response Play
[**DeleteResponsePlay**](ResponsePlaysApi.md#deleteresponseplay) | **DELETE** /response_plays/{id} | Delete a Response Play
[**GetResponsePlay**](ResponsePlaysApi.md#getresponseplay) | **GET** /response_plays/{id} | Get a Response Play
[**ListResponsePlays**](ResponsePlaysApi.md#listresponseplays) | **GET** /response_plays | List Response Plays
[**RunResponsePlay**](ResponsePlaysApi.md#runresponseplay) | **POST** /response_plays/{response_play_id}/run | Run a response play
[**UpdateResponsePlay**](ResponsePlaysApi.md#updateresponseplay) | **PUT** /response_plays/{id} | Update a Response Play

<a name="createresponseplay"></a>
# **CreateResponsePlay**
> Object CreateResponsePlay (string accept, string contentType, string authorization, string from, Object body = null)

Create a Response Play

Creates a new Response Plays.  Response Plays allow you to create packages of Incident Actions that can be applied during an Incident's life cycle.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#response-plays) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateResponsePlayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResponsePlaysApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var body = new Object(); // Object | The Response Play to be created. (optional) 

            try
            {
                // Create a Response Play
                Object result = apiInstance.CreateResponsePlay(accept, contentType, authorization, from, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponsePlaysApi.CreateResponsePlay: " + e.Message );
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
 **body** | [**Object**](Object.md)| The Response Play to be created. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteresponseplay"></a>
# **DeleteResponsePlay**
> void DeleteResponsePlay (string id, string accept, string contentType, string authorization, string from)

Delete a Response Play

Delete an existing Response Play. Once the Response Play is deleted, the action cannot be undone.  WARNING: When the Response Play is deleted, it is also removed from any Services that were using it.  Response Plays allow you to create packages of Incident Actions that can be applied to an Incident.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#response-plays) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteResponsePlayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResponsePlaysApi();
            var id = id_example;  // string | The ID of the resource.
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.

            try
            {
                // Delete a Response Play
                apiInstance.DeleteResponsePlay(id, accept, contentType, authorization, from);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponsePlaysApi.DeleteResponsePlay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the resource. | 
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **contentType** | **string**|  | [default to application/json]
 **authorization** | **string**| The &#x60;Authorization&#x60; header is used as a versioning header. | [default to Token token&#x3D;y_NbAkKc66ryYTWUXYEu]
 **from** | **string**| The email address of a valid user associated with the account making the request. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getresponseplay"></a>
# **GetResponsePlay**
> Object GetResponsePlay (string id, string accept, string contentType, string authorization, string from = null)

Get a Response Play

Get details about an existing Response Play.  Response Plays allow you to create packages of Incident Actions that can be applied during an Incident's life cycle.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#response-plays)  When using a Global API token, the `From` header is required.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetResponsePlayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResponsePlaysApi();
            var id = id_example;  // string | The ID of the resource.
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request. This is optional, and is only used for change tracking. (optional) 

            try
            {
                // Get a Response Play
                Object result = apiInstance.GetResponsePlay(id, accept, contentType, authorization, from);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponsePlaysApi.GetResponsePlay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the resource. | 
 **accept** | **string**| The &#x60;Accept&#x60; header is used as a versioning header. | [default to application/vnd.pagerduty+json;version&#x3D;2]
 **contentType** | **string**|  | [default to application/json]
 **authorization** | **string**| The &#x60;Authorization&#x60; header is used as a versioning header. | [default to Token token&#x3D;y_NbAkKc66ryYTWUXYEu]
 **from** | **string**| The email address of a valid user associated with the account making the request. This is optional, and is only used for change tracking. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listresponseplays"></a>
# **ListResponsePlays**
> Object ListResponsePlays (string accept, string contentType, string authorization, string query = null, bool? filterForManualRun = null, string from = null)

List Response Plays

List all of the existing Response Plays.  Response Plays allow you to create packages of Incident Actions that can be applied during an Incident's life cycle.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#response-plays)  When using a Global API token, the `From` header is required. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListResponsePlaysExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResponsePlaysApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var query = query_example;  // string | Filters the result, showing only the records whose name matches the query. (optional) 
            var filterForManualRun = true;  // bool? | When this parameter is present, only those Response Plays that can be run manually will be returned. (optional) 
            var from = from_example;  // string | The email address of a valid user associated with the account making the request. This is optional, and is only used for change tracking. (optional) 

            try
            {
                // List Response Plays
                Object result = apiInstance.ListResponsePlays(accept, contentType, authorization, query, filterForManualRun, from);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponsePlaysApi.ListResponsePlays: " + e.Message );
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
 **query** | **string**| Filters the result, showing only the records whose name matches the query. | [optional] 
 **filterForManualRun** | **bool?**| When this parameter is present, only those Response Plays that can be run manually will be returned. | [optional] 
 **from** | **string**| The email address of a valid user associated with the account making the request. This is optional, and is only used for change tracking. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="runresponseplay"></a>
# **RunResponsePlay**
> Object RunResponsePlay (string accept, string contentType, string authorization, string from, string responsePlayId, Object body = null)

Run a response play

Run a specified response play on a given incident.  Response Plays are a package of Incident Actions that can be applied during an Incident's life cycle.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#response-plays) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class RunResponsePlayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResponsePlaysApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var responsePlayId = responsePlayId_example;  // string | The response play ID of the response play associated with the request.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Run a response play
                Object result = apiInstance.RunResponsePlay(accept, contentType, authorization, from, responsePlayId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponsePlaysApi.RunResponsePlay: " + e.Message );
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
 **responsePlayId** | **string**| The response play ID of the response play associated with the request. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateresponseplay"></a>
# **UpdateResponsePlay**
> Object UpdateResponsePlay (string accept, string contentType, string authorization, string from, string id, Object body = null)

Update a Response Play

Updates an existing Response Play.  Response Plays allow you to create packages of Incident Actions that can be applied during an Incident's life cycle.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#response-plays) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateResponsePlayExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResponsePlaysApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The Response Play to be updated. (optional) 

            try
            {
                // Update a Response Play
                Object result = apiInstance.UpdateResponsePlay(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponsePlaysApi.UpdateResponsePlay: " + e.Message );
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
 **body** | [**Object**](Object.md)| The Response Play to be updated. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
