using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Policies;

public interface ITravelerItemPolicy
{
    bool IsApplicable(PolicyData policyData);
    IEnumerable<TravelerItem> GenerateItems(PolicyData policyData);
}
