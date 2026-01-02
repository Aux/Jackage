namespace Jackbox.TriviaMurder2;

/// <summary>
///     Subject of a question in the Final Round minigame.
/// </summary>
public class TDFinalRound
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("x")]
    public bool X { get; set; }

    [JsonPropertyName("choices")]
    public List<TDFinalRoundChoice> Choices { get; set; }
}

/// <summary>
///     Possible answers to a Find Round subject.
/// </summary>
public class TDFinalRoundChoice
{
    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }

    [JsonPropertyName("correct")]
    public bool IsCorrect { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
