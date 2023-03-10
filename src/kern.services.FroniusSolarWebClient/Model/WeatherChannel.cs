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
    /// WeatherChannel
    /// </summary>
    [DataContract(Name = "WeatherChannel")]
    public partial class WeatherChannel : IEquatable<WeatherChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherChannel" /> class.
        /// </summary>
        /// <param name="channelName">channelName.</param>
        /// <param name="channelType">channelType.</param>
        /// <param name="value">value.</param>
        /// <param name="unit">unit.</param>
        public WeatherChannel(string channelName = default(string), string channelType = default(string), Object value = default(Object), string unit = default(string))
        {
            this.ChannelName = channelName;
            this.ChannelType = channelType;
            this.Value = value;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets or Sets ChannelName
        /// </summary>
        [DataMember(Name = "channelName", EmitDefaultValue = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Gets or Sets ChannelType
        /// </summary>
        [DataMember(Name = "channelType", EmitDefaultValue = true)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeatherChannel {\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as WeatherChannel);
        }

        /// <summary>
        /// Returns true if WeatherChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of WeatherChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeatherChannel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
                }
                if (this.ChannelType != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelType.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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
