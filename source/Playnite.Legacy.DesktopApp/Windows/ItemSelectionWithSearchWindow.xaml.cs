namespace Playnite.Legacy.DesktopApp.Windows
{
    public class ItemSelectionWithSearchWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new ItemSelectionWithSearchWindow();
        }
    }

    /// <summary>
    /// Interaction logic for MetadataLookupWindow.xaml
    /// </summary>
    public partial class ItemSelectionWithSearchWindow : WindowBase
    {
        public ItemSelectionWithSearchWindow() : base()
        {
            InitializeComponent();
            Loaded += (_, __) => TextSearch.Focus();
        }
    }
}
