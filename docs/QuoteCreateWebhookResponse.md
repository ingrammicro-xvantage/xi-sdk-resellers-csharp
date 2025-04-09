# xi.sdk.resellers.Model.QuoteCreateWebhookResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Topic** | **string** | Field for identifying whether it is a reseller or vendor event. For eg, resellers/orders | [optional] 
**Event** | **string** | The event sent in the request. For eg, im::create. | [optional] 
**EventTimeStamp** | **string** | The timestamp at which the event was sent. | [optional] 
**EventId** | **string** | A unique id used as identifier for the sepcific event and used for generating the x-hub signature. | [optional] 
**Resource** | [**QuoteCreateWebhookResponseResource**](QuoteCreateWebhookResponseResource.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

