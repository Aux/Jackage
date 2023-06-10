using System.Text.Json.Serialization;

namespace Jackage.Jackbox;

public class JackboxJsonContent<T>
{
    /// <summary>
    ///     Generic container used in all Jackbox jet files.
    /// </summary>
    [JsonPropertyName("content")]
    public IEnumerable<T> Content { get; set; }
}
