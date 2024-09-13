using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Shared.Services;

namespace SophieTravelManagement.Shared;

public static class Extentions
{
    public static IServiceCollection AddShared(this IServiceCollection services)
    {
        services.AddHostedService<AppInitializer>();
        return services;
    }

    public static IApplicationBuilder UsedShared(this IApplicationBuilder applicationBuilder)
    {
        return applicationBuilder;
    }
}
