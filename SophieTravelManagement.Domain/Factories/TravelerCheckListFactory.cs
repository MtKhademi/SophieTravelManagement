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

    public TravelerCheckList CreateWithDefaultItems(TravelerCheckList id, TravelerCheckListName name, Destination destination, TravelDays days, Gender gender, Temperature temperature)
    {
        //var data = new PolicyData(days, gender, temperature, destination);

        return null;
    }
}
