using System.Diagnostics;

namespace Jackage.Views;

public class LibraryViewModel : ViewModelBase
{
    public const string Title = "Welcome to Jackage!";
    public const string Description = "Select a Party Pack to get started.";

    private void OpenUrl(string url)
        => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
}
