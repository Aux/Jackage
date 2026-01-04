namespace Jackbox;

public class JackboxManifest
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("types")]
    public List<string> Types { get; set; }
}
