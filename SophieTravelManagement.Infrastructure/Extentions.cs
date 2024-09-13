using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Application.Services;
using SophieTravelManagement.Infrastructure.EF;
using SophieTravelManagement.Infrastructure.Logging;
using SophieTravelManagement.Infrastructure.Services;
using SophieTravelManagement.Shared.Abstraction.Commands;
using SophieTravelManagement.Shared.Queries;

namespace SophieTravelManagement.Infrastructure;

public static class Extentions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSQL(configuration);
        services.AddQueries();
        services.AddSingleton<IWeatherService, DumbWeatherService>();

        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

        return services;
    }
}
