using Playnite.DesktopApp.ViewModels;
using System.Windows.Controls;

namespace Playnite.DesktopApp.Controls
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
