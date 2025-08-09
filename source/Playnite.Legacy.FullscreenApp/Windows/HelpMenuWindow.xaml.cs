namespace Playnite.Legacy.FullscreenApp.Windows
{
    public class HelpMenuWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new HelpMenuWindow();
        }
    }

    /// <summary>
    /// Interaction logic for HelpMenuWindowMenuWindow.xaml
    /// </summary>
    public partial class HelpMenuWindow : WindowBase
    {
        public HelpMenuWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
