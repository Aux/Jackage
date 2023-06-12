namespace Jackage.Jackbox;

public class JackboxGame : ISupported
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("is_supported")]
    public bool IsSupported { get; init; }

    [JsonIgnore]
    public int PackId { get; set; } = -1;

    [JsonIgnore]
    public string InstallPath { get; set; } = null;

    [JsonIgnore]
    public string GameArtPath => $"Assets/Images/{PackId}/{Id}-logo.webp";
}