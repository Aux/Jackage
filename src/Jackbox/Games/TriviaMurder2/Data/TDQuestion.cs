namespace Jackbox.TriviaMurder2;

/// <summary>
/// 
/// </summary>
public class TDQuestion
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("text")]
    public string Question { get; set; }

    [JsonPropertyName("questionAudio")]
    public string QuestionCaptions { get; set; }

    [JsonPropertyName("introAudio")]
    public string IntroCaptions { get; set; }

    [JsonPropertyName("x")]
    public bool IsNsfw { get; set; }

    [JsonPropertyName("us")]
    public bool IsUS { get; set; }

    [JsonPropertyName("choices")]
    public List<TDQuestionChoice> Choices { get; set; }

    // Unsure what this property is for/does, all default values for it are null
    [JsonPropertyName("outro")]
    public object HasOutro { get; set; }
}

/// <summary>
/// 
/// </summary>
public class TDQuestionChoice
{
    // Only used during the post-win bomb minigame
    [JsonPropertyName("correct")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ControllerClass { get; set; } = null;

    [JsonPropertyName("correct")]
    public bool IsCorrect { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
