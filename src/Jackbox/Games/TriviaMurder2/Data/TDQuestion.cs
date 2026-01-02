namespace Jackbox.TriviaMurder2;

/// <summary>
/// 
/// </summary>
public class TDQuestion
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("x")]
    public bool X { get; set; }

    [JsonPropertyName("us")]
    public bool IsUS { get; set; }

    [JsonPropertyName("hasIntro")]
    public bool HasIntro { get; set; }

    [JsonPropertyName("hasOutro")]
    public bool HasOutro { get; set; }

    [JsonPropertyName("hasPic")]
    public bool HasPicture { get; set; }
}

/// <summary>
/// 
/// </summary>
public class TDQuestionAnswer
{
    [JsonPropertyName("controllerClass")]
    public string ControllerClass { get; set; } = "";

    [JsonPropertyName("correct")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IsCorrect { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
