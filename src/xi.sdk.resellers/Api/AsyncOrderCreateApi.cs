/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    public interface IAsyncOrderCreateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Async Order Create
        /// </summary>
        /// <remarks>
        /// This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <returns>AsyncOrderCreateResponse</returns>
        AsyncOrderCreateResponse PostAsyncOrderCreateV7(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?));

        /// <summary>
        /// Async Order Create
        /// </summary>
        /// <remarks>
        /// This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <returns>ApiResponse of AsyncOrderCreateResponse</returns>
        ApiResponse<AsyncOrderCreateResponse> PostAsyncOrderCreateV7WithHttpInfo(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAsyncOrderCreateApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Async Order Create
        /// </summary>
        /// <remarks>
        /// This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AsyncOrderCreateResponse</returns>
        System.Threading.Tasks.Task<AsyncOrderCreateResponse> PostAsyncOrderCreateV7Async(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Async Order Create
        /// </summary>
        /// <remarks>
        /// This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AsyncOrderCreateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncOrderCreateResponse>> PostAsyncOrderCreateV7WithHttpInfoAsync(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAsyncOrderCreateApi : IAsyncOrderCreateApiSync, IAsyncOrderCreateApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AsyncOrderCreateApi : IDisposable, IAsyncOrderCreateApi
    {
        private xi.sdk.resellers.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AsyncOrderCreateApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AsyncOrderCreateApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AsyncOrderCreateApi(xi.sdk.resellers.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AsyncOrderCreateApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class.
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
        public AsyncOrderCreateApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class using Configuration object.
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
        public AsyncOrderCreateApi(HttpClient client, xi.sdk.resellers.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AsyncOrderCreateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AsyncOrderCreateApi(xi.sdk.resellers.Client.ISynchronousClient client, xi.sdk.resellers.Client.IAsynchronousClient asyncClient, xi.sdk.resellers.Client.IReadableConfiguration configuration)
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
        /// Async Order Create This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <returns>AsyncOrderCreateResponse</returns>
        public AsyncOrderCreateResponse PostAsyncOrderCreateV7(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?))
        {
            xi.sdk.resellers.Client.ApiResponse<AsyncOrderCreateResponse> localVarResponse = PostAsyncOrderCreateV7WithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, asyncOrderCreateDTO, iMSenderID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Async Order Create This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <returns>ApiResponse of AsyncOrderCreateResponse</returns>
        public xi.sdk.resellers.Client.ApiResponse<AsyncOrderCreateResponse> PostAsyncOrderCreateV7WithHttpInfo(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?))
        {
            // verify the required parameter 'iMCustomerNumber' is set
            if (iMCustomerNumber == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'iMCustomerNumber' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            // verify the required parameter 'iMCountryCode' is set
            if (iMCountryCode == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'iMCountryCode' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            // verify the required parameter 'iMCorrelationID' is set
            if (iMCorrelationID == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'iMCorrelationID' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            // verify the required parameter 'asyncOrderCreateDTO' is set
            if (asyncOrderCreateDTO == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'asyncOrderCreateDTO' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("IM-CustomerNumber", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMCustomerNumber)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("IM-CountryCode", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMCountryCode)); // header parameter
            if (iMSenderID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("IM-SenderID", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMSenderID)); // header parameter
            }
            localVarRequestOptions.HeaderParameters.Add("IM-CorrelationID", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMCorrelationID)); // header parameter
            localVarRequestOptions.Data = asyncOrderCreateDTO;

            // authentication (application) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AsyncOrderCreateResponse>("/resellers/v7/orders", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostAsyncOrderCreateV7", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Async Order Create This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AsyncOrderCreateResponse</returns>
        public async System.Threading.Tasks.Task<AsyncOrderCreateResponse> PostAsyncOrderCreateV7Async(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            xi.sdk.resellers.Client.ApiResponse<AsyncOrderCreateResponse> localVarResponse = await PostAsyncOrderCreateV7WithHttpInfoAsync(iMCustomerNumber, iMCountryCode, iMCorrelationID, asyncOrderCreateDTO, iMSenderID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Async Order Create This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="iMCustomerNumber">Your unique Ingram Micro customer number.</param>
        /// <param name="iMCountryCode">Two-character ISO country code.</param>
        /// <param name="iMCorrelationID">Unique transaction number to identify each transaction accross all the systems.</param>
        /// <param name="asyncOrderCreateDTO"></param>
        /// <param name="iMSenderID">Unique value used to identify the sender of the transaction. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AsyncOrderCreateResponse)</returns>
        public async System.Threading.Tasks.Task<xi.sdk.resellers.Client.ApiResponse<AsyncOrderCreateResponse>> PostAsyncOrderCreateV7WithHttpInfoAsync(string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = default(string?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'iMCustomerNumber' is set
            if (iMCustomerNumber == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'iMCustomerNumber' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            // verify the required parameter 'iMCountryCode' is set
            if (iMCountryCode == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'iMCountryCode' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            // verify the required parameter 'iMCorrelationID' is set
            if (iMCorrelationID == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'iMCorrelationID' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");

            // verify the required parameter 'asyncOrderCreateDTO' is set
            if (asyncOrderCreateDTO == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'asyncOrderCreateDTO' when calling AsyncOrderCreateApi->PostAsyncOrderCreateV7");


            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("IM-CustomerNumber", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMCustomerNumber)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("IM-CountryCode", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMCountryCode)); // header parameter
            if (iMSenderID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("IM-SenderID", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMSenderID)); // header parameter
            }
            localVarRequestOptions.HeaderParameters.Add("IM-CorrelationID", xi.sdk.resellers.Client.ClientUtils.ParameterToString(iMCorrelationID)); // header parameter
            localVarRequestOptions.Data = asyncOrderCreateDTO;

            // authentication (application) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AsyncOrderCreateResponse>("/resellers/v7/orders", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostAsyncOrderCreateV7", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
