using Playnite.Legacy.Common.Extensions;
using Playnite.Legacy.Controls;
using System;

namespace Playnite.Legacy.Windows
{
    public class UpdateWindowFactory : WindowFactory
    {
        public static Type WindowType { get; private set; }

        public static void SetWindowType<TType>() where TType : WindowBase
        {
            WindowType = typeof(TType);
        }

        public override WindowBase CreateNewWindowInstance()
        {
            return WindowType.CrateInstance<WindowBase>();
        }
    }
}
