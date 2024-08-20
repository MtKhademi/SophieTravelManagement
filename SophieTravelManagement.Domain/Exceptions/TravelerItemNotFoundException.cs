using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Domain.Exceptions;

public class TravelerItemNotFoundException : TravelerCheckListException
{
    public TravelerItemNotFoundException(string itemName) : base($"Not found this item[{itemName}] in this checkList")
    {
    }
}
