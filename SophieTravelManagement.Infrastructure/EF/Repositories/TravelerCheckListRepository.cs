using Microsoft.EntityFrameworkCore;
using SophieTravelManagement.Domain.Entities;
using SophieTravelManagement.Domain.Repositories;
using SophieTravelManagement.Domain.ValueObjects;
using SophieTravelManagement.Infrastructure.EF.Contexts;

namespace SophieTravelManagement.Infrastructure.EF.Repositories;

internal class TravelerCheckListRepository : ITravelerCheckListRepository
{
    private readonly DbSet<TravelerCheckList> _travelerCheckList;
    private readonly WriteDbContext _writeDbContext;

    public TravelerCheckListRepository(WriteDbContext writeDbContext)
    {
        _writeDbContext = writeDbContext;
        _travelerCheckList = writeDbContext.TravelerCheckLists;
    }

    public async Task AddAsync(TravelerCheckList travelerCheckList)
    {
        _travelerCheckList.Add(travelerCheckList);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(TravelerCheckList travelerCheckList)
    {
        _travelerCheckList.Remove(travelerCheckList);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task<TravelerCheckList> GetAsync(TravelerCheckListId id)
        => await _travelerCheckList.Include("_items").SingleOrDefaultAsync(p => p.Id == id);

    public async Task UpdateAsync(TravelerCheckList travelerCheckList)
    {
        _travelerCheckList.Update(travelerCheckList);
        await _writeDbContext.SaveChangesAsync();
    }
}
