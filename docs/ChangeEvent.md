# PagerDuty.ApiClient.Model.ChangeEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime?** | The time at which the emitting tool detected or generated the event. | [optional] 
**Type** | **string** | The type of object being created. | [optional] [default to TypeEnum.Changeevent]
**Services** | [**List&lt;ServiceReference&gt;**](ServiceReference.md) | An array containing Service objects that this change event is associated with. | [optional] 
**Integration** | **Object** |  | [optional] 
**RoutingKey** | **string** | This is the 32 character Integration Key for an Integration on a Service. The same Integration Key can be used for both alert and change events. | [optional] 
**Summary** | **string** | A brief text summary of the event. Displayed in PagerDuty to provide information about the change. The maximum permitted length of this property is 1024 characters. | [optional] 
**Source** | **string** | The unique name of the location where the Change Event occurred. | [optional] 
**Links** | **List&lt;Object&gt;** | List of links to include. | [optional] 
**Images** | **List&lt;Object&gt;** |  | [optional] 
**CustomDetails** | **Object** | Additional details about the change event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

