using System.Text.Json.Serialization;

namespace Jackage.Jackbox;

/// <summary>
///     Container for a Jackbox localization table.
/// </summary>
public class JackboxLocalizationContainer<T> where T : JackboxLocalization
{
    [JsonPropertyName("table")]
    public JackboxLocalizationsTable<T> Table { get; set; }
}

/// <summary>
///     Languages supported for localizations.
/// </summary>
public class JackboxLocalizationsTable<T> where T : JackboxLocalization
{
    [JsonPropertyName("en")]
    public JackboxLocalization English { get; set; }

    [JsonPropertyName("fr")]
    public JackboxLocalization French { get; set; }

    [JsonPropertyName("it")]
    public JackboxLocalization Italian { get; set; }

    [JsonPropertyName("de")]
    public JackboxLocalization Deutch { get; set; }

    [JsonPropertyName("es")]
    public JackboxLocalization Spanish { get; set; }
}

/// <summary>
///     Default localization fields.
/// </summary>
public class JackboxLocalization
{
    [JsonPropertyName("LANGUAGE_NAME")]
    public string LocalizationName { get; set; }

    [JsonPropertyName("LANGUAGE")]
    public string Language { get; set; }

    [JsonPropertyName("INTERNET_CONNECTED")]
    public string InternetConnected { get; set; }

    [JsonPropertyName("INTERNET_DISCONNECTED")]
    public string InternetDisconnected { get; set; }

    [JsonPropertyName("ROOM_DESTROYED")]
    public string RoomDestroyed { get; set; }

    [JsonPropertyName("SOCKET_DISCONNECTED")]
    public string SocketDisconnected { get; set; }

    [JsonPropertyName("TIMEOUT")]
    public string Timeout { get; set; }

    [JsonPropertyName("USER_DISCONNECT")]
    public string UserDisconnect { get; set; }

    [JsonPropertyName("LOST_LICENSE")]
    public string LostLicense { get; set; }

    [JsonPropertyName("STEAM_ERROR")]
    public string SteamError { get; set; }

    [JsonPropertyName("TWITCH_PRIME_ERROR")]
    public string TwitchPrimeError { get; set; }

    [JsonPropertyName("LOST_DLC")]
    public string LostDlc { get; set; }
}
