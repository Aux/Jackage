using Avalonia.Markup.Xaml;

namespace Jackage.Views.Library;
public partial class LibraryControl : BaseControl<LibraryModel>
{
    public LibraryControl()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
