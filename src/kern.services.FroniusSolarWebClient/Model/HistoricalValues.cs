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
    /// HistoricalValues
    /// </summary>
    [DataContract(Name = "HistoricalValues")]
    public partial class HistoricalValues : IEquatable<HistoricalValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalValues" /> class.
        /// </summary>
        /// <param name="pvSystemId">pvSystemId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="data">data.</param>
        /// <param name="links">links.</param>
        /// <param name="totalDataCount">totalDataCount.</param>
        public HistoricalValues(string pvSystemId = default(string), string deviceId = default(string), List<HistoricalData> data = default(List<HistoricalData>), AggregatedValuesLinks links = default(AggregatedValuesLinks), int totalDataCount = default(int))
        {
            this.PvSystemId = pvSystemId;
            this.DeviceId = deviceId;
            this.Data = data;
            this.Links = links;
            this.TotalDataCount = totalDataCount;
        }

        /// <summary>
        /// Gets or Sets PvSystemId
        /// </summary>
        [DataMember(Name = "pvSystemId", EmitDefaultValue = true)]
        public string PvSystemId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<HistoricalData> Data { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public AggregatedValuesLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets TotalDataCount
        /// </summary>
        [DataMember(Name = "totalDataCount", EmitDefaultValue = false)]
        public int TotalDataCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoricalValues {\n");
            sb.Append("  PvSystemId: ").Append(PvSystemId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  TotalDataCount: ").Append(TotalDataCount).Append("\n");
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
            return this.Equals(input as HistoricalValues);
        }

        /// <summary>
        /// Returns true if HistoricalValues instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricalValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalValues input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PvSystemId == input.PvSystemId ||
                    (this.PvSystemId != null &&
                    this.PvSystemId.Equals(input.PvSystemId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.TotalDataCount == input.TotalDataCount ||
                    this.TotalDataCount.Equals(input.TotalDataCount)
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
                if (this.PvSystemId != null)
                {
                    hashCode = (hashCode * 59) + this.PvSystemId.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalDataCount.GetHashCode();
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