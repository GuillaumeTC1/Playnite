using System.Collections.Generic;

namespace Playnite.Legacy.FullscreenApp.ViewModels
{
    public class GameStatusViewModel : ObservableObject
    {
        private string gameStatusText;
        public string GameStatusText
        {
            get => gameStatusText;
            set
            {
                gameStatusText = value;
                OnPropertyChanged();
            }
        }

        public GamesCollectionViewEntry Game { get; }

        public GameStatusViewModel(GamesCollectionViewEntry game)
        {
            Game = game;
        }
    }
}
