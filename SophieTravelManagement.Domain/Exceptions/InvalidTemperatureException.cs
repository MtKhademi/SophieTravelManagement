using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Domain.Exceptions;

public class InvalidTemperatureException : TravelerCheckListException
{
    public InvalidTemperatureException(double value) : base(
        $"Value '{value}' is invalid temperature")
    {
    }
}
