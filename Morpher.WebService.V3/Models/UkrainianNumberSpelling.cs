namespace Morpher.WebService.V3.Models
{
    using System.Runtime.Serialization;

    [DataContract(Name = "PropisUkrResult", Namespace = "http://schemas.datacontract.org/2004/07/Morpher.WebApi.Models")]
    internal class UkrainianNumberSpelling
    {
        [DataMember(Name = "n")]
        public UkrainianDeclensionForms NumberDeclension { get; set; }

        [DataMember(Name = "unit")]
        public UkrainianDeclensionForms UnitDeclension { get; set; }
    }
}