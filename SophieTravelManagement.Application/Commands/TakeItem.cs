using SophieTravelManagement.Shared.Abstraction.Commands;

namespace SophieTravelManagement.Application.Commands;

public record TakeItem(Guid travlerCheckListId,string Name) : ICommand
{
}
