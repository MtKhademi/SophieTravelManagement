using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies.Universal;

internal class BasicPolicy : ITravelerItemPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData)
        => [
            new("Pants",1),
            new("Socks",2),
            new("T-Shirt",1),
            new("Trousers",policyData.Days<7? 1u:2u),
            new("Shampoo",1),
            new("Toothbrush",1),
            new("Toothpaste",1),
            new("Towel",1),
            ];

    public bool IsApplicable(PolicyData policyData)
        => true;
}
