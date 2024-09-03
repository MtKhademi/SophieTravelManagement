using SophieTravelManagement.Application.Dtos;
using SophieTravelManagement.Application.Queries;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Shared.Abstraction.Quesries;

namespace SophieTravelManagement.Infrastructure.EF.Queries.Handlers;

public class GetTravelerCheckListHandler(ITravelerCheckListRepository repository) : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
{
    public async Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
    {
        var travelerCheckList = await repository.GetAsync(query.Id);
        return null;
    }
}
