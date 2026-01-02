namespace Jackbox.Games.BlatherRound;

public class BlatherHint
{
    [JsonPropertyName("word")]
    public string Value { get; set; }

    [JsonPropertyName("alwaysChoose")]
    public bool AlwaysChoose { get; set; }

    public override string ToString() => Value;
}
