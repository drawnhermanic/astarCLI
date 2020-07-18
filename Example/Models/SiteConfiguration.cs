using JsonSubTypes;
using Newtonsoft.Json;

namespace Example.Models
{
    [JsonConverter(typeof(JsonSubtypes), "development_type")]
    [JsonSubtypes.KnownSubType(typeof(ApartmentConfiguration), Models.DevelopmentType.Apartment)]
    [JsonSubtypes.KnownSubType(typeof(CommercialConfiguration), Models.DevelopmentType.Commercial)]
    [JsonSubtypes.KnownSubType(typeof(MixedUseConfiguration), Models.DevelopmentType.Mixed_Use)]
    [JsonSubtypes.KnownSubType(typeof(SubDivisionConfiguration), Models.DevelopmentType.SubDivision)]
    public interface ISiteConfiguration
    {
        [JsonProperty("num_storeys")]
        int NumberOfStoreys { get; set; }
        [JsonProperty("site_coverage")]
        decimal SiteCoverage { get; set; }
        [JsonProperty("development_type")]
        DevelopmentType DevelopmentType { get; }
    }
}
