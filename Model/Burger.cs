using System.Text.Json;
using System.Text.Json.Serialization;

namespace KrasovBurger.Model
{
    public class Burger
    {
        public string Id { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Burger>(this);
    }
}
