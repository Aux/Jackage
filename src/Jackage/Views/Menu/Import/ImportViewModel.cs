using ReactiveUI;
using System.Reactive;

namespace Jackage.Views;

public class ImportViewModel : ViewModelBase
{
    public string Title => "Import a Package";
    public string Description => "";

    public ReactiveCommand<Unit, Unit> Cancel { get; }

    public ImportViewModel()
    {
        Cancel = ReactiveCommand.Create(() => { });
    }
}
