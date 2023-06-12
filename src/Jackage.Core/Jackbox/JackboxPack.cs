namespace Jackage.Jackbox;

public class JackboxPack : ISupported
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("is_supported")]
    public bool IsSupported { get; init; }

    [JsonPropertyName("games")]
    public IReadOnlyCollection<JackboxGame> Games { get; init; }

    [JsonIgnore]
    public string InstallPath { get; set; } = null;

    [JsonIgnore]
    public string Name => JackboxConstants.Name + " " + Id;

    [JsonIgnore]
    public string CoverArtPath => $"Assets/Images/{Id}/cover-art.png";
}