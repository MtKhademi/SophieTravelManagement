using SophieTravelManagement.Application.Exceptions;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands.Handlers;

public sealed class RemoveTravelerCheckListHandler(ITravelerCheckListRepository repository) : ICommandHandler<RemoveTravelerCheckList>
{
    public async Task HandleAsync(RemoveTravelerCheckList command)
    {
        var travelerCheckList = await repository.GetAsync(command.id);

        if (travelerCheckList is null)
            throw new TravelerCheckListNotFoundException(command.id);

        await repository.DeleteAsync(travelerCheckList);
    }
}
