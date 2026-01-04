namespace Jackbox.Games.JobJob;

/// <summary>
/// 
/// </summary>
public class JJPrompt : JJBaseType
{
    [JsonPropertyName("phrase")]
    public string Phrase { get; set; }
}
