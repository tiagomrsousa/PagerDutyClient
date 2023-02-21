# PagerDuty.ApiClient.Model.Extension
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the extension. | 
**Type** | **string** | The type of object being created. | [optional] [default to TypeEnum.Extension]
**EndpointUrl** | **string** | The url of the extension. | [optional] 
**ExtensionObjects** | [**List&lt;ServiceReference&gt;**](ServiceReference.md) | The objects for which the extension applies | 
**ExtensionSchema** | [**ExtensionSchemaReference**](ExtensionSchemaReference.md) |  | 
**TemporarilyDisabled** | **bool?** | Whether or not this extension is temporarily disabled; for example, a webhook extension that is repeatedly rejected by the server. | [optional] [default to false]
**Config** | **Object** | The object that contains extension configuration values depending on the extension schema specification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

