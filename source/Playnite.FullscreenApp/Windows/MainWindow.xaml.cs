namespace Playnite.FullscreenApp.Windows
{

    public class MainWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new MainWindow();
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowBase
    {
        public MainWindow() : base()
        {
            InitializeComponent();
        }
    }
}
