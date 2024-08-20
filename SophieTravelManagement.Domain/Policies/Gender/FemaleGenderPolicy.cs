using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies.Gender;

internal class FemaleGenderPolicy : ITravelerItemPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData)
        => [
            new("Lipstick",1),
            new("Powder",2),
            new("Wyeliner",3),
            ];

    public bool IsApplicable(PolicyData policyData)
        => policyData.Gender is Consts.Gender.Female;
}
