# xi.sdk.resellers.Model.OrderCreateV7RequestLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerLineNumber** | **string** | The reseller&#39;s line item number for reference in their system. The customer line number needs to be a unique numeric value between 1 and 884. In the event we receive duplicate values or alphanumeric values in the customer line number, we will re-sequence the customer line number. To prevent re-sequencing, please use a unique numeric value between 1 and 884 in the customer line number. | [optional] 
**IngramPartNumber** | **string** | The unique IngramMicro part number. | [optional] 
**VendorPartNumber** | **string** | The vendor&#39;s part number for the line item. | [optional] 
**Quantity** | **int** | The requested quantity of the line item. | [optional] 
**UnitPrice** | **decimal** | The reseller-requested unit price for the line item. The unit price is not guaranteed. | [optional] 
**SpecialBidNumber** | **string** | The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid number take precedence over header-level bid numbers. | [optional] 
**EndUserPrice** | **decimal** | The end-user price. Required for Export Orders. | [optional] 
**Notes** | **string** | The attribute field data. | [optional] 
**ResourceId** | **string** | The resource id of the subscription | [optional] 
**Planid** | **string** | ID of the subscription plan | [optional] 
**SubscriptionPeriod** | [**OrderCreateV7RequestLinesInnerSubscriptionPeriod**](OrderCreateV7RequestLinesInnerSubscriptionPeriod.md) |  | [optional] 
**BillingPeriod** | [**OrderCreateV7RequestLinesInnerBillingPeriod**](OrderCreateV7RequestLinesInnerBillingPeriod.md) |  | [optional] 
**Margin** | **decimal** | Line-level margin requested by customer | [optional] 
**EndCustomerPrice** | **decimal** | Line-level end-customer price requsted by customer | [optional] 
**VriAdditionalAttributes** | [**List&lt;OrderCreateV7RequestVmfVendorAdditionalAttributesInner&gt;**](OrderCreateV7RequestVmfVendorAdditionalAttributesInner.md) | The object containing the list of Vendor Mandatory Fields required by the vendor for the subscription products. | [optional] 
**EndUserInfo** | [**List&lt;OrderCreateV7RequestLinesInnerEndUserInfoInner&gt;**](OrderCreateV7RequestLinesInnerEndUserInfoInner.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;OrderCreateV7RequestLinesInnerAdditionalAttributesInner&gt;**](OrderCreateV7RequestLinesInnerAdditionalAttributesInner.md) |  | [optional] 
**WarrantyInfo** | [**OrderCreateV7RequestLinesInnerWarrantyInfo**](OrderCreateV7RequestLinesInnerWarrantyInfo.md) |  | [optional] 
**VmfAdditionalAttributesLines** | [**List&lt;OrderCreateV7RequestLinesInnerVmfAdditionalAttributesLinesInner&gt;**](OrderCreateV7RequestLinesInnerVmfAdditionalAttributesLinesInner.md) | The object containing the list of fields required at a line level by the vendor.&lt;br&gt; This a &lt;code&gt;Deprecated&lt;/code&gt; object. Kindly use &lt;b&gt;vmfVendorAdditionalAttributes&lt;/b&gt; object | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

