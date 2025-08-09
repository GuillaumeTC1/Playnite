using Microsoft.Extensions.DependencyInjection;

namespace Playnite.UI;

public static class DependencyInjection
{
    public static void AddPlaynite(this IServiceCollection services)
    {
        //services.AddSingleton<IPlayniteAPI, PlayniteAPI>();
    }
}
