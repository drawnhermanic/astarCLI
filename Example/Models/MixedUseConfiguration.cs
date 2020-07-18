using Newtonsoft.Json;

namespace Example.Models
{
    public interface IMixedUseConfiguration : IApartmentConfiguration, ICommercialConfiguration
    {
        int ResidentialMix { get; set; }
    }

    public class MixedUseConfiguration : IMixedUseConfiguration
    {
        public DevelopmentType DevelopmentType { get; } = DevelopmentType.Mixed_Use;
        public int NumberOfStoreys { get; set; }
        public decimal SiteCoverage { get; set; }
        [JsonProperty("avg_apt_area")] 
        public decimal AverageApartmentArea { get; set; }
        [JsonProperty("commerical_mix")]
        public int CommercialMix { get; set; }
        [JsonProperty("retail_mix")]
        public int RetailMix { get; set; }
        [JsonProperty("residential_mix")] 
        public int ResidentialMix { get; set; }
    }
}