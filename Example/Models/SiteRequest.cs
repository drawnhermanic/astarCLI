namespace Example.Models
{
    public class SiteRequest
    {
        public decimal Width { get; set; }  
        public decimal Height { get; set; }
        public ISiteConfiguration SiteConfiguration { get; set; }
    }
}