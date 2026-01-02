using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using Jackage.ViewModels;
using Jackage.Views;
using Microsoft.Extensions.DependencyInjection;
using SukiUI;

namespace Jackage;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Line below is needed to remove Avalonia data validation.
        // Without this line you will get duplicate validations from both Avalonia and CT
        BindingPlugins.DataValidators.RemoveAt(0);

        var suki = SukiTheme.GetInstance();
        suki.ChangeBaseTheme(ThemeVariant.Dark);
        suki.ChangeColorTheme(SukiUI.Enums.SukiColor.Green);

        var services = new ServiceCollection();
        services.AddAllServices();
        var provider = services.BuildServiceProvider();

        var vm = provider.GetRequiredService<MainViewModel>();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = vm
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = vm
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
