using SophieTravelManagement.Application.Dtos;
using SophieTravelManagement.Infrastructure.EF.Models;

namespace SophieTravelManagement.Infrastructure.EF.Queries;

internal static class Extentions
{
    public static TravelerCheckListDto AsDto(this TravelerCheckListReadModel readModel)
    {
        return new()
        {
            Id = readModel.Id,
            Name = readModel.Name,
            Destination = new DestinationDto
            {
                City = readModel.Destination?.City,
                Country = readModel.Destination?.Country
            },
            Items = readModel.Items.Select(x => new TravelerItemDto
            {
                Name = x.Name,
                IsTaken = x.IsTaken,
                Quantity = x.Quantity,
            }),
        };
    }
}
