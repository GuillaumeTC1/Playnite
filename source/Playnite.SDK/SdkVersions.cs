namespace Playnite.SDK
{
    /// <summary>
    /// Represents SDK version properties.
    /// </summary>
    public static class SdkVersions
    {
        /// <summary>
        /// Gets SDK version.
        /// </summary>
        public static Version SDKVersion
        {
            get => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
