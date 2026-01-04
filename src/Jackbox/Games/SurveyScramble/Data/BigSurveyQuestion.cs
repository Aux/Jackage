namespace Jackbox.Games.SurveyScramble;

public class BigSurveyQuestion
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("pickerTitle")]
    public string PickerTitle { get; set; }

    [JsonPropertyName("voteTitle")]
    public string VoteTitle { get; set; }

    [JsonPropertyName("question")]
    public string Question { get; set; }

    [JsonPropertyName("starterContent")]
    public bool IsStarterContent { get; set; }

    [JsonPropertyName("reframeQuestions")]
    public List<string> ReframeQuestions { get; set; }

    [JsonPropertyName("preventedModes")]
    public List<string> PreventedModes { get; set; }
}
