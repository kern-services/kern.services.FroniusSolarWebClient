# kern.services.FroniusSolarWebClient.Api.AggregatedApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsPvSystemIdAggdataGet**](AggregatedApi.md#pvsystemspvsystemidaggdataget) | **GET** /pvsystems/{pvSystemId}/aggdata | This method returns total lifetime aggregated data for a specific PV system. |
| [**PvsystemsPvSystemIdAggdataYearsGet**](AggregatedApi.md#pvsystemspvsystemidaggdatayearsget) | **GET** /pvsystems/{pvSystemId}/aggdata/years | This method returns annual aggregated data for a specific PV system for all years since installation. |
| [**PvsystemsPvSystemIdAggdataYearsYearGet**](AggregatedApi.md#pvsystemspvsystemidaggdatayearsyearget) | **GET** /pvsystems/{pvSystemId}/aggdata/years/{year} | This method returns annual aggregated data for a specific PV system for a specific year. |
| [**PvsystemsPvSystemIdAggdataYearsYearMonthsGet**](AggregatedApi.md#pvsystemspvsystemidaggdatayearsyearmonthsget) | **GET** /pvsystems/{pvSystemId}/aggdata/years/{year}/months | This method returns monthly aggregated data for a specific PV system for a specific year. |
| [**PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGet**](AggregatedApi.md#pvsystemspvsystemidaggdatayearsyearmonthsmonthdaysdayget) | **GET** /pvsystems/{pvSystemId}/aggdata/years/{year}/months/{month}/days/{day} | This method returns daily aggregated data for a specific PV system for a specific date. |
| [**PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGet**](AggregatedApi.md#pvsystemspvsystemidaggdatayearsyearmonthsmonthdaysget) | **GET** /pvsystems/{pvSystemId}/aggdata/years/{year}/months/{month}/days | This method returns daily aggregated data for a specific PV system for a specific month of a year. |
| [**PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGet**](AggregatedApi.md#pvsystemspvsystemidaggdatayearsyearmonthsmonthget) | **GET** /pvsystems/{pvSystemId}/aggdata/years/{year}/months/{month} | This method returns monthly aggregated data for a specific PV system for a specific month of a year. |

<a name="pvsystemspvsystemidaggdataget"></a>
# **PvsystemsPvSystemIdAggdataGet**
> AggregatedValues PvsystemsPvSystemIdAggdataGet (Guid pvSystemId, string? channel = null)

This method returns total lifetime aggregated data for a specific PV system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns total lifetime aggregated data for a specific PV system.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataGet(pvSystemId, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns total lifetime aggregated data for a specific PV system.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataGetWithHttpInfo(pvSystemId, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

<a name="pvsystemspvsystemidaggdatayearsget"></a>
# **PvsystemsPvSystemIdAggdataYearsGet**
> AggregatedValues PvsystemsPvSystemIdAggdataYearsGet (Guid pvSystemId, string? channel = null)

This method returns annual aggregated data for a specific PV system for all years since installation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataYearsGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns annual aggregated data for a specific PV system for all years since installation.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataYearsGet(pvSystemId, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataYearsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns annual aggregated data for a specific PV system for all years since installation.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataYearsGetWithHttpInfo(pvSystemId, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

<a name="pvsystemspvsystemidaggdatayearsyearget"></a>
# **PvsystemsPvSystemIdAggdataYearsYearGet**
> AggregatedValues PvsystemsPvSystemIdAggdataYearsYearGet (Guid pvSystemId, int year, string? channel = null)

This method returns annual aggregated data for a specific PV system for a specific year.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataYearsYearGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var year = 56;  // int | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns annual aggregated data for a specific PV system for a specific year.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataYearsYearGet(pvSystemId, year, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataYearsYearGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns annual aggregated data for a specific PV system for a specific year.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataYearsYearGetWithHttpInfo(pvSystemId, year, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **year** | **int** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

<a name="pvsystemspvsystemidaggdatayearsyearmonthsget"></a>
# **PvsystemsPvSystemIdAggdataYearsYearMonthsGet**
> AggregatedValues PvsystemsPvSystemIdAggdataYearsYearMonthsGet (Guid pvSystemId, int year, string? channel = null)

This method returns monthly aggregated data for a specific PV system for a specific year.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataYearsYearMonthsGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var year = 56;  // int | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns monthly aggregated data for a specific PV system for a specific year.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsGet(pvSystemId, year, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataYearsYearMonthsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns monthly aggregated data for a specific PV system for a specific year.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsGetWithHttpInfo(pvSystemId, year, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **year** | **int** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

<a name="pvsystemspvsystemidaggdatayearsyearmonthsmonthdaysdayget"></a>
# **PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGet**
> AggregatedValues PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGet (Guid pvSystemId, int year, int month, int day, string? channel = null)

This method returns daily aggregated data for a specific PV system for a specific date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var year = 56;  // int | 
            var month = 56;  // int | 
            var day = 56;  // int | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns daily aggregated data for a specific PV system for a specific date.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGet(pvSystemId, year, month, day, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns daily aggregated data for a specific PV system for a specific date.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGetWithHttpInfo(pvSystemId, year, month, day, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysDayGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **year** | **int** |  |  |
| **month** | **int** |  |  |
| **day** | **int** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

<a name="pvsystemspvsystemidaggdatayearsyearmonthsmonthdaysget"></a>
# **PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGet**
> AggregatedValues PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGet (Guid pvSystemId, int year, int month, string? channel = null)

This method returns daily aggregated data for a specific PV system for a specific month of a year.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var year = 56;  // int | 
            var month = 56;  // int | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns daily aggregated data for a specific PV system for a specific month of a year.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGet(pvSystemId, year, month, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns daily aggregated data for a specific PV system for a specific month of a year.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGetWithHttpInfo(pvSystemId, year, month, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthDaysGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **year** | **int** |  |  |
| **month** | **int** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

<a name="pvsystemspvsystemidaggdatayearsyearmonthsmonthget"></a>
# **PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGet**
> AggregatedValues PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGet (Guid pvSystemId, int year, int month, string? channel = null)

This method returns monthly aggregated data for a specific PV system for a specific month of a year.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGetExample
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

            var apiInstance = new AggregatedApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | 
            var year = 56;  // int | 
            var month = 56;  // int | 
            var channel = "channel_example";  // string? |  (optional) 

            try
            {
                // This method returns monthly aggregated data for a specific PV system for a specific month of a year.
                AggregatedValues result = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGet(pvSystemId, year, month, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns monthly aggregated data for a specific PV system for a specific month of a year.
    ApiResponse<AggregatedValues> response = apiInstance.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGetWithHttpInfo(pvSystemId, year, month, channel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AggregatedApi.PvsystemsPvSystemIdAggdataYearsYearMonthsMonthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** |  |  |
| **year** | **int** |  |  |
| **month** | **int** |  |  |
| **channel** | **string?** |  | [optional]  |

### Return type

[**AggregatedValues**](AggregatedValues.md)

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

