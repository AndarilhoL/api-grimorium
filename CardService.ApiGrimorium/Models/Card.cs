using System.Text.Json.Serialization;

namespace CardService.ApiGrimorium.Models
{
    public class Card
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("manaCost")]
        public string? ManaCost { get; set; }

        [JsonPropertyName("cmc")]
        public double Cmc { get; set; }

        [JsonPropertyName("colors")]
        public List<string>? Colors { get; set; }

        [JsonPropertyName("colorIdentity")]
        public List<string>? ColorIdentity { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("types")]
        public List<string>? Types { get; set; }

        [JsonPropertyName("subtypes")]
        public List<string>? Subtypes { get; set; }

        [JsonPropertyName("rarity")]
        public string? Rarity { get; set; }

        [JsonPropertyName("set")]
        public string? Set { get; set; }

        [JsonPropertyName("setName")]
        public string? SetName { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("flavor")]
        public string? Flavor { get; set; }

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }

        [JsonPropertyName("power")]
        public string? Power { get; set; }

        [JsonPropertyName("toughness")]
        public string? Toughness { get; set; }

        [JsonPropertyName("layout")]
        public string? Layout { get; set; }

        [JsonPropertyName("multiverseid")]
        public string? Multiverseid { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        [JsonPropertyName("foreignNames")]
        public List<ForeignName>? ForeignNames { get; set; }

        [JsonPropertyName("printings")]
        public List<string>? Printings { get; set; }

        [JsonPropertyName("originalText")]
        public string? OriginalText { get; set; }

        [JsonPropertyName("originalType")]
        public string? OriginalType { get; set; }

        [JsonPropertyName("legalities")]
        public List<Legality>? Legalities { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("watermark")]
        public string? Watermark { get; set; }

        [JsonPropertyName("variations")]
        public List<string>? Variations { get; set; }
    }
}
