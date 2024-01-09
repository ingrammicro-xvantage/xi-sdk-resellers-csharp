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
    public interface IProductCatalogV4ApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Product availability for upto 50 SKUs
        /// </summary>
        /// <remarks>
        /// Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MultiSKUPriceAndStockResponse</returns>
        MultiSKUPriceAndStockResponse PostV4Multiskupriceandstock(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0);

        /// <summary>
        /// Product availability for upto 50 SKUs
        /// </summary>
        /// <remarks>
        /// Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MultiSKUPriceAndStockResponse</returns>
        ApiResponse<MultiSKUPriceAndStockResponse> PostV4MultiskupriceandstockWithHttpInfo(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0);
        /// <summary>
        /// Real-time Product Search
        /// </summary>
        /// <remarks>
        /// A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductSearchResponse</returns>
        ProductSearchResponse PostV4Productsearch(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0);

        /// <summary>
        /// Real-time Product Search
        /// </summary>
        /// <remarks>
        /// A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductSearchResponse</returns>
        ApiResponse<ProductSearchResponse> PostV4ProductsearchWithHttpInfo(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductCatalogV4ApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Product availability for upto 50 SKUs
        /// </summary>
        /// <remarks>
        /// Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MultiSKUPriceAndStockResponse</returns>
        System.Threading.Tasks.Task<MultiSKUPriceAndStockResponse> PostV4MultiskupriceandstockAsync(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Product availability for upto 50 SKUs
        /// </summary>
        /// <remarks>
        /// Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MultiSKUPriceAndStockResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MultiSKUPriceAndStockResponse>> PostV4MultiskupriceandstockWithHttpInfoAsync(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Real-time Product Search
        /// </summary>
        /// <remarks>
        /// A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductSearchResponse</returns>
        System.Threading.Tasks.Task<ProductSearchResponse> PostV4ProductsearchAsync(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Real-time Product Search
        /// </summary>
        /// <remarks>
        /// A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </remarks>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductSearchResponse>> PostV4ProductsearchWithHttpInfoAsync(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductCatalogV4Api : IProductCatalogV4ApiSync, IProductCatalogV4ApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductCatalogV4Api : IProductCatalogV4Api
    {
        private xi-sdk-csharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCatalogV4Api"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductCatalogV4Api() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCatalogV4Api"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductCatalogV4Api(string basePath)
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
        /// Initializes a new instance of the <see cref="ProductCatalogV4Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductCatalogV4Api(xi-sdk-csharp.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProductCatalogV4Api"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProductCatalogV4Api(xi-sdk-csharp.Client.ISynchronousClient client, xi-sdk-csharp.Client.IAsynchronousClient asyncClient, xi-sdk-csharp.Client.IReadableConfiguration configuration)
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
        /// Product availability for upto 50 SKUs Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MultiSKUPriceAndStockResponse</returns>
        public MultiSKUPriceAndStockResponse PostV4Multiskupriceandstock(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0)
        {
            xi-sdk-csharp.Client.ApiResponse<MultiSKUPriceAndStockResponse> localVarResponse = PostV4MultiskupriceandstockWithHttpInfo(multiSKUPriceAndStockRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Product availability for upto 50 SKUs Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MultiSKUPriceAndStockResponse</returns>
        public xi-sdk-csharp.Client.ApiResponse<MultiSKUPriceAndStockResponse> PostV4MultiskupriceandstockWithHttpInfo(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0)
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

            localVarRequestOptions.Data = multiSKUPriceAndStockRequest;

            localVarRequestOptions.Operation = "ProductCatalogV4Api.PostV4Multiskupriceandstock";
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
            var localVarResponse = this.Client.Post<MultiSKUPriceAndStockResponse>("/products/v4/multiskupriceandstock", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostV4Multiskupriceandstock", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Product availability for upto 50 SKUs Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MultiSKUPriceAndStockResponse</returns>
        public async System.Threading.Tasks.Task<MultiSKUPriceAndStockResponse> PostV4MultiskupriceandstockAsync(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            xi-sdk-csharp.Client.ApiResponse<MultiSKUPriceAndStockResponse> localVarResponse = await PostV4MultiskupriceandstockWithHttpInfoAsync(multiSKUPriceAndStockRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Product availability for upto 50 SKUs Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="multiSKUPriceAndStockRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MultiSKUPriceAndStockResponse)</returns>
        public async System.Threading.Tasks.Task<xi-sdk-csharp.Client.ApiResponse<MultiSKUPriceAndStockResponse>> PostV4MultiskupriceandstockWithHttpInfoAsync(MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = default(MultiSKUPriceAndStockRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = multiSKUPriceAndStockRequest;

            localVarRequestOptions.Operation = "ProductCatalogV4Api.PostV4Multiskupriceandstock";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<MultiSKUPriceAndStockResponse>("/products/v4/multiskupriceandstock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostV4Multiskupriceandstock", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Real-time Product Search A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductSearchResponse</returns>
        public ProductSearchResponse PostV4Productsearch(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0)
        {
            xi-sdk-csharp.Client.ApiResponse<ProductSearchResponse> localVarResponse = PostV4ProductsearchWithHttpInfo(productSearchRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Real-time Product Search A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductSearchResponse</returns>
        public xi-sdk-csharp.Client.ApiResponse<ProductSearchResponse> PostV4ProductsearchWithHttpInfo(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0)
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

            localVarRequestOptions.Data = productSearchRequest;

            localVarRequestOptions.Operation = "ProductCatalogV4Api.PostV4Productsearch";
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
            var localVarResponse = this.Client.Post<ProductSearchResponse>("/products/v4/productsearch", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostV4Productsearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Real-time Product Search A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductSearchResponse</returns>
        public async System.Threading.Tasks.Task<ProductSearchResponse> PostV4ProductsearchAsync(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            xi-sdk-csharp.Client.ApiResponse<ProductSearchResponse> localVarResponse = await PostV4ProductsearchWithHttpInfoAsync(productSearchRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Real-time Product Search A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 
        /// </summary>
        /// <exception cref="xi-sdk-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productSearchRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductSearchResponse)</returns>
        public async System.Threading.Tasks.Task<xi-sdk-csharp.Client.ApiResponse<ProductSearchResponse>> PostV4ProductsearchWithHttpInfoAsync(ProductSearchRequest? productSearchRequest = default(ProductSearchRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = productSearchRequest;

            localVarRequestOptions.Operation = "ProductCatalogV4Api.PostV4Productsearch";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<ProductSearchResponse>("/products/v4/productsearch", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostV4Productsearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
