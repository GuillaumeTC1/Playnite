using Playnite.FullscreenApp.Controls;
using System;
using System.Linq;

namespace Playnite.FullscreenApp.Windows
{
    public class ExtensionsMenuWindowFactory : WindowFactory
    {
        public override WindowBase CreateNewWindowInstance()
        {
            return new ExtensionsMenuWindow();
        }
    }

    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class ExtensionsMenuWindow : WindowBase
    {
        private object lastUpdatedSource = null;

        public ExtensionsMenuWindow() : base()
        {
            InitializeComponent();
            WindowTools.ConfigureChildWindow(this);
        }

        // This is practically the only place where we can refocus new items
        // afters virtualized panel finished making new buttons after items list change.
        private void PART_ItemsHost_LayoutUpdated(object sender, EventArgs e)
        {
            if (lastUpdatedSource == PART_ItemsHost.ItemsSource)
                return;

            lastUpdatedSource = PART_ItemsHost.ItemsSource;
            var button = ElementTreeHelper.FindVisualChildren<ButtonEx>(PART_ItemsHost).FirstOrDefault();
            if (button != null && !button.IsFocused)
                button.Focus();
        }
    }
}
