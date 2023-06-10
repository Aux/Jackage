using ReactiveUI;

namespace Jackage.Views.Application;

public class MainWindowModel
{
    public string WindowTitle { get; set; }

    public MainWindowModel()
    {

    }

    public ViewModelActivator Activator { get; } = new ViewModelActivator();
}
