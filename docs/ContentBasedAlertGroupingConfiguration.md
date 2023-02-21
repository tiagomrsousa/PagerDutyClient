# PagerDuty.ApiClient.Model.ContentBasedAlertGroupingConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aggregate** | **string** | Whether Alerts should be grouped if &#x60;all&#x60; or &#x60;any&#x60; specified fields match. If &#x60;all&#x60; is selected, an exact match on every specified field name must occur for Alerts to be grouped. If &#x60;any&#x60; is selected, Alerts will be grouped when there is an exact match on at least one of the specified fields. | [optional] 
**Fields** | **List&lt;string&gt;** | The fields with which to group against. Depending on the aggregate, Alerts will group if some or all the fields match | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

