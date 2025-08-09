namespace Playnite.FullscreenApp.Windows
{
    public class SoftwareToolsMenuWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new SoftwareToolsMenuWindow();
        }
    }

    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class SoftwareToolsMenuWindow : WindowBase
    {
        public SoftwareToolsMenuWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
