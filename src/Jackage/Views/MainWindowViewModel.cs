using System;
using System.Reactive.Linq;

namespace Jackage.Views;

public class MainWindowViewModel : ViewModelBase
{
    public LibraryViewModel Library { get; set; }

    public MainWindowViewModel()
    {
        ActiveView = Library = new LibraryViewModel();
    }

    private ViewModelBase _activeView;
    public ViewModelBase ActiveView
    {
        get => _activeView;
        private set => RaiseAndSetIfChanged(ref _activeView, value);
    }

    private void CreateSettingsView()
    {
        var settings = new SettingsViewModel();

        Observable.Merge(
            settings.Apply,
            settings.Exit)
            .Take(1)
            .Subscribe(_ =>
            {
                ActiveView = Library;
            });

        ActiveView = settings;
    }
}
