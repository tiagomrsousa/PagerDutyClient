# PagerDuty.ApiClient.Model.IncidentUrgencyRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of incident urgency: whether it&#x27;s constant, or it&#x27;s dependent on the support hours. | [optional] [default to TypeEnum.Constant]
**Urgency** | **string** | The incidents&#x27; urgency, if type is constant. | [optional] [default to UrgencyEnum.High]
**DuringSupportHours** | [**IncidentUrgencyType**](IncidentUrgencyType.md) |  | [optional] 
**OutsideSupportHours** | [**IncidentUrgencyType**](IncidentUrgencyType.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

