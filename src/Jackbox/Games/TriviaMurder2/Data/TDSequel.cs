namespace Jackbox.Games.TriviaMurder2;

/// <summary>
///     Sequel text that appears for the winner at the end of the game.
/// </summary>
public class TDSequel
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("minSequel")]
    public int MinimumSequel { get; set; }

    // This is 0 for every default except 101414
    [JsonPropertyName("generationJump")]
    public int GenerationJump { get; set; } = 0;

    // Is null for all defaults except one instance of 'REVERSE'
    [JsonPropertyName("nameModifier")]
    public string NameModifier { get; set; }

    [JsonPropertyName("playerNamePrefix")]
    public string PlayerNamePrefix { get; set; }

    [JsonPropertyName("tag")]
    public string Tag { get; set; }

    [JsonPropertyName("text")]
    public TrivialSequelText Text { get; set; }
}

/// <summary>
///     Text that appears as the newspaper headline
/// </summary>
public class TrivialSequelText
{
    [JsonPropertyName("main")]
    public string MainHeader { get; set; }

    [JsonPropertyName("sub")]
    public string SubHeader { get; set; }

    [JsonPropertyName("lowerThird")]
    public string LowerThird { get; set; } = "lowerThird";
}