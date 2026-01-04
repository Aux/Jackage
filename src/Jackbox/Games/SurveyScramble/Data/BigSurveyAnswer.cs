namespace Jackbox.Games.SurveyScramble;

public class BigSurveyAnswer
{
    [JsonPropertyName("a")]
    public List<string> AcceptableWords { get; set; }

    [JsonPropertyName("d")]
    public string Definition { get; set; }

    [JsonPropertyName("f")]
    public int TotalFound { get; set; }

    [JsonPropertyName("x")]
    public bool IsNsfw { get; set; }
}
