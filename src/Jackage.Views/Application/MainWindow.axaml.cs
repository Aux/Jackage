using Avalonia;
using Avalonia.Markup.Xaml;
using ReactiveUI;

namespace Jackage.Views.Application;

public class MainWindow : BaseWindow<MainWindowModel>
{
    public MainWindow() : base(false)
    {
        this.WhenActivated(disposables =>
        {
            this.DisposeWith(disposables);
        });

        AvaloniaXamlLoader.Load(this);
        this.AttachDevTools();
    }
}