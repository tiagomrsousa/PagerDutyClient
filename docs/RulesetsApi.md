# PagerDuty.ApiClient.Api.RulesetsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRuleset**](RulesetsApi.md#createruleset) | **POST** /rulesets | Create a Ruleset
[**CreateRulesetEventRule**](RulesetsApi.md#createruleseteventrule) | **POST** /rulesets/{id}/rules | Create an Event Rule
[**DeleteRuleset**](RulesetsApi.md#deleteruleset) | **DELETE** /rulesets/{id} | Delete a Ruleset
[**DeleteRulesetEventRule**](RulesetsApi.md#deleteruleseteventrule) | **DELETE** /rulesets/{id}/rules/{rule_id} | Delete an Event Rule
[**GetRuleset**](RulesetsApi.md#getruleset) | **GET** /rulesets/{id} | Get a Ruleset
[**GetRulesetEventRule**](RulesetsApi.md#getruleseteventrule) | **GET** /rulesets/{id}/rules/{rule_id} | Get an Event Rule
[**ListRulesetEventRules**](RulesetsApi.md#listruleseteventrules) | **GET** /rulesets/{id}/rules | List Event Rules
[**ListRulesets**](RulesetsApi.md#listrulesets) | **GET** /rulesets | List Rulesets
[**UpdateRuleset**](RulesetsApi.md#updateruleset) | **PUT** /rulesets/{id} | Update a Ruleset
[**UpdateRulesetEventRule**](RulesetsApi.md#updateruleseteventrule) | **PUT** /rulesets/{id}/rules/{rule_id} | Update an Event Rule

<a name="createruleset"></a>
# **CreateRuleset**
> Object CreateRuleset (string accept, string contentType, string authorization, Object body = null)

Create a Ruleset

Create a new Ruleset.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Scoped OAuth requires: `event_rules.write` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateRulesetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Ruleset
                Object result = apiInstance.CreateRuleset(accept, contentType, authorization, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.CreateRuleset: " + e.Message );
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
<a name="createruleseteventrule"></a>
# **CreateRulesetEventRule**
> Object CreateRulesetEventRule (string accept, string contentType, string authorization, string id, Object body = null)

Create an Event Rule

Create a new Event Rule.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Note: Create and Update on rules will accept 'description' or 'summary' interchangeably as an extraction action target. Get and List on rules will always return 'summary' as the target. If you are expecting 'description' please change your automation code to expect 'summary' instead.  Scoped OAuth requires: `event_rules.write` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateRulesetEventRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create an Event Rule
                Object result = apiInstance.CreateRulesetEventRule(accept, contentType, authorization, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.CreateRulesetEventRule: " + e.Message );
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
<a name="deleteruleset"></a>
# **DeleteRuleset**
> void DeleteRuleset (string accept, string contentType, string authorization, string id)

Delete a Ruleset

Delete a Ruleset.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Scoped OAuth requires: `event_rules.write` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteRulesetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Delete a Ruleset
                apiInstance.DeleteRuleset(accept, contentType, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.DeleteRuleset: " + e.Message );
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
<a name="deleteruleseteventrule"></a>
# **DeleteRulesetEventRule**
> void DeleteRulesetEventRule (string accept, string contentType, string authorization, string id, string ruleId)

Delete an Event Rule

Delete an Event Rule.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Scoped OAuth requires: `event_rules.write` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteRulesetEventRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var ruleId = ruleId_example;  // string | The id of the Event Rule to retrieve.

            try
            {
                // Delete an Event Rule
                apiInstance.DeleteRulesetEventRule(accept, contentType, authorization, id, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.DeleteRulesetEventRule: " + e.Message );
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
 **ruleId** | **string**| The id of the Event Rule to retrieve. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getruleset"></a>
# **GetRuleset**
> Object GetRuleset (string accept, string contentType, string authorization, string id)

Get a Ruleset

Get a Ruleset.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Scoped OAuth requires: `event_rules.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetRulesetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // Get a Ruleset
                Object result = apiInstance.GetRuleset(accept, contentType, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.GetRuleset: " + e.Message );
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
<a name="getruleseteventrule"></a>
# **GetRulesetEventRule**
> Object GetRulesetEventRule (string accept, string contentType, string authorization, string id, string ruleId)

Get an Event Rule

Get an Event Rule.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Note: Create and Update on rules will accept 'description' or 'summary' interchangeably as an extraction action target. Get and List on rules will always return 'summary' as the target. If you are expecting 'description' please change your automation code to expect 'summary' instead.  Scoped OAuth requires: `event_rules.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetRulesetEventRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var ruleId = ruleId_example;  // string | The id of the Event Rule to retrieve.

            try
            {
                // Get an Event Rule
                Object result = apiInstance.GetRulesetEventRule(accept, contentType, authorization, id, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.GetRulesetEventRule: " + e.Message );
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
 **ruleId** | **string**| The id of the Event Rule to retrieve. | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listruleseteventrules"></a>
# **ListRulesetEventRules**
> Object ListRulesetEventRules (string accept, string contentType, string authorization, string id, int? limit = null, int? offset = null, bool? total = null)

List Event Rules

List all Event Rules on a Ruleset.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Note: Create and Update on rules will accept 'description' or 'summary' interchangeably as an extraction action target. Get and List on rules will always return 'summary' as the target. If you are expecting 'description' please change your automation code to expect 'summary' instead.  Scoped OAuth requires: `event_rules.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListRulesetEventRulesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // List Event Rules
                Object result = apiInstance.ListRulesetEventRules(accept, contentType, authorization, id, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.ListRulesetEventRules: " + e.Message );
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
<a name="listrulesets"></a>
# **ListRulesets**
> Object ListRulesets (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null)

List Rulesets

List all Rulesets  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Scoped OAuth requires: `event_rules.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListRulesetsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // List Rulesets
                Object result = apiInstance.ListRulesets(accept, contentType, authorization, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.ListRulesets: " + e.Message );
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
<a name="updateruleset"></a>
# **UpdateRuleset**
> Object UpdateRuleset (string accept, string contentType, string authorization, string id, Object body = null)

Update a Ruleset

Update a Ruleset.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Scoped OAuth requires: `event_rules.write` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateRulesetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update a Ruleset
                Object result = apiInstance.UpdateRuleset(accept, contentType, authorization, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.UpdateRuleset: " + e.Message );
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
<a name="updateruleseteventrule"></a>
# **UpdateRulesetEventRule**
> Object UpdateRulesetEventRule (string accept, string contentType, string authorization, string id, string ruleId, Object body = null)

Update an Event Rule

Update an Event Rule. Note that the endpoint supports partial updates, so any number of the writable fields can be provided.  Rulesets allow you to route events to an endpoint and create collections of Event Rules, which define sets of actions to take based on event content.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#rulesets)  Note: Create and Update on rules will accept 'description' or 'summary' interchangeably as an extraction action target. Get and List on rules will always return 'summary' as the target. If you are expecting 'description' please change your automation code to expect 'summary' instead.  Scoped OAuth requires: `event_rules.write` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateRulesetEventRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RulesetsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var ruleId = ruleId_example;  // string | The id of the Event Rule to retrieve.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update an Event Rule
                Object result = apiInstance.UpdateRulesetEventRule(accept, contentType, authorization, id, ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesetsApi.UpdateRulesetEventRule: " + e.Message );
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
 **ruleId** | **string**| The id of the Event Rule to retrieve. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
