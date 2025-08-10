using System;

namespace Playnite.Legacy.Settings
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiresRestartAttribute : Attribute
    {
    }
}
