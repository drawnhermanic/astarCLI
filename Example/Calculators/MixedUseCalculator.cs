using System.Threading.Tasks;
using Example.Models;

namespace Example.Calculators
{
    public class MixedUseCalculator : IBuildingCalculator
    {
        public bool CanCalculate(ISiteConfiguration siteConfiguration)
        {
            return siteConfiguration is MixedUseConfiguration;
        }

        public async Task<SiteResponse> Calculate(SiteRequest request)
        {
            var response = new SiteResponse
            {
                SiteArea = SimpleCalculator.Area(request.Width, request.Length),
                SitePerimeter = SimpleCalculator.Perimeter(request.Width, request.Length)
            };

            if (request.SiteConfiguration is MixedUseConfiguration siteConfiguration)
            {
                var buildingFootprint =
                    SimpleCalculator.BuildingFootprint(response.SiteArea, siteConfiguration.SiteCoverage);
                var buildingGFA = SimpleCalculator.BuildingGFA(buildingFootprint, siteConfiguration.NumberOfStoreys);
                var commercialGFA = SimpleCalculator.CommercialGFA(buildingFootprint, siteConfiguration.CommercialMix);
                var retailGFA = SimpleCalculator.RetailGFA(buildingGFA, siteConfiguration.RetailMix);
                var numberOfApartments = SimpleCalculator.NumberOfApartments(buildingGFA, siteConfiguration.AverageApartmentArea);

                response.SiteConfigurationResponse = new MixedUseResponse()
                {
                    BuildingFootprint = buildingFootprint,
                    BuildingGFA = buildingGFA,
                    CommercialGFA = commercialGFA,
                    RetailGFA = retailGFA,
                    NumberOfApartments = numberOfApartments
                };
            }

            return await Task.FromResult(response);
        }
    }
}