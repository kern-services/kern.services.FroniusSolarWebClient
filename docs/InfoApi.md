# kern.services.FroniusSolarWebClient.Api.InfoApi

All URIs are relative to *https://api.solarweb.com/swqapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InfoReleaseGet**](InfoApi.md#inforeleaseget) | **GET** /info/release | This method returns currently deployed version of service, and it&#39;s date. |
| [**InfoUserGet**](InfoApi.md#infouserget) | **GET** /info/user | Returns user&#39;s detailed information. |

<a name="inforeleaseget"></a>
# **InfoReleaseGet**
> ReleaseInfo InfoReleaseGet ()

This method returns currently deployed version of service, and it's date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class InfoReleaseGetExample
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

            var apiInstance = new InfoApi(config);

            try
            {
                // This method returns currently deployed version of service, and it's date.
                ReleaseInfo result = apiInstance.InfoReleaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoReleaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoReleaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method returns currently deployed version of service, and it's date.
    ApiResponse<ReleaseInfo> response = apiInstance.InfoReleaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoReleaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ReleaseInfo**](ReleaseInfo.md)

### Authorization

[AccessKeyId](../README.md#AccessKeyId), [AccessKeyValue](../README.md#AccessKeyValue), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="infouserget"></a>
# **InfoUserGet**
> UserInfo InfoUserGet ()

Returns user's detailed information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using kern.services.FroniusSolarWebClient.Api;
using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Model;

namespace Example
{
    public class InfoUserGetExample
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

            var apiInstance = new InfoApi(config);

            try
            {
                // Returns user's detailed information.
                UserInfo result = apiInstance.InfoUserGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.InfoUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InfoUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns user's detailed information.
    ApiResponse<UserInfo> response = apiInstance.InfoUserGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InfoApi.InfoUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserInfo**](UserInfo.md)

### Authorization

[AccessKeyId](../README.md#AccessKeyId), [AccessKeyValue](../README.md#AccessKeyValue), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

