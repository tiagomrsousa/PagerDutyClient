# PagerDuty.ApiClient.Model.PushContactMethod
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of contact method being created. | 
**Label** | **string** | The label (e.g., \&quot;Work\&quot;, \&quot;Mobile\&quot;, etc.). | 
**Address** | **string** | The \&quot;address\&quot; to deliver to: email, phone number, etc., depending on the type. | 
**Type** | **string** |  | [optional] 
**DeviceType** | **string** | The type of device. | 
**Sounds** | [**List&lt;PushContactMethodSound&gt;**](PushContactMethodSound.md) |  | [optional] 
**CreatedAt** | **DateTime?** | Time at which the contact method was created. | [optional] 
**Blacklisted** | **bool?** | If true, this phone has been blacklisted by PagerDuty and no messages will be sent to it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

