using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Jackage.Jackbox;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Jackage.Services;

public class JackboxLocator
{
    public IEnumerable<string> GetJackboxInstalls()
    {
        // I only know how to dynamically locate on windows, so linux/osx will have to use the file dialog instead.
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return null;

        var steamInstalls = FindSteamInstalls();
        return steamInstalls;
    }

    private IEnumerable<string> FindSteamInstalls()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            using var key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam");
            if (key == null)
                return null;

            string installPath = key.GetValue("InstallPath") as string;
            if (installPath == null)
                return null;

            var libraryFile = Path.Combine(installPath, "steamapps", "libraryfolders.vdf");
            if (!File.Exists(libraryFile))
                return null;

            var jackboxInstalls = new List<string>();
            var vdf = VdfConvert.Deserialize(File.ReadAllText(libraryFile));
            foreach (var value in vdf.Value.Children())
            {
                if (value is not VProperty p)
                    continue;
                if (p.Value is not VObject obj)
                    continue;

                var gamesPath = obj["path"]?.Value<string>();
                if (string.IsNullOrWhiteSpace(gamesPath))
                    continue;

                gamesPath = Path.Combine(gamesPath, "steamapps\\common");
                var allGames = Directory.GetDirectories(gamesPath);
                var jackboxPaths = allGames.Where(x => Path.GetFileName(x).StartsWith(JackboxConstants.Name));
                if (jackboxPaths.Any())
                    jackboxInstalls.AddRange(jackboxPaths);
            }

            if (jackboxInstalls.Any())
                return jackboxInstalls;
        }

        return null;
    }

    private string FindEpicLocation()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            using var key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Epic Games\\EpicGamesLauncher");
            if (key == null)
                return null;

            string installPath = key.GetValue("AppDataPath") as string;
            if (installPath == null)
                return null;

            return installPath;
        }

        return null;
    }
}
