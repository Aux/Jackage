namespace Jackbox.Games.JobJob;

/// <summary>
/// 
/// </summary>
public class JJPosterPrompt : JJBaseType
{
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; }
}
