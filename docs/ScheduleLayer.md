# PagerDuty.ApiClient.Model.ScheduleLayer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Start** | **DateTime?** | The start time of this layer. | 
**End** | **DateTime?** | The end time of this layer. If &#x60;null&#x60;, the layer does not end. | [optional] 
**Users** | [**List&lt;ScheduleLayerUser&gt;**](ScheduleLayerUser.md) | The ordered list of users on this layer. The position of the user on the list determines their order in the layer. | 
**Restrictions** | [**List&lt;Restriction&gt;**](Restriction.md) | An array of restrictions for the layer. A restriction is a limit on which period of the day or week the schedule layer can accept assignments. | [optional] 
**RotationVirtualStart** | **DateTime?** | The effective start time of the layer. This can be before the start time of the schedule. | 
**RotationTurnLengthSeconds** | **int?** | The duration of each on-call shift in seconds. | 
**Name** | **string** | The name of the schedule layer. | [optional] 
**RenderedScheduleEntries** | [**List&lt;ScheduleLayerEntry&gt;**](ScheduleLayerEntry.md) | This is a list of entries on the computed layer for the current time range. Since or until must be set in order for this field to be populated. | [optional] 
**RenderedCoveragePercentage** | [**decimal?**](BigDecimal.md) | The percentage of the time range covered by this layer. Returns null unless since or until are set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

