# kern.services.FroniusSolarWebClient.Api.MetadataApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsCountGet**](MetadataApi.md#pvsystemscountget) | **GET** /pvsystems-count | This method returns number of PV Systems owned by user |
| [**PvsystemsGet**](MetadataApi.md#pvsystemsget) | **GET** /pvsystems | This method returns list of all PV Systems and their details owned by user |
| [**PvsystemsListGet**](MetadataApi.md#pvsystemslistget) | **GET** /pvsystems-list | This method returns list of all PV Systems (ids only) owned by user |
| [**PvsystemsPvSystemIdDevicesCountGet**](MetadataApi.md#pvsystemspvsystemiddevicescountget) | **GET** /pvsystems/{pvSystemId}/devices-count | This method returns number of devices contained within single PV System |
| [**PvsystemsPvSystemIdDevicesDeviceIdGet**](MetadataApi.md#pvsystemspvsystemiddevicesdeviceidget) | **GET** /pvsystems/{pvSystemId}/devices/{deviceId} | This method returns single device and its details |
| [**PvsystemsPvSystemIdDevicesGet**](MetadataApi.md#pvsystemspvsystemiddevicesget) | **GET** /pvsystems/{pvSystemId}/devices | This method returns list of all devices contained within single PV System |
| [**PvsystemsPvSystemIdDevicesListGet**](MetadataApi.md#pvsystemspvsystemiddeviceslistget) | **GET** /pvsystems/{pvSystemId}/devices-list | This method returns list of all device ids, within single PV System |
| [**PvsystemsPvSystemIdGet**](MetadataApi.md#pvsystemspvsystemidget) | **GET** /pvsystems/{pvSystemId} | This method returns single PV System and its details |

<a name="pvsystemscountget"></a>
# **PvsystemsCountGet**
> Counter PvsystemsCountGet (string? type = null, string? meteo = null)

This method returns number of PV Systems owned by user

Metadata method - this method takes no parameters and will return number of PV Systems that are owned by a user whose api key was used to send request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsCountGetExample
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

            var apiInstance = new MetadataApi(config);
            var type = "type_example";  // string? | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. (optional) 
            var meteo = "meteo_example";  // string? | Meteo filter - \"pro\" or \"light\". Filters PV Systems by Meteo data value (optional) 

            try
            {
                // This method returns number of PV Systems owned by user
                Counter result = apiInstance.PvsystemsCountGet(type, meteo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns number of PV Systems owned by user
    ApiResponse<Counter> response = apiInstance.PvsystemsCountGetWithHttpInfo(type, meteo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. | [optional]  |
| **meteo** | **string?** | Meteo filter - \&quot;pro\&quot; or \&quot;light\&quot;. Filters PV Systems by Meteo data value | [optional]  |

### Return type

[**Counter**](Counter.md)

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

<a name="pvsystemsget"></a>
# **PvsystemsGet**
> PvSystemList PvsystemsGet (string? type = null, int? offset = null, int? limit = null, string? meteo = null)

This method returns list of all PV Systems and their details owned by user

Metadata method - this method takes no parameters and will return list of PV Systems that are owned by a user whose api key was used to send request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsGetExample
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

            var apiInstance = new MetadataApi(config);
            var type = "type_example";  // string? | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. (optional) 
            var offset = 56;  // int? | Skip this many elements. (optional) 
            var limit = 56;  // int? | Return max this many elements. (optional) 
            var meteo = "meteo_example";  // string? | Meteo filter - \"pro\" or \"light\". Filters PV Systems by Meteo data value (optional) 

            try
            {
                // This method returns list of all PV Systems and their details owned by user
                PvSystemList result = apiInstance.PvsystemsGet(type, offset, limit, meteo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns list of all PV Systems and their details owned by user
    ApiResponse<PvSystemList> response = apiInstance.PvsystemsGetWithHttpInfo(type, offset, limit, meteo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. | [optional]  |
| **offset** | **int?** | Skip this many elements. | [optional]  |
| **limit** | **int?** | Return max this many elements. | [optional]  |
| **meteo** | **string?** | Meteo filter - \&quot;pro\&quot; or \&quot;light\&quot;. Filters PV Systems by Meteo data value | [optional]  |

### Return type

[**PvSystemList**](PvSystemList.md)

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

<a name="pvsystemslistget"></a>
# **PvsystemsListGet**
> PvSystemIdsOnly PvsystemsListGet (string? type = null, int? offset = null, int? limit = null, string? meteo = null)

This method returns list of all PV Systems (ids only) owned by user

Metadata method - this method takes no parameters and will return list of PV System IDs that are owned by a user whose api key was used to send request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsListGetExample
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

            var apiInstance = new MetadataApi(config);
            var type = "type_example";  // string? | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. (optional) 
            var offset = 56;  // int? | Skip this many elements. (optional) 
            var limit = 56;  // int? | Return max this many elements. (optional) 
            var meteo = "meteo_example";  // string? | Meteo filter - \"pro\" or \"light\". Filters PV Systems by Meteo data value (optional) 

            try
            {
                // This method returns list of all PV Systems (ids only) owned by user
                PvSystemIdsOnly result = apiInstance.PvsystemsListGet(type, offset, limit, meteo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns list of all PV Systems (ids only) owned by user
    ApiResponse<PvSystemIdsOnly> response = apiInstance.PvsystemsListGetWithHttpInfo(type, offset, limit, meteo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. | [optional]  |
| **offset** | **int?** | Skip this many elements. | [optional]  |
| **limit** | **int?** | Return max this many elements. | [optional]  |
| **meteo** | **string?** | Meteo filter - \&quot;pro\&quot; or \&quot;light\&quot;. Filters PV Systems by Meteo data value | [optional]  |

### Return type

[**PvSystemIdsOnly**](PvSystemIdsOnly.md)

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

<a name="pvsystemspvsystemiddevicescountget"></a>
# **PvsystemsPvSystemIdDevicesCountGet**
> Counter PvsystemsPvSystemIdDevicesCountGet (Guid pvSystemId, string? type = null, bool? isActive = null)

This method returns number of devices contained within single PV System

Metadata method - this method takes PV System ID as its parameter and will return number of devices within that PV System (also owned by user whose api key was used to send request)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesCountGetExample
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

            var apiInstance = new MetadataApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | ID of a PV System whose devices are requested for inspection
            var type = "type_example";  // string? | Type filter - one or more (coma separated, no spaces) types of devices. (optional) 
            var isActive = true;  // bool? | If set to \"true\", only active devices will be selected. If set to \"false\" only inactive devices will be selected. If it's not defined, both active and inactive devices will be selected. (optional) 

            try
            {
                // This method returns number of devices contained within single PV System
                Counter result = apiInstance.PvsystemsPvSystemIdDevicesCountGet(pvSystemId, type, isActive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns number of devices contained within single PV System
    ApiResponse<Counter> response = apiInstance.PvsystemsPvSystemIdDevicesCountGetWithHttpInfo(pvSystemId, type, isActive);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | ID of a PV System whose devices are requested for inspection |  |
| **type** | **string?** | Type filter - one or more (coma separated, no spaces) types of devices. | [optional]  |
| **isActive** | **bool?** | If set to \&quot;true\&quot;, only active devices will be selected. If set to \&quot;false\&quot; only inactive devices will be selected. If it&#39;s not defined, both active and inactive devices will be selected. | [optional]  |

### Return type

[**Counter**](Counter.md)

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

<a name="pvsystemspvsystemiddevicesdeviceidget"></a>
# **PvsystemsPvSystemIdDevicesDeviceIdGet**
> Device PvsystemsPvSystemIdDevicesDeviceIdGet (Guid pvSystemId, Guid deviceId)

This method returns single device and its details

Metadata method - this method takes PV System ID and device ID as parameters and returns device (and its details) whose id was sent with request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesDeviceIdGetExample
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

            var apiInstance = new MetadataApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | ID of a PV System which contains certain device
            var deviceId = "deviceId_example";  // Guid | ID of a device user requires to inspect

            try
            {
                // This method returns single device and its details
                Device result = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdGet(pvSystemId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesDeviceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesDeviceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns single device and its details
    ApiResponse<Device> response = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdGetWithHttpInfo(pvSystemId, deviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesDeviceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | ID of a PV System which contains certain device |  |
| **deviceId** | **Guid** | ID of a device user requires to inspect |  |

### Return type

[**Device**](Device.md)

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

<a name="pvsystemspvsystemiddevicesget"></a>
# **PvsystemsPvSystemIdDevicesGet**
> DeviceList PvsystemsPvSystemIdDevicesGet (Guid pvSystemId, string? type = null, int? offset = null, int? limit = null, bool? isActive = null)

This method returns list of all devices contained within single PV System

Metadata method - this method takes PV System ID as its parameter and will return list of all devices and their details contained within that PV System (also owned by user whose api key was used to send request)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesGetExample
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

            var apiInstance = new MetadataApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | ID of a PV System whose devices are requested for inspection
            var type = "type_example";  // string? | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. (optional) 
            var offset = 56;  // int? | Skip this many elements. (optional) 
            var limit = 56;  // int? | Return max this many elements. (optional) 
            var isActive = true;  // bool? | If set to \"true\", only active devices will be selected. If set to \"false\" only inactive devices will be selected. If it's not defined, both active and inactive devices will be selected. (optional) 

            try
            {
                // This method returns list of all devices contained within single PV System
                DeviceList result = apiInstance.PvsystemsPvSystemIdDevicesGet(pvSystemId, type, offset, limit, isActive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns list of all devices contained within single PV System
    ApiResponse<DeviceList> response = apiInstance.PvsystemsPvSystemIdDevicesGetWithHttpInfo(pvSystemId, type, offset, limit, isActive);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | ID of a PV System whose devices are requested for inspection |  |
| **type** | **string?** | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. | [optional]  |
| **offset** | **int?** | Skip this many elements. | [optional]  |
| **limit** | **int?** | Return max this many elements. | [optional]  |
| **isActive** | **bool?** | If set to \&quot;true\&quot;, only active devices will be selected. If set to \&quot;false\&quot; only inactive devices will be selected. If it&#39;s not defined, both active and inactive devices will be selected. | [optional]  |

### Return type

[**DeviceList**](DeviceList.md)

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

<a name="pvsystemspvsystemiddeviceslistget"></a>
# **PvsystemsPvSystemIdDevicesListGet**
> DeviceIdsOnly PvsystemsPvSystemIdDevicesListGet (Guid pvSystemId, string? type = null, int? offset = null, int? limit = null, bool? isActive = null)

This method returns list of all device ids, within single PV System

Metadata method - this method takes PV System ID as its parameter and will return list of all devices (their ids), contained within that PV System (also owned by user whose api key was used to send request)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesListGetExample
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

            var apiInstance = new MetadataApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | ID of a PV System whose devices are requested for inspection
            var type = "type_example";  // string? | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. (optional) 
            var offset = 56;  // int? | Skip this many elements. (optional) 
            var limit = 56;  // int? | Return max this many elements. (optional) 
            var isActive = true;  // bool? | If set to \"true\", only active devices will be selected. If set to \"false\" only inactive devices will be selected. If it's not defined, both active and inactive devices will be selected. (optional) 

            try
            {
                // This method returns list of all device ids, within single PV System
                DeviceIdsOnly result = apiInstance.PvsystemsPvSystemIdDevicesListGet(pvSystemId, type, offset, limit, isActive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns list of all device ids, within single PV System
    ApiResponse<DeviceIdsOnly> response = apiInstance.PvsystemsPvSystemIdDevicesListGetWithHttpInfo(pvSystemId, type, offset, limit, isActive);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdDevicesListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | ID of a PV System whose devices are requested for inspection |  |
| **type** | **string?** | Type filter - one or more (coma separated, no spaces) types of devices that pv system should contain. | [optional]  |
| **offset** | **int?** | Skip this many elements. | [optional]  |
| **limit** | **int?** | Return max this many elements. | [optional]  |
| **isActive** | **bool?** | If set to \&quot;true\&quot;, only active devices will be selected. If set to \&quot;false\&quot; only inactive devices will be selected. If it&#39;s not defined, both active and inactive devices will be selected. | [optional]  |

### Return type

[**DeviceIdsOnly**](DeviceIdsOnly.md)

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

<a name="pvsystemspvsystemidget"></a>
# **PvsystemsPvSystemIdGet**
> PvSystem PvsystemsPvSystemIdGet (Guid pvSystemId)

This method returns single PV System and its details

Metadata method - this method takes PV System ID as its parameter and will return details of that PV Systems, also owned by user whose api key was used to send request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdGetExample
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

            var apiInstance = new MetadataApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | ID of a PV System user requires to inspect

            try
            {
                // This method returns single PV System and its details
                PvSystem result = apiInstance.PvsystemsPvSystemIdGet(pvSystemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns single PV System and its details
    ApiResponse<PvSystem> response = apiInstance.PvsystemsPvSystemIdGetWithHttpInfo(pvSystemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.PvsystemsPvSystemIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | ID of a PV System user requires to inspect |  |

### Return type

[**PvSystem**](PvSystem.md)

### Authorization

[AccessKeyId](../README.md#AccessKeyId), [AccessKeyValue](../README.md#AccessKeyValue), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

