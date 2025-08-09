using System.ComponentModel;

namespace Playnite.SDK
{
    /// <summary>
    /// Represents Playnite's application mode.
    /// </summary>
    public enum ApplicationMode
    {
        /// <summary>
        /// Desktop application mode.
        /// </summary>
        [Description("Desktop")]
        Desktop,

        /// <summary>
        /// Fullscreen application mode.
        /// </summary>
        [Description("Fullscreen")]
        Fullscreen
    }
}
