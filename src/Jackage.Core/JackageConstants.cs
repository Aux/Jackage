using System.Text.Json;

namespace Jackage;

public static class JackageConstants
{
    /// <summary>
    ///     Default instance of the json serializer options for jet files.
    /// </summary>
    public static readonly JsonSerializerOptions JsonOptions;

    static JackageConstants()
    {
        JsonOptions = new()
        {
            NumberHandling =
                JsonNumberHandling.AllowReadingFromString |
                JsonNumberHandling.WriteAsString,
            WriteIndented = true
        };
    }
}
