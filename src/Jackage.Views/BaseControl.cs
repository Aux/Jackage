using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Reactive.Disposables;

namespace Jackage.Views;

public class BaseControl<TViewModel> : ReactiveUserControl<TViewModel>
        where TViewModel : class
{
    public BaseControl(bool activate = true)
    {
        if (activate)
        {
            this.WhenActivated(disposables =>
            {
                Disposable.Create(() => { }).DisposeWith(disposables);
            });
        }
    }
}
