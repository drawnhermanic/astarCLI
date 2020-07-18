namespace Example.Models
{
    public interface IApartmentConfiguration : ISiteConfiguration
    {
        int AverageApartmentArea { get; set; }
    }

    public class ApartmentConfiguration : SiteConfiguration, IApartmentConfiguration
    {
        public int AverageApartmentArea { get; set; }
    }
}