using System;
using System.Windows.Markup;

namespace Playnite.Legacy.Extensions
{
    public class ServiceProvider
    {
        public static bool IsTargetTemplate(IServiceProvider serviceProvider)
        {
            var provider = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            return provider.TargetObject.GetType().FullName == "System.Windows.SharedDp";
        }
    }
}
