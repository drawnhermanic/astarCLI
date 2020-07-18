namespace Example.Models
{
    public class ApartmentResponse : ISiteConfigurationResponse
    {
        public decimal BuildingFootprint { get; set; }

        public decimal BuildingGFA { get; set; }

        public int? NumberOfApartments { get; set; }
    }
}