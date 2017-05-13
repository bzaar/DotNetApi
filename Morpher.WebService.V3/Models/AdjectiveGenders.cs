namespace Morpher.WebService.V3.Models
{
    using Newtonsoft.Json;

    public class AdjectiveGenders
    {
        [JsonProperty("feminine")]
        public string Feminie { get; set; }

        [JsonProperty("neuter")]
        public string Neuter { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }
    }
}