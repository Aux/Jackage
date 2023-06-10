using System.Diagnostics;

namespace Jackage.Views.Library;

public class LibraryModel
{
    public string GithubUrl { get; } = "";
    public string DiscordUrl { get; } = "";
    public List<JackboxModel> Jackboxes { get; set; }

    private void OpenUrl(string url)
        => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
}
