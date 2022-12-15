# kern.services.FroniusSolarWebClient.Api.EnergyFlowApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsPvSystemIdDevicesDeviceIdFlowdataGet**](EnergyFlowApi.md#pvsystemspvsystemiddevicesdeviceidflowdataget) | **GET** /pvsystems/{pvSystemId}/devices/{deviceId}/flowdata | This method returns energy flow values for a specific device of a PV system |
| [**PvsystemsPvSystemIdFlowdataGet**](EnergyFlowApi.md#pvsystemspvsystemidflowdataget) | **GET** /pvsystems/{pvSystemId}/flowdata | This method returns energy flow values for a specific PV system |

<a name="pvsystemspvsystemiddevicesdeviceidflowdataget"></a>
# **PvsystemsPvSystemIdDevicesDeviceIdFlowdataGet**
> EnergyFlow PvsystemsPvSystemIdDevicesDeviceIdFlowdataGet (Guid pvSystemId, Guid deviceId, string? timezone = null)

This method returns energy flow values for a specific device of a PV system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesDeviceIdFlowdataGetExample
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

            var apiInstance = new EnergyFlowApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | PV System Id
            var deviceId = "deviceId_example";  // Guid | Device Id
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 

            try
            {
                // This method returns energy flow values for a specific device of a PV system
                EnergyFlow result = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdFlowdataGet(pvSystemId, deviceId, timezone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyFlowApi.PvsystemsPvSystemIdDevicesDeviceIdFlowdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesDeviceIdFlowdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns energy flow values for a specific device of a PV system
    ApiResponse<EnergyFlow> response = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdFlowdataGetWithHttpInfo(pvSystemId, deviceId, timezone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EnergyFlowApi.PvsystemsPvSystemIdDevicesDeviceIdFlowdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | PV System Id |  |
| **deviceId** | **Guid** | Device Id |  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |

### Return type

[**EnergyFlow**](EnergyFlow.md)

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

<a name="pvsystemspvsystemidflowdataget"></a>
# **PvsystemsPvSystemIdFlowdataGet**
> EnergyFlow PvsystemsPvSystemIdFlowdataGet (Guid pvSystemId, string? timezone = null)

This method returns energy flow values for a specific PV system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdFlowdataGetExample
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

            var apiInstance = new EnergyFlowApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | ID of a PV System
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 

            try
            {
                // This method returns energy flow values for a specific PV system
                EnergyFlow result = apiInstance.PvsystemsPvSystemIdFlowdataGet(pvSystemId, timezone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyFlowApi.PvsystemsPvSystemIdFlowdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdFlowdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns energy flow values for a specific PV system
    ApiResponse<EnergyFlow> response = apiInstance.PvsystemsPvSystemIdFlowdataGetWithHttpInfo(pvSystemId, timezone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EnergyFlowApi.PvsystemsPvSystemIdFlowdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | ID of a PV System |  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |

### Return type

[**EnergyFlow**](EnergyFlow.md)

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
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

