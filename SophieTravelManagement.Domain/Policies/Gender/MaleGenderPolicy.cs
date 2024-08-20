using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies.Gender;

internal class MaleGenderPolicy : ITravelerItemPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData)
        => [
            new("laptop",1),
            new("Drink",2),
            new("Book",3),
            ];

    public bool IsApplicable(PolicyData policyData)
        => policyData.Gender is Consts.Gender.Male;
}
