using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender,
    Temperature Temperature, Destination Destination);