using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands;

public record RemoveTravelerItem(Guid travelerCheckListId, string Name) : ICommand
{
}
