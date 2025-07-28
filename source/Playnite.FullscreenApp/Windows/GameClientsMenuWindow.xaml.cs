namespace Playnite.FullscreenApp.Windows
{
    public class GameClientsMenuWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new GameClientsMenuWindow();
        }
    }

    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class GameClientsMenuWindow : WindowBase
    {
        public GameClientsMenuWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
