# PagerDuty.ApiClient.Model.IncidentAddon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of Add-on. | 
**Name** | **string** | The name of the Add-on. | 
**Src** | **string** | The source URL to display in a frame in the PagerDuty UI. HTTPS is required. | 
**Services** | [**List&lt;ServiceReference&gt;**](ServiceReference.md) | The services this Add-on is associated with. If non-empty, the Add-on will appear only on incidents for those services. If empty, it will appear on incidents for all services.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

