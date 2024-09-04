using SophieTravelManagement.Application.Dtos.External;
using SophieTravelManagement.Application.Services;
using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Infrastructure.Services;

internal class DumbWeatherService : IWeatherService
{
    public Task<WeatherDto> GetWeatherAsync(Destination destination)
        => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
}
