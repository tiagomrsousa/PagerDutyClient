# PagerDuty.ApiClient.Model.RelatedIncidentMachineLearningRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupingClassification** | **string** | The classification for why this Related Incident was grouped into this group. Values can be one of: [similar_contents, prior_feedback], where: similar_contents - The Related Incident was due to similar contents of the Incidents. prior_feedback - The Related Incident was determined to be related, based on User feedback or Incident merge/unmerge actions.  | [optional] 
**UserFeedback** | **Object** | The feedback provided from Users to influence the machine learning algorithm for future Related Incidents. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

