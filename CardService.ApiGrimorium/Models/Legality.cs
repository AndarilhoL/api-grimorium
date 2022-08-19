using System.Text.Json.Serialization;

namespace CardService.ApiGrimorium.Models
{
    public class Legality
    {
        [JsonPropertyName("format")]
        public string? Format { get; set; }

        [JsonPropertyName("legality")]
        public string? LegalityFormat { get; set; }
    }
}
