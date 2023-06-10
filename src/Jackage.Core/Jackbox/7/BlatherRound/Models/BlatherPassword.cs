namespace Jackage.Jackbox.BlatherRound.Models;

/// <summary>
///     Invidual items inside of BlankyBlankPasswords.jet
/// </summary>
public class BlatherPassword
{
    /// <summary>
    ///     Folder id for locating this passwords's data.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    ///     The correct guess for this password.
    /// </summary>
    [JsonPropertyName("password")]
    public string Value { get; set; }

    /// <summary>
    ///     The category that determines what type of sentences the Hinter gets for this password.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>
    ///     
    /// </summary>
    [JsonPropertyName("subcategory")]
    public string Subcategory { get; set; }

    /// <summary>
    ///     How difficult the password is to guess.
    /// </summary>
    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; }

    /// <summary>
    ///     Whether this word is contextual to the United States.
    /// </summary>
    [JsonPropertyName("us")]
    public bool IsUS { get; set; }

    /// <summary>
    ///     Values for guesses that should still count as a win.
    /// </summary>
    [JsonPropertyName("alternateSpellings")]
    public List<string> AlternateSpellings { get; set; }

    /// <summary>
    ///     Values for guesses that should be ignored in case of false positives.
    /// </summary>
    [JsonPropertyName("forbiddenWords")]
    public List<string> ForbiddenWords { get; set; }

    /// <summary>
    ///     Additional describers to include in the hint pool.
    /// </summary>
    [JsonPropertyName("tailoredWords")]
    public List<object> TailoredWords { get; set; }
}
