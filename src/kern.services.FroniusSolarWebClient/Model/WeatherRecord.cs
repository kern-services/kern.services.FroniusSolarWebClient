/*
 * Solar.web Query API (SWQAPI)
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = kern.services.FroniusSolarWebClient.Client.OpenAPIDateConverter;

namespace kern.services.FroniusSolarWebClient.Model
{
    /// <summary>
    /// WeatherRecord
    /// </summary>
    [DataContract(Name = "WeatherRecord")]
    public partial class WeatherRecord : IEquatable<WeatherRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherRecord" /> class.
        /// </summary>
        /// <param name="logDateTime">logDateTime.</param>
        /// <param name="logDuration">logDuration.</param>
        /// <param name="channels">channels.</param>
        public WeatherRecord(string logDateTime = default(string), int? logDuration = default(int?), List<WeatherChannel> channels = default(List<WeatherChannel>))
        {
            this.LogDateTime = logDateTime;
            this.LogDuration = logDuration;
            this.Channels = channels;
        }

        /// <summary>
        /// Gets or Sets LogDateTime
        /// </summary>
        [DataMember(Name = "logDateTime", EmitDefaultValue = true)]
        public string LogDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LogDuration
        /// </summary>
        [DataMember(Name = "logDuration", EmitDefaultValue = true)]
        public int? LogDuration { get; set; }

        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name = "channels", EmitDefaultValue = true)]
        public List<WeatherChannel> Channels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeatherRecord {\n");
            sb.Append("  LogDateTime: ").Append(LogDateTime).Append("\n");
            sb.Append("  LogDuration: ").Append(LogDuration).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WeatherRecord);
        }

        /// <summary>
        /// Returns true if WeatherRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of WeatherRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeatherRecord input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogDateTime == input.LogDateTime ||
                    (this.LogDateTime != null &&
                    this.LogDateTime.Equals(input.LogDateTime))
                ) && 
                (
                    this.LogDuration == input.LogDuration ||
                    (this.LogDuration != null &&
                    this.LogDuration.Equals(input.LogDuration))
                ) && 
                (
                    this.Channels == input.Channels ||
                    this.Channels != null &&
                    input.Channels != null &&
                    this.Channels.SequenceEqual(input.Channels)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LogDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LogDateTime.GetHashCode();
                }
                if (this.LogDuration != null)
                {
                    hashCode = (hashCode * 59) + this.LogDuration.GetHashCode();
                }
                if (this.Channels != null)
                {
                    hashCode = (hashCode * 59) + this.Channels.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}