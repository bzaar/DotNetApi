namespace Morpher.WebService.V3.Models
{
    using Newtonsoft.Json;

    public class UkrainianDeclensionResult : UkrainianDeclensionForms
    {
        [JsonProperty("рід")]
        public string Gender { get; set; }
    }
}