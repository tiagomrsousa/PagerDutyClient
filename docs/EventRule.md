# PagerDuty.ApiClient.Model.EventRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Position** | **int?** | Position/index of the Event Rule in the Ruleset.  Starting from position 0 (the first rule), rules are evaluated one-by-one until a matching rule is found. | [optional] 
**CatchAll** | **bool?** | Indicates whether the Event Rule is the last Event Rule of the Ruleset that serves as a catch-all. It has limited functionality compared to other rules and always matches. | [optional] 
**Actions** | **Object** | When an event matches this rule, the actions that will be taken to change the resulting alert and incident. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

