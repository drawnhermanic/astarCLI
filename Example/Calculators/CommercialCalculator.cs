using System.Threading.Tasks;
using Example.Models;

namespace Example.Calculators
{
    public class CommercialCalculator : IBuildingCalculator
    {
        public bool CanCalculate(ISiteConfiguration siteConfiguration)
        {
            return siteConfiguration is CommercialConfiguration;
        }

        public async Task<SiteResponse> Calculate(SiteRequest request)
        {
            var response = new SiteResponse
            {
                SiteArea = SimpleCalculator.Area(request.Width, request.Length),
                SitePerimeter = SimpleCalculator.Perimeter(request.Width, request.Length)
            };

            if (request.SiteConfiguration is CommercialConfiguration siteConfiguration)
            {
                var buildingFootprint =
                    SimpleCalculator.BuildingFootprint(response.SiteArea, siteConfiguration.SiteCoverage);
                var buildingGFA = SimpleCalculator.BuildingGFA(buildingFootprint, siteConfiguration.NumberOfStoreys);
                var commercialGFA = SimpleCalculator.CommercialGFA(buildingFootprint, siteConfiguration.CommercialMix);
                var retailGFA = SimpleCalculator.RetailGFA(buildingGFA, siteConfiguration.RetailMix);

                response.SiteConfigurationResponse = new CommercialResponse
                {
                    BuildingFootprint = buildingFootprint,
                    BuildingGFA = buildingGFA,
                    CommercialGFA = commercialGFA,
                    RetailGFA = retailGFA
                };
            }

            return await Task.FromResult(response);
        }
    }
}