using System.Threading.Tasks;
using Example.Models;

namespace Example.Calculators
{
    public class ApartmentCalculator : IBuildingCalculator
    {
        public bool CanCalculate(ISiteConfiguration siteConfiguration)
        {
            return siteConfiguration is ApartmentConfiguration;
        }

        public async Task<SiteResponse> Calculate(SiteRequest request)
        {
            var response = new SiteResponse
            {
                SiteArea = SimpleCalculator.Area(request.Width, request.Length),
                SitePerimeter = SimpleCalculator.Perimeter(request.Width, request.Length)
            };

            if (request.SiteConfiguration is ApartmentConfiguration apartmentConfiguration)
            {
                var buildingFootprint =
                    SimpleCalculator.BuildingFootprint(response.SiteArea, apartmentConfiguration.SiteCoverage);
                var buildingGFA = SimpleCalculator.BuildingGFA(buildingFootprint, apartmentConfiguration.NumberOfStoreys);
                var numberOfApartments = SimpleCalculator.NumberOfApartments(buildingGFA, apartmentConfiguration.AverageApartmentArea);
            
                response.SiteConfigurationResponse = new ApartmentResponse
                {
                    BuildingFootprint = buildingFootprint,
                    BuildingGFA = buildingGFA,
                    NumberOfApartments = numberOfApartments
                };
            }

            return await Task.FromResult(response);
        }
    }
}