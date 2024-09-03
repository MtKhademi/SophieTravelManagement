using SophieTravelManagement.Domain.Consts;
using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands;

public record CreateTravelerCheckListWithItems(
    Guid id,string Name,ushort Days,Gender Gender,DestinationWriteModel destination):ICommand
{
}

public record DestinationWriteModel(string City,string Country);
