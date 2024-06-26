# xi.sdk.resellers - the C# library for the XI Sdk Resellers

For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.



## Frameworks supported


## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

## Installation
From NuGet:
```sh
dotnet add package xi.sdk.resellers
```
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;
```

## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out xi.sdk.resellers.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


## Getting Started

Quickstart on creating an application can be found [here](getting-started.md)

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AccesstokenApi(httpClient, config, httpClientHandler);
            var grantType = client_credentials;  // string | Keep grant_type as client_credentials only.
            var clientId = "clientId_example";  // string | 
            var clientSecret = "clientSecret_example";  // string | 

            try
            {
                // Accesstoken
                AccesstokenResponse result = apiInstance.GetAccesstoken(grantType, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccesstokenApi.GetAccesstoken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to [https://api.ingrammicro.com:443](https://api.ingrammicro.com:443)

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccesstokenApi* | [**GetAccesstoken**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AccesstokenApi.md#getaccesstoken) | **GET** /oauth/oauth20/token | Accesstoken
*DealsApi* | [**GetResellersV6Dealsdetails**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/DealsApi.md#getresellersv6dealsdetails) | **GET** /resellers/v6/deals/{dealId} | Deals Details
*DealsApi* | [**GetResellersV6Dealssearch**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/DealsApi.md#getresellersv6dealssearch) | **GET** /resellers/v6/deals/search | Deals Search
*FreightEstimateApi* | [**PostFreightestimate**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightEstimateApi.md#postfreightestimate) | **POST** /resellers/v6/freightestimate | Freight Estimate
*InvoicesApi* | [**GetInvoicedetailsV61**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoicesApi.md#getinvoicedetailsv61) | **GET** /resellers/v6.1/invoices/{invoiceNumber} | Get Invoice Details v6.1
*InvoicesApi* | [**GetResellersV6Invoicesearch**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoicesApi.md#getresellersv6invoicesearch) | **GET** /resellers/v6/invoices | Search your invoice
*OrderStatusApi* | [**ResellersV1WebhooksOrderstatuseventPost**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusApi.md#resellersv1webhooksorderstatuseventpost) | **POST** /resellers/v1/webhooks/orderstatusevent | Order Status
*OrdersApi* | [**DeleteOrdercancel**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrdersApi.md#deleteordercancel) | **DELETE** /resellers/v6/orders/{OrderNumber} | Cancel your Order
*OrdersApi* | [**GetOrderdetailsV61**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrdersApi.md#getorderdetailsv61) | **GET** /resellers/v6.1/orders/{ordernumber} | Get Order Details v6.1
*OrdersApi* | [**GetResellersV6Ordersearch**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrdersApi.md#getresellersv6ordersearch) | **GET** /resellers/v6/orders/search | Search your Orders
*OrdersApi* | [**PostCreateorderV6**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrdersApi.md#postcreateorderv6) | **POST** /resellers/v6/orders | Create your Order
*OrdersApi* | [**PostCreateorderV7**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrdersApi.md#postcreateorderv7) | **POST** /resellers/v7/orders | Create your Order v7
*OrdersApi* | [**PutOrdermodify**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrdersApi.md#putordermodify) | **PUT** /resellers/v6/orders/{orderNumber} | Modify your Order
*ProductCatalogApi* | [**GetResellerV6Productdetail**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductCatalogApi.md#getresellerv6productdetail) | **GET** /resellers/v6/catalog/details/{ingramPartNumber} | Product Details
*ProductCatalogApi* | [**GetResellerV6Productsearch**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductCatalogApi.md#getresellerv6productsearch) | **GET** /resellers/v6/catalog | Search Products
*ProductCatalogApi* | [**PostPriceandavailability**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductCatalogApi.md#postpriceandavailability) | **POST** /resellers/v6/catalog/priceandavailability | Price and Availability
*QuotesApi* | [**GetQuotessearchV6**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuotesApi.md#getquotessearchv6) | **GET** /resellers/v6/quotes/search | Quote Search
*QuotesApi* | [**GetResellerV6ValidateQuote**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuotesApi.md#getresellerv6validatequote) | **GET** /resellers/v6/q2o/validatequote | Validate Quote
*QuotesApi* | [**GetResellersV6Quotes**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuotesApi.md#getresellersv6quotes) | **GET** /resellers/v6/quotes/{quoteNumber} | Get Quote Details
*RenewalsApi* | [**GetResellersV6Renewalsdetails**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsApi.md#getresellersv6renewalsdetails) | **GET** /resellers/v6/renewals/{renewalId} | Renewals Details
*RenewalsApi* | [**PostRenewalssearch**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsApi.md#postrenewalssearch) | **POST** /resellers/v6/renewals/search | Renewals Search
*ReturnsApi* | [**GetResellersV6Returnsdetails**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsApi.md#getresellersv6returnsdetails) | **GET** /resellers/v6/returns/{caseRequestNumber} | Returns Details
*ReturnsApi* | [**GetResellersV6Returnssearch**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsApi.md#getresellersv6returnssearch) | **GET** /resellers/v6/returns/search | Returns Search
*ReturnsApi* | [**PostReturnscreate**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsApi.md#postreturnscreate) | **POST** /resellers/v6/returns/create | Returns Create
*StockUpdateApi* | [**ResellersV1WebhooksAvailabilityupdatePost**](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/StockUpdateApi.md#resellersv1webhooksavailabilityupdatepost) | **POST** /resellers/v1/webhooks/availabilityupdate | Stock Update


## Documentation for Models

 - [Model.AccesstokenResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AccesstokenResponse.md)
 - [Model.AsyncOrderCreateDTO](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTO.md)
 - [Model.AsyncOrderCreateDTOAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOAdditionalAttributesInner.md)
 - [Model.AsyncOrderCreateDTOEndUserInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOEndUserInfo.md)
 - [Model.AsyncOrderCreateDTOLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOLinesInner.md)
 - [Model.AsyncOrderCreateDTOLinesInnerEndUserInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOLinesInnerEndUserInfoInner.md)
 - [Model.AsyncOrderCreateDTOResellerInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOResellerInfo.md)
 - [Model.AsyncOrderCreateDTOShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOShipToInfo.md)
 - [Model.AsyncOrderCreateDTOShipmentDetails](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOShipmentDetails.md)
 - [Model.AsyncOrderCreateDTOVmfadditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOVmfadditionalAttributesInner.md)
 - [Model.AsyncOrderCreateDTOWarrantyInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOWarrantyInfoInner.md)
 - [Model.AsyncOrderCreateDTOWarrantyInfoInnerSerialInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOWarrantyInfoInnerSerialInfoInner.md)
 - [Model.AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateDTOWarrantyInfoInnerVmfAdditionalAttributesLinesInner.md)
 - [Model.AsyncOrderCreateResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AsyncOrderCreateResponse.md)
 - [Model.AvailabilityAsyncNotificationRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AvailabilityAsyncNotificationRequest.md)
 - [Model.AvailabilityAsyncNotificationRequestResourceInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AvailabilityAsyncNotificationRequestResourceInner.md)
 - [Model.AvailabilityAsyncNotificationRequestResourceInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/AvailabilityAsyncNotificationRequestResourceInnerLinksInner.md)
 - [Model.DealsDetailsResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/DealsDetailsResponse.md)
 - [Model.DealsDetailsResponseProductsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/DealsDetailsResponseProductsInner.md)
 - [Model.DealsSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/DealsSearchResponse.md)
 - [Model.DealsSearchResponseDealsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/DealsSearchResponseDealsInner.md)
 - [Model.Error](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/Error.md)
 - [Model.ErrorResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ErrorResponse.md)
 - [Model.ErrorResponseDTO](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ErrorResponseDTO.md)
 - [Model.ErrorResponseErrorsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ErrorResponseErrorsInner.md)
 - [Model.ErrorResponseErrorsInnerFieldsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ErrorResponseErrorsInnerFieldsInner.md)
 - [Model.Fields](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/Fields.md)
 - [Model.FreightRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightRequest.md)
 - [Model.FreightRequestLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightRequestLinesInner.md)
 - [Model.FreightRequestShipToAddressInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightRequestShipToAddressInner.md)
 - [Model.FreightResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightResponse.md)
 - [Model.FreightResponseFreightEstimateResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightResponseFreightEstimateResponse.md)
 - [Model.FreightResponseFreightEstimateResponseDistributionInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightResponseFreightEstimateResponseDistributionInner.md)
 - [Model.FreightResponseFreightEstimateResponseDistributionInnerCarrierListInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightResponseFreightEstimateResponseDistributionInnerCarrierListInner.md)
 - [Model.FreightResponseFreightEstimateResponseLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/FreightResponseFreightEstimateResponseLinesInner.md)
 - [Model.GetAccesstoken400Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/GetAccesstoken400Response.md)
 - [Model.GetAccesstoken500Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/GetAccesstoken500Response.md)
 - [Model.GetAccesstoken500ResponseFault](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/GetAccesstoken500ResponseFault.md)
 - [Model.GetAccesstoken500ResponseFaultDetail](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/GetAccesstoken500ResponseFaultDetail.md)
 - [Model.GetResellerV6ValidateQuote400Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/GetResellerV6ValidateQuote400Response.md)
 - [Model.GetResellerV6ValidateQuote400ResponseFieldsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/GetResellerV6ValidateQuote400ResponseFieldsInner.md)
 - [Model.InvoiceDetailsv61Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61Response.md)
 - [Model.InvoiceDetailsv61ResponseBillToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseBillToInfo.md)
 - [Model.InvoiceDetailsv61ResponseFxRateInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseFxRateInfo.md)
 - [Model.InvoiceDetailsv61ResponseLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseLinesInner.md)
 - [Model.InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner.md)
 - [Model.InvoiceDetailsv61ResponsePaymentTermsInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponsePaymentTermsInfo.md)
 - [Model.InvoiceDetailsv61ResponseShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseShipToInfo.md)
 - [Model.InvoiceDetailsv61ResponseSummary](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseSummary.md)
 - [Model.InvoiceDetailsv61ResponseSummaryForeignFxTotals](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseSummaryForeignFxTotals.md)
 - [Model.InvoiceDetailsv61ResponseSummaryLines](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseSummaryLines.md)
 - [Model.InvoiceDetailsv61ResponseSummaryMiscChargesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseSummaryMiscChargesInner.md)
 - [Model.InvoiceDetailsv61ResponseSummaryTotals](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceDetailsv61ResponseSummaryTotals.md)
 - [Model.InvoiceSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceSearchResponse.md)
 - [Model.InvoiceSearchResponseInvoicesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/InvoiceSearchResponseInvoicesInner.md)
 - [Model.OrderCreateRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequest.md)
 - [Model.OrderCreateRequestAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestAdditionalAttributesInner.md)
 - [Model.OrderCreateRequestEndUserInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestEndUserInfo.md)
 - [Model.OrderCreateRequestLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestLinesInner.md)
 - [Model.OrderCreateRequestLinesInnerAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateRequestLinesInnerEndUserInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestLinesInnerEndUserInfoInner.md)
 - [Model.OrderCreateRequestLinesInnerWarrantyInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestLinesInnerWarrantyInfoInner.md)
 - [Model.OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner.md)
 - [Model.OrderCreateRequestResellerInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestResellerInfo.md)
 - [Model.OrderCreateRequestShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestShipToInfo.md)
 - [Model.OrderCreateRequestShipmentDetails](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestShipmentDetails.md)
 - [Model.OrderCreateRequestVmf](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateRequestVmf.md)
 - [Model.OrderCreateResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponse.md)
 - [Model.OrderCreateResponseEndUserInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseEndUserInfo.md)
 - [Model.OrderCreateResponseOrdersInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInner.md)
 - [Model.OrderCreateResponseOrdersInnerAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerLinesInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerLinksInner.md)
 - [Model.OrderCreateResponseOrdersInnerMiscellaneousChargesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerMiscellaneousChargesInner.md)
 - [Model.OrderCreateResponseOrdersInnerRejectedLineItemsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseOrdersInnerRejectedLineItemsInner.md)
 - [Model.OrderCreateResponseShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderCreateResponseShipToInfo.md)
 - [Model.OrderDetailB2B](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2B.md)
 - [Model.OrderDetailB2BAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BAdditionalAttributesInner.md)
 - [Model.OrderDetailB2BBillToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BBillToInfo.md)
 - [Model.OrderDetailB2BEndUserInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BEndUserInfo.md)
 - [Model.OrderDetailB2BLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInner.md)
 - [Model.OrderDetailB2BLinesInnerAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerEstimatedDatesInner.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerDeliveryDeliveryDateRange](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerEstimatedDatesInnerDeliveryDeliveryDateRange.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerShip](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerEstimatedDatesInnerShip.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange.md)
 - [Model.OrderDetailB2BLinesInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerLinksInner.md)
 - [Model.OrderDetailB2BLinesInnerMultipleShipmentsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerMultipleShipmentsInner.md)
 - [Model.OrderDetailB2BLinesInnerScheduleLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerScheduleLinesInner.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerServiceContractInfo.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfoContractInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerServiceContractInfoContractInfo.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfoSubscriptions](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerServiceContractInfoSubscriptions.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerShipmentDetailsInner.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInner.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner.md)
 - [Model.OrderDetailB2BMiscellaneousChargesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BMiscellaneousChargesInner.md)
 - [Model.OrderDetailB2BShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderDetailB2BShipToInfo.md)
 - [Model.OrderModifyRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyRequest.md)
 - [Model.OrderModifyRequestAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyRequestAdditionalAttributesInner.md)
 - [Model.OrderModifyRequestLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyRequestLinesInner.md)
 - [Model.OrderModifyRequestShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyRequestShipToInfo.md)
 - [Model.OrderModifyResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyResponse.md)
 - [Model.OrderModifyResponseLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyResponseLinesInner.md)
 - [Model.OrderModifyResponseLinesInnerAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyResponseLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderModifyResponseLinesInnerShipmentDetails](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyResponseLinesInnerShipmentDetails.md)
 - [Model.OrderModifyResponseRejectedLineItemsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyResponseRejectedLineItemsInner.md)
 - [Model.OrderModifyResponseShipToInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderModifyResponseShipToInfo.md)
 - [Model.OrderSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderSearchResponse.md)
 - [Model.OrderSearchResponseOrdersInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderSearchResponseOrdersInner.md)
 - [Model.OrderSearchResponseOrdersInnerLinks](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderSearchResponseOrdersInnerLinks.md)
 - [Model.OrderSearchResponseOrdersInnerSubOrdersInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderSearchResponseOrdersInnerSubOrdersInner.md)
 - [Model.OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner.md)
 - [Model.OrderStatusAsyncNotificationRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequest.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequestResourceInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInnerSerialNumberDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInnerSerialNumberDetailsInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/OrderStatusAsyncNotificationRequestResourceInnerLinksInner.md)
 - [Model.PostCreateorderV7400Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PostCreateorderV7400Response.md)
 - [Model.PostCreateorderV7400ResponseFieldsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PostCreateorderV7400ResponseFieldsInner.md)
 - [Model.PostCreateorderV7500Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PostCreateorderV7500Response.md)
 - [Model.PostRenewalssearch400Response](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PostRenewalssearch400Response.md)
 - [Model.PriceAndAvailabilityRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityRequest.md)
 - [Model.PriceAndAvailabilityRequestAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityRequestAdditionalAttributesInner.md)
 - [Model.PriceAndAvailabilityRequestAvailabilityByWarehouseInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityRequestAvailabilityByWarehouseInner.md)
 - [Model.PriceAndAvailabilityRequestProductsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityRequestProductsInner.md)
 - [Model.PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner.md)
 - [Model.PriceAndAvailabilityResponseInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInner.md)
 - [Model.PriceAndAvailabilityResponseInnerAvailability](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerAvailability.md)
 - [Model.PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner.md)
 - [Model.PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInnerBackOrderInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInnerBackOrderInfoInner.md)
 - [Model.PriceAndAvailabilityResponseInnerDiscountsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerDiscountsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner.md)
 - [Model.PriceAndAvailabilityResponseInnerPricing](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerPricing.md)
 - [Model.PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerServiceFeesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/PriceAndAvailabilityResponseInnerServiceFeesInner.md)
 - [Model.ProductDetailResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductDetailResponse.md)
 - [Model.ProductDetailResponseAdditionalInformation](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductDetailResponseAdditionalInformation.md)
 - [Model.ProductDetailResponseAdditionalInformationProductWeightInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductDetailResponseAdditionalInformationProductWeightInner.md)
 - [Model.ProductDetailResponseCiscoFields](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductDetailResponseCiscoFields.md)
 - [Model.ProductDetailResponseIndicators](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductDetailResponseIndicators.md)
 - [Model.ProductDetailResponseTechnicalSpecificationsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductDetailResponseTechnicalSpecificationsInner.md)
 - [Model.ProductSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductSearchResponse.md)
 - [Model.ProductSearchResponseCatalogInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductSearchResponseCatalogInner.md)
 - [Model.ProductSearchResponseCatalogInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ProductSearchResponseCatalogInnerLinksInner.md)
 - [Model.QuoteDetailsResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponse.md)
 - [Model.QuoteDetailsResponseAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseAdditionalAttributesInner.md)
 - [Model.QuoteDetailsResponseEndUserInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseEndUserInfo.md)
 - [Model.QuoteDetailsResponseProductsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseProductsInner.md)
 - [Model.QuoteDetailsResponseProductsInnerBillDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseProductsInnerBillDetailsInner.md)
 - [Model.QuoteDetailsResponseProductsInnerPrice](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseProductsInnerPrice.md)
 - [Model.QuoteDetailsResponseProductsInnerPriceDiscountsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseProductsInnerPriceDiscountsInner.md)
 - [Model.QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner.md)
 - [Model.QuoteDetailsResponseResellerInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseResellerInfo.md)
 - [Model.QuoteDetailsResponseShippingInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteDetailsResponseShippingInfo.md)
 - [Model.QuoteSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteSearchResponse.md)
 - [Model.QuoteSearchResponseQuotesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteSearchResponseQuotesInner.md)
 - [Model.QuoteSearchResponseQuotesInnerLinks](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/QuoteSearchResponseQuotesInnerLinks.md)
 - [Model.RenewalsDetailsResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsDetailsResponse.md)
 - [Model.RenewalsDetailsResponseAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsDetailsResponseAdditionalAttributesInner.md)
 - [Model.RenewalsDetailsResponseEndUserInfo](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsDetailsResponseEndUserInfo.md)
 - [Model.RenewalsDetailsResponseProductsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsDetailsResponseProductsInner.md)
 - [Model.RenewalsDetailsResponseReferenceNumber](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsDetailsResponseReferenceNumber.md)
 - [Model.RenewalsSearchRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequest.md)
 - [Model.RenewalsSearchRequestDateType](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestDateType.md)
 - [Model.RenewalsSearchRequestDateTypeEndDate](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestDateTypeEndDate.md)
 - [Model.RenewalsSearchRequestDateTypeExpirationDate](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestDateTypeExpirationDate.md)
 - [Model.RenewalsSearchRequestDateTypeInvoiceDate](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestDateTypeInvoiceDate.md)
 - [Model.RenewalsSearchRequestDateTypeStartDate](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestDateTypeStartDate.md)
 - [Model.RenewalsSearchRequestStatus](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestStatus.md)
 - [Model.RenewalsSearchRequestStatusOpporutinyStatus](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchRequestStatusOpporutinyStatus.md)
 - [Model.RenewalsSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchResponse.md)
 - [Model.RenewalsSearchResponseRenewalsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchResponseRenewalsInner.md)
 - [Model.RenewalsSearchResponseRenewalsInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/RenewalsSearchResponseRenewalsInnerLinksInner.md)
 - [Model.ReturnsCreateRequest](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsCreateRequest.md)
 - [Model.ReturnsCreateRequestListInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsCreateRequestListInner.md)
 - [Model.ReturnsCreateRequestListInnerShipFromInfoInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsCreateRequestListInnerShipFromInfoInner.md)
 - [Model.ReturnsCreateResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsCreateResponse.md)
 - [Model.ReturnsCreateResponseReturnsClaimsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsCreateResponseReturnsClaimsInner.md)
 - [Model.ReturnsDetailsResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsDetailsResponse.md)
 - [Model.ReturnsDetailsResponseProductsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsDetailsResponseProductsInner.md)
 - [Model.ReturnsSearchResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsSearchResponse.md)
 - [Model.ReturnsSearchResponseReturnsClaimsInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsSearchResponseReturnsClaimsInner.md)
 - [Model.ReturnsSearchResponseReturnsClaimsInnerLinksInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ReturnsSearchResponseReturnsClaimsInnerLinksInner.md)
 - [Model.ValidateQuoteResponse](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ValidateQuoteResponse.md)
 - [Model.ValidateQuoteResponseLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ValidateQuoteResponseLinesInner.md)
 - [Model.ValidateQuoteResponseLinesInnerVmfAdditionalAttributesLinesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ValidateQuoteResponseLinesInnerVmfAdditionalAttributesLinesInner.md)
 - [Model.ValidateQuoteResponseVmfAdditionalAttributesInner](https://github.com/ingrammicro-xvantage/xi-sdk-resellers-csharp/tree/main/docs/ValidateQuoteResponseVmfAdditionalAttributesInner.md)



## Documentation for Authorization


Authentication schemes defined for the API:
### application

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: https://api.ingrammicro.com:443/oauth/oauth20/token?grant_type=client_credentials&client_id={ClientId}&client_secret={clientSecret}
- **Method**: Get
- **Scopes**: 
  - write: allows modifying resources
  - read: allows reading resources
 

## Author
-[Ingram Micro Xvantage](https://github.com/ingrammicro-xvantage)

## Contact

For any inquiries or support, please feel free to contact us at:

- Email: xi_support@ingrammicro.com