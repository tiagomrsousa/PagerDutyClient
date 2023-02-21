# PagerDuty.ApiClient.Api.CustomFieldsApi

All URIs are relative to *https://api.pagerduty.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomFieldsField**](CustomFieldsApi.md#createcustomfieldsfield) | **POST** /customfields/fields | Create a Field
[**CreateCustomFieldsFieldConfiguration**](CustomFieldsApi.md#createcustomfieldsfieldconfiguration) | **POST** /customfields/schemas/{schema_id}/field_configurations | Create a Field Configuration
[**CreateCustomFieldsFieldOption**](CustomFieldsApi.md#createcustomfieldsfieldoption) | **POST** /customfields/fields/{field_id}/field_options | Create a Field Option
[**CreateCustomFieldsSchema**](CustomFieldsApi.md#createcustomfieldsschema) | **POST** /customfields/schemas | Create a Schema
[**CreateCustomFieldsSchemaAssignment**](CustomFieldsApi.md#createcustomfieldsschemaassignment) | **POST** /customfields/schema_assignments | Create a Schema Assignment
[**DeleteCustomFieldsField**](CustomFieldsApi.md#deletecustomfieldsfield) | **DELETE** /customfields/fields/{field_id} | Delete a Field
[**DeleteCustomFieldsFieldConfiguration**](CustomFieldsApi.md#deletecustomfieldsfieldconfiguration) | **DELETE** /customfields/schemas/{schema_id}/field_configurations/{field_configuration_id} | Delete a Field Configuration
[**DeleteCustomFieldsFieldOption**](CustomFieldsApi.md#deletecustomfieldsfieldoption) | **DELETE** /customfields/fields/{field_id}/field_options/{field_option_id} | Delete a Field Option
[**DeleteCustomFieldsSchema**](CustomFieldsApi.md#deletecustomfieldsschema) | **DELETE** /customfields/schemas/{schema_id} | Delete a Schema
[**DeleteSchemaAssignment**](CustomFieldsApi.md#deleteschemaassignment) | **DELETE** /customfields/schema_assignments/{id} | Remove a Schema Assignment
[**GetCustomFieldsField**](CustomFieldsApi.md#getcustomfieldsfield) | **GET** /customfields/fields/{field_id} | Get a Field
[**GetCustomFieldsFieldConfiguration**](CustomFieldsApi.md#getcustomfieldsfieldconfiguration) | **GET** /customfields/schemas/{schema_id}/field_configurations/{field_configuration_id} | Get a Field Configuration
[**GetCustomFieldsFieldOption**](CustomFieldsApi.md#getcustomfieldsfieldoption) | **GET** /customfields/fields/{field_id}/field_options/{field_option_id} | Get Field Option
[**GetCustomFieldsSchema**](CustomFieldsApi.md#getcustomfieldsschema) | **GET** /customfields/schemas/{schema_id} | Get a Schema
[**ListCustomFieldsFieldConfigurations**](CustomFieldsApi.md#listcustomfieldsfieldconfigurations) | **GET** /customfields/schemas/{schema_id}/field_configurations | List Field Configurations
[**ListCustomFieldsFieldOptions**](CustomFieldsApi.md#listcustomfieldsfieldoptions) | **GET** /customfields/fields/{field_id}/field_options | List Field Options
[**ListCustomFieldsFields**](CustomFieldsApi.md#listcustomfieldsfields) | **GET** /customfields/fields | List Fields
[**ListCustomFieldsSchemas**](CustomFieldsApi.md#listcustomfieldsschemas) | **GET** /customfields/schemas | List Schemas
[**ListCustomFieldsSchemasUsingField**](CustomFieldsApi.md#listcustomfieldsschemasusingfield) | **GET** /customfields/fields/{field_id}/schemas | List Schemas using Field
[**ListSchemaAssignments**](CustomFieldsApi.md#listschemaassignments) | **GET** /customfields/schema_assignments | List Schema Assignments
[**UpdateCustomFieldsField**](CustomFieldsApi.md#updatecustomfieldsfield) | **PUT** /customfields/fields/{field_id} | Update a Field
[**UpdateCustomFieldsFieldConfiguration**](CustomFieldsApi.md#updatecustomfieldsfieldconfiguration) | **PUT** /customfields/schemas/{schema_id}/field_configurations/{field_configuration_id} | Update a Field Configuration
[**UpdateCustomFieldsFieldOption**](CustomFieldsApi.md#updatecustomfieldsfieldoption) | **PUT** /customfields/fields/{field_id}/field_options/{field_option_id} | Update a Field Option
[**UpdateCustomFieldsSchema**](CustomFieldsApi.md#updatecustomfieldsschema) | **PUT** /customfields/schemas/{schema_id} | Update a Schema

<a name="createcustomfieldsfield"></a>
# **CreateCustomFieldsField**
> Object CreateCustomFieldsField (string X_EARLY_ACCESS, Object body = null)

Create a Field

Create a new Field, along with the Field Options if provided. An account may have up to 1000 Fields.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateCustomFieldsFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Field
                Object result = apiInstance.CreateCustomFieldsField(X_EARLY_ACCESS, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomFieldsField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcustomfieldsfieldconfiguration"></a>
# **CreateCustomFieldsFieldConfiguration**
> Object CreateCustomFieldsFieldConfiguration (string X_EARLY_ACCESS, string schemaId, Object body = null)

Create a Field Configuration

Add a new Field Configuration to an existing Schema. A Schema may use at most 20 Fields, and so may have at most 20 Field Configurations.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateCustomFieldsFieldConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Field Configuration
                Object result = apiInstance.CreateCustomFieldsFieldConfiguration(X_EARLY_ACCESS, schemaId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomFieldsFieldConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **schemaId** | **string**| The ID of the schema. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcustomfieldsfieldoption"></a>
# **CreateCustomFieldsFieldOption**
> Object CreateCustomFieldsFieldOption (string X_EARLY_ACCESS, string fieldId, Object body = null)

Create a Field Option

Create a new Field Option. Field Options may only be created for Fields where `fixed_options` is `true`. A Field may have no more than 10 enabled options.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateCustomFieldsFieldOptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var fieldId = fieldId_example;  // string | The ID of the field.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Field Option
                Object result = apiInstance.CreateCustomFieldsFieldOption(X_EARLY_ACCESS, fieldId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomFieldsFieldOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **fieldId** | **string**| The ID of the field. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcustomfieldsschema"></a>
# **CreateCustomFieldsSchema**
> Object CreateCustomFieldsSchema (string X_EARLY_ACCESS, Object body = null)

Create a Schema

Create a new Schema, along with the Field Configurations if provided. An account may have up to 100 Schemas.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateCustomFieldsSchemaExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Schema
                Object result = apiInstance.CreateCustomFieldsSchema(X_EARLY_ACCESS, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomFieldsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcustomfieldsschemaassignment"></a>
# **CreateCustomFieldsSchemaAssignment**
> Object CreateCustomFieldsSchemaAssignment (string X_EARLY_ACCESS, Object body = null)

Create a Schema Assignment

Assign a new Schema to a service  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class CreateCustomFieldsSchemaAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create a Schema Assignment
                Object result = apiInstance.CreateCustomFieldsSchemaAssignment(X_EARLY_ACCESS, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.CreateCustomFieldsSchemaAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecustomfieldsfield"></a>
# **DeleteCustomFieldsField**
> void DeleteCustomFieldsField (string fieldId, string X_EARLY_ACCESS)

Delete a Field

Delete a Field. Fields may not be deleted if they are used by a Field Schema.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteCustomFieldsFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var fieldId = fieldId_example;  // string | The ID of the field.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Delete a Field
                apiInstance.DeleteCustomFieldsField(fieldId, X_EARLY_ACCESS);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteCustomFieldsField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| The ID of the field. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecustomfieldsfieldconfiguration"></a>
# **DeleteCustomFieldsFieldConfiguration**
> void DeleteCustomFieldsFieldConfiguration (string schemaId, string fieldConfigurationId, string X_EARLY_ACCESS)

Delete a Field Configuration

Remove a Field Configuration and its associated Field from a Schema.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteCustomFieldsFieldConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var fieldConfigurationId = fieldConfigurationId_example;  // string | The ID of the field configuration.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Delete a Field Configuration
                apiInstance.DeleteCustomFieldsFieldConfiguration(schemaId, fieldConfigurationId, X_EARLY_ACCESS);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteCustomFieldsFieldConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**| The ID of the schema. | 
 **fieldConfigurationId** | **string**| The ID of the field configuration. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecustomfieldsfieldoption"></a>
# **DeleteCustomFieldsFieldOption**
> void DeleteCustomFieldsFieldOption (string fieldId, string fieldOptionId, string X_EARLY_ACCESS)

Delete a Field Option

Delete a Field Option.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteCustomFieldsFieldOptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var fieldId = fieldId_example;  // string | The ID of the field.
            var fieldOptionId = fieldOptionId_example;  // string | The ID of the field option.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Delete a Field Option
                apiInstance.DeleteCustomFieldsFieldOption(fieldId, fieldOptionId, X_EARLY_ACCESS);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteCustomFieldsFieldOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| The ID of the field. | 
 **fieldOptionId** | **string**| The ID of the field option. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecustomfieldsschema"></a>
# **DeleteCustomFieldsSchema**
> void DeleteCustomFieldsSchema (string schemaId, string X_EARLY_ACCESS)

Delete a Schema

Delete a Schema. Schemas may not be deleted if they are in use by any Service.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteCustomFieldsSchemaExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Delete a Schema
                apiInstance.DeleteCustomFieldsSchema(schemaId, X_EARLY_ACCESS);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteCustomFieldsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**| The ID of the schema. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteschemaassignment"></a>
# **DeleteSchemaAssignment**
> void DeleteSchemaAssignment (string id, string X_EARLY_ACCESS)

Remove a Schema Assignment

Remove the Schema assigned to a service  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class DeleteSchemaAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var id = id_example;  // string | The ID of the resource.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Remove a Schema Assignment
                apiInstance.DeleteSchemaAssignment(id, X_EARLY_ACCESS);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.DeleteSchemaAssignment: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcustomfieldsfield"></a>
# **GetCustomFieldsField**
> Object GetCustomFieldsField (string fieldId, string X_EARLY_ACCESS, string include = null)

Get a Field

Show detailed information about a field.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetCustomFieldsFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var fieldId = fieldId_example;  // string | The ID of the field.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // Get a Field
                Object result = apiInstance.GetCustomFieldsField(fieldId, X_EARLY_ACCESS, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetCustomFieldsField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| The ID of the field. | 
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
<a name="getcustomfieldsfieldconfiguration"></a>
# **GetCustomFieldsFieldConfiguration**
> Object GetCustomFieldsFieldConfiguration (string schemaId, string fieldConfigurationId, string X_EARLY_ACCESS, string include = null)

Get a Field Configuration

Show detailed information about a Field Configuration.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetCustomFieldsFieldConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var fieldConfigurationId = fieldConfigurationId_example;  // string | The ID of the field configuration.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // Get a Field Configuration
                Object result = apiInstance.GetCustomFieldsFieldConfiguration(schemaId, fieldConfigurationId, X_EARLY_ACCESS, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetCustomFieldsFieldConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**| The ID of the schema. | 
 **fieldConfigurationId** | **string**| The ID of the field configuration. | 
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
<a name="getcustomfieldsfieldoption"></a>
# **GetCustomFieldsFieldOption**
> Object GetCustomFieldsFieldOption (string fieldId, string fieldOptionId, string X_EARLY_ACCESS)

Get Field Option

Get a Field Option.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetCustomFieldsFieldOptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var fieldId = fieldId_example;  // string | The ID of the field.
            var fieldOptionId = fieldOptionId_example;  // string | The ID of the field option.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // Get Field Option
                Object result = apiInstance.GetCustomFieldsFieldOption(fieldId, fieldOptionId, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetCustomFieldsFieldOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| The ID of the field. | 
 **fieldOptionId** | **string**| The ID of the field option. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcustomfieldsschema"></a>
# **GetCustomFieldsSchema**
> Object GetCustomFieldsSchema (string schemaId, string X_EARLY_ACCESS, string include = null)

Get a Schema

Get detailed information about a Schema.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class GetCustomFieldsSchemaExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var include = include_example;  // string | Array of additional details to include. Including `field_configurations` will also include full field details. (optional) 

            try
            {
                // Get a Schema
                Object result = apiInstance.GetCustomFieldsSchema(schemaId, X_EARLY_ACCESS, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetCustomFieldsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**| The ID of the schema. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **include** | **string**| Array of additional details to include. Including &#x60;field_configurations&#x60; will also include full field details. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listcustomfieldsfieldconfigurations"></a>
# **ListCustomFieldsFieldConfigurations**
> Object ListCustomFieldsFieldConfigurations (string schemaId, string X_EARLY_ACCESS, string include = null)

List Field Configurations

List all Field Configurations for the given Schema.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListCustomFieldsFieldConfigurationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // List Field Configurations
                Object result = apiInstance.ListCustomFieldsFieldConfigurations(schemaId, X_EARLY_ACCESS, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListCustomFieldsFieldConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaId** | **string**| The ID of the schema. | 
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
<a name="listcustomfieldsfieldoptions"></a>
# **ListCustomFieldsFieldOptions**
> Object ListCustomFieldsFieldOptions (string fieldId, string X_EARLY_ACCESS)

List Field Options

List all enabled Field Options for a Field.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListCustomFieldsFieldOptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var fieldId = fieldId_example;  // string | The ID of the field.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)

            try
            {
                // List Field Options
                Object result = apiInstance.ListCustomFieldsFieldOptions(fieldId, X_EARLY_ACCESS);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListCustomFieldsFieldOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| The ID of the field. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listcustomfieldsfields"></a>
# **ListCustomFieldsFields**
> Object ListCustomFieldsFields (string X_EARLY_ACCESS, int? limit = null, int? offset = null, bool? total = null, string include = null)

List Fields

List fields.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListCustomFieldsFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)
            var include = include_example;  // string | Array of additional details to include. (optional) 

            try
            {
                // List Fields
                Object result = apiInstance.ListCustomFieldsFields(X_EARLY_ACCESS, limit, offset, total, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListCustomFieldsFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **limit** | **int?**| The number of results per page. | [optional] 
 **offset** | **int?**| Offset to start pagination search results. | [optional] 
 **total** | **bool?**| By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  | [optional] [default to false]
 **include** | **string**| Array of additional details to include. | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listcustomfieldsschemas"></a>
# **ListCustomFieldsSchemas**
> Object ListCustomFieldsSchemas (string X_EARLY_ACCESS, int? limit = null, int? offset = null, bool? total = null)

List Schemas

List all Schemas.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListCustomFieldsSchemasExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // List Schemas
                Object result = apiInstance.ListCustomFieldsSchemas(X_EARLY_ACCESS, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListCustomFieldsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
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
<a name="listcustomfieldsschemasusingfield"></a>
# **ListCustomFieldsSchemasUsingField**
> Object ListCustomFieldsSchemasUsingField (string fieldId, string X_EARLY_ACCESS, int? limit = null, int? offset = null, bool? total = null)

List Schemas using Field

List all Schemas using the Field.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListCustomFieldsSchemasUsingFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var fieldId = fieldId_example;  // string | The ID of the field.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // List Schemas using Field
                Object result = apiInstance.ListCustomFieldsSchemasUsingField(fieldId, X_EARLY_ACCESS, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListCustomFieldsSchemasUsingField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| The ID of the field. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
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
<a name="listschemaassignments"></a>
# **ListSchemaAssignments**
> Object ListSchemaAssignments (Object filter, string X_EARLY_ACCESS, int? limit = null, int? offset = null, bool? total = null)

List Schema Assignments

List Schema Assignments by `service_id` or `schema_id`  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class ListSchemaAssignmentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var filter = new Object(); // Object | One of service_id or schema_id is required.
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var limit = 56;  // int? | The number of results per page. (optional) 
            var offset = 56;  // int? | Offset to start pagination search results. (optional) 
            var total = true;  // bool? | By default the `total` field in pagination responses is set to `null` to provide the fastest possible response times. Set `total` to `true` for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional)  (default to false)

            try
            {
                // List Schema Assignments
                Object result = apiInstance.ListSchemaAssignments(filter, X_EARLY_ACCESS, limit, offset, total);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.ListSchemaAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | [**Object**](Object.md)| One of service_id or schema_id is required. | 
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
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
<a name="updatecustomfieldsfield"></a>
# **UpdateCustomFieldsField**
> Object UpdateCustomFieldsField (string X_EARLY_ACCESS, string fieldId, Object body = null)

Update a Field

Update a field.  <!- - theme: warning - ->  > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateCustomFieldsFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var fieldId = fieldId_example;  // string | The ID of the field.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update a Field
                Object result = apiInstance.UpdateCustomFieldsField(X_EARLY_ACCESS, fieldId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.UpdateCustomFieldsField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **fieldId** | **string**| The ID of the field. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecustomfieldsfieldconfiguration"></a>
# **UpdateCustomFieldsFieldConfiguration**
> Object UpdateCustomFieldsFieldConfiguration (string X_EARLY_ACCESS, string schemaId, string fieldConfigurationId, Object body = null)

Update a Field Configuration

Update settings for Field Configuration in Schema.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateCustomFieldsFieldConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var fieldConfigurationId = fieldConfigurationId_example;  // string | The ID of the field configuration.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update a Field Configuration
                Object result = apiInstance.UpdateCustomFieldsFieldConfiguration(X_EARLY_ACCESS, schemaId, fieldConfigurationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.UpdateCustomFieldsFieldConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **schemaId** | **string**| The ID of the schema. | 
 **fieldConfigurationId** | **string**| The ID of the field configuration. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecustomfieldsfieldoption"></a>
# **UpdateCustomFieldsFieldOption**
> Object UpdateCustomFieldsFieldOption (string X_EARLY_ACCESS, string fieldId, string fieldOptionId, Object body = null)

Update a Field Option

Update Field Option for a Field.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateCustomFieldsFieldOptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var fieldId = fieldId_example;  // string | The ID of the field.
            var fieldOptionId = fieldOptionId_example;  // string | The ID of the field option.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update a Field Option
                Object result = apiInstance.UpdateCustomFieldsFieldOption(X_EARLY_ACCESS, fieldId, fieldOptionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.UpdateCustomFieldsFieldOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **fieldId** | **string**| The ID of the field. | 
 **fieldOptionId** | **string**| The ID of the field option. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecustomfieldsschema"></a>
# **UpdateCustomFieldsSchema**
> Object UpdateCustomFieldsSchema (string X_EARLY_ACCESS, string schemaId, Object body = null)

Update a Schema

Update a Schema, along with the Field Configurations if provided.  <!- - theme: warning - -> > ### Early Access > This endpoint is in Early Access and may change at any time. You must pass in the X-EARLY-ACCESS header to access it. 

### Example
```csharp
using System;
using System.Diagnostics;
using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;

namespace Example
{
    public class UpdateCustomFieldsSchemaExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomFieldsApi();
            var X_EARLY_ACCESS = X_EARLY_ACCESS_example;  // string | This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  (default to flex-service-early-access)
            var schemaId = schemaId_example;  // string | The ID of the schema.
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Update a Schema
                Object result = apiInstance.UpdateCustomFieldsSchema(X_EARLY_ACCESS, schemaId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.UpdateCustomFieldsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **X_EARLY_ACCESS** | **string**| This header indicates that this API endpoint is __UNDER CONSTRUCTION__ and may change at any time. You __MUST__ pass in this header and the above value. Do not use this endpoint in production, as it may change!  | [default to flex-service-early-access]
 **schemaId** | **string**| The ID of the schema. | 
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
