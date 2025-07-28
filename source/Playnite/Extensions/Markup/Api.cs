using Playnite.API.DesignData;
using System;
using System.ComponentModel;
using System.Windows;

namespace Playnite.Extensions.Markup
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
