using Playnite.Legacy.App;
using Playnite.Legacy.Settings;
using Playnite.SDK;

namespace Playnite.Legacy.API
{
    public class PlayniteInfoAPI : IPlayniteInfoAPI
    {
        public System.Version ApplicationVersion { get => Updater.CurrentVersion; }

        public ApplicationMode Mode => PlayniteApplication.Current.Mode;

        public bool IsPortable => PlayniteSettings.IsPortable;

        public bool InOfflineMode => PlayniteEnvironment.InOfflineMode;

        public bool IsDebugBuild => PlayniteEnvironment.IsDebugBuild;

        public bool ThrowAllErrors => PlayniteEnvironment.ThrowAllErrors;
    }
}
