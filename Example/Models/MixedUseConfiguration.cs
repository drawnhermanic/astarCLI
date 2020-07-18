namespace Example.Models
{
    public interface IMixedUseConfiguration : IApartmentConfiguration, ICommercialConfiguration
    {
        int ResidentialMix { get; set; }
    }

    public class MixedUseConfiguration : SiteConfiguration , IMixedUseConfiguration
    {
        public int AverageApartmentArea { get; set; }
        public int CommercialMix { get; set; }
        public int RetailMix { get; set; }
        public int ResidentialMix { get; set; }
    }
}