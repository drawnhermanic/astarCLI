namespace Example.Models
{
    public class CommercialResponse : ISiteConfigurationResponse
    {
        public decimal BuildingFootprint { get; set; }

        public decimal BuildingGFA { get; set; }

        public decimal CommercialGFA { get; set; }

        public decimal RetailGFA { get; set; }
    }
}