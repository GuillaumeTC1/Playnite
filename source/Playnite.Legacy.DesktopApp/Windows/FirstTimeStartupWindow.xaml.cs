namespace Playnite.Legacy.DesktopApp.Windows
{
    public class FirstTimeStartupWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new FirstTimeStartupWindow();
        }
    }

    /// <summary>
    /// Interaction logic for FirstTimeStartupWindow.xaml
    /// </summary>
    public partial class FirstTimeStartupWindow : WindowBase
    {
        public FirstTimeStartupWindow() : base()
        {
            InitializeComponent();
        }

        private void ButtonFinish_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (ButtonFinish.IsVisible)
            {
                ButtonFinish.Focus();
            }
        }
    }
}
