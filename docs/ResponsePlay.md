# PagerDuty.ApiClient.Model.ResponsePlay
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of object being created. | [optional] [default to TypeEnum.Responseplay]
**Name** | **string** | The name of the response play. | [optional] 
**Description** | **string** | The description of the response play. | [optional] 
**Team** | **Object** |  | [optional] 
**Subscribers** | **List&lt;Object&gt;** | An array containing the users and/or teams to be added as subscribers to any incident on which this response play is run. | [optional] 
**SubscribersMessage** | **string** | The content of the notification that will be sent to all incident subscribers upon the running of this response play. Note that this includes any users who may have already been subscribed to the incident prior to the running of this response play. If empty, no notifications will be sent. | [optional] 
**Responders** | **List&lt;Object&gt;** | An array containing the users and/or escalation policies to be requested as responders to any incident on which this response play is run. | [optional] 
**RespondersMessage** | **string** | The message body of the notification that will be sent to this response play&#x27;s set of responders. If empty, a default response request notification will be sent. | [optional] 
**Runnability** | **string** | String representing how this response play is allowed to be run. Valid options are:   - &#x60;services&#x60;: This response play cannot be manually run by any users. It will run automatically for new incidents triggered on any services that are configured with this response play.   - &#x60;teams&#x60;: This response play can be run manually on an incident only by members of its configured team. This option can only be selected when the &#x60;team&#x60; property for this response play is not empty.   - &#x60;responders&#x60;: This response play can be run manually on an incident by any responders in this account. | [optional] [default to RunnabilityEnum.Services]
**ConferenceNumber** | **string** | The telephone number that will be set as the conference number for any incident on which this response play is run. | [optional] 
**ConferenceUrl** | **string** | The URL that will be set as the conference URL for any incident on which this response play is run. | [optional] 
**ConferenceType** | **string** | This field has three possible values and indicates how the response play was created.   - &#x60;none&#x60; : The response play had no conference_number or conference_url set at time of creation.   - &#x60;manual&#x60; : The response play had one or both of conference_number and conference_url set at time of creation.   - &#x60;zoom&#x60; : Customers with the Zoom-Integration Entitelment can use this value to dynamicly configure conference number and url for zoom | [optional] [default to ConferenceTypeEnum.None]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

