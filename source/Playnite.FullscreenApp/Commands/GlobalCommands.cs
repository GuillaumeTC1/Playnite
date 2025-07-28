using Playnite.SDK;
using System.Windows;

namespace Playnite.FullscreenApp.Commands
{
    public class NavigateUrlCommand : RelayCommand<object>
    {
        public NavigateUrlCommand() : base(Navigate)
        {
        }

        public static void Navigate(object link)
        {
            if (FullscreenApplication.Current.Dialogs.ShowMessage(
                string.Format(ResourceProvider.GetString("LOCUrlNavigationMessage"), link.ToString()),
                string.Empty,
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                GlobalCommands.NavigateUrl(link);
            }
        }
    }
}
