# PagerDuty.ApiClient.Model.AutomationActionsScriptActionDataReference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Script** | **string** | Body of the script to be executed on the Runner. To execute it, the Runner will write the content of the property into a temp file, make the file executable and execute it. It is assumed that the Runner has a properly configured environment to run the script as an executable file. This behaviour can be altered by providing the &#x60;invocation_command&#x60; property. The maxLength value is specified in bytes. | 
**InvocationCommand** | **string** | The command to executed a script with. With the body of the script written into a temp file, the Runner will execute the &#x60;&lt;invocation_command&gt; &lt;temp_file&gt;&#x60; command. The maxLength value is specified in bytes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

