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
        throw new NotImplementedException();
    }

    public void Configure(EntityTypeBuilder<TravelerCheckList> builder)
    {
        builder.HasKey(pl => pl.Id);

        var destinationConvertor = new ValueConverter<Destination, string>(l => l.ToString(),
            l => Destination.Create(l));

        var packingListNameConvertor = new ValueConverter<TravelerCheckListName, string>(
            p => p.ToString(), p => new TravelerCheckListName(p));

        builder.
    }
}
