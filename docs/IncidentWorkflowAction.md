# PagerDuty.ApiClient.Model.IncidentWorkflowAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**DomainName** | **string** | The Verified Domain of the account that created the action | [optional] 
**PackageName** | **string** | The Package Name corresponding to the broad category of the Action | [optional] 
**FunctionName** | **string** | The Function Name describing the specific functionality of the Action | [optional] 
**Version** | [**decimal?**](BigDecimal.md) | The version of the Action | [optional] 
**Name** | **string** | The descriptive name of the Action | [optional] 
**Description** | **string** | A description of the Action | [optional] 
**ActionType** | **string** | The type of Action | [optional] 
**TriggerType** | **string** | The type of Trigger this Action is, if action_type is trigger | [optional] 
**Tags** | **List&lt;string&gt;** | A set of tags to apply to this action. | [optional] 
**SearchKeywords** | **List&lt;string&gt;** | A set of search keywords to apply to this action. | [optional] 
**Metadata** | **string** | JSON-formatted string of metadata pertaining to the Action | [optional] 
**CreatedAt** | **DateTime?** | The date-time at which this Action was created | [optional] 
**CreatedByUserId** | **string** | The obfuscated Id of the User who created this Action | [optional] 
**Inputs** | **List&lt;Object&gt;** | Inputs whose values used during Action execution | [optional] 
**Outputs** | **List&lt;Object&gt;** | Outputs whose values set during Action execution | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

