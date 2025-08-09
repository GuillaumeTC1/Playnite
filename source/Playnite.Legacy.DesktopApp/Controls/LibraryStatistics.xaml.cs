using Playnite.Legacy.DesktopApp.ViewModels;
using System.Windows.Controls;

namespace Playnite.Legacy.DesktopApp.Controls
{
    /// <summary>
    /// Interaction logic for LibraryStatistics.xaml
    /// </summary>
    public partial class LibraryStatistics : UserControl
    {
        public LibraryStatistics()
        {
            InitializeComponent();
        }

        public LibraryStatistics(StatisticsViewModel model)
        {
            DataContext = model;
            InitializeComponent();
        }
    }
}
