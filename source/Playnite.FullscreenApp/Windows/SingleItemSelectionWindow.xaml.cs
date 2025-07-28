using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Playnite.FullscreenApp.Windows
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class SingleItemSelectionWindow : WindowBase
    {
        public SingleItemSelectionWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }

        private void PART_ItemsHost_Loaded(object sender, RoutedEventArgs e)
        {
            // Needed because we use virtualized items panel and selected item might not be realized,
            // which would prevent it from getting focus.
            if (PART_ItemsHost.Tag is int selectedItemIndex)
            {
                var itemsPanel = ElementTreeHelper.FindVisualChildren<VirtualizingStackPanel>(PART_ItemsHost).FirstOrDefault();
                itemsPanel?.BringIndexIntoViewPublic(selectedItemIndex);
            }
        }
    }
}
