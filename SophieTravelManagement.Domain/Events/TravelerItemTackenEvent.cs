using SophieTravelManagement.Domain.Entities;
using SophieTravelManagement.Domain.ValueObjects;
using SophieTravelManagement.Shared.Abstraction.Domain;

namespace SophieTravelManagement.Domain.Events;

public record TravelerItemTackenEvent(
    TravelerCheckList TravelerCheckList,TravelerItem TravelerItem) : IDomainEvent
{
}
