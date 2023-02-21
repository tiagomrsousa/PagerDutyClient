# PagerDuty.ApiClient.Model.CustomFieldsFieldWithOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the resource. | 
**Summary** | **string** | A short-form, server-generated string that provides succinct, important information about an object suitable for primary labeling of an entity in a client. In many cases, this will be identical to &#x60;name&#x60;, though it is not intended to be an identifier. | 
**Self** | **string** | The API show URL at which the object is accessible | 
**Type** | **string** |  | 
**CreatedAt** | **DateTime?** | The date/time the object was created at. | 
**UpdatedAt** | **DateTime?** | The date/time the object was last updated. | 
**Datatype** | [**CustomFieldsFieldValuepropertiesdatatype**](CustomFieldsFieldValuepropertiesdatatype.md) |  | 
**MultiValue** | [**CustomFieldsFieldValuepropertiesmultiValue**](CustomFieldsFieldValuepropertiesmultiValue.md) |  | 
**FixedOptions** | [**CustomFieldsFieldValuepropertiesfixedOptions**](CustomFieldsFieldValuepropertiesfixedOptions.md) |  | 
**FieldOptions** | [**List&lt;CustomFieldsFieldOption&gt;**](CustomFieldsFieldOption.md) | The fixed list of value options that may be stored in this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

