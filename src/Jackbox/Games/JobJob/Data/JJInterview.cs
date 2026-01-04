namespace Jackbox.Games.JobJob;

/// <summary>
///     
/// </summary>
public class JJInterview : JJBaseType
{
    [JsonPropertyName("question")]
    public string Question { get; set; }

    [JsonPropertyName("round")]
    public string Round { get; set; }

    [JsonPropertyName("round3Header")]
    public string Round3Header { get; set; }
}
