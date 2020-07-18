using Newtonsoft.Json;

namespace Example.Models
{
    public interface ICommercialConfiguration : ISiteConfiguration
    {
        int CommercialMix { get; set; }
        int RetailMix { get; set; }
    }

    public class CommercialConfiguration : ICommercialConfiguration
    {
        public DevelopmentType DevelopmentType { get; } = DevelopmentType.Commercial;
        public int NumberOfStoreys { get; set; }
        public decimal SiteCoverage { get; set; }
        [JsonProperty("commerical_mix")] 
        public int CommercialMix { get; set; }
        [JsonProperty("retail_mix")] 
        public int RetailMix { get; set; }
    }
}