using Microsoft.EntityFrameworkCore;
using SophieTravelManagement.Application.Services;
using SophieTravelManagement.Infrastructure.EF.Contexts;

namespace SophieTravelManagement.Infrastructure.EF.Services;

internal class TravelerCheckListReadService : ITravelerCheckListReadService
{
    private readonly ReadDbContext _readDbContext;

    public TravelerCheckListReadService(ReadDbContext readDbContext)
    {
        _readDbContext = readDbContext;
    }

    public async Task<bool> ExistByNameAsync(string name)
        => await _readDbContext.TravelerCheckList.AnyAsync(t => t.Name == name);
}
