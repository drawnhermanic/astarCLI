namespace Example.Models
{
    public interface ICommercialConfiguration : ISiteConfiguration
    {
        int CommercialMix { get; set; }
        int RetailMix { get; set; }
    }

    public class CommercialConfiguration : SiteConfiguration, ICommercialConfiguration
    {
        public int CommercialMix { get; set; }
        public int RetailMix { get; set; }
    }
}