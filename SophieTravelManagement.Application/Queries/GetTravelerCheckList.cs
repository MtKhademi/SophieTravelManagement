using SophieTravelManagement.Application.Dtos;
using SophieTravelManagement.Shared.Abstraction.Quesries;

namespace SophieTravelManagement.Application.Queries;

public class GetTravelerCheckList : IQuery<TravelerCheckListDto>
{
    public Guid Id { get; set; }
}
