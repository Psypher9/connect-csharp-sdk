/* 
 * Square Connect API
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents the details of a credit card tender.
    /// </summary>
    [DataContract]
    public partial class TenderCardDetails :  IEquatable<TenderCardDetails>
    {
        /// <summary>
        /// The credit card payment's current state (such as `CAPTURED`)
        /// </summary>
        /// <value>The credit card payment's current state (such as `CAPTURED`)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Authorized for "AUTHORIZED"
            /// </summary>
            [EnumMember(Value = "AUTHORIZED")]
            Authorized,
            
            /// <summary>
            /// Enum Captured for "CAPTURED"
            /// </summary>
            [EnumMember(Value = "CAPTURED")]
            Captured,
            
            /// <summary>
            /// Enum Voided for "VOIDED"
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            Voided,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }

        /// <summary>
        /// This function is to convert the String Value to its correspoding Enum value
        /// </summary>
        public static StatusEnum ToStatusEnum (string str)
        {
            var enumType = typeof(StatusEnum);
            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
                if (enumMemberAttribute.Value == str) return (StatusEnum)Enum.Parse(enumType, name);
            }
            return default(StatusEnum);
        }

        /// <summary>
        /// This function is to convert the Enum Value to its correspoding String Value
        /// </summary>
        public static string StatusEnumToString(StatusEnum type)
        {
            var enumType = typeof(StatusEnum);
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
            return enumMemberAttribute.Value;
            
        }

        /// <summary>
        /// The method used to read the card.
        /// </summary>
        /// <value>The method used to read the card.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntryMethodEnum
        {
            
            /// <summary>
            /// Enum Swiped for "SWIPED"
            /// </summary>
            [EnumMember(Value = "SWIPED")]
            Swiped,
            
            /// <summary>
            /// Enum Keyed for "KEYED"
            /// </summary>
            [EnumMember(Value = "KEYED")]
            Keyed,
            
            /// <summary>
            /// Enum Emv for "EMV"
            /// </summary>
            [EnumMember(Value = "EMV")]
            Emv,
            
            /// <summary>
            /// Enum OnFile for "ON_FILE"
            /// </summary>
            [EnumMember(Value = "ON_FILE")]
            OnFile,
            
            /// <summary>
            /// Enum Contactless for "CONTACTLESS"
            /// </summary>
            [EnumMember(Value = "CONTACTLESS")]
            Contactless
        }

        /// <summary>
        /// This function is to convert the String Value to its correspoding Enum value
        /// </summary>
        public static EntryMethodEnum ToEntryMethodEnum (string str)
        {
            var enumType = typeof(EntryMethodEnum);
            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
                if (enumMemberAttribute.Value == str) return (EntryMethodEnum)Enum.Parse(enumType, name);
            }
            return default(EntryMethodEnum);
        }

        /// <summary>
        /// This function is to convert the Enum Value to its correspoding String Value
        /// </summary>
        public static string EntryMethodEnumToString(EntryMethodEnum type)
        {
            var enumType = typeof(EntryMethodEnum);
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
            return enumMemberAttribute.Value;
            
        }

        /// <summary>
        /// The credit card payment's current state (such as `CAPTURED`)
        /// </summary>
        /// <value>The credit card payment's current state (such as `CAPTURED`)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The method used to read the card.
        /// </summary>
        /// <value>The method used to read the card.</value>
        [DataMember(Name="entry_method", EmitDefaultValue=false)]
        public EntryMethodEnum? EntryMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderCardDetails" /> class.
        /// </summary>
        /// <param name="Status">The credit card payment&#39;s current state (such as &#x60;CAPTURED&#x60;).</param>
        /// <param name="Card">The credit card&#39;s non-confidential details..</param>
        /// <param name="EntryMethod">The method used to read the card..</param>
        public TenderCardDetails(StatusEnum? Status = null, Card Card = null, EntryMethodEnum? EntryMethod = null)
        {
            this.Status = Status;
            this.Card = Card;
            this.EntryMethod = EntryMethod;
        }
        
        /// <summary>
        /// The credit card&#39;s non-confidential details.
        /// </summary>
        /// <value>The credit card&#39;s non-confidential details.</value>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Card Card { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenderCardDetails {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  EntryMethod: ").Append(EntryMethod).Append("\n");
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
            return this.Equals(obj as TenderCardDetails);
        }

        /// <summary>
        /// Returns true if TenderCardDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TenderCardDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenderCardDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.EntryMethod == other.EntryMethod ||
                    this.EntryMethod != null &&
                    this.EntryMethod.Equals(other.EntryMethod)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.EntryMethod != null)
                    hash = hash * 59 + this.EntryMethod.GetHashCode();
                return hash;
            }
        }
    }

}
