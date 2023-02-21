# PagerDuty.ApiClient.Model.SubSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the subschedule | 
**RenderedScheduleEntries** | [**List&lt;ScheduleLayerEntry&gt;**](ScheduleLayerEntry.md) | This is a list of entries on the computed layer for the current time range. Since or until must be set in order for this field to be populated. | [optional] 
**RenderedCoveragePercentage** | [**decimal?**](BigDecimal.md) | The percentage of the time range covered by this layer. Returns null unless since or until are set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

