using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Application.Exceptions;

internal class TravelerCheckListAlreadyExistException : TravelerCheckListException
{
    public TravelerCheckListAlreadyExistException(string name) : base
        ($"already exist another traveler check list with name : {name}")
    {
    }
}
