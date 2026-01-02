namespace Jackbox;

public class JackboxContainer<T>
{
    [JsonPropertyName("episodeid")]
    public int EpisodeId { get; set; }

    [JsonPropertyName("content")]
    public List<T> Content { get; set; }
}
