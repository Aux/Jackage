namespace Jackbox.Games.TriviaMurder2;

/// <summary>
///     Possible paragraphs for the Dictation minigame.
/// </summary>
/// <remarks>
///     Might not be viable for modding. <see cref="EventName"/> points to a muxed audio file.
/// </remarks>
public class TDDictation
{
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("text")]
    public List<string> Text { get; set; }
}
