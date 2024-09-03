using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies.TemperaturePolicies;

internal class HighTemperaturePolicy : ITravelerItemPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData)
        => [
            new("Hat",1),
            new("Sunglasses",1),
            new("Cream with UV filter",1)
            ];

    public bool IsApplicable(PolicyData policyData)
        => policyData.Temperature > 25D;
}
