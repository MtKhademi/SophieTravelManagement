using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Application.Exceptions;

public sealed class TravelerCheckListNotFoundException : TravelerCheckListException
{
    public Guid Id { get; }
    public TravelerCheckListNotFoundException(Guid id) :
        base($"Traveler check list with id '{id}' not found") => Id = id;
}
