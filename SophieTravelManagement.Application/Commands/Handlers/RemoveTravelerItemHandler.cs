using SophieTravelManagement.Application.Exceptions;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands.Handlers;

internal class RemoveTravelerItemHandler(ITravelerCheckListRepository repository) : ICommandHandler<RemoveTravelerItem>
{
    public async Task HandleAsync(RemoveTravelerItem command)
    {
        var travelerCheckList = await repository.GetAsync(command.travelerCheckListId);
        if (travelerCheckList is null)
            throw new TravelerCheckListNotFoundException(command.travelerCheckListId);

        travelerCheckList.RemoveItem(command.Name);

        await repository.UpdateAsync(travelerCheckList);
    }
}
