﻿namespace Morpher.WebService.V3.Models
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Morpher.WebService.V3.Models.Interfaces;

    using Newtonsoft.Json;

    public class UkrainianDeclensionForms : IUkrainianParadigm, IEquatable<UkrainianDeclensionForms>
    {
        [JsonProperty("Н")]
        public string Nominative { get; set; }

        [JsonProperty("Р")]
        public string Genitive { get; set; }

        [JsonProperty("Д")]
        public string Dative { get; set; }

        [JsonProperty("З")]
        public string Accusative { get; set; }

        [JsonProperty("О")]
        public string Instrumental { get; set; }

        [JsonProperty("М")]
        public string Prepositional { get; set; }

        [JsonProperty("К")]
        public string Vocative { get; set; }

        [SuppressMessage("ReSharper", "StyleCop.SA1126")]
        public static bool operator ==(UkrainianDeclensionForms left, UkrainianDeclensionForms right)
        {
            return Equals(left, right);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1126")]
        public static bool operator !=(UkrainianDeclensionForms left, UkrainianDeclensionForms right)
        {
            return !Equals(left, right);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1503")]
        public bool Equals(UkrainianDeclensionForms other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(this.Nominative, other.Nominative) &&
                string.Equals(this.Genitive, other.Genitive) && 
                string.Equals(this.Dative, other.Dative) && 
                string.Equals(this.Accusative, other.Accusative) &&
                string.Equals(this.Instrumental, other.Instrumental) && 
                string.Equals(this.Prepositional, other.Prepositional) && 
                string.Equals(this.Vocative, other.Vocative);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1503")]
        [SuppressMessage("ReSharper", "StyleCop.SA1126")]
        [SuppressMessage("ReSharper", "ArrangeThisQualifier")]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((UkrainianDeclensionForms)obj);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1119")]
        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (this.Nominative != null ? this.Nominative.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Genitive != null ? this.Genitive.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Dative != null ? this.Dative.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Accusative != null ? this.Accusative.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Instrumental != null ? this.Instrumental.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Prepositional != null ? this.Prepositional.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Vocative != null ? this.Vocative.GetHashCode() : 0);
                return hashCode;
            }
        }

    }
}