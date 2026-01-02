namespace Jackbox.TriviaMurder2;

/// <summary>
///     Sequel text that appears for the winner at the end of the game.
/// </summary>
public class TDSequel
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("minSequel")]
    public int MinimumSequel { get; set; }

    [JsonPropertyName("tag")]
    public string Tag { get; set; }

    [JsonPropertyName("playerNamePrefix")]
    public string PlayerNamePrefix { get; set; }

    [JsonPropertyName("text")]
    public TrivialSequelText Text { get; set; }
}

/// <summary>
///     Text that appears as the newspaper headline
/// </summary>
public class TrivialSequelText
{
    [JsonPropertyName("main")]
    public string Main { get; set; }

    [JsonPropertyName("sub")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Sub { get; set; }

    [JsonPropertyName("lowerThird")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string LowerThird { get; set; }
}