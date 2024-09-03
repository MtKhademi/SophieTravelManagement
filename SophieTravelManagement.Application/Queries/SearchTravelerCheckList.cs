using SophieTravelManagement.Application.Dtos;
using SophieTravelManagement.Shared.Abstraction.Quesries;

namespace SophieTravelManagement.Application.Queries;

public class SearchTravelerCheckList : IQuery<TravelerCheckListDto>
{
    public string SearchPhrase { get; set; }
}
