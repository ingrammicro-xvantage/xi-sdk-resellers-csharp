# xi.sdk.resellers.Model.OrderCreateV7ResponseResourceOrdersInnerLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubOrderNumber** | **string** | The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number. | [optional] 
**IngramLineNumber** | **string** | The Ingram Micro line number for the product. | [optional] 
**CustomerLineNumber** | **string** | The reseller&#39;s line number for reference in their system. | [optional] 
**LineStatus** | **string** | The status for the line item in the order. One of: Backordered, Open | [optional] 
**IngramPartNumber** | **string** | The Ingram Micro part number for the line item. | [optional] 
**UnitPrice** | **decimal** | The unit price for the line item. | [optional] 
**ExtendedUnitPrice** | **decimal** | The extended list price (unit price X quantity) for the line item. | [optional] 
**QuantityOrdered** | **int** | The quantity of the line item ordered. | [optional] 
**QuantityConfirmed** | **int** | The quantity of the line item that has been confirmed. | [optional] 
**QuantityBackOrdered** | **int** | The quantity of the line item that is backordered. | [optional] 
**Notes** | **string** | Line-level notes. | [optional] 
**ShipmentDetails** | [**List&lt;OrderCreateV7ResponseResourceOrdersInnerLinesInnerShipmentDetailsInner&gt;**](OrderCreateV7ResponseResourceOrdersInnerLinesInnerShipmentDetailsInner.md) | The shipment details for the line item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

