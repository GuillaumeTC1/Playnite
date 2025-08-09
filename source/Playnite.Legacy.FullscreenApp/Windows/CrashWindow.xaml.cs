using System.Windows;

namespace Playnite.Legacy.FullscreenApp.Windows
{
    /// <summary>
    /// Interaction logic for CrashWindow.xaml
    /// </summary>
    public partial class CrashWindow : WindowBase
    {
        public CrashWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
            Loaded += CrashWindow_Loaded;
        }

        private void CrashWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ButtonGeneratePackage.Focus();
        }
    }
}
