namespace Morpher.WebService.V3.Models
{
    using Newtonsoft.Json;

    public class RussianDeclensionResult : RussianDeclensionForms
    {
        [JsonProperty("род")]
        public string Gender { get; set; }

        [JsonProperty("множественное")]
        public RussianDeclensionForms Plural { get; set; }

        [JsonProperty("ФИО")]
        public FullName FullName { get; set; }

        [JsonProperty("где")]
        public string Where { get; set; }

        [JsonProperty("куда")]
        public string To { get; set; }

        [JsonProperty("откуда")]
        public string From { get; set; }
    }
}