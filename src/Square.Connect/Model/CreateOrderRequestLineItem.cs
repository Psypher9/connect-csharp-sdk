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
    /// Represents a line item to include in an order. Each line item describes a different product to purchase, with its own quantity and price details.  Line items can either reference objects from the merchant&#39;s catalog, or can alternatively specify a name and price instead.
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequestLineItem :  IEquatable<CreateOrderRequestLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderRequestLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestLineItem" /> class.
        /// </summary>
        /// <param name="Name">Only used for ad hoc line items. The name of the line item. This value cannot exceed 500 characters.  Do not provide a value for this field if you provide a value for &#x60;catalog_object_id&#x60;..</param>
        /// <param name="Quantity">The quantity to purchase, as a string representation of a number.  This string must have a positive integer value. (required).</param>
        /// <param name="BasePriceMoney">The base price for a single unit of the line item.  &#x60;base_price_money&#x60; is required for ad hoc line items and variable priced [CatalogItemVariation](#type-catalogitemvariation)s. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the CatalogItemVariation&#39;s price..</param>
        /// <param name="VariationName">Only used for ad hoc line items. The variation name of the line item. This value cannot exceed 255 characters.  If this value is not set for an ad hoc line item, the default value of &#x60;Regular&#x60; is used.  Do not provide a value for this field if you provide a value for the &#x60;catalog_object_id&#x60;..</param>
        /// <param name="Note">The note of the line item. This value cannot exceed 500 characters..</param>
        /// <param name="CatalogObjectId">Only used for Catalog line items. The catalog object ID for an existing [CatalogItemVariation](#type-catalogitemvariation).  Do not provide a value for this field if you provide a value for &#x60;name&#x60; and &#x60;base_price_money&#x60;..</param>
        /// <param name="Modifiers">Only used for Catalog line items. The modifiers to include on the line item..</param>
        /// <param name="Taxes">The taxes to include on the line item..</param>
        /// <param name="Discounts">The discounts to include on the line item..</param>
        public CreateOrderRequestLineItem(string Name = default(string), string Quantity = default(string), Money BasePriceMoney = default(Money), string VariationName = default(string), string Note = default(string), string CatalogObjectId = default(string), List<CreateOrderRequestModifier> Modifiers = default(List<CreateOrderRequestModifier>), List<CreateOrderRequestTax> Taxes = default(List<CreateOrderRequestTax>), List<CreateOrderRequestDiscount> Discounts = default(List<CreateOrderRequestDiscount>))
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for CreateOrderRequestLineItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.Name = Name;
            this.BasePriceMoney = BasePriceMoney;
            this.VariationName = VariationName;
            this.Note = Note;
            this.CatalogObjectId = CatalogObjectId;
            this.Modifiers = Modifiers;
            this.Taxes = Taxes;
            this.Discounts = Discounts;
        }
        
        /// <summary>
        /// Only used for ad hoc line items. The name of the line item. This value cannot exceed 500 characters.  Do not provide a value for this field if you provide a value for &#x60;catalog_object_id&#x60;.
        /// </summary>
        /// <value>Only used for ad hoc line items. The name of the line item. This value cannot exceed 500 characters.  Do not provide a value for this field if you provide a value for &#x60;catalog_object_id&#x60;.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The quantity to purchase, as a string representation of a number.  This string must have a positive integer value.
        /// </summary>
        /// <value>The quantity to purchase, as a string representation of a number.  This string must have a positive integer value.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }
        /// <summary>
        /// The base price for a single unit of the line item.  &#x60;base_price_money&#x60; is required for ad hoc line items and variable priced [CatalogItemVariation](#type-catalogitemvariation)s. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the CatalogItemVariation&#39;s price.
        /// </summary>
        /// <value>The base price for a single unit of the line item.  &#x60;base_price_money&#x60; is required for ad hoc line items and variable priced [CatalogItemVariation](#type-catalogitemvariation)s. If both &#x60;catalog_object_id&#x60; and &#x60;base_price_money&#x60; are set, &#x60;base_price_money&#x60; will override the CatalogItemVariation&#39;s price.</value>
        [DataMember(Name="base_price_money", EmitDefaultValue=false)]
        public Money BasePriceMoney { get; set; }
        /// <summary>
        /// Only used for ad hoc line items. The variation name of the line item. This value cannot exceed 255 characters.  If this value is not set for an ad hoc line item, the default value of &#x60;Regular&#x60; is used.  Do not provide a value for this field if you provide a value for the &#x60;catalog_object_id&#x60;.
        /// </summary>
        /// <value>Only used for ad hoc line items. The variation name of the line item. This value cannot exceed 255 characters.  If this value is not set for an ad hoc line item, the default value of &#x60;Regular&#x60; is used.  Do not provide a value for this field if you provide a value for the &#x60;catalog_object_id&#x60;.</value>
        [DataMember(Name="variation_name", EmitDefaultValue=false)]
        public string VariationName { get; set; }
        /// <summary>
        /// The note of the line item. This value cannot exceed 500 characters.
        /// </summary>
        /// <value>The note of the line item. This value cannot exceed 500 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// Only used for Catalog line items. The catalog object ID for an existing [CatalogItemVariation](#type-catalogitemvariation).  Do not provide a value for this field if you provide a value for &#x60;name&#x60; and &#x60;base_price_money&#x60;.
        /// </summary>
        /// <value>Only used for Catalog line items. The catalog object ID for an existing [CatalogItemVariation](#type-catalogitemvariation).  Do not provide a value for this field if you provide a value for &#x60;name&#x60; and &#x60;base_price_money&#x60;.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// Only used for Catalog line items. The modifiers to include on the line item.
        /// </summary>
        /// <value>Only used for Catalog line items. The modifiers to include on the line item.</value>
        [DataMember(Name="modifiers", EmitDefaultValue=false)]
        public List<CreateOrderRequestModifier> Modifiers { get; set; }
        /// <summary>
        /// The taxes to include on the line item.
        /// </summary>
        /// <value>The taxes to include on the line item.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<CreateOrderRequestTax> Taxes { get; set; }
        /// <summary>
        /// The discounts to include on the line item.
        /// </summary>
        /// <value>The discounts to include on the line item.</value>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public List<CreateOrderRequestDiscount> Discounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequestLineItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  BasePriceMoney: ").Append(BasePriceMoney).Append("\n");
            sb.Append("  VariationName: ").Append(VariationName).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
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
            return this.Equals(obj as CreateOrderRequestLineItem);
        }

        /// <summary>
        /// Returns true if CreateOrderRequestLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequestLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequestLineItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.BasePriceMoney == other.BasePriceMoney ||
                    this.BasePriceMoney != null &&
                    this.BasePriceMoney.Equals(other.BasePriceMoney)
                ) && 
                (
                    this.VariationName == other.VariationName ||
                    this.VariationName != null &&
                    this.VariationName.Equals(other.VariationName)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.Modifiers == other.Modifiers ||
                    this.Modifiers != null &&
                    this.Modifiers.SequenceEqual(other.Modifiers)
                ) && 
                (
                    this.Taxes == other.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(other.Taxes)
                ) && 
                (
                    this.Discounts == other.Discounts ||
                    this.Discounts != null &&
                    this.Discounts.SequenceEqual(other.Discounts)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.BasePriceMoney != null)
                    hash = hash * 59 + this.BasePriceMoney.GetHashCode();
                if (this.VariationName != null)
                    hash = hash * 59 + this.VariationName.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Modifiers != null)
                    hash = hash * 59 + this.Modifiers.GetHashCode();
                if (this.Taxes != null)
                    hash = hash * 59 + this.Taxes.GetHashCode();
                if (this.Discounts != null)
                    hash = hash * 59 + this.Discounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 500.", new [] { "Name" });
            }

            // Quantity (string) maxLength
            if(this.Quantity != null && this.Quantity.Length > 5)
            {
                yield return new ValidationResult("Invalid value for Quantity, length must be less than 5.", new [] { "Quantity" });
            }

            // Quantity (string) minLength
            if(this.Quantity != null && this.Quantity.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Quantity, length must be greater than 1.", new [] { "Quantity" });
            }

            // VariationName (string) maxLength
            if(this.VariationName != null && this.VariationName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for VariationName, length must be less than 255.", new [] { "VariationName" });
            }

            // Note (string) maxLength
            if(this.Note != null && this.Note.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Note, length must be less than 500.", new [] { "Note" });
            }

            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 192.", new [] { "CatalogObjectId" });
            }

            yield break;
        }
    }

}
