namespace Jackbox;

/// <summary>
///     Container for a Jackbox data fields.
/// </summary>
public class JackboxFieldContainer
{
    [JsonPropertyName("fields")]
    public List<JackboxField> Fields { get; set; }
}

public class JackboxField
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

public static class JackboxFieldType
{
    public const string String = "S";
    public const string Boolean = "B";
    public const string Audio = "A";
}