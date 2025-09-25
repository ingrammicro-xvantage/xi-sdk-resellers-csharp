# xi.sdk.resellers.Api.DealsApi

All URIs are relative to *https://api.ingrammicro.com:443*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetResellersV6Dealsdetails**](DealsApi.md#getresellersv6dealsdetails) | **GET** /resellers/v6/deals/{dealId} | Deals Details |
| [**GetResellersV6Dealssearch**](DealsApi.md#getresellersv6dealssearch) | **GET** /resellers/v6/deals/search | Deals Search |

<a id="getresellersv6dealsdetails"></a>
# **GetResellersV6Dealsdetails**
> DealsDetailsResponse GetResellersV6Dealsdetails (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string iMApplicationId, string dealId, string vendorName)

Deals Details

The Deals Details API will retrieve all the details related to the specific deal id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace Example
{
    public class GetResellersV6DealsdetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DealsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMApplicationId = MyCompany;  // string | Unique value used to identify the sender of the transaction. Example: MyCompany
            var dealId = 12345678;  // string | Unique deal ID.
            var vendorName = Cisco;  // string | Vendor for that bid

            try
            {
                // Deals Details
                DealsDetailsResponse result = apiInstance.GetResellersV6Dealsdetails(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationId, dealId, vendorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DealsApi.GetResellersV6Dealsdetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6DealsdetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deals Details
    ApiResponse<DealsDetailsResponse> response = apiInstance.GetResellersV6DealsdetailsWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationId, dealId, vendorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DealsApi.GetResellersV6DealsdetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **iMApplicationId** | **string** | Unique value used to identify the sender of the transaction. Example: MyCompany |  |
| **dealId** | **string** | Unique deal ID. |  |
| **vendorName** | **string** | Vendor for that bid |  |

### Return type

[**DealsDetailsResponse**](DealsDetailsResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresellersv6dealssearch"></a>
# **GetResellersV6Dealssearch**
> DealsSearchResponse GetResellersV6Dealssearch (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null, string? endUser = null, string? vendor = null, string? dealId = null, int? size = null, int? page = null)

Deals Search

The Deals Search API, by default, will retrieve all the deals that are associated with the customer’s account. The customer will be able to search deals using the End-user name, Vendor name, or DealID. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace Example
{
    public class GetResellersV6DealssearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DealsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 
            var endUser = EnduserCompany;  // string? | The end user/customer's name. (optional) 
            var vendor = Cisco;  // string? | The vendor's name. (optional) 
            var dealId = 12345678;  // string? | Deal/Special bid number. (optional) 
            var size = 56;  // int? | The number of records required in the call - max records 100 per page. (optional) 
            var page = 56;  // int? | The page number reference. (optional) 

            try
            {
                // Deals Search
                DealsSearchResponse result = apiInstance.GetResellersV6Dealssearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, endUser, vendor, dealId, size, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DealsApi.GetResellersV6Dealssearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6DealssearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deals Search
    ApiResponse<DealsSearchResponse> response = apiInstance.GetResellersV6DealssearchWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, endUser, vendor, dealId, size, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DealsApi.GetResellersV6DealssearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |
| **endUser** | **string?** | The end user/customer&#39;s name. | [optional]  |
| **vendor** | **string?** | The vendor&#39;s name. | [optional]  |
| **dealId** | **string?** | Deal/Special bid number. | [optional]  |
| **size** | **int?** | The number of records required in the call - max records 100 per page. | [optional]  |
| **page** | **int?** | The page number reference. | [optional]  |

### Return type

[**DealsSearchResponse**](DealsSearchResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

