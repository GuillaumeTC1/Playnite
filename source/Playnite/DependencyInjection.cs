using Playnite.API;
using Playnite.SDK;

namespace Playnite;

public static class DependencyInjection
{
    public static void AddPlaynite(this IServiceCollection services)
    {
        services.AddSingleton<IPlayniteAPI, PlayniteAPI>();
    }
}
