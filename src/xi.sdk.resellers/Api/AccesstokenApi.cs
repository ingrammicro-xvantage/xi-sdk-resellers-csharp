/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace xi.sdk.resellers.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccesstokenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Accesstoken
        /// </summary>
        /// <remarks>
        /// The Authentication endpoint will provide an access token to access the API.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <returns>AccesstokenResponse</returns>
        AccesstokenResponse GetAccesstoken(string grantType, string clientId, string clientSecret);

        /// <summary>
        /// Accesstoken
        /// </summary>
        /// <remarks>
        /// The Authentication endpoint will provide an access token to access the API.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <returns>ApiResponse of AccesstokenResponse</returns>
        ApiResponse<AccesstokenResponse> GetAccesstokenWithHttpInfo(string grantType, string clientId, string clientSecret);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccesstokenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Accesstoken
        /// </summary>
        /// <remarks>
        /// The Authentication endpoint will provide an access token to access the API.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccesstokenResponse</returns>
        System.Threading.Tasks.Task<AccesstokenResponse> GetAccesstokenAsync(string grantType, string clientId, string clientSecret, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Accesstoken
        /// </summary>
        /// <remarks>
        /// The Authentication endpoint will provide an access token to access the API.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccesstokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccesstokenResponse>> GetAccesstokenWithHttpInfoAsync(string grantType, string clientId, string clientSecret, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccesstokenApi : IAccesstokenApiSync, IAccesstokenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccesstokenApi : IDisposable, IAccesstokenApi
    {
        private xi.sdk.resellers.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AccesstokenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AccesstokenApi(string basePath)
        {
            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                new xi.sdk.resellers.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AccesstokenApi(xi.sdk.resellers.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AccesstokenApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AccesstokenApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                new xi.sdk.resellers.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AccesstokenApi(HttpClient client, xi.sdk.resellers.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccesstokenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AccesstokenApi(xi.sdk.resellers.Client.ISynchronousClient client, xi.sdk.resellers.Client.IAsynchronousClient asyncClient, xi.sdk.resellers.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public xi.sdk.resellers.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public xi.sdk.resellers.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public xi.sdk.resellers.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public xi.sdk.resellers.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public xi.sdk.resellers.Client.ExceptionFactory ExceptionFactory
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
        /// Accesstoken The Authentication endpoint will provide an access token to access the API.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <returns>AccesstokenResponse</returns>
        public AccesstokenResponse GetAccesstoken(string grantType, string clientId, string clientSecret)
        {
            xi.sdk.resellers.Client.ApiResponse<AccesstokenResponse> localVarResponse = GetAccesstokenWithHttpInfo(grantType, clientId, clientSecret);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Accesstoken The Authentication endpoint will provide an access token to access the API.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <returns>ApiResponse of AccesstokenResponse</returns>
        public xi.sdk.resellers.Client.ApiResponse<AccesstokenResponse> GetAccesstokenWithHttpInfo(string grantType, string clientId, string clientSecret)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'grantType' when calling AccesstokenApi->GetAccesstoken");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'clientId' when calling AccesstokenApi->GetAccesstoken");

            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'clientSecret' when calling AccesstokenApi->GetAccesstoken");

            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "grant_type", grantType));
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "client_id", clientId));
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "client_secret", clientSecret));


            // make the HTTP request
            var localVarResponse = this.Client.Get<AccesstokenResponse>("/oauth/oauth20/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAccesstoken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Accesstoken The Authentication endpoint will provide an access token to access the API.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccesstokenResponse</returns>
        public async System.Threading.Tasks.Task<AccesstokenResponse> GetAccesstokenAsync(string grantType, string clientId, string clientSecret, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            xi.sdk.resellers.Client.ApiResponse<AccesstokenResponse> localVarResponse = await GetAccesstokenWithHttpInfoAsync(grantType, clientId, clientSecret, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Accesstoken The Authentication endpoint will provide an access token to access the API.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Keep grant_type as client_credentials only.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccesstokenResponse)</returns>
        public async System.Threading.Tasks.Task<xi.sdk.resellers.Client.ApiResponse<AccesstokenResponse>> GetAccesstokenWithHttpInfoAsync(string grantType, string clientId, string clientSecret, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'grantType' when calling AccesstokenApi->GetAccesstoken");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'clientId' when calling AccesstokenApi->GetAccesstoken");

            // verify the required parameter 'clientSecret' is set
            if (clientSecret == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'clientSecret' when calling AccesstokenApi->GetAccesstoken");


            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "grant_type", grantType));
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "client_id", clientId));
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "client_secret", clientSecret));


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AccesstokenResponse>("/oauth/oauth20/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAccesstoken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
