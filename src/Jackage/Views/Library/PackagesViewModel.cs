using Jackage.Jackbox;
using ReactiveUI;
using System.Reactive;

namespace Jackage.Views;

public class PackagesViewModel : ViewModelBase
{
    public string Title { get; init; }
    public string Description { get; init; }

    public JackboxGame Game { get; }

    public ReactiveCommand<Unit, Unit> Back { get; }

    public PackagesViewModel(JackboxGame game)
    {
        Game = game;
        Title = Game.Name;

        Back = ReactiveCommand.Create(() => { });
    }
}
