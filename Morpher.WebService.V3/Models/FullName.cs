namespace Morpher.WebService.V3.Models
{
    using Newtonsoft.Json;

    public class FullName
    {
        [JsonProperty("Ф")]
        public string Surname { get; set; }

        [JsonProperty("И")]
        public string Name { get; set; }

        [JsonProperty("О")]
        public string Pantronymic { get; set; }
    }
}