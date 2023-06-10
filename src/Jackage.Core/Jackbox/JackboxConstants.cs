namespace Jackage.Jackbox;

public static class JackboxConstants
{
    public const string Name = "The Jackbox Party Pack";

    public const string DefaultSteamLocation = "C:\\Program Files (x86)\\Steam\\steamapps\\common";
    public const string DefaultEpicLocation = "C:\\Program Files (x86)\\Epic Games\\Games";

    /// <summary>
    ///     File name for the Jackbox internal game configuration.
    /// </summary>
    public const string GameConfigFileName = "jbg." + ConfigFileName;

    /// <summary>
    ///     File name for the Jackbox pack configuration.
    /// </summary>
    public const string ConfigFileName = "config.jet";

    /// <summary>
    ///     Unique ids for obtaining information about each game through IGDB.
    /// </summary>
    public static readonly IReadOnlyDictionary<int, string> IgdbIds;

    static JackboxConstants()
    {
        IgdbIds = new Dictionary<int, string>
        {
            { 1, "11529" },
            { 2, "19081" },
            { 3, "19082" },
            { 4, "28213" },
            { 5, "96213" },
            { 6, "125021" },
            { 7, "138375" },
            { 8, "144783" },
            { 9, "198560" },
            { 10, "243869" }
        };
    }
}
