using SophieTravelManagement.Domain.ValueObjects;
using SophieTravelManagement.Shared.Abstraction.Exceptions;
namespace SophieTravelManagement.Application.Exceptions;

public class MissingDestinationWeatherException : TravelerCheckListException
{
    public Destination Destination { get; }
    public MissingDestinationWeatherException(Destination destination) :
        base($"Coudn't fetch weather data for detination '{destination.Country}/{destination.City}")
        => Destination = destination;
}
