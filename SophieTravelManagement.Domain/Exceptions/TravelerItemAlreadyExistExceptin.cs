using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Domain.Exceptions;

public class TravelerItemAlreadyExistExceptin : TravelerCheckListException
{
    public TravelerItemAlreadyExistExceptin(string checkListName, string checkListItemName) : base($"this item already exist : {checkListName} => {checkListItemName}")
    {
    }
}
