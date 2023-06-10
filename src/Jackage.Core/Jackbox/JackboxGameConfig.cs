using System.Text.Json.Serialization;

namespace Jackage.Jackbox;

public class JackboxGameConfig
{
    /// <summary>
    ///     Url safe version of this game's name.
    /// </summary>
    [JsonPropertyName("gameTag")]
    public string GameTag { get; set; }

    /// <summary>
    ///     GUID that uniquely identifies this game between all Jackbox games.
    /// </summary>
    [JsonPropertyName("gameId")]
    public string GameId { get; set; }

    /// <summary>
    ///     The name used internally to reference files for this game.
    /// </summary>
    [JsonPropertyName("gameName")]
    public string GameName { get; set; }

    /// <summary>
    ///     Same value as <see cref="GameName"/>, difference not known.
    /// </summary>
    [JsonPropertyName("uaAppId")]
    public string UaAppId { get; set; }

    /// <summary>
    ///     Same value as <see cref="GameName"/>, difference not known.
    /// </summary>
    [JsonPropertyName("uaAppName")]
    public string UaAppName { get; set; }

    /// <summary>
    ///     Standard semantic versioning number, unknown usage.
    /// </summary>
    [JsonPropertyName("uaVersionId")]
    public string UaVersionId { get; set; }

    /// <summary>
    ///     The type of audio file used for this game.
    /// </summary>
    [JsonPropertyName("audio-extension")]
    public string AudioExtension { get; set; }

    /// <summary>
    ///     The url players can use to join this game through the internet.
    /// </summary>
    [JsonPropertyName("joinUrl")]
    public string JoinUrl { get; set; }

    /// <summary>
    ///     The server url the game uses to connect to the internet.
    /// </summary>
    [JsonPropertyName("serverUrl")]
    public string ServerUrl { get; set; }

    /// <summary>
    ///     The directory all of the game's internal contents are stored.
    /// </summary>
    [JsonPropertyName("jsonMain")]
    public string JsonMainDirectory { get; set; }

    /// <summary>
    ///     The date and time that this build was issued.
    /// </summary>
    [JsonPropertyName("buildTimeStamp")]
    public DateTime BuildTimestamp { get; set; }

    /// <summary>
    ///     The build number associated with this version of the game.
    /// </summary>
    [JsonPropertyName("buildVersion")]
    public string BuildVersion { get; set; }
}
