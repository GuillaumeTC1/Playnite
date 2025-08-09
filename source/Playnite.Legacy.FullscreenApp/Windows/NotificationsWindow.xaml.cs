namespace Playnite.Legacy.FullscreenApp.Windows
{
    public class NotificationsWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new NotificationsWindow();
        }
    }

    /// <summary>
    /// Interaction logic for NotificationsWindow.xaml
    /// </summary>
    public partial class NotificationsWindow : WindowBase
    {
        public NotificationsWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
