namespace Playnite.Legacy.DesktopApp.Windows
{
    public class ToolsConfigWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new ToolsConfigWindow();
        }
    }

    /// <summary>
    /// Interaction logic for ToolsConfigWindow.xaml
    /// </summary>
    public partial class ToolsConfigWindow : WindowBase
    {
        public ToolsConfigWindow() : base(nameof(ToolsConfigWindow), true)
        {
            InitializeComponent();
        }
    }
}
