namespace Morpher.WebService.V3.Models
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Morpher.Russian;
    using Morpher.WebService.V3.Models.Interfaces;

    using Newtonsoft.Json;

    public class RussianDeclensionForms : IRussianParadigm, IParadigm, IEquatable<RussianDeclensionForms>
    {
        [JsonProperty(PropertyName = "И")]
        public string Nominative { get; set; }

        [JsonProperty(PropertyName = "Р")]
        public string Genitive { get; set; }

        [JsonProperty("Д")]
        public string Dative { get; set; }

        [JsonProperty("В")]
        public string Accusative { get; set; }

        [JsonProperty("Т")]
        public string Instrumental { get; set; }

        [JsonProperty("П")]
        public string Prepositional { get; set; }

        [JsonProperty("П-о")]
        public string Locative { get; set; }


        [SuppressMessage("ReSharper", "StyleCop.SA1126")]
        public static bool operator ==(RussianDeclensionForms left, RussianDeclensionForms right)
        {
            return Equals(left, right);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1126")]
        public static bool operator !=(RussianDeclensionForms left, RussianDeclensionForms right)
        {
            return !Equals(left, right);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1503")]
        public bool Equals(RussianDeclensionForms other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(this.Nominative, other.Nominative) &&
                string.Equals(this.Genitive, other.Genitive) &&
                string.Equals(this.Dative, other.Dative) &&
                string.Equals(this.Accusative, other.Accusative) &&
                string.Equals(this.Instrumental, other.Instrumental) &&
                string.Equals(this.Prepositional, other.Prepositional) &&
                string.Equals(this.Locative, other.Locative);
        }

        [SuppressMessage("ReSharper", "StyleCop.SA1503")]
        [SuppressMessage("ReSharper", "StyleCop.SA1126")]
        [SuppressMessage("ReSharper", "ArrangeThisQualifier")]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((RussianDeclensionForms)obj);
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
                hashCode = (hashCode * 397) ^ (this.Locative != null ? this.Locative.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}