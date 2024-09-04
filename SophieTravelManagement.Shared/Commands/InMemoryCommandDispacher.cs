using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Shared.Commands;

public class InMemoryCommandDispacher : ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryCommandDispacher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    async Task ICommandDispatcher.DispatchAsync<TCommand>(TCommand command)
    {
        using var scope = _serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();
        
        await handler.HandleAsync(command);
    }
}
