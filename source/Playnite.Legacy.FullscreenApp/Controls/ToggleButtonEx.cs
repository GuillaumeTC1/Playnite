using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Playnite.FullscreenApp.Controls
{
    public class ToggleButtonEx : ToggleButton
    {
        static ToggleButtonEx()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToggleButtonEx), new FrameworkPropertyMetadata(typeof(ToggleButtonEx)));
        }

        public ToggleButtonEx() : base()
        {
            KeyDown += Ex_KeyDown;
        }

        private void Ex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e is GameControllerInputEventArgs controllerInput)
            {
                if (controllerInput.Button == GameControllerGesture.ConfirmationBinding)
                {
                    OnClick();
                    e.Handled = true;
                }
            }
        }
    }
}
