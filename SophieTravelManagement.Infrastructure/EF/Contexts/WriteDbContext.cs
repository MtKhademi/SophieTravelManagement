using Microsoft.EntityFrameworkCore;
using SophieTravelManagement.Domain.Entities;
using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Infrastructure.EF.Contexts;

internal class WriteDbContext : DbContext
{
    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {
    }

    public DbSet<TravelerCheckList> TravelerCheckLists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TravelerCheckList");

        var config = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<TravelerCheckList>(config);
        modelBuilder.ApplyConfiguration<TravelerItem>(config);
    }
}
