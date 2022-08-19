using System.Text.Json.Serialization;

namespace CardService.ApiGrimorium.Models
{
    public class Root
    {
        [JsonPropertyName("cards")]
        public List<Card>? Cards { get; set; }
    }
}
