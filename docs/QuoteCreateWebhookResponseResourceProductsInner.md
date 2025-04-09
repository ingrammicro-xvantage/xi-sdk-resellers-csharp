# xi.sdk.resellers.Model.QuoteCreateWebhookResponseResourceProductsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteProductGuid** | **string** | Quote Product GUID  is the primary quote key in Ingram Micro&#39;s CRM - needed to retrieve quote details. | [optional] 
**LineNumber** | **string** | Line number which the product will appear in the quote.  Line number is manditory when unique configurations are included in a quote and mainting the item line order is required. | [optional] 
**Quantity** | **string** | Quantity of product line item quoted. | [optional] 
**Notes** | **string** | Product line item comments. | [optional] 
**Ean** | **string** | EANUPC | [optional] 
**Coo** | **string** | Country of Origin. | [optional] 
**IngramPartNumber** | **string** | Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes | [optional] 
**VendorPartNumber** | **string** | Vendor Part Number | [optional] 
**Description** | **string** | Product description.  Note - The quote view api returns only the product short description as maintained in Ingram Micro&#39;s crm system.  For long descriptions, please refer to alternative information sources. | [optional] 
**Weight** | **string** | Weight is provided based on country standard.  For countries following Imperial standards - weight is presented as pounds with decimal.  In countries following metric standards, weight is provided as kilograms with decimal. | [optional] 
**WeightUom** | **string** | Unit of measure | [optional] 
**IsSuggestionProduct** | **string** | Flag to indicate if a product line item is a suggested product.  The suggested product is provided in addition to the requested quoted products and a suggested option.  Suggested products are grouped together for subtotal and total calculations. | [optional] 
**VpnCategory** | **string** | Vendor product category specific to Cisco. HWDW (hardware) or service. | [optional] 
**QuoteProductsSupplierPartAuxiliaryId** | **string** | Vendor product configuration ID specific to Cisco. | [optional] 
**VendorName** | **string** | Vendor name of the product | [optional] 
**Terms** | **string** | Terms of the quote | [optional] 
**Price** | [**QuoteCreateWebhookResponseResourceProductsInnerPrice**](QuoteCreateWebhookResponseResourceProductsInnerPrice.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

