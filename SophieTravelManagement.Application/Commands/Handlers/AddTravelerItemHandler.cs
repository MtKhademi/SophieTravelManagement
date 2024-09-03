using SophieTravelManagement.Application.Exceptions;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Domain.ValueObjects;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands.Handlers;

internal sealed class AddTravelerItemHandler(
    ITravelerCheckListRepository repository) : ICommandHandler<AddTravelerItem>
{

    public async Task HandleAsync(AddTravelerItem command)
    {
        var travelerCheckList = await repository.GetAsync(command.travelerCheckListId);

        if (travelerCheckList is null)
            throw new TravelerCheckListNotFoundException(command.travelerCheckListId);

        var travelerItem = new TravelerItem(command.Name, command.Quantity);
        travelerCheckList.AddItem(travelerItem);

        await repository.UpdateAsync(travelerCheckList);
    }
}
