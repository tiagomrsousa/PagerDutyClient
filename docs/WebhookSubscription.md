# PagerDuty.ApiClient.Model.WebhookSubscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Type** | **string** | The type indicating the schema of the object. | [default to TypeEnum.Webhooksubscription]
**Active** | **bool?** | Determines whether this subscription will produce webhook events. | [optional] [default to true]
**DeliveryMethod** | **Object** |  | 
**Description** | **string** | A short description of the webhook subscription. | [optional] 
**Events** | **List&lt;string&gt;** | The set of outbound event types the webhook will receive. | 
**Filter** | **Object** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

