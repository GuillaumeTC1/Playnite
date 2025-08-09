using Playnite.App;
using Playnite.Common;
using Playnite.Settings;
using System.Collections.Generic;
using System.IO;

namespace Playnite
{
    public class CefTools
    {
        public static bool IsInitialized { get; private set; }

        public static void ConfigureCef(bool enableLogs)
        {
            throw new System.NotImplementedException("CefTools.ConfigureCef is not implemented in Playnite 10. Use CefTools.Initialize instead.");
            //FileSystem.CreateDirectory(PlaynitePaths.BrowserCachePath);
            //var settings = new CefSettings();
            //settings.WindowlessRenderingEnabled = true;

            //if (settings.CefCommandLineArgs.ContainsKey("disable-gpu"))
            //{
            //    settings.CefCommandLineArgs.Remove("disable-gpu");
            //}

            //if (settings.CefCommandLineArgs.ContainsKey("disable-gpu-compositing"))
            //{
            //    settings.CefCommandLineArgs.Remove("disable-gpu-compositing");
            //}

            //settings.CefCommandLineArgs.Add("disable-gpu", "1");
            //settings.CefCommandLineArgs.Add("disable-gpu-compositing", "1");

            //settings.CachePath = PlaynitePaths.BrowserCachePath;
            //settings.PersistSessionCookies = true;
            //settings.LogFile = Path.Combine(PlaynitePaths.ConfigRootPath, "cef.log");
            //settings.LogSeverity = enableLogs ? LogSeverity.Error : LogSeverity.Disable;
            //// Firefox user agent gives the best compatibility because some websites complain
            //// about unsecure browser if we try to pretend to be Chrome (which is CefSharp's default).
            //// Plugins can change this on an individual level anyways.
            //settings.Headers["User-Agent"].ToString() = $"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:139.0) Gecko/20100101 Firefox/139.0 Playnite/{PlayniteApplication.CurrentVersion.ToString(2)}";
            //IsInitialized = Cef.Initialize(settings);
        }

        public static void Shutdown()
        {
            throw new System.NotImplementedException("CefTools.Shutdown is not implemented in Playnite 10. Use CefTools.Dispose instead.");
            //Cef.Shutdown();
            //IsInitialized = false;
        }
    }
}
