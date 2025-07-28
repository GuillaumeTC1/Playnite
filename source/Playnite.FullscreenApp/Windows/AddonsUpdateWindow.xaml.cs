namespace Playnite.FullscreenApp.Windows
{
    public class AddonsUpdateWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new AddonsUpdateWindow();
        }
    }

    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class AddonsUpdateWindow : WindowBase
    {
        public AddonsUpdateWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
