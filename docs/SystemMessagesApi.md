# kern.services.FroniusSolarWebClient.Api.SystemMessagesApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGet**](SystemMessagesApi.md#pvsystemspvsystemiddevicesdeviceidmessagescountget) | **GET** /pvsystems/{pvSystemId}/devices/{deviceId}/messages-count | Gets the total count of system messages for a certain Device of a PV System |
| [**PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGet**](SystemMessagesApi.md#pvsystemspvsystemiddevicesdeviceidmessageslanguagecodeget) | **GET** /pvsystems/{pvSystemId}/devices/{deviceId}/messages/{languageCode} | Gets system messages for a certain Device of a PV System |
| [**PvsystemsPvSystemIdMessagesCountGet**](SystemMessagesApi.md#pvsystemspvsystemidmessagescountget) | **GET** /pvsystems/{pvSystemId}/messages-count | Gets the total count of system messages for a certain PV System |
| [**PvsystemsPvSystemIdMessagesLanguageCodeGet**](SystemMessagesApi.md#pvsystemspvsystemidmessageslanguagecodeget) | **GET** /pvsystems/{pvSystemId}/messages/{languageCode} | Gets system messages for a certain PV System |

<a name="pvsystemspvsystemiddevicesdeviceidmessagescountget"></a>
# **PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGet**
> SystemMessageList PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGet (Guid pvSystemId, Guid deviceId, string from, string? stateType = null, int? stateCode = null, string? stateSeverity = null, string? to = null, string? languageCode = null)

Gets the total count of system messages for a certain Device of a PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGetExample
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

            var apiInstance = new SystemMessagesApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | PV System Id
            var deviceId = "deviceId_example";  // Guid | Device Id
            var from = "from_example";  // string | Date from
            var stateType = "stateType_example";  // string? | Type of message. Can be \"Error\" or \"Event\" (optional) 
            var stateCode = 56;  // int? | State code (optional) 
            var stateSeverity = "stateSeverity_example";  // string? | Severity status. Can be \"error\", \"warning\", \"information\", \"unknown\" (optional) 
            var to = "to_example";  // string? | Date to (optional) 
            var languageCode = "\"en\"";  // string? | Language code (optional)  (default to "en")

            try
            {
                // Gets the total count of system messages for a certain Device of a PV System
                SystemMessageList result = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGet(pvSystemId, deviceId, from, stateType, stateCode, stateSeverity, to, languageCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the total count of system messages for a certain Device of a PV System
    ApiResponse<SystemMessageList> response = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGetWithHttpInfo(pvSystemId, deviceId, from, stateType, stateCode, stateSeverity, to, languageCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdDevicesDeviceIdMessagesCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | PV System Id |  |
| **deviceId** | **Guid** | Device Id |  |
| **from** | **string** | Date from |  |
| **stateType** | **string?** | Type of message. Can be \&quot;Error\&quot; or \&quot;Event\&quot; | [optional]  |
| **stateCode** | **int?** | State code | [optional]  |
| **stateSeverity** | **string?** | Severity status. Can be \&quot;error\&quot;, \&quot;warning\&quot;, \&quot;information\&quot;, \&quot;unknown\&quot; | [optional]  |
| **to** | **string?** | Date to | [optional]  |
| **languageCode** | **string?** | Language code | [optional] [default to &quot;en&quot;] |

### Return type

[**SystemMessageList**](SystemMessageList.md)

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

<a name="pvsystemspvsystemiddevicesdeviceidmessageslanguagecodeget"></a>
# **PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGet**
> SystemMessageList PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGet (Guid pvSystemId, Guid deviceId, string from, string languageCode, string? stateType = null, int? stateCode = null, string? stateSeverity = null, string? to = null, string? timezone = null, int? offset = null, int? limit = null)

Gets system messages for a certain Device of a PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGetExample
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

            var apiInstance = new SystemMessagesApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | PV System Id
            var deviceId = "deviceId_example";  // Guid | Device Id
            var from = "from_example";  // string | Date from
            var languageCode = "\"en\"";  // string | Language code (default to "en")
            var stateType = "stateType_example";  // string? | Type of message. Can be \"Error\" or \"Event\" (optional) 
            var stateCode = 56;  // int? | State code (optional) 
            var stateSeverity = "stateSeverity_example";  // string? | Severity status. Can be \"error\", \"warning\", \"information\", \"unknown\" (optional) 
            var to = "to_example";  // string? | Date to (optional) 
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 
            var offset = 56;  // int? | Skip this many elements (optional) 
            var limit = 56;  // int? | Return max this many elements (optional) 

            try
            {
                // Gets system messages for a certain Device of a PV System
                SystemMessageList result = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGet(pvSystemId, deviceId, from, languageCode, stateType, stateCode, stateSeverity, to, timezone, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets system messages for a certain Device of a PV System
    ApiResponse<SystemMessageList> response = apiInstance.PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGetWithHttpInfo(pvSystemId, deviceId, from, languageCode, stateType, stateCode, stateSeverity, to, timezone, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdDevicesDeviceIdMessagesLanguageCodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | PV System Id |  |
| **deviceId** | **Guid** | Device Id |  |
| **from** | **string** | Date from |  |
| **languageCode** | **string** | Language code | [default to &quot;en&quot;] |
| **stateType** | **string?** | Type of message. Can be \&quot;Error\&quot; or \&quot;Event\&quot; | [optional]  |
| **stateCode** | **int?** | State code | [optional]  |
| **stateSeverity** | **string?** | Severity status. Can be \&quot;error\&quot;, \&quot;warning\&quot;, \&quot;information\&quot;, \&quot;unknown\&quot; | [optional]  |
| **to** | **string?** | Date to | [optional]  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |
| **offset** | **int?** | Skip this many elements | [optional]  |
| **limit** | **int?** | Return max this many elements | [optional]  |

### Return type

[**SystemMessageList**](SystemMessageList.md)

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

<a name="pvsystemspvsystemidmessagescountget"></a>
# **PvsystemsPvSystemIdMessagesCountGet**
> SystemMessageList PvsystemsPvSystemIdMessagesCountGet (Guid pvSystemId, string from, string? stateType = null, int? stateCode = null, string? stateSeverity = null, string? to = null, string? type = null, string? languageCode = null)

Gets the total count of system messages for a certain PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdMessagesCountGetExample
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

            var apiInstance = new SystemMessagesApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | PV System Id
            var from = "from_example";  // string | Date from
            var stateType = "stateType_example";  // string? | Type of message. Can be \"Error\" or \"Event\" (optional) 
            var stateCode = 56;  // int? | State code (optional) 
            var stateSeverity = "stateSeverity_example";  // string? | Severity status. Can be \"error\", \"warning\", \"information\", \"unknown\" (optional) 
            var to = "to_example";  // string? | Date to (optional) 
            var type = "type_example";  // string? | Device type (optional) 
            var languageCode = "\"en\"";  // string? | Language code (optional)  (default to "en")

            try
            {
                // Gets the total count of system messages for a certain PV System
                SystemMessageList result = apiInstance.PvsystemsPvSystemIdMessagesCountGet(pvSystemId, from, stateType, stateCode, stateSeverity, to, type, languageCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdMessagesCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdMessagesCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the total count of system messages for a certain PV System
    ApiResponse<SystemMessageList> response = apiInstance.PvsystemsPvSystemIdMessagesCountGetWithHttpInfo(pvSystemId, from, stateType, stateCode, stateSeverity, to, type, languageCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdMessagesCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | PV System Id |  |
| **from** | **string** | Date from |  |
| **stateType** | **string?** | Type of message. Can be \&quot;Error\&quot; or \&quot;Event\&quot; | [optional]  |
| **stateCode** | **int?** | State code | [optional]  |
| **stateSeverity** | **string?** | Severity status. Can be \&quot;error\&quot;, \&quot;warning\&quot;, \&quot;information\&quot;, \&quot;unknown\&quot; | [optional]  |
| **to** | **string?** | Date to | [optional]  |
| **type** | **string?** | Device type | [optional]  |
| **languageCode** | **string?** | Language code | [optional] [default to &quot;en&quot;] |

### Return type

[**SystemMessageList**](SystemMessageList.md)

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

<a name="pvsystemspvsystemidmessageslanguagecodeget"></a>
# **PvsystemsPvSystemIdMessagesLanguageCodeGet**
> SystemMessageList PvsystemsPvSystemIdMessagesLanguageCodeGet (Guid pvSystemId, string from, string languageCode, string? stateType = null, int? stateCode = null, string? stateSeverity = null, string? to = null, string? timezone = null, string? type = null, int? offset = null, int? limit = null)

Gets system messages for a certain PV System

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class PvsystemsPvSystemIdMessagesLanguageCodeGetExample
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

            var apiInstance = new SystemMessagesApi(config);
            var pvSystemId = "pvSystemId_example";  // Guid | PV System Id
            var from = "from_example";  // string | Date from
            var languageCode = "\"en\"";  // string | Language code (default to "en")
            var stateType = "stateType_example";  // string? | Type of message. Can be \"Error\" or \"Event\" (optional) 
            var stateCode = 56;  // int? | State code (optional) 
            var stateSeverity = "stateSeverity_example";  // string? | Severity status. Can be \"error\", \"warning\", \"information\", \"unknown\" (optional) 
            var to = "to_example";  // string? | Date to (optional) 
            var timezone = "timezone_example";  // string? | Timezone for dates in response, \"local\" or \"zulu\". Zulu is default. (optional) 
            var type = "type_example";  // string? | Device type (optional) 
            var offset = 56;  // int? | Skip this many elements (optional) 
            var limit = 56;  // int? | Return max this many elements (optional) 

            try
            {
                // Gets system messages for a certain PV System
                SystemMessageList result = apiInstance.PvsystemsPvSystemIdMessagesLanguageCodeGet(pvSystemId, from, languageCode, stateType, stateCode, stateSeverity, to, timezone, type, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdMessagesLanguageCodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PvsystemsPvSystemIdMessagesLanguageCodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets system messages for a certain PV System
    ApiResponse<SystemMessageList> response = apiInstance.PvsystemsPvSystemIdMessagesLanguageCodeGetWithHttpInfo(pvSystemId, from, languageCode, stateType, stateCode, stateSeverity, to, timezone, type, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemMessagesApi.PvsystemsPvSystemIdMessagesLanguageCodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pvSystemId** | **Guid** | PV System Id |  |
| **from** | **string** | Date from |  |
| **languageCode** | **string** | Language code | [default to &quot;en&quot;] |
| **stateType** | **string?** | Type of message. Can be \&quot;Error\&quot; or \&quot;Event\&quot; | [optional]  |
| **stateCode** | **int?** | State code | [optional]  |
| **stateSeverity** | **string?** | Severity status. Can be \&quot;error\&quot;, \&quot;warning\&quot;, \&quot;information\&quot;, \&quot;unknown\&quot; | [optional]  |
| **to** | **string?** | Date to | [optional]  |
| **timezone** | **string?** | Timezone for dates in response, \&quot;local\&quot; or \&quot;zulu\&quot;. Zulu is default. | [optional]  |
| **type** | **string?** | Device type | [optional]  |
| **offset** | **int?** | Skip this many elements | [optional]  |
| **limit** | **int?** | Return max this many elements | [optional]  |

### Return type

[**SystemMessageList**](SystemMessageList.md)

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

