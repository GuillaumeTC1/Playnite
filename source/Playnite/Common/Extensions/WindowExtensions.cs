using Playnite.Common;

namespace Playnite.Common.Extensions
{
    public static class WindowExtensions
    {
        public static ComputerScreen GetScreen(this Window window)
        {
            return Screen.FromPoint(new System.Drawing.Point((int)window.Left, (int)window.Top)).ToComputerScreen();
        }
    }
}
