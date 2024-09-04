using Microsoft.EntityFrameworkCore;
using SophieTravelManagement.Application.Dtos;
using SophieTravelManagement.Application.Queries;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Infrastructure.EF.Contexts;
using SophieTravelManagement.Shared.Abstraction.Quesries;

namespace SophieTravelManagement.Infrastructure.EF.Queries.Handlers;

internal class GetTravelerCheckListHandler(ReadDbContext readDbContext) : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
{
    public async Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
        => await readDbContext.TravelerCheckList
        .Include(p => p.Items)
        .Where(p => p.Id == query.Id)
        .Select(p => p.AsDto())
        .AsNoTracking()
        .SingleOrDefaultAsync();
}
