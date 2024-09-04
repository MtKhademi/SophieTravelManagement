using SophieTravelManagement.Application.Exceptions;
using SophieTravelManagement.Application.Services;
using SophieTravelManagement.Domain.Factories;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Domain.ValueObjects;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands.Handlers;

internal class CreateTravelerCheckListWithItemsHandler(
    ITravelerCheckListRepository repository,
    ITravelerCheckListFactory factory,
    IWeatherService weatherService,
    ITravelerCheckListReadService travelerCheckListReadService) : ICommandHandler<CreateTravelerCheckListWithItems>
{
    public async Task HandleAsync(CreateTravelerCheckListWithItems command)
    {
        var (id, name, days, gender, destinationWriteModel) = command;


        if (await travelerCheckListReadService.ExistByNameAsync(name))
            throw new TravelerCheckListAlreadyExistException(name);

        var destination = new Destination(destinationWriteModel.City, destinationWriteModel.Country);
        var weather = await weatherService.GetWeatherAsync(destination);

        if (weather is null)
            throw new MissingDestinationWeatherException(destination);

        var travelerCheckList = factory.CreateWithDefaultItems(id, name, destination, days, gender, weather.tempreature);

        await repository.AddAsync(travelerCheckList);
    }
}
