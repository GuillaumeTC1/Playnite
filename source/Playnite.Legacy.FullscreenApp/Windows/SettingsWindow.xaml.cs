namespace Playnite.Legacy.FullscreenApp.Windows
{
    public class SettingsWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new SettingsWindow();
        }
    }

    /// <summary>
    /// Interaction logic for ProgressWindow.xaml
    /// </summary>
    public partial class SettingsWindow : WindowBase
    {
        public SettingsWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
