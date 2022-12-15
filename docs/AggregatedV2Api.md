# kern.services.FroniusSolarWebClient.Api.AggregatedV2Api

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsPvSystemIdAggrdataGet**](AggregatedV2Api.md#pvsystemspvsystemidaggrdataget) | **GET** /pvsystems/{pvSystemId}/aggrdata | Gets aggregated data for a given PV system for a custom period of time. Filters allow limiting to specific PV system energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa. |
| [**PvsystemsPvSystemIdDevicesDeviceIdAggrdataGet**](AggregatedV2Api.md#pvsystemspvsystemiddevicesdeviceidaggrdataget) | **GET** /pvsystems/{pvSystemId}/devices/{deviceId}/aggrdata | Gets aggregated data for a given inverter for a custom period of time. Filters allow limiting to specific device energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa. |

<a name="pvsystemspvsystemidaggrdataget"></a>
# **PvsystemsPvSystemIdAggrdataGet**
> AggrValues PvsystemsPvSystemIdAggrdataGet (Guid pvSystemId, string? channel = null, string? from = null, string? to = null, string? duration = null, string? period = null, int? offset = null, int? limit = null)

Gets aggregated data for a given PV system for a custom period of time. Filters allow limiting to specific PV system energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggrdataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.solarweb.com/swqapi";
            // Configure API key authorization: AccessKeyId
            config.AddApiKey("AccessKeyId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccessKeyId", "Bearer");
            // Configure API key authorization: AccessKeyValue
            config.AddApiKey("AccessKeyValue", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccessKeyValue", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AggregatedV2Api(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var channel = "channel_example";  // string? | Limits query by selected channel. Note: Channel filters can be concatened using commas. E.g,: ?channel=EnergyFeedIn,EnergyPurchased (optional) 
            var from = "from_example";  // string? | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. (optional) 
            var to = "to_example";  // string? | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. (optional) 
            var duration = "duration_example";  // string? | Duration is measured in years, months or days - depending on the from parameter. A duration of 1 means that start and end are equal.  Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. (optional) 
            var period = "period_example";  // string? | Limits the time series for the query to a period. \"total\" delivers total values over whole system lifetime. \"years\" delivers values for each year of system lifetime. \"yyyy\" delivers all months of requested year. \"yyyy-MM\" delivers all days of requested month. (optional) 
            var offset = 56;  // int? | ​Supports pagination, returns items from a starting \"offset\" point (items = objects in the \"Data\" array). (optional) 
            var limit = 56;  // int? | ​Supports pagination, returning not more than \"limit\" items (items = objects in the \"Data\" array). (optional) 

            try
            {
                // Gets aggregated data for a given PV system for a custom period of time. Filters allow limiting to specific PV system energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa.
                AggrValues result = apiInstance.PvsystemsPvSystemIdAggrdataGet(pvSystemId, channel, from, to, duration, period, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedV2Api.PvsystemsPvSystemIdAggrdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggrdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets aggregated data for a given PV system for a custom period of time. Filters allow limiting to specific PV system energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa.
    ApiResponse<AggrValues> response = apiInstance.PvsystemsPvSystemIdAggrdataGetWithHttpInfo(pvSystemId, channel, from, to, duration, period, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedV2Api.PvsystemsPvSystemIdAggrdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **channel** | **string?** | Limits query by selected channel. Note: Channel filters can be concatened using commas. E.g,: ?channel&#x3D;EnergyFeedIn,EnergyPurchased | [optional]  |
| **from** | **string?** | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. | [optional]  |
| **to** | **string?** | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. | [optional]  |
| **duration** | **string?** | Duration is measured in years, months or days - depending on the from parameter. A duration of 1 means that start and end are equal.  Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. | [optional]  |
| **period** | **string?** | Limits the time series for the query to a period. \&quot;total\&quot; delivers total values over whole system lifetime. \&quot;years\&quot; delivers values for each year of system lifetime. \&quot;yyyy\&quot; delivers all months of requested year. \&quot;yyyy-MM\&quot; delivers all days of requested month. | [optional]  |
| **offset** | **int?** | ​Supports pagination, returns items from a starting \&quot;offset\&quot; point (items &#x3D; objects in the \&quot;Data\&quot; array). | [optional]  |
| **limit** | **int?** | ​Supports pagination, returning not more than \&quot;limit\&quot; items (items &#x3D; objects in the \&quot;Data\&quot; array). | [optional]  |

### Return type

[**AggrValues**](AggrValues.md)

### Authorization

[AccessKeyId](../README.md#AccessKeyId), [AccessKeyValue](../README.md#AccessKeyValue), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pvsystemspvsystemiddevicesdeviceidaggrdataget"></a>
# **PvsystemsPvSystemIdDevicesDeviceIdAggrdataGet**
> AggrValues PvsystemsPvSystemIdDevicesDeviceIdAggrdataGet (Guid pvSystemId, Guid deviceId, string? channel = null, string? from = null, string? to = null, string? duration = null, string? period = null, int? offset = null, int? limit = null)

Gets aggregated data for a given inverter for a custom period of time. Filters allow limiting to specific device energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesDeviceIdAggrdataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.solarweb.com/swqapi";
            // Configure API key authorization: AccessKeyId
            config.AddApiKey("AccessKeyId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccessKeyId", "Bearer");
            // Configure API key authorization: AccessKeyValue
            config.AddApiKey("AccessKeyValue", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccessKeyValue", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AggregatedV2Api(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var deviceId = "deviceId_example";  // Guid | 
            var channel = "channel_example";  // string? | Limits query by selected channel. Note: Channel filters can be concatened using commas. E.g,: ?channel=EnergyFeedIn,EnergyPurchased (optional) 
            var from = "from_example";  // string? | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. (optional) 
            var to = "to_example";  // string? | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. (optional) 
            var duration = "duration_example";  // string? | Duration is measured in years, months or days - depending on the from parameter. A duration of 1 means that start and end are equal.  Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. (optional) 
            var period = "period_example";  // string? | Limits the time series for the query to a period. \"total\" delivers total values over whole system lifetime. \"years\" delivers values for each year of system lifetime. \"yyyy\" delivers all months of requested year. \"yyyy-MM\" delivers all days of requested month. (optional) 
            var offset = 56;  // int? | ​Supports pagination, returns items from a starting \"offset\" point (items = objects in the \"Data\" array). (optional) 
            var limit = 56;  // int? | ​Supports pagination, returning not more than \"limit\" items (items = objects in the \"Data\" array). (optional) 

            try
            {
                // Gets aggregated data for a given inverter for a custom period of time. Filters allow limiting to specific device energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa.
                AggrValues result = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdAggrdataGet(pvSystemId, deviceId, channel, from, to, duration, period, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedV2Api.PvsystemsPvSystemIdDevicesDeviceIdAggrdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesDeviceIdAggrdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets aggregated data for a given inverter for a custom period of time. Filters allow limiting to specific device energy values.  Note: If period parameter is used, than from, to and duration parameters are not allowed, and vice versa.
    ApiResponse<AggrValues> response = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdAggrdataGetWithHttpInfo(pvSystemId, deviceId, channel, from, to, duration, period, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedV2Api.PvsystemsPvSystemIdDevicesDeviceIdAggrdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **deviceId** | **Guid** |  |  |
| **channel** | **string?** | Limits query by selected channel. Note: Channel filters can be concatened using commas. E.g,: ?channel&#x3D;EnergyFeedIn,EnergyPurchased | [optional]  |
| **from** | **string?** | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. | [optional]  |
| **to** | **string?** | ​Limits the time series for the query. Period type in from and to need to match. Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. | [optional]  |
| **duration** | **string?** | Duration is measured in years, months or days - depending on the from parameter. A duration of 1 means that start and end are equal.  Formats: yyyy for years, yyyy-MM or yyyyMM for months, yyyy-MM-dd or yyyyMMdd for days. | [optional]  |
| **period** | **string?** | Limits the time series for the query to a period. \&quot;total\&quot; delivers total values over whole system lifetime. \&quot;years\&quot; delivers values for each year of system lifetime. \&quot;yyyy\&quot; delivers all months of requested year. \&quot;yyyy-MM\&quot; delivers all days of requested month. | [optional]  |
| **offset** | **int?** | ​Supports pagination, returns items from a starting \&quot;offset\&quot; point (items &#x3D; objects in the \&quot;Data\&quot; array). | [optional]  |
| **limit** | **int?** | ​Supports pagination, returning not more than \&quot;limit\&quot; items (items &#x3D; objects in the \&quot;Data\&quot; array). | [optional]  |

### Return type

[**AggrValues**](AggrValues.md)

### Authorization

[AccessKeyId](../README.md#AccessKeyId), [AccessKeyValue](../README.md#AccessKeyValue), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

