# PagerDuty.ApiClient.Model.MaintenanceWindow
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of object being created. | [default to TypeEnum.Maintenancewindow]
**SequenceNumber** | **int?** | The order in which the maintenance window was created. | [optional] 
**StartTime** | **DateTime?** | This maintenance window&#x27;s start time. This is when the services will stop creating incidents. If this date is in the past, it will be updated to be the current time. | 
**EndTime** | **DateTime?** | This maintenance window&#x27;s end time. This is when the services will start creating incidents again. This date must be in the future and after the &#x60;start_time&#x60;. | 
**Description** | **string** | A description for this maintenance window. | [optional] 
**CreatedBy** | [**UserReference**](UserReference.md) |  | [optional] 
**Services** | [**List&lt;ServiceReference&gt;**](ServiceReference.md) |  | 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

