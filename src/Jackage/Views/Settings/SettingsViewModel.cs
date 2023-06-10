using DynamicData.Binding;
using Jackage.Data;
using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;
using System;

namespace Jackage.Views;

public class SettingsViewModel : ViewModelBase
{
    public const string Title = "Jackage Settings";
    public const string Description = "";

    public JackageOptions Options { get; }

    public ReactiveCommand<Unit, Unit> Apply { get; }
    public ReactiveCommand<Unit, Unit> Exit { get; }

    public bool HasChanges { get; set; } = false;

    public SettingsViewModel()
    {
        this.WhenAnyPropertyChanged().Subscribe(_ => HasChanges = true);

        Apply = ReactiveCommand.Create(WriteChanges);
        Exit = ReactiveCommand.Create(() => { });
    }

    public string backupDir;
    public string BackupDirectory
    {
        get => backupDir;
        set => this.RaiseAndSetIfChanged(ref backupDir, value);
    }

    private Unit WriteChanges()
    {
        return Unit.Default;
    }
}
