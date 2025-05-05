# xi.sdk.resellers.Model.FreightRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillToAddressId** | **Object** | Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit. | [optional] 
**ShipToAddressId** | **string** | The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process. | [optional] 
**ShipToAddress** | [**FreightRequestShipToAddress**](FreightRequestShipToAddress.md) |  | [optional] 
**Lines** | [**List&lt;FreightRequestLinesInner&gt;**](FreightRequestLinesInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

