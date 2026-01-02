namespace Jackbox.Games.BlatherRound;

public class BlatherPasswordHint
{
    /// <summary>
    ///     The category this hint can appear in.
    /// </summary>
    [JsonPropertyName("list")]
    public string Category { get; set; }

    /// <summary>
    ///     The value of the tailored word.
    /// </summary>
    [JsonPropertyName("word")]
    public string Value { get; set; }

    public override string ToString() => $"{Value} {Category}";
}
