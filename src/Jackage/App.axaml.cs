using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using Jackage.Jackbox;
using Jackage.Services;
using Jackage.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Jackage;
public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();
            var stream = assets.Open(new Uri(JackageConstants.AssetsDirectory + "manifest.json"));
            var manifest = JsonSerializer.Deserialize<IReadOnlyCollection<JackboxPack>>(stream);

            var paths = new JackboxLocator().GetJackboxInstalls();

            foreach (var pack in manifest)
            {
                if (pack.Id == 1)   // First jackbox is just "jackbox"
                    pack.InstallPath = paths.SingleOrDefault(x => Path.GetFileName(x) == JackboxConstants.Name);
                else
                    pack.InstallPath = paths.SingleOrDefault(x => Path.GetFileName(x).EndsWith(pack.Id.ToString()));
            }

            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(manifest),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}