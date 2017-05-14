namespace Morpher.WebService.V3.Models
{
    using System.Runtime.Serialization;

    [DataContract(Name = "PropisResult", Namespace = "http://schemas.datacontract.org/2004/07/Morpher.WebApi.Models")]
    internal class RussianNumberSpelling
    {
        [DataMember(Name = "n")]
        public RussianDeclensionForms NumberDeclension { get; set; }

        [DataMember(Name = "unit")]
        public RussianDeclensionForms UnitDeclension { get; set; }
    }
}