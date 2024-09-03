using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands;

public record RemoveTravelerCheckList(Guid id) : ICommand
{
}
