namespace Jackbox.Games.JobJob;

public abstract class JJBaseType
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    // Unsure what this does, all default values are an empty string ""
    [JsonPropertyName("isValid")]
    public string IsValid { get; set; }

    [JsonPropertyName("x")]
    public bool IsNsfw { get; set; }
}
