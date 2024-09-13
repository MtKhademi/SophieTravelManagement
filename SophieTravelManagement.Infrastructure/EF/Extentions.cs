using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Application.Services;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Infrastructure.EF.Contexts;
using SophieTravelManagement.Infrastructure.EF.Options;
using SophieTravelManagement.Infrastructure.EF.Repositories;
using SophieTravelManagement.Infrastructure.EF.Services;
using SophieTravelManagement.Shared.Options;

namespace SophieTravelManagement.Infrastructure.EF;

public static class Extentions
{
    public static IServiceCollection AddSQL(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<ITravelerCheckListRepository, TravelerCheckListRepository>();
        services.AddScoped<ITravelerCheckListReadService, TravelerCheckListReadService>();

        var options = configuration.GetOptions<DatabaseOptions>("DatabaseConnectionString");

        services.AddDbContext<ReadDbContext>(cfg => cfg.UseSqlServer(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(cfg => cfg.UseSqlServer(options.ConnectionString));

        return services;
    }
}
