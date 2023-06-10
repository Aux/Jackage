namespace Jackage.Jackbox.BlatherRound;

/// <summary>
///     Invidual items inside of BlankyBlankWordLists.jet
/// </summary>
public class BlatherDescriber
{
    /// <summary>
    ///     Unknown, value is always empty.
    /// </summary>
    [JsonPropertyName("amount")]
    public string Amount { get; set; }

    /// <summary>
    ///     Folder id for locating this describer's data.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    ///     
    /// </summary>
    [JsonPropertyName("maxChoices")]
    public int? MaxChoices { get; set; }

    /// <summary>
    ///     Unique name for this describer.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    ///     
    /// </summary>
    [JsonPropertyName("optional")]
    public bool IsOptional { get; set; }

    /// <summary>
    ///     
    /// </summary>
    [JsonPropertyName("placeholder")]
    public string Placeholder { get; set; }

    /// <summary>
    ///     
    /// </summary>
    [JsonPropertyName("words")]
    public List<BlatherDescriberWord> Words { get; set; }
}
