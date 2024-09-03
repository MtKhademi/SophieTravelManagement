namespace SophieTravelManagement.Infrastructure.EF.Models;

public class TravelerCheckListReadModel
{
    public Guid Id { get; set; }
    public int Version { get; set; }
    public string Name { get; set; }
    public DestinationReadModel Destination { get; set; }
    public List<TravelerItemReadModel> Items { get; set; }
}
