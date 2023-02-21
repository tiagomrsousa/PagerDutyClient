# PagerDuty.ApiClient.Model.WebhookIncidentAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | Uniquely identifies this outgoing webhook message; can be used for idempotency when processing the messages. | [optional] 
**TriggeredAt** | **DateTime?** | The date/time when this message was was sent. | [optional] 
**Webhook** | [**Webhook**](Webhook.md) |  | [optional] 
**Type** | **string** | The type of action being reported by this message. * &#x60;incident.trigger&#x60; - Sent when an incident is newly created/triggered. * &#x60;incident.acknowledge&#x60; - Sent when an incident is acknowledged by a user. * &#x60;incident.unacknowledge&#x60; - Sent when an incident is unacknowledged due to its acknowledgement timing out. * &#x60;incident.resolve&#x60; - Sent when an incident has been resolved. * &#x60;incident.assign&#x60; - Sent when an incident has been assigned to another user. Often occurs in concert with an &#x60;acknowledge&#x60;. * &#x60;incident.escalate&#x60; - Sent when an incident has been escalated to another user in the same escalation chain. * &#x60;incident.delegate&#x60; - Sent when an incident has been reassigned to another escalation policy. * &#x60;incident.annotate&#x60; - Sent when a note is created on an incident.  | [optional] 
**Incident** | [**Incident**](Incident.md) |  | [optional] 
**LogEntries** | [**List&lt;LogEntry&gt;**](LogEntry.md) | Log Entries that correspond to the action this Webhook is reporting. Includes the channels. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

