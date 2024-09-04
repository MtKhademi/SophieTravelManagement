namespace SophieTravelManagement.Shared.Abstraction.Quesries;

public interface IQueryDispatcher
{
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
}
