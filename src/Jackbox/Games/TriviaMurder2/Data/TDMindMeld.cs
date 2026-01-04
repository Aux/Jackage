namespace Jackbox.Games.TriviaMurder2;

/// <summary>
///     Subject for the Mind Meld minigame.
/// </summary>
public class TDMindMeld
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("text")]
    public string Subject { get; set; }

    [JsonPropertyName("x")]
    public bool IsNsfw { get; set; }

    [JsonPropertyName("us")]
    public bool IsUS { get; set; }

    [JsonPropertyName("answers")]
    public List<TDMindMeldAnswer> Answers { get; set; }
}

/// <summary>
///     Acceptable answer for the Mind Meld minigame.
/// </summary>
public class TDMindMeldAnswer
{
    [JsonPropertyName("answer")]
    public string Answer { get; set; }

    [JsonPropertyName("alt")]
    public List<string> AcceptableAlternates { get; set; }
}