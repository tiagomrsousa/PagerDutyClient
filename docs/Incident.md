# PagerDuty.ApiClient.Model.Incident
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentNumber** | **int?** | The number of the incident. This is unique across your account. | [optional] 
**CreatedAt** | **DateTime?** | The date/time the incident was first triggered. | [optional] 
**Status** | **string** | The current status of the incident. | [optional] 
**Title** | **string** | A succinct description of the nature, symptoms, cause, or effect of the incident. | [optional] 
**PendingActions** | [**List&lt;IncidentAction&gt;**](IncidentAction.md) | The list of pending_actions on the incident. A pending_action object contains a type of action which can be escalate, unacknowledge, resolve or urgency_change. A pending_action object contains at, the time at which the action will take place. An urgency_change pending_action will contain to, the urgency that the incident will change to. | [optional] 
**IncidentKey** | **string** | The incident&#x27;s de-duplication key. | [optional] 
**Service** | [**ServiceReference**](ServiceReference.md) |  | [optional] 
**Assignments** | [**List&lt;Assignment&gt;**](Assignment.md) | List of all assignments for this incident. This list will be empty if the &#x60;Incident.status&#x60; is &#x60;resolved&#x60;. | [optional] 
**AssignedVia** | **string** | How the current incident assignments were decided.  Note that &#x60;direct_assignment&#x60; incidents will not escalate up the attached &#x60;escalation_policy&#x60; | [optional] 
**Acknowledgements** | [**List&lt;Acknowledgement&gt;**](Acknowledgement.md) | List of all acknowledgements for this incident. This list will be empty if the &#x60;Incident.status&#x60; is &#x60;resolved&#x60; or &#x60;triggered&#x60;. | [optional] 
**LastStatusChangeAt** | **DateTime?** | The time at which the status of the incident last changed. | [optional] 
**LastStatusChangeBy** | [**AgentReference**](AgentReference.md) |  | [optional] 
**FirstTriggerLogEntry** | [**LogEntryReference**](LogEntryReference.md) |  | [optional] 
**EscalationPolicy** | [**EscalationPolicyReference**](EscalationPolicyReference.md) |  | [optional] 
**Teams** | [**List&lt;TeamReference&gt;**](TeamReference.md) | The teams involved in the incident’s lifecycle. | [optional] 
**Priority** | [**PriorityReference**](PriorityReference.md) |  | [optional] 
**Urgency** | **string** | The current urgency of the incident. | [optional] 
**ResolveReason** | [**ResolveReason**](ResolveReason.md) |  | [optional] 
**AlertCounts** | [**AlertCount**](AlertCount.md) |  | [optional] 
**ConferenceBridge** | [**ConferenceBridge**](ConferenceBridge.md) |  | [optional] 
**Body** | [**IncidentBody**](IncidentBody.md) |  | [optional] 
**IncidentsResponders** | [**List&lt;IncidentsRespondersReference&gt;**](IncidentsRespondersReference.md) |  | [optional] 
**ResponderRequests** | [**List&lt;ResponderRequest&gt;**](ResponderRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

