# kern.services.FroniusSolarWebClient.Api.HistoricalApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsPvSystemIdDevicesDeviceIdHistdataGet**](HistoricalApi.md#pvsystemspvsystemiddevicesdeviceidhistdataget) | **GET** /pvsystems/{pvSystemId}/devices/{deviceId}/histdata | This method returns the past time detail values for a specific device. The data is returned in granularity of 5 minute intervals. |
| [**PvsystemsPvSystemIdHistdataGet**](HistoricalApi.md#pvsystemspvsystemidhistdataget) | **GET** /pvsystems/{pvSystemId}/histdata | This method returns the past time detail values for a specific PV system. The data is returned in granularity of 5 minute intervals. |

<a name="pvsystemspvsystemiddevicesdeviceidhistdataget"></a>
# **PvsystemsPvSystemIdDevicesDeviceIdHistdataGet**
> HistoricalValues PvsystemsPvSystemIdDevicesDeviceIdHistdataGet (Guid pvSystemId, Guid deviceId, string from, string to, string? timezone = null, string? channel = null, int? offset = null, int? limit = null)

This method returns the past time detail values for a specific device. The data is returned in granularity of 5 minute intervals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesDeviceIdHistdataGetExample
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

            var apiInstance = new HistoricalApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var deviceId = "deviceId_example";  // Guid | 
            var from = "from_example";  // string | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time
            var to = "to_example";  // string | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 
            var channel = "channel_example";  // string? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // This method returns the past time detail values for a specific device. The data is returned in granularity of 5 minute intervals.
                HistoricalValues result = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdHistdataGet(pvSystemId, deviceId, from, to, timezone, channel, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricalApi.PvsystemsPvSystemIdDevicesDeviceIdHistdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesDeviceIdHistdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns the past time detail values for a specific device. The data is returned in granularity of 5 minute intervals.
    ApiResponse<HistoricalValues> response = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdHistdataGetWithHttpInfo(pvSystemId, deviceId, from, to, timezone, channel, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoricalApi.PvsystemsPvSystemIdDevicesDeviceIdHistdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **deviceId** | **Guid** |  |  |
| **from** | **string** | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time |  |
| **to** | **string** | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time |  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |
| **channel** | **string?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**HistoricalValues**](HistoricalValues.md)

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

<a name="pvsystemspvsystemidhistdataget"></a>
# **PvsystemsPvSystemIdHistdataGet**
> HistoricalValues PvsystemsPvSystemIdHistdataGet (Guid pvSystemId, string from, string to, string? channel = null, int? offset = null, int? limit = null, string? timezone = null)

This method returns the past time detail values for a specific PV system. The data is returned in granularity of 5 minute intervals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdHistdataGetExample
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

            var apiInstance = new HistoricalApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var from = "from_example";  // string | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time
            var to = "to_example";  // string | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time
            var channel = "channel_example";  // string? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var timezone = "timezone_example";  // string? |  (optional) 

            try
            {
                // This method returns the past time detail values for a specific PV system. The data is returned in granularity of 5 minute intervals.
                HistoricalValues result = apiInstance.PvsystemsPvSystemIdHistdataGet(pvSystemId, from, to, channel, offset, limit, timezone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricalApi.PvsystemsPvSystemIdHistdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdHistdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns the past time detail values for a specific PV system. The data is returned in granularity of 5 minute intervals.
    ApiResponse<HistoricalValues> response = apiInstance.PvsystemsPvSystemIdHistdataGetWithHttpInfo(pvSystemId, from, to, channel, offset, limit, timezone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoricalApi.PvsystemsPvSystemIdHistdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **from** | **string** | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time |  |
| **to** | **string** | Date time format yyyy-MM-ddTHH:mm:ssZ, yyyyMMddTHHmmssZ or Unix time |  |
| **channel** | **string?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |
| **timezone** | **string?** |  | [optional]  |

### Return type

[**HistoricalValues**](HistoricalValues.md)

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

