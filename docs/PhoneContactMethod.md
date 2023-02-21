# PagerDuty.ApiClient.Model.PhoneContactMethod
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of contact method being created. | 
**Label** | **string** | The label (e.g., \&quot;Work\&quot;, \&quot;Mobile\&quot;, etc.). | 
**Address** | **string** | The \&quot;address\&quot; to deliver to: email, phone number, etc., depending on the type. | 
**Type** | **string** |  | [optional] 
**CountryCode** | **int?** | The 1-to-3 digit country calling code. | 
**Enabled** | **bool?** | If true, this phone is capable of receiving SMS messages. | [optional] 
**Blacklisted** | **bool?** | If true, this phone has been blacklisted by PagerDuty and no messages will be sent to it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

