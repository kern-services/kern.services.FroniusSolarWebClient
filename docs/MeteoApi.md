# kern.services.FroniusSolarWebClient.Api.MeteoApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsPvSystemIdWeatherCurrentGet**](MeteoApi.md#pvsystemspvsystemidweathercurrentget) | **GET** /pvsystems/{pvSystemId}/weather/current | This method returns current weather forecast for PV System |
| [**PvsystemsPvSystemIdWeatherEnergyforecastGet**](MeteoApi.md#pvsystemspvsystemidweatherenergyforecastget) | **GET** /pvsystems/{pvSystemId}/weather/energyforecast | This method returns energy forecast for PV System |
| [**PvsystemsPvSystemIdWeatherForecastGet**](MeteoApi.md#pvsystemspvsystemidweatherforecastget) | **GET** /pvsystems/{pvSystemId}/weather/forecast | This method returns weather forecast for PV System |

<a name="pvsystemspvsystemidweathercurrentget"></a>
# **PvsystemsPvSystemIdWeatherCurrentGet**
> WeatherForecast PvsystemsPvSystemIdWeatherCurrentGet (Guid pvSystemId, string? channel = null, string? timezone = null)

This method returns current weather forecast for PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdWeatherCurrentGetExample
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

            var apiInstance = new MeteoApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var channel = "channel_example";  // string? |  (optional) 
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 

            try
            {
                // This method returns current weather forecast for PV System
                WeatherForecast result = apiInstance.PvsystemsPvSystemIdWeatherCurrentGet(pvSystemId, channel, timezone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeteoApi.PvsystemsPvSystemIdWeatherCurrentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdWeatherCurrentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns current weather forecast for PV System
    ApiResponse<WeatherForecast> response = apiInstance.PvsystemsPvSystemIdWeatherCurrentGetWithHttpInfo(pvSystemId, channel, timezone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeteoApi.PvsystemsPvSystemIdWeatherCurrentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **channel** | **string?** |  | [optional]  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |

### Return type

[**WeatherForecast**](WeatherForecast.md)

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pvsystemspvsystemidweatherenergyforecastget"></a>
# **PvsystemsPvSystemIdWeatherEnergyforecastGet**
> EnergyForecast PvsystemsPvSystemIdWeatherEnergyforecastGet (Guid pvSystemId, string? timezone = null, string? from = null, string? to = null, string? duration = null)

This method returns energy forecast for PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdWeatherEnergyforecastGetExample
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

            var apiInstance = new MeteoApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 
            var from = "from_example";  // string? | Date time format yyyy-MM-ddTHH:mm:ssZ or yyyyMMddTHHmmssZ. (optional) 
            var to = "to_example";  // string? | Date time format yyyy-MM-ddTHH:mm:ssZ or yyyyMMddTHHmmssZ. (optional) 
            var duration = "duration_example";  // string? | Number of hours in response. (optional) 

            try
            {
                // This method returns energy forecast for PV System
                EnergyForecast result = apiInstance.PvsystemsPvSystemIdWeatherEnergyforecastGet(pvSystemId, timezone, from, to, duration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeteoApi.PvsystemsPvSystemIdWeatherEnergyforecastGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdWeatherEnergyforecastGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns energy forecast for PV System
    ApiResponse<EnergyForecast> response = apiInstance.PvsystemsPvSystemIdWeatherEnergyforecastGetWithHttpInfo(pvSystemId, timezone, from, to, duration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeteoApi.PvsystemsPvSystemIdWeatherEnergyforecastGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |
| **from** | **string?** | Date time format yyyy-MM-ddTHH:mm:ssZ or yyyyMMddTHHmmssZ. | [optional]  |
| **to** | **string?** | Date time format yyyy-MM-ddTHH:mm:ssZ or yyyyMMddTHHmmssZ. | [optional]  |
| **duration** | **string?** | Number of hours in response. | [optional]  |

### Return type

[**EnergyForecast**](EnergyForecast.md)

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
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pvsystemspvsystemidweatherforecastget"></a>
# **PvsystemsPvSystemIdWeatherForecastGet**
> WeatherForecast PvsystemsPvSystemIdWeatherForecastGet (Guid pvSystemId, string? channel = null, string? timezone = null, string? from = null, string? to = null, string? duration = null)

This method returns weather forecast for PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdWeatherForecastGetExample
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

            var apiInstance = new MeteoApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var channel = "channel_example";  // string? |  (optional) 
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 
            var from = "from_example";  // string? | Date time format yyyy-MM-dd or yyyyMMdd. (optional) 
            var to = "to_example";  // string? | Date time format yyyy-MM-dd or yyyyMMdd. (optional) 
            var duration = "duration_example";  // string? | Number of days in response. (optional) 

            try
            {
                // This method returns weather forecast for PV System
                WeatherForecast result = apiInstance.PvsystemsPvSystemIdWeatherForecastGet(pvSystemId, channel, timezone, from, to, duration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeteoApi.PvsystemsPvSystemIdWeatherForecastGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdWeatherForecastGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns weather forecast for PV System
    ApiResponse<WeatherForecast> response = apiInstance.PvsystemsPvSystemIdWeatherForecastGetWithHttpInfo(pvSystemId, channel, timezone, from, to, duration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeteoApi.PvsystemsPvSystemIdWeatherForecastGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **channel** | **string?** |  | [optional]  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |
| **from** | **string?** | Date time format yyyy-MM-dd or yyyyMMdd. | [optional]  |
| **to** | **string?** | Date time format yyyy-MM-dd or yyyyMMdd. | [optional]  |
| **duration** | **string?** | Number of days in response. | [optional]  |

### Return type

[**WeatherForecast**](WeatherForecast.md)

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

