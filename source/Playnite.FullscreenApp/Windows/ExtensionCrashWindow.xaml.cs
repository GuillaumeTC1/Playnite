using System.Windows;

namespace Playnite.FullscreenApp.Windows
{
    /// <summary>
    /// Interaction logic for CrashWindow.xaml
    /// </summary>
    public partial class ExtensionCrashWindow : WindowBase
    {
        public ExtensionCrashWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
            Loaded += CrashWindow_Loaded;
        }

        private void CrashWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ButtonRestart.Focus();
        }
    }
}
