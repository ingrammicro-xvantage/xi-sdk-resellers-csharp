/*
 * Reseller API Documentation - United States
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using xi-sdk-csharp.Client;
using xi-sdk-csharp.Client.Auth;
using xi-sdk-csharp.Model;

namespace xi-sdk-csharp.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesV4ApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceDetailResponse</returns>
        InvoiceDetailResponse PostV4Invoicedetails(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0);

        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceDetailResponse</returns>
        ApiResponse<InvoiceDetailResponse> PostV4InvoicedetailsWithHttpInfo(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesV4ApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InvoiceDetailResponse</returns>
        System.Threading.Tasks.Task<InvoiceDetailResponse> PostV4InvoicedetailsAsync(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InvoiceDetailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceDetailResponse>> PostV4InvoicedetailsWithHttpInfoAsync(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesV4Api : IInvoicesV4ApiSync, IInvoicesV4ApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoicesV4Api : IInvoicesV4Api
    {
        private xi-sdk-csharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV4Api"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesV4Api() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV4Api"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesV4Api(string basePath)
        {
            this.Configuration = xi-sdk-csharp.Client.Configuration.MergeConfigurations(
                xi-sdk-csharp.Client.GlobalConfiguration.Instance,
                new xi-sdk-csharp.Client.Configuration { BasePath = basePath }
            );
            this.Client = new xi-sdk-csharp.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new xi-sdk-csharp.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = xi-sdk-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV4Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoicesV4Api(xi-sdk-csharp.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = xi-sdk-csharp.Client.Configuration.MergeConfigurations(
                xi-sdk-csharp.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new xi-sdk-csharp.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new xi-sdk-csharp.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = xi-sdk-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV4Api"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InvoicesV4Api(xi-sdk-csharp.Client.ISynchronousClient client, xi-sdk-csharp.Client.IAsynchronousClient asyncClient, xi-sdk-csharp.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = xi-sdk-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public xi-sdk-csharp.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public xi-sdk-csharp.Client.ISynchronousClient Client { get; set; }

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
        public xi-sdk-csharp.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public xi-sdk-csharp.Client.ExceptionFactory ExceptionFactory
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
        /// Get Invoice Details A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceDetailResponse</returns>
        public InvoiceDetailResponse PostV4Invoicedetails(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0)
        {
            xi-sdk-csharp.Client.ApiResponse<InvoiceDetailResponse> localVarResponse = PostV4InvoicedetailsWithHttpInfo(invoiceDetailRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Invoice Details A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceDetailResponse</returns>
        public xi-sdk-csharp.Client.ApiResponse<InvoiceDetailResponse> PostV4InvoicedetailsWithHttpInfo(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0)
        {
            xi-sdk-csharp.Client.RequestOptions localVarRequestOptions = new xi-sdk-csharp.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = xi-sdk-csharp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = xi-sdk-csharp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = invoiceDetailRequest;

            localVarRequestOptions.Operation = "InvoicesV4Api.PostV4Invoicedetails";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InvoiceDetailResponse>("/invoices/v4/invoicedetails", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostV4Invoicedetails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Invoice Details A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InvoiceDetailResponse</returns>
        public async System.Threading.Tasks.Task<InvoiceDetailResponse> PostV4InvoicedetailsAsync(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            xi-sdk-csharp.Client.ApiResponse<InvoiceDetailResponse> localVarResponse = await PostV4InvoicedetailsWithHttpInfoAsync(invoiceDetailRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Invoice Details A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceDetailRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InvoiceDetailResponse)</returns>
        public async System.Threading.Tasks.Task<xi-sdk-csharp.Client.ApiResponse<InvoiceDetailResponse>> PostV4InvoicedetailsWithHttpInfoAsync(InvoiceDetailRequest? invoiceDetailRequest = default(InvoiceDetailRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            xi-sdk-csharp.Client.RequestOptions localVarRequestOptions = new xi-sdk-csharp.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = xi-sdk-csharp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = xi-sdk-csharp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = invoiceDetailRequest;

            localVarRequestOptions.Operation = "InvoicesV4Api.PostV4Invoicedetails";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<InvoiceDetailResponse>("/invoices/v4/invoicedetails", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostV4Invoicedetails", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
