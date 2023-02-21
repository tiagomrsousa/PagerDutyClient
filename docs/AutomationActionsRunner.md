# PagerDuty.ApiClient.Model.AutomationActionsRunner
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunnerType** | [**AutomationActionsRunnerTypeEnum**](AutomationActionsRunnerTypeEnum.md) |  | 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**LastSeen** | **DateTime?** |  | [optional] 
**Status** | [**AutomationActionsRunnerStatusEnum**](AutomationActionsRunnerStatusEnum.md) |  | 
**CreationTime** | **DateTime?** |  | 
**RunbookBaseUri** | **string** |  | [optional] 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | The list of teams associated with the Runner | [optional] 
**Privileges** | [**AutomationActionsUserPermissions**](AutomationActionsUserPermissions.md) |  | [optional] 
**AssociatedActions** | **Object** | References to at most 3 actions associated with the Runner. Use appropriate endpoints to retrieve the full list of associated actions. | [optional] 
**Metadata** | **Object** | Additional metadata | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

