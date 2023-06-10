using System.Text.Json.Serialization;

namespace Jackage.Jackbox;
public class JackboxManifest
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("id")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public List<string> Types { get; set; }
}
