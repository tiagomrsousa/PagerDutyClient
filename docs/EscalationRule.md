# PagerDuty.ApiClient.Model.EscalationRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**EscalationDelayInMinutes** | **int?** | The number of minutes before an unacknowledged incident escalates away from this rule. | 
**Targets** | [**List&lt;EscalationTargetReference&gt;**](EscalationTargetReference.md) | The targets an incident should be assigned to upon reaching this rule. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

