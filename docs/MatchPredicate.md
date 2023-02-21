# PagerDuty.ApiClient.Model.MatchPredicate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Matcher** | **string** | Required if the type is &#x60;contains&#x60;, &#x60;exactly&#x60; or &#x60;regex&#x60;. | [optional] 
**Part** | **string** | The email field that will attempt to use the matcher expression. Required if the type is &#x60;contains&#x60;, &#x60;exactly&#x60; or &#x60;regex&#x60;. | 
**Children** | [**List&lt;MatchPredicate&gt;**](MatchPredicate.md) | Additional matchers to be run. Must be not empty if the type is &#x60;all&#x60;, &#x60;any&#x60;, or &#x60;not&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

