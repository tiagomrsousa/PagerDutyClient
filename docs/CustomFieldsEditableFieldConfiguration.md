# PagerDuty.ApiClient.Model.CustomFieldsEditableFieldConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultValue** | **AllOfCustomFieldsEditableFieldConfigurationDefaultValue** | The value to use for this field if none is provided. It must be specified if &#x60;required&#x60; is &#x60;true&#x60;, and may not be specified otherwise. | [optional] 
**Id** | **string** | The ID of the resource. | [optional] 
**Type** | **string** | A string that determines the schema of the object. This must be the standard name for the entity, suffixed by &#x60;_reference&#x60; if the object is a reference. | [optional] 
**CreatedAt** | **DateTime?** | The date/time the object was created at. | [optional] 
**UpdatedAt** | **DateTime?** | The date/time the object was last updated. | [optional] 
**Required** | **bool?** | If &#x60;true&#x60;, this Field must always have a value set for objects using this schema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

