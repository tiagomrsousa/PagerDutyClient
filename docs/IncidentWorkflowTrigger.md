# PagerDuty.ApiClient.Model.IncidentWorkflowTrigger
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**TriggerTypeName** | **string** | Human readable name for the trigger type | [optional] 
**TriggerType** | **string** |  | [optional] 
**Condition** | **string** | A PCL condition string which must be satisfied for the trigger to fire.  Required if trigger_type is “conditional”, not allowed if trigger_type is “manual”  | [optional] 
**TriggerUrl** | **string** |  | [optional] 
**Workflow** | **Object** | Workflow to start when this trigger is invoked | [optional] 
**Services** | **List&lt;Object&gt;** | An optional array of Services associated with this workflow. Incidents in any of the listed Services are eligible to fire this Trigger | [optional] 
**IsSubscribedToAllServices** | **bool?** | Indicates that the Trigger should be associated with All Services | [optional] 
**Permissions** | **Object** | An object detailing who can start this Trigger. Applicable only to manual Triggers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

