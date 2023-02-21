# PagerDuty.ApiClient.Model.WebhooksV1IncidentData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**IncidentNumber** | **int?** | The number of the incident. This is unique across the account. | [optional] 
**CreatedOn** | **DateTime?** | The date/time the incident was first triggered. | [optional] 
**Status** | **string** | The current status of the incident. | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**IncidentKey** | **string** | The incident&#x27;s de-duplication key. | [optional] 
**Service** | [**WebhooksV1Service**](WebhooksV1Service.md) |  | [optional] 
**AssignedToUser** | [**WebhooksV1AssignedToUser**](WebhooksV1AssignedToUser.md) |  | [optional] 
**AssignedTo** | [**List&lt;WebhooksV1AssignedTo&gt;**](WebhooksV1AssignedTo.md) |  | [optional] 
**TriggerSummaryData** | **Object** |  | [optional] 
**TriggerDetailsHtmlUrl** | **string** |  | [optional] 
**LastStatusChangeOn** | **DateTime?** | The time at which the status of the incident last changed. | [optional] 
**LastStatusChangeBy** | [**WebhooksV1AssignedToUser**](WebhooksV1AssignedToUser.md) |  | [optional] 
**NumberOfEscalations** | **int?** | Number of times the incident has been escalated. | [optional] 
**Urgency** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

