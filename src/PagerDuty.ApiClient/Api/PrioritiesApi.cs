/* 
 * PagerDuty API
 *
 * This document describes the PagerDuty REST APIs.  For guides and examples please visit our [Documentation.](https://developer.pagerduty.com/docs/get-started/getting-started/)  Our REST APIs are defined in OpenAPI v3.x. You can view the schema at [github.com/PagerDuty/api-schema](https://github.com/PagerDuty/api-schema).  Note that properties in some schemas have fields not shown by default such as `readOnly`, `format`, and `default`. Hover your cursor over the right column that looks like `optional+1` to see the full list of fields. 
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@pagerduty.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PagerDuty.ApiClient.Client;
using PagerDuty.ApiClient.Model;
using Newtonsoft.Json;

namespace PagerDuty.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPrioritiesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List priorities
        /// </summary>
        /// <remarks>
        /// List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </remarks>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>Object</returns>
        PriorityResponse ListPriorities (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null);

        /// <summary>
        /// List priorities
        /// </summary>
        /// <remarks>
        /// List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </remarks>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<PriorityResponse> ListPrioritiesWithHttpInfo (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List priorities
        /// </summary>
        /// <remarks>
        /// List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </remarks>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ListPrioritiesAsync (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null);

        /// <summary>
        /// List priorities
        /// </summary>
        /// <remarks>
        /// List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </remarks>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ListPrioritiesAsyncWithHttpInfo (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PrioritiesApi : IPrioritiesApi
    {
        private PagerDuty.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PrioritiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PrioritiesApi(String basePath)
        {
            this.Configuration = new PagerDuty.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PagerDuty.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrioritiesApi"/> class
        /// </summary>
        /// <returns></returns>
        public PrioritiesApi()
        {
            this.Configuration = PagerDuty.ApiClient.Client.Configuration.Default;

            ExceptionFactory = PagerDuty.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrioritiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PrioritiesApi(PagerDuty.ApiClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PagerDuty.ApiClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PagerDuty.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PagerDuty.ApiClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PagerDuty.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// List priorities List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </summary>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>Object</returns>
        public PriorityResponse ListPriorities (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null)
        {
             ApiResponse<PriorityResponse> localVarResponse = ListPrioritiesWithHttpInfo(accept, contentType, authorization, limit, offset, total);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List priorities List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </summary>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<PriorityResponse> ListPrioritiesWithHttpInfo (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling PrioritiesApi->ListPriorities");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling PrioritiesApi->ListPriorities");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PrioritiesApi->ListPriorities");

            var localVarPath = "/priorities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.AddOrUpdate("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (total != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total", total)); // query parameter
            if (accept != null) localVarHeaderParams.AddOrUpdate("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.AddOrUpdate("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (authorization != null) localVarHeaderParams.AddOrUpdate("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListPriorities", localVarResponse);
                if (exception != null) throw exception;
            }

            //PriorityResponse dynamicObject = JsonConvert.DeserializeObject<PriorityResponse>(localVarResponse.Content);

            return new ApiResponse<PriorityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriorityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriorityResponse)));
        }

        /// <summary>
        /// List priorities List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </summary>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ListPrioritiesAsync (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null)
        {
             ApiResponse<Object> localVarResponse = await ListPrioritiesAsyncWithHttpInfo(accept, contentType, authorization, limit, offset, total);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List priorities List existing priorities, in order (most to least severe).  A priority is a label representing the importance and impact of an incident. This feature is only available on Standard and Enterprise plans.  For more information see the [API Concepts Document](../../api-reference/ZG9jOjI3NDc5Nzc-api-concepts#priorities) 
        /// </summary>
        /// <exception cref="PagerDuty.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept">The &#x60;Accept&#x60; header is used as a versioning header.</param>
        /// <param name="contentType"></param>
        /// <param name="authorization">The &#x60;Authorization&#x60; header is used as a versioning header.</param>
        /// <param name="limit">The number of results per page. (optional)</param>
        /// <param name="offset">Offset to start pagination search results. (optional)</param>
        /// <param name="total">By default the &#x60;total&#x60; field in pagination responses is set to &#x60;null&#x60; to provide the fastest possible response times. Set &#x60;total&#x60; to &#x60;true&#x60; for this field to be populated.  See our [Pagination Docs](https://developer.pagerduty.com/docs/rest-api-v2/pagination/) for more information.  (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ListPrioritiesAsyncWithHttpInfo (string accept, string contentType, string authorization, int? limit = null, int? offset = null, bool? total = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling PrioritiesApi->ListPriorities");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling PrioritiesApi->ListPriorities");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PrioritiesApi->ListPriorities");

            var localVarPath = "/priorities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.AddOrUpdate("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (total != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total", total)); // query parameter
            if (accept != null) localVarHeaderParams.AddOrUpdate("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.AddOrUpdate("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (authorization != null) localVarHeaderParams.AddOrUpdate("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListPriorities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
