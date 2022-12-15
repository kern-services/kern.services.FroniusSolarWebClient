/*
 * Solar.web Query API (SWQAPI)
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using kern.services.FroniusSolarWebClient.Client;
using kern.services.FroniusSolarWebClient.Api;
// uncomment below to import models
//using kern.services.FroniusSolarWebClient.Model;

namespace kern.services.FroniusSolarWebClient.Test.Api
{
    /// <summary>
    ///  Class for testing MeteoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MeteoApiTests : IDisposable
    {
        private MeteoApi instance;

        public MeteoApiTests()
        {
            instance = new MeteoApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MeteoApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MeteoApi
            //Assert.IsType<MeteoApi>(instance);
        }

        /// <summary>
        /// Test PvsystemsPvSystemIdWeatherCurrentGet
        /// </summary>
        [Fact]
        public void PvsystemsPvSystemIdWeatherCurrentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid pvSystemId = null;
            //string? channel = null;
            //string? timezone = null;
            //var response = instance.PvsystemsPvSystemIdWeatherCurrentGet(pvSystemId, channel, timezone);
            //Assert.IsType<WeatherForecast>(response);
        }

        /// <summary>
        /// Test PvsystemsPvSystemIdWeatherEnergyforecastGet
        /// </summary>
        [Fact]
        public void PvsystemsPvSystemIdWeatherEnergyforecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid pvSystemId = null;
            //string? timezone = null;
            //string? from = null;
            //string? to = null;
            //string? duration = null;
            //var response = instance.PvsystemsPvSystemIdWeatherEnergyforecastGet(pvSystemId, timezone, from, to, duration);
            //Assert.IsType<EnergyForecast>(response);
        }

        /// <summary>
        /// Test PvsystemsPvSystemIdWeatherForecastGet
        /// </summary>
        [Fact]
        public void PvsystemsPvSystemIdWeatherForecastGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid pvSystemId = null;
            //string? channel = null;
            //string? timezone = null;
            //string? from = null;
            //string? to = null;
            //string? duration = null;
            //var response = instance.PvsystemsPvSystemIdWeatherForecastGet(pvSystemId, channel, timezone, from, to, duration);
            //Assert.IsType<WeatherForecast>(response);
        }
    }
}
