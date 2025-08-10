using Playnite.API.DesignData;
using Playnite.Legacy.App;
using Playnite.Legacy.Common.Extensions;
using System.ComponentModel;
using System.Windows;

namespace Playnite.Legacy.Extensions.Markup
{
    public class Api : BindingExtension
    {
        public Api() : this(null)
        {
        }

        public Api(string path) : base(path)
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                Source = new DesignPlayniteAPI();
                PathRoot = null;
            }
            else
            {
                Source = PlayniteApplication.Current;
                PathRoot = nameof(PlayniteApplication.PlayniteApiGlobal);
            }

            if (!path.IsNullOrEmpty())
            {
                PathRoot += ".";
            }
        }
    }
}
