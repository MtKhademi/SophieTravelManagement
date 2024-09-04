using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SophieTravelManagement.Domain.Entities;
using SophieTravelManagement.Domain.ValueObjects;

namespace SophieTravelManagement.Infrastructure.EF.Config;

internal class WriteConfiguration : IEntityTypeConfiguration<TravelerCheckList>,
    IEntityTypeConfiguration<TravelerItem>
{
    public void Configure(EntityTypeBuilder<TravelerItem> builder)
    {
        builder.Property<Guid>("Id");
        builder.Property(p => p.Name);
        builder.Property(p => p.Quantity);
        builder.Property(p => p.IsTaken);
        builder.ToTable("TravelerItems");
    }

    public void Configure(EntityTypeBuilder<TravelerCheckList> builder)
    {
        builder.HasKey(pl => pl.Id);

        var destinationConvertor = new ValueConverter<Destination, string>(l => l.ToString(),
            l => Destination.Create(l));

        var packingListNameConvertor = new ValueConverter<TravelerCheckListName, string>(
            p => p.ToString(), p => new TravelerCheckListName(p));

        builder.Property(p => p.Id)
            .HasConversion(id => id.Value, id => new TravelerCheckListId(id));

        builder.Property(typeof(Destination),"_destination")
            .HasConversion(destinationConvertor)
            .HasColumnName("Destination");

        builder.Property(typeof(TravelerCheckListName), "_name")
            .HasConversion(packingListNameConvertor)
            .HasColumnName("Name");

        builder.HasMany(typeof(TravelerItem), "_items");

        builder.ToTable("TravelerCheckList");
    }
}
