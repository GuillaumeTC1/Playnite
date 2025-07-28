using System.Windows;

namespace Playnite.FullscreenApp.Windows
{
    public class RandomGameSelectWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new RandomGameSelectWindow();
        }
    }

    /// <summary>
    /// Interaction logic for RandomGameSelectWindow.xaml
    /// </summary>
    public partial class RandomGameSelectWindow : WindowBase
    {
        public RandomGameSelectWindow()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
            Loaded += RandomGameSelectWindow_Loaded;
        }

        private void RandomGameSelectWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ButtonPlay.Focus();
        }
    }
}
