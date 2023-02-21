# PagerDuty.ApiClient.Model.Schedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of object being created. | [default to TypeEnum.Schedule]
**ScheduleLayers** | [**List&lt;ScheduleLayer&gt;**](ScheduleLayer.md) | A list of schedule layers. | [optional] 
**TimeZone** | **string** | The time zone of the schedule. | 
**Name** | **string** | The name of the schedule | [optional] 
**Description** | **string** | The description of the schedule | [optional] 
**FinalSchedule** | [**SubSchedule**](SubSchedule.md) |  | [optional] 
**OverridesSubschedule** | [**SubSchedule**](SubSchedule.md) |  | [optional] 
**EscalationPolicies** | [**List&lt;EscalationPolicyReference&gt;**](EscalationPolicyReference.md) | An array of all of the escalation policies that uses this schedule. | [optional] 
**Users** | [**List&lt;UserReference&gt;**](UserReference.md) | An array of all of the users on the schedule. | [optional] 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | An array of all of the teams on the schedule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

