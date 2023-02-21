# PagerDuty.ApiClient.Model.Alert
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime?** | The date/time the alert was first triggered. | [optional] 
**Type** | **string** | The type of object being created. | [default to TypeEnum.Alert]
**Status** | **string** | The current status of the alert. | [optional] 
**AlertKey** | **string** | The alert&#x27;s de-duplication key. | [optional] 
**Service** | [**ServiceReference**](ServiceReference.md) |  | [optional] 
**FirstTriggerLogEntry** | [**LogEntryReference**](LogEntryReference.md) |  | [optional] 
**Incident** | [**IncidentReference**](IncidentReference.md) |  | [optional] 
**Suppressed** | **bool?** | Whether or not an alert is suppressed. Suppressed alerts are not created with a parent incident. | [optional] [default to false]
**Severity** | **string** | The magnitude of the problem as reported by the monitoring tool. | [optional] 
**Integration** | [**IntegrationReference**](IntegrationReference.md) |  | [optional] 
**Body** | **Object** | A JSON object containing data describing the alert. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

