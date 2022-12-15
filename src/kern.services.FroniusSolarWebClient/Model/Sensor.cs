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
    /// Sensor
    /// </summary>
    [DataContract(Name = "Sensor")]
    public partial class Sensor : IEquatable<Sensor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sensor" /> class.
        /// </summary>
        /// <param name="sensorName">sensorName.</param>
        /// <param name="sensorType">sensorType.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="activationDate">activationDate.</param>
        /// <param name="deactivationDate">deactivationDate.</param>
        public Sensor(string sensorName = default(string), string sensorType = default(string), bool? isActive = default(bool?), string activationDate = default(string), string deactivationDate = default(string))
        {
            this.SensorName = sensorName;
            this.SensorType = sensorType;
            this.IsActive = isActive;
            this.ActivationDate = activationDate;
            this.DeactivationDate = deactivationDate;
        }

        /// <summary>
        /// Gets or Sets SensorName
        /// </summary>
        [DataMember(Name = "sensorName", EmitDefaultValue = true)]
        public string SensorName { get; set; }

        /// <summary>
        /// Gets or Sets SensorType
        /// </summary>
        [DataMember(Name = "sensorType", EmitDefaultValue = true)]
        public string SensorType { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets ActivationDate
        /// </summary>
        [DataMember(Name = "activationDate", EmitDefaultValue = true)]
        public string ActivationDate { get; set; }

        /// <summary>
        /// Gets or Sets DeactivationDate
        /// </summary>
        [DataMember(Name = "deactivationDate", EmitDefaultValue = true)]
        public string DeactivationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Sensor {\n");
            sb.Append("  SensorName: ").Append(SensorName).Append("\n");
            sb.Append("  SensorType: ").Append(SensorType).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ActivationDate: ").Append(ActivationDate).Append("\n");
            sb.Append("  DeactivationDate: ").Append(DeactivationDate).Append("\n");
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
            return this.Equals(input as Sensor);
        }

        /// <summary>
        /// Returns true if Sensor instances are equal
        /// </summary>
        /// <param name="input">Instance of Sensor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sensor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SensorName == input.SensorName ||
                    (this.SensorName != null &&
                    this.SensorName.Equals(input.SensorName))
                ) && 
                (
                    this.SensorType == input.SensorType ||
                    (this.SensorType != null &&
                    this.SensorType.Equals(input.SensorType))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.ActivationDate == input.ActivationDate ||
                    (this.ActivationDate != null &&
                    this.ActivationDate.Equals(input.ActivationDate))
                ) && 
                (
                    this.DeactivationDate == input.DeactivationDate ||
                    (this.DeactivationDate != null &&
                    this.DeactivationDate.Equals(input.DeactivationDate))
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
                if (this.SensorName != null)
                {
                    hashCode = (hashCode * 59) + this.SensorName.GetHashCode();
                }
                if (this.SensorType != null)
                {
                    hashCode = (hashCode * 59) + this.SensorType.GetHashCode();
                }
                if (this.IsActive != null)
                {
                    hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                }
                if (this.ActivationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ActivationDate.GetHashCode();
                }
                if (this.DeactivationDate != null)
                {
                    hashCode = (hashCode * 59) + this.DeactivationDate.GetHashCode();
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