﻿using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Shared.Abstraction.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SophieTravelManagement.Shared.Commands
{
    public static class Extentions
    {
        public static IServiceCollection AddCommands(this IServiceCollection services) {

            var assembly = Assembly.GetCallingAssembly();

            services.AddSingleton<ICommandDispatcher, InMemoryCommandDispacher>();

            services.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return services;
        }
    }
}
