using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SophieTravelManagement.Infrastructure.EF.Models;

namespace SophieTravelManagement.Infrastructure.EF.Config;

internal class ReadConfiguration : IEntityTypeConfiguration<TravelerCheckListReadModel>,
    IEntityTypeConfiguration<TravelerItemReadModel>
{
    public void Configure(EntityTypeBuilder<TravelerCheckListReadModel> builder)
    {
        builder.ToTable("TravelerCheckList");
        builder.HasKey(x => x.Id);

        builder.Property(pl => pl.Destination)
            .HasConversion(d => d.ToString(), d => DestinationReadModel.Create(d));

        builder.HasMany(pl => pl.Items)
            .WithOne(pi => pi.TravelerCheckList);
    }

    public void Configure(EntityTypeBuilder<TravelerItemReadModel> builder)
    {
        builder.ToTable("TravelerItems");
    }
}
