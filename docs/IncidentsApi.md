# PagerDuty.ApiClient.Api.IncidentsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIncident**](IncidentsApi.md#createincident) | **POST** /incidents | Create an Incident
[**CreateIncidentNote**](IncidentsApi.md#createincidentnote) | **POST** /incidents/{id}/notes | Create a note on an incident
[**CreateIncidentNotificationSubscribers**](IncidentsApi.md#createincidentnotificationsubscribers) | **POST** /incidents/{id}/status_updates/subscribers | Add Notification Subscribers
[**CreateIncidentResponderRequest**](IncidentsApi.md#createincidentresponderrequest) | **POST** /incidents/{id}/responder_requests | Create a responder request for an incident
[**CreateIncidentSnooze**](IncidentsApi.md#createincidentsnooze) | **POST** /incidents/{id}/snooze | Snooze an incident
[**CreateIncidentStatusUpdate**](IncidentsApi.md#createincidentstatusupdate) | **POST** /incidents/{id}/status_updates | Create a status update on an incident
[**GetIncident**](IncidentsApi.md#getincident) | **GET** /incidents/{id} | Get an incident
[**GetIncidentAlert**](IncidentsApi.md#getincidentalert) | **GET** /incidents/{id}/alerts/{alert_id} | Get an alert
[**GetIncidentFieldValues**](IncidentsApi.md#getincidentfieldvalues) | **GET** /incidents/{id}/field_values | Get Incident Field Values
[**GetIncidentImpactedBusinessServices**](IncidentsApi.md#getincidentimpactedbusinessservices) | **GET** /incidents/{id}/business_services/impacts | List Business Services impacted by the given Incident
[**GetIncidentNotificationSubscribers**](IncidentsApi.md#getincidentnotificationsubscribers) | **GET** /incidents/{id}/status_updates/subscribers | List Notification Subscribers
[**GetOutlierIncident**](IncidentsApi.md#getoutlierincident) | **GET** /incidents/{id}/outlier_incident | Get Outlier Incident
[**GetPastIncidents**](IncidentsApi.md#getpastincidents) | **GET** /incidents/{id}/past_incidents | Get Past Incidents
[**GetRelatedIncidents**](IncidentsApi.md#getrelatedincidents) | **GET** /incidents/{id}/related_incidents | Get Related Incidents
[**GetSchemaForIncident**](IncidentsApi.md#getschemaforincident) | **GET** /incidents/{id}/field_values/schema | Get Incident&#x27;s Schema
[**ListIncidentAlerts**](IncidentsApi.md#listincidentalerts) | **GET** /incidents/{id}/alerts | List alerts for an incident
[**ListIncidentLogEntries**](IncidentsApi.md#listincidentlogentries) | **GET** /incidents/{id}/log_entries | List log entries for an incident
[**ListIncidentNotes**](IncidentsApi.md#listincidentnotes) | **GET** /incidents/{id}/notes | List notes for an incident
[**ListIncidents**](IncidentsApi.md#listincidents) | **GET** /incidents | List incidents
[**MergeIncidents**](IncidentsApi.md#mergeincidents) | **PUT** /incidents/{id}/merge | Merge incidents
[**PutIncidentManualBusinessServiceAssociation**](IncidentsApi.md#putincidentmanualbusinessserviceassociation) | **PUT** /incidents/{id}/business_services/{business_service_id}/impacts | Manually change an Incident&#x27;s Impact on a Business Service.
[**RemoveIncidentNotificationSubscribers**](IncidentsApi.md#removeincidentnotificationsubscribers) | **POST** /incidents/{id}/status_updates/unsubscribe | Remove Notification Subscriber
[**SetIncidentFieldValues**](IncidentsApi.md#setincidentfieldvalues) | **PUT** /incidents/{id}/field_values | Set Incident Field Values
[**UpdateIncident**](IncidentsApi.md#updateincident) | **PUT** /incidents/{id} | Update an incident
[**UpdateIncidentAlert**](IncidentsApi.md#updateincidentalert) | **PUT** /incidents/{id}/alerts/{alert_id} | Update an alert
[**UpdateIncidentAlerts**](IncidentsApi.md#updateincidentalerts) | **PUT** /incidents/{id}/alerts | Manage alerts
[**UpdateIncidents**](IncidentsApi.md#updateincidents) | **PUT** /incidents | Manage incidents

<a name="createincident"></a>
# **CreateIncident**
> Object CreateIncident (string accept, string contentType, string authorization, string from, Object body = null)

Create an Incident

Create an incident synchronously without a corresponding event from a monitoring service.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateIncidentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create an Incident
                Object result = apiInstance.CreateIncident(accept, contentType, authorization, from, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.CreateIncident: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createincidentnote"></a>
# **CreateIncidentNote**
> Object CreateIncidentNote (string accept, string contentType, string authorization, string from, string id, Object body = null)

Create a note on an incident

Create a new note for the specified incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  A maximum of 2000 notes can be added to an incident.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateIncidentNoteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a note on an incident
                Object result = apiInstance.CreateIncidentNote(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.CreateIncidentNote: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createincidentnotificationsubscribers"></a>
# **CreateIncidentNotificationSubscribers**
> Object CreateIncidentNotificationSubscribers (string accept, string id, Object body = null)

Add Notification Subscribers

Subscribe the given entities to Incident Status Update Notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateIncidentNotificationSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The entities to subscribe. (optional) 

            try
            {
                // Add Notification Subscribers
                Object result = apiInstance.CreateIncidentNotificationSubscribers(accept, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.CreateIncidentNotificationSubscribers: " + e.Message );
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
<a name="createincidentresponderrequest"></a>
# **CreateIncidentResponderRequest**
> Object CreateIncidentResponderRequest (string accept, string contentType, string authorization, string from, string id, Object body = null)

Create a responder request for an incident

Send a new responder request for the specified incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateIncidentResponderRequestExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a responder request for an incident
                Object result = apiInstance.CreateIncidentResponderRequest(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.CreateIncidentResponderRequest: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createincidentsnooze"></a>
# **CreateIncidentSnooze**
> Object CreateIncidentSnooze (string accept, string contentType, string authorization, string from, string id, Object body = null)

Snooze an incident

Snooze an incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateIncidentSnoozeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Snooze an incident
                Object result = apiInstance.CreateIncidentSnooze(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.CreateIncidentSnooze: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createincidentstatusupdate"></a>
# **CreateIncidentStatusUpdate**
> Object CreateIncidentStatusUpdate (string accept, string contentType, string authorization, string from, string id, Object body = null)

Create a status update on an incident

Create a new status update for the specified incident. Optionally pass `subject` and `html_message` properties in the request body to override the email notification that gets sent.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateIncidentStatusUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a status update on an incident
                Object result = apiInstance.CreateIncidentStatusUpdate(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.CreateIncidentStatusUpdate: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getincident"></a>
# **GetIncident**
> Object GetIncident (string accept, string contentType, string authorization, string id, string X_EARLY_ACCESS, string include = null)

Get an incident

Show detailed information about an incident. Accepts either an incident id, or an incident number.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents)  <!- - theme: warning - -> > ### Early Access > The `include[]=field_values` part of this endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetIncidentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // Get an incident
                Object result = apiInstance.GetIncident(accept, contentType, authorization, id, X_EARLY_ACCESS, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetIncident: " + e.Message );
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
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **include** | **string**| Array of additional details to include. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getincidentalert"></a>
# **GetIncidentAlert**
> Object GetIncidentAlert (string accept, string contentType, string authorization, string id, string alertId)

Get an alert

Show detailed information about an alert. Accepts an alert id.  An incident represents a problem or an issue that needs to be addressed and resolved.  When a service sends an event to PagerDuty, an alert and corresponding incident is triggered in PagerDuty.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetIncidentAlertExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var alertId = alertId_example;  // string | The id of the alert to retrieve.

            try
            {
                // Get an alert
                Object result = apiInstance.GetIncidentAlert(accept, contentType, authorization, id, alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetIncidentAlert: " + e.Message );
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
 **alertId** | **string**| The id of the alert to retrieve. | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getincidentfieldvalues"></a>
# **GetIncidentFieldValues**
> Object GetIncidentFieldValues (string id, string X_EARLY_ACCESS)

Get Incident Field Values

Get field values for an incident  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetIncidentFieldValuesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Get Incident Field Values
                Object result = apiInstance.GetIncidentFieldValues(id, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetIncidentFieldValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the resource. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getincidentimpactedbusinessservices"></a>
# **GetIncidentImpactedBusinessServices**
> Object GetIncidentImpactedBusinessServices (string accept, string id, string X_EARLY_ACCESS)

List Business Services impacted by the given Incident

Retrieve a list of Business Services that are being impacted by the given Incident.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetIncidentImpactedBusinessServicesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)

            try
            {
                // List Business Services impacted by the given Incident
                Object result = apiInstance.GetIncidentImpactedBusinessServices(accept, id, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetIncidentImpactedBusinessServices: " + e.Message );
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

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getincidentnotificationsubscribers"></a>
# **GetIncidentNotificationSubscribers**
> Object GetIncidentNotificationSubscribers (string accept, string id)

List Notification Subscribers

Retrieve a list of Notification Subscribers on the Incident.  <!- - theme: warning - -> > Users must be added through `POST /incident/{id}/status_updates/subscribers` to be returned from this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetIncidentNotificationSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // List Notification Subscribers
                Object result = apiInstance.GetIncidentNotificationSubscribers(accept, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetIncidentNotificationSubscribers: " + e.Message );
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
<a name="getoutlierincident"></a>
# **GetOutlierIncident**
> Object GetOutlierIncident (string accept, string contentType, string authorization, string id, DateTime? since = null, string additionalDetails = null)

Get Outlier Incident

Gets Outlier Incident information for a given Incident on its Service.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#outlier-incident)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetOutlierIncidentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var additionalDetails = additionalDetails_example;  // string | Array of additional attributes to any of the returned incidents for related incidents. (optional) 

            try
            {
                // Get Outlier Incident
                Object result = apiInstance.GetOutlierIncident(accept, contentType, authorization, id, since, additionalDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetOutlierIncident: " + e.Message );
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
 **additionalDetails** | **string**| Array of additional attributes to any of the returned incidents for related incidents. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpastincidents"></a>
# **GetPastIncidents**
> Object GetPastIncidents (int? limit = null, bool? total = null)

Get Past Incidents

Past Incidents returns Incidents within the past 6 months that have similar metadata and were generated on the same Service as the parent Incident. By default, 5 Past Incidents are returned. Note: This feature is currently available as part of the Event Intelligence package or Digital Operations plan only.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#past_incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetPastIncidentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var limit = 56;  // int? | The number of results to be returned in the response. (optional)  (default to 5)
            var total = true;  // bool? | By default the `total` field in the response body is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated with the total number of Past Incidents.  (optional)  (default to false)

            try
            {
                // Get Past Incidents
                Object result = apiInstance.GetPastIncidents(limit, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetPastIncidents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The number of results to be returned in the response. | [optional] [default to 5]
 **total** | **bool?**| By default the &#x60;total&#x60; field in the response body is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated with the total number of Past Incidents.  | [optional] [default to false]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrelatedincidents"></a>
# **GetRelatedIncidents**
> Object GetRelatedIncidents (string accept, string contentType, string authorization, string id, string additionalDetails = null)

Get Related Incidents

Returns the 20 most recent Related Incidents that are impacting other Responders and Services. Note: This feature is currently available as part of the Event Intelligence package or Digital Operations plan only.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#related_incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetRelatedIncidentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var additionalDetails = additionalDetails_example;  // string | Array of additional attributes to any of the returned incidents for related incidents. (optional) 

            try
            {
                // Get Related Incidents
                Object result = apiInstance.GetRelatedIncidents(accept, contentType, authorization, id, additionalDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetRelatedIncidents: " + e.Message );
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
 **additionalDetails** | **string**| Array of additional attributes to any of the returned incidents for related incidents. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getschemaforincident"></a>
# **GetSchemaForIncident**
> Object GetSchemaForIncident (string id, string X_EARLY_ACCESS, string include = null)

Get Incident's Schema

Get detailed information about a Schema for an incident.  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetSchemaForIncidentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var include = include_example;  // string | Array of additional details to include. Including `field_options` will also include field options. (optional) 

            try
            {
                // Get Incident's Schema
                Object result = apiInstance.GetSchemaForIncident(id, X_EARLY_ACCESS, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.GetSchemaForIncident: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the resource. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **include** | **string**| Array of additional details to include. Including &#x60;field_options&#x60; will also include field options. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listincidentalerts"></a>
# **ListIncidentAlerts**
> Object ListIncidentAlerts (string accept, string contentType, string authorization, string id, int? limit = null, int? offset = null, bool? total = null, string alertKey = null, string statuses = null, string sortBy = null, string include = null)

List alerts for an incident

List alerts for the specified incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListIncidentAlertsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var alertKey = alertKey_example;  // string | Alert de-duplication key. (optional) 
            var statuses = statuses_example;  // string | Return only alerts with the given statuses. (More status codes may be introduced in the future.) (optional) 
            var sortBy = sortBy_example;  // string | Used to specify both the field you wish to sort the results on (created_at/resolved_at), as well as the direction (asc/desc) of the results. The sort_by field and direction should be separated by a colon. A maximum of two fields can be included, separated by a comma. Sort direction defaults to ascending. (optional) 
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // List alerts for an incident
                Object result = apiInstance.ListIncidentAlerts(accept, contentType, authorization, id, limit, offset, total, alertKey, statuses, sortBy, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.ListIncidentAlerts: " + e.Message );
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
 **alertKey** | **string**| Alert de-duplication key. | [optional] 
 **statuses** | **string**| Return only alerts with the given statuses. (More status codes may be introduced in the future.) | [optional] 
 **sortBy** | **string**| Used to specify both the field you wish to sort the results on (created_at/resolved_at), as well as the direction (asc/desc) of the results. The sort_by field and direction should be separated by a colon. A maximum of two fields can be included, separated by a comma. Sort direction defaults to ascending. | [optional] 
 **include** | **string**| Array of additional details to include. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listincidentlogentries"></a>
# **ListIncidentLogEntries**
> Object ListIncidentLogEntries (string accept, string contentType, string authorization, string id, int? limit = null, int? offset = null, bool? total = null, string timeZone = null, DateTime? since = null, DateTime? until = null, bool? isOverview = null, string include = null)

List log entries for an incident

List log entries for the specified incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  A Log Entry are a record of all events on your account.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListIncidentLogEntriesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? | The start of the date range over which you want to search. (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? | The end of the date range over which you want to search. (optional) 
            var isOverview = true;  // bool? | If `true`, will return a subset of log entries that show only the most important changes to the incident. (optional)  (default to false)
            var include = include_example;  // string | Array of additional Models to include in response. (optional) 

            try
            {
                // List log entries for an incident
                Object result = apiInstance.ListIncidentLogEntries(accept, contentType, authorization, id, limit, offset, total, timeZone, since, until, isOverview, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.ListIncidentLogEntries: " + e.Message );
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
 **timeZone** | **string**| Time zone in which dates in the result will be rendered. | [optional] [default to UTC]
 **since** | **DateTime?**| The start of the date range over which you want to search. | [optional] 
 **until** | **DateTime?**| The end of the date range over which you want to search. | [optional] 
 **isOverview** | **bool?**| If &#x60;true&#x60;, will return a subset of log entries that show only the most important changes to the incident. | [optional] [default to false]
 **include** | **string**| Array of additional Models to include in response. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listincidentnotes"></a>
# **ListIncidentNotes**
> Object ListIncidentNotes (string accept, string contentType, string authorization, string id)

List notes for an incident

List existing notes for the specified incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListIncidentNotesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var id = id_example;  // string | The ID of the resource.

            try
            {
                // List notes for an incident
                Object result = apiInstance.ListIncidentNotes(accept, contentType, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.ListIncidentNotes: " + e.Message );
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
<a name="listincidents"></a>
# **ListIncidents**
> Object ListIncidents (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null, string dateRange = null, string incidentKey = null, List<string> serviceIds = null, List<string> teamIds = null, List<string> userIds = null, string urgencies = null, string timeZone = null, string statuses = null, List<string> sortBy = null, string include = null, string since = null, string until = null)

List incidents

List existing incidents.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents)  Scoped OAuth requires: `incidents.read` 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListIncidentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var dateRange = dateRange_example;  // string | When set to all, the since and until parameters and defaults are ignored. (optional) 
            var incidentKey = incidentKey_example;  // string | Incident de-duplication key. Incidents with child alerts do not have an incident key; querying by incident key will return incidents whose alerts have alert_key matching the given incident key. (optional) 
            var serviceIds = new List<string>(); // List<string> | Returns only the incidents associated with the passed service(s). This expects one or more service IDs. (optional) 
            var teamIds = new List<string>(); // List<string> | An array of team IDs. Only results related to these teams will be returned. Account must have the `teams` ability to use this parameter. (optional) 
            var userIds = new List<string>(); // List<string> | Returns only the incidents currently assigned to the passed user(s). This expects one or more user IDs. Note: When using the assigned_to_user filter, you will only receive incidents with statuses of triggered or acknowledged. This is because resolved incidents are not assigned to any user. (optional) 
            var urgencies = urgencies_example;  // string | Array of the urgencies of the incidents to be returned. Defaults to all urgencies. Account must have the `urgencies` ability to do this. (optional) 
            var timeZone = timeZone_example;  // string | Time zone in which dates in the result will be rendered. (optional)  (default to UTC)
            var statuses = statuses_example;  // string | Return only incidents with the given statuses. To query multiple statuses, pass `statuses[]` more than once, for example: `https://api.pagerduty.com/incidents?statuses[]=triggered&statuses[]=acknowledged`. (More status codes may be introduced in the future.) (optional) 
            var sortBy = new List<string>(); // List<string> | Used to specify both the field you wish to sort the results on (incident_number/created_at/resolved_at/urgency), as well as the direction (asc/desc) of the results. The sort_by field and direction should be separated by a colon. A maximum of two fields can be included, separated by a comma. Sort direction defaults to ascending. The account must have the `urgencies` ability to sort by the urgency. (optional) 
            var include = include_example;  // string | Array of additional details to include. (optional) 
            var since = since_example;  // string | The start of the date range over which you want to search. Maximum range is 6 months and default is 1 month. (optional) 
            var until = until_example;  // string | The end of the date range over which you want to search. Maximum range is 6 months and default is 1 month. (optional) 

            try
            {
                // List incidents
                Object result = apiInstance.ListIncidents(accept, contentType, authorization, limit, offset, total, dateRange, incidentKey, serviceIds, teamIds, userIds, urgencies, timeZone, statuses, sortBy, include, since, until);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.ListIncidents: " + e.Message );
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
 **dateRange** | **string**| When set to all, the since and until parameters and defaults are ignored. | [optional] 
 **incidentKey** | **string**| Incident de-duplication key. Incidents with child alerts do not have an incident key; querying by incident key will return incidents whose alerts have alert_key matching the given incident key. | [optional] 
 **serviceIds** | [**List&lt;string&gt;**](string.md)| Returns only the incidents associated with the passed service(s). This expects one or more service IDs. | [optional] 
 **teamIds** | [**List&lt;string&gt;**](string.md)| An array of team IDs. Only results related to these teams will be returned. Account must have the &#x60;teams&#x60; ability to use this parameter. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| Returns only the incidents currently assigned to the passed user(s). This expects one or more user IDs. Note: When using the assigned_to_user filter, you will only receive incidents with statuses of triggered or acknowledged. This is because resolved incidents are not assigned to any user. | [optional] 
 **urgencies** | **string**| Array of the urgencies of the incidents to be returned. Defaults to all urgencies. Account must have the &#x60;urgencies&#x60; ability to do this. | [optional] 
 **timeZone** | **string**| Time zone in which dates in the result will be rendered. | [optional] [default to UTC]
 **statuses** | **string**| Return only incidents with the given statuses. To query multiple statuses, pass &#x60;statuses[]&#x60; more than once, for example: &#x60;https://api.pagerduty.com/incidents?statuses[]&#x3D;triggered&amp;statuses[]&#x3D;acknowledged&#x60;. (More status codes may be introduced in the future.) | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Used to specify both the field you wish to sort the results on (incident_number/created_at/resolved_at/urgency), as well as the direction (asc/desc) of the results. The sort_by field and direction should be separated by a colon. A maximum of two fields can be included, separated by a comma. Sort direction defaults to ascending. The account must have the &#x60;urgencies&#x60; ability to sort by the urgency. | [optional] 
 **include** | **string**| Array of additional details to include. | [optional] 
 **since** | **string**| The start of the date range over which you want to search. Maximum range is 6 months and default is 1 month. | [optional] 
 **until** | **string**| The end of the date range over which you want to search. Maximum range is 6 months and default is 1 month. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mergeincidents"></a>
# **MergeIncidents**
> Object MergeIncidents (string accept, string contentType, string authorization, string from, string id, Object body = null)

Merge incidents

Merge a list of source incidents into this incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class MergeIncidentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Merge incidents
                Object result = apiInstance.MergeIncidents(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.MergeIncidents: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putincidentmanualbusinessserviceassociation"></a>
# **PutIncidentManualBusinessServiceAssociation**
> Object PutIncidentManualBusinessServiceAssociation (string accept, string X_EARLY_ACCESS, string id, string businessServiceId, Object body = null)

Manually change an Incident's Impact on a Business Service.

Change Impact of an Incident on a Business Service.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class PutIncidentManualBusinessServiceAssociationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header with the value `business-impact-early-access`. Do not use this endpoint in production, as it may change! (default to business-impact-early-access)
            var id = id_example;  // string | The ID of the resource.
            var businessServiceId = businessServiceId_example;  // string | The business service ID.
            var body = new Object(); // Object | The `impacted` relation will cause the Business Service and any Services that it supports to become impacted by this incident.

The `not_impacted` relation will remove the Incident's Impact from the specified Business Service.

The effect of adding or removing Impact to a Business Service in this way will also change the propagation of Impact to other Services supported by that Business Service. (optional) 

            try
            {
                // Manually change an Incident's Impact on a Business Service.
                Object result = apiInstance.PutIncidentManualBusinessServiceAssociation(accept, X_EARLY_ACCESS, id, businessServiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.PutIncidentManualBusinessServiceAssociation: " + e.Message );
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
 **id** | **string**| The ID of the resource. | 
 **businessServiceId** | **string**| The business service ID. | 
 **body** | [**Object**](Object.md)| The &#x60;impacted&#x60; relation will cause the Business Service and any Services that it supports to become impacted by this incident.

The &#x60;not_impacted&#x60; relation will remove the Incident&#x27;s Impact from the specified Business Service.

The effect of adding or removing Impact to a Business Service in this way will also change the propagation of Impact to other Services supported by that Business Service. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeincidentnotificationsubscribers"></a>
# **RemoveIncidentNotificationSubscribers**
> Object RemoveIncidentNotificationSubscribers (string accept, string id, Object body = null)

Remove Notification Subscriber

Unsubscribes the matching Subscribers from Incident Status Update Notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class RemoveIncidentNotificationSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object | The entities to unsubscribe. (optional) 

            try
            {
                // Remove Notification Subscriber
                Object result = apiInstance.RemoveIncidentNotificationSubscribers(accept, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.RemoveIncidentNotificationSubscribers: " + e.Message );
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
<a name="setincidentfieldvalues"></a>
# **SetIncidentFieldValues**
> Object SetIncidentFieldValues (string id, Object body = null)

Set Incident Field Values

Set field values for an incident  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class SetIncidentFieldValuesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Set Incident Field Values
                Object result = apiInstance.SetIncidentFieldValues(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.SetIncidentFieldValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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
<a name="updateincident"></a>
# **UpdateIncident**
> Object UpdateIncident (string accept, string contentType, string authorization, string from, string id, Object body = null)

Update an incident

Acknowledge, resolve, escalate or reassign an incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateIncidentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update an incident
                Object result = apiInstance.UpdateIncident(accept, contentType, authorization, from, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.UpdateIncident: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateincidentalert"></a>
# **UpdateIncidentAlert**
> Object UpdateIncidentAlert (string accept, string contentType, string authorization, string from, string id, string alertId, Object body = null)

Update an alert

Resolve an alert or associate an alert with a new parent incident.  An incident represents a problem or an issue that needs to be addressed and resolved.  When a service sends an event to PagerDuty, an alert and corresponding incident is triggered in PagerDuty.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateIncidentAlertExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var alertId = alertId_example;  // string | The id of the alert to retrieve.
            var body = new Object(); // Object | The parameters of the alert to update. (optional) 

            try
            {
                // Update an alert
                Object result = apiInstance.UpdateIncidentAlert(accept, contentType, authorization, from, id, alertId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.UpdateIncidentAlert: " + e.Message );
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
 **alertId** | **string**| The id of the alert to retrieve. | 
 **body** | [**Object**](Object.md)| The parameters of the alert to update. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateincidentalerts"></a>
# **UpdateIncidentAlerts**
> Object UpdateIncidentAlerts (string accept, string contentType, string authorization, string from, string id, Object body = null, int? limit = null, int? offset = null, bool? total = null)

Manage alerts

Resolve multiple alerts or associate them with different incidents.  An incident represents a problem or an issue that needs to be addressed and resolved. An alert represents a digital signal that was emitted to PagerDuty by the monitoring systems that detected or identified the issue.  A maximum of 500 alerts may be updated at a time. If more than this number of alerts are given, the API will respond with status 413 (Request Entity Too Large).  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateIncidentAlertsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var id = id_example;  // string | The ID of the resource.
            var body = new Object(); // Object |  (optional) 
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // Manage alerts
                Object result = apiInstance.UpdateIncidentAlerts(accept, contentType, authorization, from, id, body, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.UpdateIncidentAlerts: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 
 **limit** | **int?**| The number of results per page. | [optional] 
 **offset** | **int?**| Offset to start pagination search results. | [optional] 
 **total** | **bool?**| By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  | [optional] [default to false]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateincidents"></a>
# **UpdateIncidents**
> Object UpdateIncidents (string accept, string contentType, string authorization, string from, Object body = null, int? limit = null, int? offset = null, bool? total = null)

Manage incidents

Acknowledge, resolve, escalate or reassign one or more incidents.  An incident represents a problem or an issue that needs to be addressed and resolved.  A maximum of 250 incidents may be updated at a time. If more than this number of incidents are given, the API will respond with status 413 (Request Entity Too Large).  Note: the manage incidents API endpoint is rate limited to 500 requests per minute.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#incidents) 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateIncidentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IncidentsApi();
            var accept = accept_example;  // string | The `Accept` header is used as a versioning header. (default to application/vnd.pagerduty+json;version=2)
            var contentType = contentType_example;  // string |  (default to application/json)
            var authorization = authorization_example;  // string | The `Authorization` header is used as a versioning header. (default to Token token=y_NbAkKc66ryYTWUXYEu)
            var from = from_example;  // string | The email address of a valid user associated with the account making the request.
            var body = new Object(); // Object |  (optional) 
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // Manage incidents
                Object result = apiInstance.UpdateIncidents(accept, contentType, authorization, from, body, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncidentsApi.UpdateIncidents: " + e.Message );
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
 **body** | [**Object**](Object.md)|  | [optional] 
 **limit** | **int?**| The number of results per page. | [optional] 
 **offset** | **int?**| Offset to start pagination search results. | [optional] 
 **total** | **bool?**| By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  | [optional] [default to false]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
