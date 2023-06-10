using Avalonia.Markup.Xaml;

namespace Jackage.Views;

public partial class JackboxControl : BaseControl<JackboxModel>
{
    public JackboxControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
