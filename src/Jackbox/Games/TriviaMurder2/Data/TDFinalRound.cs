namespace Jackbox.Games.TriviaMurder2;

/// <summary>
///     Subject of a question in the Final Round minigame.
/// </summary>
public class TDFinalRound
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("text")]
    public string Subject { get; set; }

    [JsonPropertyName("x")]
    public bool IsNsfw { get; set; }

    [JsonPropertyName("choices")]
    public List<TDFinalRoundChoice> Choices { get; set; }
}

/// <summary>
///     Possible answers to a Find Round subject.
/// </summary>
public class TDFinalRoundChoice
{
    [JsonPropertyName("correct")]
    public bool IsCorrect { get; set; }

    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }

    [JsonPropertyName("text")]
    public string Answer { get; set; }
}
