# xi.sdk.resellers.Api.OrdersApi

All URIs are relative to *https://api.ingrammicro.com:443*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteOrdercancel**](OrdersApi.md#deleteordercancel) | **DELETE** /resellers/v6/orders/{OrderNumber} | Cancel your Order |
| [**GetOrderdetailsV61**](OrdersApi.md#getorderdetailsv61) | **GET** /resellers/v6.1/orders/{ordernumber} | Get Order Details v6.1 |
| [**GetResellersV6Ordersearch**](OrdersApi.md#getresellersv6ordersearch) | **GET** /resellers/v6/orders/search | Search your Orders |
| [**PostCreateorderV6**](OrdersApi.md#postcreateorderv6) | **POST** /resellers/v6/orders | Create your Order |
| [**PostCreateorderV7**](OrdersApi.md#postcreateorderv7) | **POST** /resellers/v7/orders | Create your Order v7 |
| [**PutOrdermodify**](OrdersApi.md#putordermodify) | **PUT** /resellers/v6/orders/{orderNumber} | Modify your Order |
| [**VendorRequiredInfo**](OrdersApi.md#vendorrequiredinfo) | **POST** /resellers/v7/vendorrequiredinfo | Vendor Required Info |

<a id="deleteordercancel"></a>
# **DeleteOrdercancel**
> void DeleteOrdercancel (string orderNumber, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? regionCode = null, string? iMSenderID = null)

Cancel your Order

This call must be submitted before the order is released to Ingram Micro’s warehouse. The order cannot be canceled once it is released to the warehouse. Order should be on customer hold to delete any order from Ingram system.

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
    public class DeleteOrdercancelExample
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var orderNumber = 20-RD128;  // string | Ingram Micro sales order number.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var regionCode = CS;  // string? | Region code for sandbox testing - Not for use in production. (optional) 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 

            try
            {
                // Cancel your Order
                apiInstance.DeleteOrdercancel(orderNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, regionCode, iMSenderID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.DeleteOrdercancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrdercancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel your Order
    apiInstance.DeleteOrdercancelWithHttpInfo(orderNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, regionCode, iMSenderID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.DeleteOrdercancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderNumber** | **string** | Ingram Micro sales order number. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems. |  |
| **regionCode** | **string?** | Region code for sandbox testing - Not for use in production. | [optional]  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |

### Return type

void (empty response body)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **400** | Bad Request |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **404** | Not Found |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **405** | Method Not Allowed |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **500** | Internal Server Error |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorderdetailsv61"></a>
# **GetOrderdetailsV61**
> OrderDetailB2B GetOrderdetailsV61 (string ordernumber, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null, DateOnly? ingramOrderDate = null, string? vendorNumber = null, string? simulateStatus = null, bool? isIml = null, string? regionCode = null)

Get Order Details v6.1

The Orders details API endpoint allows a customer to retrieve their Ingram Micro orders details by using the Ingram Micro sales order number as a path parameter. The sales order number, IM-CustomerNumber, IM-CountryCode, and IM-CorrelationID are required parameters.<br><br>*Service contracts, subscriptions, and license information are unavailable at the moment, this information will be available in the future. <br><br> Recent bug fixes:   - Fixed duplication of serial numbers in the API response.   - Fixed API time-out issues   - Fixed missing tracking information.   - Implemented enhanced order status.  

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
    public class GetOrderdetailsV61Example
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var ordernumber = 20-RD3QV;  // string | The Ingram Micro sales order number.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany. (optional) 
            var ingramOrderDate = Wed May 13 00:00:00 UTC 2020;  // DateOnly? | The date and time in UTC format that the order was created. (optional) 
            var vendorNumber = "vendorNumber_example";  // string? | Vendor Number. (optional) 
            var simulateStatus = "IM::SHIPPED";  // string? | Order response for various order statuses. Not for use in production. (optional) 
            var isIml = true;  // bool? | True/False only for IML customers. (optional) 
            var regionCode = "regionCode_example";  // string? | Region code for sandbox testing - Not for use in production. (optional) 

            try
            {
                // Get Order Details v6.1
                OrderDetailB2B result = apiInstance.GetOrderdetailsV61(ordernumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, ingramOrderDate, vendorNumber, simulateStatus, isIml, regionCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderdetailsV61: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderdetailsV61WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order Details v6.1
    ApiResponse<OrderDetailB2B> response = apiInstance.GetOrderdetailsV61WithHttpInfo(ordernumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, ingramOrderDate, vendorNumber, simulateStatus, isIml, regionCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetOrderdetailsV61WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordernumber** | **string** | The Ingram Micro sales order number. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany. | [optional]  |
| **ingramOrderDate** | **DateOnly?** | The date and time in UTC format that the order was created. | [optional]  |
| **vendorNumber** | **string?** | Vendor Number. | [optional]  |
| **simulateStatus** | **string?** | Order response for various order statuses. Not for use in production. | [optional]  |
| **isIml** | **bool?** | True/False only for IML customers. | [optional]  |
| **regionCode** | **string?** | Region code for sandbox testing - Not for use in production. | [optional]  |

### Return type

[**OrderDetailB2B**](OrderDetailB2B.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresellersv6ordersearch"></a>
# **GetResellersV6Ordersearch**
> OrderSearchResponse GetResellersV6Ordersearch (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? ingramOrderNumber = null, string? orderStatus = null, List<string>? orderStatusIn = null, string? ingramOrderDate = null, List<string>? ingramOrderDateBt = null, string? iMSenderID = null, string? customerOrderNumber = null, int? pageSize = null, int? pageNumber = null, string? endCustomerOrderNumber = null, List<string>? invoiceDateBt = null, List<string>? shipDateBt = null, List<string>? deliveryDateBt = null, string? ingramPartNumber = null, string? vendorPartNumber = null, string? serialNumber = null, string? trackingNumber = null, string? vendorName = null, string? specialBidNumber = null)

Search your Orders

The Orders Search API endpoint allows a customer to search their Ingram Micro orders by using any of the available query string parameters, customer can search their order by using single query string parameters or combining them together. This endpoint supports the pagination of results.

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
    public class GetResellersV6OrdersearchExample
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var ingramOrderNumber = "ingramOrderNumber_example";  // string? | The Ingram Micro order number. (optional) 
            var orderStatus = "SHIPPED";  // string? | Ingram Micro order status. (optional) 
            var orderStatusIn = new List<string>?(); // List<string>? | Ingram Micro order status(can use it for multiple entries). (optional) 
            var ingramOrderDate = 2021-04-23;  // string? | Search by Order date(yyyy-MM-dd). (optional) 
            var ingramOrderDateBt = new List<string>?(); // List<string>? | Search with the start and end date(only 2 entries allowed). (optional) 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 
            var customerOrderNumber = "customerOrderNumber_example";  // string? | Search using your PO/Order number. (optional) 
            var pageSize = 56;  // int? | The number of records required in the call - max records 100 per page. (optional) 
            var pageNumber = 56;  // int? | The page number reference. (optional) 
            var endCustomerOrderNumber = "endCustomerOrderNumber_example";  // string? | End customer/user purchase order number. (optional) 
            var invoiceDateBt = new List<string>?(); // List<string>? | Invoice date of order, search with the start and end date(only 2 entries allowed).*Currently, this feature is not available in Australia. (optional) 
            var shipDateBt = new List<string>?(); // List<string>? | Shipment date of order, search with the start and end date(only 2 entries allowed). (optional) 
            var deliveryDateBt = new List<string>?(); // List<string>? | The delivery date of the order, search with the start and end date(only 2 entries allowed).*Currently, this feature is not available in Australia (optional) 
            var ingramPartNumber = "ingramPartNumber_example";  // string? | Ingram Micro unique part number for the product. (optional) 
            var vendorPartNumber = "vendorPartNumber_example";  // string? | Vendor’s part number for the product. (optional) 
            var serialNumber = "serialNumber_example";  // string? | A serial number of the product. (optional) 
            var trackingNumber = "trackingNumber_example";  // string? | The tracking number of the order.*Currently, this feature is not available in Australia (optional) 
            var vendorName = "vendorName_example";  // string? | Name of the vendor. (optional) 
            var specialBidNumber = "specialBidNumber_example";  // string? | The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.*Currently, this feature is not available in Australia (optional) 

            try
            {
                // Search your Orders
                OrderSearchResponse result = apiInstance.GetResellersV6Ordersearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, ingramOrderNumber, orderStatus, orderStatusIn, ingramOrderDate, ingramOrderDateBt, iMSenderID, customerOrderNumber, pageSize, pageNumber, endCustomerOrderNumber, invoiceDateBt, shipDateBt, deliveryDateBt, ingramPartNumber, vendorPartNumber, serialNumber, trackingNumber, vendorName, specialBidNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetResellersV6Ordersearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6OrdersearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search your Orders
    ApiResponse<OrderSearchResponse> response = apiInstance.GetResellersV6OrdersearchWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, ingramOrderNumber, orderStatus, orderStatusIn, ingramOrderDate, ingramOrderDateBt, iMSenderID, customerOrderNumber, pageSize, pageNumber, endCustomerOrderNumber, invoiceDateBt, shipDateBt, deliveryDateBt, ingramPartNumber, vendorPartNumber, serialNumber, trackingNumber, vendorName, specialBidNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetResellersV6OrdersearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems. |  |
| **ingramOrderNumber** | **string?** | The Ingram Micro order number. | [optional]  |
| **orderStatus** | **string?** | Ingram Micro order status. | [optional]  |
| **orderStatusIn** | [**List&lt;string&gt;?**](string.md) | Ingram Micro order status(can use it for multiple entries). | [optional]  |
| **ingramOrderDate** | **string?** | Search by Order date(yyyy-MM-dd). | [optional]  |
| **ingramOrderDateBt** | [**List&lt;string&gt;?**](string.md) | Search with the start and end date(only 2 entries allowed). | [optional]  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |
| **customerOrderNumber** | **string?** | Search using your PO/Order number. | [optional]  |
| **pageSize** | **int?** | The number of records required in the call - max records 100 per page. | [optional]  |
| **pageNumber** | **int?** | The page number reference. | [optional]  |
| **endCustomerOrderNumber** | **string?** | End customer/user purchase order number. | [optional]  |
| **invoiceDateBt** | [**List&lt;string&gt;?**](string.md) | Invoice date of order, search with the start and end date(only 2 entries allowed).*Currently, this feature is not available in Australia. | [optional]  |
| **shipDateBt** | [**List&lt;string&gt;?**](string.md) | Shipment date of order, search with the start and end date(only 2 entries allowed). | [optional]  |
| **deliveryDateBt** | [**List&lt;string&gt;?**](string.md) | The delivery date of the order, search with the start and end date(only 2 entries allowed).*Currently, this feature is not available in Australia | [optional]  |
| **ingramPartNumber** | **string?** | Ingram Micro unique part number for the product. | [optional]  |
| **vendorPartNumber** | **string?** | Vendor’s part number for the product. | [optional]  |
| **serialNumber** | **string?** | A serial number of the product. | [optional]  |
| **trackingNumber** | **string?** | The tracking number of the order.*Currently, this feature is not available in Australia | [optional]  |
| **vendorName** | **string?** | Name of the vendor. | [optional]  |
| **specialBidNumber** | **string?** | The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.*Currently, this feature is not available in Australia | [optional]  |

### Return type

[**OrderSearchResponse**](OrderSearchResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OrderSearch_Response to be returned |  -  |
| **204** | No Content |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcreateorderv6"></a>
# **PostCreateorderV6**
> OrderCreateResponse PostCreateorderV6 (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, OrderCreateRequest orderCreateRequest, string? iMSenderID = null)

Create your Order

Instantly create and place orders. The POST API supports stocked SKUs as well as licensing and warranties SKUs. IM-CustomerNumber, IM-CountryCode, IM-SenderID and IM-CorrelationID are required parameters. Ingram Micro recommends that you provide the ingrampartnumber for each SKU contained in each order. NOTE: You must have net terms to use the Ingram Micro Order Create API. Ingram Micro offers trade credit when using our APIs, and repayment is based on net terms. For example, if your net terms agreement is net-30, you will have 30 days to make a full payment. Ingram Micro does not allow credit card transactions for API ordering. 

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
    public class PostCreateorderV6Example
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var orderCreateRequest = new OrderCreateRequest(); // OrderCreateRequest | 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 

            try
            {
                // Create your Order
                OrderCreateResponse result = apiInstance.PostCreateorderV6(iMCustomerNumber, iMCountryCode, iMCorrelationID, orderCreateRequest, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.PostCreateorderV6: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCreateorderV6WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create your Order
    ApiResponse<OrderCreateResponse> response = apiInstance.PostCreateorderV6WithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, orderCreateRequest, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.PostCreateorderV6WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems. |  |
| **orderCreateRequest** | [**OrderCreateRequest**](OrderCreateRequest.md) |  |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |

### Return type

[**OrderCreateResponse**](OrderCreateResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **207** | Multi-Status |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **400** | Bad Request |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **500** | Internal Server Error |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcreateorderv7"></a>
# **PostCreateorderV7**
> OrderCreateV7Response201 PostCreateorderV7 (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, OrderCreateV7Request orderCreateV7Request, string? iMSenderID = null)

Create your Order v7

The Order Create v7 allows our customers to create orders asynchronously. The customer can create either standard orders using stocked SKUs and/or create a “Quote to Order” using the existing quote which is in “Ready to Order” status, or the customer can create an order using the “Configure to order” (CTO) quote. Upon successful submission of the order create request, a confirmation message will be returned as an API response. <br > <br > Once the order is processed, Ingram Micro will notify customers via webhook using a pre-defined callback URL as an HTTP post regarding the updates related to the order. Upon successful order creation, a notification will be sent via webhook regarding the order details, in the event of any error occurring during the order creation process, an error message will be delivered via webhook. Nightly system unavailability will delay response Async response. <br > <br > The key differentiator between standard ordering and “Quote To Order” is the optional input field in the request body which is “quoteNumber”. If a customer passes the quote number in the request body, the order will be processed as a “Quote To Order” using the details from the quote. Any SKUs, quantity, or price information that are passed in the lines object within the request will be ignored in the case of “Quote To Order”.<br > <br > **Prerequisite:** Pre-defined callback URL <br > <br > **Standard ordering::**<br><br>Ingram Micro recommends that you provide the ingramPartNumber for each SKU contained in each order. NOTE: You must have net terms to use the Ingram Micro Order Create API. Ingram Micro offers trade credit when using our APIs, and repayment is based on net terms. For example, if your net terms agreement is net 30, you will have 30 days to make a full payment. Ingram Micro does not allow credit card transactions for API ordering. <br><br>[**Key differences between v6 and v7 Migration**](https://developer.ingrammicro.com/reseller/page/v6-and-v7-migration) <br><br> <br><br>**Quote to Order / Configure to Order:**<br><br>If customers are planning to use Quote to Order or Configure to Order Quotes, it’s recommended to validate the quote using the “Validate Quote” endpoint before creating an order using the quote. Validate Quote endpoint will not only validate the quote but also outline all the mandatory fields required by the vendor at a header level and at the line level which a customer needs to pass to the Quote to Order endpoint request. For a detailed understanding of the “Validate Quote” endpoint, review the “Validate Quote” endpoint documentation. <br><br> **How it works:**<br><br>- The customer validates the quote with a quote number from the Validate Quote endpoint.<br>- The customer copies all the mandatory fields required by the vendor and adds them to the QTO request body.<br>- The customer provides all the values for Vendor mandatory fields along with other required information for QTO to create an order.<br>- After the order creation request receipt acknowledgment from the QTO endpoint, all further order creation updates will be provided via webhook push notification.

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
    public class PostCreateorderV7Example
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var orderCreateV7Request = new OrderCreateV7Request(); // OrderCreateV7Request | 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 

            try
            {
                // Create your Order v7
                OrderCreateV7Response201 result = apiInstance.PostCreateorderV7(iMCustomerNumber, iMCountryCode, iMCorrelationID, orderCreateV7Request, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.PostCreateorderV7: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCreateorderV7WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create your Order v7
    ApiResponse<OrderCreateV7Response201> response = apiInstance.PostCreateorderV7WithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, orderCreateV7Request, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.PostCreateorderV7WithHttpInfo: " + e.Message);
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
| **orderCreateV7Request** | [**OrderCreateV7Request**](OrderCreateV7Request.md) |  |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |

### Return type

[**OrderCreateV7Response201**](OrderCreateV7Response201.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Confirmation response |  -  |
| **201** | Webhook Response |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putordermodify"></a>
# **PutOrdermodify**
> OrderModifyResponse PutOrdermodify (string orderNumber, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, OrderModifyRequest orderModifyRequest, string? actionCode = null, string? regionCode = null, string? iMSenderID = null)

Modify your Order

The Order Modify API endpoint allows for changes to be made to an order after the order creation process as long as the order was created with the customer hold flag.  * Orders can be modified within 24hrs of being placed with the customer hold flag, after 24hrs they are voided if they are not released by the customer.  * Modifying orders that were placed without the customer hold flag is not possible 

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
    public class PutOrdermodifyExample
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var orderNumber = 20-RC1RD;  // string | Ingram sales order number.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var orderModifyRequest = new OrderModifyRequest(); // OrderModifyRequest | 
            var actionCode = release;  // string? | Action code to be used for order release. (optional) 
            var regionCode = CS;  // string? | Region code paramter to be used only for order release functionality.Region code is only for sandbox not for production (optional) 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 

            try
            {
                // Modify your Order
                OrderModifyResponse result = apiInstance.PutOrdermodify(orderNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, orderModifyRequest, actionCode, regionCode, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.PutOrdermodify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutOrdermodifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify your Order
    ApiResponse<OrderModifyResponse> response = apiInstance.PutOrdermodifyWithHttpInfo(orderNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, orderModifyRequest, actionCode, regionCode, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.PutOrdermodifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderNumber** | **string** | Ingram sales order number. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **orderModifyRequest** | [**OrderModifyRequest**](OrderModifyRequest.md) |  |  |
| **actionCode** | **string?** | Action code to be used for order release. | [optional]  |
| **regionCode** | **string?** | Region code paramter to be used only for order release functionality.Region code is only for sandbox not for production | [optional]  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |

### Return type

[**OrderModifyResponse**](OrderModifyResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **201** | Created |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **207** | Multi-Status |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **400** | Bad Request |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorrequiredinfo"></a>
# **VendorRequiredInfo**
> List&lt;VendorRequiredInforesponseInner&gt; VendorRequiredInfo (string iMCustomerNumber, string iMCorrelationID, string iMCountryCode, string iMSenderID, VendorRequiredInfoRequest? vendorRequiredInfoRequest = null)

Vendor Required Info

<p>The vendor required info API allows customers to identify all the mandatory fields that will be required to create an order before placing an order. These fields are required by the vendor to process orders. The customers can identify Vendor Required Information, aka Vendor Mandatory Fields or VMFs, using any of the following.</p><ul><li>Ingram Part Number</li><li>Vendor Part Number</li><li>Plan ID</li><li>Ingram Quote Number</li></ul><p>For the non-cloud Technology Solutions products, such as Hardware, Software, or Warranty, the VMFs will be returned in the “vmfAdditionalAttributes” object in the response, whereas for the cloud subscriptions products, the VMFs will be returned in the “vriAdditionalAttributes” object in the response.</p><p>While creating an Order Create request for the non-cloud products, such as Hardware, Software, or Warranty, pass “vmfAdditionalAttributes” object with the necessary response in the “attributeValue” field.</p><p>While creating an Order Create request, for Subscription products, pass “vriAdditionalAttributes” object with the necessary response in the “attributeValue” field and any other applicable subcomponents to create an order. </p>

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
    public class VendorRequiredInfoExample
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
            var apiInstance = new OrdersApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMSenderID = MyCompany;  // string | Unique value used to identify the sender of the transaction. 
            var vendorRequiredInfoRequest = new VendorRequiredInfoRequest?(); // VendorRequiredInfoRequest? |  (optional) 

            try
            {
                // Vendor Required Info
                List<VendorRequiredInforesponseInner> result = apiInstance.VendorRequiredInfo(iMCustomerNumber, iMCorrelationID, iMCountryCode, iMSenderID, vendorRequiredInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.VendorRequiredInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorRequiredInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Vendor Required Info
    ApiResponse<List<VendorRequiredInforesponseInner>> response = apiInstance.VendorRequiredInfoWithHttpInfo(iMCustomerNumber, iMCorrelationID, iMCountryCode, iMSenderID, vendorRequiredInfoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.VendorRequiredInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMSenderID** | **string** | Unique value used to identify the sender of the transaction.  |  |
| **vendorRequiredInfoRequest** | [**VendorRequiredInfoRequest?**](VendorRequiredInfoRequest?.md) |  | [optional]  |

### Return type

[**List&lt;VendorRequiredInforesponseInner&gt;**](VendorRequiredInforesponseInner.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

