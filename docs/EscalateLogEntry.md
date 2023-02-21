# PagerDuty.ApiClient.Model.EscalateLogEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**CreatedAt** | **DateTime?** | Time at which the log entry was created. | [optional] 
**Channel** | [**Channel**](Channel.md) |  | [optional] 
**Agent** | [**AgentReference**](AgentReference.md) |  | [optional] 
**Note** | **string** | Optional field containing a note, if one was included with the log entry. | [optional] 
**Contexts** | [**List&lt;Context&gt;**](Context.md) | Contexts to be included with the trigger such as links to graphs or images. | [optional] 
**Service** | [**ServiceReference**](ServiceReference.md) |  | [optional] 
**User** | [**UserReference**](UserReference.md) |  | [optional] 
**Incident** | [**IncidentReference**](IncidentReference.md) |  | [optional] 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | Will consist of references unless included | [optional] 
**EventDetails** | **Object** |  | [optional] 
**Assignees** | [**List&lt;UserReference&gt;**](UserReference.md) | An array of assigned Users for this log entry | [optional] 
**Type** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

