using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using Jackage.Jackbox;
using Jackage.Views;
using System;
using System.Collections.Generic;
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

            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(manifest),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}