# PagerDuty.ApiClient.Model.Oncall
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EscalationPolicy** | [**EscalationPolicyReference**](EscalationPolicyReference.md) |  | [optional] 
**User** | [**UserReference**](UserReference.md) |  | [optional] 
**Schedule** | [**ScheduleReference**](ScheduleReference.md) |  | [optional] 
**EscalationLevel** | **int?** | The escalation level for the on-call. | [optional] 
**Start** | **DateTime?** | The start of the on-call. If &#x60;null&#x60;, the on-call is a permanent user on-call. | [optional] 
**End** | **DateTime?** | The end of the on-call. If &#x60;null&#x60;, the user does not go off-call. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

