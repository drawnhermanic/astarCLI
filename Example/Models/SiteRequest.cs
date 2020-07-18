using Newtonsoft.Json;

namespace Example.Models
{
    public class SiteRequest
    {
        [JsonProperty("width")]
        public decimal Width { get; set; }
        [JsonProperty("length")] 
        public decimal Length { get; set; }

        [JsonProperty("site_config")] 
        public ISiteConfiguration SiteConfiguration { get; set; }
    }
}