using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Playnite.FullscreenApp.Controls
{
    public class CheckBoxEx : CheckBox
    {
        static CheckBoxEx()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBoxEx), new FrameworkPropertyMetadata(typeof(CheckBoxEx)));
        }

        public CheckBoxEx() : base()
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
            else if (e.Key == Key.Enter)
            {
                OnClick();
                e.Handled = true;
            }
        }
    }
}
