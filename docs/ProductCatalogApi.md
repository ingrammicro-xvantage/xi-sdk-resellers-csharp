# xi.sdk.resellers.Api.ProductCatalogApi

All URIs are relative to *https://api.ingrammicro.com:443*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetResellerV6Productdetail**](ProductCatalogApi.md#getresellerv6productdetail) | **GET** /resellers/v6/catalog/details/{ingramPartNumber} | Product Details |
| [**GetResellerV6Productdetailcmp**](ProductCatalogApi.md#getresellerv6productdetailcmp) | **GET** /resellers/v6/catalog/details | Product Details |
| [**GetResellerV6Productsearch**](ProductCatalogApi.md#getresellerv6productsearch) | **GET** /resellers/v6/catalog | Search Products |
| [**PostPriceandavailability**](ProductCatalogApi.md#postpriceandavailability) | **POST** /resellers/v6/catalog/priceandavailability | Price and Availability |

<a id="getresellerv6productdetail"></a>
# **GetResellerV6Productdetail**
> ProductDetailResponse GetResellerV6Productdetail (string ingramPartNumber, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null)

Product Details

Search all the product-related details using a unique Ingram Part Number. Currently, this API is available in the USA, India, and Netherlands.

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
    public class GetResellerV6ProductdetailExample
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
            var apiInstance = new ProductCatalogApi(httpClient, config, httpClientHandler);
            var ingramPartNumber = 6YE881;  // string | Ingram Micro unique part number for the product
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems
            var iMSenderID = MyCompany;  // string? | Sender Identification text (optional) 

            try
            {
                // Product Details
                ProductDetailResponse result = apiInstance.GetResellerV6Productdetail(ingramPartNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogApi.GetResellerV6Productdetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellerV6ProductdetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Product Details
    ApiResponse<ProductDetailResponse> response = apiInstance.GetResellerV6ProductdetailWithHttpInfo(ingramPartNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogApi.GetResellerV6ProductdetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingramPartNumber** | **string** | Ingram Micro unique part number for the product |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems |  |
| **iMSenderID** | **string?** | Sender Identification text | [optional]  |

### Return type

[**ProductDetailResponse**](ProductDetailResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresellerv6productdetailcmp"></a>
# **GetResellerV6Productdetailcmp**
> ProductDetailResponse GetResellerV6Productdetailcmp (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null, string? planName = null, string? planId = null, string? vendorPartNumber = null)

Product Details

Search all the product-related details.

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
    public class GetResellerV6ProductdetailcmpExample
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
            var apiInstance = new ProductCatalogApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems
            var iMSenderID = MyCompany;  // string? | Sender Identification text (optional) 
            var planName = "planName_example";  // string? | Name of the subscription plan (optional) 
            var planId = "planId_example";  // string? | Id of the subscription plan.   <span style='color:red'>To search for details of subscription products, customer must pass either vendorPartNumber, planName or planId.</span> (optional) 
            var vendorPartNumber = "vendorPartNumber_example";  // string? | Vendor’s part number for the product. (optional) 

            try
            {
                // Product Details
                ProductDetailResponse result = apiInstance.GetResellerV6Productdetailcmp(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, planName, planId, vendorPartNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogApi.GetResellerV6Productdetailcmp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellerV6ProductdetailcmpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Product Details
    ApiResponse<ProductDetailResponse> response = apiInstance.GetResellerV6ProductdetailcmpWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, planName, planId, vendorPartNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogApi.GetResellerV6ProductdetailcmpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems |  |
| **iMSenderID** | **string?** | Sender Identification text | [optional]  |
| **planName** | **string?** | Name of the subscription plan | [optional]  |
| **planId** | **string?** | Id of the subscription plan.   &lt;span style&#x3D;&#39;color:red&#39;&gt;To search for details of subscription products, customer must pass either vendorPartNumber, planName or planId.&lt;/span&gt; | [optional]  |
| **vendorPartNumber** | **string?** | Vendor’s part number for the product. | [optional]  |

### Return type

[**ProductDetailResponse**](ProductDetailResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | No Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresellerv6productsearch"></a>
# **GetResellerV6Productsearch**
> ProductSearchResponse GetResellerV6Productsearch (string iMCustomerNumber, string iMCorrelationID, string iMCountryCode, int? pageNumber = null, int? pageSize = null, string? iMSenderID = null, string? type = null, string? hasDiscounts = null, List<string>? vendor = null, List<string>? vendorPartNumber = null, string? acceptLanguage = null, string? vendorNumber = null, string? keyword = null, string? category = null, string? skipAuthorisation = null, string? groupName = null, string? planID = null, bool? showGroupInfo = null)

Search Products

Search the Ingram Micro product catalog by providing any of the information in the keyword(Ingram part number / vendor part number/ product description / UPC

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
    public class GetResellerV6ProductsearchExample
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
            var apiInstance = new ProductCatalogApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var pageNumber = 56;  // int? | Current page number. Default is 1 (optional) 
            var pageSize = 56;  // int? | Number of records required in the call - max records 100 per page (optional) 
            var iMSenderID = MyCompany;  // string? | Sender Identification text (optional) 
            var type = "IM::physical";  // string? | The SKU type of product. One of Physical, Digital, or Any. (optional) 
            var hasDiscounts = true;  // string? | Specifies if there are discounts available for the product. (optional) 
            var vendor = new List<string>?(); // List<string>? | The name of the vendor/manufacturer of the product. (optional) 
            var vendorPartNumber = new List<string>?(); // List<string>? | The vendors part number for the product. (optional) 
            var acceptLanguage = "\"en\"";  // string? | Header to the API calls, the content will help us identify the response language. (optional)  (default to "en")
            var vendorNumber = "vendorNumber_example";  // string? | Vendor number of the product (optional) 
            var keyword = "keyword_example";  // string? | Keyword search,can be ingram part number or vendor part number or product title or vendor nameKeyword search. Can be Ingram Micro part number, vender part number, product title, or vendor name. (optional) 
            var category = Accessories;  // string? | The category of the product. Example: Displays. (optional) 
            var skipAuthorisation = true;  // string? | This parameter is True when you want Skip the authorization, so template will work like current B2b template. (optional) 
            var groupName = Microsoft Defender for Endpoint P2 (NCE COM MTH);  // string? | Name of the Product Group (optional) 
            var planID = 471490;  // string? | ID of the plan (optional) 
            var showGroupInfo = true;  // bool? | In case of value true, below Group related information will displayed without the plan info. Group Name, Group Description, Number of plans, link in the group. A link will be provided if customer want to see all the plans in that group. (optional) 

            try
            {
                // Search Products
                ProductSearchResponse result = apiInstance.GetResellerV6Productsearch(iMCustomerNumber, iMCorrelationID, iMCountryCode, pageNumber, pageSize, iMSenderID, type, hasDiscounts, vendor, vendorPartNumber, acceptLanguage, vendorNumber, keyword, category, skipAuthorisation, groupName, planID, showGroupInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogApi.GetResellerV6Productsearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellerV6ProductsearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Products
    ApiResponse<ProductSearchResponse> response = apiInstance.GetResellerV6ProductsearchWithHttpInfo(iMCustomerNumber, iMCorrelationID, iMCountryCode, pageNumber, pageSize, iMSenderID, type, hasDiscounts, vendor, vendorPartNumber, acceptLanguage, vendorNumber, keyword, category, skipAuthorisation, groupName, planID, showGroupInfo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogApi.GetResellerV6ProductsearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **pageNumber** | **int?** | Current page number. Default is 1 | [optional]  |
| **pageSize** | **int?** | Number of records required in the call - max records 100 per page | [optional]  |
| **iMSenderID** | **string?** | Sender Identification text | [optional]  |
| **type** | **string?** | The SKU type of product. One of Physical, Digital, or Any. | [optional]  |
| **hasDiscounts** | **string?** | Specifies if there are discounts available for the product. | [optional]  |
| **vendor** | [**List&lt;string&gt;?**](string.md) | The name of the vendor/manufacturer of the product. | [optional]  |
| **vendorPartNumber** | [**List&lt;string&gt;?**](string.md) | The vendors part number for the product. | [optional]  |
| **acceptLanguage** | **string?** | Header to the API calls, the content will help us identify the response language. | [optional] [default to &quot;en&quot;] |
| **vendorNumber** | **string?** | Vendor number of the product | [optional]  |
| **keyword** | **string?** | Keyword search,can be ingram part number or vendor part number or product title or vendor nameKeyword search. Can be Ingram Micro part number, vender part number, product title, or vendor name. | [optional]  |
| **category** | **string?** | The category of the product. Example: Displays. | [optional]  |
| **skipAuthorisation** | **string?** | This parameter is True when you want Skip the authorization, so template will work like current B2b template. | [optional]  |
| **groupName** | **string?** | Name of the Product Group | [optional]  |
| **planID** | **string?** | ID of the plan | [optional]  |
| **showGroupInfo** | **bool?** | In case of value true, below Group related information will displayed without the plan info. Group Name, Group Description, Number of plans, link in the group. A link will be provided if customer want to see all the plans in that group. | [optional]  |

### Return type

[**ProductSearchResponse**](ProductSearchResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | a ProductSearchv6ResponseElement to be returned |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Sender Identification text . <br>  |
| **400** | Bad Request |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Sender Identification text . <br>  |
| **404** | No Content |  -  |
| **500** | Internal Server Error |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Sender Identification text . <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postpriceandavailability"></a>
# **PostPriceandavailability**
> List&lt;PriceAndAvailabilityResponseInner&gt; PostPriceandavailability (bool includeAvailability, bool includePricing, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, bool? includeProductAttributes = null, string? iMSenderID = null, PriceAndAvailabilityRequest? priceAndAvailabilityRequest = null)

Price and Availability

The PriceAndAvailability API, will retrieve Pricing, Availability, discounts, Inventory Location, Reserve Inventory for the products upto 50 products. 

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
    public class PostPriceandavailabilityExample
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
            var apiInstance = new ProductCatalogApi(httpClient, config, httpClientHandler);
            var includeAvailability = true;  // bool | Pass boolean value as input, if true the response will contain warehouse availability details, if false the response will not hold warehouse availability details
            var includePricing = true;  // bool | Pass boolean value as input, if true the response will contain Pricing details of the Product, if false the response will not hold Pricing details.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var includeProductAttributes = true;  // bool? | Pass boolean value as input, if true the response will contain detailed attributes related to the Product, if false or not sent the response will contain very few Product details. (optional) 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 
            var priceAndAvailabilityRequest = new PriceAndAvailabilityRequest?(); // PriceAndAvailabilityRequest? |  (optional) 

            try
            {
                // Price and Availability
                List<PriceAndAvailabilityResponseInner> result = apiInstance.PostPriceandavailability(includeAvailability, includePricing, iMCustomerNumber, iMCountryCode, iMCorrelationID, includeProductAttributes, iMSenderID, priceAndAvailabilityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogApi.PostPriceandavailability: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPriceandavailabilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price and Availability
    ApiResponse<List<PriceAndAvailabilityResponseInner>> response = apiInstance.PostPriceandavailabilityWithHttpInfo(includeAvailability, includePricing, iMCustomerNumber, iMCountryCode, iMCorrelationID, includeProductAttributes, iMSenderID, priceAndAvailabilityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogApi.PostPriceandavailabilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeAvailability** | **bool** | Pass boolean value as input, if true the response will contain warehouse availability details, if false the response will not hold warehouse availability details |  |
| **includePricing** | **bool** | Pass boolean value as input, if true the response will contain Pricing details of the Product, if false the response will not hold Pricing details. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **includeProductAttributes** | **bool?** | Pass boolean value as input, if true the response will contain detailed attributes related to the Product, if false or not sent the response will contain very few Product details. | [optional]  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |
| **priceAndAvailabilityRequest** | [**PriceAndAvailabilityRequest?**](PriceAndAvailabilityRequest?.md) |  | [optional]  |

### Return type

[**List&lt;PriceAndAvailabilityResponseInner&gt;**](PriceAndAvailabilityResponseInner.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **207** | Multi Status |  -  |
| **400** | Bad Request |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

