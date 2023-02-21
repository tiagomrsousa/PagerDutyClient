# PagerDuty.ApiClient.Model.EventRuleActionsCommon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Annotate** | **Object** | Set a note on the resulting incident. | [optional] 
**EventAction** | **Object** | Set whether the resulting alert status is trigger or resolve. | [optional] 
**Extractions** | **List&lt;OneOfEventRuleActionsCommonExtractionsItems&gt;** | Dynamically extract values to set and modify new and existing PD-CEF fields. | [optional] 
**Priority** | **Object** | Set the priority ID for the resulting incident. You can find the priority you want by calling the priorities endpoint. | [optional] 
**Severity** | **Object** | Set the severity of the resulting alert. | [optional] 
**Suppress** | **Object** | Set whether the resulting alert is suppressed. Can optionally be used with a threshold where resulting alerts will be suppressed until the threshold is met in a window of time. If using a threshold the rule must also set a route action. | [optional] 
**Suspend** | **Object** | Set the length of time to suspend the resulting alert before triggering. Rules with a suspend action must also set a route action, and cannot have a suppress with threshold action | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

