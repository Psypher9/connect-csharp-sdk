/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RevokeTokenRequest :  IEquatable<RevokeTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeTokenRequest" /> class.
        /// </summary>
        /// <param name="ClientId">Your application&#39;s ID, available from the [application dashboard](https://connect.squareup.com/apps)..</param>
        /// <param name="AccessToken">The access token of the merchant whose token you want to revoke. Do not provide a value for merchant_id if you provide this parameter..</param>
        /// <param name="MerchantId">The ID of the merchant whose token you want to revoke. Do not provide a value for access_token if you provide this parameter..</param>
        public RevokeTokenRequest(string ClientId = default(string), string AccessToken = default(string), string MerchantId = default(string))
        {
            this.ClientId = ClientId;
            this.AccessToken = AccessToken;
            this.MerchantId = MerchantId;
        }
        
        /// <summary>
        /// Your application&#39;s ID, available from the [application dashboard](https://connect.squareup.com/apps).
        /// </summary>
        /// <value>Your application&#39;s ID, available from the [application dashboard](https://connect.squareup.com/apps).</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// The access token of the merchant whose token you want to revoke. Do not provide a value for merchant_id if you provide this parameter.
        /// </summary>
        /// <value>The access token of the merchant whose token you want to revoke. Do not provide a value for merchant_id if you provide this parameter.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// The ID of the merchant whose token you want to revoke. Do not provide a value for access_token if you provide this parameter.
        /// </summary>
        /// <value>The ID of the merchant whose token you want to revoke. Do not provide a value for access_token if you provide this parameter.</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevokeTokenRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RevokeTokenRequest);
        }

        /// <summary>
        /// Returns true if RevokeTokenRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RevokeTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevokeTokenRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
