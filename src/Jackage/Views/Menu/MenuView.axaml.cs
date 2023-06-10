using Avalonia;
using Avalonia.Controls;

namespace Jackage.Views;

public partial class MenuView : UserControl
{
    public string Title { get => GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<MenuView, string>(nameof(Title));

    public string Description { get => GetValue(DescriptionProperty); set => SetValue(DescriptionProperty, value); }
    public static readonly StyledProperty<string> DescriptionProperty = AvaloniaProperty.Register<MenuView, string>(nameof(Description));

    public MenuView()
    {
        InitializeComponent();
    }
}
