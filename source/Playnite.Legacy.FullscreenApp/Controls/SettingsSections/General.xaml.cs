using Playnite.FullscreenApp.ViewModels;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Playnite.FullscreenApp.Controls.SettingsSections
{
    /// <summary>
    /// Interaction logic for Visuals.xaml
    /// </summary>
    public partial class General : SettingsSectionControl
    {
        public General()
        {
            InitializeComponent();
        }

        public General(FullscreenAppViewModel mainModel)
        {
            InitializeComponent();

            SelectMonitor.ItemsSource = mainModel.AppSettings.Fullscreen.AvailableScreens;
            SelectMonitor.DisplayMemberPath = nameof(System.Windows.Forms.Screen.DeviceName);
            BindingTools.SetBinding(
                SelectMonitor,
                Selector.SelectedIndexProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.Monitor),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                ToggleBattery,
                ToggleButton.IsCheckedProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.ShowBattery),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                ToggleBatteryPercentage,
                ToggleButton.IsCheckedProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.ShowBatteryPercentage),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                ToggleClock,
                ToggleButton.IsCheckedProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.ShowClock),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                TogglePrimaryDisplayOnly,
                ToggleButton.IsCheckedProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.UsePrimaryDisplay),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                ToggleAsyncImageLoad,
                ToggleButton.IsCheckedProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.AsyncImageLoading),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                ToggleMinimizeAfterGame,
                ToggleButton.IsCheckedProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.MinimizeAfterGameStartup),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);

            BindingTools.SetBinding(
                SelectImageScaler,
                Selector.SelectedValueProperty,
                mainModel.AppSettings.Fullscreen,
                nameof(FullscreenSettings.ImageScalerMode),
                BindingMode.TwoWay,
                UpdateSourceTrigger.PropertyChanged);
            SelectorBehaviors.SetEnumSource(SelectImageScaler, typeof(Playnite.ImageLoadScaling));
        }
    }
}
