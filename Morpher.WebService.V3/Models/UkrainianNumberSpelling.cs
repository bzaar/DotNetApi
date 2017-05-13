namespace Morpher.WebService.V3.Models
{
    using Newtonsoft.Json;

    public class UkrainianNumberSpelling
    {
        [JsonProperty("n")]
        public UkrainianDeclensionForms NumberDeclension { get; set; }

        [JsonProperty("unit")]
        public UkrainianDeclensionForms UnitDeclension { get; set; }
    }
}