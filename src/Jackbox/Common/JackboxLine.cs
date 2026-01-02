using System.Drawing;

namespace Jackbox;

/// <summary>
///     Standard format used for drawing data.
/// </summary>
public class JackboxLine
{
    [JsonPropertyName("thickness")]
    public int Thickness { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("points")]
    public string PointsValue => string.Join('|', Points);

    [JsonIgnore]
    public List<Point> Points { get; set; }
}