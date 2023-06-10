using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Reactive.Disposables;

namespace Jackage.Views;

public class BaseWindow<TViewModel> : ReactiveWindow<TViewModel>
        where TViewModel : class
{
    public BaseWindow(bool activate = true)
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
