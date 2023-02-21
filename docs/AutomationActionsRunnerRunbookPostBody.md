# PagerDuty.ApiClient.Model.AutomationActionsRunnerRunbookPostBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunbookBaseUri** | **string** | The base URI of the Runbook server to connect to. May only contain alphanumeric characters, periods, underscores and dashes. If omitted, the previously stored value will remain unchanged. | [optional] 
**RunbookApiKey** | **string** | The API key to connect to the Runbook server with. If omitted, the previously stored value will remain unchanged. | [optional] 
**RunnerType** | [**AutomationActionsRunnerTypeEnum**](AutomationActionsRunnerTypeEnum.md) |  | 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | The list of teams associated with the Runner | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

