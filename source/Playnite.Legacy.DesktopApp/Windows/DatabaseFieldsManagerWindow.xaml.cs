namespace Playnite.Legacy.DesktopApp.Windows
{
    public class DatabaseFieldsManagerWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new DatabaseFieldsManagerWindow();
        }
    }

    public partial class DatabaseFieldsManagerWindow : WindowBase
    {
        public DatabaseFieldsManagerWindow() : base("DatabaseFieldsManagerWindow_V2")
        {
            InitializeComponent();
        }
    }
}
