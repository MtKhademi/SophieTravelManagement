namespace SophieTravelManagement.Infrastructure.EF.Models;

public class DestinationReadModel
{
    public string City { get; set; }
    public string Country { get; set; }

    public static DestinationReadModel Create(string value)
    {
        var splutLocalization = value.Split(',');
        return new DestinationReadModel { City = splutLocalization.First(), Country = splutLocalization.Last() };
    }

    public override string ToString() => $"{City} {Country}";

}
