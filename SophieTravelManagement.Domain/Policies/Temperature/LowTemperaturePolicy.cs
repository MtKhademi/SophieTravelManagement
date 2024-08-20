using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies.Temperature;

internal class LowTemperaturePolicy : ITravelerItemPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData)
        => [
            new("Winter hat",1),
            new("Scarf",1),
            new("Gloves",1),
            new("Warm jacket",1),
            new("Hoodie",1)
            ];

    public bool IsApplicable(PolicyData policyData)
        => policyData.Temperature < 10D;
}
