using Playnite.Legacy.App;
using Playnite.Legacy.Plugins;
using System;

namespace Playnite.Legacy.Extensions.Markup
{
    public class PluginStatus : BindingExtension
    {
        public string Status { get; set; }
        public string Plugin { get; set; }

        public PluginStatus() : this(null)
        {
        }

        public PluginStatus(string path) : base(path)
        {
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ServiceProvider.IsTargetTemplate(serviceProvider))
            {
                return this;
            }

            Source = PlayniteApplication.Current;
            Path = $"{nameof(PlayniteApplication.ExtensionsStatusBinder)}[{Plugin}].{nameof(ExtensionsStatusBinder.Status.IsInstalled)}";
            return base.ProvideValue(serviceProvider);
        }
    }
}
