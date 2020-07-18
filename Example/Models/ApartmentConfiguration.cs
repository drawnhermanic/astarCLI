using Newtonsoft.Json;

namespace Example.Models
{
    public interface IApartmentConfiguration : ISiteConfiguration
    {
        decimal AverageApartmentArea { get; set; }
    }

    public class ApartmentConfiguration : IApartmentConfiguration
    {
        public int NumberOfStoreys { get; set; }
        public decimal SiteCoverage { get; set; }
        public DevelopmentType DevelopmentType { get; } = DevelopmentType.Apartment;
        [JsonProperty("avg_apt_area")]
        public decimal AverageApartmentArea { get; set; }
    }

}