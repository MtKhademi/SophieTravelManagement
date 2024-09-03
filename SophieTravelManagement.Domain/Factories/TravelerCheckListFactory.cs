using SophieTravelManagement.Domain.Consts;
using SophieTravelManagement.Domain.Entities;
using SophieTravelManagement.Domain.Policies;
using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Domain.Factories;

internal class TravelerCheckListFactory : ITravelerCheckListFactory
{

    private readonly IEnumerable<ITravelerItemPolicy> _policies;

    public TravelerCheckListFactory(IEnumerable<ITravelerItemPolicy> policies)
        => _policies = policies;



    public TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
        => new(id, name, destination);

    public TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, Destination destination, TravelDays days, Gender gender, Temperature temperature)
    {
        var policyData = new PolicyData(days, gender, temperature, destination);
        var applicationPolicies = _policies.Where(p => p.IsApplicable(policyData));

        var items = applicationPolicies.SelectMany(p => p.GenerateItems(policyData)).ToList();
        var travelerCheckingList = Create(id, name, destination);

        travelerCheckingList.AddItems(items);

        return travelerCheckingList;
    }
}
