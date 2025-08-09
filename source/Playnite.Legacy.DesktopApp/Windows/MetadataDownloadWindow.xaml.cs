namespace Playnite.Legacy.DesktopApp.Windows
{
    public class MetadataDownloadWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new MetadataDownloadWindow();
        }
    }

    /// <summary>
    /// Interaction logic for EmulatorImportWindow.xaml
    /// </summary>
    public partial class MetadataDownloadWindow : WindowBase
    {
        public MetadataDownloadWindow() : base(nameof(MetadataDownloadWindow), true)
        {
            InitializeComponent();
        }
    }
}
