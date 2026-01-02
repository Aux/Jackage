using System.Drawing;

namespace Jackbox.TriviaMurder2;

/// <summary>
///     Pre-drawn images that the ghost will draw for the Mirror minigame.
/// </summary>
public class TDMirror
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("lines")]
    public List<JackboxLine> Lines { get; set; }
}
