# PagerDuty.ApiClient.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the user. | 
**Type** | **string** | The type of object being created. | [default to TypeEnum.User]
**Email** | **string** | The user&#x27;s email address. | 
**TimeZone** | **string** | The preferred time zone name. If null, the account&#x27;s time zone will be used. | [optional] 
**Color** | **string** | The schedule color. | [optional] 
**Role** | **string** | The user role. Account must have the &#x60;read_only_users&#x60; ability to set a user as a &#x60;read_only_user&#x60; or a &#x60;read_only_limited_user&#x60;, and must have advanced permissions abilities to set a user as &#x60;observer&#x60; or &#x60;restricted_access&#x60;. | [optional] 
**AvatarUrl** | **string** | The URL of the user&#x27;s avatar. | [optional] 
**Description** | **string** | The user&#x27;s bio. | [optional] 
**InvitationSent** | **bool?** | If true, the user has an outstanding invitation. | [optional] 
**JobTitle** | **string** | The user&#x27;s title. | [optional] 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | The list of teams to which the user belongs. Account must have the &#x60;teams&#x60; ability to set this. | [optional] 
**ContactMethods** | [**List&lt;ContactMethodReference&gt;**](ContactMethodReference.md) | The list of contact methods for the user. | [optional] 
**NotificationRules** | [**List&lt;NotificationRuleReference&gt;**](NotificationRuleReference.md) | The list of notification rules for the user. | [optional] 
**License** | **Object** | The License assigned to the User | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

