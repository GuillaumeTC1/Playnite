namespace Playnite.FullscreenApp.Windows
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class MultiItemSelectionWindow : WindowBase
    {
        public MultiItemSelectionWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }
    }
}
