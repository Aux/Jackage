using Jackage.Jackbox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Linq;

namespace Jackage.Views;

public class MainWindowViewModel : ViewModelBase
{
    public IReadOnlyCollection<JackboxPack> Manifest { get; }
    public LibraryViewModel Library { get; set; }

    public MainWindowViewModel(IReadOnlyCollection<JackboxPack> manifest)
    {
        Manifest = manifest;
        ActiveView = Library = new LibraryViewModel();
    }

    private ViewModelBase _activeView;
    public ViewModelBase ActiveView
    {
        get => _activeView;
        private set => RaiseAndSetIfChanged(ref _activeView, value); 
    }

    private ViewModelBase _previousView;
    public ViewModelBase PreviousView
    {
        get => _previousView;
        private set => RaiseAndSetIfChanged(ref _previousView, value);
    }

    private void OpenUrl(string url)
        => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

    private void CreateSettingsView()
    {
        CreateView(new SettingsViewModel(), view =>
        {
            Observable.Merge(
                view.Apply,
                view.Cancel)
                .Take(1)
                .Subscribe(_ => ActiveView = PreviousView);
        });
    }

    private void CreateImportView()
    {
        CreateView(new ImportViewModel(), view =>
        {
            view.Cancel.Subscribe(_ => ActiveView = PreviousView);
        });
    }

    private void CreateGamesView(JackboxPack pack)
    {
        CreateView(new GamesViewModel(pack), view =>
        {
            view.Back.Subscribe(_ => ActiveView = PreviousView);
        });
    }

    private void CreatePackagesView(JackboxGame game)
    {
        CreateView(new PackagesViewModel(game), view =>
        {
            view.Back.Subscribe(_ => ActiveView = PreviousView);
        });
    }

    private void CreateView<T>(T view, Action<T> exit) where T : ViewModelBase
    {
        if (ActiveView is T)
            return;

        exit.Invoke(view);

        if (ActiveView is not SettingsViewModel && ActiveView is not ImportViewModel)
            PreviousView = ActiveView;
        ActiveView = view;
    }
}
