namespace Example.Models
{
    public interface ISiteConfiguration
    {
        int NumberOfStoreys { get; set; }
        int SiteCoverage { get; set; }
        DevelopmentType DevelopmentType { get; set; }
    }

    public class SiteConfiguration : ISiteConfiguration
    {
        public int NumberOfStoreys { get; set; }

        public int SiteCoverage { get; set; }

        public DevelopmentType DevelopmentType { get; set; }
    }
}
