# PagerDuty.ApiClient.Model.Integration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Name** | **string** | The name of this integration. | [optional] 
**Service** | [**ServiceReference**](ServiceReference.md) |  | [optional] 
**CreatedAt** | **DateTime?** | The date/time when this integration was created. | [optional] 
**Vendor** | [**VendorReference**](VendorReference.md) |  | [optional] 
**IntegrationEmail** | **string** | Specify for generic_email_inbound_integration. Must be set to an email address @your-subdomain.pagerduty.com | [optional] 
**EmailIncidentCreation** | **string** | Specify for generic_email_inbound_integration | [optional] 
**EmailFilterMode** | **string** | Specify for generic_email_inbound_integration. May override email_incident_creation | [optional] 
**EmailParsers** | [**List&lt;EmailParser&gt;**](EmailParser.md) | Specify for generic_email_inbound_integration. | [optional] 
**EmailParsingFallback** | **string** | Specify for generic_email_inbound_integration. | [optional] 
**EmailFilters** | **List&lt;Object&gt;** | Specify for generic_email_inbound_integration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

