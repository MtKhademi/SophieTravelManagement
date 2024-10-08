﻿using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Domain.Factories;
using SophieTravelManagement.Domain.Policies;
using SophieTravelManagement.Shared.Commands;

namespace SophieTravelManagement.Application;

public static class Extentions
{
    public static IServiceCollection AddApplicatino(this IServiceCollection services)
    {
        services.AddCommands();

        services.AddSingleton<ITravelerCheckListFactory, TravelerCheckListFactory>();

        services.Scan(b => b.FromAssemblies(typeof(ITravelerItemPolicy).Assembly)
        .AddClasses(c => c.AssignableTo<ITravelerItemPolicy>())
        .AsImplementedInterfaces()
        .WithScopedLifetime());

        return services;
    }
}
