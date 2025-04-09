# xi.sdk.resellers.Model.QuoteCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteName** | **string** | Quote Name given to quote by sales team or system generated. Generally used as a reference to identify the quote. | [optional] 
**Firstname** | **string** | Logged in Users firstname | [optional] 
**Lastname** | **string** | Logged in Users Lastname | [optional] 
**CustomerContact** | **string** | Logged in Users email address contact. | [optional] 
**QuoteExpiryDate** | **string** | The date on which a quote will expire. | [optional] 
**CustomerNeed** | **string** | Any special need from the customer. | [optional] 
**EndUserInfo** | [**QuoteCreateRequestEndUserInfo**](QuoteCreateRequestEndUserInfo.md) |  | [optional] 
**DealId** | **string** | Price discount identifyer to specify a pricing discount that has been applied to the quote. | [optional] 
**PricingType** | **string** | Pricing type of the quote. | [optional] 
**SendQuoteCopy** | **string** | List of email addressed to whom the quote will be emailed after it&#39;s created. (Max 10 email ids) | [optional] 
**Products** | [**List&lt;QuoteCreateRequestProductsInner&gt;**](QuoteCreateRequestProductsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

