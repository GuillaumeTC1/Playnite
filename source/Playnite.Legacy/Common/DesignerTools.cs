using System.ComponentModel;
using System.Windows;

namespace Playnite.Legacy.Common
{
    public class DesignerTools
    {
        private static bool? inDesignMode = null;

        public static bool IsInDesignMode
        {
            get
            {
                if (inDesignMode == null)
                {
                    inDesignMode = DesignerProperties.GetIsInDesignMode(new DependencyObject());
                }

                return inDesignMode.Value;
            }
        }
    }
}
