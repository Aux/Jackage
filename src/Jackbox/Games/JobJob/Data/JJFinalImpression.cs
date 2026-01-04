namespace Jackbox.Games.JobJob;

/// <summary>
///     
/// </summary>
public class JJFinalImpression : JJBaseType
{
    [JsonPropertyName("firstPrompt")]
    public string FirstPrompt { get; set; }

    [JsonPropertyName("secondPrompt")]
    public string SecondPrompt { get; set; }
}
