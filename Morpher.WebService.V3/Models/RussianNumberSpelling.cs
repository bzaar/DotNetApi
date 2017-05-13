namespace Morpher.WebService.V3.Models
{
    using Newtonsoft.Json;

    public class RussianNumberSpelling
    {
        [JsonProperty("n")]
        public RussianDeclensionForms NumberDeclension { get; set; }

        [JsonProperty("unit")]
        public RussianDeclensionForms UnitDeclension { get; set; }
    }
}