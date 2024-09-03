using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands;

public record AddTravelerItem(Guid travelerCheckListId,string Name,uint Quantity) : ICommand
{
}
