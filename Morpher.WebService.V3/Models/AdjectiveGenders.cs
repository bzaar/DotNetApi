namespace Morpher.WebService.V3.Models
{
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract]
    internal class AdjectiveGenders
    {
        [DataMember(Name = "feminine")]
        public string Feminie { get; set; }

        [DataMember(Name = "neuter")]
        public string Neuter { get; set; }

        [XmlElement("plural")]
        [DataMember(Name = "plural")]
        public string Plural { get; set; }
    }
}