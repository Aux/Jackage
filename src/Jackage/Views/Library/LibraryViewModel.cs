using Jackage.Jackbox;
using System.Collections.Generic;
using System.Diagnostics;

namespace Jackage.Views;

public class LibraryViewModel : ViewModelBase
{
    public string Title => "Welcome to Jackage!";
    public string Description => "Select a Party Pack to get started.";

    public IReadOnlyCollection<JackboxPack> Manifest { get; }

    public LibraryViewModel(IReadOnlyCollection<JackboxPack> manifest)
    {
        Manifest = manifest;
    }

    private void OpenUrl(string url)
        => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
}
