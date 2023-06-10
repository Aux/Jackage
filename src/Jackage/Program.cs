using Avalonia;
using Avalonia.ReactiveUI;
using Projektanker.Icons.Avalonia;
using Projektanker.Icons.Avalonia.FontAwesome;
using Splat;
using System;

namespace Jackage;

internal class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp(Locator.Current)
        .StartWithClassicDesktopLifetime(args);
    
    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp(IReadonlyDependencyResolver resolver)
         => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .WithIcons(x => x.Register<FontAwesomeIconProvider>())
            .UseReactiveUI();
}
