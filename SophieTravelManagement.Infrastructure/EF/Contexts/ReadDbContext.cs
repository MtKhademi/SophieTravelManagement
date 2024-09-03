using Microsoft.EntityFrameworkCore;
using SophieTravelManagement.Infrastructure.EF.Config;
using SophieTravelManagement.Infrastructure.EF.Models;

namespace SophieTravelManagement.Infrastructure.EF.Contexts;

internal class ReadDbContext : DbContext
{

    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
    {

    }

    public DbSet<TravelerCheckListReadModel> TravelerCheckList { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TravelerCheckList");

        var configuration = new ReadConfiguration();
        modelBuilder.ApplyConfiguration<TravelerCheckListReadModel>(configuration);
        modelBuilder.ApplyConfiguration<TravelerItemReadModel>(configuration);
    }
}
