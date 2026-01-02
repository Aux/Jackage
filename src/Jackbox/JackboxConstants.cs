using System.Collections.Frozen;

namespace Jackbox;
public static class JackboxConstants
{
    public const string PartyPackName = "The Jackbox Party Pack";

    public const string DefaultSteamLocation = "C:\\Program Files (x86)\\Steam\\steamapps\\common";
    public const string DefaultEpicLocation = "C:\\Program Files (x86)\\Epic Games\\Games";

    public const string ConfigFileName = "config.jet";
    public const string GameConfigFileName = "jbg." + ConfigFileName;

    public static readonly FrozenDictionary<int, string> IgdbIds;

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
        }.ToFrozenDictionary();
    }
}
