# PagerDuty.ApiClient.Model.AuditRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Self** | **string** | Record URL. | [optional] 
**ExecutionTime** | **DateTime?** | The date/time the action executed, in ISO8601 format and millisecond precision. | 
**ExecutionContext** | **Object** | Action execution context | [optional] 
**Actors** | [**List&lt;Reference&gt;**](Reference.md) |  | [optional] 
**Method** | **Object** | The method information | 
**RootResource** | [**Reference**](Reference.md) |  | 
**Action** | **string** |  | 
**Details** | **Object** | Additional details to provide further information about the action or the resource that has been audited.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

