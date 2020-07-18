using Newtonsoft.Json;

namespace Example.Models
{
    public interface ISubDivisionConfiguration : ISiteConfiguration
    {
        decimal AvgLotSize { get; set; }
    }

    public class SubDivisionConfiguration : ISubDivisionConfiguration
    {
        public DevelopmentType DevelopmentType { get; } = DevelopmentType.SubDivision;
        public int NumberOfStoreys { get; set; }
        public decimal SiteCoverage { get; set; }
        [JsonProperty("avg_lot_size")] 
        public decimal AvgLotSize { get; set; }
    }
}