# xi.sdk.resellers.Model.ProductDetailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngramPartNumber** | **string** | Ingram Micro unique part number for the product. | [optional] 
**VendorPartNumber** | **string** | Vendor’s part number for the product. | [optional] 
**ProductAuthorized** | **string** | Boolean that indicates whether a product is authorized. | [optional] 
**Description** | **string** | The description given for the product. | [optional] 
**Upc** | **string** | The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item. | [optional] 
**ProductCategory** | **string** | The category of the product. | [optional] 
**ProductSubcategory** | **string** | The sub-category of the product. | [optional] 
**VendorName** | **string** | Vendor name for the order. | [optional] 
**VendorNumber** | **string** | Vendor number that identifies the product. | [optional] 
**ProductStatusCode** | **string** | Status code of the product. | [optional] 
**ProductClass** | **string** | Indicates whether the product is directly shipped from the vendor’s warehouse or if the product ships from Ingram Micro’s warehouse. Class Codes are Ingram classifications on how skus are stocked A &#x3D; Product that is stocked usually in all IM warehouses and replenished on a regular basis. B &#x3D; Product that is stocked in limited IM warehouses and replenished on a regular basis C &#x3D; Product that is stocked in fewer IM warehouses and replenished on a regular basis. D &#x3D; Product that Ingram Micro has elected to discontinue. E &#x3D; Product that will be phased out later, according to the vendor. You may not want to replenish this product, but instead sell down what is in stock. F &#x3D; Product that we carry for a specific customer or supplier under a contractual agreement. N &#x3D; New Sku. Classification before first receipt O &#x3D; Discontinued product to be liquidated S&#x3D; Order for Specialized Demand (Order to backorder) X&#x3D; direct ship from Vendor V &#x3D; product that vendor has elected to discontinue. | [optional] 
**CustomerPartNumber** | **string** | Reseller / end-user’s part number for the product. | [optional] 
**Indicators** | [**ProductDetailResponseIndicators**](ProductDetailResponseIndicators.md) |  | [optional] 
**CiscoFields** | [**ProductDetailResponseCiscoFields**](ProductDetailResponseCiscoFields.md) |  | [optional] 
**WarrantyInformation** | **List&lt;string&gt;** | Warranty codes related to the product. | [optional] 
**AdditionalInformation** | [**ProductDetailResponseAdditionalInformation**](ProductDetailResponseAdditionalInformation.md) |  | [optional] 
**SubscriptionDetails** | [**List&lt;ProductDetailResponseSubscriptionDetailsInner&gt;**](ProductDetailResponseSubscriptionDetailsInner.md) | Subscription product Details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

