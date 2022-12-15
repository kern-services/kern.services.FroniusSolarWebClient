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
    /// EnergyFlowStatus
    /// </summary>
    [DataContract(Name = "EnergyFlow_status")]
    public partial class EnergyFlowStatus : IEquatable<EnergyFlowStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyFlowStatus" /> class.
        /// </summary>
        /// <param name="isOnline">isOnline.</param>
        /// <param name="battMode">battMode.</param>
        public EnergyFlowStatus(bool isOnline = default(bool), double? battMode = default(double?))
        {
            this.IsOnline = isOnline;
            this.BattMode = battMode;
        }

        /// <summary>
        /// Gets or Sets IsOnline
        /// </summary>
        [DataMember(Name = "isOnline", EmitDefaultValue = true)]
        public bool IsOnline { get; set; }

        /// <summary>
        /// Gets or Sets BattMode
        /// </summary>
        [DataMember(Name = "battMode", EmitDefaultValue = true)]
        public double? BattMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnergyFlowStatus {\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
            sb.Append("  BattMode: ").Append(BattMode).Append("\n");
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
            return this.Equals(input as EnergyFlowStatus);
        }

        /// <summary>
        /// Returns true if EnergyFlowStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyFlowStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyFlowStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsOnline == input.IsOnline ||
                    this.IsOnline.Equals(input.IsOnline)
                ) && 
                (
                    this.BattMode == input.BattMode ||
                    (this.BattMode != null &&
                    this.BattMode.Equals(input.BattMode))
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
                hashCode = (hashCode * 59) + this.IsOnline.GetHashCode();
                if (this.BattMode != null)
                {
                    hashCode = (hashCode * 59) + this.BattMode.GetHashCode();
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
