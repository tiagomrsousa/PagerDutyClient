# PagerDuty.ApiClient.Model.AnalyticsRawIncident
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignmentCount** | **int?** | Total count of instances where responders were assigned an incident (including through reassignment or escalation) or accepted a responder request. | [optional] 
**BusinessHourInterruptions** | **int?** | Total number of unique interruptions during business hour. Business hour: 8am-6pm Mon-Fri, based on the user’s time zone.   | [optional] 
**CreatedAt** | **string** | Timestamp of when the incident was created. | [optional] 
**Description** | **string** | The incident description | [optional] 
**EngagedSeconds** | **int?** | Total engaged time across all responders for this incident.  Engaged time is measured from the time a user engages with an incident (by acknowledging or accepting a responder request) until the incident is resolved.  This may include periods in which the incident was snoozed. | [optional] 
**EngagedUserCount** | **int?** | Total number of users who engaged (acknowledged, accepted responder request) in the incident. | [optional] 
**EscalationCount** | **int?** | Total count of instances where an incident is escalated between responders assigned to an escalation policy. | [optional] 
**Id** | **string** | Incident ID | [optional] 
**IncidentNumber** | **int?** | The PagerDuty incident number | [optional] 
**Major** | **bool?** | An incident is classified as a [major incident](https://support.pagerduty.com/docs/operational-reviews#major-incidents) if it has one of the two highest priorities, or if multiple responders are added and acknowledge the incident. | [optional] 
**OffHourInterruptions** | **int?** | Total number of unique interruptions during off hour. Off hour: 6pm-10pm Mon-Fri and all day Sat-Sun, based on the user’s time zone.       | [optional] 
**PriorityId** | **string** | ID of the incident&#x27;s priority level. | [optional] 
**PriorityName** | **string** | The user-provided short name of the priority. | [optional] 
**ResolvedAt** | **string** | Timestamp of when the incident was resolved. | [optional] 
**SecondsToEngage** | **int?** | A measure of *people response time*. This metric measures the time from the first user engagement (acknowledge or responder accept) to the last. This metric is only used for incidents with **multiple responders**; for incidents with one or no engaged users, this value is null. | [optional] 
**SecondsToFirstAck** | **int?** | Time between start of an incident, and the first responder to acknowledge. | [optional] 
**SecondsToMobilize** | **int?** | Time between start of an incident, and the last additional responder to acknowledge.  If an incident has one or less responders, the value will be null. | [optional] 
**SecondsToResolve** | **int?** | Time from when incident triggered until it was resolved. | [optional] 
**ServiceId** | **string** | ID of the service that the incident triggered on. | [optional] 
**ServiceName** | **string** | Name of the service that the incident triggered on. | [optional] 
**SleepHourInterruptions** | **int?** | Total number of unique interruptions during sleep hour. Sleep hour: 10pm-8am every day, based on the user’s time zone. | [optional] 
**SnoozedSeconds** | **int?** | Total seconds the incident has been snoozed for. | [optional] 
**TeamId** | **string** | ID of the team the incident was assigned to. | [optional] 
**TeamName** | **string** | Name of the team the incident was assigned to. | [optional] 
**Urgency** | **string** | Notification level | [optional] 
**UserDefinedEffortSeconds** | **int?** | The total response effort in seconds, [as defined by the user](https://support.pagerduty.com/docs/editing-incidents#edit-incident-duration). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

