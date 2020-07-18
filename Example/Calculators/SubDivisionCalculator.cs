using System.Threading.Tasks;
using Example.Models;

namespace Example.Calculators
{
    public class SubDivisionCalculator : IBuildingCalculator
    {
        public bool CanCalculate(ISiteConfiguration siteConfiguration)
        {
            return siteConfiguration is SubDivisionConfiguration;
        }

        public async Task<SiteResponse> Calculate(SiteRequest request)
        {
            var response = new SiteResponse
            {
                SiteArea = SimpleCalculator.Area(request.Width, request.Length),
                SitePerimeter = SimpleCalculator.Perimeter(request.Width, request.Length)
            };

            if (request.SiteConfiguration is SubDivisionConfiguration siteConfiguration)
            {
                var numberOfLots = SimpleCalculator.NumberOfLots(response.SiteArea, siteConfiguration.SiteCoverage, siteConfiguration.AvgLotSize);

                response.SiteConfigurationResponse = new SubDivisionResponse
                {
                    NumberOfLots = numberOfLots
                };
            }

            return await Task.FromResult(response);
        }
    }
}