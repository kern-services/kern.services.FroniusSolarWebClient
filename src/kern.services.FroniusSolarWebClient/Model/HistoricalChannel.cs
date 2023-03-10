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
    /// HistoricalChannel
    /// </summary>
    [DataContract(Name = "HistoricalChannel")]
    public partial class HistoricalChannel : IEquatable<HistoricalChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalChannel" /> class.
        /// </summary>
        /// <param name="channelName">channelName.</param>
        /// <param name="channelType">channelType.</param>
        /// <param name="unit">unit.</param>
        /// <param name="value">value.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isDamaged">isDamaged.</param>
        public HistoricalChannel(string channelName = default(string), string channelType = default(string), string unit = default(string), double? value = default(double?), bool? isActive = default(bool?), bool? isDamaged = default(bool?))
        {
            this.ChannelName = channelName;
            this.ChannelType = channelType;
            this.Unit = unit;
            this.Value = value;
            this.IsActive = isActive;
            this.IsDamaged = isDamaged;
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
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public double? Value { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsDamaged
        /// </summary>
        [DataMember(Name = "isDamaged", EmitDefaultValue = true)]
        public bool? IsDamaged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoricalChannel {\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDamaged: ").Append(IsDamaged).Append("\n");
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
            return this.Equals(input as HistoricalChannel);
        }

        /// <summary>
        /// Returns true if HistoricalChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricalChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalChannel input)
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
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsDamaged == input.IsDamaged ||
                    (this.IsDamaged != null &&
                    this.IsDamaged.Equals(input.IsDamaged))
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
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.IsActive != null)
                {
                    hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                }
                if (this.IsDamaged != null)
                {
                    hashCode = (hashCode * 59) + this.IsDamaged.GetHashCode();
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
