namespace Jackage.Jackbox;

public class JackboxPack
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("is_supported")]
    public bool IsSupported { get; init; }

    [JsonPropertyName("games")]
    public IReadOnlyCollection<JackboxGame> Games { get; init; }

    [JsonIgnore]
    public string Name => JackboxConstants.Name + " " + Id;

    [JsonIgnore]
    public string CoverArtPath => $"Assets/Images/{Id}/cover-art.png";

    //public string GetGameArtPath(string gameId) => JackageConstants.AssetsDirectory + $"{Id}/{gameId}-logo.webp";
}