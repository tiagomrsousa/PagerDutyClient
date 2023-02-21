# PagerDuty.ApiClient.Model.EscalationPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of object being created. | [default to TypeEnum.Escalationpolicy]
**Name** | **string** | The name of the escalation policy. | 
**Description** | **string** | Escalation policy description. | [optional] 
**NumLoops** | **int?** | The number of times the escalation policy will repeat after reaching the end of its escalation. | [optional] [default to 0]
**OnCallHandoffNotifications** | **string** | Determines how on call handoff notifications will be sent for users on the escalation policy. Defaults to \&quot;if_has_services\&quot;. | [optional] 
**EscalationRules** | [**List&lt;EscalationRule&gt;**](EscalationRule.md) |  | 
**Services** | [**List&lt;ServiceReference&gt;**](ServiceReference.md) |  | [optional] 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | Teams associated with the policy. Account must have the &#x60;teams&#x60; ability to use this parameter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

