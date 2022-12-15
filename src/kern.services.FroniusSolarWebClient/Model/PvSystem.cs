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
    /// PvSystem
    /// </summary>
    [DataContract(Name = "PvSystem")]
    public partial class PvSystem : IEquatable<PvSystem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PvSystem" /> class.
        /// </summary>
        /// <param name="pvSystemId">pvSystemId.</param>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="pictureURL">pictureURL.</param>
        /// <param name="peakPower">peakPower.</param>
        /// <param name="installationDate">installationDate.</param>
        /// <param name="lastImport">lastImport.</param>
        /// <param name="meteoData">meteoData.</param>
        /// <param name="timeZone">timeZone.</param>
        public PvSystem(Guid pvSystemId = default(Guid), string name = default(string), PvSystemAddress address = default(PvSystemAddress), string pictureURL = default(string), double? peakPower = default(double?), string installationDate = default(string), string lastImport = default(string), string meteoData = default(string), string timeZone = default(string))
        {
            this.PvSystemId = pvSystemId;
            this.Name = name;
            this.Address = address;
            this.PictureURL = pictureURL;
            this.PeakPower = peakPower;
            this.InstallationDate = installationDate;
            this.LastImport = lastImport;
            this.MeteoData = meteoData;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// Gets or Sets PvSystemId
        /// </summary>
        [DataMember(Name = "pvSystemId", EmitDefaultValue = false)]
        public Guid PvSystemId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public PvSystemAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets PictureURL
        /// </summary>
        [DataMember(Name = "pictureURL", EmitDefaultValue = true)]
        public string PictureURL { get; set; }

        /// <summary>
        /// Gets or Sets PeakPower
        /// </summary>
        [DataMember(Name = "peakPower", EmitDefaultValue = true)]
        public double? PeakPower { get; set; }

        /// <summary>
        /// Gets or Sets InstallationDate
        /// </summary>
        [DataMember(Name = "installationDate", EmitDefaultValue = true)]
        public string InstallationDate { get; set; }

        /// <summary>
        /// Gets or Sets LastImport
        /// </summary>
        [DataMember(Name = "lastImport", EmitDefaultValue = true)]
        public string LastImport { get; set; }

        /// <summary>
        /// Gets or Sets MeteoData
        /// </summary>
        [DataMember(Name = "meteoData", EmitDefaultValue = true)]
        public string MeteoData { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PvSystem {\n");
            sb.Append("  PvSystemId: ").Append(PvSystemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PictureURL: ").Append(PictureURL).Append("\n");
            sb.Append("  PeakPower: ").Append(PeakPower).Append("\n");
            sb.Append("  InstallationDate: ").Append(InstallationDate).Append("\n");
            sb.Append("  LastImport: ").Append(LastImport).Append("\n");
            sb.Append("  MeteoData: ").Append(MeteoData).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as PvSystem);
        }

        /// <summary>
        /// Returns true if PvSystem instances are equal
        /// </summary>
        /// <param name="input">Instance of PvSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PvSystem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PictureURL == input.PictureURL ||
                    (this.PictureURL != null &&
                    this.PictureURL.Equals(input.PictureURL))
                ) && 
                (
                    this.PeakPower == input.PeakPower ||
                    (this.PeakPower != null &&
                    this.PeakPower.Equals(input.PeakPower))
                ) && 
                (
                    this.InstallationDate == input.InstallationDate ||
                    (this.InstallationDate != null &&
                    this.InstallationDate.Equals(input.InstallationDate))
                ) && 
                (
                    this.LastImport == input.LastImport ||
                    (this.LastImport != null &&
                    this.LastImport.Equals(input.LastImport))
                ) && 
                (
                    this.MeteoData == input.MeteoData ||
                    (this.MeteoData != null &&
                    this.MeteoData.Equals(input.MeteoData))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.PictureURL != null)
                {
                    hashCode = (hashCode * 59) + this.PictureURL.GetHashCode();
                }
                if (this.PeakPower != null)
                {
                    hashCode = (hashCode * 59) + this.PeakPower.GetHashCode();
                }
                if (this.InstallationDate != null)
                {
                    hashCode = (hashCode * 59) + this.InstallationDate.GetHashCode();
                }
                if (this.LastImport != null)
                {
                    hashCode = (hashCode * 59) + this.LastImport.GetHashCode();
                }
                if (this.MeteoData != null)
                {
                    hashCode = (hashCode * 59) + this.MeteoData.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
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
