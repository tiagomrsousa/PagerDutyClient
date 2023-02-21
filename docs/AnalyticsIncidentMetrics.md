# PagerDuty.ApiClient.Model.AnalyticsIncidentMetrics
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MeanAssignmentCount** | **int?** | Mean count of instances where responders were assigned an incident (including through reassignment or escalation) or accepted a responder request. | [optional] 
**MeanEngagedSeconds** | **int?** | Mean engaged time across all responders for incidents that match the given filters. Engaged time is measured from the time a user engages with an incident (by acknowledging or accepting a responder request) until the incident is resolved. This may include periods in which the incidents was snoozed. | [optional] 
**MeanEngagedUserCount** | **int?** | Mean number of users who engaged with an incident. *Engaged* is defined as acknowledging an incident or accepting a responder request in it. | [optional] 
**MeanSecondsToEngage** | **int?** | A measure of *people response time*. This metric measures the time from the first user engagement (acknowledge or responder accept) to the last. This metric is only used for incidents with **multiple responders**; for incidents with one or no engaged users, this value is null. | [optional] 
**MeanSecondsToFirstAck** | **int?** | Mean time between the start of an incident, and the first responder to acknowledge. | [optional] 
**MeanSecondsToMobilize** | **int?** | Mean time between the start of an incident, and the last additional responder to acknowledge. For incidents with one or no engaged users, this value is null. | [optional] 
**MeanSecondsToResolve** | **int?** | Mean time from when an incident was triggered until it was resolved. | [optional] 
**ServiceId** | **string** | ID of the service. Only included when aggregating by service. | [optional] 
**ServiceName** | **string** | Name of the service. Only included when aggregating by service. | [optional] 
**TeamId** | **string** | ID of the team the incident was assigned to. | [optional] 
**TeamName** | **string** | Name of the team the incident was assigned to. | [optional] 
**TotalBusinessHourInterruptions** | **int?** | Total number of unique interruptions during business hours. Business hour: 8am-6pm Mon-Fri, based on the user’s time zone.  | [optional] 
**TotalEngagedSeconds** | **int?** | Total engaged time across all responders for incidents. Engaged time is measured from the time a user engages with an incident (by acknowledging or accepting a responder request) until the incident is resolved. This may include periods in which the incidents was snoozed. | [optional] 
**TotalEscalationCount** | **int?** | Total count of instances where an incident is escalated between responders assigned to an escalation policy. | [optional] 
**TotalIncidentCount** | **int?** | The total number of incidents that were created. | [optional] 
**TotalOffHourInterruptions** | **int?** | Total number of unique interruptions during off hours. Off hour: 6pm-10pm Mon-Fri and all day Sat-Sun, based on the user’s time zone. | [optional] 
**TotalSleepHourInterruptions** | **int?** | Total number of unique interruptions during sleep hours. Sleep hour: 10pm-8am every day, based on the user’s time zone. | [optional] 
**TotalSnoozedSeconds** | **int?** | Total number of seconds incidents were snoozed. | [optional] 
**UpTimePct** | [**decimal?**](BigDecimal.md) | The percentage of time in the defined date range that the service was not interrupted by a [major incident](https://support.pagerduty.com/docs/operational-reviews#major-incidents). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

