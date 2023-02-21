# PagerDuty.ApiClient.Model.CustomFieldsFieldValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the field. | 
**Name** | **string** | The name of the field. May include ASCII characters, specifically lowercase letters, digits, and underescores. The &#x60;name&#x60; for a Field must be unique. | 
**Type** | **string** | Determines the type of the reference. | 
**DisplayName** | **string** | The human-readable name of the field. This must be unique across an account. | 
**MultiValue** | **bool?** | If &#x60;true&#x60;, allows the custom field to store a set of multiple values. Must be &#x60;false&#x60; if &#x60;datatype&#x60; is not \&quot;string\&quot; or \&quot;url\&quot; | 
**Datatype** | **string** | The kind of data the custom field is allowed to contain. | 
**Description** | **string** | A description of the data this field contains. | 
**FixedOptions** | **bool?** | If &#x60;true&#x60;, restricts the values allowed to be stored in the custom field to a limited set of options (configured via the Field Option sub-resource). Must be &#x60;false&#x60; if &#x60;datatype&#x60; is \&quot;boolean\&quot;, \&quot;url\&quot;, or \&quot;datetime\&quot; | 
**Value** | **OneOfCustomFieldsFieldValueValue** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

