# PagerDuty.ApiClient.Model.NotificationRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of object being created. | [default to TypeEnum.Assignmentnotificationrule]
**StartDelayInMinutes** | **int?** | The delay before firing the rule, in minutes. | 
**ContactMethod** | [**ContactMethodReference**](ContactMethodReference.md) |  | 
**Urgency** | **string** | Which incident urgency this rule is used for. Account must have the &#x60;urgencies&#x60; ability to have a low urgency notification rule. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

