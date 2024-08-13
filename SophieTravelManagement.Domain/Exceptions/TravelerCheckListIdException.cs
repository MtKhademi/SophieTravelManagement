using SophieTravelManagement.Shared.Abstraction.Exceptions;

namespace SophieTravelManagement.Domain.Exceptions
{
    public class TravelerCheckListIdException : TravelerCheckListException
    {
        public TravelerCheckListIdException() : base("Traveler check list can not be empty")
        {

        }
    }
}
