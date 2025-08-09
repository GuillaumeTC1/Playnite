using Playnite.SDK;
using Playnite.SDK.Database;
using Playnite.SDK.Models;

namespace Playnite.UI.Services
{
    public class PlayniteStateService
    {
        private readonly IPlayniteAPI _api;
        
        public PlayniteStateService(IPlayniteAPI api)
        {
            _api = api;
        }

        public event EventHandler<GameEventArgs> GameSelected;
        public event EventHandler<ApplicationModeChangedEventArgs> ApplicationModeChanged;

        private ApplicationMode _currentMode;
        public ApplicationMode CurrentMode
        {
            get => _currentMode;
            set
            {
                if (_currentMode != value)
                {
                    var oldMode = _currentMode;
                    _currentMode = value;
                    ApplicationModeChanged?.Invoke(this, new ApplicationModeChangedEventArgs(oldMode, value));
                }
            }
        }

        public async Task<IItemCollection<Game>> GetGamesAsync()
        {
            return await Task.Run(() => _api.Database.Games);
        }

        public void SelectGame(Game game)
        {
            GameSelected?.Invoke(this, new GameEventArgs(game));
        }
    }

    public class GameEventArgs : EventArgs
    {
        public Game Game { get; }

        public GameEventArgs(Game game)
        {
            Game = game;
        }
    }

    public class ApplicationModeChangedEventArgs : EventArgs
    {
        public ApplicationMode OldMode { get; }
        public ApplicationMode NewMode { get; }

        public ApplicationModeChangedEventArgs(ApplicationMode oldMode, ApplicationMode newMode)
        {
            OldMode = oldMode;
            NewMode = newMode;
        }
    }
}
