using SophieTravelManagement.Domain.Exceptions;

namespace SophieTravelManagement.Domain.ValueObjects;

public class TravelDays
{
    public ushort Value { get; }
    public TravelDays(ushort value)
    {
        if (value is 0 or > 100)
            throw new InvalidTravelDaysException(value);

        Value = value;
    }

    public static implicit operator TravelDays(ushort value) => new(value);
    public static implicit operator ushort(TravelDays value) => value.Value;

}
