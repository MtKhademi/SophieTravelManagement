using Microsoft.Extensions.DependencyInjection;
using SophieTravelManagement.Shared.Abstraction.Quesries;

namespace SophieTravelManagement.Shared.Queries;

internal class InMemoryQueryDispatcher : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryQueryDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task<TResult> QueryAsync<TResult>(IQuery<TResult> query)
    {
        using var scope = _serviceProvider.CreateScope();
        var handleType = typeof(IQueryHandler<,>)
            .MakeGenericType(query.GetType(), typeof(TResult));

        var handler = scope.ServiceProvider.GetRequiredService(handleType);

        return await (Task<TResult>)handleType.GetMethod(
            nameof(IQueryHandler<IQuery<TResult>, TResult>)).Invoke(handler, new[] { query });
    }
}
