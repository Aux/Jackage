using Jackage.Jackbox;
using ReactiveUI;
using System.IO;
using System.Reactive;

namespace Jackage.Views;

public class GamesViewModel : ViewModelBase
{
    public string Title => $"The Jackbox Party Pack {Pack.Id}";
    public string Description => "Select a game in this pack you'd like to customize.";

    public JackboxPack Pack { get; }

    public ReactiveCommand<Unit, Unit> Back { get; }

    public GamesViewModel(JackboxPack pack)
    {
        Pack = pack;
        foreach (var game in Pack.Games)
        {
            game.PackId = Pack.Id;
            game.InstallPath = Path.Combine(Pack.InstallPath, "games", game.Id);
        }

        Back = ReactiveCommand.Create(() => { });
    }
}
