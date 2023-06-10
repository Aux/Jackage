namespace Jackage.Jackbox;

public class JackboxGame
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("is_supported")]
    public bool IsSupported { get; init; }
}