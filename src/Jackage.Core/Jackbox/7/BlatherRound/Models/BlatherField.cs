namespace Jackage.Jackbox.BlatherRound;

/// <summary>
///     Container for a Blather data fields.
/// </summary>
public class BlatherFieldContainer
{
    [JsonPropertyName("fields")]
    public List<BlatherField> Fields { get; set; }
}

public class BlatherField
{
    [JsonPropertyName("t")]
    public string Type { get; set; }

    /// <remarks>
    ///     When the value is a collection, it becomes a single string deliminated by the | character.
    /// </remarks>
    [JsonPropertyName("v")]
    public string Value { get; set; }

    [JsonPropertyName("n")]
    public string Name { get; set; }
}

public static class BlatherFieldType
{
    public const string String = "S";
    public const string Boolean = "B";
}