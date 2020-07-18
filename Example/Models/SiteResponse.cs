namespace Example.Models
{
    public class SiteResponse
    {
        public decimal SiteArea { get; set; }

        public decimal SitePerimeter { get; set; }

        public ISiteConfigurationResponse SiteConfigurationResponse { get; set; }
    }

    public interface ISiteConfigurationResponse
    {
    }
}