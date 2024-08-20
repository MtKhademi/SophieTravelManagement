using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Domain.Exceptions;

public class InvalidTravelDaysException : TravelerCheckListException
{
    public InvalidTravelDaysException(ushort days) : base(
        $"Days '{days}' is invalid for travel")
    {
    }
}
