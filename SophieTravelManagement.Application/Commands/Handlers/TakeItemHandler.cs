using SophieTravelManagement.Application.Exceptions;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands.Handlers;

public sealed class TakeItemHandler(ITravelerCheckListRepository repository) : ICommandHandler<TakeItem>
{
    public async Task HandleAsync(TakeItem command)
    {
        var travelerCheckList = await repository.GetAsync(command.travlerCheckListId);
        if (travelerCheckList == null)
            throw new TravelerCheckListNotFoundException(command.travlerCheckListId);

        travelerCheckList.TakeItem(command.Name);

        await repository.UpdateAsync(travelerCheckList);
    }
}
