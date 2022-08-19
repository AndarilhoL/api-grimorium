using System.Text.Json.Serialization;

namespace CardService.ApiGrimorium.Models
{
    public class ForeignName
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("flavor")]
        public object? Flavor { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("multiverseid")]
        public object? Multiverseid { get; set; }
    }
}
