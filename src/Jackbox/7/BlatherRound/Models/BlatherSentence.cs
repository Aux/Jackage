namespace Jackbox.BlatherRound;

/// <summary>
///     Invidual items inside of BlankyBlankSentenceStructures.jet
/// </summary>
public class BlatherSentence
{
    /// <summary>
    ///     Category of password these sentences are used for.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>
    ///     Folder id for locating this sentence's data.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    ///     Collection of string formats that can appear for the Hinter to choose from.
    /// </summary>
    [JsonPropertyName("structures")]
    public List<string> Structures { get; set; }

    public override string ToString() => $"{Category} ({Id})";
}
